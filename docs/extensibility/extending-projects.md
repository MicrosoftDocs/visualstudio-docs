---
title: Extending Projects
description: Learn how to create your own custom project types in the Visual Studio SDK and how to manage different types of Visual Studio solutions.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- solutions [Visual Studio]
- projects [Visual Studio]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Extend projects

Projects and solutions are the ways Visual Studio organizes code and resource files into compilation and deployment units. You can find more information about projects in [Projects (Visual Studio SDK)](../extensibility/extending-projects.md).

 You can create your own project types with the Visual Studio SDK and the Managed Package Framework for Projects, which you can download at [Managed Package Framework for Projects](https://github.com/tunnelvisionlabs/MPFProj10). To understand how custom projects are implemented, see [New project generation: Under the hood, part one](../extensibility/internals/new-project-generation-under-the-hood-part-one.md) and [New project generation: Under the hood, part two](../extensibility/internals/new-project-generation-under-the-hood-part-two.md).

 The topics in this section describe how to create custom projects and how to manage different types of Visual Studio solution.

## In this section

- [Create a basic project system, part 1](../extensibility/creating-a-basic-project-system-part-1.md) describes how to create a custom project system.

- [Create a basic project system, part 2](../extensibility/creating-a-basic-project-system-part-2.md) describes how to create a custom project system.

- [Save data in project files](../extensibility/saving-data-in-project-files.md) explains how add to project (<em>.</em>proj*) files.

- [Verify subtypes of a project at run time](../extensibility/verifying-subtypes-of-a-project-at-run-time.md) explains how to verify the subtype of a project at run time.

- [Add and remove property pages](../extensibility/adding-and-removing-property-pages.md) explains how to customize the property pages for your custom project.

- [Add an attribute to a project item](../extensibility/adding-an-attribute-to-a-project-item.md) explains how to add an attribute to a custom project item.

- [Persist the property of a project item](../extensibility/persisting-the-property-of-a-project-item.md) explains how to persist the properties of a custom project item.

- [Manage universal Windows projects](../extensibility/managing-universal-windows-projects.md) explains how to manage universal projects.
