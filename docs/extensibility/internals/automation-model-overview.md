---
title: Automation Model Overview
description: Learn about the Visual Studio automation model that consists of a set of objects against which you can write a Visual Studio add-in or extension.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- automation [Visual Studio SDK], about automation
- extensibility
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Automation model overview

The automation model consists of a set of objects against which you can write a Visual Studio add-in or extension. An add-in is an application that can manipulate the Visual Studio environment and automate common tasks. A Visual Studio extension can create custom Visual Studio components or add to the functionality of standard components such as the text editor.

## Objects in the automation model
 The automation model consists of related groups of objects that control major facets of the common environment. The following diagram shows the extensive set of Visual Studio objects that compose the automation model.

 ![Visual Studio automation object chart](../../extensibility/internals/media/vsvisualstudioautomationobjectchart.gif "vsVisualStudioAutomationObjectChart")

 For more information, see [Extend the Visual Studio environment](/previous-versions/esk3eey8(v=vs.140)).

 The environment provides a model for different functional areas. For instance, there is a code model for various elements that you might find in code. There is a document model for various document elements. One area, the project area, is of particular interest to VSPackage providers. You will likely want your new project types to contribute to the automation model in much the same way as Visual C++ and Visual Basic contribute to the automation model. That process is outlined in [Provide automation for VSPackages](../../extensibility/internals/providing-automation-for-vspackages.md).

 Places where you can consider extending the automation model of the environment:

- Project

- Document

- Code

- Build

For more information on automation, see [Automation and extensibility for Visual Studio](/previous-versions/visualstudio/visual-studio-2015/extensibility/extensibility-in-visual-studio?preserve-view=true&view=vs-2015). This document and the documents it provides links to, help you make decisions regarding how you should provide automation for your VSPackage.

## Contribute to the automation model

Visual Studio provides a set of automation interfaces for customizing the environment. The automation model is the object model that enables end users to create Visual Studio add-ins and extensions.

 In addition, it is appropriate for you, as a VSPackage developer, to contribute to the automation model; by doing this, you enable end users of your VSPackage to create add-ins and generally provide a consistent user model experience when they use your VSPackage in Visual Studio.

 To make the end-user experience consistent, you can follow a set of guidelines as you design your VSPackage so that the automation model for your VSPackage follows the ideas in Visual Studio.

## In this section

- [Provide automation for VSPackages](../../extensibility/internals/providing-automation-for-vspackages.md)

 Discusses the two main ways to provide automation for your VSPackage.

- [Expose project objects](../../extensibility/internals/exposing-project-objects.md)

 Provides step-by-step instructions for creating VSPackage-specific objects.

- [Project modeling](../../extensibility/internals/project-modeling.md)

 Explains the standard project objects that are required to create automation for your new project type and illustrates the path that project automation follows. This topic also provides listings of declarations and implementation for classes.

- [Expose events](../../extensibility/internals/exposing-events-in-the-visual-studio-sdk.md)

 Provides step-by-step instructions for creating events for your automation model.

- [Automation support for options pages](../../extensibility/internals/automation-support-for-options-pages.md)

 Describes how to return an automation object for supporting properties of a VSPackage's custom **Options** dialog box on the **Tool** menu by extending the `DTE.Properties` object.

- [Provide automation for code](../../extensibility/internals/providing-automation-for-code.md)

 Explains that creating an automation model for your code is not required. However, a link is provided in this topic that provides insightful information into code models.

- [How to: Provide automation for Windows](../../extensibility/internals/how-to-provide-automation-for-windows.md)

 Explains that providing automation is a good idea whenever you want to make automation objects available on a window, and the environment does not already provide a ready-made automation object. Discusses automation for tool windows and document windows.

- [Use the automation model](../../extensibility/internals/using-the-automation-model.md)

 Provides two code examples that show how an automation consumer obtains the initial project automation objects.

- [Automation for Configuration and SelectedItem objects](../../extensibility/internals/automation-for-configuration-and-selecteditem-objects.md)

 Provides information about automation for Configuration and SelectedItems objects.

## Reference
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.GetAutomationObject%2A>
 Provides a code sample that shows how a VSPackage participates in the DTE automation object model. Lists parameters, return values, and selected remarks.

## Related content
- [How to: Create an add-in](/previous-versions/80493a3w(v=vs.140))
