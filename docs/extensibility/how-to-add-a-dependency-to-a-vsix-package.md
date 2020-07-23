---
title: 'How to: Add a Dependency to a VSIX Package | Microsoft Docs'
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- package reference
- package assembly
- package dll
- vsix reference
ms.assetid: 8f20177b-dab9-43a3-b959-81a591b451d6
author: acangialosi
ms.author: anthc
manager: jillfra
ms.workload:
- vssdk
---
# How to: Add a dependency to a VSIX package

You can set up a VSIX package deployment that installs any dependencies that are not already present on the target computer. To accomplish this, include the VSIX dependencies to the *source.extension.vsixmanifest* file.

## To add a dependency

1. Open the *source.extension.vsixmanifest* file in the **Design** view. Go to the **Dependencies** tab and click **New**.

2. To add an installed extension: in the **Add New Dependency** dialog box, select **Installed extension** and then, for the **Name**, select an extension on the list.

3. To add another VSIX that is not installed: in the **Add New Dependency** dialog box, select **File on file system** and then use the **Browse** button to select the VSIX.

## Require a specific Visual Studio release

If your extension requires a specific version of Visual Studio 2017, for example, it depends on a feature released in 15.3, you can specify the build number in your VSIX **InstallationTarget**. For example, release 15.3 has a build number of '15.0.26730.3'. You can see the mapping of releases to build numbers [here](../install/visual-studio-build-numbers-and-release-dates.md). Note that using the release number '15.3' will not work correctly.

If your extension requires 15.3 or higher, you would declare the **InstallationTarget Version** as [15.0.26730.3, 16.0):

```xml
<Installation>
  <InstallationTarget Id="Microsoft.VisualStudio.Community" Version="[15.0.26730.3, 16.0)" />
</Installation>
```

The VSIXInstaller will detect earlier versions of Visual Studio and inform the user that a later update is required.

## See also

- [VSIX extension schema 1.0 reference](https://msdn.microsoft.com/library/76e410ec-b1fb-4652-ac98-4a4c52e09a2b)
- [Anatomy of a VSIX package](../extensibility/anatomy-of-a-vsix-package.md)
- [Prepare extensions for Windows Installer deployment](../extensibility/preparing-extensions-for-windows-installer-deployment.md)
