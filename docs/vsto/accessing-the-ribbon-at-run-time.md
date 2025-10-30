---
title: "Access the Ribbon at run time"
description: You can write code to show, hide, and modify the Ribbon, and enable users to run the code from controls in a custom task pane, actions pane, or Outlook form region.
ms.date: 02/02/2017
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Globals class, Ribbon"
  - "Ribbon [Office development in Visual Studio], accessing"
  - "RibbonManager class"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Access the Ribbon at run time

  You can write code to show, hide, and modify the Ribbon, and enable users to run the code from controls in a custom task pane, actions pane, or Outlook form region.

 You can access the Ribbon by using the `Globals` class. For Outlook projects, you can access the Ribbons that appear in a specific Outlook Inspector or Outlook Explorer window.

 [!INCLUDE[appliesto_ribbon](../vsto/includes/appliesto-ribbon-md.md)]

## Access the Ribbon by using the Globals class
 You can use the `Globals` class to access the Ribbon in a document-level project or VSTO Add-in project from anywhere in the project.

 For more information about the `Globals` class, see [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md).

 The following example uses the `Globals` class to access a custom Ribbon named `Ribbon1` and set the text that appears on a combo box on the Ribbon to `Hello World`.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_Outlook_FR_Access_O12/ThisAddIn.cs" id="Snippet4":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_Outlook_FR_Access_O12/ThisAddIn.vb" id="Snippet4":::
 ---

## Access a collection of Ribbons that appear in a specific Outlook Inspector window
 You can access a collection of Ribbons that appear in Outlook *Inspectors*. An Inspector is a window that opens in Outlook when users perform certain tasks, such as creating e-mail messages. To access the Ribbon of an Inspector window, call the `Ribbons` property of the `Globals` class and pass in an <xref:Microsoft.Office.Interop.Outlook.Inspector> object that represents the Inspector.

 The following example gets the Ribbon collection of the Inspector that currently has focus. This example then accesses a Ribbon named `Ribbon1` and sets the text that appears on a combo box on the Ribbon to `Hello World`.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_Outlook_FR_Access_O12/ThisAddIn.cs" id="Snippet5":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_Outlook_FR_Access_O12/ThisAddIn.vb" id="Snippet5":::
 ---

## Access a collection of Ribbons that appear for a specific Outlook Explorer
 You can access a collection of Ribbons that appear in an Outlook *Explorer*. An Explorer is the main application user interface (UI) for an instance of Outlook. To access the Ribbon of an Explorer window, call the `Ribbons` property of the `Globals` class and pass in an <xref:Microsoft.Office.Interop.Outlook.Explorer> object that represents the Explorer.

 The following example gets the Ribbon collection of the Explorer that currently has focus. This example then accesses a Ribbon named `Ribbon1` and sets the text that appears on a combo box on the Ribbon to `Hello World`.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_Outlook_FR_Access_O12/ThisAddIn.cs" id="Snippet6":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_Outlook_FR_Access_O12/ThisAddIn.vb" id="Snippet6":::
 ---

## Related content
- [Ribbon overview](../vsto/ribbon-overview.md)
- [Ribbon Designer](../vsto/ribbon-designer.md)
- [Ribbon XML](../vsto/ribbon-xml.md)
- [Ribbon object model overview](../vsto/ribbon-object-model-overview.md)
- [Walkthrough: Create a custom tab by using the Ribbon Designer](../vsto/walkthrough-creating-a-custom-tab-by-using-the-ribbon-designer.md)
- [Walkthrough: Update the controls on a Ribbon at run time](../vsto/walkthrough-updating-the-controls-on-a-ribbon-at-run-time.md)
- [Customize a Ribbon for Outlook](../vsto/customizing-a-ribbon-for-outlook.md)
- [Access a form region at run time](../vsto/accessing-a-form-region-at-run-time.md)
