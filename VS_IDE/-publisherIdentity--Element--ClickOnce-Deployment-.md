---
title: "&lt;publisherIdentity&gt; Element (ClickOnce Deployment)"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-deployment
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 34c579db-d2f2-4b66-b9c8-47207f33d950
caps.latest.revision: 11
manager: wpickett
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# &lt;publisherIdentity&gt; Element (ClickOnce Deployment)
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