---
title: "Parent Element | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "VSCT XML schema elements, Parent"
  - "Parent element (VSCT XML schema)"
ms.assetid: e4624ac8-1b9a-4940-910a-528a661cefad
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# Parent Element
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The parent of a button or combo box may only be a group. The parent of a menu or group may be any other menu or group. In a [CommandPlacement Element](../extensibility/commandplacement-element.md), this element is required; in all other instances it is optional. If this element is omitted, the parent of `Group_Undefined:0` will be implied.  
  
## Syntax  
  
```  
<Parent guid="guidMyCommandSet" id="MyParentGroupOrMenu" />  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|guid|Required. GUID of GUID/ID command identifier.|  
|id|Required. ID of GUID/ID command identifier.|  
  
### Child Elements  
 None  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[CommandTable Element](../extensibility/commandtable-element.md)|Defines all the elements that represent commands that a VSPackage provides to the integrated development environment (IDE). For example, menu items, menus, toolbars, and combo boxes.|  
|[Buttons Element](../extensibility/buttons-element.md)|Groups [Button Element](../extensibility/button-element.md) elements.|  
|[Menus Element](../extensibility/menus-element.md)|Defines all the menus that a VSPackage implements.|  
|[Groups Element](../extensibility/groups-element.md)|Contains entries that define the command groups of a VSPackage.|  
  
## See Also  
 [Visual Studio Command Table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
