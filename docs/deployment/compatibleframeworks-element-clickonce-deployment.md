---
title: "&lt;compatibleFrameworks&gt; Element (ClickOnce Deployment) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-deployment"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "<compatibleFrameworks> element [ClickOnce deployment manifest]"
ms.assetid: f6c3ee55-9e65-403d-8664-3ebde872c7d4
caps.latest.revision: 15
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
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
# &lt;compatibleFrameworks&gt; Element (ClickOnce Deployment)
Identifies the versions of the .NET Framework where this application can install and run.  
  
> [!NOTE]
>  [MageUI.exe](../Topic/MageUI.exe%20\(Manifest%20Generation%20and%20Editing%20Tool,%20Graphical%20Client\).md) does not support the `compatibleFrameworks` element when saving an application manifest that has already been signed with a certificate using [MageUI.exe](../Topic/MageUI.exe%20\(Manifest%20Generation%20and%20Editing%20Tool,%20Graphical%20Client\).md). Instead, you must use [Mage.exe](../Topic/Mage.exe%20\(Manifest%20Generation%20and%20Editing%20Tool\).md).  
  
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
 The `compatibleFrameworks` element is required for deployment manifests that target the [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] runtime provided by [!INCLUDE[net_v40_short](../code-quality/includes/net_v40_short_md.md)] or later. The `compatibleFrameworks` element contains one or more `framework` elements that specify the .NET Framework versions on which this application can run. The [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] runtime will run the application on the first available `framework` in this list.  
  
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
 The following code example shows a `compatibleFrameworks` element in a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] deployment manifest. This deployment can run on the [!INCLUDE[net_client_v40_long](../deployment/includes/net_client_v40_long_md.md)]. It can also run on the [!INCLUDE[net_v40_short](../code-quality/includes/net_v40_short_md.md)] because it is a superset of the [!INCLUDE[net_client_v40_long](../deployment/includes/net_client_v40_long_md.md)].  
  
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