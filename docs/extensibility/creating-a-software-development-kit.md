---
title: Creating a Software Development Kit
description: Explore the general infrastructure of software development kits (SDKs) and how to create a platform SDK and an extension SDK in Visual Studio.
ms.date: 08/31/2021
ms.topic: how-to
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Create a software development kit

A software development kit (SDK) is a collection of APIs that you can reference as a single item in Visual Studio. The **Reference Manager** dialog box lists all the SDKs that are relevant to the project. When you add an SDK to a project, the APIs are available in Visual Studio.

There are two types of SDKs:

- Platform SDKs are mandatory components for developing apps for a platform. For example, the Windows 8.1 SDK is required to develop Windows 8.x Store apps.

- Extension SDKs are optional components that extend a platform but aren't mandatory for developing apps for that platform.

The following sections describe the general infrastructure of SDKs and how to create a platform SDK and an extension SDK.

## Platform SDKs

Platform SDKs are required to develop apps for a platform. For example, the Windows 8.1 SDK is required to develop apps for Windows 8.1.

### Installation

All platform SDKs will be installed at *HKLM\Software\Microsoft\Microsoft SDKs\\[TPI]\v[TPV]\\@InstallationFolder = [SDK root]*. Accordingly, the Windows 8.1 SDK is installed at *HKLM\Software\Microsoft\Microsoft SDKs\Windows\v8.1*.

### Layout

Platform SDKs have the following layout:

```
\[InstallationFolder root]
            SDKManifest.xml
            \References
                  \[config]
                        \[arch]
            \DesignTime
                  \[config]
                        \[arch]
```

| Node | Description |
|------------------------| - |
| *References* folder | Contains binaries that contain APIs that can be coded against. These could include Windows Metadata (WinMD) files or assemblies. |
| *DesignTime* folder | Contains files that are needed only at pre-run/debugging time. These could include XML docs, libraries, headers, Toolbox design-time binaries, MSBuild artifacts, and so forth<br /><br /> XML docs would, ideally, be placed in the *\DesignTime* folder, but XML docs for references will continue to be placed alongside the reference file in Visual Studio. For example, the XML doc for a reference<em>\References\\[config]\\[arch]\sample.dll</em> will be *\References\\[config]\\[arch]\sample.xml*, and the localized version of that doc will be *\References\\[config]\\[arch]\\[locale]\sample.xml*. |
| *Configuration* folder | There can be only three folders: *Debug*, *Retail* and *CommonConfiguration*. SDK authors can place their files under *CommonConfiguration* if the same set of SDK files should be consumed, regardless of the configuration that the SDK consumer will target. |
| *Architecture* folder | Any supported *architecture* folder can exist. Visual Studio supports the following architectures: x86, x64, ARM, and neutral. Note: Win32 maps to x86, and AnyCPU maps to neutral.<br /><br /> MSBuild looks only under *\CommonConfiguration\neutral* for Platform SDKs. |
| *SDKManifest.xml* | This file describes how Visual Studio should consume the SDK. Look at the SDK Manifest for Windows 8.1:<br /><br /> `<FileList             DisplayName = "Windows"             PlatformIdentity = "Windows, version=8.1"             TargetFramework = ".NET for Windows Store apps, version=v4.5.1; .NET Framework, version=v4.5.1"             MinVSVersion = "14.0">              <File Reference = "Windows.winmd">                <ToolboxItems VSCategory = "Toolbox.Default" />             </File> </FileList>`<br /><br /> **DisplayName:** The value that the Object Browser displays in the Browse list.<br /><br /> **PlatformIdentity:** The existence of this attribute tells Visual Studio and MSBuild that the SDK is a platform SDK and that the references added from it shouldn't be copied locally.<br /><br /> **TargetFramework:** This attribute is used by Visual Studio to ensure that only projects that target the same Frameworks as specified in the value of this attribute can consume the SDK.<br /><br /> **MinVSVersion:** This attribute is used by Visual Studio to consume only the SDKs that apply to it.<br /><br /> **Reference:** This attribute must be specified for only those references that contain controls. For information about how to specify whether a reference contains controls, see below. |

## Extension SDKs

The following sections describe what you need to do to deploy an extension SDK.

### Installation

Extension SDKs can be installed for a specific user or for all users without specifying a registry key. To install an SDK for all users, use the following path:

*%Program Files%\Microsoft SDKs\<target platform\>\v<platform version number\>\ExtensionSDKs*

For a user-specific installation, use the following path:

*%USERPROFILE%\AppData\Local\Microsoft SDKs\<target platform\>\v<platform version number\>\ExtensionSDKs*

