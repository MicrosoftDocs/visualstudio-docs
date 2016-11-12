---
title: "Version Numbers for Main and Localized Satellite Assemblies | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "satellite assemblies, version numbers"
  - "SatelliteContractVersionAttribute"
  - "version numbers, assemblies"
  - "assemblies [Visual Studio], version numbers"
  - "versioning, assemblies"
ms.assetid: 5489aea1-57b4-4561-9bb4-24d490269602
caps.latest.revision: 12
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Version Numbers for Main and Localized Satellite Assemblies
The <xref:System.Resources.SatelliteContractVersionAttribute> class provides versioning support for a main assembly that uses localized resources by means of the resource manager. Applying the <xref:System.Resources.SatelliteContractVersionAttribute> to an application's main assembly allows you to update and re-deploy the assembly without updating its satellite assemblies. For example, you can use the <xref:System.Resources.SatelliteContractVersionAttribute> class with a service pack that doesn't introduce new resources without rebuilding and redeploying your satellite assemblies. For your localized resources to be available, the satellite contract version of your main assembly must match the <xref:System.Reflection.AssemblyVersionAttribute> class of your satellite assemblies. You must specify an exact version number in the <xref:System.Resources.SatelliteContractVersionAttribute>; wildcard characters such as "*" are not allowed. For more information, see [Retrieving Resources](../Topic/Retrieving%20Resources%20in%20Desktop%20Apps.md).  
  
## Updating Assemblies  
 The <xref:System.Resources.SatelliteContractVersionAttribute> class allows you to update a main assembly without having to update your satellite assembly, or vice versa. When the main assembly is updated, its assembly version number is changed. If you want to continue using the existing satellite assemblies, change the main assembly's version number but leave the satellite contract version number the same. For example, in your first release your main assembly version may be 1.0.0.0. The satellite contract version and the assembly version of the satellite assembly will also be 1.0.0.0. If you need to update your main assembly for a service pack, you can change the assembly version to 1.0.0.1, while keeping the satellite contract version and the satellite's assembly version as 1.0.0.0.  
  
 If you need to update a satellite assembly but not your main assembly, you change the <xref:System.Reflection.AssemblyVersionAttribute> of the satellite assembly. Along with your satellite assembly, you will have to ship a policy assembly that states that your new satellite assembly is compatible with your old satellite assembly. For more information on policies, see [How the Runtime Locates Assemblies](../Topic/How%20the%20Runtime%20Locates%20Assemblies.md).  
  
 The following code shows how to set the satellite contract version. The code can be placed in either a build script or in the AssemblyInfo.vb or AssemblyInfo.cs file.  
  
```vb#  
<Assembly: SatelliteContractVersionAttribute("4.3.2.1")>  
  
```  
  
```c#  
[assembly: SatelliteContractVersionAttribute("4.3.2.1")]  
```  
  
## See Also  
 [How the Runtime Locates Assemblies](../Topic/How%20the%20Runtime%20Locates%20Assemblies.md)   
 [Setting Assembly Attributes](../Topic/Setting%20Assembly%20Attributes.md)   
 [Security and Localized Satellite Assemblies](../ide/security-and-localized-satellite-assemblies.md)   
 [Localizing Applications](../ide/localizing-applications.md)   
 [Globalizing and Localizing Applications](../ide/globalizing-and-localizing-applications.md)