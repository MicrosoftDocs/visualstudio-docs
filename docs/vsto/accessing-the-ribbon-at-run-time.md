---
title: "Accessing the Ribbon at Run Time | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Globals class, Ribbon"
  - "Ribbon [Office development in Visual Studio], accessing"
  - "RibbonManager class"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Accessing the Ribbon at Run Time
  You can write code to show, hide, and modify the Ribbon, and enable users to run the code from controls in a custom task pane, actions pane, or Outlook form region.  
  
 You can access the Ribbon by using the `Globals` class. For Outlook projects, you can access the Ribbons that appear in a specific Outlook Inspector or Outlook Explorer window.  
  
 [!INCLUDE[appliesto_ribbon](../vsto/includes/appliesto-ribbon-md.md)]  
  
## Accessing the Ribbon by Using the Globals Class  
 You can use the `Globals` class to access the Ribbon in a document-level project or VSTO Add-in project from anywhere in the project.  
  
 For more information about the `Globals` class, see [Global Access to Objects in Office Projects](../vsto/global-access-to-objects-in-office-projects.md).  
  
 The following example uses the `Globals` class to access a custom Ribbon named `Ribbon1` and set the text that appears on a combo box on the Ribbon to `Hello World`.  
  
 [!code-vb[Trin_Outlook_FR_Access#4](../vsto/codesnippet/VisualBasic/Trin_Outlook_FR_Access_O12/ThisAddIn.vb#4)]
 [!code-csharp[Trin_Outlook_FR_Access#4](../vsto/codesnippet/CSharp/Trin_Outlook_FR_Access_O12/ThisAddIn.cs#4)]  
  
## Accessing a Collection of Ribbons That Appear in a Specific Outlook Inspector Window  
 You can access a collection of Ribbons that appear in Outlook *Inspectors*. An Inspector is a window that opens in Outlook when users perform certain tasks, such as creating e-mail messages. To access the Ribbon of an Inspector window, call the `Ribbons` property of the `Globals` class and pass in an <xref:Microsoft.Office.Interop.Outlook.Inspector> object that represents the Inspector.  
  
 The following example gets the Ribbon collection of the Inspector that currently has focus. This example then accesses a Ribbon named `Ribbon1` and sets the text that appears on a combo box on the Ribbon to `Hello World`.  
  
 [!code-vb[Trin_Outlook_FR_Access#5](../vsto/codesnippet/VisualBasic/Trin_Outlook_FR_Access_O12/ThisAddIn.vb#5)]
 [!code-csharp[Trin_Outlook_FR_Access#5](../vsto/codesnippet/CSharp/Trin_Outlook_FR_Access_O12/ThisAddIn.cs#5)]  
  
## Accessing a Collection of Ribbons That Appear for a Specific Outlook Explorer  
 You can access a collection of Ribbons that appear in an Outlook *Explorer*. An Explorer is the main application user interface (UI) for an instance of Outlook. To access the Ribbon of an Explorer window, call the `Ribbons` property of the `Globals` class and pass in an <xref:Microsoft.Office.Interop.Outlook.Explorer> object that represents the Explorer.  
  
 The following example gets the Ribbon collection of the Explorer that currently has focus. This example then accesses a Ribbon named `Ribbon1` and sets the text that appears on a combo box on the Ribbon to `Hello World`.  
  
 [!code-vb[Trin_Outlook_FR_Access#6](../vsto/codesnippet/VisualBasic/Trin_Outlook_FR_Access_O12/ThisAddIn.vb#6)]
 [!code-csharp[Trin_Outlook_FR_Access#6](../vsto/codesnippet/CSharp/Trin_Outlook_FR_Access_O12/ThisAddIn.cs#6)]  
  
## See Also  
 [Ribbon Overview](../vsto/ribbon-overview.md)   
 [Ribbon Designer](../vsto/ribbon-designer.md)   
 [Ribbon XML](../vsto/ribbon-xml.md)   
 [Ribbon Object Model Overview](../vsto/ribbon-object-model-overview.md)   
 [Walkthrough: Creating a Custom Tab by Using the Ribbon Designer](../vsto/walkthrough-creating-a-custom-tab-by-using-the-ribbon-designer.md)   
 [Walkthrough: Updating the Controls on a Ribbon at Run Time](../vsto/walkthrough-updating-the-controls-on-a-ribbon-at-run-time.md)   
 [Customizing a Ribbon for Outlook](../vsto/customizing-a-ribbon-for-outlook.md)   
 [Accessing a Form Region at Run Time](../vsto/accessing-a-form-region-at-run-time.md)  
  
  