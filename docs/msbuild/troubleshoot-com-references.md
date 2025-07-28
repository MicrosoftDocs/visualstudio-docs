---
title: Troubleshoot COM reference build errors
description: Learn how to understand and troubleshoot COM reference problems in .NET builds with MSBuild.
ms.date: 06/13/2025
ms.topic: how-to
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Troubleshoot COM references

COM is a Windows technology for defining and operating with objects and types that can be consumed by diverse client apps across the Windows platform. See [Component Object Model (COM)](/windows/win32/com/component-object-model--com--portal).

You might reference a COM component in a .NET project, in which case it must be projected in a managed assembly, referred to as a primary interop assembly, or PIA. The interop assembly contains managed types that correspond to COM object types (as represented by interfaces described in type libraries) and forwards API calls to COM. For general information about COM Interop, see [COM Interop](/dotnet/standard/native-interop/cominterop).

COM components may be referenced in .NET Framework projects, or in .NET Core (including .NET 5 or later) projects. Visual Studio provides ways to add references to COM objects. For example, a COM component that is a Windows UI control (an ActiveX control) might be presented in the Toolbox, and when you drag it and drop it on to your Windows form or a Windows Presentation Foundation (WPF) form, it is added as a `COMReference` in the project file.

You can also add COM references directly in Solution Explorer. Right-click on **Dependencies**, and select **Add COM Reference**.

MSBuild can create the wrapper assemblies for COM references. During a build, the [`ResolveComReference` task](./resolvecomreference-task.md) runs and uses the system registry to locate any referenced COM objects, generates wrappers by calling `tlbimp.exe`, and writes it to disk under the project folder.

Next, this article shows various ways of referencing COM components, and some of the possible errors that can occur when using each method.

## COMReference

The `COMReference` item type references the COM component by using the system registry. The GUID and version are the primary keys used to locate the component.

```xml
  <ItemGroup>
    <COMReference Include="MyComLibrary">
      <Guid>{01234567-89AB-CDEF-0123-456789ABCDEF}</Guid>
      <VersionMajor>1</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>tlbimp</WrapperTool>
    </COMReference>
  </ItemGroup>

</Project>
```

Because the system registry is used, components have to be registered on the build machine. This works best if you only build from Visual Studio on your local machine where you control what's installed and you may have admin rights to write to the registry. However, when you build on a server or in a container, such as in CI/CD scenarios, you have to ensure that the right products are installed on the build server, and changes to the server, such as installing a new version of Office, or uninstalling a software package, introduce the risk of breaking the build. Or worse, not breaking the build, but referencing a different version of the same component than the one your code was written for.

The other issue is the COM component you get from the registry might have some slight differences to the component that your code was written for. It depends on the publisher of the component and whether any updates have been installed that modified it, without changing the version numbers. This type of incompatibility wouldn't produce a build error, but might produce an error at runtime, if the changes were significant enough to break something your app depends on.

General information about how COM components are represented in the registry can be found at [Registering COM applications](/windows/win32/com/registering-com-applications).

## COMFileReference

The `COMFileReference` item type references COM components by file path. The registry is not used at build time. This is an important alternative to `COMReference` if you don't want your build process to depend on the system registry. If you use `COMFileReference`, you don't have to worry about how to register the COM components your app needs until the application is installed and run on the user's machine, which is a big benefit because your build process might be running without the elevated privileges required to write to the registry.

```xml
<ItemGroup>
  <COMFileReference Include="Controls\MyCom32.dll" />
</ItemGroup>
```

To avoid writing to the registry entirely, use [reg-free COM](/dotnet/framework/interop/registration-free-com-interop) with a manifest.

There could still be an issue with a component not being the same as what you coded against, if the referenced path is not under your control. If a software package updates the component on the build machine, without updating the version information, you might find you're loading a different component with a potential incompatibility. To avoid this, you can use a cached, known version of the COM binaries and only reference that.

## Reference

