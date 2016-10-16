---
title: "CommandPlacement Element"
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
  - "CommandPlacements element (VSCT XML schema)"
  - "VSCT XML schema elements, CommandPlacements"
ms.assetid: 2cbd7ac8-c55a-43d8-a26d-713b3d790016
caps.latest.revision: 9
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
# CommandPlacement Element
The CommandPlacement element enables buttons, groups, and menus to be included in more than one group or menu. By using the CommandPlacement element, you do not have to completely redefine these items in order to modify the look of a user interface.  
  
 For more information, see [Creating Reusable Groups of Buttons](../extensibility/creating-reusable-groups-of-buttons.md).  
  
## Syntax  
  
```  
<CommandPlacement guid=guidMyCommandSet" id="MyCommand" priority="0x001" >  
  <Parent>... </Parent>  
</CommandPlacement>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|guid|Required. The guid of the command set, as defined in the [Symbols Element](../extensibility/symbols-element.md).|  
|id|Required. The id of the menu, group, or command to be placed, as defined in the `Symbols Element`.|  
|priority|Required. Determines the visual position of the item in its parent element.|  
|Condition|Optional. See [Conditional Attributes](../extensibility/vsct-xml-schema-conditional-attributes.md).|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|Parent|Required. The menu or group that hosts the item to be placed.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[CommandPlacements Element](../extensibility/commandplacements-element.md)|Specifies groups of CommandPlacements and CommandPlacement elements.|  
  
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
 [CommandPlacements Element](../extensibility/commandplacements-element.md)   
 [Visual Studio Command Table (.Vsct) Files](../extensibility/visual-studio-command-table--.vsct--files.md)