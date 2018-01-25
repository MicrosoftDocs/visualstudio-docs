---
title: "How to: Add Controls to the Backstage View | Microsoft Docs"
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
  - "customizing the Ribbon, menus"
  - "controls, Ribbon"
  - "menus, customizing"
  - "Microsoft Office Button"
  - "custom Ribbon, menus"
  - "Ribbon, customizing"
  - "Office button"
  - "Ribbon, menus"
  - "Microsoft Office Menu"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Add Controls to the Backstage View
  You can use the Ribbon Designer to add controls to the menu that opens when you click the **File** tab. when you run the application, controls that you add to the **File** tab appear a group named **Add-ins**.  
  
 You cannot position controls before or after built-in controls by using the Ribbon designer in Visual Studio. A built-in control is a control that already appears in Backstage view. If you want to position controls before or after built-in controls, you must use a Ribbon XML. For more information about **Ribbon (XML)**, see [Ribbon XML](../vsto/ribbon-xml.md). For more information about customizing the Backstage view, see [Introduction to the Office 2010 Backstage View for Developers](http://go.microsoft.com/fwlink/?LinkId=182189) and [Customizing the Office 2010 Backstage View for Developers](http://go.microsoft.com/fwlink/?LinkId=182188).  
  
 [!INCLUDE[appliesto_ribbon](../vsto/includes/appliesto-ribbon-md.md)]  
  
### To add controls to Backstage View  
  
1.  Open the Ribbon item in Design view.  
  
     For information about how to add a **Ribbon (Visual Designer)** item to your project, see [How to: Get Started Customizing the Ribbon](../vsto/how-to-get-started-customizing-the-ribbon.md).  
  
2.  In the Ribbon Designer, click the **File** tab.  
  
     A menu designer appears. This design surface does not contain any controls.  
  
3.  From the **Office Ribbon Controls** tab of the **Toolbox**, drag any of the following controls onto the menu designer:  
  
    -   Button  
  
    -   CheckBox  
  
    -   Gallery  
  
    -   Menu  
  
    -   Separator  
  
    -   SplitButton  
  
    -   ToggleButton  
  
4.  Drag controls to move them to new positions on the menu.  
  
## See Also  
 [Ribbon Overview](../vsto/ribbon-overview.md)   
 [Ribbon Designer](../vsto/ribbon-designer.md)   
 [Ribbon XML](../vsto/ribbon-xml.md)   
 [How to: Get Started Customizing the Ribbon](../vsto/how-to-get-started-customizing-the-ribbon.md)   
 [Walkthrough: Creating a Custom Tab by Using the Ribbon Designer](../vsto/walkthrough-creating-a-custom-tab-by-using-the-ribbon-designer.md)  
  
  