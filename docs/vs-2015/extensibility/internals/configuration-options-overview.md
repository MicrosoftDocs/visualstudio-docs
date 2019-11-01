---
title: "Configuration Options Overview | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "project configurations"
  - "configuration options, about configuration options"
ms.assetid: f4ad4dd3-b39e-42df-ad89-d403cdf24a2b
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# Configuration Options Overview
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Projects in [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] can support multiple configurations that can be built, debugged, run, and/or deployed. A configuration is a build type described with a named set of properties, typically compiler switches and file locations. By default, new solutions contain two configurations, Debug and Release. These configurations can be applied using their default settings, or modified to meet your specific solution and/or project requirements. Some packages can be built in two ways: as an ActiveX editor or as an in-place component. Projects do not need to support multiple configurations, however. If there is only one configuration available, that configuration is mapped into all of the solution configurations.  
  
 Configurations typically consist of two parts — the configuration name (such as Debug or Release) and platform settings. A configuration's platform name identifies the environment that the configuration targets, such as an API set or operating system platform. Users of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] cannot create a platform; they must choose from the selections a project VSPackage allows. When a user installs a VSPackage, the delivery platform created during development of the package can surface any platform name desired based on any criteria set by the package creator. The user can then select from the list of platforms made available through the VSPackage when the property pages are instantiated.  
  
 Platform names are optional since not all projects support the concept of platforms. When a configuration lacks a platform name, the string "N/A" is displayed in the UI.  
  
 Each solution has its own set of configurations, only one of which can be active at a time. A solution configuration is a set of no more than one configuration from each project. The "no more than" stipulation is due to the option to exclude a project from a solution configuration. Users can create their own custom solution configurations.  
  
 The following table illustrates the typical configurations setup for a project. The rows are labeled with configuration names and the columns with platform names.  
  
|Configuration Name|Platform — Win32|Platform — Win64|  
|------------------------|----------------------|----------------------|  
|Debug|\<Debug Win32 settings>|\<Debug Win64 settings>|  
|Release|\<Release Win32 settings>|\<Release Win64 settings>|  
|MyConfig|N/A|\<MyConfig Win64 settings>|  
  
> [!NOTE]
> You cannot create a "MyConfig" solution configuration that excludes a "Win32" platform unless the project you are targeting does not support Win32.  
  
 Changing the active configuration for a solution selects the set of project configurations that are built, run, debugged or deployed in that solution. For example, if you change the active solution configuration from Release to Debug, all projects within that solution are automatically built with the projects' configuration indicated in the solution's Debug configuration. The projects' configurations are usually also named Debug unless the user has made manual changes in the environment's Configuration Manager.  
  
 The solution configuration properties stored for each project include the project name, project configuration name, flags to indicate whether or not to build or to deploy, and platform name. For more information, see [Solution Configuration](../../extensibility/internals/solution-configuration.md).  
  
 The user can view and set solution configuration parameters by selecting the solution in the hierarchy (Solution Explorer) and opening the property pages. Similarly, you can view and set project configuration parameters by selecting a project in Solution Explorer and opening the property pages for that project.  
  
 The user can also build one project using Release configuration settings and all the rest with Debug configuration settings if necessary. For more information, see [Project Configuration for Building](../../extensibility/internals/project-configuration-for-building.md).  
  
 The following diagram shows how the interfaces that support solution and project configurations are implemented:  
  
 ![Configuration Interfaces graphic](../../extensibility/internals/media/vsconfiginterfaces.gif "vsConfigInterfaces")  
Configuration interfaces  
  
 A few notes relating to the previous diagram:  
  
- `IDispatch` is marked as optional in the Configuration Object. Specifically, it is optional to have the configuration interfaces on the browse object.  
  
- `IVsDebuggableProjectCfg` is marked optional in the Configuration Object, but is required for debugging support.  
  
- `IVsProjectCfg2` is marked optional in the Configuration Object, but is needed for output grouping support.  
  
- The `Config Provider` object is marked as an optional object, but the option is where to implement it. You may implement the object on the project object or on a separate object.  
  
- `IVsCfgProvider2` is needed for platform support and configuration editing. `IVsCfgProvider` is sufficient if you do not implement that functionality.  
  
- Some of these objects shown in the diagram as separate objects can be combined into the same class where practical based on your specific design requirements. In other topics of this section, however, the objects and interfaces associated with those objects will be discussed according to the scenario presented in the diagram.  
  
- Certain objects are implemented separately. For example, project and solution building occur on separate threads and the object to manage the build lives separately from the object describing the configuration for the build.  
  
  For further information on the Configuration Object interfaces and Configuration Provider Object interfaces in the previous diagram, see [Project Configuration Object](../../extensibility/internals/project-configuration-object.md). In addition, [Project Configuration for Building](../../extensibility/internals/project-configuration-for-building.md) provides more information on the Configuration Builder and Build Dependency Object interfaces, and [Project Configuration for Managing Deployment](../../extensibility/internals/project-configuration-for-managing-deployment.md) further describes the interfaces attached to the configuration deployer and deployment dependency objects. Finally, [Project Configuration for Output](../../extensibility/internals/project-configuration-for-output.md) describes the Output Group and Output Object interfaces, and the use of property pages to view and set configuration-dependent properties.  
  
## See Also  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsCfgProvider2>   
 [Project Configuration for Building](../../extensibility/internals/project-configuration-for-building.md)   
 [Solution Configuration](../../extensibility/internals/solution-configuration.md)
