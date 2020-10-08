---
title: "VisibilityConstraints Element | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "VisibilityConstraints"
helpviewer_keywords: 
  - "VSCT XML schema elements, VisibilityConstraints"
  - "VisibilityConstraints element (VSCT XML schema)"
ms.assetid: d6dcd314-6fe4-4693-a189-91fa026c7b34
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# VisibilityConstraints Element
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The VisibilityConstraints element determines the static visibility of groups of commands and toolbars. The visibility is first controlled by the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] integrated development environment (IDE) without loading the VSPackage.  
  
## Syntax  
  
```  
<VisibilityConstraints>  
  <VisibilityConstraint>... </VisibilityConstraint>  
  <VisibilityConstraint>... </VisibilityConstraint>  
</VisibilityConstraint>  
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
|[VisibilityItem Element](../extensibility/visibilityitem-element.md)|Determines the static visibility of commands and toolbars.|  
|[VisibilityConstraints](../extensibility/visibilityconstraints-element.md)|Determines the static visibility of groups of commands and toolbars.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[CommandTable Element](../extensibility/commandtable-element.md)|Defines all the elements that represent the commands (for example, menu items, menus, toolbars, and combo boxes) that a VSPackage provides to the IDE.|  
  
## Example  
  
```  
<VisibilityConstraints>  
  <VisibilityItem guid="cmdSetGuidMyProductCommands"     id="cmdidAddWidget"  
    context="guidNotViewSourceMode"/>  
</VisibilityConstraints>  
```  
  
## See Also  
 [VisibilityItem Element](../extensibility/visibilityitem-element.md)   
 [Visual Studio Command Table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
