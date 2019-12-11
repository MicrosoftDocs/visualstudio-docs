---
title: "How to: Add or Remove References By Using the Reference Manager | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
f1_keywords:
  - "VS.ReferenceManager"
helpviewer_keywords:
  - "Visual C# projects, references"
  - "references [Visual Studio], adding"
  - "assemblies [Visual Studio], references"
  - "Visual Basic projects, references"
  - "project references, adding"
  - "referencing components, adding references"
  - "project references, removing"
  - "referencing assemblies"
  - "referencing components, removing references"
  - "references [Visual Studio], removing"
  - "referencing components, assemblies not listed"
ms.assetid: 1aabb520-99b0-46c6-9368-21b4d84793eb
caps.latest.revision: 48
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Add or Remove References By Using the Reference Manager
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can use the **Reference Manager** dialog box to add and manage references to components that you, Microsoft, or another company developed. If you're developing a Universal Windows app, your project automatically references all of the correct Windows SDK DLLs. If you are developing a .NET application, your project automatically references mscorlib.dll. Some .NET APIs are exposed in components that you have to add manually. References to COM components or custom components have to be added manually.

## Adding and Removing a Reference

#### To Add a Reference

1. In **Solution Explorer**, right-click on the References node and choose **Add Reference**.

2. Specify the references to add, and then choose the **OK** button.

   **Reference Manager** opens and lists the available references by group. The project type determines which of the following groups appear:

- Assemblies, with the Framework and Extensions subgroups.

- Solution, with the Projects subgroup.

- Windows, with the Core and Extensions subgroups. You can explore the references in the Windows SDK or extension SDKs by using the **Object Browser**.

- Browse, with the Recent subgroup.

## Assemblies tab
 The **Assemblies** tab lists all .NET Framework assemblies that are available for referencing. The **Assemblies** tab doesn’t list any assemblies from the global assembly cache (GAC) because assemblies in the GAC are part of the run-time environment. If you deploy or copy an application that contains a reference to an assembly that’s registered in the GAC, the assembly won’t be deployed or copied with the application, regardless of the Copy Local setting. For more information, see [Project References](https://go.microsoft.com/fwlink/?LinkId=238512).

 When you manually add a reference to any of the EnvDTE namespaces (EnvDTE, EnvDTE80, EnvDTE90, EnvDTE90a, or EnvDTE100), set the Embed Interop Types property of the reference to False in the Properties window. Setting this property to True can cause build issues because of certain EnvDTE properties that can’t be embedded.

 All desktop projects contain an implicit reference to mscorlib. [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] projects contain an implicit reference to Microsoft.VisualBasic. In [!INCLUDE[vs_dev11_long](../includes/vs-dev11-long-md.md)], all projects contain an implicit reference to System.Core, even if it’s removed from the list of references.

 If a project type doesn’t support Assemblies, the tab won’t appear in the **Reference Manager** dialog box.

 The Assemblies tab consists of two sub-tabs:

1. Framework lists all assemblies that constitute the targeted Framework.

   - Advertised assemblies are in the Full Framework and enumerated in the Framework list when your project targets a Profile of the targeted Framework. Advertised assemblies are grey to differentiate them from the assemblies that exist in the targeted Framework profile of the project. For example, if a project targets .NET Framework 4 Client, the Framework list shows advertised assemblies from .NET Framework 4. When a user adds an advertised assembly, the user is notified that, after the **Reference Manager** dialog box is closed, the project will be retargeted to the .NET Framework 4 and the advertised assembly will be added.

   - Projects for [!INCLUDE[win8_appname_long](../includes/win8-appname-long-md.md)] apps contain references to all of the assemblies in the targeted [!INCLUDE[net_win8_profile](../includes/net-win8-profile-md.md)] by default on project creation. In managed projects, a read-only node under the References folder in **Solution Explorer** indicates the reference to the entire Framework. Accordingly, the Framework tab won’t enumerate any of the assemblies from the Framework and instead display the following message: “All of the Framework assemblies are already referenced. Please use the Object Browser to explore the references in the Framework.” For desktop projects, the Framework tab enumerates assemblies from the targeted Framework, and the user must add the references that the application requires.

2. Extensions lists all assemblies that external vendors of components and controls have developed to extend the targeted Framework. Depending on the purpose of the user application, it might need these assemblies.

   - Extensions is populated by enumerating the assemblies that are registered in the following locations:

       ```
       32-bit machine:
       HKEY_CURRENT_USER\SOFTWARE\Microsoft\[Target Framework Identifier]\v[Target Framework Version]\AssemblyFoldersEx\[UserComponentName]\@default=[Disk location of assemblies]
       HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\[Target Framework Identifier]\v[Target Framework Version]\AssemblyFoldersEx\[UserComponentName]\@default=[Disk location of assemblies]
       64-bit machine:
       HKEY_CURRENT_USER\SOFTWARE\Wow6432Node\Microsoft\[Target Framework Identifier]\v[Target Framework Version]\AssemblyFoldersEx\[UserComponentName]\@default=[Disk location of assemblies]
       HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\[Target Framework Identifier]\v[Target Framework Version]\AssemblyFoldersEx\[UserComponentName]\@default=[Disk location of assemblies]
       And older versions of the [Target Framework Identifier]
       ```

        For example, if a project targets the .NET Framework 4 on a 32-bit machine, Extensions will enumerate assemblies that are registered under \Microsoft\\.NETFramework\v4.0\AssemblyFoldersEx\\, \Microsoft\\.NETFramework\v3.5\AssemblyFoldersEx\\, \Microsoft\\.NETFramework\v3.0\AssemblyFoldersEx\\, and \Microsoft\\.NETFramework\v2.0\AssemblyFoldersEx\\.

   Some components in the list may not be shown, depending on the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] version of your project. This can occur under the following conditions:

