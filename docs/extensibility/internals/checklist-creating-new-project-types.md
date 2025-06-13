---
title: 'Checklist: Creating New Project Types'
description: Learn about the tasks that must be completed to create and display a new project type in Visual Studio.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- projects [Visual Studio SDK], creating new types
- project types, checklist for creating
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Checklist: Create new project types

You must complete several tasks to create a new project type. The following checklist provides a guide to those tasks:

1. Design the functionality for your new project type. For more information, see [Project type design decisions](../../extensibility/internals/project-type-design-decisions.md).

2. Determine which editors are used for code and other project elements. You can use the core or standard editors, or you can create and use project-specific editors. For more information, see [Create custom editors and designers](../../extensibility/creating-custom-editors-and-designers.md) and [How to: Open project-specific editors](../../extensibility/how-to-open-project-specific-editors.md).

3. Determine the level of participation your project items will have in the **Class View** and the **Object Browser**. For more information, see [Support symbol-browsing tools](../../extensibility/internals/supporting-symbol-browsing-tools.md).

4. Derive new classes based on design decisions that you made previously for your project and project items.

5. Write the code for the following project type components:

    - Project factory, to manage creating new projects and opening existing projects. For more information, see [Create project instances by using project factories](../../extensibility/internals/creating-project-instances-by-using-project-factories.md).

    - Project hierarchy and command handling. For more information, see [Use HierUtil7 project classes to implement a project type (C++)](/previous-versions/bb166212(v=vs.100)), [Elements of a project model](../../extensibility/internals/elements-of-a-project-model.md), [Project model core components](../../extensibility/internals/project-model-core-components.md), and [MenuCommands vs. OleMenuCommands](/previous-versions/visualstudio/visual-studio-2015/misc/menucommands-vs-olemenucommands?preserve-view=true&view=vs-2015).

    - Project items management, including adding your project to the **New Project** dialog box. For more information, see [Add project and project item templates](../../extensibility/internals/adding-project-and-project-item-templates.md) and [Register project and item templates](../../extensibility/internals/registering-project-and-item-templates.md).

    - Persistence of project state and individual items. For more information, see [Open and save project items](../../extensibility/internals/opening-and-saving-project-items.md). For persistence of solution information, see [Solutions](../../extensibility/internals/solutions-overview.md).

    - Configuration-independent properties to display in the Properties window. For more information, see [Extend properties](../../extensibility/internals/extending-properties.md).

    - Project configuration properties as implemented in property pages to show configuration-dependent properties. For more information, see [Manage configuration options](../../extensibility/internals/managing-configuration-options.md).

    - Enumerating outputs for deployment. For more information, see [Project configuration for output](../../extensibility/internals/project-configuration-for-output.md).

    - Project startup services. For more information, see [Elements of a project model](../../extensibility/internals/elements-of-a-project-model.md) and [Project model core components](../../extensibility/internals/project-model-core-components.md).

    - Objects, or classes derived from `IDispatch`, available for automation.

    - XML command table (*.vsct*) files. For more information, see [Visual Studio command table (.vsct) files](../../extensibility/internals/visual-studio-command-table-dot-vsct-files.md).

6. Test, debug, and start your project type.

7. Display your project in the **Project** tab of the **Add Reference** dialog box by setting `VARIANT_TRUE` as the value for `VSHPROPID_ShowProjInSolutionPage`. For more information, see <xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.GetProperty%2A>.

8. Create the Microsoft Installer (*.msi*) file for installing your VSPackages. For more information, see [Install VSPackages with Windows Installer](../../extensibility/internals/installing-vspackages-with-windows-installer.md), [Register a project type](../../extensibility/internals/registering-a-project-type.md), and [VSPackages](../../extensibility/internals/vspackages.md).

## Related content
- [Hierarchies in Visual Studio](../../extensibility/internals/hierarchies-in-visual-studio.md)
- [When to create project types](../../extensibility/internals/when-to-create-project-types.md)
- [Create project types](../../extensibility/internals/creating-project-types.md)