---
title: "&lt;assemblyIdentity&gt; Element (ClickOnce Deployment) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-deployment"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "urn:schemas-microsoft-com:asm.v2#assemblyIdentity"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "<assemblyIdentity> element [ClickOnce deployment manifest]"
ms.assetid: f4a3bb83-c800-47d0-9905-9a5ae2486838
caps.latest.revision: 23
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
# &lt;assemblyIdentity&gt; Element (ClickOnce Deployment)
Identifies the primary assembly of the [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application.  
  
## Syntax  
  
```  
  
      <assemblyIdentity    
   name   
   version  
   publicKeyToken  
   processorArchitecture  
    type  
/>  
```  
  
## Elements and Attributes  
 The `assemblyIdentity` element is required. It contains no child elements and has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`name`|Required. Identifies the human-readable name of the deployment for informational purposes.<br /><br /> If `name` contains special characters, such as single or double quotes, the application may fail to activate.|  
|`version`|Required. Specifies the version number of the assembly, in the following format: `major.minor.build.revision`.<br /><br /> This value must be incremented in an updated manifest to trigger an application update.|  
|`publicKeyToken`|Required. Specifies a 16-character hexadecimal string that represents the last 8 bytes of the SHA-1 hash value of the public key under which the deployment manifest is signed. The public key that is used to sign must be 2048 bits or greater.<br /><br /> Although signing an assembly is recommended but optional, this attribute is required. If an assembly is unsigned, you should copy a value from a self-signed assembly or use a "dummy" value of all zeros.|  
|`processorArchitecture`|Required. Specifies the processor. The valid values are `msil` for all processors, `x86` for 32-bit Windows, `IA64` for 64-bit Windows, and `Itanium` for Intel 64-bit Itanium processors.|  
|`type`|Required. For compatibility with Windows side-by-side installation technology. The only allowed value is `win32`.|  
  
## Remarks  
  
## Example  
 The following code example illustrates an `assemblyIdentity` element in a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] deployment manifest. This code example is part of a larger example provided for the [ClickOnce Deployment Manifest](../deployment/clickonce-deployment-manifest.md) topic.  
  
```  
<!-- Identify the deployment. -->  
<assemblyIdentity   
  name="My Application Deployment.app"  
  version="1.0.0.0"  
  publicKeyToken="43cb1e8e7a352766"  
  language="neutral"  
  processorArchitecture="x86"  
  xmlns="urn:schemas-microsoft-com:asm.v1" />  
```  
  
## See Also  
 [ClickOnce Deployment Manifest](../deployment/clickonce-deployment-manifest.md)   
 [\<assemblyIdentity> Element](../deployment/assemblyidentity-element-clickonce-application.md)