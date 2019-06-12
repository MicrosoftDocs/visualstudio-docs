---
title: "How to: Export a ribbon from the Ribbon Designer to Ribbon XML"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "custom Ribbon, XML"
  - "customizing the Ribbon, XML"
  - "Ribbon [Office development in Visual Studio], XML"
  - "Ribbon [Office development in Visual Studio], exporting"
  - "XML [Office development in Visual Studio], Ribbon"
  - "Ribbon Designer [Office development in Visual Studio]"
  - "exporting Ribbon"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Export a ribbon from the Ribbon Designer to Ribbon XML
  The **Ribbon (Visual Designer)** item does not support all possible types of Ribbon customization. To customize the ribbon in advanced ways, you can export the ribbon from the designer to Ribbon XML and edit the XML directly.

> [!NOTE]
> Not all property values appear in the Ribbon XML file. For more information, see [Ribbon overview](../vsto/ribbon-overview.md).

 [!INCLUDE[appliesto_ribbon](../vsto/includes/appliesto-ribbon-md.md)]

### To export a ribbon from the Ribbon Designer to Ribbon XML

1. Right-click the Ribbon code file in **Solution Explorer**, and then click **View Designer**.

2. Right-click the Ribbon Designer, and then click **Export Ribbon to XML**.

     Visual Studio adds a Ribbon XML file and a Ribbon XML code file to your project.

3. In the Ribbon code class, locate the comments that start with `TODO:`.

4. Copy the code block in these comments to the **ThisAddin**, **ThisWorkbook**, or **ThisDocument** class, depending on which type of solution you are developing.

     This code enables the Microsoft Office application to discover and load your custom ribbon. For more information, see [Ribbon XML](../vsto/ribbon-xml.md).

5. In the **ThisAddin**, **ThisWorkbook**, or **ThisDocument** class, uncomment the code block.

     After you uncomment the code, it should resemble the following example. In this example, the Ribbon class is called `MyRibbon`.

     [!code-csharp[Trin_Ribbon_Custom_Tab_XML#1](../vsto/codesnippet/CSharp/Trin_Ribbon_Custom_Tab_XML_O12/ThisAddIn.cs#1)]
     [!code-vb[Trin_Ribbon_Custom_Tab_XML#1](../vsto/codesnippet/VisualBasic/Trin_Ribbon_Custom_Tab_XML_O12/ThisAddIn.vb#1)]

6. Switch to the Ribbon XML code file and find the `Ribbon Callbacks` region.

     This is where you write callback methods to handle user actions, such as clicking a button.

7. Create a callback method for each event handler that you wrote in the Ribbon Designer code.

8. Move all your event handler code from the event handlers to the callback methods, and modify the code to work with the Ribbon extensibility (RibbonX) programming model.

     For information about writing callback methods and using the RibbonX programming model, see [Ribbon XML](../vsto/ribbon-xml.md).

## See also
- [Ribbon overview](../vsto/ribbon-overview.md)
- [Ribbon Designer](../vsto/ribbon-designer.md)
- [Ribbon XML](../vsto/ribbon-xml.md)
- [Walkthrough: Create a custom tab by using the Ribbon Designer](../vsto/walkthrough-creating-a-custom-tab-by-using-the-ribbon-designer.md)
- [Walkthrough: Create a custom tab by using Ribbon XML](../vsto/walkthrough-creating-a-custom-tab-by-using-ribbon-xml.md)
