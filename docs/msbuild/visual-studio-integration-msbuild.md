---
title: Visual Studio Integration (MSBuild)
titleSuffix: ''
ms.custom: seodec18
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- MSBuild, reference resolution
- MSBuild, well-known target names
- MSBuild, hosting
- MSBuild, editing project files
- MSBuild, Visual Studio integration
- MSBuild, IntelliSense
- MSBuild, output groups
- MSBuild, in-process compilers
- MSBuild, design-time target execution
ms.assetid: 06cd6d7f-8dc1-4e49-8a72-cc9e331d7bca
author: ghogen
ms.author: ghogen
manager: jillfra
ms.workload:
- multiple
---
# Visual Studio integration (MSBuild)
Visual Studio hosts [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] to load and build managed projects. Because [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] is responsible for the project, almost any project in the [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] format can be successfully used in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], even if the project was authored by a different tool and has a customized build process.

 This article describes specific aspects of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]'s [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] hosting that should be considered when customizing projects and *.targets* files that you wish to load and build in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. These will help you make sure [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] features like IntelliSense and debugging work for your custom project.

 For information about C++ projects, see [Project files](/cpp/build/reference/project-files).

## Project file name extensions
 *MSBuild.exe* recognizes any project file name extension matching the pattern *.\*proj*. However, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] only recognizes a subset of these project file name extensions, which determine the language-specific project system that will load the project. [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] does not have a language-neutral [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] based project system.

 For example, the [!INCLUDE[csprcs](../data-tools/includes/csprcs_md.md)] project system loads *.csproj* files, but [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] is not able to load a *.xxproj* file. A project file for source files in an arbitrary language must use the same extension as [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] or [!INCLUDE[csprcs](../data-tools/includes/csprcs_md.md)] project files to be loaded in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].

## Well-known target names
 Clicking the **Build** command in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] will execute the default target in the project. Often, this target is also named `Build`. Choosing the **Rebuild** or **Clean** command will attempt to execute a target of the same name in the project. Clicking **Publish** will execute a target named `PublishOnly` in the project.

## Configurations and platforms
 Configurations are represented in [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] projects by properties grouped in a `PropertyGroup` element that contains a `Condition` attribute. [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] looks at these conditions in order to create a list of project configurations and platforms to display. To successfully extract this list, the conditions must have a format similar to the following:

```xml
Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' "
Condition=" '$(Configuration)' == 'Release' " 
Condition=" '$(Something)|$(Configuration)|$(SomethingElse)' == 'xxx|Debug|yyy' "
```

 [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] looks at the conditions on `PropertyGroup`, `ItemGroup`, `Import`, property, and item elements for this purpose.

## Additional build actions
 [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] allows you to change the item type name of a file in a project with the **Build Action** property of the **File properties** window. **Compile**, **EmbeddedResource**, **Content**, and **None** item type names are always listed in this menu, along with any other item type names already in your project. To ensure any custom item type names are always available in this menu, you can add the names to an item type named `AvailableItemName`. For example, adding the following to your project file will add the custom type **JScript** to this menu for all projects that import it:

```xml
<ItemGroup>
    <AvailableItemName Include="JScript"/>
</ItemGroup>
```

> [!NOTE]
> Some item type names are special to [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] but not listed in this dropdown.

## In-process compilers
 When possible, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] will attempt to use the in-process version of the [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] compiler for increased performance. (Not applicable to [!INCLUDE[csprcs](../data-tools/includes/csprcs_md.md)].) For this to work correctly, the following conditions must be met:

- In a target of the project, there must be a task named `Vbc` for [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] projects.

- The `UseHostCompilerIfAvailable` parameter of the task must be set to true.

## Design-time IntelliSense
 To get IntelliSense support in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] before a build has generated an output assembly, the following conditions must be met:

- There must be a target named `Compile`.

- Either the `Compile` target or one of its dependencies must call the compiler task for the project, such as `Csc` or `Vbc`.

- Either the `Compile` target or one of its dependencies must cause the compiler to receive all the necessary parameters for IntelliSense, particularly all references.

