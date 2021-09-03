---
title: Create file associations (ClickOnce app)
description: Learn how to associate a ClickOnce application with one or more file name extensions, so that the application starts when the user opens such a file.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - file associations, ClickOnce applications
  - ClickOnce deployment, file associations
ms.assetid: 835230c8-3177-440f-85e3-e40f1d8b4f9d
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
ms.workload: 
  - multiple
---
# How to: Create file associations for a ClickOnce application
[!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] applications can be associated with one or more file name extensions, so that the application will be started automatically when the user opens a file of those types. Adding file name extension support to a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application is straightforward.

### To create file associations for a ClickOnce application

1. Create a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application normally, or use your existing [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application.

2. Open the application manifest with a text or XML editor, such as Notepad.

3. Find the `assembly` element. For more information, see [ClickOnce application manifest](../deployment/clickonce-application-manifest.md).

4. As a child of the `assembly` element, add a `fileAssociation` element. The `fileAssociation` element has four attributes:

   - `extension`: The file name extension you want to associate with the application.

   - `description`: A description of the file type, which will appear in the Windows shell.

   - `progid`: A string uniquely identifying the file type, to mark it in the registry.

   - `defaultIcon`: An icon to use for this file type. The icon must be added as a file resource in the application manifest. For more information, see [How to: Include a Data File in a ClickOnce Application](../deployment/how-to-include-a-data-file-in-a-clickonce-application.md).

     For an example of the `file` and `fileAssociation` elements, see [\<fileAssociation> Element](../deployment/fileassociation-element-clickonce-application.md).

5. If you want to associate more than one file type with the application, add additional `fileAssociation` elements. Note that the `progid` attribute should be different for each.

6. Once you have finished with the application manifest, re-sign the manifest. You can do this from the command line by using *Mage.exe*.

    `mage -Sign WindowsFormsApp1.exe.manifest -CertFile mycert.pfx`

    For more information, see [Mage.exe (Manifest Generation and Editing Tool)](/dotnet/framework/tools/mage-exe-manifest-generation-and-editing-tool).

## See also
- [\<fileAssociation> element](../deployment/fileassociation-element-clickonce-application.md)
- [ClickOnce application manifest](../deployment/clickonce-application-manifest.md)
- [Mage.exe (Manifest Generation and Editing Tool)](/dotnet/framework/tools/mage-exe-manifest-generation-and-editing-tool)