---
title: "Icon Element | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "VSCT XML schema elements, Icon"
  - "Icon element (VSCT XML schema)"
ms.assetid: 73c58fe3-d53c-4f4e-b025-29567c6cbb7c
caps.latest.revision: 6
ms.author: gregvanl
manager: jillfra
---
# Icon Element
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The guid attribute of the Icon tag is the guid of a defined bitmap.  The id attribute selects the slot in the bitmap strip. This element is optional.  If this element is omitted the value of **guidOfficeIcon:msotcidNoIcon** will be implied.  
  
## Syntax  
  
```  
<Icon guid="guidImages" id="bmpPic1" />  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|guid|Required. The guid of a defined bitmap.|  
|id|Required. Selects the slot in the bitmap strip.|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|None.|None.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Buttons Element](../extensibility/buttons-element.md)||  
  
## See Also  
 [Visual Studio Command Table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
