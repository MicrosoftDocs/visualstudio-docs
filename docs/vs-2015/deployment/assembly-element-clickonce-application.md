---
title: "&lt;assembly&gt; Element (ClickOnce Application) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
f1_keywords: 
  - "urn:schemas-microsoft-com:asm.v2#assembly"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "<assembly> element [ClickOnce application manifest]"
ms.assetid: 51410569-10f9-4c0a-96b5-d39185edbefc
caps.latest.revision: 17
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# &lt;assembly&gt; Element (ClickOnce Application)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The top-level element for the application manifest.  
  
## Syntax  
  
```  
  
      <assembly  
   manifestVersion  
/>  
```  
  
## Elements and Attributes  
 The `assembly` element is the root element and is required. Its first contained element must be an `assemblyIdentity` element. The manifest elements must be in one of the following namespaces:  
  
 `urn:schemas-microsoft-com:asm.v1`  
  
 `urn:schemas-microsoft-com:asm.v2`  
  
 `http://www.w3.org/2000/09/xmldsig#`  
  
 Child elements of the assembly must also be in these namespaces, by inheritance or by tagging.  
  
 The `assembly` element has the following attribute.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`manifestVersion`|Required. The `manifestVersion` attribute must be set to `1.0`.|  
  
## Example  
 The following code example illustrates an `assembly` element in an application manifest for a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application. This code example is part of a larger example provided in [ClickOnce Application Manifest](../deployment/clickonce-application-manifest.md).  
  
```  
<asmv1:assembly   
  xsi:schemaLocation="urn:schemas-microsoft-com:asm.v1 assembly.adaptive.xsd"   
  manifestVersion="1.0"   
  xmlns:asmv3="urn:schemas-microsoft-com:asm.v3"  
  xmlns:dsig=http://www.w3.org/2000/09/xmldsig#  
  xmlns:co.v2="urn:schemas-microsoft-com:clickonce.v2"  
  xmlns="urn:schemas-microsoft-com:asm.v2"  
  xmlns:asmv1="urn:schemas-microsoft-com:asm.v1"  
  xmlns:asmv2="urn:schemas-microsoft-com:asm.v2"  
  xmlns:xsi=http://www.w3.org/2001/XMLSchema-instance  
  xmlns:co.v1="urn:schemas-microsoft-com:clickonce.v1">  
```  
  
## See Also  
 [ClickOnce Application Manifest](../deployment/clickonce-application-manifest.md)   
 [\<assembly> Element](../deployment/assembly-element-clickonce-deployment.md)
