---
title: "Office primary interop assemblies"
description: Use the primary interop assembly (PIA) to gain access the features of a Microsoft Office application from an Office project.
ms.date: "12/23/2021"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "primary interop assemblies"
  - "assemblies [Office development in Visual Studio], primary interop assemblies"
  - "Office primary interop assemblies"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Office primary interop assemblies

To use the features of a Microsoft Office application from an Office project, you must use the primary interop assembly (PIA) for the application. The PIA enables managed code to interact with a Microsoft Office application's COM-based object model.

[!include[Add-ins note](includes/addinsnote.md)]

When you create a new Office project, Visual Studio adds references to the PIAs that are required to build the project. In some scenarios, you might need to add references to other PIAs (for example, you can use a feature of Microsoft Office Word in a project for Microsoft Office Excel).

This article describes the following aspects of using the Microsoft Office PIAs in Office projects:

- [Separate primary interop assemblies to build and run projects](#separateassemblies)

- [Use features of multiple Microsoft Office applications in a single project](#usingfeatures)

- [Full list of primary interop assemblies for Microsoft Office applications](#pialist)

For more information about primary interop assemblies, see [Primary interop assemblies](/previous-versions/dotnet/netframework-4.0/aax7sdch(v=vs.100)).

<a name="separateassemblies"></a>

## Separate primary interop assemblies to build and run projects

Visual Studio uses different sets of the PIAs on the development computer. These different sets of assemblies are in the following locations:

- A folder in the program files directory

  This set of the assemblies is used when you write code and build projects. Visual Studio installs these assemblies automatically.

- The global assembly cache

  This set of the assemblies is used during some development tasks, such as when you run or debug projects. Visual Studio doesn't install and register these assemblies; you need to do it yourself.

### Primary interop assemblies in the program files directory

The PIAs are automatically added to a location in the file system, outside of the global assembly cache, while you install Visual Studio. When you create a new project, Visual Studio automatically adds references to these copies of the PIAs to your project. Visual Studio uses these copies of the PIAs, instead of the assemblies in the global assembly cache, to resolve type references when you develop and build your project.

When different versions of the PIAs are registered in the global assembly cache, you can face several development issues. The added copies of PIAs will help you to avoid such issues.

For Visual Studio 2017 and later, these copies of the PIAs are installed to following shared locations on the development computer:

- `%ProgramFiles%\Microsoft Visual Studio\Shared\Visual Studio Tools for Office\PIA\`

- (or `%ProgramFiles(x86)%\Microsoft Visual Studio\Shared\Visual Studio Tools for Office\PIA\` on 64-bit operating systems)

> [!NOTE]
> For older versions of Visual Studio, these PIAs will be installed to the Visual Studio Tools for Office\PIA folder under the `%ProgramFiles%` folder for that version of Visual Studio.
> For Example: `%ProgramFiles(x86)%\Microsoft Visual Studio 14.0\Visual Studio Tools for Office\PIA\`

### Primary interop assemblies in the global assembly cache

To perform certain development tasks, the PIAs must be installed and registered in the global assembly cache on the development computer. Typically, the PIAs are installed automatically when you install Office on the development computer. For more information, see [Configure a computer to develop Office solutions](../vsto/how-to-configure-a-computer-to-develop-office-solutions.md).

The Office PIAs aren't required on end-user computers to run Office solutions. For more information, see [Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md).

<a name="usingfeatures"></a>

## Use features of multiple Microsoft Office applications in a single project

Every Office project template in Visual Studio is designed to work with a single Microsoft Office application. To use features in multiple Microsoft Office applications, or to use features in an application or component that doesn't have a project in Visual Studio, you must add a reference to the required PIAs.

In most cases, you should add references to the PIAs that are installed by Visual Studio under the `%ProgramFiles(x86)%\Microsoft Visual Studio\Shared\Visual Studio Tools for Office\PIA\` directory. These versions of the assemblies appear on the **Framework** tab of the **Reference Manager** dialog box. For more information, see [How to: Target Office applications through primary interop assemblies](../vsto/how-to-target-office-applications-through-primary-interop-assemblies.md).

If you've installed and registered the PIAs in the global assembly cache, these versions of the assemblies appear on the **COM** tab of the **Reference Manager** dialog box. Avoid adding references to these versions of the assemblies, because there are some development issues that can occur when you use them. For example, if you've registered different versions of the PIAs in the global assembly cache, your project will automatically bind to the version of the assembly that was registered last, even if you specify a different version of the assembly on the **COM** tab of the **Reference Manager** dialog box.

> [!NOTE]
> Some assemblies are added to a project automatically when an assembly that references them is added. For example, references to the `Office.dll` and `Microsoft.Vbe.Interop.dll` assemblies are added automatically when you add a reference to the Word, Excel, Outlook, Microsoft Forms, or Graph assemblies.

<a name="pialist"></a>

## Primary interop assemblies for Microsoft Office applications

The following table lists the primary interop assemblies that are available for  Office 2016, Office 2013, and Office 2010.

<br/>

|Office application or component|Primary interop assembly name|
|-------------------------------------|-----------------------------------|
|Microsoft Access 14.0 Object Library<br /><br /> Microsoft Access 15.0 Object Library|Microsoft.Office.Interop.Access.dll|
|Microsoft Office 14.0 Access Database Engine Object Library<br /><br /> Microsoft Office 15.0 Access Database Engine Object Library|Microsoft.Office.Interop.Access.Dao.dll|
|Microsoft Excel 14.0 Object Library<br /><br /> Microsoft Excel 15.0 Object Library|[Microsoft.Office.Interop.Excel.dll](/dotnet/api/microsoft.office.interop.excel?view=excel-pia&preserve-view=true)|
|Microsoft Graph 14.0 Object Library (used by PowerPoint, Access, and Word for graphs)<br /><br /> Microsoft Graph 15.0 Object Library|Microsoft.Office.Interop.Graph.dll|
|Microsoft InfoPath 2.0 Type Library (for InfoPath 2007 only)|[Microsoft.Office.Interop.InfoPath.dll](/dotnet/api/microsoft.office.interop.infopath?view=infopath-form&preserve-view=true)|
|Microsoft InfoPath XML Interop Assembly (for InfoPath 2007 only)|Microsoft.Office.Interop.InfoPath.Xml.dll|
|Microsoft Office 14.0 Object Library (Office shared functionality)<br /><br /> Microsoft Office 15.0 Object Library (Office shared functionality)|office.dll|
|Microsoft Office Outlook View Control (can be used in Web pages and applications to access your Inbox)|Microsoft.Office.Interop.OutlookViewCtl.dll|
|Microsoft Outlook 14.0 Object Library<br /><br /> Microsoft Outlook 15.0 Object Library|[Microsoft.Office.Interop.Outlook.dll](/dotnet/api/microsoft.office.interop.outlook?view=outlook-pia&preserve-view=true)|
|Microsoft PowerPoint 14.0 Object Library<br /><br /> Microsoft PowerPoint 15.0 Object Library|Microsoft.Office.Interop.PowerPoint.dll|
|Microsoft Project 14.0 Object Library<br /><br /> Microsoft Project 15.0 Object Library|[Microsoft.Office.Interop.MSProject.dll](/dotnet/api/microsoft.office.interop.msproject?view=office-project-server&preserve-view=true)|
|Microsoft Publisher 14.0 Object Library<br /><br /> Microsoft Publisher 15.0 Object Library|Microsoft.Office.Interop.Publisher.dll|
|Microsoft SharePoint Designer 14.0 Web Object Reference Library|Microsoft.Office.Interop.SharePointDesigner.dll|
|Microsoft SharePoint Designer 14.0 Page Object Reference Library|Microsoft.Office.Interop.SharePointDesignerPage.dll|
|Microsoft Smart Tags 2.0 Type Library **Note:**  Smart tags are deprecated in  Excel 2010 and Word 2010.|Microsoft.Office.Interop.SmartTag.dll|
|Microsoft Visio 14.0 Type Library<br /><br /> Microsoft Visio 15.0 Type Library|Microsoft.Office.Interop.Visio.dll|
|Microsoft Visio 14.0 Save As Web Type Library<br /><br /> Microsoft Visio 15.0 Save As Web Type Library|Microsoft.Office.Interop.Visio.SaveAsWeb.dll|
|Microsoft Visio 14.0 Drawing Control Type Library<br /><br /> Microsoft Visio 15.0 Drawing Control Type Library|Microsoft.Office.Interop.VisOcx.dll|
|Microsoft Word 14.0 Object Library<br /><br /> Microsoft Word 15.0 Object Library|[Microsoft.Office.Interop.Word.dll](/dotnet/api/microsoft.office.interop.word?view=word-pia&preserve-view=true)|
|Microsoft Visual Basic for Applications Extensibility 5.3|Microsoft.Vbe.Interop.dll|

### Binding redirect assemblies

When you install and register the Office PIAs in the global assembly cache (either with Office or by installing the redistributable package for the PIAs), the binding redirect assemblies are also installed only in the global assembly cache. These assemblies ensure that the correct version of the primary interop assemblies is loaded at run time.

For example, when a solution that references an Office 2010 assembly runs on a computer that has the  Office 2013  version of the same primary interop assembly, the binding redirect assembly instructs the .NET Framework runtime to load the  Office 2013  version of the primary interop assembly.

For more information, see [How to: Enable and disable automatic binding redirection](/dotnet/framework/configure-apps/how-to-enable-and-disable-automatic-binding-redirection).

## Related content

- [How to: Target Office applications through primary interop assemblies](../vsto/how-to-target-office-applications-through-primary-interop-assemblies.md)
- [Excel object model overview](../vsto/excel-object-model-overview.md)
- [InfoPath solutions](../vsto/infopath-solutions.md)
- [Outlook object model overview](../vsto/outlook-object-model-overview.md)
- [PowerPoint solutions](../vsto/powerpoint-solutions.md)
- [Project solutions](../vsto/project-solutions.md)
- [Visio object model overview](../vsto/visio-object-model-overview.md)
- [Word object model overview](../vsto/word-object-model-overview.md)
- [General reference &#40;Office development in Visual Studio&#41;](../vsto/general-reference-office-development-in-visual-studio.md)
