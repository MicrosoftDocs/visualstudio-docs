---
title: "How to: Create a WCF Workflow Service Application | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
ms.assetid: 12d675ac-27d8-4d86-ba16-6f7688f8c841
caps.latest.revision: 14
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Create a WCF Workflow Service Application
[!INCLUDE[indigo1](../includes/indigo1-md.md)] workflow service applications are distributed communications services that pass messages between clients and themselves across process boundaries. The implementation of the service contract on the service side is done declaratively through workflow activities in [!INCLUDE[netfx40_short](../includes/netfx40-short-md.md)] in a manner analogous to legacy workflow services in .NET Framework 3.5.

### To create a WCF workflow service application

1. Start [!INCLUDE[vs2010](../includes/vs2010-md.md)].

2. On the **File** menu, point to **New**, and then select **Project…**.

     The **New Project** dialog box opens.

3. In the **Installed Templates** pane, select **WCF** or **Workflow** from either the **Visual C#** or **Visual Basic** groupings depending on you language of choice.

4. In the middle pane, select **WCF Workflow Service Application**.

5. In the **Name** box, enter a descriptive name for your project to make it easy to identify.

6. In the **Location** box, enter the directory in which you want to save your project, or click **Browse** to navigate to it.

7. In the **Solution** box, select to either create a new solution and then click **OK**.

    > [!NOTE]
    > If you want to add a workflow console application to an existing solution, open that solution in [!INCLUDE[vs2010](../includes/vs2010-md.md)], right click the solution in **Solution Explorer**, and select **Add**, then **New Project…** to open the **New Project** dialog box. Proceed as described above in this procedure.

8. The project template creates a service definition as XAML. The [!INCLUDE[wfd1](../includes/wfd1-md.md)] opens to the design view with a <xref:System.Activities.Statements.Sequence> activity that contains a set of <xref:System.ServiceModel.Activities.Receive> and <xref:System.ServiceModel.Activities.SendReply> activities.

## See Also
 [How to: Create an Activity](https://msdn.microsoft.com/library/c09b1e99-21b5-4d96-9c04-ec31db3f4436)
 [Creating a Workflow Project](../workflow-designer/creating-a-workflow-project.md)