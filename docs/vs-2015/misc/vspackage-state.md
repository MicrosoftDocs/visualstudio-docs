---
title: "VSPackage State | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "devlang-csharp"
ms.topic: conceptual
helpviewer_keywords: 
  - "state, VSPackages"
  - "VSPackages, managing application state"
  - "state persistence"
ms.assetid: 6056a9ea-e7a8-481c-9fc8-340229fa12d9
caps.latest.revision: 25
manager: jillfra
---
# VSPackage State
Many factors determine the set of persisted values, or state, of a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] application.  
  
- Projects have project and configuration properties.  
  
- Solutions have properties.  
  
- User settings determine the size and position of document windows, tool windows, docking state, and keyboard shortcuts.  
  
- Applications can have options that a user sets.  
  
- Objects that an application creates can have properties of their own.  
  
  Here are some of the ways that a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] application state can be managed:  
  
- Through the project and solution property pages.  
  
- Through the **Import and Export Settings Wizard**, which enables a user to move settings from one computer to another.  
  
- Through the **Options** dialog box, which includes options related to applications.  
  
- Through the **Properties** window, which exposes properties of objects.  
  
- Through Automation. An application can access VSPackage and object properties that have been exposed to Automation.  
  
  Underlying the application state are various persistence mechanisms that enable the application state to be saved and restored.  
  
## In This Section  
 [Support for State Persistence](../misc/support-for-state-persistence.md)  
 Lists common strategies for saving, restoring, and resetting the state of a VSPackage.  
  
 [Options and Options Pages](../extensibility/internals/options-and-options-pages.md)  
 Introduces general and custom Options pages and explains how to implement them.  
  
 [Creating an Options Page](../extensibility/creating-an-options-page.md)  
 Explains how to create two Options pages, a simple page and a custom page.  
  
 [Support for Settings Categories](../misc/support-for-settings-categories.md)  
 Discusses user settings and how they are created and persisted.  
  
 [Creating a Settings Category](../extensibility/creating-a-settings-category.md)  
 Explains how to create a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] settings category and use it to save values to and restore values from a settings file.  
  
 [Extending Properties and the Property Window](../extensibility/extending-properties-and-the-property-window.md)  
 Explains how to display and change the value of an object in the **Properties** window.  
  
 [Exposing Properties to the Properties Window](../extensibility/exposing-properties-to-the-properties-window.md)  
 Explains how to expose the public properties of an object to the **Properties** window.  
  
 [Support for Project and Configuration Properties](../extensibility/internals/support-for-project-and-configuration-properties.md)  
 Explains how to display and change project and configuration properties.  
  
 [Getting Project Properties](../extensibility/getting-project-properties.md)  
 Guides you through the steps of creating a managed VSPackage that displays project properties in a tool window.  
  
 [Using the Settings Store](../extensibility/using-the-settings-store.md)  
 Explains the Settings Store persistence mechanism and how to use it.  
  
## Related Sections  
 [VSPackages](../extensibility/internals/vspackages.md)  
 Provides a general orientation to topics that explain how to create and use VSPackages.