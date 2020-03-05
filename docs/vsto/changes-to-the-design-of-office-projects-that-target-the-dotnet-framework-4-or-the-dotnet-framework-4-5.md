---
title: "Design changes to Office projects targeting .NET Framework"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office development in Visual Studio 2010, what's new"
  - "what's new [Office development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Changes to the design of Office projects that target the .NET Framework 4 or the .NET Framework 4.5
  Starting in [!INCLUDE[vs_dev10_long](../sharepoint/includes/vs-dev10-long-md.md)], Visual Studio introduced some changes to the design of Office projects that target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later. If you are familiar with Office projects in previous versions of Visual Studio, you should be aware of these changes before you develop Office projects that target those versions of the .NET Framework 4.0 or later. By default, all projects that you create by using Visual Studio 2013 or later target the .NET Framework 4.0 or later.

 The following sections describe these Office project design changes.

## Understand the interface-based design of the Visual Studio 2010 Tools for Office runtime
 When you develop an Office project that targets the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later, most of the types that you use in the Visual Studio 2010 Tools for Office runtime are interfaces. This is a major change from previous versions of the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)], where these types are classes. For example, when you target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later, the <xref:Microsoft.Office.Tools.Excel.Worksheet> and <xref:Microsoft.Office.Tools.Word.Document> types are interfaces instead of classes. For more information, see [Visual Studio Tools for Office runtime overview](../vsto/visual-studio-tools-for-office-runtime-overview.md).

 For any types that you could instantiate directly in previous versions of the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)], you now use methods of the `Globals.Factory` object to get instances of these types. For example, to get an object that implements the <xref:Microsoft.Office.Tools.Excel.SmartTag> interface, use the `Globals.Factory.CreateSmartTag` method. For more information, see the following topics:

- [Update Excel and Word projects that you migrate to the .NET Framework 4 or the .NET Framework 4.5](../vsto/updating-excel-and-word-projects-that-you-migrate-to-the-dotnet-framework-4-or-the-dotnet-framework-4-5.md)

- [Update Ribbon customizations in Office projects that you migrate to the .NET Framework 4 or the .NET Framework 4.5](update-ribbon-customizations-in-office-projects-to-migrate-to-dotnet-framework-4-or-4-5.md)

- [Update form regions in Outlook projects that you migrate to the .NET Framework 4 or the .NET Framework 4.5](../vsto/updating-form-regions-in-outlook-projects-that-you-migrate-to-the-dotnet-framework-4-or-the-dotnet-framework-4-5.md)

### New base classes in Office projects
 The new interface-based design of the Visual Studio 2010 Tools for Office runtime affects the generated classes in Office projects, such as `ThisDocument`, `ThisWorkbook`, and `ThisAddIn`. In Office projects that target the .NET Framework 3.5 and previous versions of the framework, these generated classes derive from classes in the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] such as `Microsoft.Office.Tools.Word.Document`, `Microsoft.Office.Tools.Excel.Worksheet`, and `Microsoft.Office.Tools.AddIn`. In projects that target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later, these [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] classes are now interfaces. Therefore the generated classes in Office projects can no longer derive their implementation from them. Instead, the generated classes derive from new base classes such as <xref:Microsoft.Office.Tools.Word.DocumentBase>, <xref:Microsoft.Office.Tools.Excel.WorksheetBase>, and <xref:Microsoft.Office.Tools.AddInBase>. For more information, see [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md) and [Program document-level customizations](../vsto/programming-document-level-customizations.md).

 The base classes are not part of the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] redistributable. Instead, they are defined in utilities assemblies that are included with Visual Studio. These assemblies are copied to the output folder when you build Office projects and must be deployed with your solution. For more information about the utilities assemblies, see [Assemblies in the Visual Studio Tools for Office runtime](../vsto/assemblies-in-the-visual-studio-tools-for-office-runtime.md).

## Breaking changes in Office projects that are retargeted to the .NET Framework 4
 The following table lists the main breaking changes you can encounter in Office projects that are retargeted to the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later. For further details, see [Migrate Office solutions to the .NET Framework 4 or later](../vsto/migrating-office-solutions-to-the-dotnet-framework-4-or-later.md).

