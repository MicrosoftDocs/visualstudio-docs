---
title: "How to: Add a Dialog box launcher to a Ribbon group"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "dialog box launcher [Office development in Visual Studio]"
  - "Ribbon [Office development in Visual Studio], dialog box launcher"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Add a Dialog box launcher to a Ribbon group
  You can add a dialog box launcher to any group on a Ribbon. A dialog box launcher is a small icon that appears in a group. Users click this icon to open related dialog boxes or task panes that provide more options that relate to the group.

 [!INCLUDE[appliesto_ribbon](../vsto/includes/appliesto-ribbon-md.md)]

### To add a dialog box launcher to a Ribbon group

1. Select the Ribbon code file (*.vb* or *.cs* file) in **Solution Explorer**.

2. On the **View** menu, click **Designer**.

3. In the Ribbon Designer, right-click any group, and then click **Add DialogBoxLauncher**.

     Add code to the <xref:Microsoft.Office.Tools.Ribbon.RibbonGroup.DialogLauncherClick> event of the group to open a custom or built-in dialog box.

## See also
- [Ribbon overview](../vsto/ribbon-overview.md)
- [Access the Ribbon at run time](../vsto/accessing-the-ribbon-at-run-time.md)
- [Office development samples and walkthroughs](../vsto/office-development-samples-and-walkthroughs.md)
- [Ribbon designer](../vsto/ribbon-designer.md)
- [Ribbon object model overview](../vsto/ribbon-object-model-overview.md)
- [Ribbon XML](../vsto/ribbon-xml.md)
- [How to: Export a Ribbon from the Ribbon Designer to Ribbon XML](../vsto/how-to-export-a-ribbon-from-the-ribbon-designer-to-ribbon-xml.md)
- [How to: Change the position of a tab on the Ribbon](../vsto/how-to-change-the-position-of-a-tab-on-the-ribbon.md)
- [How to: Customize a built-in tab](../vsto/how-to-customize-a-built-in-tab.md)
- [How to: Add Controls to the backstage view](../vsto/how-to-add-controls-to-the-backstage-view.md)
- [Customize a Ribbon for Outlook](../vsto/customizing-a-ribbon-for-outlook.md)
- [How to: Get started customizing the Ribbon](../vsto/how-to-get-started-customizing-the-ribbon.md)
- [How to: Show Add-in user interface errors](../vsto/how-to-show-add-in-user-interface-errors.md)
- [Walkthrough: Create a custom tab by using the Ribbon Designer](../vsto/walkthrough-creating-a-custom-tab-by-using-the-ribbon-designer.md)
- [Walkthrough: Update the controls on a Ribbon at run time](../vsto/walkthrough-updating-the-controls-on-a-ribbon-at-run-time.md)
- [Walkthrough: Create a custom tab by using Ribbon XML](../vsto/walkthrough-creating-a-custom-tab-by-using-ribbon-xml.md)
