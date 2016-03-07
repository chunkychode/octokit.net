using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Threading.Tasks;
#if NET_45
using System.Collections.ObjectModel;
#endif

namespace Octokit
{
    /// <summary>
    /// Used to paginate through API response results.
    /// </summary>
    /// <remarks>
    /// This is meant to be internal, but I factored it out so we can change our mind more easily later.
    /// </remarks>
    public class ApiPagination : IApiPagination
    {
        public async Task<IReadOnlyList<T>> GetAllPages<T>(Func<Task<IReadOnlyPagedCollection<T>>> getFirstPage, Uri uri)
        {
            Ensure.ArgumentNotNull(getFirstPage, "getFirstPage");
            try
            {
                var page = await getFirstPage().ConfigureAwait(false);

                var allItems = new List<T>(page);
                if (page != null)
                {
                    while (page != null && (page = await page.GetNextPage().ConfigureAwait(false)) != null)
                    {
                        allItems.AddRange(page);
                    }
                }
                return new ReadOnlyCollection<T>(allItems);
            }
            catch (NotFoundException)
            {
                throw new NotFoundException(
                    string.Format(CultureInfo.InvariantCulture, "{0} was not found.", uri.OriginalString), HttpStatusCode.NotFound);
            }
        }
        public async Task<IReadOnlyList<T>> GetAllPagesUntil<T>(Func<Task<IReadOnlyPagedCollection<T>>> getFirstPage, Uri uri, Func<IReadOnlyCollection<T>, bool> until)
        {
            Ensure.ArgumentNotNull(getFirstPage, "getFirstPage");
            try
            {
                var page = await getFirstPage().ConfigureAwait(false);

                var allItems = new List<T>();
                if (page!=null && !until(page))
                {
                    allItems.AddRange(page);
                    while (page != null && (page = await page.GetNextPage().ConfigureAwait(false)) != null)
                        if (!until(page))
                        {
                            allItems.AddRange(page);
                            while (page != null && (page = await page.GetNextPage().ConfigureAwait(false)) != null)
                            {
                                allItems.AddRange(page);
                                if (!until(page))
                                    break;
                            }
                        }
                        else
                            break;
                }
                return new ReadOnlyCollection<T>(allItems);
            }
            catch (NotFoundException)
            {
                throw new NotFoundException(
                    string.Format(CultureInfo.InvariantCulture, "{0} was not found.", uri.OriginalString), HttpStatusCode.NotFound);
            }

        }
    }
}