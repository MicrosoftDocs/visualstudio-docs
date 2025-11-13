---
title: "Build Office solutions"
description: Learn the differences between building and debugging Office projects and building and debugging other types of projects in Visual Studio, such as Windows Forms.
ms.date: 08/14/2019
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "debugging [Office development in Visual Studio]"
  - "debugging Office applications in Visual Studio"
  - "solutions [Office development in Visual Studio], debugging"
  - "Office applications [Office development in Visual Studio], debugging"
  - "application development [Office development in Visual Studio], building"
  - "Office applications [Office development in Visual Studio], building"
  - "projects [Office development in Visual Studio], debugging"
  - "Office solutions [Office development in Visual Studio], building"
  - "solutions [Office development in Visual Studio], building"
  - "Office projects [Office development in Visual Studio], debugging"
  - "projects [Office development in Visual Studio], building"
  - "builds [Office development in Visual Studio]"
  - "Office projects [Office development in Visual Studio], building"
  - "application development [Office development in Visual Studio], debugging"
  - "Office solutions [Office development in Visual Studio], debugging"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Build Office solutions

  In general, building and debugging Office projects is the same as building and debugging other types of projects in Visual Studio, such as Windows Forms. The topics in this section explain the differences that do exist. For general information about how to build applications, see [Compile and build in Visual Studio](../ide/compiling-and-building-in-visual-studio.md).

[!include[Add-ins note](includes/addinsnote.md)]

## Project output for Office projects
 The output location for Office projects is *projectname*\bin\release or *projectname*\bin\debug. You cannot build to a deployment directory.

### Document-level projects
 When you build a document-level project, the following items are included in the project output:

- A copy of the project document.

- The project assembly and all referenced assemblies that have their **Copy Local** property set to **true**.

- The application manifest, which has the file name extension *.manifest*. For more information, see [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md).

- The deployment manifest, which has the file name extension *.vsto*. For more information, see [Deployment manifests for Office solutions](../vsto/deployment-manifests-for-office-solutions.md).

- A program database (*PDB*) file.

> [!NOTE]
> If you build a document-level solution to a remote location instead of the local computer, add the fully qualified path to the Trusted Locations list in the application's Trust Center. For more information, see the section called Granting Trust to Documents in [Secure Office solutions](../vsto/securing-office-solutions.md).

### Application-level projects
 When you build a VSTO Add-in project, the following items are included in the project output:

- The project assembly and all referenced assemblies that have their **Copy Local** property set to **true**.

- The application manifest, which has the file name extension *.manifest*. For more information, see [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md).

- The deployment manifest, which has the file name extension *.vsto*. For more information, see [Deployment manifests for Office solutions](../vsto/deployment-manifests-for-office-solutions.md).

- A program database (*PDB*) file for the project assembly.

  The build process for VSTO Add-in projects also creates a set of registry entries on the development computer that are required to load the VSTO Add-in. For more information, see [Registry entries for VSTO Add-ins](../vsto/registry-entries-for-vsto-add-ins.md).

  If you build an Outlook VSTO Add-in project that contains form regions, the build process adds the following additional information to the registry:

- A key for each message class that is associated with one or more form regions.

- An entry for each form region and an associated value that represents the name of the Outlook VSTO Add-in.

  Outlook needs this information to load the form regions.

## Referenced assemblies
 You can reference assemblies (including class library projects) from your Building Office Solutions project. Every referenced assembly has a property called **Copy Local**. **Copy Local** indicates whether the assembly is copied to the output directory. By default it is set to **true**. Every referenced assembly that has **Copy Local** set to **true** is copied to the output directory.

## Security during the build process
 Visual Studio automatically configures the security settings on the development computer to grant trust to the solution during the build process. This allows the solution to run while you debug it.

 Office projects use certificates to verify the publisher. Visual Studio automatically creates a temporary certificate to identify Office solutions, and configures the development computer to trust the temporary certificate.

 For more information, see [Secure Office solutions](../vsto/securing-office-solutions.md).

### Network projects
 If the assembly or document location is on a network share, the local (User level) security policy update is not enough to allow the solution to run. An administrator must grant full trust at the Machine level to assemblies and documents that are on a network share before the solution will run. For more information about how to set security policy, see [Secure Office solutions](../vsto/securing-office-solutions.md).

 For document-level projects, you must also add the fully qualified location of the document to the Office trusted folders list. For more information, see [Grant trust to documents](../vsto/granting-trust-to-documents.md).

## Change the platform target
 By default, the platform target for Office projects is **Any CPU**. Typically, you should not change this setting. Office solutions that are built with the **Any CPU** platform target setting run in 32-bit and 64-bit versions of Microsoft  Office 2013  or Office 2010.

 You should set the platform target to x64 only if you are creating a solution that will run only in 64-bit versions of Microsoft  Office 2013  or Office 2010, and your solution calls native 64-bit APIs. For more information about changing the platform target setting, see [How to: Configure projects to target platforms](../ide/how-to-configure-projects-to-target-platforms.md).

 If you set the platform target to x64, the solution will not run in 32-bit versions of Windows or Office. The x64 platform target requires the solution to run in a 64-bit process.

## Use the Clean command
 To remove the built project files from the development computer, you can use the **Clean** command on the **Build** menu in Visual Studio. The **Clean** command deletes all files in the build output location. For application-level projects, the **Clean** command also removes the registry entries that are created by the build process.

## Related topics

|Title|Description|
|-----------|-----------------|
|[Debug Office projects](../vsto/debugging-office-projects.md)|Presents issues involved in debugging Office projects.|
|[Walkthrough: Create your first document-level customization for Excel](../vsto/walkthrough-creating-your-first-document-level-customization-for-excel.md)|Demonstrates how to create a basic document-level customization for Excel.|
|[How to: Re-enable a VSTO Add-in that has been disabled](../vsto/how-to-re-enable-a-vsto-add-in-that-has-been-disabled.md)|Describes how to re-enable a VSTO Add-in that has been hard or soft disabled.|
|[Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md)|Provides links to information about creating Office solutions, and about the role of assemblies in your solution.|