This is the recommended way to reference COM components with newer versions of .NET. Wrapper assemblies are pregenerated, instead of being built at every build session, and the outputs are referenced directly as managed assemblies.

Sometimes wrapper assemblies (PIAs) are distributed by the provider of the COM components. If that's the case, you can reference them directly as managed assemblies. This is no different from referencing any other .NET assembly, except that at runtime, there's a dependency on the COM component being installed and registered.

To create the wrapper assemblies yourself for COM components you want to use, use `tlbimp.exe` or `aximp.exe` for ActiveX controls.

Using this method, you can avoid requiring elevated privileges to write to the system registry at build time. If you generate your own wrapper assemblies and store them in a place you control, perhaps in a NuGet package or in a folder accessible to your solution, you can be insulated from changes that are beyond your control.

## Bitness

If your project references 32-bit COM components, you must build using `MSBuild.exe` or Visual Studio, not `dotnet build`. This is because `dotnet build` runs the 64-bit version of MSBuild, which is not capable of working with 32-bit COM components.

COM components were once all compiled to 32-bit binaries. Later, when 64-bit technology was introduced, it became possible to compile a COM component to both 32-bit and 64-bit binaries. The same component is often available in both 32-bit and 64-bit binaries. In such cases, the GUID or CLSID that identifies that unique component is the same for both 32-bit and 64-bit binaries, but the registry itself is forked into 32-bit and 64-bit sections of the registry.

Errors can arise if your projects aren't configured properly to reference the correct bitness of the COM component you need. If your COM component is only available as a 32-bit binary, your app can only use it if it runs as a 32-bit process. If your .NET assembly is built as a 32-bit assembly, it can reference 32-bit COM components. If it's built as a 64-bit assembly, it can reference 64-bit COM components. However, if your assembly is built as `Any CPU`, you have to be careful when referencing COM components, which don't have the equivalent of `Any CPU`. It might be better to build your application in both 32-bit and 64-bit forms, which reference the right COM components, assuming the COM components are available in both bitness forms.

There's an additional build property `Prefer32bit` (also a checkbox in Visual Studio) which causes an assembly built as `Any CPU` to always run as 32-bit on a 64-bit machine. This would work to run with 32-bit COM components, but it might be misleading for anyone using the project later.

You can use `Condition` attributes on the `PlatformTarget` property to reference two different bitness forms of a single COM component. For example,

```xml
<ItemGroup Condition="'$(PlatformTarget)' == 'x86'">
  <COMFileReference Include="Controls\MyCom32.dll" />
</ItemGroup>
<ItemGroup Condition="'$(PlatformTarget)' == 'x64'">
  <COMFileReference Include="Controls\MyCom64.dll" />
</ItemGroup>
```

When you build for x86, you reference the 32-bit COM DLL, but when you build for x64, you reference the 64-bit version.

## How MSBuild resolves COM references

The basic algorithm is described here, including the sequence of steps in resolving a reference, what executables are run (for example, `tlbimp.exe`), and what Windows API calls are used.

In the standard .NET SDK build process, the `ResolveComReference` task is called in the common targets files in a target named `ResolveComReferences`. The target is invoked once per project and processes all the COM references, both `COMReference` and `COMFileReference`. For more information, see [ResolveComReference task](resolvecomreference-task.md).

The task walks the dependency tree, attempting to resolve all the references. Most errors with individual references are not fatal; MSBuild continues to attempt to resolve other references. Some errors are fatal, if they would affect all references equally.

