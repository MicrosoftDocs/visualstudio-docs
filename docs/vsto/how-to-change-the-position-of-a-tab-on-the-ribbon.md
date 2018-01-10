---
title: "How to: Change the Position of a Tab on the Ribbon | Microsoft Docs"
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
  - "Ribbon [Office development in Visual Studio], tabs"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Change the Position of a Tab on the Ribbon
  You can change the order of custom tabs on a Ribbon by using the **Tab Collection Editor**. You can position custom tabs before or after a built-in tab on the Ribbon. A built-in tab is a tab that is already on the Ribbon of a Microsoft Office application. For example, the **Data** tab is a built-in tab in Excel.  
  
 [!INCLUDE[appliesto_ribbon](../vsto/includes/appliesto-ribbon-md.md)]  
  
### To change the order of tabs on the Ribbon  
  
1.  Select the Ribbon code file (.vb or .cs file) in **Solution Explorer**.  
  
2.  On the **View** menu, click **Designer**.  
  
3.  Right-click the Ribbon Designer, and then click **Properties**.  
  
4.  In the **Properties** window, select the **Tabs** property, and then click the ellipsis button (![ASP.NET Mobile Designer ellipse](../sharepoint/media/mwellipsis.gif "ASP.NET Mobile Designer ellipse")).  
  
     The **Tab Collection Editor** appears.  
  
5.  In the **Tab Collection Editor**, in the **Members** list, select the tab you want to move and click the up or down arrows to change the tab order.  
  
### To position a tab before or after a built-in tab on the Ribbon  
  
1.  In the Ribbon Designer, select a custom tab.  
  
2.  In the **Properties** window, expand the **ControlId** property, and then make sure that the value of the **ControlIdType** property is set to **Custom**.  
  
3.  In the **Properties** window, expand the **Position** property.  
  
4.  Set the **PositionType** property to the appropriate value:  
  
    -   **BeforeOfficeId** positions the group before a specified built-in tab.  
  
    -   **AfterOfficeId** positions the group after a specified built-in tab.  
  
5.  Set the **OfficeId** property to the control ID of a built-in tab.  
  
     For a list of control IDs, see [Office 2010 Help Files: Office Fluent User Interface Control Identifiers](http://go.microsoft.com/fwlink/?LinkID=181052).  
  
## See Also  
 [Ribbon Overview](../vsto/ribbon-overview.md)   
 [Ribbon Designer](../vsto/ribbon-designer.md)   
 [Ribbon XML](../vsto/ribbon-xml.md)   
 [Walkthrough: Creating a Custom Tab by Using the Ribbon Designer](../vsto/walkthrough-creating-a-custom-tab-by-using-the-ribbon-designer.md)   
 [Walkthrough: Creating a Custom Tab by Using Ribbon XML](../vsto/walkthrough-creating-a-custom-tab-by-using-ribbon-xml.md)  
  
  