If you want to use a different location, you must do one of two things:

1. Specify it in a registry key:

     **HKLM\Software\Microsoft\Microsoft SDKs\<target platform>\v<platform version number\>\ExtensionSDKs\<SDKName>\<SDKVersion>**\

     and add a (Default) subkey that has a value of `<path to SDK><SDKName><SDKVersion>`.

2. Add the MSBuild property `SDKReferenceDirectoryRoot` to your project file. The value of this property is a semicolon delimited list of directories in which the Extension SDKs you want to reference reside.

### Installation layout

Extension SDKs have the following installation layout:

```
\<ExtensionSDKs root>
           \<SDKName>
                 \<SDKVersion>
                        SDKManifest.xml
                        \References
                              \<config>
                                    \<arch>
                        \Redist
                              \<config>
                                    \<arch>
                        \DesignTime
                               \<config>
                                     \<arch>

```

1. \\<SDKName\>\\<SDKVersion\>: the name and version of the extension SDK is derived from the corresponding folder names in the path to the SDK root. MSBuild uses this identity to find the SDK on disk, and Visual Studio displays this identity in the **Properties** window and **Reference Manager** dialog.

2. *References* folder: the binaries that contain the APIs. These could be Windows Metadata (WinMD) files or assemblies.

3. *Redist* folder: the files that are needed for runtime/debugging and should get packaged as part of the user's application. All binaries should be placed underneath *\redist\\<config\>\\<arch\>*, and the binary names should have the following format to ensure uniqueness: *]*\<company>.\<product>.\<purpose>.\<extension><em>. For example, *Microsoft.Cpp.Build.dll</em>. All files with names that may collide with file names from other SDKs (for example, javascript, css, pri, xaml, png, and jpg files) should be placed underneath <em>\redist\\<config\>\\<arch\>\\<sdkname\>\* except for the files that are associated with XAML controls. These files should be placed underneath *\redist\\<config\>\\<arch\>\\<componentname\>\\</em>.

4. *DesignTime* folder: the files that are needed at only pre-run/debugging time and shouldn't be packaged as part of the user's application. These could be XML docs, libraries, headers, toolbox design-time binaries, MSBuild artifacts, and so forth. Any SDK that is intended for consumption by a native project must have an *SDKName.props* file. The following shows a sample of this type of file.

   ```xml
   <?xml version="1.0" encoding="utf-8"?>
   <Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
     <PropertyGroup>
       <ExecutablePath>C:\Temp\ExecutablePath;$(ExecutablePath)</ExecutablePath>
       <IncludePath>$(FrameworkSDKRoot)\..\v8.1\ExtensionSDKs\cppimagingsdk\1.0\DesignTime\CommonConfiguration\Neutral\include;$(IncludePath)</IncludePath>
       <AssemblyReferencePath>C:\Temp\AssemblyReferencePath;(AssemblyReferencePath)</AssemblyReferencePath>
       <LibraryPath>$(FrameworkSDKRoot)\..\v8.1\ExtensionSDKs\cppimagingsdk\1.0\DesignTime\Debug\ARM;$(LibraryPath)</LibraryPath>
       <SourcePath>C:\Temp\SourcePath\X64;$(SourcePath)</SourcePath>
       <ExcludePath>C:\Temp\ExcludePath\X64;$(ExcludePath)</ExcludePath>
       <_PropertySheetDisplayName>DevILSDK, 1.0</_PropertySheetDisplayName>
     </PropertyGroup>
   </Project>

   ```

    XML reference documents are placed alongside the reference file. For example, the XML reference document for the *\References\\<config\>\\<arch\>\sample.dll* assembly is *\References\\<config\>\\<arch\>\sample.xml*, and the localized version of that doc is *\References\\<config\>\\<arch\>\\<locale\>\sample.xml*.

5. *Configuration* folder: three subfolders: *Debug*, *Retail*, and *CommonConfiguration*. SDK authors can place their files under *CommonConfiguration* when the same set of SDK files should be consumed, regardless of the configuration targeted by the SDK consumer.

6. *Architecture* folder: the following architectures are supported: x86, x64, ARM, neutral. Win32 maps to x86, and AnyCPU maps to neutral.

### SDKManifest.xml

The *SDKManifest.xml* file describes how Visual Studio should consume the SDK. The following is an example:

