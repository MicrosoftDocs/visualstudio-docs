---
title: Add references in the Reference Manager
description: Learn how to use the Reference Manager dialog box to add and manage references to developed components.
ms.custom: SEO-VS-2020
ms.date: 08/30/2021
ms.topic: how-to
f1_keywords:
- VS.ReferenceManager
helpviewer_keywords:
- C# projects, references
- references [Visual Studio], adding
- assemblies [Visual Studio], references
- Visual Basic projects, references
- project references, adding
- referencing components, adding references
- project references, removing
- referencing assemblies
- referencing components, removing references
- references [Visual Studio], removing
- referencing components, assemblies not listed
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# How to: Add or remove references by using the Reference Manager

You can use the Reference Manager dialog box to add and manage references to components that you, Microsoft, or another company developed. If you're developing a Universal Windows app, your project automatically references all of the correct Windows SDK DLLs. If you are developing a .NET application, your project automatically references *mscorlib.dll*. Some .NET APIs are exposed in components that you have to add manually. References to COM components or custom components have to be added manually.

## Reference Manager dialog box

The Reference Manager dialog box shows different categories on the left side, depending on the project type:

- **Assemblies**, with **Framework** and **Extensions** subgroups

- **COM** lists all COM components that are available for referencing

- **Projects**

- **Shared Projects**

- **Windows**, with **Core** and **Extensions** subgroups. You can explore the references in the Windows SDK or extension SDKs by using the **Object Browser**.

- **Browse**, with **Recent** subgroup

    > [!NOTE]
    > You might not see **Browse** in the Reference Manager dialog box if you're developing C++ projects.

## Add a reference

::: moniker range="vs-2017"

1. In **Solution Explorer**, right-click on the **References** or **Dependencies** node and choose **Add Reference**. You can also right-click on the project node and select **Add** > **Reference**.

   **Reference Manager** opens and lists the available references by group.

2. Specify the references to add, and then select **OK**.

::: moniker-end

::: moniker range=">=vs-2019"

1. In **Solution Explorer**, right-click on the **References** or **Dependencies** node and choose either **Add Project Reference**, **Add Shared Project Reference**, or **Add COM Reference**. (You can right-click the project node and select **Add** from the fly-out menu to choose from these options, too.)

   **Reference Manager** opens and lists the available references by group.

2. Specify the references to add, and then select **OK**.

::: moniker-end

## Assemblies tab

The **Assemblies** tab lists all .NET assemblies that are available for referencing. The **Assemblies** tab doesn't list any assemblies from the global assembly cache (GAC) because assemblies in the GAC are part of the run-time environment. If you deploy or copy an application that contains a reference to an assembly that's registered in the GAC, the assembly won't be deployed or copied with the application, regardless of the **Copy Local** setting. For more information, see [Manage references in a project](../ide/managing-references-in-a-project.md).

When you manually add a reference to any of the EnvDTE namespaces (<xref:EnvDTE>, <xref:EnvDTE80>, <xref:EnvDTE90>, <xref:EnvDTE90a>, or <xref:EnvDTE100>), set the **Embed Interop Types** property of the reference to **False** in the **Properties** window. Setting this property to **True** can cause build issues because of certain EnvDTE properties that can't be embedded.

All desktop projects contain an implicit reference to **mscorlib**. Visual Basic projects contain an implicit reference to <xref:Microsoft.VisualBasic>. All projects contain an implicit reference to **System.Core**, even if it's removed from the list of references.

If a project type doesn't support assemblies, the tab won't appear in the Reference Manager dialog box.

The **Assemblies** tab consists of two sub-tabs:

1. **Framework** lists all assemblies that constitute the targeted framework.

   For projects that don't target .NET Core or the Universal Windows Platform, the **Framework** tab enumerates assemblies from the targeted framework. The user must add any references that the application requires.

   Universal Windows projects contain references to all of the assemblies in the targeted framework by default. In managed projects, a read-only node under the **References** folder in **Solution Explorer** indicates the reference to the entire framework. Accordingly, the **Framework** tab doesn't enumerate any of the assemblies from the framework and instead displays the following message: "All of the Framework assemblies are already referenced. Please use the Object Browser to explore the references in the Framework".

