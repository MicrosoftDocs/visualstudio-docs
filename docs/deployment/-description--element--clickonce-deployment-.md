---
title: "&lt;description&gt; Element (ClickOnce Deployment)"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-deployment"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "urn:schemas-microsoft-com:asm.v2#description"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "<description> element [ClickOnce deployment manifest]"
ms.assetid: 18f6919e-a3ab-4942-a57d-167fabfac44e
caps.latest.revision: 19
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
# &lt;description&gt; Element (ClickOnce Deployment)
Identifies application information used to create a shell presence and an **Add or Remove Programs** item in Control Panel.  
  
## Syntax  
  
```  
  
      <description   
   publisher   
   product  
   suiteName  
   supportUrl  
/>  
```  
  
## Elements and Attributes  
 The `description` element is required and is in the `urn:schemas-microsoft-com:asm.v1` namespace. It contains no child elements and has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`publisher`|Required. Identifies the company name used for icon placement in the Windows **Start** menu and the **Add or Remove Programs** item in Control Panel, when the deployment is configured for install.|  
|`product`|Required. Identifies the full product name. Used as the title for the icon installed in the Windows **Start** menu.|  
|`suiteName`|Optional. Identifies a subfolder within the `publisher` folder in the Windows **Start** menu.|  
|`supportUrl`|Optional. Specifies a support URL that is shown in the **Add or Remove Programs** item in Control Panel. A shortcut to this URL is also created for application support in the Windows **Start** menu, when the deployment is configured for installation.|  
  
## Remarks  
 The description element is required in all deployment configurations.  
  
## Example  
 The following code example illustrates a `description` element in a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] deployment manifest. This code example is part of a larger example provided for the [ClickOnce Deployment Manifest](../deployment/clickonce-deployment-manifest.md) topic.  
  
```  
<description   
  asmv2:publisher="My Company Name"  
  asmv2:product="My Application"  
  xmlns="urn:schemas-microsoft-com:asm.v1" />  
```  
  
## See Also  
 [ClickOnce Deployment Manifest](../deployment/clickonce-deployment-manifest.md)