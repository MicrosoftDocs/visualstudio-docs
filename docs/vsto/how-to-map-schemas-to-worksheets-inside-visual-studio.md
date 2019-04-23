---
title: "How to: Map schemas to worksheets inside Visual Studio"
titleSuffix: ""
ms.custom: "seodec18"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "XML schemas [Office development in Visual Studio], mapping"
  - "mappings [Office development in Visual Studio], XML schemas to Excel worksheets"
  - "Excel [Office development in Visual Studio], XML schemas"
  - "worksheets [Office development in Visual Studio], XML schemas"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Map schemas to worksheets inside Visual Studio
  You can map an XML schema to a worksheet while the worksheet is open in Visual Studio. You use the same Microsoft Office Excel tools that you use when the workbook is open outside of Visual Studio. The Office project creates the same objects whether you map the schema to the worksheet before or after you create your Excel solution.

 [!INCLUDE[appliesto_xlalldoc](../vsto/includes/appliesto-xlalldoc-md.md)]

> [!NOTE]
> You cannot use multipart XML schemas in Excel solutions.

## To map an XML schema to an Excel worksheet in Visual Studio

1. Open the Excel workbook or template project inside Visual Studio.

2. Click in the worksheet to move the focus to the designer.

3. On the Ribbon, click the **Developer** tab.

    > [!NOTE]
    > If the **Developer** tab is not visible, you must first show it. For more information, see [How to: Show the Developer tab on the ribbon](../vsto/how-to-show-the-developer-tab-on-the-ribbon.md).

4. In the **XML** group, click **Source**.

     The **XML Source** window opens.

5. In the **XML Source** window, click **XML Maps**.

     The **XML Maps** dialog box opens.

6. In the **XML Maps** dialog box, click **Add**.

7. Browse to your schema file, select it, and then click **Open**.

8. Click **OK**.

     The schema is represented in the **XML Source** window. In your project, a typed <xref:System.Data.DataSet> is generated based on the schema, and a <xref:System.Windows.Forms.BindingSource> is created.

9. Drag elements from the **XML Source** window to the places in your worksheet where you want the corresponding controls to be created.

     If you drag a non-repeating schema element, the Office project generates an <xref:Microsoft.Office.Tools.Excel.XmlMappedRange> control that is automatically bound to the <xref:System.Windows.Forms.BindingSource>.

     If you drag a repeating schema element, the Office project generates a <xref:Microsoft.Office.Tools.Excel.ListObject> control that is not automatically bound to a data source. For more information, see [XML schemas and data in document-level customizations](../vsto/xml-schemas-and-data-in-document-level-customizations.md).

## See also
- [How to: Map schemas to Word documents inside Visual Studio](../vsto/how-to-map-schemas-to-word-documents-inside-visual-studio.md)
- [XML schemas and data in document-level customizations](../vsto/xml-schemas-and-data-in-document-level-customizations.md)
