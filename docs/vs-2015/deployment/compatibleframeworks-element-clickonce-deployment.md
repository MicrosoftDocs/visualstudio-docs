---
title: "&lt;compatibleFrameworks&gt; Element (ClickOnce Deployment) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "<compatibleFrameworks> element [ClickOnce deployment manifest]"
ms.assetid: f6c3ee55-9e65-403d-8664-3ebde872c7d4
caps.latest.revision: 17
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# &lt;compatibleFrameworks&gt; Element (ClickOnce Deployment)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Identifies the versions of the .NET Framework where this application can install and run.  
  
> [!NOTE]
> [MageUI.exe](https://msdn.microsoft.com/library/f9e130a6-8117-49c4-839c-c988f641dc14) does not support the `compatibleFrameworks` element when saving an application manifest that has already been signed with a certificate using [MageUI.exe](https://msdn.microsoft.com/library/f9e130a6-8117-49c4-839c-c988f641dc14). Instead, you must use [Mage.exe](https://msdn.microsoft.com/library/77dfe576-2962-407e-af13-82255df725a1).  
  
## Syntax  
  
```  
<compatibleFrameworks  
      SupportUrl>   
   <framework  
      targetVersion  
      profile  
      supportedRuntime  
   />   
</ compatibleFrameworks>  
```  
  
## Elements and Attributes  
 The `compatibleFrameworks` element is required for deployment manifests that target the [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] runtime provided by [!INCLUDE[net_v40_short](../includes/net-v40-short-md.md)] or later. The `compatibleFrameworks` element contains one or more `framework` elements that specify the .NET Framework versions on which this application can run. The [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] runtime will run the application on the first available `framework` in this list.  
  
 The following table lists the attribute that the `compatibleFrameworks` element supports.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`S` `upportUrl`|Optional. Specifies a URL where the preferred compatible .NET Framework version can be downloaded.|  
  
## framework  
 Required. The following table lists the attributes that the `framework` element supports.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`targetVersion`|Required. Specifies the version number of the target .NET Framework.|  
|`profile`|Required. Specifies the profile of the target .NET Framework.|  
|`supportedRuntime`|Required. Specifies the version number of the runtime associated with the target .NET Framework.|  
  
## Remarks  
  
## Example  
 The following code example shows a `compatibleFrameworks` element in a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] deployment manifest. This deployment can run on the [!INCLUDE[net_client_v40_long](../includes/net-client-v40-long-md.md)]. It can also run on the [!INCLUDE[net_v40_short](../includes/net-v40-short-md.md)] because it is a superset of the [!INCLUDE[net_client_v40_long](../includes/net-client-v40-long-md.md)].  
  
```  
<compatibleFrameworks xmlns="urn:schemas-microsoft-com:clickonce.v2">  
  <framework   
      targetVersion="4.0"   
      profile="Client"   
      supportedRuntime="4.0.30319" />  
</compatibleFrameworks>  
```  
  
## See Also  
 [ClickOnce Deployment Manifest](../deployment/clickonce-deployment-manifest.md)
