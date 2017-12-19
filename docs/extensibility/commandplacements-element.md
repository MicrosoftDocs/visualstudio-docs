---
title: "CommandPlacements Element | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "CommandPlacements"
helpviewer_keywords: 
  - "CommandPlacements element (VSCT XML schema)"
  - "VSCT XML schema elements, CommandPlacements"
ms.assetid: 78a5724a-3b9f-4c78-9c0d-8faa3924f81c
caps.latest.revision: 11
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# CommandPlacements Element
The CommandPlacements element groups CommandPlacement elements and other CommandPlacements groupings.  
  
 The CommandPlacements element is optional. If no commands, groups, or menus must be included in a secondary location, you do not have to include this section in your .vsct file.  
  
## Syntax  
  
```  
<CommandPlacements>  
  <CommandPlacement>... </CommandPlacement>  
  <CommandPlacement>... </CommandPlacement>  
</CommandPlacements>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|Condition|Optional. See [Conditional Attributes](../extensibility/vsct-xml-schema-conditional-attributes.md).|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|CommandPlacements|Groups CommandPlacement elements and other CommandPlacements groupings.|  
|[CommandPlacement Element](../extensibility/commandplacement-element.md)|Enables buttons, groups, and menus to be included in more than one group or menu.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[CommandTable Element](../extensibility/commandtable-element.md)|Defines all the elements that represent commands.|  
  
## Example  
  
```  
<CommandPlacements>  
  <CommandPlacement guid="guidWidgetPackage" id="cmdidInsertOptions"  
    priority="0x0300">  
    <Parent guid="cmdGuidWidgetCommands" id="menuIDEditWidget"/>  
  </CommandPlacement>  
</CommandPlacements>  
```  
  
## See Also  
 [CommandPlacement Element](../extensibility/commandplacement-element.md)   
 [Visual Studio Command Table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)