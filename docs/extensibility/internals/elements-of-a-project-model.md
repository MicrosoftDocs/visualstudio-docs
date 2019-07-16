---
title: "Elements of a Project Model | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "projects [Visual Studio SDK], implementation considerations"
  - "project models"
  - "projects [Visual Studio SDK], elements"
ms.assetid: a1dbe0dc-68da-45d7-8704-5b43ff7e4fc4
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Elements of a project model
The interfaces and implementations of all projects in [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] share a basic structure: the project model for your project type. In your project model, which is the VSPackage you are developing, you create objects that comply with your design decisions and work together with global functionality provided by the IDE. Although you control how a project item is persisted, for example, you do not control notification that a file must be persisted. When a user places the focus on an open project item and chooses **Save** on the **File** menu on the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] menu bar, your project type code must intercept the command from the IDE, persist the file, and send notification back to the IDE that the file is no longer changed.

 Your VSPackage interacts with the IDE through services that provide access to the IDE interfaces. For example, through particular services, you monitor and route commands and provide context information for selections made in the project. All the global IDE functionality needed for your VSPackage is provided by services. For more information about services, see [How to: Get a service](../../extensibility/how-to-get-a-service.md).

 Other implementation considerations:

- A single project model can contain more than one project type.

- Project types and the attendant project factories are registered independently with GUIDs.

- Each project must have a template file or wizard to initialize the new project file when a user creates a new project through the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] UI. For example, the [!INCLUDE[vcprvc](../../code-quality/includes/vcprvc_md.md)] templates initialize what eventually become .vcproj files.

  The following illustration shows the primary interfaces, services, and objects that compose a typical project implementation. You can use the application helper, `HierUtil7`, to create the underlying objects and other programming boilerplate. For more information about the `HierUtil7` application helper, see [Use HierUtil7 project classes to implement a project type (C++)](https://msdn.microsoft.com/library/a5c16a09-94a2-46ef-87b5-35b815e2f346).

  ![Visual Studio project model graphic](../../extensibility/internals/media/vsprojectmodel.gif "vsProjectModel")
  Project model

  For more information about the interfaces and services listed in the previous diagram, and other optional interfaces not included in the diagram, see [Project model core components](../../extensibility/internals/project-model-core-components.md).

  Projects can support commands and therefore must implement the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface to participate in command routing through the command context GUIDs.

## See also
- [Checklist: Create new project types](../../extensibility/internals/checklist-creating-new-project-types.md)
- [Use HierUtil7 project classes to implement a project type (C++)](https://msdn.microsoft.com/library/a5c16a09-94a2-46ef-87b5-35b815e2f346)
- [Project model core components](../../extensibility/internals/project-model-core-components.md)
- [Create project instances by using project factories](../../extensibility/internals/creating-project-instances-by-using-project-factories.md)
- [How to: Get a service](../../extensibility/how-to-get-a-service.md)
- [Create project types](../../extensibility/internals/creating-project-types.md)
