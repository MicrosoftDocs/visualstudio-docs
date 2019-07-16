---
title: "Managing Configuration Options | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "configuration options"
ms.assetid: 596c28ee-f48d-4252-a5c4-f730c43a39e6
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Managing Configuration Options
When you create a new project type, you must manage project and solution configuration settings that determine how your project will be built, packaged, deployed, and run. The following topics discuss project and solution configuration.

## In This Section
- [Overview](../../extensibility/internals/configuration-options-overview.md)

 Describes how projects in [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] can support multiple configurations.

- [Property Pages](../../extensibility/internals/property-pages.md)

 Explains that users can view and change project configuration dependent properties and independent properties by using property pages.

- [Solution Configuration](../../extensibility/internals/solution-configuration.md)

 Provides information about what is stored in solution configurations and how solution configurations direct the behavior of the **Start** and **Build** commands.

- [Project Configuration Object](../../extensibility/internals/project-configuration-object.md)

 Explains how the project configuration object manages the display of configuration information to the UI.

- [Project Configuration for Building](../../extensibility/internals/project-configuration-for-building.md)

 Explains how a list of solution configurations for a particular solution is managed by the **Solution Configurations** dialog box.

- [Project Configuration for Managing Deployment](../../extensibility/internals/project-configuration-for-managing-deployment.md)

 Defines the act of deployment and the two ways [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] supports projects that support deployment.

- [Project Configuration for Output](../../extensibility/internals/project-configuration-for-output.md)

 Explains the build processes that every configuration can support and the interfaces and methods by which output items can be made available.

## Related Sections
- [Project Types](../../extensibility/internals/project-types.md)

 Provides an overview of projects as the basic building blocks of the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] integrated development environment (IDE). Links are provided to additional topics that explain how projects control building and compiling code.