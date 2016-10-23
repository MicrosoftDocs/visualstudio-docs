---
title: "Developing Applications with the Workflow Designer"
ms.custom: na
ms.date: 10/06/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 4cd062b1-b496-4668-bbc1-ee85545e066d
caps.latest.revision: 17
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
# Developing Applications with the Workflow Designer
The Windows Workflow Designer is a visual designer and debugger for the graphical construction and debugging of Windows Workflow Foundation (WF) applications in the .NET Framework version 4 that is hosted in the Visual Studio 2010 development environment. It enables you to compose a composite workflow application, activity library, or Windows Communication Foundation (WCF) service through the use of templates and activity designers. For more information about workflows, see the [Windows Workflow Foundation &#91;.NET Framework 4&#93;](../Topic/Windows%20Workflow%20Foundation.md).  
  
 The following are several new design features that set this new version of the Workflow Designer apart from older versions of the Workflow Designer:  
  
-   The Workflow Designer is built using Windows Presentation Foundation (WPF). This enhances the activity designer experience and improves performance for large and complex workflows.  
  
-   Custom activities are now designed with WPF, using XAML and the programming model for creating activity designers has been simplified.  
  
-   A flowchart activity has been implemented, so you can visualize program flow using the familiar flowchart modeling style.  
  
-   The Workflow Designer has a new variable designer that allows you to declare and scope variables within your workflows, binding them to activities.  
  
-   In Visual Studio 2010, the Workflow Designer provides full IntelliSense capabilities when authoring Visual Basic expressions within your .NET Framework 4 workflows.  
  
-   The debugging experience now extends into XAML, allowing you to set breakpoints in your XAML workflow definition and to step into your XAML code at runtime, which provides an experience similar to that in managed code.  
  
-   Rehosting the Workflow Designer outside of Visual Studio is greatly simplified compared to previous versions, now requiring only a few lines of code.  
  
-   The new <xref:System.Activities.Statements.Flowchart?qualifyHint=False> activity and its [Flowchart](../WF_Design/Flowchart-Activity-Designer.md) allow you to visualize your program flow using the familiar flowchart modeling style.  
  
-   The messaging activities have been enhanced, allowing you to write fully-declarative (no code) Windows Communication Foundation (WCF) services.  
  
-   The **Add Service Reference…** functionality allows you to generate activities automatically that access Web services.  
  
## In This Section  
 [Using the Workflow Designer](../WF_Design/Using-the-Workflow-Designer.md)  
 Shows how to create new activities and workflow projects using the built-in designers and how to use other tools provided by the designer to handle arguments, variables, expressions, imports, and breadcrumb navigation.  
  
 [Using the Activity Designers](../WF_Design/Using-the-Activity-Designers.md)  
 Describes the categories of activities and templates and their designers that are system-provided.  
  
 [Debugging Workflows with the Workflow Designer](../WF_Design/Debugging-Workflows-with-the-Workflow-Designer.md)  
 Describe how to perform traditional debugging procedures as well as debugging XAML and expressions.  
  
 [Workflow Designer UI Help](../WF_Design/Workflow-Designer-UI-Help.md)  
 Contains context-sensitive help topics for dialog boxes provided by Windows Workflow Designer, as well as guidance on designer shell features, keyboard shortcuts and error messages.  
  
 [Developing Workflow Applications Targeting the .NET 3.0 or .NET 3.5 Framework](../WF_Design/Developing-Workflow-Applications-Targeting-the-.NET-3.0-or-.NET-3.5-Framework.md)  
 Contains guidance on using the legacy designer that targets the .NET Framework version 3.5 or the WinFX.  
  
 [Designer ReHosting &#91;WF Samples&#93;](../Topic/Designer%20ReHosting.md)  
 This sample shows how to create the WPF layout to contain the designer.  
  
 [Custom Activity Designers](../Topic/Custom%20Activity%20Designers.md)  
 This section contains activity samples that use custom designers for display in the workflow designer.