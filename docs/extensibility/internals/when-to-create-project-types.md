---
title: When to Create Project Types
description: Learn how to determine whether a new project type is required for customizing Visual Studio for your users.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- project types, conditions for creating
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# When to Create Project Types

Creating a new project type provides a basis for customizing Visual Studio for your users. However, creating a new project type is not required for all Visual Studio customizations. The following guidelines should help you determine whether a new project type is required for your scenario.

## Create a New Project Type
 You must create a project type if you want to customize Visual Studio to act in one or more of the following ways:

- Participate in build, deploy, configurations, and source control.

- Offer debugging support.

- Display project items in **Solution Explorer**.

- Use the **Open Project** or **New Project** dialog box.

- Support project nesting.

## Extend an Existing Project Type
 You might want to create a new project type that can use Visual Studio in the following ways to modify or extend the behavior of an existing project type, for example, modifying the build process for Visual C++ projects:

- Work with multiple files as a single unit.

- Display a single file as a hierarchy of sub-items.

- Display a command context around editors.

- Display a service context for editors.

## Use an Existing Project Type
 Creating a new project is sometimes not necessary. The following table shows the tasks that you do not have to create a project type for.

|Task|Description|
|----------|-----------------|
|Handling commands|Any VSPackage can handle commands.|
|Building an editor|Custom editors can be registered. For more information, see [Document Windows and Editors](/previous-versions/bb165691(v=vs.100)).|
|Owning windows|You can create both tool and document windows without adding a new project type.|
|Exposing properties in the Properties window|All objects can expose properties.|

## Create a Project Subtype
 You can use project subtypes to extend a managed project type without having to create a new project type. Project subtypes use COM aggregation to extend managed projects written in Microsoft Visual Basic or Visual C#. With COM aggregation, you can reuse much of the managed project system implementation and  still customize for a particular scenario through aggregation and the use of supporting interfaces. For more information about project subtypes, see [Project Subtypes](../../extensibility/internals/project-subtypes.md).

## Related content
- [Document Windows and Editors](/previous-versions/bb165691(v=vs.100))
- [Checklist: Creating New Project Types](../../extensibility/internals/checklist-creating-new-project-types.md)
- [Hierarchies in Visual Studio](../../extensibility/internals/hierarchies-in-visual-studio.md)