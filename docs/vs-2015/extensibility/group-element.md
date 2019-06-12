---
title: "Group Element | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "VSCT XML schema elements, Groups"
  - "Groups element (VSCT XML schema)"
ms.assetid: 69faee18-cbf4-470a-b952-c1919c583df8
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# Group Element
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Defines a VSPackage command group.  
  
## Syntax  
  
```  
<Group guid="guidMyCommandSet" id="MyGroup" priority="0x101">  
  <Parent>... </Parent>  
</Group>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|guid|Required. GUID of the GUID/ID command identifier.|  
|id|Required. ID of the GUID/ID command identifier.|  
|priority|Optional. A numeric value that specifies the priority.|  
|Condition|Optional. See [Conditional Attributes](../extensibility/vsct-xml-schema-conditional-attributes.md).|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|Parent|Optional. The parent element of the button.|  
|Annotation|Optional comment.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Groups Element](../extensibility/groups-element.md)|Contains entries that define the command groups of a VSPackage.|  
  
## Example  
  
```  
<Group guid="cmdSetGuidWidgetCommands" id="groupIDFileEdit">  
  <Parent guid="guidSHLMainMenu" id="IDM_VS_TOOL_MAINMENU"/>  
</Group>  
```  
  
## See Also  
 [Visual Studio Command Table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
