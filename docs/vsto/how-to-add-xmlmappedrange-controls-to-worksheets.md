---
title: "How to: Add XMLMappedRange controls to worksheets"
description: Learn that when you map an XML element to a cell in Microsoft Office Excel, Visual Studio automatically adds an XmlMappedRange control to your worksheet.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "XMLMappedRange control, adding to worksheets"
  - "controls [Office development in Visual Studio], adding to worksheets"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Add XMLMappedRange controls to worksheets
  When you map an XML element to a cell in Microsoft Office Excel, Visual Studio automatically adds an <xref:Microsoft.Office.Tools.Excel.XmlMappedRange> control to your worksheet.

 [!INCLUDE[appliesto_xlalldoc](../vsto/includes/appliesto-xlalldoc-md.md)]

> [!NOTE]
> The <xref:Microsoft.Office.Tools.Excel.XmlMappedRange> control is not available on the **Toolbox** or the **Data Sources** window. Additionally, you cannot create <xref:Microsoft.Office.Tools.Excel.XmlMappedRange> controls programmatically.

## To add an XMLMappedRange control to a worksheet

1. Open the Excel workbook in the Visual Studio designer.

2. Open the worksheet where you want to add the control.

3. On the **Developer** tab, click **Source**.

    > [!NOTE]
    > If the **Developer** tab is not visible on the Ribbon, you must enable it. For more information, see [How to: Show the Developer tab on the Ribbon](../vsto/how-to-show-the-developer-tab-on-the-ribbon.md).

     The **XML Source** task pane appears.

4. In the **XML Source** task pane, click **XML Maps**.

5. In the **XML Maps** dialog box, click **Add**.

     The **XML Source** dialog box appears.

6. Select an XML schema from the **XML Source** dialog box and click **Open**.

     The schema is added to the **XML Maps** dialog box.

7. In the **XML Maps** dialog box, click **OK**.

8. Drag an element from the **XML Source** task pane to a cell on the worksheet.

     An <xref:Microsoft.Office.Tools.Excel.XmlMappedRange> is created and added to the project.

    > [!NOTE]
    > If you drag a parent element from the **XML Source** task pane, a <xref:Microsoft.Office.Tools.Excel.ListObject> control is created.

## See also
- [XmlMappedRange control](../vsto/xmlmappedrange-control.md)
- [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
- [How to: Map schemas to worksheets inside Visual Studio](../vsto/how-to-map-schemas-to-worksheets-inside-visual-studio.md)
