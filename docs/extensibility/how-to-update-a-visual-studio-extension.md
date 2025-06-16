---
title: 'Update a Visual Studio Extension'
description: Update a Visual Studio extension on your system by using the Extensions and Updates options to install the updated version.
ms.date: 02/02/2024
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

## To update an extension on your system

1. On the **Tools** menu, click **Extensions and Updates**.

2. In the left pane, click **Updates**.

3. In the middle pane, click the update you want to install.

     The version number of the updated extension is displayed in the right pane, together with other information.

4. At the bottom of the right pane, click **Update**.

## To publish an update of an extension

1. In Visual Studio, open the solution for the extension you want to update. Make the changes.

    > [!IMPORTANT]
    > Unsigned all user extensions don't get updated automatically. You should always sign your extensions.

2. In **Solution Explorer**, open *source.extension.manifest*.

3. In the manifest designer, increase the value of the number in the **Version** field.

4. Save the solution and build it.

5. Upload the new `.vsix` file (in the `\bin\Debug\` folder of the project) to the [Visual Studio Marketplace](https://marketplace.visualstudio.com/vs) Web site.

     When a user who has an earlier version of the extension opens **Extensions and Updates**, the new version  appears in the **Updates** list, if the tool is set to automatically look for updates.

     You can enable or disable automatic checking for updates at the bottom of the **Updates** pane (**Enable/disable automatic detection of available updates**), which changes the **Check for updates** setting in **Tools** > **Options** > **Environment** > **Extensions and Updates**.

     You can specify (in **Tools** > **Options** > **Environment** > **Extensions and Updates**) whether you want automatic updates for per-user extensions, all user extensions or both (the default setting).

## Related content

- [Anatomy of a VSIX package](../extensibility/anatomy-of-a-vsix-package.md)
- [Find and using Visual Studio extensions](../ide/finding-and-using-visual-studio-extensions.md)
