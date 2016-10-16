---
title: "IDSymbol Element"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IDSymbol element (VSCT XML schema)"
  - "VSCT XML schema elements, IDSymbol"
ms.assetid: 760cfd20-3c06-422c-9103-98bfa1f387f8
caps.latest.revision: 7
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
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
# IDSymbol Element
The `IDSymbol` element contains the ID of the GUID:ID pair that represents a menu, group, or command. The GUID comes from the parent `GuidSymbol` element. The `IDSymbol` element has a `name` attribute that provides a friendly name for the ID, which is contained in the `value` attribute.  
  
## Syntax  
  
```  
<IDSymbol name=ElementName value="0x0010" />  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|name|Required. Name of the ID symbol.|  
|value|Required. Numeric ID value of the ID symbol.|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[GuidSymbol Element](../extensibility/guidsymbol-element.md)|Contains the GUID of the GUID:ID pair that represents a menu, group, or command. Groups `IDSymbol` elements.|  
  
## Remarks  
 Every `IDSymbol` element in a given `GuidSymbol` element must have a unique `value`. However, `IDSymbol` elements that have identical values can exist in a package as long as they have different parents.  
  
## See Also  
 [Visual Studio Command Table (.Vsct) Files](../extensibility/visual-studio-command-table--.vsct--files.md)