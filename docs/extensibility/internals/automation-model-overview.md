---
title: "Automation Model Overview | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "automation [Visual Studio SDK], about automation"
  - "extensibility"
ms.assetid: 12b6d6db-0d22-4aaa-aa7d-1365f759b7b0
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Automation model overview
The automation model consists of a set of objects against which you can write a Visual Studio add-in or extension. An add-in is an application that can manipulate the Visual Studio environment and automate common tasks. A Visual Studio extension can create custom Visual Studio components or add to the functionality of standard components such as the text editor.

## Objects in the automation model
 The automation model consists of related groups of objects that control major facets of the common environment. The following diagram shows the extensive set of Visual Studio objects that compose the automation model.

 ![Visual Studio automation object chart](../../extensibility/internals/media/vsvisualstudioautomationobjectchart.gif "vsVisualStudioAutomationObjectChart")

 For more information, see [Extend the Visual Studio environment](https://msdn.microsoft.com/Library/4173a963-7ac7-4966-9bb7-e28a9d9f6792).

 The environment provides a model for different functional areas. For instance, there is a code model for various elements that you might find in code. There is a document model for various document elements. One area, the project area, is of particular interest to VSPackage providers. You will likely want your new project types to contribute to the automation model in much the same way as [!INCLUDE[vcprvc](../../code-quality/includes/vcprvc_md.md)] and [!INCLUDE[vbprvb](../../code-quality/includes/vbprvb_md.md)] contribute to the automation model. That process is outlined in [Provide automation for VSPackages](../../extensibility/internals/providing-automation-for-vspackages.md).

 Places where you can consider extending the automation model of the environment:

- Project

- Document

- Code

- Build

For more information on automation, see [Automation and extensibility for Visual Studio](/visualstudio/extensibility/extensibility-in-visual-studio?view=vs-2015). This document and the documents it provides links to, help you make decisions regarding how you should provide automation for your VSPackage.

## See also
- [How to: Create an add-in](https://msdn.microsoft.com/Library/50be56d2-e3a5-4cd2-8569-2a0666b268ce)