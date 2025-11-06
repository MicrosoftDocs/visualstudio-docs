---
title: 'Update a Visual Studio Extension'
description: Update a Visual Studio extension on your system by using the Extensions and Updates options to install the updated version.
ms.date: 11/5/2025
ms.topic: how-to
helpviewer_keywords:
- update package
- update extension
- new package version
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Update a Visual Studio extension

You can update a Visual Studio extension on your system by using **Extensions and Updates** to install the updated version. If you create an updated version of an extension, you can signify it as updated by incrementing the version number in the VSIX manifest.

 Updates are installed when the VSIX manifest of the incoming extension has the same `ID` as the installed one and a higher `Version` number. If the `Version` number is the same or lower, the package can't be installed. If the `ID` values don't match, the package that is not yet installed is recognized as a separate extension.

 To help prevent conflicts during development, we recommend that you uninstall earlier versions of extensions in progress, and also uninstall or disable any other potentially conflicting extensions.

> [!NOTE]
> If you're an extension developer, you can find information about how to upgrade your extensions to work with the latest version of Visual Studio [here](./migration/update-visual-studio-extension.md).

## To update an extension on your system

1. On the **Tools** menu, click **Extensions and Updates**.

2. In the left pane, click **Updates**.

3. In the middle pane, click the update you want to install.

     The version number of the updated extension is displayed in the right pane, together with other information.

4. At the bottom of the right pane, click **Update**.

## Related content

- [Anatomy of a VSIX package](../extensibility/anatomy-of-a-vsix-package.md)
- [Find and using Visual Studio extensions](../ide/finding-and-using-visual-studio-extensions.md)
