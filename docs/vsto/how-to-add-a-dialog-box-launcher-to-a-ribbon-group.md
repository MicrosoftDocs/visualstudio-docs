---
title: "How to: Add a Dialog Box Launcher to a Ribbon Group | Microsoft Docs"
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
  - "dialog box launcher [Office development in Visual Studio]"
  - "Ribbon [Office development in Visual Studio], dialog box launcher"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Add a Dialog Box Launcher to a Ribbon Group
  You can add a dialog box launcher to any group on a Ribbon. A dialog box launcher is a small icon that appears in a group. Users click this icon to open related dialog boxes or task panes that provide more options that relate to the group.  
  
 [!INCLUDE[appliesto_ribbon](../vsto/includes/appliesto-ribbon-md.md)]  
  
### To add a dialog box launcher to a Ribbon group  
  
1.  Select the Ribbon code file (.vb or .cs file) in **Solution Explorer**.  
  
2.  On the **View** menu, click **Designer**.  
  
3.  In the Ribbon Designer, right-click any group, and then click **Add DialogBoxLauncher**.  
  
     Add code to the <xref:Microsoft.Office.Tools.Ribbon.RibbonGroup.DialogLauncherClick> event of the group to open a custom or built-in dialog box.  
  
## See Also  
 [Ribbon Overview](../vsto/ribbon-overview.md)   
 [Accessing the Ribbon at Run Time](../vsto/accessing-the-ribbon-at-run-time.md)   
 [Office Development Samples and Walkthroughs](../vsto/office-development-samples-and-walkthroughs.md)   
 [Ribbon Designer](../vsto/ribbon-designer.md)   
 [Ribbon Object Model Overview](../vsto/ribbon-object-model-overview.md)   
 [Ribbon XML](../vsto/ribbon-xml.md)   
 [How to: Export a Ribbon from the Ribbon Designer to Ribbon XML](../vsto/how-to-export-a-ribbon-from-the-ribbon-designer-to-ribbon-xml.md)   
 [How to: Change the Position of a Tab on the Ribbon](../vsto/how-to-change-the-position-of-a-tab-on-the-ribbon.md)   
 [How to: Customize a Built-in Tab](../vsto/how-to-customize-a-built-in-tab.md)   
 [How to: Add Controls to the Backstage View](../vsto/how-to-add-controls-to-the-backstage-view.md)   
 [Customizing a Ribbon for Outlook](../vsto/customizing-a-ribbon-for-outlook.md)   
 [How to: Get Started Customizing the Ribbon](../vsto/how-to-get-started-customizing-the-ribbon.md)   
 [How to: Show Add-in User Interface Errors](../vsto/how-to-show-add-in-user-interface-errors.md)   
 [Walkthrough: Creating a Custom Tab by Using the Ribbon Designer](../vsto/walkthrough-creating-a-custom-tab-by-using-the-ribbon-designer.md)   
 [Walkthrough: Updating the Controls on a Ribbon at Run Time](../vsto/walkthrough-updating-the-controls-on-a-ribbon-at-run-time.md)   
 [Walkthrough: Creating a Custom Tab by Using Ribbon XML](../vsto/walkthrough-creating-a-custom-tab-by-using-ribbon-xml.md)  
  
  