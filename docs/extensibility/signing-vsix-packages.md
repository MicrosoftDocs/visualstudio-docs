---
title: Signing VSIX Packages | Microsoft Docs
description: Learn about signing extension assemblies. The VSIX installer displays a message that a VSIX is signed and information about the signature itself.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- signature
- signing
- authenticode
- vsix
- packages
ms.assetid: e34cfc2c-361c-44f8-9cfe-9f2be229d248
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Signing VSIX Packages
Extension assemblies do not need to be signed before they can run in Visual Studio, but it is a good practice to do so.

 If you want to secure your extension and make sure it hasn't been tampered with, you can add a digital signature to a VSIX package. When a VSIX is signed, the VSIX installer will display a message indicating that it is signed, plus more information about the signature itself. If the contents of the VSIX have been modified, and the VSIX has not been signed again, the VSIX installer will show that the signature is not valid. The installation is not stopped, but the user is warned.

> [!IMPORTANT]
> Beginning with Visual Studio 2015, VSIX packages signed using anything other than SHA256 encryption will be identified as having an invalid signature. VSIX installation is not blocked but the user will be warned.

## Signing a VSIX with VSIXSignTool
 There is a SHA256 encryption signing tool available from [VisualStudioExtensibility](https://www.nuget.org/profiles/VisualStudioExtensibility) on nuget.org at [VsixSignTool](https://www.nuget.org/packages/Microsoft.VSSDK.Vsixsigntool).

#### To use the VSIXSignTool

1. Add your VSIX to a project.

2. Right click on the project node in Solution Explorer, selecting **Add &#124; Manage NuGet Packages**.  For more information on NuGet and adding NuGet packages see the [NuGet documentation](/NuGet) and [Package Manager UI](/NuGet/Tools/Package-Manager-UI) topics.

3. Search for VSIXSignTool from VisualStudioExtensibility and install the NuGet package.

4. You can now run the VSIXSignTool from the project's local packages location. Consult the tool's command line help for your signing scenario (VSIXSignTool.exe /?).

   For example to sign with a password protected certificate file:

   VSIXSignTool.exe sign /f \<certfile> /p \<password> \<VSIXfile>

## See also
- [Shipping Visual Studio Extensions](../extensibility/shipping-visual-studio-extensions.md)
