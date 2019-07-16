---
title: "&lt;publisherIdentity&gt; Element (ClickOnce Deployment) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "publisherIdentity Element [ClickOnce deployment manifest], introduction"
  - "required element for signed manifests [ClickOnce], publisherIdentity Element"
  - "publisherIdentity Element [ClickOnce deployment manifest], syntax, elements, and attributes"
ms.assetid: 34c579db-d2f2-4b66-b9c8-47207f33d950
caps.latest.revision: 13
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# &lt;publisherIdentity&gt; Element (ClickOnce Deployment)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Contains information about the publisher that signed this deployment manifest.  
  
## Syntax  
  
```  
<publisherIdentity  
   name  
   issuerKeyHash  
/>  
```  
  
## Elements and Attributes  
 The `publisherIdentity` element is required for signed manifests. The following table shows the attributes that the `publisherIdentity` element supports.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`name`|Required. Describes the identity of the party that published this application.|  
|`issuerKeyHash`|Required. Contains the SHA-1 hash of the public key of the certificate issuer.|  
  
#### Parameters  
  
## Property Value/Return Value  
  
## Exceptions  
  
## Remarks  
  
## Requirements  
  
## Subhead