2. **Extensions** lists all assemblies that external vendors of components and controls have developed to extend the targeted framework. Depending on the purpose of the user application, it might need these assemblies.

   **Extensions** is populated by enumerating the assemblies that are registered in the following locations:

   32-bit machine:
   - `HKEY_CURRENT_USER\SOFTWARE\Microsoft\[Target Framework Identifier]\v[Target Framework Version]\AssemblyFoldersEx\[UserComponentName]\@default=[Disk location of assemblies]`
   - `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\[Target Framework Identifier]\v[Target Framework Version]\AssemblyFoldersEx\[UserComponentName]\@default=[Disk location of assemblies]`

   64-bit machine:
   - `HKEY_CURRENT_USER\SOFTWARE\Wow6432Node\Microsoft\[Target Framework Identifier]\v[Target Framework Version]\AssemblyFoldersEx\[UserComponentName]\@default=[Disk location of assemblies]`
   - `HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\[Target Framework Identifier]\v[Target Framework Version]\AssemblyFoldersEx\[UserComponentName]\@default=[Disk location of assemblies]`

   And older versions of the [Target Framework Identifier]

   For example, if a project targets .NET Framework 4 on a 32-bit machine, **Extensions** enumerates assemblies that are registered under *\Microsoft\.NETFramework\v4.0\AssemblyFoldersEx*, *\Microsoft\.NETFramework\v3.5\AssemblyFoldersEx*, *\Microsoft\.NETFramework\v3.0\AssemblyFoldersEx*, and *\Microsoft\.NETFramework\v2.0\AssemblyFoldersEx*.

Some components in the list may not be shown, depending on the framework version of your project. This can occur under the following conditions:

- A component that uses a recent framework version is incompatible with a project that targets an earlier version.

   For information about how to change the target framework version for a project, see [Framework targeting overview](visual-studio-multi-targeting-overview.md).

- A component that uses .NET Framework 4 is incompatible with a project that targets the .NET Framework 4.5.

You should avoid adding file references to outputs of another project in the same solution, because doing this may cause compilation errors. Instead, use the **Projects** tab of the **Add Reference** dialog box to create project-to-project references. This makes team development easier by enabling better management of the class libraries you create in your projects. For more information, see [Troubleshoot broken references](../ide/troubleshooting-broken-references.md).

> [!NOTE]
> In Visual Studio 2015 or later, a file reference instead of a project reference is created if the target framework version of one project is .NET Framework 4.5 or later, and the target version of the other project is .NET Framework 2, 3, 3.5, or 4.0.

### To display an assembly in the Add Reference dialog box

- Move or copy the assembly to one of the following locations:

  - The current project directory. (You can find these assemblies by using the **Browse** tab.)

  - Other project directories in the same solution. (You can find these assemblies by using the **Projects** tab.)

  \- or -

- Set a registry key that specifies the location of assemblies to display:

  For a 32-bit operating system, add one of the following registry keys.

  - `[HKEY_CURRENT_USER\SOFTWARE\Microsoft\.NETFramework\<VersionMinimum>\AssemblyFoldersEx\MyAssemblies]@="<AssemblyLocation>"`

  - `[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\.NETFramework\<VersionMinimum>\AssemblyFoldersEx\MyAssemblies]@="<AssemblyLocation>"`

  For a 64-bit operating system, add one of the following registry keys in a 32-bit registry hive.

  - `[HKEY_CURRENT_USER\SOFTWARE\Wow6432Node\Microsoft\.NETFramework\<VersionMinimum>\AssemblyFoldersEx\MyAssemblies]@="<AssemblyLocation>"`

  - `[HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\.NETFramework\<VersionMinimum>\AssemblyFoldersEx\MyAssemblies]@="<AssemblyLocation>"`

  *\<VersionMinimum\>* is the lowest framework version that applies. If *\<VersionMinimum\>* is v3.0, folders specified in *AssemblyFoldersEx* apply to projects that target .NET Framework 3.0 and later.

  *\<AssemblyLocation\>* is the directory of the assemblies that you want to appear in the **Add Reference** dialog box, for example, *C:\MyAssemblies*.

  Creating the registry key under the `HKEY_LOCAL_MACHINE` node allows all users to see the assemblies in the specified location in the **Add Reference** dialog box. Creating the registry key under the `HKEY_CURRENT_USER` node affects only the setting for the current user.

  Open the **Add Reference** dialog box again. The assemblies should appear on the **.NET** tab. If they do not, make sure that the assemblies are located in the specified *AssemblyLocation* directory, restart Visual Studio, and try again.

## Projects tab

The **Projects** tab lists all compatible projects within the current solution, in the **Solution** sub-tab.

A project can reference another project that targets a different framework version. For example, you could create a project that targets the .NET Framework 4 but that references an assembly that's been built for the .NET Framework 2. However, the .NET Framework 2 project can't reference a .NET Framework 4 project. For more information, see [Framework targeting overview](../ide/visual-studio-multi-targeting-overview.md).

> [!NOTE]
> A project that targets the .NET Framework 4 is incompatible with a project that targets the .NET Framework 4 Client Profile.

## Shared Projects tab

Add a reference to a shared project on the **Shared Projects** tab of the Reference Manager dialog box. [Shared Projects](/xamarin/cross-platform/app-fundamentals/shared-projects?tabs=windows) let you write common code that's referenced by a number of different application projects.