If the COM component is found in the registry or in the filesystem, MSBuild typically tries to reuse previously built wrapper assemblies, but if necessary, it generates the wrappers. With default settings, the wrapper assemblies are generated by running `tlbimp.exe` and placed in a folder under the project folder. The `tlbimp.exe` is included in the [.NET Framework SDK](https://dotnet.microsoft.com/download/visual-studio-sdks).

By setting properties, you can customize the arguments and settings provided to the `ResolveComReference` task. You can configure whether to use previously built wrapper assemblies, either previously built or in the cache (if the cache option is being used). You can customize the output folder. You can set `EmbedInteropTypes` to true to embed the projected types a in the library or executable being built, instead of in a separate wrapper assembly.

## Diagnostic tools

To diagnose the specific build error, you need to see the detailed input to the `ResolveComReference` task that failed.

### Verbose diagnostics

Set verbose diagnostics (`-v:diag` switch on the MSBuild command line) or in Visual Studio, under **Tools Options**, **Environment**, **Build and Run**, set output level to **Diagnostic**.

### View binary logs

Generate a binary log (`-bl` switch on the MSBuild command line), and use the [structured log viewer](https://msbuildlog.com), which provides a UI that makes it much easier to see the detailed steps in the build, the values of task input parameters, and so on.

Here's the view of the `ResolveComReferences` target in the structured log viewer. You can inspect the parameters and outputs, which represent the resolved reference paths and wrapper assemblies. In this example, the wrapper assembly location is expanded to show the location and filename of the generated wrapper assembly.

:::image type="content" source="./media/vs-2022/resolve-com-references-log-viewer.png" lightbox="./media/vs-2022/resolve-com-references-log-viewer.png" alt-text="Screenshot of the MSBuild structured log viewer, looking at the ResolveComReferences target.":::

Once you've identified the component's name, GUID, and version that produced a failure, you can review all the properties and items provided to the `ResolveComReference` task and gather information about this component from the system registry. You can use the registry editor `regedit.exe`, but editing the registry requires Administrator privileges.

### RegEdit

Become familiar with the registry locations for COM components, both 32-bit and 64-bit registry locations. GUIDs that identify a COM class type are called class IDs (CLSID) and stored under CLSID in the registry. On a 64-bit machine, 64-bit components are registered under `HKEY_LOCAL_MACHINE\Software\Classes\CLSID\`, but 32-bit components are registered under `HKEY_LOCAL_MACHINE\Software\WOW6432Node\Classes\CLSID\`. On a 32-bit machine, 32-bit components are registered under `HKEY_LOCAL_MACHINE\Software\Classes\CLSID\`. You usually find the component by searching for its name or GUID in the registry editor. If the component's registration is in a registry hive, as in the case of Visual Studio components, you might have to locate and open the hive. See [Editing the registry for a Visual Studio instance](../install/tools-for-managing-visual-studio-instances.md#editing-the-registry-for-a-visual-studio-instance).

### OleView

You might prefer to use [`oleview.exe`](/windows/win32/com/ole-com-object-viewer) to investigate an individual COM type, and get information such as the type library and what interfaces it implements. OLEView doesn't require admin permissions and is much easier to use than `regedit.exe`.

### Procmon

You can use Process Monitor [`procmon`](/sysinternals/downloads/procmon) to monitor applications that use COM at runtime, and monitor registry changes.

## Common problems

This section describes common problems that can occur when using COM references.

### Registration issues

Is the component registered on the build machine? If one of your own components isn't registered, it can be registered manually using a command-line tool, `regsvr32.exe`. (This command requires elevated permissions on the machine.) If the components are part of a software package, like Office, make sure the right version of the product that distributes and registers the component is installed. Try repairing or reinstalling the software product or package.

Confirm the properties of the `COMReference`. Are the name, GUID, and versions correct, the same as in the registry? Check for typos, spelling errors, version mismatches, or other inconsistencies.

Consider if the component is a 32-bit or a 64-bit component, if both versions are available. If you're targeting ARM64, see [Build Arm64X binaries](/windows/arm/arm64x-build).

With `COMFileReference`, you reference a COM component by its file location. Check the path to the file and make sure it's correct, accounting for the current working directory if it's a relative path.

### Type library issues

A type library is required to generate an interop assembly. Type libraries can be embedded in a binary like a DLL, or they can be in a separate file, a TLB file (`.tlb` extension).

If you can't find a type library for the COM component, you can often generate one. You don't normally have to generate a type library. It should be installed with the component, distributed by the component provider. Common solutions include installing, upgrading, or reinstalling a software package.

There are ways to generate a type library from a COM binary in the rare case where one is needed. For example, you can open the binary in the Visual Studio resource editor, or a third-party resource editor, locate the type library resource, export it, and use **Save File As** to save it as a text file with the `tlb` extension.

### Failed to scan dependencies

[MSB3304](errors/msb3304.md) occurs if there's any issue scanning the dependencies of the reference. The `ResolveComReference` task tries to walk the entire dependency graph, so any issues identifying the dependencies gives this error. The error message given depends on the specific issue. If the error comes from `tlbimp.exe`, you can also try running `tlbimp.exe` on the command line to get more details on the problem.

### Problems generating wrapper assemblies

MSBuild tries to find existing wrapper assemblies in its cache from a previous run, if this option was specified, or reuse previously generated wrappers. If necessary, it generates the wrapper. The tool `tlbimp.exe` is used to build wrapper assemblies. A folder is created to contain the wrapper assemblies. By default, the folder is created in the project folder, but this is set by the `WrapperAssemblyLocation` parameter of the `ResolveComReference` task. If this process fails, the error [MSB3290](errors/msb3290.md) or [MSB3283](errors/msb3283.md) is given, along with the error information from the operating system. See the suggested troubleshooting tips for those specific errors.

### Bad COMReference or COMFileReference syntax

If MSBuild fails to convert the metadata from the project file, you get error [MSB3095](errors/msb3095.md). If this occurs, check for typos or other errors in the COM references (or any properties used in the COM references) in the project file. Check the subelements of the `COMReference` element against the expected metadata as documented in [MSBuild common project items](./common-msbuild-project-items.md#comreference) for syntax errors or missing metadata.

### File IO errors

The `ResolveComReference` task reads and writes to the filesystem, which means it can fail with a system IO error, which are caught by MSBuild and reported under a generic MSBuild error code. Look to the error details in the messages from the operating system. Check the spelling and correctness of any paths, and for paths constructed from MSBuild properties, check the properties to ensure that they are defined and have the expected values.

### Warnings

Some issues with COM reference resolution are reported as warnings. You might see [MSB3305](errors/msb3305.md), which is given when an underlying function call reports a non-fatal issue, such as a potential type conversion issue. You can suppress such warnings by setting the MSBuild property `ResolveComReferenceSilent` to `true`. We don't recommend using this setting permanently, but it might be useful if you understand the issue and want to suppress the notification temporarily. You can also use standard techniques to suppress warnings. See [Supress build warnings](..//ide/how-to-suppress-compiler-warnings.md#suppress-a-warning-by-editing-the-project-file).

## Windows native method calls

The `ResolveComReference` might call certain Windows API functions. Errors from these API calls are passed on to the build output. These are listed here for reference.

| Function name | Description |
| - | - |
| [FreeLibrary](/windows/win32/api/libloaderapi/nf-libloaderapi-freelibrary) | Frees the loaded dynamic-link library (DLL) module. |
| [GetModuleFileName](/windows/win32/api/libloaderapi/nf-libloaderapi-getmodulefilenamew) | Retrieves the fully qualified path for the file that contains the specified module. |
| [LoadLibrary](/windows/win32/api/libloaderapi/nf-libloaderapi-loadlibraryw) | Loads the specified module into the address space of the calling process.  |
| [LoadRegTypeLib](/windows/win32/api/oleauto/nf-oleauto-loadregtypelib) | Uses registry information to load a type library. |
| [QueryPathOfRegTypeLib](/windows/win32/api/oleauto/nf-oleauto-querypathofregtypelib) | Retrieves the path of a registered type library. |

## Related content

- [ResolveComReference task](./resolvecomreference-task.md)
- [COM Interop](/dotnet/standard/native-interop/cominterop)