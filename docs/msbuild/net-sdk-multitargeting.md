---
title: .NET SDK Multitargeting Overview
description: Use MSBuild to compile an application to run on any one of several versions of .NET.
ms.date: 1/9/2025
ms.topic: how-to
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Targeting multiple .NET versions in a build

Targeting multiple .NET frameworks in a build allows you to ensure that your application or library is available for different versions or editions of .NET.

Multitargeting for .NET Core and .NET 5 and later projects is significantly different from and more advanced than multitargeting for .NET Framework projects. See [Comparison between .NET Framework and .NET Core multitargeting](#comparison-between-net-framework-and-net-core-multitargeting).

## Set up .NET multitargeting

1. Create a new .NET Standard class library either in Visual Studio or using the `dotnet new classlib` command.

2. Edit the project file. Edit the `.csproj` file to support multiple target frameworks. Change the `<TargetFramework>` element to `<TargetFrameworks>` and list the frameworks you want to target.

   ```xml
   <Project Sdk="Microsoft.NET.Sdk">
   <PropertyGroup>
       <TargetFrameworks>netstandard2.0;net45;netcoreapp3.1;net5.0</TargetFrameworks>
   </PropertyGroup>
   </Project>
   ```

3. Use conditional compilation symbols to separate code that is specific to a particular version.

    ```csharp
    public string GetFramework()
    {
    #if NET45
        return ".NET Framework 4.5";
    #elif NETSTANDARD2_0
        return ".NET Standard 2.0";
    #elif NETCOREAPP3_1
        return ".NET Core 3.1";
    #elif NET5_0
        return ".NET 5.0";
    #else
        return "Unknown Framework";
    #endif
    }
    ```

4. Build and pack. Use the `dotnet pack` or `MSBuild.exe /t:pack` command to create the package. This will generate a `.nupkg` file that targets all specified frameworks.

   ```sh
   MSBuild.exe /t:pack MyProject.csproj
   ```

## Handle dependencies

When targeting multiple framework versions, you might need to handle dependencies differently for each version. Use conditional `ItemGroup` elements in your project file to specify framework-specific dependencies.

```xml
<ItemGroup Condition="'$(TargetFramework)' == 'net45'">
<PackageReference Include="SomePackage" Version="1.0.0" />
</ItemGroup>
<ItemGroup Condition="'$(TargetFramework)' == 'netstandard2.0'">
<PackageReference Include="SomeOtherPackage" Version="2.0.0" />
</ItemGroup>
```

Handling version-specific dependencies in a .NET project involves using conditional `PackageReference` elements in your project file. This allows you to specify different versions of a package for different target frameworks. Here's how you can do it:

### Add version-specific dependencies

1. **Edit the Project File**: Open your `.csproj` file and add conditional `PackageReference` elements inside an `ItemGroup` element. This way, you can specify different versions of a package based on the target framework.

   ```xml
    <Project Sdk="Microsoft.NET.Sdk">
    <PropertyGroup>
        <TargetFrameworks>net45;netstandard2.0;netcoreapp3.1;net5.0</TargetFrameworks>
    </PropertyGroup>
    <ItemGroup Condition="'$(TargetFramework)' == 'net45'">
        <PackageReference Include="SomePackage" Version="1.0.0" />
    </ItemGroup>
    <ItemGroup Condition="'$(TargetFramework)' == 'netstandard2.0'">
        <PackageReference Include="SomePackage" Version="2.0.0" />
    </ItemGroup>
    <ItemGroup Condition="'$(TargetFramework)' == 'netcoreapp3.1'">
        <PackageReference Include="SomePackage" Version="3.0.0" />
    </ItemGroup>
    <ItemGroup Condition="'$(TargetFramework)' == 'net5.0'">
        <PackageReference Include="SomePackage" Version="4.0.0" />
    </ItemGroup>
    </Project>
   ```

2. **Use the CLI**: You can also add dependencies using the .NET CLI. For example, to add a dependency for a specific target framework, you can use the following command:

   ```sh
    dotnet add package SomePackage --version 1.0.0 --framework net45
   ```

### Manage transitive dependencies

Transitive dependencies are dependencies of your dependencies. It's important to review and manage these to avoid conflicts and ensure compatibility. You can use the `dotnet list package` command to see all the dependencies and their versions.

```sh
dotnet list package
```

### Handle diamond dependencies

Diamond dependencies occur when multiple versions of a package are present in the dependency tree. NuGet resolves these by selecting the lowest applicable version. To avoid issues, you can specify version ranges or use binding redirects in .NET Framework projects.

```xml
<PackageReference Include="ExamplePackage" Version="[1.0,2.0)" />
```

By following these practices, you can effectively manage version-specific dependencies in your .NET projects, ensuring compatibility and stability across different target frameworks. See [Manage package dependencies in .NET applications](/dotnet/core/tools/dependencies), [Dependencies](/dotnet/standard/library-guidance/dependencies), and [How NuGet resolves package dependencies](/nuget/concepts/dependency-resolution).

## Specify runtime identifiers

A runtime identifier (RID) specifies a target runtime environment, which consists of a unique combination of operating system and CPU. Runtime identifiers affect the architecture-dependent NuGet packages that are used. Runtime identifiers consist of a shorthand code, for example, `linux-x64`. For more information and a list of RID codes for each supported operating system and CPU, see [.NET RID catalog](/dotnet/core/rid-catalog).

RIDs are specified using the `<RuntimeIdentifier>` property in the project file. You can also use the plural form `<RuntimeIdentifiers>` to specify multiple target architectures.

For .NET Core projects, target frameworks and target runtimes specified as RIDs act separately, and may be used in any supported combination, including multiple RIDs and multiple target frameworks. For a .NET Framework target, you can only specify a single RID.

The RID affects the NuGet packages your application binaries depend on, but the binary itself only depends on the target framework. Therefore, although separate output folders are created for each different target framework (for example, `bin\Debug\netstandard2.0` and `bin\Debug\net8.0`), they are not created for each RID.

## Comparison Between .NET Framework and .NET Core Multitargeting

Multitargeting for .NET Core (and .NET 5 and later) is very different and more powerful than [multitargeting for .NET Framework projects](msbuild-multitargeting-overview.md).

### .NET Framework
- **Limited Multitargeting**: .NET Framework supports multitargeting, but it is more limited compared to .NET Core. It can target different versions of the .NET Framework, but not multiple frameworks simultaneously. See [MSBuild multitargeting](msbuild-multitargeting-overview.md).
- **Older Toolset**: Uses an older type of multitargeting with MSBuild, where a project can target only one framework and one platform at a time.

### .NET Core
- **Advanced Multitargeting**: .NET Core supports advanced multitargeting, allowing you to target multiple frameworks simultaneously using the `<TargetFrameworks>` property in the project file. See [Target frameworks](/dotnet/targetframeworks).
- **Modern Toolset**: Uses a newer type of multitargeting with MSBuild, where multiple builds occur for each target framework listed.

## Related content

- [Specify the targeted .NET Frameworks - Visual Studio](../ide/visual-studio-multi-targeting-overview.md)

[!INCLUDE[AI generated](../includes/ai-generated-attribution.md)]