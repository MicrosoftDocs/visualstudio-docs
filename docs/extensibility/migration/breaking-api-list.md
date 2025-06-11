---
title: Breaking API changes in Visual Studio 2022
description: Learn about API changes that cause existing VS extensions to fail to compile when migrating extensions to Visual Studio 2022.
ms.date: 06/08/2021
ms.topic: reference
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
monikerRange: "vs-2022"

---
# Breaking API changes in Visual Studio 2022

If you're migrating an extension to Visual Studio 2022, the breaking changes listed here might affect you.

## Reference assemblies no longer installed

Many of the assemblies you may have been referencing that MSBuild resolved from a Visual Studio installation directory are no longer installed. You should use NuGet to acquire the Visual Studio SDK ref assemblies you need. See [Modernize projects](update-visual-studio-extension.md#modernize-your-vsix-project) for detailed steps on doing this.

## Removed APIs

In Visual Studio 2022 a number of APIs have been removed as part of moving Visual Studio going forward. A list of the removed APIs can be found on the [Removed API List](removed-api-list.md) page.

## Interop breaking changes

Many of our APIs have changed in Visual Studio 2022, usually with simple changes that are straightforward for your code to accommodate.

To manage the breaking changes, we are planning to provide a new mechanism for the distribution of interop assemblies. Specifically, for Visual Studio 2022 and beyond we provide a single interop assembly with definitions for many common public Visual Studio interfaces. That assembly contains managed definitions for many Visual Studio interfaces moving away from multiple interop assemblies. The new interop assembly is distributed via the `Microsoft.VisualStudio.Interop` NuGet package.

However, Visual Studio components that are primarily used in native contexts and have a low number of breaking changes will continue to have their own interop assemblies (for example, the debugger assembly will still be VisualStudio.Debugger.Interop.dll as it does today). In any case the assemblies can be then referenced from your application, just as they are today.

This is a significant change and means that extensions that use APIs in and assembly built in this new approach are not compatible with older versions of Visual Studio using the previous interop assembly.

This has a few very important advantages that will make updating your extension to Visual Studio 2022 easier:

- Any broken APIs will become build time errors making them easier to find and fix.
- You only need to update code that uses an API that was broken in Visual Studio 2022.
- You will not be able to accidentally use the old, now broken API.

Overall, these changes will result in a more stable version of Visual Studio for all users. The major drawback of this approach is that your managed assemblies will not be able to run in both Visual Studio 2019 and Visual Studio 2022 without compiling your code once for each target Visual Studio version.

As you work through compile errors due to the API differences between Visual Studio 2019 and Visual Studio 2022, you may find the API or pattern you're facing listed below with guidance on how to fix it.

### `int` or `uint` where `IntPtr` is expected

We expect this will be a very common error. To make Visual Studio 2022 a 64-bit process, some of our interop APIs had to be fixed where they assumed a pointer could fit in a 32-bit integer to actually use a pointer-sized value.

Sample error:

> Argument 3: cannot convert from 'out uint' to 'out System.IntPtr'

Simply update your code to expect or provide `IntPtr` or `UIntPtr` where `int` or `uint` used to be to resolve the break.

Sample fix:

```diff
-shell.LoadLibrary(myGuid, myFlags, out uint ptrLib);
+shell.LoadLibrary(myGuid, myFlags, out IntPtr ptrLib);
```

### An interop type defined in two assemblies

When C# compiler reports an error that a type you're using is defined in two assemblies, you probably are referencing an assembly from the Visual Studio 2019 version of the SDK that you should no longer reference.

Sample error:

> error CS0433: The type 'IVsDpiAware' exists in both 'Microsoft.VisualStudio.Interop, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' and 'Microsoft.VisualStudio.Shell.Interop.16.0.DesignTime, Version=16.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'

Refer to our [reference assembly remapping table](migrated-assemblies.md) to see which assembly name is the preferred name in Visual Studio 2022.
Considering the two assemblies named in the sample error above and looking at this table, notice that `Microsoft.VisualStudio.Interop` is the new assembly name. The fix then would be to remove the reference to `Microsoft.VisualStudio.Shell.Interop.16.0.DesignTime` from the project.

In some cases we offer a Visual Studio 2022-versioned package for the deprecated assembly that contains type forwarders. When this is available, you have the option to *upgrade* your package reference to the Visual Studio 2022 version instead of removing it. The type forwarders will resolve the error from the compiler.

Keep in mind that sometimes these references can come by transitive package reference, and thus can be harder to remove than a direct reference made in your project file. In such cases, make sure all your direct package references all are using Visual Studio 2022 SDK packages themselves. You may refer to *project.assets.json* to identify the chain of packages responsible for bringing in the deprecated assembly. Updating a transitive package reference to a Visual Studio 2022 version is as easy as installing it as a direct reference.

If you cannot change the dependency tree (for example, because it involves a third-party dependency), you can add a direct package reference to the pre-Visual Studio 2022 package and add `ExcludeAssets="compile"` metadata to that `PackageReference` item to solve the compiler error. But keep in mind that with this technique, your extension may retain a dependency on a pre-Visual Studio 2022 assembly and your extension may malfunction at runtime.

### Missing reference to an interop assembly

When you reference an assembly that compiled against the pre-Visual Studio 2022 SDK, you may get an error about missing an assembly reference.

Sample error:

> Error CS0012 The type 'IVsTextViewFilter' is defined in an assembly that is not referenced. You must add a reference to assembly 'Microsoft.VisualStudio.TextManager.Interop, Version=7.1.40304.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'

Using the [reference assembly remapping table](migrated-assemblies.md), you can confirm that the requested assembly is in fact not one you should have to reference.

The best fix is to update your dependency to a version that compiled against the Visual Studio 2022 SDK so the removed interop assembly is no longer requested by the compiler.

In some cases we offer a Visual Studio 2022-versioned package for the deprecated assembly that contains type forwarders. When this is available, you have the option to add a package reference to the Visual Studio 2022 version of the obsolete package so the type forwarders will resolve the error from the compiler.

### `IAsyncServiceProvider` is missing

There are two definitions of this interface, in two namespaces. Only one of these was intended for managed consumption.

Visual Studio 2019 Namespace | Visual Studio 2022 Namespace | Intended use
--|--|--
Microsoft.VisualStudio.Shell.IAsyncServiceProvider | Microsoft.VisualStudio.Shell.IAsyncServiceProvider | Managed code consumption
Microsoft.VisualStudio.Shell.Interop.IAsyncServiceProvider | Microsoft.VisualStudio.Shell.COMAsyncServiceProvider.IAsyncServiceProvider | low-level interop only

If you see an error about `IAsyncServiceProvider`, it *may* be that you were using the one intended for native code (the second row).
If so, you can update to the new namespace, or switch to the more managed-friendly interface.

### `DTE` and `_DTE` type cast failures

`DTE` and `_DTE` are both interfaces. One derives from the other. However in Visual Studio 2022, the base and derived types are swapped.
This makes certain type assignments or casts fail.

This also means where you used to use `new DTE()`, you must now use `new _DTE()`.

To mitigate most issues with this, use `DTE2` from the `EnvDTE80` namespace instead.

### Missing argument on a method invocation

A few methods no longer declare default arguments for what were optional parameters in the interop API. If you get an error about a missing argument for a COM interop call, and the parameter calls for an `object` type, the previous default value that the Visual Studio 2019 interop API defined may have been `""`, so consider adding `""` as your argument to resolve the compile error.

When in doubt about what the default argument used to be, try switching your language service context from Visual Studio 2022 to Visual Studio 2019 so you get Intellisense with the older interop assemblies to see what the default argument was, and then add it explicitly to your code. It will continue to work fine when compiled for Visual Studio 2019, but will now compile for Visual Studio 2022.

Sample fix:

```diff
-process4.Attach2();
+process4.Attach2("");
```

### Legacy Find API deprecation

As a part of our efforts to modernize find in files, we have deprecated support to the following APIs of the EnvDTE interface in VS 2022.

- [EditPoint.FindPattern(String, Int32, EditPoint, TextRanges)](/dotnet/api/envdte.editpoint.findpattern?view=visualstudiosdk-2019&preserve-view=true)
- [EditPoint.ReplacePattern(TextPoint, String, String, Int32, TextRanges)](/dotnet/api/envdte.editpoint.replacepattern?view=visualstudiosdk-2019&preserve-view=true)
- [EditPoint.ReplaceText(Object, String, Int32)](/dotnet/api/envdte.editpoint.replacetext?view=visualstudiosdk-2019&preserve-view=true)
- [TextSelection.FindText(String, Int32)](/dotnet/api/envdte.textselection.findtext?view=visualstudiosdk-2019&preserve-view=true#EnvDTE_TextSelection_FindText_System_String_System_Int32_)
- [TextSelection.FindPattern(String, Int32, TextRanges)](/dotnet/api/envdte.textselection.findpattern?view=visualstudiosdk-2019&preserve-view=true)
- [TextSelection.ReplaceText(String, String, Int32)](/dotnet/api/envdte.textselection.replacetext?view=visualstudiosdk-2019&preserve-view=true)
- [TextSelection.ReplacePattern(String, String, Int32, TextRanges)](/dotnet/api/envdte.textselection.replacepattern?view=visualstudiosdk-2019&preserve-view=true)
- [TextDocument.ReplacePattern(String, String, Int32, TextRanges)](/dotnet/api/envdte.textdocument.replacepattern?view=visualstudiosdk-2019&preserve-view=true)
- [TextDocument.ReplaceText(String, String, Int32)](/dotnet/api/envdte.textdocument.replacetext?view=visualstudiosdk-2019&preserve-view=true)

These APIs will no longer work in VS 2022 and beyond. The guidance is to use [IFinder Interface (Microsoft.VisualStudio.Text.Operations)](/dotnet/api/microsoft.visualstudio.text.operations.ifinder?view=visualstudiosdk-2019&preserve-view=true) instead which has find and replace methods on it. Access to an object implementing the IFinder interface can be gained via the [IFindService.CreateFinderFactory Method](/dotnet/api/microsoft.visualstudio.text.operations.ifindservice.createfinderfactory?view=visualstudiosdk-2019&preserve-view=true). An example of migrating a third-party extension to Visual Studio from the older APIs to the modern IFinder APIs can be found here: [Migrate Code Maid extension from EnvDTE Find and Replace pattern APIs to modern IFinder APIs](https://github.com/codecadwallader/codemaid/pull/847/commits/12e226a2ad6e9a4ccec4c3fda1a19db63eef6efd)
