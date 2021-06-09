---
title: Publish your extension for Visual Studio 2022 Preview
description: Learn how to make your updated Visual Studio extension available for Visual Studio 2022 Preview.
ms.date: 06/08/2021
ms.topic: conceptual
author: leslierichardson95
ms.author: lerich
manager: jmartens
monikerRange: "vs-2022"
ms.workload:
- vssdk
---
# Publish your Visual Studio 2022 extension

[!INCLUDE(preview-note)](./includes/preview-note.md)

Great, so you've [added a Visual Studio 2022 target](add-Visual Studio 2022-target.md) to your extension and [tested](testing.md) it.
Now you are ready to publish the extension for the world to admire.

## Visual Studio Marketplace

Publishing your extension to the [Visual Studio Marketplace](https://marketplace.visualstudio.com/) is a great way to get new users to find and install your extension.
Whether your extension targets Visual Studio 2022 exclusively or targets older VS versions too, the Marketplace is there to support you.

In the future the Marketplace will allow you to upload multiple VSIXs to just one Marketplace listing,
allowing you to upload your Visual Studio 2022-targeted VSIX and a pre-Visual Studio 2022 VSIX. Your users will automatically get the right VSIX for the VS version they have installed, when using the VS extension manager.

For the preview releases of Visual Studio 2022 the Marketplace will only support a single VSIX file per Marketplace listing. While Visual Studio 2022 is in preview we encourage you to have a separate Visual Studio 2022 only Marketplace listing for your extension. That way you can iterate your Visual Studio 2022 extension as needed without impacting your customers on earlier versions of Visual Studio. You can also mark the extension as 'preview' to set the expectation it will be likely be less reliable, even the source of that unreliability is Visual Studio 2022, than your mainstream extension.

## Custom installer

If you build an MSI/EXE to install your extension and spawn vsixinstaller.exe to install (part of) your extension,
know that the VSIX installer in Visual Studio 2022 has been updated. Developers will need to use the version of the VSIX
installer that comes with Visual Studio 2022 to install extensions to Visual Studio 2022. The VSIX installer in Visual Studio 2022 will also install
applicable extensions targeting previous versions of Visual Studio that are installed side by side with Visual Studio 2022 on the same machine.

## Network share

You can share your extension over a LAN or any other way. If you target Visual Studio 2022 and pre-Visual Studio 2022, you will need to share you multiple VSIXs individually and give them filenames (or place them in unique folders) that help your users know which VSIX to install based on the version of VS they have installed.

## Other considerations

### Dependencies

If your VSIX specifies another VSIX as a dependency via the
`<dependency>` element each referenced VSIX needs to install in the same targets and product architectures as your VSIX. If a dependent VSIX does not support the targeted installation of Visual Studio your VSIX will fail. It's ok for the dependent VSIX to support more targets and architectures than yours, just not less. This will likely mean the deployment and distribution approach of VSIX with dependencies should
mirror that of their dependents.
