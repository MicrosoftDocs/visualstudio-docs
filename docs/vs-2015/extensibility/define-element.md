---
title: "Define Element | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "VSCT XML schema elements, Define"
  - "Define element (VSCT XML schema)"
ms.assetid: 5aee74e3-de41-4dc6-9618-93e158af56dd
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# Define Element
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Defines a symbol name and value pair. This symbol can be evaluated by conditional attributes. For more information, see [Conditional Attributes](../extensibility/vsct-xml-schema-conditional-attributes.md). See also the [Symbols Element](../extensibility/symbols-element.md).  
  
## Syntax  
  
```  
<Define name="Mode" value="Standard" />  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|name|Required. The name of the symbol:<br /><br /> name="Mode"|  
|value|Required. The value of the symbol:<br /><br /> value="Standard"|  
|Condition|Optional. For more information, see [Conditional Attributes](../extensibility/vsct-xml-schema-conditional-attributes.md).|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[CommandTable Element](../extensibility/commandtable-element.md)|Defines all the elements that represent commands that a VSPackage provides to the integrated development environment (IDE). For example, menu items, menus, toolbars, and combo boxes.|  
  
## Example  
  
```  
<Define name="DEMO_UI"/>  
<Define name="MODE" value="Standard"/>  
```  
  
## See Also  
 [Visual Studio Command Table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
