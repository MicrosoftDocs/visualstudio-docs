---
title: "GuidSymbol Element | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "VSCT XML schema elements, GuidSymbol"
  - "GuidSymbol element (VSCT XML schema)"
ms.assetid: 11fb3545-8974-4776-9a54-6b6e7739ae31
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# GuidSymbol Element
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The `GuidSymbol` element contains the GUID of the GUID:ID pair that represents a menu, group, or command. The ID comes from an `IDSymbol` element in the `GuidSymbol` element. The `GuidSymbol` element has a `name` attribute that provides a friendly name for the GUID, which is contained in the `value` attribute.  
  
## Syntax  
  
```  
<GuidSymbol name="guidMyCommandSet" value="{xxxxxxxxxxxxx-xxxx-xxxx-xxxxxxxxxxxx}">  
  <IDSymbol>... </IDSymbol>  
  <IDSymbol>... </IDSymbol>  
</GuidSymbol>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|name|Required. Name of the GUID symbol.|  
|value|Required. GUID of the GUID symbol.|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[IDSymbol Element](../extensibility/idsymbol-element.md)|Contains the ID of the GUID:ID pair that represents a menu, group, or command.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Symbols Element](../extensibility/symbols-element.md)|Groups `GuidSymbol` elements in a .vsct file.|  
  
## Remarks  
 Typically, a .vsct file contains three `GuidSymbol` elements in its `Symbols` section, one for the package itself, one for the command set (the collection of menus, groups, and commands that the package makes available), and one for the bitmaps that provide icons for buttons and other visual components. Every `IDSymbol` element in a given `GuidSymbol` element must have a unique `value`.However, `IDSymbol` elements that have identical values can exist in a package as long as they have different parents.  
  
## See Also  
 [Visual Studio Command Table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
