# Overview [![NuGet](https://img.shields.io/nuget/v/CommitHash.svg)](https://www.nuget.org/packages/CommitHash) [![Actions Status](https://github.com/stop-cran/CommitHashAttribute/workflows/.NET%20Core/badge.svg)](https://github.com/stop-cran/CommitHashAttribute/actions)

This package provieds a simple attribute to track source code commit hash in created executables.

# Installation

NuGet package is available [here](https://www.nuget.org/packages/CommitHash/).

```PowerShell
PM> Install-Package CommitHash
```

# Example

```C#
[assembly:CommitHash("e040025f0613f1f4433468b2d33bfc72aaa60959")]
```