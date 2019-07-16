---
title: "Interaction Patterns"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
ms.assetid: a3643792-b0df-481c-bc35-576f948e04cf
caps.latest.revision: 5
ms.author: gregvanl
manager: jillfra
---
# Interaction Patterns for Visual Studio
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

## Overview
 A design pattern, in general, is the core of a design that can be applied in specific situations to solve problems with similar sets of constraints. Feature and system designers use these design patterns as starting points, which can then be adapted to their specific situation.

 Visual Studio has a library of common interaction patterns that should be considered when building new features. There are two core contexts for our design patterns: Visual Studio Client (devenv) and Visual Studio Online. For some design problems, there is a ubiquitous pattern that works well in all situations. In many cases, however, the solution might be different for UI that is being presented within a browser and that which is hosted on a client application.

### Visual Studio Client pattern types

|Pattern type|Description|Examples|
|------------------|-----------------|--------------|
|**Application-level patterns**|High-level patterns common to the application, determining or displaying application context, and containing composite and control patterns within them|-   Tool windows<br />-   Document windows|
|**Composite patterns**|Common patterns that may span across application patterns, or a recognized pattern made up of several controls in a distinct configuration|-   View switching<br />-   List builders<br />-   Displaying data<br />-   Notifications<br />-   Validation<br />-   Selection models|
|**Control patterns**|Specifics about how low-level controls are expected to behave|-   Tree views<br />-   Editing within a grid control|

## Application patterns
 At a high level, the Visual Studio interface comprises multiple windows, dialogs, commands, and toolbars within a single IDE. The Visual Studio hierarchy determines context and drives menus. The key integration points in the user interface of the IDE are document windows, tool windows, projects, the command structure, the text editor, the toolbox, the Properties window, and Tools > Options.

 There are basic usage patterns for each of the key integration points in the user interface of the IDE:

- [Menus and Commands for Visual Studio](../../extensibility/ux-guidelines/menus-and-commands-for-visual-studio.md)

- [Application Patterns for Visual Studio](../../extensibility/ux-guidelines/application-patterns-for-visual-studio.md)

  - [Window interactions](../../extensibility/ux-guidelines/application-patterns-for-visual-studio.md#BKMK_WindowInteractions)

  - [Tool windows](../../extensibility/ux-guidelines/application-patterns-for-visual-studio.md#BKMK_ToolWindows)

  - [Document editor conventions](../../extensibility/ux-guidelines/application-patterns-for-visual-studio.md#BKMK_DocumentEditorConventions)

  - [Dialogs](../../extensibility/ux-guidelines/application-patterns-for-visual-studio.md#BKMK_Dialogs)

  - [Projects](../../extensibility/ux-guidelines/application-patterns-for-visual-studio.md#BKMK_Projects)

## Common control patterns
 Control patterns are mainly about how individual controls are expected to behave. This is one area in which consistency is most critical.

 Most common controls in Visual Studio should follow the Desktop Windows guidelines. Our guidelines only include areas in which we need to augment common conventions with Visual Studio-specific interactions, or places in which we supersede the guidelines entirely in order to tailor Visual Studio to meet the needs of our sophisticated users.

- [Common Control Patterns for Visual Studio](../../extensibility/ux-guidelines/common-control-patterns-for-visual-studio.md)

  - [Common controls](../../extensibility/ux-guidelines/common-control-patterns-for-visual-studio.md#BKMK_CommonControls)

  - [Text controls](../../extensibility/ux-guidelines/common-control-patterns-for-visual-studio.md#BKMK_TextControls)

  - [Buttons and hyperlinks](../../extensibility/ux-guidelines/common-control-patterns-for-visual-studio.md#BKMK_ButtonsAndHyperlinks)

## Composite patterns
 There are a number of ways that users expect to accomplish tasks. Wherever possible, features should be designed to use those patterns both for interaction and visual design.

 While there are many composite patterns within Visual Studio, some of the most important with regards to consistency are:

- [Composite Patterns for Visual Studio](../../extensibility/ux-guidelines/composite-patterns-for-visual-studio.md)

  - [On-object UI and peeking](../../extensibility/ux-guidelines/composite-patterns-for-visual-studio.md#BKMK_OnObjectUI)

  - [Selection models](../../extensibility/ux-guidelines/composite-patterns-for-visual-studio.md#BKMK_SelectionModels)

  - [Persistence and saving settings](../../extensibility/ux-guidelines/composite-patterns-for-visual-studio.md#BKMK_PersistenceAndSavingSettings)

  - [Touch input](../../extensibility/ux-guidelines/composite-patterns-for-visual-studio.md#BKMK_TouchInput)