```
<FileList DisplayName = "My SDK"
          ProductFamilyName = "My SDKs"
          TargetFramework = ".NETCore, version=v4.5.1; .NETFramework, version=v4.5.1"
          MinVSVersion = "14.0"
          MaxPlatformVersion = "8.1"
          AppliesTo = "WindowsAppContainer + WindowsXAML"
          SupportPrefer32Bit = "True"
          SupportedArchitectures = "x86;x64;ARM"
          SupportsMultipleVersions = "Error"
          CopyRedistToSubDirectory = "."
          DependsOn = "SDKB, version=2.0"
          MoreInfo = "https://msdn.microsoft.com/MySDK">
  <File Reference = "MySDK.Sprint.winmd" Implementation = "XNASprintImpl.dll">
    <Registration Type = "Flipper" Implementation = "XNASprintFlipperImpl.dll" />
    <Registration Type = "Flexer" Implementation = "XNASprintFlexerImpl.dll" />
    <ToolboxItems VSCategory = "Toolbox.Default" />
  </File>
</FileList>
```

The following list gives the elements of the file:

1. DisplayName: the value that appears in the Reference Manager, Solution Explorer, Object Browser, and other locations in the user interface for Visual Studio.

2. ProductFamilyName: The overall SDK product name. For example, the Windows Library for JavaScript (WinJS) SDK is named "Microsoft.WinJS.1.0" and "Microsoft.WinJS.2.0", which belong to the same family of SDK products family, "Microsoft.WinJS". This attribute allows Visual Studio and MSBuild to make that connection. If this attribute doesn't exist, the SDK Name is used as the product family name.

3. FrameworkIdentity: Specifies a dependency on one or more Windows component libraries. The value of this attribute is put into the consuming app's manifest. This attribute is applicable only to Windows component libraries.

4. TargetFramework: Specifies the SDKs that are available in the Reference Manager and the toolbox. This is a semicolon-delimited list of target framework monikers, for example ".NET Framework, version=v2.0; .NET Framework, version=v4.5.1". If several versions of the same target framework are specified, the Reference Manager uses the lowest specified version for filtering purposes. For example, if ".NET Framework, version=v2.0; .NET Framework, version=v4.5.1" is specified, Reference Manager will use ".NET Framework, version=v2.0". If a specific target framework profile is specified, only that profile will be used by the Reference Manager for filtering purposes. For example, when "Silverlight, version=v4.0, profile=WindowsPhone" is specified, Reference Manager filters on only the Windows Phone profile; a project targeting the full Silverlight 4.0 Framework does not see the SDK in the Reference Manager.

5. MinVSVersion: The minimum Visual Studio version.

6. MaxPlatformVerson: The maximum target platform version should be used to specify the platform versions on which your Extension SDK will not work. For example, the Microsoft Visual C++ Runtime Package v11.0 should be referenced only by Windows 8 projects. Thus, the Windows 8 project's MaxPlatformVersion is 8.0. This means that the Reference Manager filters out Microsoft Visual C++ Runtime Package for a Windows 8.1 project, and MSBuild throws an error when a Windows 8.1 project references it. Note: this element is supported starting in Visual Studio 2013.

