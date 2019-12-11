---
title: "How to: Change the position of a tab on the ribbon"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Ribbon [Office development in Visual Studio], tabs"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Change the position of a tab on the ribbon
  You can change the order of custom tabs on a ribbon by using the **Tab Collection Editor**. You can position custom tabs before or after a built-in tab on the ribbon. A built-in tab is a tab that is already on the Ribbon of a Microsoft Office application. For example, the **Data** tab is a built-in tab in Excel.

 [!INCLUDE[appliesto_ribbon](../vsto/includes/appliesto-ribbon-md.md)]

### To change the order of tabs on the ribbon

1. Select the Ribbon code file (*.vb* or *.cs* file) in **Solution Explorer**.

2. On the **View** menu, click **Designer**.

3. Right-click the Ribbon Designer, and then click **Properties**.

4. In the **Properties** window, select the **Tabs** property, and then click the ellipsis button (![ASP.NET mobile designer ellipse](../sharepoint/media/mwellipsis.gif "ASP.NET Mobile Designer ellipse")).

     The **Tab Collection Editor** appears.

5. In the **Tab Collection Editor**, in the **Members** list, select the tab you want to move and click the up or down arrows to change the tab order.

### To position a tab before or after a built-in tab on the ribbon

1. In the Ribbon Designer, select a custom tab.

2. In the **Properties** window, expand the **ControlId** property, and then make sure that the value of the **ControlIdType** property is set to **Custom**.

3. In the **Properties** window, expand the **Position** property.

4. Set the **PositionType** property to the appropriate value:

    - **BeforeOfficeId** positions the group before a specified built-in tab.

    - **AfterOfficeId** positions the group after a specified built-in tab.

5. Set the **OfficeId** property to the control ID of a built-in tab.

     For a list of control IDs, see [Office 2010 help files: Office fluent user interface control identifiers](https://www.microsoft.com/download/details.aspx?id=6627).

## See also
- [Ribbon overview](../vsto/ribbon-overview.md)
- [Ribbon Designer](../vsto/ribbon-designer.md)
- [Ribbon XML](../vsto/ribbon-xml.md)
- [Walkthrough: Create a custom tab by using the Ribbon Designer](../vsto/walkthrough-creating-a-custom-tab-by-using-the-ribbon-designer.md)
- [Walkthrough: Create a custom tab by using Ribbon XML](../vsto/walkthrough-creating-a-custom-tab-by-using-ribbon-xml.md)
