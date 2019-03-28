---
title: "Button Element | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "Buttons element (VSCT XML schema)"
  - "VSCT XML schema elements, Buttons"
ms.assetid: 96dccf51-2b00-4700-9d28-924b34c21ecd
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# Button Element
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Defines an element that the user can interact with. Buttons can be of different kinds: Button, MenuButton, and SplitDropDown.  
  
## Syntax  
  
```  
<Button guid="guidMyCommandSet" id="MyCommand" priority="0x102" type="button">  
  <Parent>... </Parent>  
  <Icon>... </Icon>  
  <CommandFlag>... </CommandFlag>  
  <Strings>... </Strings>  
</Button>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|guid|Required. GUID of the GUID/ID command identifier.|  
|id|Required. ID of the GUID/ID command identifier.|  
|priority|Optional. A numeric value that specifies the priority.|  
|type|Optional. An enumerated value that specifies the kind of button.<br /><br /> If not given, uses Button.<br /><br /> Button<br /> A standard command that appears on toolbars (typically as an iconic button), menus, and context menus.<br /><br /> MenuButton<br /> A menu item that does not execute a command, but produces another menu.<br /><br /> SplitDropDown<br /> Controls, such as the Undo and Redo buttons on the standard toolbar in Microsoft Word.|  
|Condition|Optional. See [Conditional Attributes](../extensibility/vsct-xml-schema-conditional-attributes.md).|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Parent Element](../extensibility/parent-element.md)|Optional. The parent element of the button.|  
|[Icon Element](../extensibility/icon-element.md)|Optional. The icon associated with the button.|  
|[Command Flag Element](../extensibility/command-flag-element.md)|Required. The valid CommandFlag values for a Button are as follows.<br /><br /> - AllowParams<br /><br /> - CommandWellOnly<br /><br /> - DefaultDisabled<br /><br /> - DefaultInvisible<br /><br /> - DontCache<br /><br /> - DynamicItemStart<br /><br /> - DynamicVisibility<br /><br /> - FixMenuController<br /><br /> - IconAndText<br /><br /> - NoButtonCustomize<br /><br /> - NoCustomize<br /><br /> - NoKeyCustomize<br /><br /> - NoShowOnMenuController<br /><br /> - Pict<br /><br /> - PostExec<br /><br /> - ProfferedCmd<br /><br /> - RouteToDocs<br /><br /> - TextCascadeUseBtn<br /><br /> - TextMenuUseButton<br /><br /> - TextChanges<br /><br /> - TextChangesButton<br /><br /> - TextContextUseButton<br /><br /> - TextMenuCtrlUseMenu<br /><br /> - TextMenuUseButton<br /><br /> - TextOnly|  
|[Strings Element](../extensibility/strings-element.md)|Required. The child [ButtonText Element](../extensibility/buttontext-element.md) must be defined.|  
|Annotation|Optional comment.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Buttons Element](../extensibility/buttons-element.md)|Groups Button elements.|  
  
## Example  
 The following example defines a button in a .vsct file.  
   
 ```xml
<Button guid="guidMenuTextCmdSet" id="cmdidMyCommand" priority="0x0100" type="Button">
    <Parent guid="guidMenuTextCmdSet" id="MyMenuGroup" />
    <Icon guid="guidImages" id="bmpPic1" />
    <CommandFlag>TextChanges</CommandFlag>
    <Strings>
          <CommandName>cmdidMyCommand</CommandName>
          <ButtonText>My Command name</ButtonText>
    </Strings>
</Button>
 ```

## See Also  
 [Visual Studio Command Table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
