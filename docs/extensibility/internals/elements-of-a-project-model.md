---
title: Elements of a Project Model
description: Learn about the elements of a project model and how the interfaces and implementations of all projects in Visual Studio share a basic structure.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- projects [Visual Studio SDK], implementation considerations
- project models
- projects [Visual Studio SDK], elements
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Elements of a project model

The interfaces and implementations of all projects in Visual Studio share a basic structure: the project model for your project type. In your project model, which is the VSPackage you are developing, you create objects that comply with your design decisions and work together with global functionality provided by the IDE. Although you control how a project item is persisted, for example, you do not control notification that a file must be persisted. When a user places the focus on an open project item and chooses **Save** on the **File** menu on the Visual Studio menu bar, your project type code must intercept the command from the IDE, persist the file, and send notification back to the IDE that the file is no longer changed.

 Your VSPackage interacts with the IDE through services that provide access to the IDE interfaces. For example, through particular services, you monitor and route commands and provide context information for selections made in the project. All the global IDE functionality needed for your VSPackage is provided by services. For more information about services, see [How to: Get a service](../../extensibility/how-to-get-a-service.md).

 Other implementation considerations:

- A single project model can contain more than one project type.

- Project types and the attendant project factories are registered independently with GUIDs.

- Each project must have a template file or wizard to initialize the new project file when a user creates a new project through the Visual Studio UI. For example, the Visual C++ templates initialize what eventually become .vcproj files.

  The following illustration shows the primary interfaces, services, and objects that compose a typical project implementation. You can use the application helper, `HierUtil7`, to create the underlying objects and other programming boilerplate. For more information about the `HierUtil7` application helper, see [Use HierUtil7 project classes to implement a project type (C++)](/previous-versions/bb166212(v=vs.100)).

  ![Visual Studio project model graphic](../../extensibility/internals/media/vsprojectmodel.gif "vsProjectModel")
  
  Project model

  For more information about the interfaces and services listed in the previous diagram, and other optional interfaces not included in the diagram, see [Project model core components](../../extensibility/internals/project-model-core-components.md).

  Projects can support commands and therefore must implement the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface to participate in command routing through the command context GUIDs.

## Related content
- [Checklist: Create new project types](../../extensibility/internals/checklist-creating-new-project-types.md)
- [Use HierUtil7 project classes to implement a project type (C++)](/previous-versions/bb166212(v=vs.100))
- [Project model core components](../../extensibility/internals/project-model-core-components.md)
- [Create project instances by using project factories](../../extensibility/internals/creating-project-instances-by-using-project-factories.md)
- [How to: Get a service](../../extensibility/how-to-get-a-service.md)
- [Create project types](../../extensibility/internals/creating-project-types.md)
