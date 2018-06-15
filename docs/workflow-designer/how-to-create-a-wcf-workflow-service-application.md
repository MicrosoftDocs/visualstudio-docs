---
title: "Workflow Designer - How to: Create a WCF Workflow Service Application"
ms.date: 11/04/2016
ms.topic: conceptual
ms.prod: visual-studio-dev15
ms.technology: vs-workflow-designer
ms.assetid: 12d675ac-27d8-4d86-ba16-6f7688f8c841
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# How to: Create a WCF Workflow Service Application

Windows Communication Foundation (WCF) workflow service applications are distributed communications services that pass messages between clients and themselves across process boundaries. The implementation of the service contract on the service side is done declaratively through workflow activities in .NET Framework 4 in a manner analogous to legacy workflow services in .NET Framework 3.5.

## To create a WCF workflow service application

1.  Start Visual Studio 2010.

2.  On the **File** menu, point to **New**, and then select **Project**.

     The **New Project** dialog box opens.

3.  In the **Installed Templates** pane, select **WCF** or **Workflow** from either the **Visual C#** or **Visual Basic** groupings depending on you language of choice.

4.  In the middle pane, select **WCF Workflow Service Application**.

5.  In the **Name** box, enter a descriptive name for your project to make it easy to identify.

6.  In the **Location** box, enter the directory in which you want to save your project, or click **Browse** to navigate to it.

7.  In the **Solution** box, select to either create a new solution and then click **OK**.

    > [!NOTE]
    > If you want to add a workflow console application to an existing solution, open that solution in Visual Studio 2010, right click the solution in **Solution Explorer**, and select **Add**, then **New Project** to open the **New Project** dialog box. Proceed as described above in this procedure.

8.  The project template creates a service definition as XAML. The Windows Workflow Designer opens to the design view with a <xref:System.Activities.Statements.Sequence> activity that contains a set of <xref:System.ServiceModel.Activities.Receive> and <xref:System.ServiceModel.Activities.SendReply> activities.

## See also

- [How to: Create an Activity](/dotnet/framework/windows-workflow-foundation/how-to-create-an-activity)
- [Creating a Workflow Project](../workflow-designer/creating-a-workflow-project.md)