# Breaking API changes in Dev17

If you're migrating an extension to Dev17, the breaking changes listed here might affect you.

## Reference assemblies no longer installed

Many of the assemblies you may have been referencing that msbuild resolved from a VS installation directory are no longer installed.
You should use NuGet to acquire the VS SDK ref assemblies you need.
See [Modernize projects](modernize-projects.md) for detailed steps on doing this.

## Removed APIs

In Dev17 a number of APIs have been removed as part of moving Visual Studio forward. A list of the removed APIs can be found on the [Removed API List](removed-api-list.md) page.

## Interop breaking changes

Hundreds of our APIs have changed in Dev17,
usually with simple changes that are straightforward for your code to accommodate.

To manage the breaking changes, we are planning to provide a new
mechanism for the distribution of interop assemblies. Specifically, for
Dev17 and beyond we provide a single interop assembly
with definitions for many common public Visual Studio interface. That
assembly contains managed definitions for many Visual Studio
interfaces moving away from multiple interop assemblies. The new interop
assembly is be distributed via the `Microsoft.VisualStudio.Interop` NuGet package.

However, Visual Studio components that are primarily used in native
contexts and have a low number of breaking changes will continue to have
their own interop assemblies (e.g., the debugger will still
VisualStudio.Debugger.Interop.dll as it does today). In any case the
assemblies can be then referenced from your application, just as they
are today.

This is a significant change and means that extensions that use APIs in
and assembly built in this new approach are not compatible with older
versions of Visual Studio using the previous interop assembly.

This has a few very important advantages that will make migrating your
extension over to Dev17 easier:

1. Any broken APIs will become build time errors making them easier to find and fix.
1. You only need to update code that uses an API that was broken in Dev17.
1. You will not be able to accidentally use the old, now broken API.

Overall, these changes will result in a more stable version of Visual
Studio for all users. The major drawback of this approach is that your
managed assemblies will not be able to run in both Dev16 and Dev17
without compiling your code once for each target VS version.

As you work through compile errors due to the API differences between Dev16 and Dev17,
you may find the API or pattern you're facing listed below with guidance
on how to fix it.

### `int` or `uint` where `IntPtr` is expected

We expect this will be a very common error.
To make Dev17 a 64-bit process, some of our interop APIs had to be fixed
where they assumed a pointer could fit in a 32-bit integer to actually use a pointer-sized value.

Sample error:

> Argument 3: cannot convert from 'out uint' to 'out System.IntPtr'

Simply update your code to expect or provide `IntPtr` or `UIntPtr` where `int` or `uint` used to be to resolve the break.

Sample fix:

```diff
-shell.LoadLibrary(myGuid, myFlags, out uint ptrLib);
+shell.LoadLibrary(myGuid, myFlags, out IntPtr ptrLib);
```

### An interop type defined in two assemblies

When C# complains that a type you're using is defined in two assemblies,
you probably are referencing an assembly from the Dev16 era that you should no longer reference.

Sample error:

> error CS0433: The type 'IVsDpiAware' exists in both 'Microsoft.VisualStudio.Interop, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' and 'Microsoft.VisualStudio.Shell.Interop.16.0.DesignTime, Version=16.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'

Refer to our [reference assembly remapping table](migrated-pia.md) to see which assembly name
is the preferred name in Dev17.
Considering the two assemblies named in the sample error above and looking at this table,
we see that `Microsoft.VisualStudio.Interop` is the new assembly name.
The fix then would be to remove our reference to `Microsoft.VisualStudio.Shell.Interop.16.0.DesignTime` from the project.

In some cases we offer a Dev17-versioned package for the deprecated assembly that contains type forwarders.
When this is available, you have the option to *upgrade* your package reference
to the Dev17 version instead of removing it.
The type forwarders will resolve the error from the compiler.

Keep in mind that sometimes these references can come by transitive package reference,
and thus can be harder to remove than a direct reference made in your project file.
In such cases, make sure all your direct package references all are using Dev17 SDK packages themselves.
You may refer to project.assets.json to identify the chain of packages responsible for bringing in the deprecated assembly.
Updating a transitive package reference to a Dev17 version is as easy as installing it as a direct reference.

If you cannot change the dependency tree (e.g. it involves a 3rd party dependency),
you can add a direct package reference to the pre-Dev17 package and add `ExcludeAssets="compile"` metadata to that `PackageReference` item to solve the compiler break.
But keep in mind that with this technique your extension may retain a dependency on a pre-Dev17 assembly and your extension may malfunction at runtime.

### Missing reference to an interop assembly

When you reference an assembly that compiled against the pre-Dev17 SDK,
you may get an error about missing an assembly reference.

Sample error:

> Error CS0012 The type 'IVsTextViewFilter' is defined in an assembly that is not referenced. You must add a reference to assembly 'Microsoft.VisualStudio.TextManager.Interop, Version=7.1.40304.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'

Using the [reference assembly remapping table](migrated-pia.md), you can confirm that
the requested assembly is in fact not one you should have to reference.

The best fix is to update your dependency to a version that compiled against the Dev17 SDK
so the removed interop assembly is no longer requested by the compiler.

In some cases we offer a Dev17-versioned package for the deprecated assembly that contains type forwarders.
When this is available, you have the option to add a package reference
to the Dev17 version of the obsolete package so the type forwarders
will resolve the error from the compiler.

### `IAsyncServiceProvider` is missing

There are two definitions of this interface, in two namespaces.
Only one of these was intended for managed consumption.

Dev16 Namespace | Dev17 Namespace | Intended use
--|--|--
Microsoft.VisualStudio.Shell.IAsyncServiceProvider | Microsoft.VisualStudio.Shell.IAsyncServiceProvider | Managed code consumption
Microsoft.VisualStudio.Shell.Interop.IAsyncServiceProvider | Microsoft.VisualStudio.Shell.COMAsyncServiceProvider.IAsyncServiceProvider | low-level interop only

If you see an error about `IAsyncServiceProvider`, it *may* be that you were using the one intended for native code (the second row).
If so, you can update to the new namespace, or switch to the more managed-friendly interface.

### `DTE` and `_DTE` type cast failures

`DTE` and `_DTE` are both interfaces. One derives from the other.
However in Dev17, the base and derived types are swapped.
This makes certain type assignments or casts fail.

This also means where you used to use `new DTE()`,
you must now use `new _DTE()`.

### Missing argument on a method invocation

A few methods no longer declare default arguments for what were optional parameters
in the interop API.
If you get an error about a missing argument for a COM interop call,
and the parameter calls for an `object` type, the previous default value that the
Dev16 interop API defined may have been `""`, so consider adding `""` as your argument
to resolve the compile error.

When in doubt about what the default argument used to be, try switching
your language service context from Dev17 to Dev16 so you get Intellisense with the older
interops to see what the default argument was, and then add it explicitly to your code.
It will continue to work fine when compiled for Dev16, but will now compile for Dev17.

Sample fix:

```diff
-process4.Attach2();
+process4.Attach2("");
```
