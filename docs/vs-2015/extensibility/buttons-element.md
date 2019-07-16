---
title: "Buttons Element | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "Buttons element (VSCT XML schema)"
  - "VSCT XML schema elements, Buttons"
ms.assetid: 9f2cf94d-dec5-4776-a836-9a89c75f0c87
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# Buttons Element
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Groups [Button](../extensibility/button-element.md) elements, which represent individual commands.  
  
## Syntax  
  
```  
<Buttons>  
  <Button>... </Button>  
  <Button>... </Button>  
</Buttons>  
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
|[Buttons Element](../extensibility/buttons-element.md)|Groups Button elements.|  
|[Button Element](../extensibility/button-element.md)|Defines a command that the user can interact with.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Commands Element](../extensibility/commands-element.md)|Represents the collection of commands on the VSPackage toolbar.|  
  
## Example  
  
```  
<Buttons>  
  <Button guid="guidMenuAndCommandsCmdSet" id="cmdidMyCommand"     priority="0x100" type="Button">  
    <Parent guid="guidMenuAndCommandsCmdSet" id="MyMenuGroup"/>  
    <Icon guid="guidGenericCmdBmp" id="bmpArrow"/>  
    <Strings>  
      <ButtonText>C# Command Sample</ButtonText>  
    </Strings>  
  </Button>  
</Buttons>  
```  
  
## See Also  
 [How VSPackages Add User Interface Elements](../extensibility/internals/how-vspackages-add-user-interface-elements.md)   
 [Commands, Menus, and Toolbars](../extensibility/internals/commands-menus-and-toolbars.md)
