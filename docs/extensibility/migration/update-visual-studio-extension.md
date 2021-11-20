---
title: Update a Visual Studio extension
description: Learn how to update your Visual Studio extension to work with Visual Studio 2022.
ms.date: 06/08/2021
ms.topic: conceptual
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
monikerRange: "vs-2022"
ms.workload:
- vssdk
feedback_system: GitHub
---
# Update a Visual Studio extension for Visual Studio 2022

> [!IMPORTANT]
> The advice in this guide is intended to guide developers in migrating extensions that require major changes to work both in Visual Studio 2019 and 2022. In those cases it is recommended to have two VSIX projects and conditional compilation.
> Many extensions will be able to work in both Visual Studio 2019 and 2022 with minor changes that won't require following the advice on modernizing your extension in this guide.
> Try your extension in Visual Studio 2022 and evaluate what option is best for your extension.

You can update your extension to work with Visual Studio 2022 by following this guide. Visual Studio 2022 is a 64-bit application, and introduces some breaking changes in the VS SDK. This guide walks you through the steps required to get your extension working with the current preview of Visual Studio 2022, so your extension can be ready for users to install before Visual Studio 2022 reaches GA.

## Installing

Install Visual Studio 2022 from [Visual Studio 2022 downloads](https://visualstudio.microsoft.com/downloads).

### Extensions written in a .NET language

The VS SDK targeting Visual Studio 2022 for managed extensions is up *exclusively* on NuGet:

- The [Microsoft.VisualStudio.Sdk](https://www.nuget.org/packages/Microsoft.VisualStudio.Sdk/) (17.x versions) meta-package brings in most or all of the reference assemblies you will need.
- The [Microsoft.VSSDK.BuildTools](https://www.nuget.org/packages/Microsoft.VSSDK.BuildTools/) (17.x versions) package should be referenced from your VSIX project so it can build a Visual Studio 2022-compliant VSIX.

Even if you don't reference any breaking changes, extensions *must* be compiled with the "Any CPU" or "x64" platform. The "x86" platform is incompatible with Visual Studio 2022's 64-bit process.

### Extensions written in C++

The VS SDK for extensions compiled with C++ is available with the installed Visual Studio SDK, as usual.

Even if you don't reference any breaking changes, extensions *must* be compiled specifically against the Visual Studio 2022 SDK and for amd64.

### Update your extension to Visual Studio 2022

#### Extensions with running code

Extensions with running code *must* be compiled specifically for Visual Studio 2022. Visual Studio 2022 will not load any extension that does not target Visual Studio 2022 specifically.

Learn how to migrate your pre-Visual Studio 2022 extensions to Visual Studio 2022:

1. [Modernize your projects](#modernize-your-vsix-project).
1. [Refactor your source code into a shared project](#use-shared-projects-for-multi-targeting) to allow for targeting Visual Studio 2022 and older versions.
1. [Add a Visual Studio 2022-targeted VSIX project](#add-a-visual-studio-2022-target), and our [package/assembly remapping table](migrated-assemblies.md).
1. [Making necessary code adjustments](#handle-breaking-api-changes).
1. [Testing your Visual Studio 2022 extension](#test-your-extension).
1. [Publishing your Visual Studio 2022 extension](#publish-your-extension).

#### Extensions without running code

Extensions that do not contain any running code (for example, project/item templates) are *not* required to follow the above steps including the production of two distinct VSIXs.

Instead, the one VSIX should be modified so that its `source.extension.vsixmanifest` file declares two installation targets, like this:

```xml
<Installation>
   <InstallationTarget Id="Microsoft.VisualStudio.Community" Version="[15.0,17.0)">
      <ProductArchitecture>x86</ProductArchitecture>
   </InstallationTarget>
   <InstallationTarget Id="Microsoft.VisualStudio.Community" Version="[17.0,18.0)">
      <ProductArchitecture>amd64</ProductArchitecture>
   </InstallationTarget>
</Installation>
```

You can skip the steps in this article about using shared projects and multiple VSIXs. You can proceed with [testing](#test-your-extension)!

> [!NOTE]
> If you are authoring a *new* Visual Studio extension, using Visual Studio 2022, and want to (also) target Visual Studio 2019 or an earlier version, check out [this guide](target-previous-versions.md).

### MSBuild tasks

If you author MSBuild tasks, be aware that in Visual Studio 2022 it is much more likely that they will be loaded in a 64-bit MSBuild.exe process. If your task requires a 32-bit process to run, refer to [this MSBuild documentation](../../msbuild/how-to-configure-targets-and-tasks.md#usingtask-attributes-and-task-parameters) to ensure MSBuild knows to load your task in a 32-bit process.

## Modernize your VSIX project

Before adding Visual Studio 2022 support to your extension, we strongly recommend taking this time to clean up and modernize your existing project before going further, including:

1. [Migrate from packages.config to `PackageReference`](/nuget/consume-packages/migrate-packages-config-to-package-reference).

1. Replace any direct assembly VS SDK assembly references with PackageReference items.

   ```diff
   -<Reference Include="Microsoft.VisualStudio.OLE.Interop" />
   +<PackageReference Include="Microsoft.VisualStudio.OLE.Interop" Version="..." />
   ```

   > [!TIP]
   > You can replace *many* assembly references with just *one* PackageReference to our metapackage:
   >
   >```diff
   >-<Reference Include="Microsoft.VisualStudio.OLE.Interop" />
   >-<Reference Include="Microsoft.VisualStudio.Interop" />
   >-<Reference Include="Microsoft.VisualStudio.Interop.8.0" />
   >+<PackageReference Include="Microsoft.VisualStudio.Sdk" Version="..." />
   >```

   Be sure to pick package versions that match the minimum version of Visual Studio you are targeting.

   Some assemblies that are not unique to the VS SDK (for example, Newtonsoft.Json.dll) may have been discoverable through a simple `<Reference Include="Newtonsoft.Json" />` reference before Visual Studio 2022 but in Visual Studio 2022 requires a package reference instead because in Visual Studio 2022, we remove some Visual Studio runtime and SDK directories from MSBuild's default assembly search path.

   In switching from direct assembly references to NuGet package references, you might pick up additional assembly references and analyzer packages due to NuGet automatically installing the transitive closure of dependencies. This is generally OK, but might result in additional warnings being flagged during your build. Work through these warnings and resolve as many as you can, and consider suppressing those warnings you cannot resolve using in-code `#pragma warning disable <id>` regions.

## Use shared projects for multi-targeting

[Shared projects](/xamarin/cross-platform/app-fundamentals/shared-projects?tabs=windows) are a project type that were introduced in Visual Studio 2015. Shared projects in Visual Studio enable source code files to be shared between multiple projects and build differently using conditional compilation symbols and unique sets of references.

Because Visual Studio 2022 requires a distinct set of reference assemblies from all prior VS versions, our guidance is to use shared projects to conveniently multi-target your extension to pre-Visual Studio 2022 and Visual Studio 2022 (and later versions), giving you code sharing, but distinct references.

In the context of Visual Studio extensions, you could have one VSIX project for Visual Studio 2022 and later and one VSIX project for Visual Studio 2019 and earlier. Each of these projects would contain just a `source.extension.vsixmanifest` and the package references to either the 16.x SDK or the 17.x SDK. These VSIX projects would also have a shared project reference to a new shared project that will host all your source code that can be shared across the two VS versions.

As a starting point, for this document we will assume you already have a VSIX project that targets Visual Studio 2019 and that you want your extension to work on Visual Studio 2022.

All these steps can be completed with Visual Studio 2019.

1. If you have not already done so, [modernize your projects](#modernize-your-vsix-project) to ease steps later in this update process.

1. Add a new shared project to your solution for each existing project that references the VS SDK.
   ![Add New Project command](media/update-visual-studio-extension/add-new-project.png)
   ![New project template](media/update-visual-studio-extension/new-shared-project-template.png)

1. Add a reference from each VS SDK-referencing project to its shared project counterpart.
   :::image type="content" source="media/update-visual-studio-extension/add-shared-project-reference.png" alt-text="Add shared project reference" lightbox="media/update-visual-studio-extension/add-shared-project-reference.png":::

1. Move all the source code (including .cs, .resx) from each VS SDK-referencing project to its shared project counterpart.
Leave the `source.extension.vsixmanifest` file in the VSIX project.
   ![Shared project contains all source files](media/update-visual-studio-extension/source-files-in-shared-project.png)

1. Metadata files (release notes, license, icons, and so on) and VSCT files should be moved to a shared directory and added as linked files to the VSIX project. Note that the shared directory is separate from the shared project.
   ![Add metadata and VSCT files as linked files](media/update-visual-studio-extension/add-linked-items-to-vsix.png)
    - For Metadata files, set BuildAction to `Content` and set Include in VSIX to `true`.

      ![Include metadata files in VSIX](./media/update-visual-studio-extension/include-metadata-files-in-vsix.png)
    - For VSCT files, set BuildAction to `VSCTCompile` and don't include in VSIX.
      Visual Studio might complain that this setting is not supported, but you can manually change the build action by unloading the project and changing `Content` to `VSCTCompile`

    ```diff
    -<Content Include="..\SharedFiles\VSIXProject1Package.vsct">
    -  <Link>VSIXProject1Package.vsct</Link>
    -</Content>
    +<VSCTCompile Include="..\SharedFiles\VSIXProject1Package.vsct">
    +  <Link>VSIXProject1Package.vsct</Link>
    +  <ResourceName>Menus.ctmenu</ResourceName>
    +</VSCTCompile>
    ```

      ![Set VSCT files as VSCTCompile](media/update-visual-studio-extension/build-linked-vsct-files.png)

1. Build your project(s) to confirm you have not introduced any new errors.

Your project is now ready to add Visual Studio 2022 support.

## Add a Visual Studio 2022 target

This document assumes you have completed the steps to [factor your Visual Studio extension with shared projects](#use-shared-projects-for-multi-targeting).

Proceed to add Visual Studio 2022 support to your extension with these steps, which may be completed using Visual Studio 2019:

1. Add a New VSIX Project to your solution. This will be the project that targets Visual Studio 2022. Remove any source code that came with the template, but *keep the `source.extension.vsixmanifest` file*.

1. On your new VSIX project, Add a shared project reference to the same shared project that your Visual Studio 2019-targeting VSIX references.

   ![A solution with one shared project and two VSIX projects](media/update-visual-studio-extension/shared-project-with-two-heads.png)

1. Verify that the new VSIX project builds properly. You might need to add references to match your original VSIX project to resolve any compiler errors.

1. For managed VS extensions, update your package references from 16.x (or earlier) to the 17.x package versions in your Visual Studio 2022-targeted project file using the NuGet Package Manager or directly editing the project file:

    ```diff
    -<PackageReference Include="Microsoft.VisualStudio.SDK" Version="16.0.206" />
    +<PackageReference Include="Microsoft.VisualStudio.SDK" Version="17.0.0-preview.1" />
    -<PackageReference Include="Microsoft.VSSDK.BuildTools" Version="16.10.32" />
    +<PackageReference Include="Microsoft.VSSDK.BuildTools" Version="17.0.63-preview.1" />
    ```

   You'll use versions that are actually available from nuget.org. The ones used previously are just for demonstration purposes.

   In many cases, package IDs have changed. Refer to the [package/assembly mapping table](migrated-assemblies.md) for a list of changes in Visual Studio 2022.

   Extensions written in C++ do not yet have an available SDK to compile with.

1. For C++ projects, they must be compiled for amd64. For managed extensions, consider changing your project from building for Any CPU to targeting `x64`, to reflect that in Visual Studio 2022 your extension always loads in a 64-bit process. `Any CPU` is fine too, but may produce warnings if you reference any x64-only native binaries.

   Any dependency your extension may have on a native module will have to be updated from an x86 image
   to an amd64 image.

1. Edit your `source.extension.vsixmanifest` file to reflect targeting Visual Studio 2022. Set the `<InstallationTarget>` tag to reflect Visual Studio 2022 and indicate an amd64 payload:

   ```xml
   <InstallationTarget Id="Microsoft.VisualStudio.Community" Version="[17.0,18.0)">
      <ProductArchitecture>amd64</ProductArchitecture>
   </InstallationTarget>
   ```

   In Visual Studio 2019, the designer for this file does not expose the new `ProductArchitecture` element,
   so this change will need to be done with an xml editor, which you can access via the **Open With** command in **Solution Explorer**.

   This `ProductArchitecture` element is critical. Visual Studio 2022 will *not* install your extension without it.

   | Element | Value | Description |
   | - | - | - |
   | ProductArchitecture | X86, AMD64 | The platforms that are supported by this VSIX. Not case sensitive. One platform  per element and one element per  InstallTarget. For product versions less than 17.0 the default value is x86 and can be omitted.  For product versions 17.0 and greater this element is required and there is no default value. For Visual Studio 2022 the only valid content for this element is "amd64". |

1. Make any other adjustments necessary in your source.extension.vsixmanifest to match the one that targets Visual Studio 2019 (if any). If you are publishing 2 different versions of your extension each targeting a different version of VS, it is critical that the ID of the VSIX, in the `Identity` element of the manifest, is different for both extensions.

At this point, you have a Visual Studio 2022-targeted extension VSIX. You should build your Visual Studio 2022-targeted VSIX project and [work through any build breaks that appear](#handle-breaking-api-changes). If you do not have build breaks in your Visual Studio 2022-targeted VSIX project,
congratulations: you're ready for testing!

## Handle breaking API changes

There are [breaking API changes](breaking-api-list.md) in Visual Studio 2022 that may require changes to your code from when it ran on prior versions. Review that document for tips on how to update your code for each of them.

When adapting your code, we recommend you use [conditional compilation](#use-conditional-compilation-symbols) so that your code can continue to support pre-Visual Studio 2022 while adding support for Visual Studio 2022.

When you get your Visual Studio 2022-targeted extension building, proceed to [testing](#test-your-extension).

## Use conditional compilation symbols

If you wish to use the same source code, even the same file, for Visual Studio 2022 and earlier versions, you might need to use conditional compilation so that you can fork your code to adapt to breaking changes. Conditional compilation is a feature of the C#, Visual Basic, and C++ languages that can be used to share most code while accommodating divergent APIs in specific places.

More information on usage of preprocessor directives and conditional compilation symbols can be found in the Microsoft docs [#if
preprocessor directive](/dotnet/csharp/language-reference/preprocessor-directives#conditional-compilation).

Your project(s) that target earlier Visual Studio versions will need a conditional compilation symbol that can then be used to fork the code to use the different APIs. You can set the conditional compilation symbol in the project properties page, as shown in the following image:

![Setting conditional compilation symbols](media/update-visual-studio-extension/conditional-compilation-symbols.png)

Be sure to set the compilation symbol for *all* configurations, since by default the symbol you enter may only apply to one configuration.

### C\# techniques

You can then use that symbol as a pre-processor directive (`#if`) as shown in the following code. You can then fork your code to deal with the breaking change between the different Visual Studio versions.

```cs
    Guid myGuid = new Guid("{633FBA02-719B-40E7-96BF-0899767CD104}");
    uint myFlags = 0;
    IVsShell shell = await AsyncServiceProvider.GlobalProvider.GetServiceAsync<SVsShell, IVsShell>();
#if Dev16
    shell.LoadUILibrary(myGuid, myFlags, out uint ptrLib);
#else
    shell.LoadUILibrary(myGuid, myFlags, out IntPtr ptrLib);
#endif
```

In some cases, you can simply use `var` to avoid naming the type, thus avoiding the need for `#if` regions. The above snippet can also be written as:

```cs
    Guid myGuid = new Guid("{633FBA02-719B-40E7-96BF-0899767CD104}");
    uint myFlags = 0;
    IVsShell shell = await AsyncServiceProvider.GlobalProvider.GetServiceAsync<SVsShell, IVsShell>();
    shell.LoadUILibrary(myGuid, myFlags, out var ptrLib);
```

When using the `#if` syntax, notice how you can use the language service context dropdown in the document shown below to change syntax highlighting and the other help the language service offers to focus attention on one target Visual Studio version for our extension vs. another.

![Conditional compilation in a shared project](media/update-visual-studio-extension/conditional-compilation-if-region.png)

### XAML sharing techniques

XAML has no preprocessor to allow customizing content based on preprocessor symbols. Copying and maintaining two XAML pages where their content must differ between Visual Studio 2022 and earlier versions may be required.

However in some cases, a reference to a type that exists in distinct assemblies across Visual Studio 2022 and earlier versions might still be representable in one XAML file by removing the namespace that references the assembly:

```diff
-xmlns:vsui="clr-namespace:Microsoft.VisualStudio.PlatformUI;assembly=Microsoft.VisualStudio.Shell.14.0"
-Value="{DynamicResource {x:Static vsui:TreeViewColors.SelectedItemActiveBrushKey}}"
+Value="{DynamicResource TreeViewColors.SelectedItemActiveBrushKey}"
```

## Test your extension

To test an extension that targets Visual Studio 2022 you will need to have Visual Studio 2022 installed.
You will not be able to run 64-bit extensions on versions of Visual Studio prior to Visual Studio 2022.

You can use Visual Studio 2022 to build and test your extensions whether they target Visual Studio 2022 or an earlier version. When launching a VSIX project from Visual Studio 2022 an experimental instance of Visual Studio will be launched.

We strongly recommend you test with each version of Visual Studio that you intend the extension to support.

Now you're ready to [publish your extension](#publish-your-extension).

## Publish your extension

Great, so you've added a Visual Studio 2022 target to your extension and tested it. Now you are ready to publish the extension for the world to admire.

### Visual Studio Marketplace

Publishing your extension to the [Visual Studio Marketplace](https://marketplace.visualstudio.com/) is a great way to get new users to find and install your extension. Whether your extension targets Visual Studio 2022 exclusively or targets older VS versions too, the Marketplace is there to support you.

In the future, the Marketplace will allow you to upload multiple VSIXs to just one Marketplace listing, allowing you to upload your Visual Studio 2022-targeted VSIX and a pre-Visual Studio 2022 VSIX. Your users will automatically get the right VSIX for the VS version they have installed, when using the VS extension manager.

### Custom installer

If you build an MSI/EXE to install your extension and spawn vsixinstaller.exe to install (part of) your extension,
know that the VSIX installer in Visual Studio 2022 has been updated. Developers will need to use the version of the VSIX
installer that comes with Visual Studio 2022 to install extensions to Visual Studio 2022. The VSIX installer in Visual Studio 2022 will also install applicable extensions targeting previous versions of Visual Studio that are installed side by side with Visual Studio 2022 on the same machine.

### Network share

You can share your extension over a LAN or any other way. If you target Visual Studio 2022 and pre-Visual Studio 2022, you will need to share you multiple VSIXs individually and give them filenames (or place them in unique folders) that help your users know which VSIX to install based on the version of Visual Studio they have installed.

### Other considerations

#### Dependencies

If your VSIX specifies another VSIX as a dependency via the
`<dependency>` element, each referenced VSIX needs to install in the same targets and product architectures as your VSIX. If a dependent VSIX does not support the targeted installation of Visual Studio, your VSIX will fail. It's ok for the dependent VSIX to support more targets and architectures than yours, just not less. This restriction means that the deployment and distribution approach of a VSIX with dependencies should
mirror that of their dependents.

## Q & A

**Q**: My extension does not require any interop changes as it just provides data (for example, templates), can I create a single extension that includes Visual Studio 2022 as well?

**A**: Yes!  See [Extensions without running code](#extensions-without-running-code) for more info about this.

**Q**: A NuGet dependency is bringing in old interop assemblies and causing clashing classes.

**A**: Add the following line to your .csproj file to avoid duplicate assemblies:

```xml
    <PackageReference Include="<Name of offending assembly>" ExcludeAssets="compile" PrivateAssets="all" />
```

This will prevent package references from importing the old version of the assembly from other dependencies.

**Q**: My commands and hotkeys are not working in Visual Studio after switching my source files to a shared project.

**A**: [Step 2.4](samples.md#step-2---refactor-source-code-into-a-shared-project) of the Image Optimizer sample shows how to add VSCT files as linked items so that they are compiled into your VSCT file.

## Next steps

Follow a step-by-step example, [ImageOptimizer](samples.md), with links to the project and code changes for each step.
