---
title: "How to: Prevent Outlook from displaying a form region"
description: Learn how you can prevent Microsoft Office Outlook from displaying a form region for a particular item.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "form regions [Office development in Visual Studio], canceling display"
  - "canceling form region display"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Prevent Outlook from displaying a form region
  There might be situations in which you do not want Microsoft Office Outlook to display a form region for a particular item. For example, if a contact item does not contain a business address, you can prevent a form region that shows the location of the business in a map from appearing.

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

## To prevent Outlook from displaying a form region

1. Open the code file for the form region you want to modify.

2. Expand the **Form Region Factory** code region.

3. Add code to the `FormRegionInitializing` event handler that sets the <xref:System.ComponentModel.CancelEventArgs.Cancel%2A> property of the <xref:Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs> class to **true**.

   In this example, if the contact item does not contain an address, the <xref:System.ComponentModel.CancelEventArgs.Cancel%2A> property is set to **true**, and the form region does not appear.

## Example
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_Outlook_FR_Separate_O12/MapIt.cs" id="Snippet1":::
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_Outlook_FR_Separate_O12/MapIt.vb" id="Snippet1":::


## See also
- [Create Outlook form regions](../vsto/creating-outlook-form-regions.md)
- [Walkthrough: Design an Outlook form region](../vsto/walkthrough-designing-an-outlook-form-region.md)
- [How to: Add a form region to an Outlook Add-in project](../vsto/how-to-add-a-form-region-to-an-outlook-add-in-project.md)
- [Walkthrough: Design an Outlook form region](../vsto/walkthrough-designing-an-outlook-form-region.md)
- [Walkthrough: Import a form region that is designed in Outlook](../vsto/walkthrough-importing-a-form-region-that-is-designed-in-outlook.md)