- The conditions listed in the [In-process compilers](#in-process-compilers) section must be met.

## Build solutions
 Within [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], the solution file and project build ordering are controlled by [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] itself. When building a solution with *msbuild.exe* on the command line, [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] parses the solution file and orders the project builds. In both cases the projects are built individually in dependency order, and project to project references are not traversed. In contrast, when individual projects are built with *msbuild.exe*, project to project references are traversed.

 When building inside [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], the property `$(BuildingInsideVisualStudio)` is set to `true`. This can be used in your project or *.targets* files to cause the build to behave differently.

## Display properties and items
 [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] recognizes certain property names and values. For example, the following property in a project will cause **Windows Application** to appear in the **Application Type** box in the **Project Designer**.

```xml
<OutputType>WinExe</OutputType>
```

 The property value can be edited in the **Project Designer** and saved in the project file. If such a property is given an invalid value by hand-editing, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] will show a warning when the project is loaded and replace the invalid value with a default value.

 [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] understands defaults for some properties. These properties will not be persisted into the project file unless they have non-default values.

 Properties with arbitrary names are not displayed in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. To modify arbitrary properties in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], you must open the project file in the XML editor and edit them by hand. For more information, see the [Edit project files in Visual Studio](#edit-project-files-in-visual-studio) section later in this topic.

 Items defined in the project with arbitrary item type names are by default displayed in the **Solution Explorer** under their project node. To hide an item from display, set the `Visible` metadata to `false`. For example, the following item will participate in the build process but not be displayed in **Solution Explorer**.

```xml
<ItemGroup>
    <IntermediateFile Include="cache.temp">
        <Visible>false</Visible>
    </IntermediateFile>
</ItemGroup>
```

> [!NOTE]
> The `Visible` metadata is ignored by **Solution Explorer** for C++ projects. Items will always be shown even if `Visible` is set to false.

 Items declared in files imported into the project are not displayed by default. Items created during the build process are never displayed in **Solution Explorer**.

## Conditions on items and properties
 During a build, all conditions are fully respected.

 When determining property values to display, properties that [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] considers configuration dependent are evaluated differently than properties it considers configuration independent. For properties it considers configuration dependent, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] sets the `Configuration` and `Platform` properties appropriately and instructs [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] to re-evaluate the project. For properties it considers configuration independent, it is indeterminate how conditions will be evaluated.

 Conditional expressions on items are always ignored for the purposes of deciding whether the item should be displayed in **Solution Explorer**.

## Debugging
 In order to find and launch the output assembly and attach the debugger, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] needs the properties `OutputPath`, `AssemblyName`, and `OutputType` correctly defined. The debugger will fail to attach if the build process did not cause the compiler to generate a *.pdb* file.

## Design-time target execution
 [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] attempts to execute targets with certain names when it loads a project. These targets include `Compile`, `ResolveAssemblyReferences`, `ResolveCOMReferences`, `GetFrameworkPaths`, and `CopyRunEnvironmentFiles`. [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] runs these targets so that the compiler can be initialized to provide IntelliSense, the debugger can be initialized, and references displayed in Solution Explorer can be resolved. If these targets are not present, the project will load and build correctly but the design-time experience in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] will not be fully functional.

## Edit project files in Visual Studio
 To edit an [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] project directly, you can open the project file in the Visual Studio XML editor.

#### To unload and edit a project file in Visual Studio

1. In **Solution Explorer**, open the shortcut menu for the project, and then choose **Unload Project**.

     The project is marked **(unavailable)**.

2. In **Solution Explorer**, open the shortcut menu for the unavailable project, and then choose **Edit \<Project File>**.

     The project file opens in the Visual Studio XML Editor.

3. Edit, save, and then close the project file.

4. In **Solution Explorer**, open the shortcut menu for the unavailable project, and then choose **Reload Project**.

