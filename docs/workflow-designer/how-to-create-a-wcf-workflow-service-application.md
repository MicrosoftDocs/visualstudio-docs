---
title: "How to: Create a WCF Workflow Service Application | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 12d675ac-27d8-4d86-ba16-6f7688f8c841
caps.latest.revision: 14
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
# How to: Create a WCF Workflow Service Application
[!INCLUDE[indigo1](../workflow-designer/includes/indigo1_md.md)] workflow service applications are distributed communications services that pass messages between clients and themselves across process boundaries. The implementation of the service contract on the service side is done declaratively through workflow activities in [!INCLUDE[netfx40_short](../workflow-designer/includes/netfx40_short_md.md)] in a manner analogous to legacy workflow services in .NET Framework 3.5.  
  
### To create a WCF workflow service application  
  
1.  Start [!INCLUDE[vs2010](../misc/includes/vs2010_md.md)].  
  
2.  On the **File** menu, point to **New**, and then select **Project…**.  
  
     The **New Project** dialog box opens.  
  
3.  In the **Installed Templates** pane, select **WCF** or **Workflow** from either the **Visual C#** or **Visual Basic** groupings depending on you language of choice.  
  
4.  In the middle pane, select **WCF Workflow Service Application**.  
  
5.  In the **Name** box, enter a descriptive name for your project to make it easy to identify.  
  
6.  In the **Location** box, enter the directory in which you want to save your project, or click **Browse** to navigate to it.  
  
7.  In the **Solution** box, select to either create a new solution and then click **OK**.  
  
    > [!NOTE]
    >  If you want to add a workflow console application to an existing solution, open that solution in [!INCLUDE[vs2010](../misc/includes/vs2010_md.md)], right click the solution in **Solution Explorer**, and select **Add**, then **New Project…** to open the **New Project** dialog box. Proceed as described above in this procedure.  
  
8.  The project template creates a service definition as XAML. The [!INCLUDE[wfd1](../workflow-designer/includes/wfd1_md.md)] opens to the design view with a <xref:System.Activities.Statements.Sequence> activity that contains a set of <xref:System.ServiceModel.Activities.Receive> and <xref:System.ServiceModel.Activities.SendReply> activities.  
  
## See Also  
 [How to: Create an Activity](../Topic/How%20to:%20Create%20an%20Activity.md)   
 [Creating a Workflow Project](../workflow-designer/creating-a-workflow-project.md)