---
title: "Developing Applications with the Workflow Designer"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
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
# Developing Applications with the Workflow Designer
The [!INCLUDE[wfd1](../workflowdesigner/includes/wfd1_md.md)] is a visual designer and debugger for the graphical construction and debugging of [!INCLUDE[wf](../workflowdesigner/includes/wf_md.md)] applications in the [!INCLUDE[netfx40_long](../workflowdesigner/includes/netfx40_long_md.md)] that is hosted in the [!INCLUDE[vs2010](../codequality/includes/vs2010_md.md)] development environment. It enables you to compose a composite workflow application, activity library, or [!INCLUDE[indigo1](../workflowdesigner/includes/indigo1_md.md)] service through the use of templates and activity designers. [!INCLUDE[crabout](../codequality/includes/crabout_md.md)] workflows, see the [Windows Workflow Foundation &#91;.NET Framework 4&#93;](../Topic/Windows%20Workflow%20Foundation.md).  
  
 The following are several new design features that set this new version of the [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)] apart from older versions of the [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)]:  
  
-   The [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)] is built using [!INCLUDE[avalon1](../workflowdesigner/includes/avalon1_md.md)]. This enhances the activity designer experience and improves performance for large and complex workflows.  
  
-   Custom activities are now designed with [!INCLUDE[avalon2](../workflowdesigner/includes/avalon2_md.md)], using XAML and the programming model for creating activity designers has been simplified.  
  
-   A flowchart activity has been implemented, so you can visualize program flow using the familiar flowchart modeling style.  
  
-   The [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)] has a new variable designer that allows you to declare and scope variables within your workflows, binding them to activities.  
  
-   In [!INCLUDE[vs2010](../codequality/includes/vs2010_md.md)], the [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)] provides full IntelliSense capabilities when authoring Visual Basic expressions within your [!INCLUDE[netfx40_short](../workflowdesigner/includes/netfx40_short_md.md)] workflows.  
  
-   The debugging experience now extends into XAML, allowing you to set breakpoints in your XAML workflow definition and to step into your XAML code at runtime, which provides an experience similar to that in managed code.  
  
-   Rehosting the [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)] outside of [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] is greatly simplified compared to previous versions, now requiring only a few lines of code.  
  
-   The new \<xref:System.Activities.Statements.Flowchart> activity and its [Flowchart](../workflowdesigner/flowchart-activity-designer.md) allow you to visualize your program flow using the familiar flowchart modeling style.  
  
-   The messaging activities have been enhanced, allowing you to write fully-declarative (no code) [!INCLUDE[indigo1](../workflowdesigner/includes/indigo1_md.md)] services.  
  
-   The **Add Service Reference…** functionality allows you to generate activities automatically that access Web services.  
  
## In This Section  
 [Using the Workflow Designer](../workflowdesigner/using-the-workflow-designer.md)  
 Shows how to create new activities and workflow projects using the built-in designers and how to use other tools provided by the designer to handle arguments, variables, expressions, imports, and breadcrumb navigation.  
  
 [Using the Activity Designers](../workflowdesigner/using-the-activity-designers.md)  
 Describes the categories of activities and templates and their designers that are system-provided.  
  
 [Debugging Workflows with the Workflow Designer](../workflowdesigner/debugging-workflows-with-the-workflow-designer.md)  
 Describe how to perform traditional debugging procedures as well as debugging XAML and expressions.  
  
 [Workflow Designer UI Help](../workflowdesigner/workflow-designer-ui-help.md)  
 Contains context-sensitive help topics for dialog boxes provided by [!INCLUDE[wfd1](../workflowdesigner/includes/wfd1_md.md)], as well as guidance on designer shell features, keyboard shortcuts and error messages.  
  
 [Developing Workflow Applications Targeting the .NET 3.0 or .NET 3.5 Framework](../workflowdesigner/developing-workflow-applications-targeting-the-.net-3.0-or-.net-3.5-framework.md)  
 Contains guidance on using the legacy designer that targets the [!INCLUDE[netfx35_long](../workflowdesigner/includes/netfx35_long_md.md)] or the [!INCLUDE[vstecwinfx](../workflowdesigner/includes/vstecwinfx_md.md)].  
  
 [Designer ReHosting &#91;WF Samples&#93;](../Topic/Designer%20ReHosting.md)  
 This sample shows how to create the WPF layout to contain the designer.  
  
 [Custom Activity Designers](../Topic/Custom%20Activity%20Designers.md)  
 This section contains activity samples that use custom designers for display in the workflow designer.