---
title: Create a Workflow Foundation project
ms.date: 06/25/2018
ms.topic: conceptual
ms.prod: visual-studio-dev15
helpviewer_keywords:
  - "Workflow Designer, creating a workflow project"
  - "creating a workflow project"
ms.assetid: 235a125e-ebe7-4a98-bf77-86c8558728fb
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# Workflow project templates

You can create Workflows, Windows Communication Foundation (WCF) workflow services, custom activities, and custom activity designers by using Visual Studio project templates. This article describes how to create libraries and applications with the project templates available in Visual Studio.

## Create a Workflow project

Visual Studio provides four different Workflow project templates:

- Workflow console app

- WCF workflow service app

- Activity library

- Activity designer library

To access these templates, first install the **Windows Workflow Foundation** component of Visual Studio 2017. For detailed instructions, see [Install Windows Workflow Foundation](developing-applications-with-the-workflow-designer.md#install-windows-workflow-foundation).

1. After you've installed the **Windows Workflow Foundation** component, open the **New Project** dialog by selecting **File** > **New** > **Project**.

1. In the left-hand pane, select the **Visual C#** > **Workflow** category (or **Visual Basic** > **Workflow** if you prefer Visual Basic).

1. In the middle pane, select a project template, such as **Workflow Console Application**.

1. In the **Name** box, enter a descriptive name for your project to make it easy to identify.

1. In the **Location** box, enter the directory in which you want to save your project, or select **Browse** to navigate to it.

1. In the **Solution** box, enter the name for the new solution. Select **OK** to create the application.

   > [!NOTE]
   > If you want to add a new project to an existing solution, open that solution in Visual Studio, right-click the solution in **Solution Explorer**, and select **Add** > **New Project** to open the **New Project** dialog box.

## Workflow console app

If you choose the **Workflow Console Application** template, Visual Studio creates a workflow definition in XAML. The Workflow Designer opens and displays the canvas for the workflow you created. To compose a workflow, drag activities or other workflow items from **Toolbox** to the design surface.

## WCF workflow service app

If you choose the **WCF Workflow Service Application** template, Visual Studio creates a service definition as XAML. The Workflow Designer opens to the design view with a <xref:System.Activities.Statements.Sequence> activity that contains a set of <xref:System.ServiceModel.Activities.Receive> and <xref:System.ServiceModel.Activities.SendReply> activities.

## Activity library

If you choose the **Activity Library** template, Visual Studio creates an activity definition in XAML. Workflow Designer opens and displays the canvas for your custom activity. Drag an activity from **Toolbox** to the design surface to include it in your custom activity.

> [!NOTE]
> You're allowed only one child activity in the body of your custom activity. However, that child activity could be a composite activity, such as a <xref:System.Activities.Statements.Sequence> activity or <xref:System.Activities.Statements.Flowchart> activity.

## Activity designer library

If you choose the **Activity Designer Library** template, Visual Studio creates an activity designer definition in XAML and a code-behind implementation file. The Workflow Designer opens and displays the canvas for your activity designer. Drag Windows Presentation Foundation (WPF) controls from **Toolbox** to the design surface to use them in your custom activity designer.

For an example of how to implement a custom activity designer, see [How to: Create a custom activity designer](/dotnet/framework/windows-workflow-foundation/how-to-create-a-custom-activity-designer).

> [!NOTE]
> Custom activity designers can be used for custom activities and for default .NET Framework activities.

## See also

- [Use the Workflow Designer](developing-applications-with-the-workflow-designer.md)
- [Design workflows (.NET Framework)](/dotnet/framework/windows-workflow-foundation/designing-workflows)