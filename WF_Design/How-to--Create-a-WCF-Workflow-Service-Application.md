---
title: "How to: Create a WCF Workflow Service Application"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 12d675ac-27d8-4d86-ba16-6f7688f8c841
caps.latest.revision: 14
manager: erikre
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# How to: Create a WCF Workflow Service Application
Windows Communication Foundation (WCF) workflow service applications are distributed communications services that pass messages between clients and themselves across process boundaries. The implementation of the service contract on the service side is done declaratively through workflow activities in .NET Framework 4 in a manner analogous to legacy workflow services in .NET Framework 3.5.  
  
### To create a WCF workflow service application  
  
1.  Start Visual Studio 2010.  
  
2.  On the **File** menu, point to **New**, and then select **Project…**.  
  
     The **New Project** dialog box opens.  
  
3.  In the **Installed Templates** pane, select **WCF** or **Workflow** from either the **Visual C#** or **Visual Basic** groupings depending on you language of choice.  
  
4.  In the middle pane, select **WCF Workflow Service Application**.  
  
5.  In the **Name** box, enter a descriptive name for your project to make it easy to identify.  
  
6.  In the **Location** box, enter the directory in which you want to save your project, or click **Browse** to navigate to it.  
  
7.  In the **Solution** box, select to either create a new solution and then click **OK**.  
  
    > [!NOTE]
    >  If you want to add a workflow console application to an existing solution, open that solution in Visual Studio 2010, right click the solution in **Solution Explorer**, and select **Add**, then **New Project…** to open the **New Project** dialog box. Proceed as described above in this procedure.  
  
8.  The project template creates a service definition as XAML. The Windows Workflow Designer opens to the design view with a <xref:System.Activities.Statements.Sequence?qualifyHint=False> activity that contains a set of <xref:System.ServiceModel.Activities.Receive?qualifyHint=False> and <xref:System.ServiceModel.Activities.SendReply?qualifyHint=False> activities.  
  
## See Also  
 [How to: Create an Activity](../Topic/How%20to:%20Create%20an%20Activity.md)   
 [Creating a Workflow Project](../WF_Design/Creating-a-Workflow-Project.md)