- A component that uses a recent version of the .NET Framework is incompatible with a project that targets an earlier version of the .NET Framework.

     For information about how to change the target .NET Framework version for a project, see [How to: Target a Version of the .NET Framework](../ide/how-to-target-a-version-of-the-dotnet-framework.md).

- A component that uses [!INCLUDE[net_v40_short](../includes/net-v40-short-md.md)] is incompatible with a project that targets the [!INCLUDE[net_v45](../includes/net-v45-md.md)].

     When you create a new application, some projects target the [!INCLUDE[net_v45](../includes/net-v45-md.md)] by default. For more information, see [.NET Framework Client Profile](https://msdn.microsoft.com/library/f0219919-1f02-4588-8704-327a62fd91f1).

- You should avoid adding file references to outputs of another project in the same solution, because doing this may cause compilation errors. Instead, use the **Projects** tab of the **Add Reference** dialog box to create project-to-project references. This makes team development easier by enabling better management of the class libraries you create in your projects. For more information, see [Troubleshooting Broken References](../ide/troubleshooting-broken-references.md).

- > [!NOTE]
    > In Visual Studio 2015, a file reference instead of a project reference is created if the target version of the .NET Framework of one project is version 4.5, and the target version of the other project is version 2, 3, 3.5, or 4.0.

#### To display an assembly in the Add Reference dialog box

- Move or copy the assembly to one of the following locations:

  - The current project directory. (You can find these assemblies by using the **Browse** tab.)

  - Other project directories in the same solution. (You can find these assemblies by using the **Projects** tab.)

    \- or -

- Set a registry key that specifies the location of assemblies to display:

   For a 32-bit operating system, add one of the following registry keys.

  - [HKEY_CURRENT_USER\SOFTWARE\Microsoft\\.NETFramework\\*VersionMinimum*\AssemblyFoldersEx\MyAssemblies]@="*AssemblyLocation*"

  - [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\\.NETFramework\\*VersionMinimum*\AssemblyFoldersEx\MyAssemblies]@="*AssemblyLocation*"

    For a 64-bit operating system, add one of the following registry keys in a 32-bit registry hive.

  - [HKEY_CURRENT_USER\SOFTWARE\Wow6432Node\Microsoft\\.NETFramework\\*VersionMinimum*\AssemblyFoldersEx\MyAssemblies]@="*AssemblyLocation*"

  - [HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\\.NETFramework\\*VersionMinimum*\AssemblyFoldersEx\MyAssemblies]@="*AssemblyLocation*"

    *VersionMinimum* is the lowest .NET Framework version that applies. If *VersionMinimum* is v3.0, folders specified in AssemblyFoldersEx apply to projects that target .NET Framework 3.0 and later.

    *AssemblyLocation* is the directory of the assemblies that you want to appear in the **Add Reference** dialog box, for example, C:\MyAssemblies\\.

    Creating the registry key under the HKEY_LOCAL_MACHINE node allows all users to see the assemblies in the specified location in the **Add Reference** dialog box. Creating the registry key under the HKEY_CURRENT_USER node affects only the setting for the current user.

    Open the **Add Reference** dialog box again. The assemblies should appear on the **.NET** tab. If they do not, make sure that the assemblies are located in the specified *AssemblyLocation* directory, restart Visual Studio, and try again.

## COM tab
 The COM tab lists all COM components that are available for referencing. If you want to add a reference to a registered COM DLL that contains an internal manifest, unregister the DLL first. Otherwise, Visual Studio adds the assembly reference as an ActiveX Control instead of as a native DLL.

 If a project type doesn’t support COM, the tab won’t appear in the **Reference Manager** dialog box.

## Solution tab
 The Solution tab lists all compatible projects within the current solution, in the Projects sub-tab.

 A project can reference another project that targets a different version of the .NET Framework. For example, you could create a project that targets the [!INCLUDE[net_v40_short](../includes/net-v40-short-md.md)] but that references an assembly that’s been built for the .NET Framework 2. However, the .NET Framework 2 project can’t reference a [!INCLUDE[net_v40_short](../includes/net-v40-short-md.md)] project. For more information, see [Targeting a Specific .NET Framework Version](../ide/targeting-a-specific-dotnet-framework-version.md).

 A project that targets the [!INCLUDE[net_v40_short](../includes/net-v40-short-md.md)] is incompatible with a project that targets the [!INCLUDE[net_client_v40_long](../includes/net-client-v40-long-md.md)].

 In [!INCLUDE[vs_dev11_long](../includes/vs-dev11-long-md.md)], a file reference instead of a project reference is created if one project targets the .NET Framework 4 and another project targets an earlier version.

 A project that targets the [!INCLUDE[net_win8_profile](../includes/net-win8-profile-md.md)] can’t add a project reference to a project that targets the .NET Framework and vice versa.

## Windows tab
 The Windows tab lists all SDKs that are specific to platforms on which Windows operating systems run.

 You can generate a WinMD file in Visual Studio in two ways:

- **[!INCLUDE[win8_appname_long](../includes/win8-appname-long-md.md)] app managed projects**: [!INCLUDE[win8_appname_long](../includes/win8-appname-long-md.md)] app projects can output WinMD binaries by setting Project Properties &#124; Output Type = WinMD File. The WinMD filename must be the superset namespace of all the namespaces that exist within it. For example, if a project consists of namespaces A.B and A.B.C, the possible names for its outputted WinMD are A.winmd and A.B.winmd. If a user enters a Project Properties &#124; Assembly Name or Project Properties &#124; Namespace value that’s disjoint from the set of namespaces in the project or there is no superset namespace within a project, a build warning is generated: 'A.winmd' isn’t a valid .winmd file name for this assembly. All types within a Windows Metadata file must exist in a sub namespace of the file name. Types that don’t exist in a sub namespace of the file name won’t be able to be located at runtime. In this assembly, the smallest common namespace is 'CSWSClassLibrary1'. A desktop Visual Basic or Visual C# project can only consume WinMDs that are generated by using the [!INCLUDE[win8](../includes/win8-md.md)] SDKs, which are known as first-party WinMDs, and can’t generate WinMDs.

- **[!INCLUDE[win8_appname_long](../includes/win8-appname-long-md.md)] app native projects**: A native WinMD file consists of only metadata. Its implementation exists in a separate DLL file. One can produce native binaries by choosing the Windows Runtime Component project template in the **New Project** dialog box or by starting from a blank project and modifying the project properties to generate a WinMD file. If the project consists of disjoint namespaces, a build error will tell the user to combine their namespaces or run the MSMerge tool.

  The Windows tab consists of two subgroups.

### Core Subgroup
 The Core subgroup lists all of the WinMDs (for Windows Runtime elements) in the SDK for the targeted version of Windows.

 [!INCLUDE[win8_appname_long](../includes/win8-appname-long-md.md)] app projects contain references to all of the WinMDs in the [!INCLUDE[win8](../includes/win8-md.md)] SDK by default on project creation. In managed projects, a read-only node under the References folder in **Solution Explorer** indicates the reference to the entire [!INCLUDE[win8](../includes/win8-md.md)] SDK. Accordingly, the Core subgroup in the Reference Manager won’t enumerate any of the assemblies from the [!INCLUDE[win8](../includes/win8-md.md)] SDK and instead displays a message: “The Windows SDK is already referenced. Please use the Object Browser to explore the references in the Windows SDK.”

 In the desktop projects, the Core subgroup doesn’t appear by default. You can add the Windows Runtime by opening the shortcut menu for the project node, choosing **Unload Project**, adding the following snippet, and re-opening the project (on the project node, choose **Reload Project**). When you invoke the **Reference Manager** dialog box, the Core subgroup appears.

```
<PropertyGroup>
  <TargetPlatformVersion>8.0</TargetPlatformVersion>
</PropertyGroup>
```

 Make sure to select the **Windows** check box on this subgroup. You should then be able to use Windows Runtime elements. However, you'll also want to add System.Runtime, in which the Windows Runtime defines some standard classes and interfaces, such as IEnumerable, that are used throughout the Windows Runtime libraries. For information about how to add System.Runtime, see [Managed desktop apps and Windows Runtime](https://msdn.microsoft.com/library/windows/apps/jj856306.aspx#consuming_standard_windows_runtime_types).

### Extensions Subgroup
 Extensions lists the user SDKs that extend the targeted Windows platform. This tab appears for [!INCLUDE[win8_appname_long](../includes/win8-appname-long-md.md)] app projects only. Desktop projects won’t show this tab because they can consume only first-party .winmd files.

 An SDK is a collection of files that Visual Studio treats as a single component. In the Extensions tab, SDKs that apply to the project from which the **Reference Manager** dialog box was invoked are listed as single entries. When added to a project, all of the SDK content is consumed by Visual Studio such that the user doesn’t need to take any further actions to leverage the SDK contents in IntelliSense, toolbox, designers, Object Browser, build, deployment, debugging, and packaging. For information about how to display your SDK in the Extensions tab, see [Creating a Software Development Kit](../extensibility/creating-a-software-development-kit.md).

> [!NOTE]
> If a project references an SDK that depends on another SDK, Visual Studio won’t consume the second SDK unless the user manually adds a reference to the second SDK. When a user chooses an SDK on the **Extensions** tab, the **Reference Manager** dialog box helps the user identify SDK dependencies by listing not only the name and version of the SDK but also the name of any SDK dependencies in the details pane. If a user doesn’t notice the dependencies and only adds that SDK, MSBuild will prompt the user to add the dependencies.

 If a project type doesn’t support **Extensions**, the tab doesn’t appear in the **Reference Manager** dialog box.

## Browse button
 You can use the **Browse** button to browse for a component in the file system.

 A project can reference a component that targets a different version of the .NET Framework. For example, you could create an application that targets the .NET Framework 4 Client Profile, which references a component that targets the .NET Framework 2. For more information, see [Targeting a Specific .NET Framework Version](../ide/targeting-a-specific-dotnet-framework-version.md).

 You should avoid adding file references to outputs of another project in the same solution, because this tactic may cause compilation errors. Instead, use the **Solution** tab of the **Reference Manager** dialog box to create project-to-project references. This tactic makes team development easier by enabling better management of the class libraries that you create in your projects. For more information, see [Troubleshooting Broken References](../ide/troubleshooting-broken-references.md).

 You can’t browse to an SDK and add it to your project. You can only browse to a file (for example, an assembly or .winmd) and add it to your project.

 When doing a file reference to a WinMD, the expected layout is that the *FileName*.winmd, *FileName*.dll, and *FileName*.pri files are all placed alongside each other. If you reference a WinMD in the following scenarios, an incomplete set of files will be copied into the project output directory and, consequently, build and runtime failures will occur.

- **Native component**: a native project will create one WinMD for each disjoint set of namespaces and one DLL that consists of the implementation. The WinMDs will have disparate names. When referencing this native component file, MSBuild won’t recognize that the dissimilarly named WinMDs make one component. Consequently, only the identically named *FileName*.dll and *FileName*.winmd will be copied, and runtime errors will occur. To work around this issue, create an Extension SDK. For more information, see [Creating a Software Development Kit](../extensibility/creating-a-software-development-kit.md).

- **Consuming controls**: at a minimum, a XAML control consists of a *FileName*.winmd, *FileName*.dll, *FileName*.pri, *XamlName*.xaml, and an *ImageName*.jpg. When the project is built, the resource files that are associated with the file reference won’t get copied into the project’s output directory, and only *FileName*.winmd, *FileName*.dll and *FileName*.pri will be copied. A build error is logged to inform the user that the resources *XamlName*.xaml and *ImageName*.jpg are missing. To succeed, the user will have to manually copy these resource files into the project output directory for build and debugging/runtime. To work around this issue, either create an Extension SDK by following the steps in [Creating a Software Development Kit](../extensibility/creating-a-software-development-kit.md) or edit the project file to add the following property:

    ```
    <PropertyGroup>
    <GenerateLibraryOutput>True</GenerateLibraryOutput>
    </PropertyGroup>
    ```

    > [!NOTE]
    > If you add the property, the build might run slower.

## Recent
 Assemblies, COM, Windows, and Browse each support a Recent tab, which enumerates the list of components that were recently added to projects.

## Search
 The search bar in the **Reference Manager** dialog box operates over the tab that’s in focus. For example, if a user types “System” in the search bar while the **Solution** tab is in focus, the search won’t return any results unless the solution consists of a project name that contains “System”.

## See Also
 [NIB How to: Add or Remove References By Using the Add Reference Dialog Box](https://msdn.microsoft.com/3bd75d61-f00c-47c0-86a2-dd1f20e231c9)
 [Managing references in a project](../ide/managing-references-in-a-project.md)
