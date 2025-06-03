---
title: Manage references in a project
description: Manage references to external components and connected services in your project so Visual Studio can locate the component or the service.
ms.date: 08/12/2024
ms.topic: conceptual
f1_keywords:
- vs.ProjectPropertiesReferencePaths
- cs.ProjectPropertiesReferencePaths
helpviewer_keywords:
- C# projects, references
- referencing objects, project references
- external component references
- referencing namespaces
- Visual Basic projects, references
- referencing components, external components
- Web references, types of project references
- namespaces [Visual Studio], referencing
- COM components, referencing
- objects [Visual Studio], referencing
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# Manage references in a project

Before you write code against an external component or connected service, your project must first contain a reference to it. A reference is essentially an entry in a project file that contains the information that Visual Studio needs to locate the component or the service.

How you add a reference depends on the project type for the code you're working on:

- If you see a **Dependencies** node in **[Solution Explorer](use-solution-explorer.md)**, you can use the right-click context menu to select **Add Project Reference**.

  :::image type="content" source="media/add-project-reference.png" alt-text="Screenshot of the Add Project Reference option from the right-click context menu.":::

  ::: moniker range="<=vs-2019"
  You can also right-click the [project node](use-solution-explorer.md#solution-explorer-ui) and select **Add** > **Project Reference**.
  ::: moniker-end

- If you see a **References** node in **[Solution Explorer](use-solution-explorer.md)**, you can use the right-click context menu to select **Add Reference**.

  :::image type="content" source="media/add-reference.png" alt-text="Screenshot of the Add Reference option from the right-click context menu.":::

  ::: moniker range="<=vs-2019"
  Or, right-click the [project node](use-solution-explorer.md#solution-explorer-ui) and select **Add** > **Reference**.
  ::: moniker-end

  For more information, see [How to: Add or remove references](../ide/how-to-add-or-remove-references-by-using-the-reference-manager.md).

You can add a reference to the following types of components and services:

- .NET class libraries or assemblies

- UWP apps

- COM components

- Other assemblies or class libraries of projects in the same solution

- Shared projects

- XML Web services

## UWP app references

The [Universal Windows Platform](/windows/uwp/get-started/universal-application-platform-guide) (UWP) provides a common app platform for every device that runs Windows. To learn how to create a UWP app, see [Tutorial: Create your first Universal Windows Platform application in Visual Studio with XAML and C#](../get-started/csharp/tutorial-uwp.md).

### Project references

Universal Windows Platform (UWP) projects can create references to other UWP projects in the solution, or to Windows 8.1 projects or binaries, provided that these projects don't use APIs that have been deprecated in Windows 10 and later. For more information, see [Move from Windows Runtime 8 to UWP](/windows/uwp/porting/w8x-to-uwp-root).

If you choose to retarget Windows 8.1 projects to Windows 10 and later, see [Port, migrate, and upgrade Visual Studio projects](/visualstudio/releases/2022/port-migrate-and-upgrade-visual-studio-projects).

> [!TIP]
> For information about how to create and build a new UWP app for Windows 10 and Windows 11, see [Choose a UWP version](/windows/uwp/updates-and-versions/choose-a-uwp-version?ocid=VSClient_VerX_NewProject_version&preserve-view=true).

### Extension SDK references

Visual Basic, C#, C++ and JavaScript Universal Windows Platform (UWP) apps can reference Extension SDKs that target Windows 8.1, as long as these Extension SDKs don't use APIs that have been deprecated in Windows 10 and later. Check the Extension SDK vendor site to find out whether it can be referenced by UWP apps.

If you determine that the Extension SDK being referenced by your app isn't supported, then you need to perform the following steps:

1. Look at the name of the project that is causing the error. The platform that your project targets is noted in parentheses next to the project name. For example, **MyProjectName (Windows 8.1)** means that your project **MyProjectName** is targeting platform version Windows 8.1.

1. Go to the site of the vendor who owns the unsupported Extension SDK, and install the version of the Extension SDK with dependencies that are compatible with the version of the platform your project is targeting.

    > [!NOTE]
    > One way to find out whether an Extension SDK has dependencies on other Extension SDKs is by looking in **Reference Manager**. Restart Visual Studio, create a new C# UWP app project, and then right-click on the project and select **Add Reference**. Go to the **Windows** tab, then the **Extensions** sub-tab, and select the Extension SDK. Look at the right pane in the **Reference Manager**. If it has dependencies, they will be listed there.

    > [!IMPORTANT]
    > If your project is targeting Windows 10 specifically, and the Extension SDK installed in the previous step has a dependency on the Microsoft Visual C++ Runtime Package, the version of Microsoft Visual C++ Runtime Package that is compatible with Windows 10 is v14.0, and is installed with Visual Studio.

1. If the Extension SDK you installed in the previous step has dependencies on other Extension SDKs, go to the sites of the vendors who own the dependencies, and then install the versions of these dependencies that are compatible with the version of the platform your project is targeting.

1. Restart Visual Studio and open your app.

1. Right-click on the **References** or **Dependencies** node in the project that caused the error, and then select **Add Reference**.

1. Select the **Windows** tab and then the **Extensions** subtab, uncheck the checkboxes for the old Extension SDKs, and then check the checkboxes for the new Extension SDKs. Select **OK**.

## Add a reference at design time

When you make a reference to an assembly in your project, Visual Studio searches for the assembly in the following locations:

- The current project directory. (You can find these assemblies by using the **Browse** tab.)

- Other project directories in the same solution. (You can find these assemblies on the **Projects** tab.)

> [!NOTE]
> - All projects contain an implied reference to **mscorlib**.
> - All projects contain an implied reference to `System.Core`, even if `System.Core` is removed from the list of references.
> - Visual Basic projects contain an implied reference to <xref:Microsoft.VisualBasic>.

## References to shared components at run time

At run time, components must be either in the output path of the project or in the Global Assembly Cache (GAC). If the project contains a reference to an object that isn't in one of these locations, you must copy the reference to the output path of the project when you build the project. The <xref:Microsoft.VisualStudio.VCProjectEngine.VCProjectReference.CopyLocal%2A> property indicates whether this copy has to be made. If the value is **True**, the reference is copied to the project directory when you build the project. If the value is **False**, the reference isn't copied.

If you deploy an application that contains a reference to a custom component that is registered in the GAC, the component won't be deployed with the application, regardless of the <xref:Microsoft.VisualStudio.VCProjectEngine.VCProjectReference.CopyLocal%2A> setting. In earlier versions of Visual Studio, you could set the <xref:Microsoft.VisualStudio.VCProjectEngine.VCProjectReference.CopyLocal%2A> property on a reference to ensure that the assembly was deployed. Now, you must manually add the assembly to the \Bin folder. This action puts all custom code under scrutiny, thereby reducing the risk of publishing custom code with which you aren't familiar.

By default, the <xref:Microsoft.VisualStudio.VCProjectEngine.VCProjectReference.CopyLocal%2A> property is set to **False** if the assembly or component is in the global assembly cache or is a framework component. Otherwise, the value is set to **True**. Project-to-project references are always set to **True**.

## Reference a project or assembly that targets a different version of .NET

You can create applications that reference projects or assemblies that target a different version of the .NET. For example, you could create an application that targets .NET Framework 4.6, that references an assembly that targets .NET Framework 4.5. If you create a project that targets an earlier version of .NET, you can't set a reference in that project to a project or assembly that targets a newer version.

For more information, see [Framework targeting overview](../ide/visual-studio-multi-targeting-overview.md).

## Project-to-project references

Project-to-project references are references to projects that contain assemblies; you add project references by using the **Projects** tab of the Reference Manager dialog box. Visual Studio can find an assembly when given a path to the project.

When you have a project that produces an assembly, you should reference the project and not use a file reference. The advantage of a project-to-project reference is that it creates a dependency between the projects in the build system. The dependent project is built if it has changed since the last time the referencing project was built. A file reference doesn't create a build dependency, so it's possible to build the referencing project without building the dependent project, and the reference can become obsolete. (That is, the project can reference a previously built version of the project.) This can result in several versions of a single DLL being required in the *bin* directory, which isn't possible. When this conflict occurs, a message appears, such as "Warning: the dependency 'file' in project 'project' can't be copied to the run directory because it would overwrite the reference 'file.'" For more information, see [Troubleshoot broken references](/troubleshoot/developer/visualstudio/project-build/troubleshooting-broken-references) and [How to: Create and remove project dependencies](../ide/how-to-create-and-remove-project-dependencies.md).

> [!NOTE]
> A file reference instead of a project-to-project reference is created if the target version of the .NET Framework of one project is version 4.5, and the target version of the other project is version 2, 3, 3.5, or 4.0.

## Shared project references

Unlike most other project types, a *shared project* doesn't have any binary output. Instead, the code is compiled into each project that references it. Shared Projects let you write common code that's referenced by many different application projects. The code is compiled as part of each referencing project and can include compiler directives to help incorporate platform-specific functionality into the shared code base. Add a reference to a shared project on the **Shared Projects** tab of the Reference Manager dialog box.

## File references

File references are direct references to assemblies outside the context of a Visual Studio project. You create them by using the **Browse** tab of the Reference Manager dialog box. Use a file reference when you just have an assembly or component, and not the project that creates it as output.

## Related content

- [Troubleshoot broken references](/troubleshoot/developer/visualstudio/project-build/troubleshooting-broken-references)
- [How to: Add or remove references](../ide/how-to-add-or-remove-references-by-using-the-reference-manager.md)
