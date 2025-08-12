---
title: GenerateApplicationManifest Task
description: Use the MSBuild GenerateApplicationManifest task to generates a ClickOnce application manifest or a native manifest.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#GenerateApplicationManifest
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- MSBuild, GenerateApplicationManifest task
- HostInBrowser property (MSBuild)
- GenerateApplicationManifest task [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# GenerateApplicationManifest task

Generates a ClickOnce application manifest or a native manifest. A native manifest describes a component by defining a unique identity for the component and identifying all assemblies and files that make up the component. A ClickOnce application manifest extends a native manifest by indicating the entry point of the application, and specifying the application security level.

## Parameters

The following table describes the parameters for the `GenerateApplicationManifest` task.

| Parameter | Description |
|---------------------------------| - |
| `AssemblyName` | Optional `String` parameter.<br /><br /> Specifies the `Name` field of the assembly identity for the generated manifest. If this parameter is not specified, the name is inferred from the `EntryPoint` or `InputManifest` parameters. If no name can be created, the task throws an error. |
| `AssemblyVersion` | Optional `String` parameter.<br /><br /> Specifies the `Version` field of the assembly identity for the generated manifest. If this parameter is not specified, a default value of "1.0.0.0" is used. |
| `ClrVersion` | Optional `String` parameter.<br /><br /> Specifies the minimum version of the Common Language Runtime (CLR) required by the application. The default value is the CLR version in use by the build system. If the task is generating a native manifest, this parameter is ignored. |
| `ConfigFile` | Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies which item contains the application configuration file. If the task is generating a native manifest, this parameter is ignored. |
| `Dependencies` | Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies an item list that defines the set of dependent assemblies for the generated manifest. Each item may be further described by item metadata to indicate additional deployment state and the type of dependence. For more information, see [Item metadata](#item-metadata). |
| `Description` | Optional `String` parameter.<br /><br /> Specifies the description for the application or component. |
| `EntryPoint` | Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies a single item that indicates the entry point for the generated manifest assembly.<br /><br /> For a ClickOnce application manifest, this parameter specifies the assembly that starts when the application is run. |
| `ErrorReportUrl` | Optional <xref:System.String?displayProperty=fullName> parameter.<br /><br /> Specifies the URL of the web page that is displayed in dialog boxes during error reports in ClickOnce installations. |
| `FileAssociations` | Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies a list of one or more file type that are associated with the ClickOnce deployment manifest.<br /><br /> File associations only valid only when .NET Framework 3.5 or later is targeted. |
| `Files` | Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> The files to include in the manifest. Specify the full path for each file. |
| `HostInBrowser` | Optional <xref:System.Boolean> parameter.<br /><br /> If `true`, the application is hosted in a browser (as are WPF Web Browser Applications). |
| `IconFile` | Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Indicates the application icon file. The application icon is expressed in the generated application manifest and is used for the **Start Menu** and **Add/Remove Programs** dialog. If this input is not specified, a default icon is used. If the task is generating a native manifest, this parameter is ignored. |
| `InputManifest` | Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Indicates an input XML document to serve as a base for the manifest generator. This allows structured data such as application security or custom manifest definitions to be reflected in the output manifest. The root element in the XML document must be an assembly node in the asmv1 namespace. |
| `IsolatedComReferences` | Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br /> Specifies COM components to isolate in the generated manifest. This parameter supports the ability to isolate COM components for "Registration Free COM" deployment. It works by auto-generating a manifest with standard COM registration definitions. However, the COM components must be registered on the build machine in order for this to function properly. |
| `LauncherBasedDeployment` | Optional Boolean parameter.<br /><br /> Set this to `True` when building for .NET Core 3.1, .NET 5 and later versions to ensure that the application executable is renamed to the expected executable name after building the application host executable *apphost.exe*. |
| `ManifestType` | Optional `String` parameter.<br /><br /> Specifies which type of manifest to generate. This parameter can have the following values:<br /><br /> -   `Native`<br />-   `ClickOnce`<br /><br /> If this parameter is not specified, the task defaults to `ClickOnce`. |
| `MaxTargetPath` | Optional `String` parameter.<br /><br /> Specifies the maximum allowable length of a file path in a ClickOnce application deployment. If this value is specified, the length of each file path in the application is checked against this limit. Any items that exceed the limit will raise in a build warning. If this input is not specified or is zero, then no checking is performed. If the task is generating a native manifest, this parameter is ignored. |
| `OSVersion` | Optional `String` parameter.<br /><br /> Specifies the minimum required operating system (OS) version required by the application. If this parameter is not specified, the value "4.10.0.0" is used, the minimum supported OS of the .NET Framework. If the task is generating a native manifest, this input is ignored. |
| `OutputManifest` | Optional <xref:Microsoft.Build.Framework.ITaskItem> output parameter.<br /><br /> Specifies the name of the generated output manifest file. If this parameter is not specified, the name of the output file is inferred from the identity of the generated manifest. |
| `Platform` | Optional `String` parameter.<br /><br /> Specifies the target platform of the application. This parameter can have the following values:<br /><br /> -   `AnyCPU`<br />-   `x86`<br />-   `x64`<br />-   `Itanium`<br /><br /> If this parameter is not specified, the task defaults to `AnyCPU`. |
| `Product` | Optional `String` parameter.<br /><br /> Specifies the name of the application. If this parameter is not specified, the name is inferred from the identity of the generated manifest. This name is used for the shortcut name on the **Start** menu and is part of the name that appears in the **Add or Remove Programs** dialog box. |
| `Publisher` | Optional `String` parameter.<br /><br /> Specifies the publisher of the application. If this parameter is not specified, the name is inferred from the registered user, or the identity of the generated manifest. This name is used for the folder name on the **Start** menu and is part of the name that appears in the **Add or Remove Programs** dialog box. |
| `RequiresMinimumFramework35SP1` | Optional `Boolean` parameter.<br /><br /> If true, the application requires the .NET Framework 3.5 SP1 or a more recent version. |
| `TargetCulture` | Optional `String` parameter.<br /><br /> Identifies the culture of the application and specifies the `Language` field of the assembly identity for the generated manifest. If this parameter is not specified, it is assumed the application is culture invariant. |
| `TargetFrameworkMoniker` | Optional `String` parameter.<br /><br /> Specifies the target framework moniker. |
| `TargetFrameworkProfile` | Optional `String` parameter.<br /><br /> Specifies the target framework profile. |
| `TargetFrameworkSubset` | Optional `String` parameter.<br /><br /> Specifies the name of the .NET Framework subset to target. |
| `TargetFrameworkVersion` | Optional `String` parameter.<br /><br /> Specifies the target .NET Framework of the project. |
| `TrustInfoFile` | Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Indicates an XML document that specifies the application security. The root element in the XML document must be a trustInfo node in the asmv2 namespace. If the task is generating a native manifest, this parameter is ignored. |
| `UseApplicationTrust` | Optional `Boolean` parameter.<br /><br /> If true, the `Product`, `Publisher`, and `SupportUrl` properties are written to the application manifest. |

## Remarks

In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.GenerateManifestBase> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of the parameters of the Task class, see [Task base class](../msbuild/task-base-class.md).

For information about how to use the `GenerateDeploymentManifest` task, see [GenerateApplicationManifest task](../msbuild/generateapplicationmanifest-task.md).

The inputs for dependencies and files may be further decorated with item metadata to specify additional deployment state for each item.

## Item metadata

|Metadata name|Description|
|-------------------|-----------------|
|`DependencyType`|Indicates whether the dependency is published and installed with the application or a prerequisite. This metadata is valid for all dependencies, but is not used for files. The available values for this metadata are:<br /><br /> -   `Install`<br />-   `Prerequisite`<br /><br /> Install is the default value.|
|`AssemblyType`|Indicates whether the dependency is a managed or a native assembly. This metadata is valid for all dependencies, but is not used for files. The available values for this metadata are:<br /><br /> -   `Managed`<br />-   `Native`<br />-   `Unspecified`<br /><br /> `Unspecified` is the default value, which indicates that the manifest generator will determine the assembly type automatically.|
|`Group`|Indicates the group for downloading additional files on-demand. The group name is defined by the application and can be any string. An empty string indicates the file is not part of a download group, which is the default. Files not in a group are part of the initial application download. Files in a group are only downloaded when explicitly requested by the application using <xref:System.Deployment.Application>.<br /><br /> This metadata is valid for all files where `IsDataFile` is `false` and all dependencies where `DependencyType` is `Install`.|
|`TargetPath`|Specifies how the path should be defined in the generated manifest. This attribute is valid for all files. If this attribute is not specified, the item specification is used. This attribute is valid for all files and dependencies with a `DependencyType` value of `Install`.|
|`IsDataFile`|A `Boolean` metadata value that indicates whether or not the file is a data file. A data file is special in that it is migrated between application updates. This metadata is only valid for files. `False` is the default value.|

## Example 1

This example uses the `GenerateApplicationManifest` task to generate a ClickOnce application manifest and the `GenerateDeploymentManifest` task to generate a deployment manifest for an application with a single assembly. It then uses the `SignFile` task to sign the manifests.

This illustrates the simplest possible manifest generation scenario where ClickOnce manifests are generated for a single program. A default name and identity are inferred from the assembly for the manifest.

> [!NOTE]
> In the example below, all application binaries are pre-built in order to focus on manifest generation aspects. This example produces a fully working ClickOnce deployment.
>
> [!NOTE]
> For more information on the `Thumbprint` property used in the `SignFile` task in this example, see [SignFile task](../msbuild/signfile-task.md).

```xml
<Project DefaultTargets="Build">

    <ItemGroup>
        <EntryPoint Include="SimpleWinApp.exe" />
    </ItemGroup>

    <PropertyGroup>
        <Thumbprint>
             <!-- Insert generated thumbprint here -->
        </Thumbprint>
    </PropertyGroup>

    <Target Name="Build">

        <GenerateApplicationManifest
            EntryPoint="@(EntryPoint)">
            <Output
                ItemName="ApplicationManifest"
                TaskParameter="OutputManifest"/>
        </GenerateApplicationManifest>

        <GenerateDeploymentManifest
            EntryPoint="@(ApplicationManifest)">
            <Output
                ItemName="DeployManifest"
                TaskParameter="OutputManifest"/>
        </GenerateDeploymentManifest>

        <SignFile
            CertificateThumbprint="$(Thumbprint)"
            SigningTarget="@(ApplicationManifest)"/>

        <SignFile
            CertificateThumbprint="$(Thumbprint)"
            SigningTarget="@(DeployManifest)"/>

    </Target>
</Project>
```

## Example 2

This example uses the `GenerateApplicationManifest` and `GenerateDeploymentManifest` tasks to generate ClickOnce application and deployment manifests for an application with a single assembly, specifying name and identity of manifests.

This example is similar to previous example except the name and identity of the manifests are explicitly specified. Also, this example is configured as an online application instead of an installed application.

> [!NOTE]
> In the example below, all application binaries are pre-built in order to focus on manifest generation aspects. This example produces a fully working ClickOnce deployment.
>
> [!NOTE]
> For more information on the `Thumbprint` property used in the `SignFile` task in this example, see [SignFile task](../msbuild/signfile-task.md).

```xml
<Project DefaultTargets="Build">

    <ItemGroup>
        <EntryPoint Include="SimpleWinApp.exe" />
    </ItemGroup>

    <PropertyGroup>
        <Thumbprint>
             <!-- Insert generated thumbprint here -->
        </Thumbprint>
    </PropertyGroup>

    <Target Name="Build">

        <GenerateApplicationManifest
            AssemblyName="SimpleWinApp.exe"
            AssemblyVersion="1.0.0.0"
            EntryPoint="@(EntryPoint)"
            OutputManifest="SimpleWinApp.exe.manifest">
            <Output
                ItemName="ApplicationManifest"
                TaskParameter="OutputManifest"/>
        </GenerateApplicationManifest>

        <GenerateDeploymentManifest
                AssemblyName="SimpleWinApp.application"
                AssemblyVersion="1.0.0.0"
                EntryPoint="@(ApplicationManifest)"
                Install="false"
                OutputManifest="SimpleWinApp.application">
                <Output
                    ItemName="DeployManifest"
                    TaskParameter="OutputManifest"/>
        </GenerateDeploymentManifest>

        <SignFile
            CertificateThumbprint="$(Thumbprint)"
            SigningTarget="@(ApplicationManifest)"/>

        <SignFile
            CertificateThumbprint="$(Thumbprint)"
            SigningTarget="@(DeployManifest)"/>

    </Target>
</Project>
```

## Example 3

This example uses the `GenerateApplicationManifest` and `GenerateDeploymentManifest` tasks to generate ClickOnce application and deployment manifests for an application with multiple files and assemblies.

> [!NOTE]
> In the example below, all application binaries are pre-built in order to focus on manifest generation aspects. This example produces a fully working ClickOnce deployment.
>
> [!NOTE]
> For more information on the `Thumbprint` property used in the `SignFile` task in this example, see [SignFile task](../msbuild/signfile-task.md).

```xml
<Project DefaultTargets="Build">

    <ItemGroup>
        <EntryPoint Include="SimpleWinApp.exe" />
    </ItemGroup>

    <PropertyGroup>
        <Thumbprint>
             <!-- Insert generated thumbprint here -->
        </Thumbprint>
        <DeployUrl>
            <!-- Insert the deployment URL here -->
        </DeployUrl>
        <SupportUrl>
            <!-- Insert the support URL here -->
        </SupportUrl>
    </PropertyGroup>

    <Target Name="Build">

    <ItemGroup>
        <EntryPoint Include="SimpleWinApp.exe"/>
        <Dependency Include="ClassLibrary1.dll">
            <AssemblyType>Managed</AssemblyType>
            <DependencyType>Install</DependencyType>
        </Dependency>
        <Dependency Include="ClassLibrary2.dll">
            <AssemblyType>Managed</AssemblyType>
            <DependencyType>Install</DependencyType>
            <Group>Secondary</Group>
        </Dependency>
        <Dependency Include="MyAddIn1.dll">
            <AssemblyType>Managed</AssemblyType>
            <DependencyType>Install</DependencyType>
            <TargetPath>Addins\MyAddIn1.dll</TargetPath>
        </Dependency>
        <Dependency Include="ClassLibrary3.dll">
            <AssemblyType>Managed</AssemblyType>
            <DependencyType>Prerequisite</DependencyType>
        </Dependency>

        <File Include="Text1.txt">
            <TargetPath>Text\Text1.txt</TargetPath>
            <Group>Text</Group>
        </File>
        <File Include="DataFile1.xml ">
            <TargetPath>Data\DataFile1.xml</TargetPath>
            <IsDataFile>true</IsDataFile>
        </File>

        <IconFile Include="Heart.ico"/>
        <ConfigFile Include="app.config">
            <TargetPath>SimpleWinApp.exe.config</TargetPath>
        </ConfigFile>
        <BaseManifest Include="app.manifest"/>
    </ItemGroup>

    <Target Name="Build">

        <GenerateApplicationManifest
            AssemblyName="SimpleWinApp.exe"
            AssemblyVersion="1.0.0.0"
            ConfigFile="@(ConfigFile)"
            Dependencies="@(Dependency)"
            Description="TestApp"
            EntryPoint="@(EntryPoint)"
            Files="@(File)"
            IconFile="@(IconFile)"
            InputManifest="@(BaseManifest)"
            OutputManifest="SimpleWinApp.exe.manifest">
            <Output
                ItemName="ApplicationManifest"
                TaskParameter="OutputManifest"/>
        </GenerateApplicationManifest>

        <GenerateDeploymentManifest
            AssemblyName="SimpleWinApp.application"
            AssemblyVersion="1.0.0.0"
            DeploymentUrl="$(DeployToUrl)"
            Description="TestDeploy"
            EntryPoint="@(ApplicationManifest)"
            Install="true"
            OutputManifest="SimpleWinApp.application"
            Product="SimpleWinApp"
            Publisher="Microsoft"
            SupportUrl="$(SupportUrl)"
            UpdateEnabled="true"
            UpdateInterval="3"
            UpdateMode="Background"
            UpdateUnit="weeks">
            <Output
                ItemName="DeployManifest"
                TaskParameter="OutputManifest"/>
        </GenerateDeploymentManifest>

        <SignFile
            CertificateThumbprint="$(Thumbprint)"
            SigningTarget="@(ApplicationManifest)"/>

        <SignFile
            CertificateThumbprint="$(Thumbprint)"
            SigningTarget="@(DeployManifest)"/>

    </Target>
</Project>
```

## Example 4

This example uses the `GenerateApplicationManifest` task to generate a native manifest for application *Test.exe*, referencing native component *Alpha.dll* and an isolated COM component *Bravo.dll*.

This example produces the *Test.exe.manifest*, making the application XCOPY deployable and taking advantage of Registration Free COM.

> [!NOTE]
> In the example below, all application binaries are pre-built in order to focus on manifest generation aspects. This example produces a fully working ClickOnce deployment.

```xml
<Project DefaultTargets="Build">

    <ItemGroup>
        <File Include="Test.exe" />
        <Dependency Include="Alpha.dll">
            <AssemblyType>Native</AssemblyType>
            <DependencyType>Install</DependencyType>
        </Dependency>
        <ComComponent Include="Bravo.dll" />
    </ItemGroup>

    <Target Name="Build">
        <GenerateApplicationManifest
            AssemblyName="Test.exe"
            AssemblyVersion="1.0.0.0"
            Dependencies="@(Dependency)"
            Files="@(File)"
            IsolatedComReferences="@(ComComponent)"
            ManifestType="Native">
            <Output
                ItemName="ApplicationManifest"
                TaskParameter="OutputManifest"/>
        </GenerateApplicationManifest>

    </Target>
</Project>
```

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [GenerateDeploymentManifest task](../msbuild/generatedeploymentmanifest-task.md)
- [SignFile task](../msbuild/signfile-task.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
