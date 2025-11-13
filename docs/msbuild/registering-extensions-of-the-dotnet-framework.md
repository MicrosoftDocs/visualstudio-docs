---
title: Registering Extensions of the .NET Framework
description: Learn how to add a folder containing an assembly that extends a specific version of the .NET Framework to the system registry.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- Add References dialog box, registering extensions of the .NET Framework
- MSBuild, registering extensions of the .NET Framework
- .NET Framework extensions, registering
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Register extensions of the .NET Framework

You can develop an assembly that extends a specific version of the .NET Framework. To enable the assembly to appear in the Visual Studio **Add References** dialog box, you must add the folder that contains it to the system registry.

 For example, assume that the Trey Research company has developed a library that extends the .NET Framework 4, and wants the library assemblies to appear in the **Add References** dialog box when a project targets the .NET Framework 4. Also assume that the assemblies are 32-bit assemblies running on a 32-bit computer or 64-bit assemblies running on a 64-bit computer, and that they will be installed in the *C:\TreyResearch\Extensions4\\* folder.

 Register this folder by using this key: **HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\\.NETFramework\v4.0.30319\AssemblyFoldersEx\TreyResearch\\**. Give the key this default value: **C:\TreyResearch\Extensions4**.

> [!NOTE]
> The build number of the .NET Framework version may be different.

 To register a 32-bit assembly on a 64-bit computer, use the Wow6432 node, for example: **HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\\.NETFramework\v4.0.30319\AssemblyFoldersEx\TreyResearch\\**.

### Related content

- [Visual Studio integration](../msbuild/visual-studio-integration-msbuild.md)
