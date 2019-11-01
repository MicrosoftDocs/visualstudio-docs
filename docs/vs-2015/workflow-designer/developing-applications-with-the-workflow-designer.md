---
title: "Developing Applications with the Workflow Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "DefaultWorkflowDesigner"
  - "DefaultWorkflowDesigner.UI"
helpviewer_keywords:
  - "Visual Studio 2010 Workflow Designer [WFD], overview"
  - "Workflow Designer [WFD]"
  - "Visual Studio 2010 Workflow Designer [WFD]"
  - "Workflow Designer [WFD], overview"
ms.assetid: 4cd062b1-b496-4668-bbc1-ee85545e066d
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: jillfra
---
# Developing Applications with the Workflow Designer
The [!INCLUDE[wfd1](../includes/wfd1-md.md)] is a visual designer and debugger for the graphical construction and debugging of [!INCLUDE[wf](../includes/wf-md.md)] applications in the [!INCLUDE[netfx40_long](../includes/netfx40-long-md.md)] that is hosted in the [!INCLUDE[vs2010](../includes/vs2010-md.md)] development environment. It enables you to compose a composite workflow application, activity library, or [!INCLUDE[indigo1](../includes/indigo1-md.md)] service through the use of templates and activity designers. [!INCLUDE[crabout](../includes/crabout-md.md)] workflows, see the [Windows Workflow Foundation &#91;.NET Framework 4&#93;](https://msdn.microsoft.com/library/9a23ea6b-d600-483e-89cd-8889cfec5f66).

 The following are several new design features that set this new version of the [!INCLUDE[wfd2](../includes/wfd2-md.md)] apart from older versions of the [!INCLUDE[wfd2](../includes/wfd2-md.md)]:

- The [!INCLUDE[wfd2](../includes/wfd2-md.md)] is built using [!INCLUDE[avalon1](../includes/avalon1-md.md)]. This enhances the activity designer experience and improves performance for large and complex workflows.

- Custom activities are now designed with [!INCLUDE[avalon2](../includes/avalon2-md.md)], using XAML and the programming model for creating activity designers has been simplified.

- A flowchart activity has been implemented, so you can visualize program flow using the familiar flowchart modeling style.

- The [!INCLUDE[wfd2](../includes/wfd2-md.md)] has a new variable designer that allows you to declare and scope variables within your workflows, binding them to activities.

- In [!INCLUDE[vs2010](../includes/vs2010-md.md)], the [!INCLUDE[wfd2](../includes/wfd2-md.md)] provides full IntelliSense capabilities when authoring Visual Basic expressions within your [!INCLUDE[netfx40_short](../includes/netfx40-short-md.md)] workflows.

- The debugging experience now extends into XAML, allowing you to set breakpoints in your XAML workflow definition and to step into your XAML code at runtime, which provides an experience similar to that in managed code.

- Rehosting the [!INCLUDE[wfd2](../includes/wfd2-md.md)] outside of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] is greatly simplified compared to previous versions, now requiring only a few lines of code.

- The new <xref:System.Activities.Statements.Flowchart> activity and its [Flowchart](../workflow-designer/flowchart-activity-designer.md) allow you to visualize your program flow using the familiar flowchart modeling style.

- The messaging activities have been enhanced, allowing you to write fully-declarative (no code) [!INCLUDE[indigo1](../includes/indigo1-md.md)] services.

- The **Add Service Reference…** functionality allows you to generate activities automatically that access Web services.

## In This Section
 [Using the Workflow Designer](../workflow-designer/using-the-workflow-designer.md)
 Shows how to create new activities and workflow projects using the built-in designers and how to use other tools provided by the designer to handle arguments, variables, expressions, imports, and breadcrumb navigation.

 [Using the Activity Designers](../workflow-designer/using-the-activity-designers.md)
 Describes the categories of activities and templates and their designers that are system-provided.

 [Debugging Workflows with the Workflow Designer](../workflow-designer/debugging-workflows-with-the-workflow-designer.md)
 Describe how to perform traditional debugging procedures as well as debugging XAML and expressions.

 [Workflow Designer UI Help](../workflow-designer/workflow-designer-ui-help.md)
 Contains context-sensitive help topics for dialog boxes provided by [!INCLUDE[wfd1](../includes/wfd1-md.md)], as well as guidance on designer shell features, keyboard shortcuts and error messages.

 [Developing Workflow Applications Targeting the .NET 3.0 or .NET 3.5 Framework](../workflow-designer/developing-workflow-applications-targeting-the-dotnet-3-0-or-dotnet-3-5-framework.md)
 Contains guidance on using the legacy designer that targets the [!INCLUDE[netfx35_long](../includes/netfx35-long-md.md)] or the [!INCLUDE[vstecwinfx](../includes/vstecwinfx-md.md)].

 [Designer ReHosting &#91;WF Samples&#93;](https://msdn.microsoft.com/library/b676ad31-5f64-4d84-9a36-b4d7113a2f4d)
 This sample shows how to create the WPF layout to contain the designer.

 [Custom Activity Designers](https://msdn.microsoft.com/library/dcf14dca-ce6d-4278-96ba-062f0a679075)
 This section contains activity samples that use custom designers for display in the workflow designer.