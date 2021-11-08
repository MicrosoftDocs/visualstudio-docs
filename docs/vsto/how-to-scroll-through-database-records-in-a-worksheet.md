---
title: "How to: Scroll through database records in a worksheet"
description: Learn how you can use the designer to display a single field from a database table in a Microsoft Excel worksheet
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "databases [Office development in Visual Studio], scrolling records"
  - "records [Office development in Visual Studio], scrolling"
  - "data [Office development in Visual Studio], scrolling database records"
  - "worksheets [Office development in Visual Studio], scrolling records"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Scroll through database records in a worksheet
  The following procedure shows how to use the designer to display a single field from a database table in a Microsoft Office Excel worksheet, with controls that enable the end user to scroll through all the records.

 You can use the designer only in document-level projects. However, you can also add controls and bind them to data programmatically at run time. For more information, see [Walkthrough: Simple data binding in VSTO Add-in project](../vsto/walkthrough-simple-data-binding-in-vsto-add-in-project.md).

 [!INCLUDE[appliesto_xlalldoc](../vsto/includes/appliesto-xlalldoc-md.md)]

## To scroll through database records in a worksheet

1. Open an Excel application project in Visual Studio.

2. Open the **Data Sources** window and create a data source from the database. For more information, see [Add new connections](../data-tools/add-new-connections.md).

3. Expand the table that contains the data that you want to show, and select the specific column.

4. Open the list of controls and select **NamedRange**.

5. Drag the <xref:Microsoft.Office.Tools.Excel.NamedRange> control onto the cell where you want the data to appear.

6. From the **Windows Forms** tab of the **Toolbox**, add a <xref:System.Windows.Forms.BindingNavigator> control to your worksheet, and set up the controls you want to use. For more information, see [BindingNavigator control overview &#40;Windows Forms&#41;](/dotnet/framework/winforms/controls/bindingnavigator-control-overview-windows-forms).

## See also
- [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md)
