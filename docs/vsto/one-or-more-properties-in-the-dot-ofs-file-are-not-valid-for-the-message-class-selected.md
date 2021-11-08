---
title: Invalid properties in the .ofs file for the message class"
description: Learn how to correct an error that occurs when one or more properties in the .ofs file are not valid for the message class selected.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "conceptual"
f1_keywords:
  - "VSTO.NewFormRegionWizard.OFSPropertyError"
dev_langs:
  - "VB"
  - "CSharp"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# Invalid properties in the .ofs file for the message class

  The error "One or more properties in the .ofs file are not valid for the message class selected" appears when you import a form region that is designed in Outlook, but one or more fields on the form region aren't compatible with the message classes that you select on the final page of the **New Form Region** wizard.

For example, you might select **Task (IPM.Task)** on the final page of the **New Form Region** wizard. If the form region has a **Business Address** field, you'll receive this error because a task doesn't have a business address. Therefore, the **Business Address** field is not compatible with the `IPM.Task` message class.

 You might select **Task (IPM.Task)** on the final page of the **New Form Region** wizard. If the form region has a **Business Address** field, you'll receive this error because a task doesn't have a business address. Therefore, the **Business Address** field is not compatible with the `IPM.Task` message class.

## To correct this error

- On the final page of the **New Form Region** wizard, select a message class that is compatible with the fields on the form region.

- In the Forms Designer in Outlook, remove fields that aren't compatible with the message classes. Remove fields that you plan to select on the final page of the **New Form Region** wizard.

## See also
- [Walkthrough: Import a form region that is designed in Outlook](../vsto/walkthrough-importing-a-form-region-that-is-designed-in-outlook.md)
