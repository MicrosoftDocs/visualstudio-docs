---
title: "One or more properties in the .ofs file are not valid for the message class selected | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VSTO.NewFormRegionWizard.OFSPropertyError"
dev_langs: 
  - "VB"
  - "CSharp"
ms.assetid: ca9e2ec1-df96-45ca-9611-cec47edfe1e4
caps.latest.revision: 8
author: "gewarren"
ms.author: "gewarren"
manager: "ghogen"
---
# One or more properties in the .ofs file are not valid for the message class selected
  This error appears when you import a form region that is designed in Outlook, but one or more fields on the form region are not compatible with the message classes that you select on the final page of the **New Form Region** wizard.  
  
 For example, you might select **Task (IPM.Task)** on the final page of the **New Form Region** wizard. If the form region contains a **Business Address** field, you will receive this error because a task does not have a business address. Therefore, the **Business Address** field is not compatible with the IPM.Task message class.  
  
### To correct this error  
  
-   On the final page of the **New Form Region** wizard, select a message class that is compatible with the fields on the form region.  
  
-   In the Forms Designer in Outlook, remove fields that are not compatible with the message classes that you plan to select on the final page of the **New Form Region** wizard.  
  
## See Also  
 [Walkthrough: Importing a Form Region That Is Designed in Outlook](../vsto/walkthrough-importing-a-form-region-that-is-designed-in-outlook.md)  
  
  