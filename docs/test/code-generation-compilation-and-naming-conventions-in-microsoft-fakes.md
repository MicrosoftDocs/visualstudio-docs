---
title: Configure Microsoft Fakes code generation
description: Learn about options and issues in Fakes code generation and compilation, including the naming conventions for Fakes-generated types, members, and parameters.
ms.date: 05/23/2023
ms.topic: how-to
ms.author: mikejo
manager: aajohn
ms.subservice: test-tools
author: mikejo5000
---
# Code generation, compilation, and naming conventions in Microsoft Fakes

This article discusses options and issues in Fakes code generation and compilation, and describes the naming conventions for Fakes-generated types, members, and parameters.

**Requirements**

- Visual Studio Enterprise
- A .NET Framework project

- .NET Core, .NET 5.0 or later, and SDK-style project support previewed in Visual Studio 2019 Update 6, and is enabled by default in Update 8. For more information, see [Microsoft Fakes for .NET Core and SDK-style projects](/visualstudio/releases/2019/release-notes#microsoft-fakes-for-net-core-and-sdk-style-projects).

## Code generation and compilation

### Configure code generation of stubs

The generation of stub types is configured in an XML file that has the *.fakes* file extension. The Fakes framework integrates in the build process through custom MSBuild tasks and detects those files at build time. The Fakes code generator compiles the stub types into an assembly and adds the reference to the project.

The following example illustrates stub types defined in *FileSystem.dll*:

```xml
<Fakes xmlns="http://schemas.microsoft.com/fakes/2011/">
    <Assembly Name="FileSystem"/>
</Fakes>
```

### Type filtering

Filters can be set in the *.fakes* file to restrict which types should be stubbed. You can add an unbounded number of Clear, Add, Remove elements under the StubGeneration element to build the list of selected types.

For example, the following *.fakes* file generates stubs for types under the System and System.IO namespaces, but excludes any type containing "Handle" in System:

```xml
<Fakes xmlns="http://schemas.microsoft.com/fakes/2011/">
  <Assembly Name="mscorlib" />
  <!-- user code -->
  <StubGeneration>
    <Clear />
    <Add Namespace="System!" />
    <Add Namespace="System.IO!"/>
    <Remove TypeName="Handle" />
  </StubGeneration>
  <!-- /user code -->
</Fakes>
```

The filter strings use a simple grammar to define how the matching should be done:

- Filters are case-insensitive by default; filters perform a substring matching:

     `el` matches "hello"

- Adding `!` to the end of the filter makes it a precise case-sensitive match:

     `el!` does not match "hello"

     `hello!` matches "hello"

- Adding `*` to the end of the filter makes it match the prefix of the string:

     `el*` does not match "hello"

     `he*` matches "hello"

- Multiple filters in a semicolon-separated list are combined as a disjunction:

     `el;wo` matches "hello" and "world"

### Stub concrete classes and virtual methods

By default, stub types are generated for all non-sealed classes. It is possible to restrict the stub types to abstract classes through the *.fakes* configuration file:

```xml
<Fakes xmlns="http://schemas.microsoft.com/fakes/2011/">
  <Assembly Name="mscorlib" />
  <!-- user code -->
  <StubGeneration>
    <Types>
      <Clear />
      <Add AbstractClasses="true"/>
    </Types>
  </StubGeneration>
  <!-- /user code -->
</Fakes>
```

### Internal types

The Fakes code generator generates shim types and stub types for types that are visible to the generated Fakes assembly. To make internal types of a shimmed assembly visible to Fakes and your test assembly, add  <xref:System.Runtime.CompilerServices.InternalsVisibleToAttribute> attributes to the shimmed assembly code that gives visibility to the generated Fakes assembly and to the test assembly. Here's an example:

```csharp
// FileSystem\AssemblyInfo.cs
[assembly: InternalsVisibleTo("FileSystem.Fakes")]
[assembly: InternalsVisibleTo("FileSystem.Tests")]
```

**Internal types in strongly named assemblies**

If the shimmed assembly is strongly named, and you want to access internal types of the assembly:

- Both your test assembly and the Fakes assembly must be strongly named.

- Add the public keys of the test and Fakes assembly to the **InternalsVisibleToAttribute** attributes in the shimmed assemblies. Here's how the example attributes in the shimmed assembly code would look when the shimmed assembly is strongly named:

    ```csharp
    // FileSystem\AssemblyInfo.cs
    [assembly: InternalsVisibleTo("FileSystem.Fakes",
        PublicKey=<Fakes_assembly_public_key>)]
    [assembly: InternalsVisibleTo("FileSystem.Tests",
        PublicKey=<Test_assembly_public_key>)]
    ```

If the shimmed assembly is strongly named, the Fakes framework automatically strongly signs the generated Fakes assembly. You have to strong sign the test assembly. See [Strong-Named assemblies](/dotnet/framework/app-domains/strong-named-assemblies).

The Fakes framework uses the same key to sign all generated assemblies, so you can use this snippet as a starting point to add the **InternalsVisibleTo** attribute for the fakes assembly to your shimmed assembly code.

```csharp
[assembly: InternalsVisibleTo("FileSystem.Fakes, PublicKey=0024000004800000940000000602000000240000525341310004000001000100e92decb949446f688ab9f6973436c535bf50acd1fd580495aae3f875aa4e4f663ca77908c63b7f0996977cb98fcfdb35e05aa2c842002703cad835473caac5ef14107e3a7fae01120a96558785f48319f66daabc862872b2c53f5ac11fa335c0165e202b4c011334c7bc8f4c4e570cf255190f4e3e2cbc9137ca57cb687947bc")]
```

You can specify a different public key for the Fakes assembly, such as a key you have created for the shimmed assembly, by specifying the full path to the *.snk* file that contains the alternate key as the `KeyFile` attribute value in the `Fakes`\\`Compilation` element of the *.fakes* file. For example:

```xml
<-- FileSystem.Fakes.fakes -->
<Fakes ...>
  <Compilation KeyFile="full_path_to_the_alternate_snk_file" />
</Fakes>
```

You then have to use the public key of the alternate *.snk* file as the second parameter of the InternalVisibleTo attribute for the Fakes assembly in the shimmed assembly code:

```csharp
// FileSystem\AssemblyInfo.cs
[assembly: InternalsVisibleTo("FileSystem.Fakes",
    PublicKey=<Alternate_public_key>)]
[assembly: InternalsVisibleTo("FileSystem.Tests",
    PublicKey=<Test_assembly_public_key>)]
```

In the example above, the values `Alternate_public_key` and the `Test_assembly_public_key` can be the same.

### Optimize build times

The compilation of Fakes assemblies can significantly increase your build time. You can minimize the build time by generating the Fakes assemblies for .NET System assemblies and third-party assemblies in a separate centralized project. Because such assemblies rarely change on your machine, you can reuse the generated Fakes assemblies in other projects.

From your unit test projects, add a reference to the compiled Fakes assemblies that are placed under FakesAssemblies in the project folder.

1. Create a new Class Library with the .NET runtime version matching your test projects. Let's call it Fakes.Prebuild. Remove the *class1.cs* file from the project, not needed.

2. Add reference to all the System and third-party assemblies you need Fakes for.

3. Add a *.fakes* file for each of the assemblies and build.

4. From your test project

    - Make sure that you have a reference to the Fakes runtime DLL:

         *%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\PublicAssemblies\Microsoft.QualityTools.Testing.Fakes.dll*

    - For each assembly that you have created Fakes for, add a reference to the corresponding DLL file in the *Fakes.Prebuild\FakesAssemblies* folder of your project.

### Avoid assembly name clashing

In a Team Build environment, all build outputs are merged into a single directory. If multiple projects use Fakes, it might happen that Fakes assemblies from different versions override each other. For example, TestProject1 fakes *mscorlib.dll* from the .NET Framework 2.0 and TestProject2 fakes *mscorlib.dll* for the .NET Framework 4 would both yield to a *mscorlib.Fakes.dll* Fakes assembly.

To avoid this issue, Fakes should automatically create version qualified Fakes assembly names for non-project references when adding the *.fakes* files. A version-qualified Fakes assembly name embeds a version number when you create the Fakes assembly name:

Given an assembly MyAssembly and a version 1.2.3.4, the Fakes assembly name is MyAssembly.1.2.3.4.Fakes.

You can change or remove this version by the editing the Version attribute of the Assembly element in the *.fakes*:

```xml
attribute of the Assembly element in the .fakes:
<Fakes ...>
  <Assembly Name="MyAssembly" Version="1.2.3.4" />
  ...
</Fakes>
```

## Fakes naming conventions

### Shim type and stub type naming conventions

**Namespaces**

- .Fakes suffix is added to the namespace.

   For example, `System.Fakes` namespace contains the shim types of System namespace.

- Global.Fakes contains the shim type of the empty namespace.

  **Type names**

- Shim prefix is added to the type name to build the shim type name.

   For example, ShimExample is the shim type of the Example type.

- Stub prefix is added to the type name to build the stub type name.

   For example, StubIExample is the stub type of the IExample type.

  **Type Arguments and Nested Type Structures**

- Generic type arguments are copied.

- Nested type structure is copied for shim types.

### Shim delegate property or stub delegate field naming conventions

**Basic rules** for field naming, starting from an empty name:

- The method name is appended.

- If the method name is an explicit interface implementation, the dots are removed.

- If the method is generic, `Of`*n* is appended where *n* is the number of generic method arguments.

  **Special method names** such as property getter or setters are treated as described in the following table:

|If method is...|Example|Method name appended|
|-|-|-|
|A **constructor**|`.ctor`|`Constructor`|
|A static **constructor**|`.cctor`|`StaticConstructor`|
|An **accessor** with method name composed of two parts separated by "_" (such as property getters)|*kind_name* (common case, but not enforced by ECMA)|*NameKind*, where both parts have been capitalized and swapped|
||Getter of property `Prop`|`PropGet`|
||Setter of property `Prop`|`PropSet`|
||Event adder|`Add`|
||Event remover|`Remove`|
|An **operator** composed of two parts|`op_name`|`NameOp`|
|For example: + operator|`op_Add`|`AddOp`|
|For a **conversion operator**, the return type is appended.|`T op_Implicit`|`ImplicitOpT`|

> [!NOTE]
> - **Getters and setters of indexers** are treated similarly to the property. The default name for an indexer is `Item`.
> - **Parameter type** names are transformed and concatenated.
> - **Return type** is ignored unless there's an overload ambiguity. If there's an overload ambiguity, the return type is appended at the end of the name.

### Parameter type naming conventions

|Given|Appended string is...|
|-|-|
|A **type**`T`|T<br /><br /> The namespace, nested structure, and generic tics are dropped.|
|An **out parameter**`out T`|`TOut`|
|A **ref parameter** `ref T`|`TRef`|
|An **array type**`T[]`|`TArray`|
|A **multi-dimensional array** type `T[ , , ]`|`T3`|
|A **pointer** type `T*`|`TPtr`|
|A **generic type**`T<R1, ...>`|`TOfR1`|
|A **generic type argument**`!i` of type `C<TType>`|`Ti`|
|A **generic method argument**`!!i` of method `M<MMethod>`|`Mi`|
|A **nested type**`N.T`|`N` is appended, then `T`|

### Recursive rules

The following rules are applied recursively:

- Because Fakes uses C# to generate the Fakes assemblies, any character that would produce an invalid C# token is escaped to "_" (underscore).

- If a resulting name clashes with any member of the declaring type, a numbering scheme is used by appending a two-digit counter, starting at 01.

## Utilizing Microsoft Fakes in Continuous Integration

### Microsoft Fakes Assembly Generation

Microsoft Fakes is a feature available exclusively in Visual Studio Enterprise. As such, the generation of Fakes Assemblies necessitates the use of the [Visual Studio Build Task](/azure/devops/pipelines/tasks/build/visual-studio-build?view=azure-devops&preserve-view=true) when building your project.

> [!NOTE]
> An alternative strategy involves checking your Fakes Assemblies directly into the Continuous Integration (CI) system and utilizing the [MSBuild Task](../msbuild/msbuild-task.md?view=vs-2019&preserve-view=true). If you opt for this approach, you need to make sure to include an assembly reference to the generated Fakes assembly in your test project, as shown in the following code snippet:

```xml
<Project Sdk="Microsoft.NET.Sdk">
    <ItemGroup>
        <Reference Include="FakesAssemblies\System.Fakes.dll"/>
    </ItemGroup>
</Project>
```

This reference must be added manually, specifically for SDK-style projects (that is, .NET Core, .NET 5+, and .NET Framework), because these projects now implicitly add assembly references. If you decide to use this method, make sure to update the Fakes assembly whenever the parent assembly undergoes changes.

## Related content

- [Isolating code under test with Microsoft Fakes](../test/isolating-code-under-test-with-microsoft-fakes.md)
