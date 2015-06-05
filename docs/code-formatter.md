# Coding Style

The coding style for Octokit is based on the defaults that the .NET team have
defined over in their repository:

https://github.com/dotnet/corefx/blob/master/Documentation/coding-style.md

There are a couple of places where we've deviated from them:

- No copyright headers for files
- No newline above using statements (likely relates to previous rule)
- No explicit visibility for members
- Private field naming style

Rather that outline all these rules, there's a code formatter tool which
can be run against the codebase to ensure everything is consistent.

You need VS2015 to run it, but it's available from the root of the repository:

```
.\build FormatCode
```

We'll likely run the formatter periodically anyway, but you're more than
welcome to run this as part of contributing changes.
