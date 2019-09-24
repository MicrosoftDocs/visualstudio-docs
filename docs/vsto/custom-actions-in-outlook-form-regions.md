---
title: "Custom actions in Outlook form regions"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "form regions [Office development in Visual Studio], custom actions"
  - "custom actions [Office development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Custom actions in Outlook form regions
  Actions display buttons that enable users to respond to a Microsoft Office Outlook item. For example, to respond to a mail item, users click the **Reply**, **Reply to All**, or **Forward** action buttons. Each of these actions creates a new mail item and populates the item's fields by using information from the original item.

 You can create a custom action that opens any kind of Outlook item. For example, you can add a custom action that opens a new appointment or task item. Set the properties of a custom action or use custom code to populate the fields of the new item. Custom actions appear in the **Custom Actions** drop-down of an item that is open in an Outlook inspector window.

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

## Add custom actions to a form region
 To add a custom action to a form region, use the **Custom Actions** dialog box. You can open the **Custom Actions** dialog box by selecting the Form Region in **Solution Explorer**, expanding the **Manifest** node in the **Properties Window**, selecting the **CustomActions** property, and then clicking on the ellipsis button (![ASP.NET mobile designer ellipse](../sharepoint/media/mwellipsis.gif "ASP.NET Mobile Designer ellipse")).

 You can use the **Custom Actions** dialog box to specify a *target form*. A target form is the form that appears when the user executes the custom action.

 You can also use the **Custom Actions** dialog box to specify how you want information from the original item to appear in the target form.

 The following table describes the properties that are available in the **Custom Actions** dialog box.

|Property|Description|
|--------------|-----------------|
|**AddressLike**|Specifies how the target form will be addressed.|
|**Body**|Specifies how the body of the original item is appended to the target form.|
|**Enabled**|Indicates whether the custom action is enabled. If this property is set to **false**, the custom action is disabled.|
|**Method**|Specifies the type of response available when the custom action is executed. The custom action can send the form, open the form, or prompt the user whether they want to send or open the form.|
|**Name**|Specifies the internal name that you can use to reference this custom action in code.|
|**ShowOnRibbon**|Indicates whether to display the custom action on the Ribbon of the original item.|
|**SubjectPrefix**|Specifies text that is inserted at the start of the subject line of the target form.|
|**TargetForm**|Specifies the message class name of the target form. For example, type **IPM.Task** to open a task form.|
|**Title**|Specifies the label of the custom action button.|

## Customize a custom action at run time
 You can also add behavior to the custom action using code. For example, you can add code that takes the names of e-mail recipients and adds those names as attendees in a new appointment item. To do this, handle the [CustomAction](/office/vba/api/Outlook.MailItem.CustomAction) event of the [MailItem object](/office/vba/api/Outlook.MailItem).

## See also
- [Create Outlook form regions](../vsto/creating-outlook-form-regions.md)
- [Walkthrough: Design an Outlook form region](../vsto/walkthrough-designing-an-outlook-form-region.md)
- [Associate a form region with an Outlook message class](../vsto/associating-a-form-region-with-an-outlook-message-class.md)