## IntelliSense and validation
 When using the XML editor to edit project files, IntelliSense and validation is driven by the [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] schema files. These are installed in the schema cache, which can be found in *\<Visual Studio installation directory>\Xml\Schemas\1033\MSBuild*.

 The core [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] types are defined in *Microsoft.Build.Core.xsd* and common types used by [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] are defined in *Microsoft.Build.CommonTypes.xsd*. To customize the schemas so that you have IntelliSense and validation for custom item type names, properties, and tasks, you can either edit *Microsoft.Build.xsd*, or create your own schema that includes the CommonTypes or Core schemas. If you create your own schema you will have to direct the XML editor to find it using the **Properties** window.

## Edit loaded project files
 [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] caches the content of project files and files imported by project files. If you edit a loaded project file, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] will automatically prompt you to reload the project so that the changes take effect. However if you edit a file imported by a loaded project, there will be no reload prompt and you must unload and reload the project manually to make the changes take effect.

## Output groups
 Several targets defined in *Microsoft.Common.targets* have names ending in `OutputGroups` or `OutputGroupDependencies`. [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] calls these targets to get specific lists of project outputs. For example, the `SatelliteDllsProjectOutputGroup` target creates a list of all the satellite assemblies a build will create. These output groups are used by features like publishing, deployment, and project to project references. Projects that do not define them will load and build in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], but some features may not work correctly.

## Reference resolution
 Reference resolution is the process of using the reference items stored in a project file to locate actual assemblies. [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] must trigger reference resolution in order to show detailed properties for each reference in the **Properties** window. The following list describes the three types of references and how they are resolved.

- Assembly references:

   The project system calls a target with the well-known name `ResolveAssemblyReferences`. This target should produce items with the item type name `ReferencePath`. Each of these items should have an item specification (the value of the `Include` attribute of an item) containing the full path to the reference. The items should have all the metadata from the input items passed through in addition to the following new metadata:

  - `CopyLocal`, indicating whether the assembly should be copied into the output folder, set to true or false.

  - `OriginalItemSpec`, containing the original item specification of the reference.

  - `ResolvedFrom`, set to "{TargetFrameworkDirectory}" if it was resolved from the .NET Framework directory.

- COM references:

   The project system calls a target with the well-known name `ResolveCOMReferences`. This target should produce items with the item type name `ComReferenceWrappers`. Each of these items should have an item specification containing the full path to the interop assembly for the COM reference. The items should have all the metadata from the input items passed through, in addition to new metadata with the name `CopyLocal`, indicating whether the assembly should be copied into the output folder, set to true or false.

- Native references

   The project system calls a target with the well-known name `ResolveNativeReferences`. This target should produce items with the item type name `NativeReferenceFile`. The items should have all the metadata from the input items passed through, in addition to a new piece of metadata named `OriginalItemSpec`, containing the original item specification of the reference.

## Performance shortcuts
 If you use the Visual Studio IDE to start debugging (either by choosing the F5 key or by choosing **Debug** > **Start Debugging** on the menu bar) or to build your project (for example, **Build** > **Build Solution**), the build process uses a fast update check to improve performance. In some cases where customized builds create files that get built in turn, the fast update check does not correctly identify the changed files. Projects that need more thorough update checks can turn off the fast checking by setting the environment variable `DISABLEFASTUPTODATECHECK=1`. Alternatively, projects can set this as an MSBuild property in the project or in a file the project imports.

 For regular builds in Visual Studio, the fast update check doesn't apply, and the project will build as if you invoked the build at a command prompt.

## See also
- [How to: Extend the Visual Studio build process](../msbuild/how-to-extend-the-visual-studio-build-process.md)
- [Start a build from within the IDE](../msbuild/starting-a-build-from-within-the-ide.md)
- [Register extensions of the .NET Framework](../msbuild/registering-extensions-of-the-dotnet-framework.md)
- [MSBuild concepts](../msbuild/msbuild-concepts.md)
- [Item element (MSBuild)](../msbuild/item-element-msbuild.md)
- [Property element (MSBuild)](../msbuild/property-element-msbuild.md)
- [Target element (MSBuild)](../msbuild/target-element-msbuild.md)
- [Csc task](../msbuild/csc-task.md)
- [Vbc task](../msbuild/vbc-task.md)
