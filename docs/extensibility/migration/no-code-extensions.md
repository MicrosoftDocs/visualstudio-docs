---
title: No-code extensions
description: Learn about special rules for extensions that do not carry executable code when updating Visual Studio extensions to work with Visual Studio 2022 Preview.
ms.date: 06/08/2021
ms.topic: conceptual
author: leslierichardson95
ms.author: lerich
manager: jmartens
monikerRange: "vs-2022"
ms.workload:
- vssdk
---
# No-code extensions

[!INCLUDE(preview-note)](./includes/preview-note.md)

VS extensions that do not carry executable code are not required to pack distinct VSIXs for Visual Studio 2022 and pre-Visual Studio 2022.

Instead, the one VSIX should be modified so that its `source.extension.vsixmanifest` file
declares two installation targets, like this:

```xml
<Installation>
   <InstallationTarget Id="Microsoft.VisualStudio.Community" Version="[15.0,17.0)">
      <ProductArchitecture>x86</ProductArchitecture>
   </InstallationTarget>
   <InstallationTarget Id="Microsoft.VisualStudio.Community" Version="[17.0,18.0)">
      <ProductArchitecture>amd64</ProductArchitecture>
   </InstallationTarget>
</Installation>
```

You can skip the steps outlined elsewhere on this wiki about using shared projects and multiple VSIXs.