## Universal Windows tab

The **Universal Windows** tab lists all SDKs that are specific to platforms on which Windows operating systems run.
This tab has two subgroups: **Core** and **Extensions**.

### Core subgroup

Universal Windows app projects have a reference to the Universal Windows SDK by default. Accordingly, the **Core** subgroup in the **Reference Manager** doesn't enumerate any of the assemblies from the Universal Windows SDK.

### Extensions subgroup

**Extensions** lists the user SDKs that extend the targeted Windows platform.

An SDK is a collection of files that Visual Studio treats as a single component. In the **Extensions** tab, SDKs that apply to the project from which the Reference Manager dialog box was invoked are listed as single entries. When added to a project, all of the SDK content is consumed by Visual Studio such that the user doesn't need to take any further actions to leverage the SDK contents in IntelliSense, toolbox, designers, Object Browser, build, deployment, debugging, and packaging.

For information about how to display your SDK in the **Extensions** tab, see [Creating a Software Development Kit](../extensibility/creating-a-software-development-kit.md).

> [!NOTE]
> If a project references an SDK that depends on another SDK, Visual Studio won't consume the second SDK unless you manually add a reference to the second SDK. When a user chooses an SDK on the **Extensions** tab, the Reference Manager dialog box helps you identify SDK dependencies by listing any dependencies in the details pane.

If a project type doesn't support extensions, this tab doesn't appear in the Reference Manager dialog box.

## COM tab

The **COM** tab lists all COM components that are available for referencing. If you want to add a reference to a registered COM DLL that contains an internal manifest, unregister the DLL first. Otherwise, Visual Studio adds the assembly reference as an ActiveX control instead of as a native DLL.

If a project type doesn't support COM, the tab doesn't appear in the Reference Manager dialog box.

## Browse

You can use the **Browse** button to browse for a component in the file system.

A project can reference a component that targets a different framework version. For example, you could create an application that targets .NET Framework 4.7 but references a component that targets .NET Framework 4. For more information, see [Framework targeting overview](../ide/visual-studio-multi-targeting-overview.md).

Avoid adding file references to outputs of another project in the same solution, because this tactic may cause compilation errors. Instead, use the **Solution** tab of the Reference Manager dialog box to create project-to-project references. This makes team development easier by enabling better management of the class libraries that you create in your projects. For more information, see [Troubleshoot broken references](../ide/troubleshooting-broken-references.md).

You can't browse to an SDK and add it to your project. You can only browse to a file (for example, an assembly or *.winmd*) and add it to your project.

When doing a file reference to a WinMD, the expected layout is that the *\<FileName>.winmd*, *\<FileName>.dll*, and *\<FileName>.pri* files are all placed alongside each other. If you reference a WinMD in the following scenarios, an incomplete set of files will be copied into the project output directory and, consequently, build and runtime failures will occur.

- **Native component**: a native project will create one WinMD for each disjoint set of namespaces and one DLL that consists of the implementation. The WinMDs will have disparate names. When referencing this native component file, MSBuild won't recognize that the dissimilarly named WinMDs make one component. Consequently, only the identically named *\<FileName>.dll* and *\<FileName>.winmd* will be copied, and runtime errors will occur. To work around this issue, create an extension SDK. For more information, see [Create a Software Development Kit](../extensibility/creating-a-software-development-kit.md).

- **Consuming controls**: at a minimum, a XAML control consists of a *\<FileName>.winmd*, *\<FileName>.dll*, *\<FileName>.pri*, *\<XamlName>.xaml*, and an *\<ImageName>.jpg*. When the project is built, the resource files that are associated with the file reference won't get copied into the project's output directory, and only *\<FileName>.winmd*, *\<FileName>.dll* and *\<FileName>.pri* will be copied. A build error is logged to inform the user that the resources *\<XamlName>.xaml* and *\<ImageName>.jpg* are missing. To succeed, the user will have to manually copy these resource files into the project output directory for build and debugging/runtime. To work around this issue, either create an extension SDK by following the steps in [Create a Software Development Kit](../extensibility/creating-a-software-development-kit.md) or edit the project file to add the following property:

    ```xml
    <PropertyGroup>
       <GenerateLibraryOutput>True</GenerateLibraryOutput>
    </PropertyGroup>
    ```

    > [!NOTE]
    > If you add the property, the build might run slower.

## Recent

**Assemblies**, **COM**, **Windows**, and **Browse** each support a **Recent** tab, which enumerates the list of components that were recently added to projects.

## Search

The search bar in the Reference Manager dialog box operates over the tab that's in focus. For example, if a user types "System" in the search bar while the **Solution** tab is in focus, the search won't return any results unless the solution consists of a project name that contains "System".

## See also

- [Manage references in a project](../ide/managing-references-in-a-project.md)
