---
title: "Groups Element | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "VSCT XML schema elements, Groups"
  - "Groups element (VSCT XML schema)"
ms.assetid: 740ca4ec-79fa-4b98-8f9a-2a137f9f7f98
caps.latest.revision: 11
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# Groups Element
Contains entries that define the command groups of a VSPackage.  
  
## Syntax  
  
```  
<Groups>  
  <Group>... </Group>  
  <Group>... </Group>  
</Groups>  
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
|[Group Element](../extensibility/group-element.md)|Represents a single command group.|  
|[Groups Element](../extensibility/groups-element.md)|Contains entries that define the command groups of a VSPackage.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Commands Element](../extensibility/commands-element.md)|Represents the collection of commands on the VSPackage toolbar.|  
  
## Example  
  
```  
<Groups>  
  <Group guid="cmdSetGuidWidgetCommands" id="groupIDFileEdit">  
    <Parent guid="guidSHLMainMenu" id="IDM_VS_TOOL_MAINMENU"/>  
  </Group>  
</Groups>  
```  
  
## See Also  
 [How VSPackages Add User Interface Elements](../extensibility/internals/how-vspackages-add-user-interface-elements.md)   
 [Commands, Menus, and Toolbars](../extensibility/internals/commands-menus-and-toolbars.md)