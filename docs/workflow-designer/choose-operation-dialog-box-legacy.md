---
title: "Choose Operation Dialog Box (Legacy) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
f1_keywords: 
  - "System.Workflow.Activities.Design.OperationPickerDialog.UI"
ms.assetid: bc3ec902-7797-494e-af48-e70c97eb6779
caps.latest.revision: 10
author: "ErikRe"
ms.author: "erikre"
manager: "erikre"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Choose Operation Dialog Box (Legacy)
This topic describes how use the **Choose Operation** dialog box in the legacy [!INCLUDE[wfd1](../workflow-designer/includes/wfd1_md.md)]. Use the legacy [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] when you need to target either the [!INCLUDE[netfx35_long](../workflow-designer/includes/netfx35_long_md.md)] or the [!INCLUDE[vstecwinfx](../workflow-designer/includes/vstecwinfx_md.md)].  
  
 The **Choose Operation** dialog box is used to select an operation to associate with a <xref:System.Workflow.Activities.ReceiveActivity> activity or a <xref:System.Workflow.Activities.SendActivity> activity. For more information about using this dialog box with those activities, see [How to: Implement a WCF Contract Operation (Legacy)](../workflow-designer/how-to-implement-a-windows-communication-foundation-contract-operation-legacy.md) and [How to: Invoke a WCF Contract Operation (Legacy)](../workflow-designer/how-to-invoke-a-windows-communication-foundation-contract-operation-legacy.md).  
  
 The following table describes the user interface (UI) elements of the **Choose Operation** dialog box.  
  
|UI Element|Description|  
|----------------|-----------------|  
|**Add Contract**|Creates a new contract for you. You can define new operations on this contract. (This is used with <xref:System.Workflow.Activities.ReceiveActivity> only.)|  
|**Add Operation**|Adds new operations to a new contract that you created in the **Choose Operation** dialog box. **Note:**  You can add new operations only to contracts you have created through the **Choose Operation** dialog box. <br /><br /> (This is used with <xref:System.Workflow.Activities.ReceiveActivity> only.)|  
|**Import...**|Imports a previously defined contract and allows you to select an operation from that contract.|  
|**Operation Name**|Name of the currently selected operation. This text box is available for editing only if you have created an operation through the **Choose Operation** dialog box.|  
|**Parameters**|Tab containing the parameter definitions for the currently selected operation. **Note:**  Parameter definitions can be changed only if you have created an operation through the **Choose Operation** dialog box.|  
|**Properties**|Tab containing the <xref:System.Net.Security.ProtectionLevel> settings for messages sent between the client and service. **Note:**  This tab is enabled only if you have created an operation through the **Choose Operation** dialog box.|  
|**Permissions**|Tab containing the <xref:System.Workflow.Activities.OperationInfoBase.PrincipalPermissionName%2A> and <xref:System.Workflow.Activities.OperationInfoBase.PrincipalPermissionRole%2A> properties of users that are allowed to call that operation. For example, if only users from the Administrators group were allowed to call that operation, then you would write "Administrators" in the **Role** text box.<br /><br /> This tab is enabled for both operations created through the **ChooseOperation** dialog box and operations that were imported through the **Import** button.|  
  
> [!NOTE]
>  The **Choose Operation** dialog box shows only contracts or operations that are used by other <xref:System.Workflow.Activities.SendActivity> activities in the workflow. Similarly, the **Choose Operation** dialog box for <xref:System.Workflow.Activities.ReceiveActivity> activities shows only contracts or operations that are used by other **ReceiveActivity** activities in the workflow.  
  
## See Also  
 [How to: Implement a WCF Contract Operation (Legacy)](../workflow-designer/how-to-implement-a-windows-communication-foundation-contract-operation-legacy.md)   
 [How to: Invoke a WCF Contract Operation (Legacy)](../workflow-designer/how-to-invoke-a-windows-communication-foundation-contract-operation-legacy.md)   
 [Legacy Designer for Windows Workflow Foundation UI Help](../workflow-designer/legacy-designer-for-windows-workflow-foundation-ui-help.md)