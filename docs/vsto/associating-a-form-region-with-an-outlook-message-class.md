---
title: "Associate a form region with an Outlook message class"
ms.date: 02/02/2017
ms.topic: conceptual
f1_keywords:
  - "VSTO.NewFormRegionWizard.InvalidMessageClassName"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "FormRegionMessageClassAttribute"
  - "form regions [Office development in Visual Studio], message classes"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Associate a form region with an Outlook message class
  You can specify which Microsoft Office Outlook items display a form region by associating the form region with the message class of each item. For example, if you want to append a form region to the bottom of a mail item, you can associate the form region with the `IPM.Note` message class.

 To associate a form region with a message class, specify the message class name in the **New Outlook Form Region** wizard or apply an attribute to the form region factory class.

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

## Understand Outlook message classes
 An Outlook message class identifies a type of Outlook item. The following table lists these eight standard types of items and their message class names.

|Outlook Item Type|Message Class Name|
|-----------------------|------------------------|
|AppointmentItem|`IPM.Appointment`|
|ContactItem|`IPM.Contact`|
|DistListItem|`IPM.DistList`|
|JournalItem|`IPM.Activity`|
|MailItem|`IPM.Note`|
|PostItem|`IPM.Post` or `IPM.Post.RSS`|
|TaskItem|`IPM.Task`|

 You can also specify the names of custom message classes. Custom message classes identify custom forms that you define in Outlook.

> [!NOTE]
> For replacement and replace-all form regions, you can specify a new custom message class name. You do not need to use the message class name of an existing custom form. The name of the custom message class must be unique. One way to ensure that the name is unique is to use a naming convention similar to the following: \<*StandardMessageClassName*>.\<*Company*>.\<*MessageClassName*> (for example: `IPM.Note.Contoso.MyMessageClass`).

## Associate a form region with an Outlook message class
 There are two ways to associate a form region with a message class:

- Use the **New Outlook Form Region** wizard.

- Apply class attributes.

### Use the New Outlook Form Region wizard
 On the final page of the **New Outlook Form Region** wizard, you can select standard message classes and type the names of custom message classes that you want to associate with the form region.

 The standard message classes are not available if the form region is designed to replace the whole form or the default page of a form. You can specify standard message class names only for forms that add a new page to a form or that are appended to the bottom of a form. For more information, see [How to: Add a form region to an Outlook Add-in project](../vsto/how-to-add-a-form-region-to-an-outlook-add-in-project.md).

 To include one or more custom message classes, type their names in the **Which custom message classes will display this form region?** box.

 The names that you type must comply with the following guidelines:

- Use the fully qualified message class name (for example: "IPM.Note.Contoso").

- Use semicolons to separate multiple message class names.

- Do not include standard Outlook message classes, such as "IPM.Note" or "IPM.Contact". Only include custom message classes, such as "IPM.Note.Contoso".

- Do not specify the base message class by itself (for example: "IPM").

- Do not exceed 256 characters for each message class name.

  The **New Outlook Form Region** wizard validates the format of your input when you click **Finish**.

> [!NOTE]
> The **New Outlook Form Region** wizard does not verify that the message class names that you provide are correct or valid.

 When you complete the wizard, the **New Outlook Form Region** wizard applies attributes to the form region class that contain the specified message class names. You can also apply these attributes manually.

### Apply class attributes
 You can associate a form region with an Outlook message class after you complete the **New Outlook Form Region** wizard. To do this, apply attributes to the form region factory class.

 The following example shows two <xref:Microsoft.Office.Tools.Outlook.FormRegionMessageClassAttribute> attributes that have been applied to a form region factory class named `myFormRegion`. The first attribute associates the form region with a standard message class for a mail message form. The second attribute associates the form region with a custom message class named `IPM.Task.Contoso`.

 [!code-vb[Trin_Outlook_FR_Attributes#1](../vsto/codesnippet/VisualBasic/Trin_Outlook_FR_Attributes/FormRegion1.vb#1)]
 [!code-csharp[Trin_Outlook_FR_Attributes#1](../vsto/codesnippet/CSharp/Trin_Outlook_FR_Attributes/FormRegion1.cs#1)]

 Attributes must comply with the following guidelines:

- For custom message classes, use the fully qualified message class name (for example: "IPM.Note.Contoso").

- Do not specify the base message class by itself (for example: "IPM").

- Do not exceed 256 characters for each message class name.

- Do not include the names of standard message classes if the form region replaces the whole form or the default page of a form. You can specify standard message class names only for forms that add a new page to a form or that are appended to the bottom of a form. For more information, see [How to: Add a form region to an Outlook Add-in project](../vsto/how-to-add-a-form-region-to-an-outlook-add-in-project.md).

  Visual Studio validates the format of the message class names when you build the project.

> [!NOTE]
> Visual Studio does not verify that the message class names that you provide are correct or valid.

## See also
- [Access a form region at run time](../vsto/accessing-a-form-region-at-run-time.md)
- [Create Outlook form regions](../vsto/creating-outlook-form-regions.md)
- [Walkthrough: Design an Outlook form region](../vsto/walkthrough-designing-an-outlook-form-region.md)
- [Guidelines to create Outlook form regions](../vsto/guidelines-for-creating-outlook-form-regions.md)
- [Form name and message class overview](/office/vba/outlook/Concepts/Forms/form-name-and-message-class-overview)
- [How Outlook forms and items work together](/office/vba/outlook/Concepts/Forms/how-outlook-forms-and-items-work-together)
