---
title: "Symbols Element"
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
  - "Symbols element (VSCT XML schema)"
  - "VSCT XML schema elements, Symbols"
ms.assetid: 1cda43d8-42a5-4b1b-a3c8-cf0401c3202f
caps.latest.revision: 7
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
# Symbols Element
Defines GUIDs and IDs that are used by other VSCT elements. For unmanaged code, this information typically comes from the header files that are specified by [Extern Element](../extensibility/extern-element.md). Managed code uses the child elements of the Symbols element to define this information.  
  
 If you create a .vsct file from an existing .cto file, the symbols will be generated as children of the Symbols element. For more information, see [How to: Create a .Vsct File from an Existing .Cto File](../misc/how-to--create-a-.vsct-file-from-an-existing-.cto-file.md).  
  
 The Symbols element should not be confused with the [Define Element](../extensibility/define-element.md), which defines name-value pairs for use by the preprocessor.  
  
## Syntax  
  
```  
<Symbols>  
  <GuidSymbol>... </GuidSymbol>  
  <GuidSymbol>... </GuidSymbol>  
</Symbols>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|None||  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|GuidSymbol|Defines a GUID symbol. GuidSymbol has two required attributes: name and value. The name is the name of the symbol, and the value is the value of the GUID as a string.<br /><br /> For example:\<GuidSymbol name="guidVsPackage1Pkg"   value="{c5f54698-101a-4846-84d3-dc748f9cd848}" />|  
|IDSymbol|Defines a symbol. IDSymbol has two required attributes: name and value. The name is the name of the symbol, and the value is the value of the symbol as a string.<br /><br /> For example:\<IDSymbol name="MyMenuGroup" value="0x1020" />|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[CommandTable Element](../extensibility/commandtable-element.md)|The root element of the .vsct file.|  
  
## Example  
  
```  
<Symbols>  
  <GuidSymbol name="guidVsPackage1Pkg" value="{c5f54698-101a-4846-84d3-dc748f9cd848}" />  
  <GuidSymbol name="guidVsPackage1CmdSet" value="{cb9dfd7f-2fcc-4a3e-aae8-f7fe30b1cfac}">  
    <IDSymbol name="MyMenuGroup" value="0x1020" />  
    <IDSymbol name="cmdidMyCommand" value="0x0100" />  
    <IDSymbol name="cmdidMyTool" value="0x0101" />  
  </GuidSymbol>  
</Symbols>  
```  
  
## See Also  
 [Visual Studio Command Table (.Vsct) Files](../extensibility/visual-studio-command-table--.vsct--files.md)