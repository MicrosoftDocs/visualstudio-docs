---
title: "When to Create Project Types | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "project types, conditions for creating"
ms.assetid: 26adc860-ee4a-4f5c-95e1-e41b207dd7e6
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# When to Create Project Types
Creating a new project type provides a basis for customizing [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] for your users. However, creating a new project type is not required for all [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] customizations. The following guidelines should help you determine whether a new project type is required for your scenario.

## Create a New Project Type
 You must create a project type if you want to customize [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] to act in one or more of the following ways:

- Participate in build, deploy, configurations, and source control.

- Offer debugging support.

- Display project items in **Solution Explorer**.

- Use the **Open Project** or **New Project** dialog box.

- Support project nesting.

## Extend an Existing Project Type
 You might want to create a new project type that can use [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] in the following ways to modify or extend the behavior of an existing project type, for example, modifying the build process for [!INCLUDE[vcprvc](../../code-quality/includes/vcprvc_md.md)] projects:

- Work with multiple files as a single unit.

- Display a single file as a hierarchy of sub-items.

- Display a command context around editors.

- Display a service context for editors.

## Use an Existing Project Type
 Creating a new project is sometimes not necessary. The following table shows the tasks that you do not have to create a project type for.

|Task|Description|
|----------|-----------------|
|Handling commands|Any VSPackage can handle commands.|
|Building an editor|Custom editors can be registered. For more information, see [Document Windows and Editors](https://msdn.microsoft.com/library/603625e1-62b6-413a-bc44-089346e166bc).|
|Owning windows|You can create both tool and document windows without adding a new project type.|
|Exposing properties in the Properties window|All objects can expose properties.|

## Create a Project Subtype
 You can use project subtypes to extend a managed project type without having to create a new project type. Project subtypes use COM aggregation to extend managed projects written in Microsoft [!INCLUDE[vbprvb](../../code-quality/includes/vbprvb_md.md)] or [!INCLUDE[csprcs](../../data-tools/includes/csprcs_md.md)]. With COM aggregation, you can reuse much of the managed project system implementation and  still customize for a particular scenario through aggregation and the use of supporting interfaces. For more information about project subtypes, see [Project Subtypes](../../extensibility/internals/project-subtypes.md).

## See also
- [Document Windows and Editors](https://msdn.microsoft.com/library/603625e1-62b6-413a-bc44-089346e166bc)
- [Checklist: Creating New Project Types](../../extensibility/internals/checklist-creating-new-project-types.md)
- [Hierarchies in Visual Studio](../../extensibility/internals/hierarchies-in-visual-studio.md)