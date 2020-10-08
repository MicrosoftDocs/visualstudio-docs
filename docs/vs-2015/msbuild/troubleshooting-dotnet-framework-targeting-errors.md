---
title: "Troubleshooting .NET Framework Targeting Errors | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: troubleshooting
f1_keywords: 
  - "vs.FrameworkTargetingErrors"
  - "MSBuild.ResolveAssemblyReference.FailedToResolveReferenceBecausePrimaryAssemblyInExclusionList"
helpviewer_keywords: 
  - "targeting .NET Framework version [Visual Studio]"
  - "versions [Visual Studio], .NET Framework Client Profile"
  - "multi-targeting"
  - "multitargeting"
  - ".NET Framework Client Profile"
ms.assetid: 830e3e45-9a93-4279-a249-75b84599aefb
caps.latest.revision: 32
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Troubleshooting .NET Framework Targeting Errors
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This topic describes MSBuild errors that might occur because of reference issues and how you can resolve those errors.  
  
## You Have Referenced a Project or Assembly That Targets a Different Version of the .NET Framework  
 You can create applications that reference projects or assemblies that target different versions of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)]. For example, you can create an application that targets the client profile for the [!INCLUDE[net_v40_short](../includes/net-v40-short-md.md)] but references an assembly that targets the .NET Framework 2.0. However, if you create a project that targets an earlier version of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)], you can’t set a reference in that project to a project or assembly that targets the client profile for the [!INCLUDE[net_v40_short](../includes/net-v40-short-md.md)] or the [!INCLUDE[net_v40_short](../includes/net-v40-short-md.md)] itself. To resolve the error, make sure that your application targets a profile or profiles that are compatible with the profile that’s targeted by the projects or assemblies that your application references.  
  
## You Have Re-Targeted a Project to a Different Version of the .NET Framework  
 If you change the target version of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] for your application, Visual Studio changes some of the references, but you may have to update some references manually. For example, one of the previously mentioned errors might occur if you change an application to target the [!INCLUDE[net_v35SP1_long](../includes/net-v35sp1-long-md.md)] and that application has resources or settings that rely on the client profile for the [!INCLUDE[net_v40_short](../includes/net-v40-short-md.md)].  
  
 To work around application settings, open **Solution Explorer**, choose **Show All Files**, and then edit the app.config file in the XML editor of Visual Studio. Change the version in the settings to match the appropriate version of the .NET Framework. For example, you can change the version setting from 4.0.0.0 to 2.0.0.0. Similarly, for an application that has added resources, open **Solution Explorer**, choose the **Show All Files** button, expand **My Project** (Visual Basic) or **Properties** (C#), and then edit the Resources.resx file in the XML editor of Visual Studio. Change the version setting from 4.0.0.0 to 2.0.0.0.  
  
 If your application has resources such as icons or bitmaps or settings such as data connection strings, you can also resolve the error by removing all the items on the **Settings** page of the **Project Designer** and then re-adding the required settings.  
  
## You Have Re-Targeted a Project to a Different Version of the .NET Framework and References Do Not Resolve  
 If you retarget a project to a different version of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)], your references may not resolve properly in some cases. Explicit fully qualified references to assemblies often cause this issue, but you can resolve it by removing the references that do not resolve and then adding them back to the project. As an alternative, you can edit the project file to replace the references. First, you remove references of the following form:  
  
```  
<Reference Include="System.ServiceModel, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089, processorArchitecture=MSIL" />  
```  
  
 Then you replace them with the simple form:  
  
```  
<Reference Include="System.ServiceModel" />  
```  
  
> [!NOTE]
> After you close and reopen your project, you should also rebuild it to ensure that all references resolve correctly.  
  
## See Also  
 [How to: Target a Version of the .NET Framework](../ide/how-to-target-a-version-of-the-dotnet-framework.md)   
 [.NET Framework Client Profile](https://msdn.microsoft.com/library/f0219919-1f02-4588-8704-327a62fd91f1)   
 [Targeting a Specific .NET Framework Version](../ide/targeting-a-specific-dotnet-framework-version.md)   
 [Multitargeting](../msbuild/msbuild-multitargeting-overview.md)
