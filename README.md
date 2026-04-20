# multi-dot-net

Sample multi-project .NET solution used to test cache intelligence in [drone-meltwater-cache](https://github.com/drone-plugins/drone-meltwater-cache).

## Structure

```
multi-dot-net/
├── ProjectA/           # Console app (references ProjectB)
│   ├── ProjectA.csproj
│   └── Program.cs
├── ProjectB/           # Class library (uses Newtonsoft.Json)
│   ├── ProjectB.csproj
│   └── Greeter.cs
└── multi-dot-net.sln
```

## Purpose

This repo demonstrates the scenario where cache intelligence must detect **multiple** `.csproj` files across sibling directories and cache a single shared `.nuget/packages` location at the common ancestor (repo root), rather than only caching one project's packages.

Related Jira: [CI-16621](https://harness.atlassian.net/browse/CI-16621)
