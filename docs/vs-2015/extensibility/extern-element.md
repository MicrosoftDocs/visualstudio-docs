---
title: "Extern Element | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "Extern"
helpviewer_keywords: 
  - "VSCT XML schema elements, Extern"
  - "Extern element (VSCT XML schema)"
ms.assetid: db6c3ddd-a1ba-450a-897a-bb568a5377fc
caps.latest.revision: 16
ms.author: gregvanl
manager: jillfra
---
# Extern Element
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Extern element references any external header (.h) files to merge with the .vsct file at compile time. The files to be merged must be on the Include path given to the VSCT compiler or referenced by an [Include Element](../extensibility/include-element.md). The files may be other .vsct files or C++ header files.  
  
 Definitions in header files must be of the form "#define [Symbol] [Value]"  The value may be another symbol if it is previously defined. Definitions may be used in conditional statements of command items. Any symbol not actually used will be discarded.  
  
 CommandTable Element  
Extern Element  
  
## Syntax  
  
```  
<Extern href="stdidcmd.h" />  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|href|Required. The path to the header file:<br /><br /> href="stdidcmd.h"|  
|Condition|Optional. See [Conditional Attributes](../extensibility/vsct-xml-schema-conditional-attributes.md).|  
|language|Optional. The default language of all [\<Strings>](../extensibility/strings-element.md) elements in the command table:<br /><br /> language="en-us"|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|None.|None.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[CommandTable Element](../extensibility/commandtable-element.md)|Defines all of the elements that represent commands — that is, menu items, menus, toolbars, and combo boxes — that a VSPackage provides to the IDE.|  
  
## Example  
  
```  
<?xml version="1.0" encoding="utf-8"?>  
<CommandTable xmlns="http://schemas.microsoft.com/VisualStudio/2005-10-  
  18/CommandTable" xmlns:xs="http://www.w3.org/2001/XMLSchema">  
    <Extern href="C:\VSCore\vscommon\inc\vsshlids.h"/>  
    …  
  <Commands package="guidMyPackage">  
</CommandTable>  
```  
  
## See Also  
 [Visual Studio Command Table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)   
 [How VSPackages Add User Interface Elements](../extensibility/internals/how-vspackages-add-user-interface-elements.md)   
 [Commands, Menus, and Toolbars](../extensibility/internals/commands-menus-and-toolbars.md)
