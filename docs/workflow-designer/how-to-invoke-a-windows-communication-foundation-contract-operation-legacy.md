---
title: "How to: Invoke a Windows Communication Foundation Contract Operation (Legacy) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: a9058345-708f-4fcf-8739-2a43e5285b7a
caps.latest.revision: 8
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
# How to: Invoke a Windows Communication Foundation Contract Operation (Legacy)
This topic describes how to invoke a [!INCLUDE[indigo1](../workflow-designer/includes/indigo1_md.md)] contract operation using the legacy [!INCLUDE[wfd1](../workflow-designer/includes/wfd1_md.md)] that targets the [!INCLUDE[netfx35_long](../workflow-designer/includes/netfx35_long_md.md)] or the [!INCLUDE[vstecwinfx](../workflow-designer/includes/vstecwinfx_md.md)].  
  
 After dragging a **SendActivity** activity from the toolbox to the workflow design surface, you must import an existing contract and determine which operation will be invoked from that **SendActivity** activity. You select your contract and its operations through the [Choose Operation Dialog Box (Legacy)](../workflow-designer/choose-operation-dialog-box-legacy.md).  
  
 Also, if you are using a configuration file with your service, you will need to specify a <xref:System.Workflow.Activities.ChannelToken>. The <xref:System.Workflow.Activities.ChannelToken> identifies the endpoint configuration your send activity is going to use to connect to the workflow service.  
  
### To invoke a WCF contract operation from a SendActivity activity  
  
1.  Double-click the **SendActivity** activity in the designer or click the ellipsis next to the **ServiceOperationInfo** property in the **Properties** pane.  
  
2.  When the **Choose Operation** dialog box opens, click **Import** in the upper-right corner of the dialog box.  
  
     The [Browse and Select a .NET Type Dialog Box (Legacy)](../workflow-designer/browse-and-select-a-dotnet-type-dialog-box-legacy.md) opens.  
  
3.  Search for an assembly or project that contains the contract you want.  
  
4.  Select the contract and click **OK**.  
  
5.  Under **Available Operations**, select the operation you want to invoke and click **OK**.  
  
### To specify a channel token  
  
1.  Select the <xref:System.Workflow.Activities.SendActivity> activity in the designer.  
  
2.  In the **Properties** pane, specify a name for the <xref:System.Workflow.Activities.ChannelToken>. This name uniquely identifies the channel token.  
  
3.  Expand the channel token node and specify a name for the client endpoint you are going to use in the <xref:System.Workflow.Activities.ChannelToken.EndpointName%2A> field. The endpoint configuration of the same name in the configuration file will be used to configure the channel.  
  
4.  Create the endpoint configuration in your configuration file, if it does not exist already. For more information about configuring your client, see [WCF Client Overview](../Topic/WCF%20Client%20Overview.md).  
  
## See Also  
 [Choose Operation Dialog Box (Legacy)](../workflow-designer/choose-operation-dialog-box-legacy.md)   
 [How to: Implement a WCF Contract Operation (Legacy)](../workflow-designer/how-to-implement-a-windows-communication-foundation-contract-operation-legacy.md)   
 [Legacy Workflow Activities](../workflow-designer/legacy-workflow-activities.md)