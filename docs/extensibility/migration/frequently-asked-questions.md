---
title: "Frequently asked questions about migrating your Visual Studio 2022 extension to your Visual Studio 2022 Preview"
description: Read information and answers to frequently asked questions about migrating Visual Studio extensions to Visual Studio 2022 Preview.
ms.date: 06/08/2021
ms.topic: conceptual
author: leslierichardson95
ms.author: lerich
manager: jmartens
monikerRange: "vs-2022"
ms.workload:
- vssdk
---
# Frequently asked questions about migrating Visual Studio extensions to Visual Studio 2022 Preview

**Q**: My extension does not require any interop changes as it just provides data (i.e. templates), can I create a single extension that includes Dev17 as well?

**A**: Yes!  See [No-code extensions](no-code-extensions.md) for more info about this.

**Q**: A NuGet dependency is bringing in old interop assemblies and causing clashing classes.

**A**: Add the following line to your CS Project to avoid duplicate assemblies:

```xml
    <PackageReference Include="<Name of offending assembly>" ExcludeAssets="compile" PrivateAssets="all" />
```

This will prevent package references from importing the old version of the assembly from other dependencies.

**Q**: My commands and hotkeys are not working in VS after switching my source files to a shared project.

**A**: [Step 2.4](samples.md#step-2---refactor-source-code-into-a-shared-project) of the Image Optimizer sample shows how to add VSCT files as linked items so that they are compiled into your VSCT file.