7. AppliesTo: Specifies the SDKs that are available in the Reference Manager by specifying applicable Visual Studio project types. Nine values are recognized: WindowsAppContainer, VisualC, VB, CSharp, WindowsXAML, JavaScript, Managed, and Native. The SDK author can use and ("+'), or ("&#124;"), not ("!") operators to specify exactly the scope of project types that apply to the SDK.

    WindowsAppContainer identifies projects for Windows 8.x Store apps.

8. SupportPrefer32Bit: Supported values are "True" and "False". The default is "True". If the value is set to "False", MSBuild returns an error for Windows 8.x Store projects (or a warning for desktop projects) if the project that references the SDK has Prefer32Bit enabled. For more information about Prefer32Bit, see [Build page, Project Designer (C#)](../ide/reference/build-page-project-designer-csharp.md) or [Compile page, Project Designer (Visual Basic)](../ide/reference/compile-page-project-designer-visual-basic.md).

9. SupportedArchitectures: A semicolon delimited list of architectures that the SDK supports. MSBuild displays a warning if the targeted SDK architecture in the consuming project isn't supported. If this attribute isn't specified, MSBuild never displays this type of warning.

10. SupportsMultipleVersions: If this attribute is set to **Error** or **Warning**, MSBuild indicates that the same project can't reference multiple versions of the same SDK family. If this attribute doesn't exist or is set to **Allow**, MSBuild doesn't display this type of error or warning.

11. AppX: Specifies the path to the app packages for the Windows component library on the disk. This value is passed to the registration component of the Windows component library during local debugging. The naming convention for the file name is *\<Company>.\<Product>.\<Architecture>.\<Configuration>.\<Version>.appx*. Configuration and Architecture are optional in the attribute name and the attribute value if they don't apply to the Windows component library. This value is applicable only to Windows component libraries.

12. CopyRedistToSubDirectory: Specifies where the files under the *\redist* folder should be copied relative to the app package root (that is, the **Package location** chosen in the **Create App Package** wizard) and runtime layout root. The default location is the root of the app package and **F5** layout.

13. DependsOn: A list of SDK identities that define the SDKs on which this SDK depends. This attribute appears in the details pane of the Reference Manager.

14. MoreInfo: The URL to the web page that provides help and more information. This value is used in the More Information link in the right pane of the Reference Manager.

15. Registration Type: Specifies the WinMD registration in the app manifest and is required for native WinMD, which has a counterpart implementation DLL.

16. File Reference: Specified for only those references that contain controls or are native WinMDs. For information about how to specify whether a reference contains controls, see [Specify the location of toolbox items](#ToolboxItems) below.

## <a name="ToolboxItems"></a> Specify the location of toolbox items

The **ToolBoxItems** element of the *SDKManifest.xml* schema specifies the control names, source assemblies, and toolbox tab names of toolbox items in both platform and extension SDKs. The following examples show various scenarios. This is applicable to either WinMD or DLL references.

Note that in Visual Studio 2019 and earlier, rather than listing toolbox control names in the manifest, Visual Studio dynamically enumerated the control types in the SDK's assemblies. Starting in Visual Studio 2022, this is no longer supported; toolbox items must be explicitly listed in *SDKManifest.xml*.

1. Place controls in the toolbox default category.

    ```xml
    <File Reference = "sample.winmd">
      <ToolboxItems VSCategory = "Toolbox.Default">
        <Item Type = "Namespace.ControlName1" />
        <Item Type = "Namespace.ControlName2" />
      </ToolboxItems>
    </File>
    ```

2. Place controls under a particular category name.

    ```xml
    <File Reference = "sample.winmd">
      <ToolboxItems VSCategory= "MyCategoryName">
        <Item Type = "Namespace.ControlName1" />
        <Item Type = "Namespace.ControlName2" />
      </ToolboxItems>
    </File>
    ```

3. Place controls under particular category names.

    ```xml
    <File Reference = "sample.winmd">
      <ToolboxItems VSCategory = "Graph">
        <Item Type = "Namespace.ControlName1" />
      </ToolboxItems>
      <ToolboxItems VSCategory = "Data">
        <Item Type = "Namespace.ControlName2" />
      </ToolboxItems>
    </File>
    ```

4. Place controls under different category names in Blend and Visual Studio.

    ```xml
    // Blend accepts a slightly different structure for the category name because it allows a path rather than a single category.
    <File Reference = "sample.winmd">
      <ToolboxItems VSCategory = "Graph" BlendCategory = "Controls/sample/Graph">
        <Item Type = "Namespace.ControlName1" />
        <Item Type = "Namespace.ControlName2" />
      </ToolboxItems>
    </File>
    ```

5. Enumerate specific controls differently in Blend and Visual Studio.

    ```xml
    <File Reference = "sample.winmd">
      <ToolboxItems VSCategory = "Graph">
        <Item Type = "Namespace.ControlName1" />
      </ToolboxItems>
      <ToolboxItems BlendCategory = "Controls/sample/Graph">
        <Item Type = "Namespace.ControlName2" />
      </ToolboxItems>
    </File>
    ```

6. Enumerate specific controls, and place them under the Visual Studio Common Path or only in the All Controls Group.

    ```xml
    <File Reference = "sample.winmd">
      <ToolboxItems VSCategory = "Toolbox.Common">
        <Item Type = "Namespace.ControlName1" />
      </ToolboxItems>
      <ToolboxItems VSCategory = "Toolbox.All">
        <Item Type = "Namespace.ControlName2" />
      </ToolboxItems>
    </File>
    ```

7. Enumerate specific controls, and show only a specific set in ChooseItems without them being in the toolbox.

    ```xml
    <File Reference = "sample.winmd">
      <ToolboxItems VSCategory = "Toolbox.ChooseItemsOnly">
        <Item Type = "Namespace.ControlName1" />
        <Item Type = "Namespace.ControlName2" />
      </ToolboxItems>
    </File>
    ```

## Related content

- [Walkthrough: Create an SDK using C++](../extensibility/walkthrough-creating-an-sdk-using-cpp.md)
- [Walkthrough: Create an SDK using C# or Visual Basic](../extensibility/walkthrough-creating-an-sdk-using-csharp-or-visual-basic.md)
- [Manage references in a project](../ide/managing-references-in-a-project.md)
