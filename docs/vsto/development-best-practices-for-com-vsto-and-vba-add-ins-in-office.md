---
title: "Development best practices: COM, VSTO, & VBA add-ins in Office"
description: Learn about the recommended best practices when developing COM, VSTO, and VBA add-ins for Microsoft Office.
titleSuffix: ""
ms.date: "07/25/2017"
ms.topic: best-practice
dev_langs:
  - ""
helpviewer_keywords:
  - ""
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Development best practices for COM, VSTO, and VBA add-ins in Office

  If you are developing COM, VSTO or VBA add-ins for Office, follow the development best practices described in this article.   This will help ensure:

- Compatibility of your add-ins across different versions and deployments of Office.
- Reduced complexity of add-in deployment for your users and IT administrators.
- Unintended installation or runtime failures of your add-in do not occur.

>Note: Using the [Desktop Bridge](/windows/uwp/porting/desktop-to-uwp-root) to prepare your COM, VSTO or VBA add-in for the Windows Store is not supported. COM, VSTO and VBA add-ins cannot be distributed in the Windows Store or the Office Store.

## Do not check for Office during installation
 We don’t recommend having your add-in detect whether Office is installed during the add-in installation process. If Office is not installed, you can install the add-in, and the user will be able to access it after Office is installed.

## Use Embedded Interop Types (NoPIA)
If your solution uses .NET 4.0 or later, use embedded interop types (NoPIA) instead of depending on the Office Primary Interop Assemblies (PIA) redistributable. Using type embedding reduces the installation size of your solution, and ensures future compatibility. Office 2010 was the last version of Office that shipped the PIA redistributable. For more information, see [Walkthrough: Embedding type information from Microsoft Office assemblies](/previous-versions/ee317478(v=vs.140)) and [Type equivalence and embedded interop types](/windows/uwp/porting/desktop-to-uwp-root).

If your solution uses an earlier version of .NET, we recommend that you update your solution to use .NET 4.0 or later. Using .NET 4.0 or later reduces runtime prerequisites on newer versions of Windows.

## Avoid depending on specific Office versions
If your solution uses functionality that is only available in newer versions of Office, verify that the capability exists (if possible, at the feature level) at run time (for example, using exception handling or by checking the version). Validate minimum versions, rather than specific versions, using supported APIs in the object model, such as the [Application.Version property](<xref:Microsoft.Office.Interop.Excel._Application.Version%2A>). We don’t recommend that you rely on Office binary metadata, installation paths, or registry keys because these can change between installations, environments, and versions.

## Enable both 32-bit and 64-bit Office usage
Your default build target should support both 32-bit (x86) and 64-bit (x64), unless your solution depends on libraries that are only available for a specific bitness. The 64-bit version of Office is increasing in adoption, especially in big data environments. Supporting both 32-bit and 64-bit makes it easier for your users to transition between 32-bit and 64-bit versions of Office.

When writing VBA code, use 64-bit safe declare statements and convert variables as appropriate. Additionally, ensure that documents can be shared between users running either 32-bit or 64-bit versions of Office by providing code for each bitness. For more information, see [64-bit Visual Basic for applications overview](/office/vba/Language/Concepts/Getting-Started/64-bit-visual-basic-for-applications-overview).

## Support restricted environments
Your solution should not require User Account Elevation or Administrator privileges. Additionally, the solution should not depend on setting or altering:

- The current working directory.
- DLL load directories.
- The PATH variable.

## Change the save location of shared data and settings
If the solution consists of an add-in and a process that is external to Office, do not use the user’s application data folder or the registry to exchange data or settings between the add-in and the external process. Instead, consider using the user’s temporary folder, documents folder, or your solution’s installation directory.

## Increment the version number with each update
Set the version number of the binaries in your solution and increment it with each update. This will make it easier for users to identify changes between versions and assess compatibility.

## Provide support statements for the latest versions of Office
Customers are asking ISVs to provide support statements for their COM, VSTO and VBA add-ins that run in Office. Listing your explicit support statements helps customers using Microsoft 365 apps for enterprise readiness tools understand your support.

To provide support statements for Office client applications (for example, Word or Excel), first verify that your add-ins run in the current Office release, and then commit to providing updates if your add-in breaks in a future release. You do not have to test your add-ins when Microsoft releases a new build, or an update to Office. Microsoft rarely changes the COM, VSTO and VBA extensibility platform in Office, and these changes will be well documented.

>Important: Microsoft maintains a list of supported add-ins for readiness reports, and ISV contact information. To get your add-in listed, see [/configmgr/desktop-analytics/ready-for-windows](/configmgr/desktop-analytics/ready-for-windows).

## Use Process Monitor to help debug installation or loading issues
If your add-in has compatibility issues during installation or load, they might be related to issues with file or registry access. Use [Process Monitor](/sysinternals/downloads/procmon) or a similar debugging tool to log and compare behavior against a working environment to help identify the problem.
