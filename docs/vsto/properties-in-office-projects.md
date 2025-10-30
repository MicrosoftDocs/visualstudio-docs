---
title: "Properties in Office projects"
description: Learn about the properties that are available to Office projects in Visual Studio through the Properties window.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Trust Assemblies Location property"
  - "Cache in Document property"
  - "properties [Office development in Visual Studio]"
  - "Namespace for Host Item property"
  - "Office projects [Office development in Visual Studio], properties"
  - "projects [Office development in Visual Studio], properties"
  - "Value2 property"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Properties in Office projects

  There are several important properties that are available to Office projects in Visual Studio. These properties can be accessed in the **Properties** window.

 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]

## Namespace for host item
 Use the **Namespace for Host Item** property to change the namespace for host item classes (for example, the `ThisAddIn`, `ThisWorkbook`, or `ThisDocument` classes) in Visual C# projects. This property appears in the **Properties** window when you select the document node in a document-level project (such as *ExcelWorkbook1.xlsx* or *WordDocument1.docx*) or the application node in a VSTO Add-in project (such as Excel or Word) in **Solution Explorer**.

 When you create a Visual C# Office project, host items are given a namespace based on the name of the project. It is recommended that you use the **Namespace for Host Item** property to change the namespace rather than edit the code files directly. When you use this property, the namespace is changed in the generated (hidden) code files, as well as in the visible code files.

## CacheInDocument
 The **CacheInDocument** property appears in the **Properties** window for document-level projects when you select an instance of a <xref:System.Data.DataSet> in the Visual Studio designer. Only public members can be cached; ensure that the **Modifiers** property is set to **Public** if you want to cache a <xref:System.Data.DataSet>.

 This property takes a Boolean value:

- Select **true** to cache the dataset in the document.

- Select **false** if you do not want the dataset to be cached in the document.

  For more information about caching data, see [Cached data in document-level customizations](../vsto/cached-data-in-document-level-customizations.md).

## Value2
 The **Value2** property is only available for Excel workbook or template projects. It appears under the **Databindings** property node in the **Properties** window when you select a <xref:Microsoft.Office.Tools.Excel.NamedRange> control on the worksheet designer.

 Use the **Value2** property in the **Properties** window to bind the <xref:Microsoft.Office.Tools.Excel.NamedRange.Value2%2A> property of the <xref:Microsoft.Office.Tools.Excel.NamedRange> to a field in your data source.

## Related content
- [Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md)
- [Office project templates overview](../vsto/office-project-templates-overview.md)
- [Events in Office projects](../vsto/events-in-office-projects.md)