|Breaking change|Consequence|
|---------------------|-----------------|
|The <xref:System.Security.SecurityTransparentAttribute> is no longer used or supported in Office projects.|You must remove this attribute from the AssemblyInfo code file in Office projects that you upgrade from Visual Studio 2008. For more information, see [Required changes to run Office projects that you migrate to the .NET Framework 4 or the .NET Framework 4.5](../vsto/required-changes-to-run-office-projects-that-you-migrate-to-the-dotnet-framework-4-or-the-dotnet-framework-4-5.md).|
|The **ExcelLocale1033Attribute** is no longer used or supported in Excel projects.|You must remove this attribute from the *AssemblyInfo* code file in Excel projects. For more information, see [Update Excel and Word projects that you migrate to the .NET Framework 4 or the .NET Framework 4.5](../vsto/updating-excel-and-word-projects-that-you-migrate-to-the-dotnet-framework-4-or-the-dotnet-framework-4-5.md).|
|The programming model of **Ribbon (Visual Designer)** project items has changed.|You must modify the code-behind file for any ribbon items in your project. You must also modify any code that instantiates ribbon controls at run time, handles ribbon events, or sets the position of a ribbon component programmatically. For more information, see [Update Ribbon customizations in Office projects that you migrate to the .NET Framework 4 or the .NET Framework 4.5](update-ribbon-customizations-in-office-projects-to-migrate-to-dotnet-framework-4-or-4-5.md).|
|The programming model of Outlook form regions has changed.|You must modify the code-behind file for any form regions in your project and any code that instantiates certain form region classes at run time. For more information, see [Update form regions in Outlook projects that you migrate to the .NET Framework 4 or the .NET Framework 4.5](../vsto/updating-form-regions-in-outlook-projects-that-you-migrate-to-the-dotnet-framework-4-or-the-dotnet-framework-4-5.md).|
|The programming model for smart tags in Excel and Word projects has changed. Smart tags are deprecated in [!INCLUDE[Excel_14_short](../vsto/includes/excel-14-short-md.md)] and [!INCLUDE[Word_14_short](../vsto/includes/word-14-short-md.md)].|If your solution uses smart tags, errors will occur when you build the project. Because smart tags are deprecated in [!INCLUDE[Excel_14_short](../vsto/includes/excel-14-short-md.md)] and [!INCLUDE[Word_14_short](../vsto/includes/word-14-short-md.md)], you must remove the tags before you can test and debug the solution in [!INCLUDE[vs_dev12](../vsto/includes/vs-dev12-md.md)] or later.|
|The syntax of the `GetVstoObject` and `HasVstoObject` methods has changed|You must pass the `Globals.Factory` object to these methods when you access them on native objects from the primary interop assemblies (PIAs), or you can access these methods on the object that is returned by the `Globals.Factory` property in your project. For more information, see [Update Excel and Word projects that you migrate to the .NET Framework 4 or the .NET Framework 4.5](../vsto/updating-excel-and-word-projects-that-you-migrate-to-the-dotnet-framework-4-or-the-dotnet-framework-4-5.md).|
|The events of Word content controls are associated with new delegates.|You must modify any code that handles events of Word content controls to specify the new delegates. For more information, see [Update Excel and Word projects that you migrate to the .NET Framework 4 or the .NET Framework 4.5](../vsto/updating-excel-and-word-projects-that-you-migrate-to-the-dotnet-framework-4-or-the-dotnet-framework-4-5.md).|
|The `OLEObject` and `OLEControl` classes have been renamed.|You must modify any code that uses instances of these classes to use <xref:Microsoft.Office.Tools.Excel.ControlSite> or <xref:Microsoft.Office.Tools.Word.ControlSite> objects instead. For more information, see [Update Excel and Word projects that you migrate to the .NET Framework 4 or the .NET Framework 4.5](../vsto/updating-excel-and-word-projects-that-you-migrate-to-the-dotnet-framework-4-or-the-dotnet-framework-4-5.md).|
|Host item classes, such as `ThisWorkbook`, `Sheet`*n*, `ThisDocument`, and `ThisAddIn`, no longer provide a `Dispose` method that you can override.|You must move any code in the `Dispose` method override to the `Shutdown` event handler in the host item class, for example, `ThisAddIn_Shutdown`, and remove the `Dispose` method override from your host item class.|

## See also
- [Migrate Office solutions to the .NET Framework 4 or later](../vsto/migrating-office-solutions-to-the-dotnet-framework-4-or-later.md)
- [What's new in Office development](https://msdn.microsoft.com/library/bf054af2-c896-4723-aa15-6381145b14bb)
- [Visual Studio Tools for Office runtime overview](../vsto/visual-studio-tools-for-office-runtime-overview.md)
