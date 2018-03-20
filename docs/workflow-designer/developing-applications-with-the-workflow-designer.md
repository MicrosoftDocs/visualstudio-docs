---
title: "Developing Applications with the Workflow Designer | Microsoft Docs"
ms.date: "11/04/2016"
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
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: 
  - "multiple"
---
# Developing Applications with the Workflow Designer

The Windows Workflow Designer is a visual designer and debugger for the graphical construction and debugging of [!INCLUDE[wf](../workflow-designer/includes/wf_md.md)] applications in the [!INCLUDE[netfx40_long](../workflow-designer/includes/netfx40_long_md.md)] that is hosted in the [!INCLUDE[vs2010](../misc/includes/vs2010_md.md)] development environment. It enables you to compose a composite workflow application, activity library, or [!INCLUDE[indigo1](../workflow-designer/includes/indigo1_md.md)] service through the use of templates and activity designers. For more information about workflows, see the [Windows Workflow Foundation &#91;.NET Framework 4&#93;](http://msdn.microsoft.com/Library/9a23ea6b-d600-483e-89cd-8889cfec5f66).

 The following are several new design features that set this new version of the [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] apart from older versions of the [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)]:

-   The [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] is built using [!INCLUDE[avalon1](../workflow-designer/includes/avalon1_md.md)]. This enhances the activity designer experience and improves performance for large and complex workflows.

-   Custom activities are now designed with [!INCLUDE[avalon2](../workflow-designer/includes/avalon2_md.md)], using XAML and the programming model for creating activity designers has been simplified.

-   A flowchart activity has been implemented, so you can visualize program flow using the familiar flowchart modeling style.

-   The [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] has a new variable designer that allows you to declare and scope variables within your workflows, binding them to activities.

-   In [!INCLUDE[vs2010](../misc/includes/vs2010_md.md)], the [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] provides full IntelliSense capabilities when authoring Visual Basic expressions within your [!INCLUDE[netfx40_short](../workflow-designer/includes/netfx40_short_md.md)] workflows.

-   The debugging experience now extends into XAML, allowing you to set breakpoints in your XAML workflow definition and to step into your XAML code at runtime, which provides an experience similar to that in managed code.

-   Rehosting the [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] outside of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] is greatly simplified compared to previous versions, now requiring only a few lines of code.

-   The new <xref:System.Activities.Statements.Flowchart> activity and its [Flowchart](../workflow-designer/flowchart-activity-designer.md) allow you to visualize your program flow using the familiar flowchart modeling style.

-   The messaging activities have been enhanced, allowing you to write fully-declarative (no code) [!INCLUDE[indigo1](../workflow-designer/includes/indigo1_md.md)] services.

-   The **Add Service Reference...** functionality allows you to generate activities automatically that access Web services.