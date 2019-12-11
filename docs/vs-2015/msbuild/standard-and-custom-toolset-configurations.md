---
title: "Standard and Custom Toolset Configurations | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
helpviewer_keywords: 
  - "MSBuild, custom toolset configurations"
  - "MSBuild, msbuild.exe.config"
ms.assetid: 15a048c8-5ad3-448e-b6e9-e3c5d7147ed2
caps.latest.revision: 34
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Standard and Custom Toolset Configurations
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

An MSBuild Toolset contains references to tasks, targets, and tools that you can use to build an application project. MSBuild includes a standard Toolset, but you can also create custom Toolsets. For information about how to specify a Toolset, see [Toolset (ToolsVersion)](../msbuild/msbuild-toolset-toolsversion.md)  

## Standard Toolset Configurations  
 MSBuild 12.0 includes the following standard Toolsets:  

| ToolsVersion | Toolset Path (as specified in the MSBuildToolsPath or MSBuildBinPath build property) |
|--------------|--------------------------------------------------------------------------------------|
|     2.0      |           *Windows installation path*\Microsoft.Net\Framework\v2.0.50727\            |
|     3.5      |              *Windows installation path*\Microsoft.NET\Framework\v3.5\               |
|     4.0      |           *Windows installation path*\Microsoft.NET\Framework\v4.0.30319\            |
|     12.0     |                          *%ProgramFiles%*\MSBuild\12.0\bin                           |

 The `ToolsVersion` value determines which Toolset is used by a project that Visual Studio generates. In [!INCLUDE[vs_dev12](../includes/vs-dev12-md.md)] the default value is "12.0" (no matter what the version specified in the project file), but you can override that attribute by using the **/toolsversion** switch at a command prompt. For information about this attribute and other ways to specify the `ToolsVersion`, see [Overriding ToolsVersion Settings](../msbuild/overriding-toolsversion-settings.md).  

 If the `ToolsVersion` isn't specified, the registry key **HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSBuild\\<Version Number\>\DefaultToolsVersion** defines the `ToolsVersion`, which is always 2.0.  

 The following registry keys specify the installation path of MSBuild.exe.  

|Registry Key|Key Name|String Key Value|  
|------------------|--------------|----------------------|  
|\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSBuild\ToolsVersions\2.0\|MSBuildToolsPath|.NET Framework 2.0 Install Path|  
|\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\ MSBuild\ToolsVersions\3.5\|MSBuildToolsPath|.NET Framework 3.5 Install Path|  
|\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\ MSBuild\ToolsVersions\4.0\|MSBuildToolsPath|.NET Framework 4 Install Path|  
|\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\ MSBuild\ToolsVersions\12.0\|MSBuildToolsPath|MSBuild Install Path|  

### Sub-toolsets  
 If the registry key in the previous table has a subkey, MSBuild uses it to determine the path of a sub-toolset may override the path in the parent toolset. The following subkey is an example:  

 \HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSBuild\ToolsVersions\12.0\12.0  

 If any properties are defined in both the base toolset and the selected sub-toolset, the property definitions in the sub-toolset are used. For example, the MSBuild 4.0 toolset defines `SDK40ToolsPath` to point to the 7.0A SDK, but the MSBuild 4.0\11.0 toolset defines the same property to point to the 8.0A SDK. If `VisualStudioVersion` is unset, `SDK40ToolsPath` would point to 7.0A, but if `VisualStudioVersion` is set to 11.0, the property would instead point to 8.0A.  

 The `VisualStudioVersion` build property indicates whether a sub-toolset becomes active. For example, a `VisualStudioVersion` value of "12.0" specifies the MSBuild 12.0 sub-toolset. For more information, see the Sub-toolsets section of [Toolset (ToolsVersion)](../msbuild/msbuild-toolset-toolsversion.md).  

> [!NOTE]
> We recommend that you avoid changing these settings. Nevertheless, you can add your own settings and define computer-wide custom toolset definitions, as the next section describes.  

## Custom Toolset Definitions  
 When a standard Toolset does not fulfill your build requirements, you can create a custom Toolset. For example, you may have a build lab scenario in which you must have a separate system for building [!INCLUDE[vcprvc](../includes/vcprvc-md.md)] projects. By using a custom Toolset, you can assign custom values to the `ToolsVersion` attribute when you create projects or run MSBuild.exe. By doing this, you can also use the `$(MSBuildToolsPath)` property to import .targets files from that directory, as well as defining your own custom toolset properties that can be used for any project that uses that toolset.  

 Specify a custom Toolset in the configuration file for MSBuild.exe (or for the custom tool that hosts the MSBuild engine if that is what you are using). For example, the configuration file for MSBuild.exe could include the following Toolset definition if you wished to override the default behavior of ToolsVersion 12.0.  

```  
<msbuildToolsets default="12.0">  
   <toolset toolsVersion="12.0">  
      <property name="MSBuildToolsPath"   
        value="C:\SpecialPath" />  
   </toolset>  
</msbuildToolsets>  
```  

 `<msbuildToolsets>` must also be defined in the configuration file, as follows.  

```  
<configSections>  
   <section name="msbuildToolsets"         
       Type="Microsoft.Build.BuildEngine.ToolsetConfigurationSection,   
       Microsoft.Build.Engine, Version=12.0.0.0, Culture=neutral,   
       PublicKeyToken=b03f5f7f11d50a3a"  
   </section>  
</configSections>  
```  

> [!NOTE]
> To be read correctly, `<configSections>` must be the first subsection in the `<configuration>` section.  

 `ToolsetConfigurationSection` is a custom configuration section that can be used by any MSBuild host for custom configuration. If you use a custom Toolset, a host does not have to do anything to initialize the build engine except provide the configuration file entries. By defining entries in the registry, you can specify computer-wide Toolsets that apply to MSBuild.exe, [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], and all hosts of MSBuild.  

> [!NOTE]
> If a configuration file defines settings for a `ToolsVersion` that was already defined in the registry, the two definitions are not merged. The definition in the configuration file takes precedence and the settings in the registry for that `ToolsVersion` are ignored.  

 The following properties are specific to the value of `ToolsVersion` that is used in projects:  

- **$(MSBuildBinPath)** is set to the `ToolsPath` value that is specified either in the registry or in the configuration file where the `ToolsVersion` is defined. The `$(MSBuildToolsPath)` setting in the registry or the configuration file specifies the location of the core tasks and targets. In the project file, this maps to the $(MSBuildBinPath) property, and also to the $(MSBuildToolsPath) property.  

- `$(MSBuildToolsPath)` is a reserved property that is supplied by the MSBuildToolsPath property that is specified in the configuration file. (This property replaces `$(MSBuildBinPath)`. However, `$(MSBuildBinPath)` is carried forward for compatibility.) A custom toolset must define either `$(MSBuildToolsPath)` or `$(MSBuildBinPath)` but not both, unless they both have the same value.  

  You can also add custom, ToolsVersion-specific properties to the configuration file by using the same syntax that you use to add the MSBuildToolsPath property. To make these custom properties available to the project file, use the same name as the name of the value that is specified in the configuration file. You may define toolsets but not sub-toolsets in the configuration file.  

## See Also  
 [Toolset (ToolsVersion)](../msbuild/msbuild-toolset-toolsversion.md)
