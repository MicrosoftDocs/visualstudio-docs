---
title: Modernize your VSIX projects
description: Learn how to use the latest features and best practices when updating your Visual Studio extension to work with Visual Studio 2022.
ms.date: 06/08/2021
ms.topic: conceptual
author: leslierichardson95
ms.author: lerich
manager: jmartens
monikerRange: "vs-2022"
ms.workload:
- vssdk
---
# Modernize your VSIX projects

Before adding Dev17 support to your extension,
we strongly recommend taking this time to clean up and modernize your existing project before going further, including:

1. [Migrate from packages.config to `PackageReference`](/nuget/consume-packages/migrate-packages-config-to-package-reference).

1. Replace any direct assembly VS SDK assembly references with PackageReference items.

   ```diff
   -<Reference Include="Microsoft.VisualStudio.OLE.Interop" />
   +<PackageReference Include="Microsoft.VisualStudio.OLE.Interop" Version="..." />
   ```

   Tip: you can replace *many* assembly references with just *one* PackageReference to our metapackage:

   ```diff
   -<Reference Include="Microsoft.VisualStudio.OLE.Interop" />
   -<Reference Include="Microsoft.VisualStudio.Interop" />
   -<Reference Include="Microsoft.VisualStudio.Interop.8.0" />
   +<PackageReference Include="Microsoft.VisualStudio.Sdk" Version="..." />
   ```

   Be sure to pick package versions that match the minimum version of VS you are targeting.

   Note that some assemblies that are not unique to the VS SDK (for example, Newtonsoft.Json.dll)
   may have been discoverable through a simple `<Reference Include="Newtonsoft.Json" />`
   reference before Dev17 but in Dev17 requires a package reference instead because in Dev17
   we remove some VS runtime and SDK directories from MSBuild's default assembly search path.

   Note that in switching from direct assembly references to NuGet package references,
   you may pick up additional assembly references and analyzer packages due to NuGet automatically
   installing the transitive closure of dependencies.
   This is generally a Good Thing, but may result in additional warnings being flagged during your build.
   Please work through these and resolve as many as you can, and consider suppressing those you cannot
   using in-code `#pragma warning disable <id>` regions.

Now you're ready to [use shared projects](shared-projects.md) to prepare for adding a Dev17 target to you extension.
