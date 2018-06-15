---
title: "Developing Applications with the Workflow Designer"
ms.date: 11/04/2016
ms.topic: conceptual
ms.prod: visual-studio-dev15
ms.technology: vs-workflow-designer
f1_keywords:
  - "DefaultWorkflowDesigner"
  - "DefaultWorkflowDesigner.UI"
helpviewer_keywords:
  - "Visual Studio 2010 Workflow Designer [WFD], overview"
  - "Workflow Designer [WFD]"
  - "Visual Studio 2010 Workflow Designer [WFD]"
  - "Workflow Designer [WFD], overview"
ms.assetid: 4cd062b1-b496-4668-bbc1-ee85545e066d
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# Developing Applications with the Workflow Designer

The Windows Workflow Designer is a visual designer and debugger for the graphical construction and debugging of Windows Workflow Foundation (WF) applications in the .NET Framework 4 that is hosted in the Visual Studio 2010 development environment. It enables you to compose a composite workflow application, activity library, or Windows Communication Foundation (WCF) service through the use of templates and activity designers. For more information about workflows, see the [Windows Workflow Foundation &#91;.NET Framework 4&#93;](http://msdn.microsoft.com/Library/9a23ea6b-d600-483e-89cd-8889cfec5f66).

 The following are several new design features that set this new version of the Workflow Designer apart from older versions of the Workflow Designer:

-   The Workflow Designer is built using Windows Presentation Foundation (WPF). This enhances the activity designer experience and improves performance for large and complex workflows.

-   Custom activities are now designed with [!INCLUDE[avalon2](../workflow-designer/includes/avalon2_md.md)], using XAML and the programming model for creating activity designers has been simplified.

-   A flowchart activity has been implemented, so you can visualize program flow using the familiar flowchart modeling style.

-   The Workflow Designer has a new variable designer that allows you to declare and scope variables within your workflows, binding them to activities.

-   In Visual Studio 2010, the Workflow Designer provides full IntelliSense capabilities when authoring Visual Basic expressions within your .NET Framework 4 workflows.

-   The debugging experience now extends into XAML, allowing you to set breakpoints in your XAML workflow definition and to step into your XAML code at runtime, which provides an experience similar to that in managed code.

-   Rehosting the Workflow Designer outside of Visual Studio is greatly simplified compared to previous versions, now requiring only a few lines of code.

-   The new <xref:System.Activities.Statements.Flowchart> activity and its [Flowchart](../workflow-designer/flowchart-activity-designer.md) allow you to visualize your program flow using the familiar flowchart modeling style.

-   The messaging activities have been enhanced, allowing you to write fully-declarative (no code) Windows Communication Foundation (WCF) services.

-   The **Add Service Reference...** functionality allows you to generate activities automatically that access Web services.