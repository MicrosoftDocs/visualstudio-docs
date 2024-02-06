---
title: Enable debugging and diagnostics with Source Link
description: Enable Source Link in your .NET project to improve debugging and diagnostics, where the debugger downloads underlying source files as you step into sections of code.
ms.date: 08/09/2022
ms.topic: how-to
dev_langs: 
  - CSharp
  - VB
helpviewer_keywords: 
  - source link, debugging, diagnostics
author: poppastring
ms.author: madownie
ms.subservice: debug-diagnostics
---

# Enable debugging and diagnostics with Source Link

Source Link is a technology that enables first-class source debugging experiences for binaries. With Source Link-enabled libraries, the debugger can [download the underlying source files](https://devblogs.microsoft.com/dotnet/improving-debug-time-productivity-with-source-link/) as you step in, and you can set breakpoints/tracepoints like you would with any other source. It also enables analysis tools to easily find the correct source code when debugging production environments like Azure.

You can enable Source Link experience in your own .NET project by setting a few properties and adding a PackageReference to a Source Link package:

```xml
<Project Sdk="Microsoft.NET.Sdk">
 <PropertyGroup>
    <TargetFramework>netcoreapp2.1</TargetFramework>
 
    <!-- Optional: Publish the repository URL in the built .nupkg (in the NuSpec <Repository> element) -->
    <PublishRepositoryUrl>true</PublishRepositoryUrl>
 
    <!-- Optional: Embed source files that are not tracked by the source control manager in the PDB -->
    <EmbedUntrackedSources>true</EmbedUntrackedSources>
  
    <!-- Optional: Build symbol package (.snupkg) to distribute the PDB containing Source Link -->
    <IncludeSymbols>true</IncludeSymbols>
    <SymbolPackageFormat>snupkg</SymbolPackageFormat>
  </PropertyGroup>
  <ItemGroup>
    <!-- This assumes GitHub source control but other repo options are available --> 
    <PackageReference Include="Microsoft.SourceLink.GitHub" Version="1.1.1" PrivateAssets="All"/>
  </ItemGroup>
</Project>
```

## Sharing symbols

Once you have enabled Source Link in your project, you'll need to ensure that the symbol files (PDB) created during the build process are available to Visual Studio (or your analysis tool). You can distribute PDBs alongside your application (or in the NuGet package). Alternatively you can embed the symbol file in the application or assembly with the following project setting.

```xml
<DebugType>embedded</DebugType>
```

If your application is distributed as a library via a package published to NuGet.org, it's recommended to build a symbol package and publish it to NuGet.org as well. Symbols available on the NuGet.org symbol server allow the debugger to download it when needed.

> [!NOTE]
> Embedding symbols isn't always recommended for NuGet packages because it increases the size, and thus the restore time for projects that consume your package.

## Alternative source control providers

Source Link packages are available for multiple source control providers:

- [github.com and GitHub Enterprise](https://github.com/dotnet/sourcelink#githubcom-and-github-enterprise)
- [Azure Repos (former Visual Studio Team Services)](https://github.com/dotnet/sourcelink#azure-repos-former-visual-studio-team-services)
- [Azure DevOps Server (former Team Foundation Server)](https://github.com/dotnet/sourcelink#azure-devops-server-former-team-foundation-server)
- [GitLab](https://github.com/dotnet/sourcelink#gitlab)
- [Bitbucket](https://github.com/dotnet/sourcelink#bitbucket)

## Related content
- [Source Link](/dotnet/standard/library-guidance/sourcelink)
- [Specify symbol (.pdb) and source files in the debugger](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md)
- [Improving Debug-time Productivity with Source Link](https://devblogs.microsoft.com/dotnet/improving-debug-time-productivity-with-source-link/)
