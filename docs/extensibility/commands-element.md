---
title: "Commands Element | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "Commands"
helpviewer_keywords: 
  - "Commands element (VSCT XML schema)"
  - "VSCT XML schema elements, Commands"
ms.assetid: 47cf16a5-d78b-452e-86f6-b5893856dddf
caps.latest.revision: 17
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
# Commands Element
Represents the collection of commands on the VSPackage toolbar. The collection can have up to five subsections, as follows: menus, groups, buttons, combos, and bitmaps.  
  
 Each subsection child element, for example, \<Menu>, is identified by a unique command ID that is a GUID and numeric identifier pair. The GUID identifies the "command set" and is used to group logically related commands. The VSPackage should define its own command set to avoid collisions with command IDs that are defined by other VSPackages.  
  
## Syntax  
  
```  
<Commands package="GuidMyPackage" >  
  <Menus>... </Menus>  
  <Groups>... </Groups>  
  <Buttons>... </Buttons>  
  <Combos>... </Combos>  
  <Bitmaps>... </Bitmaps>  
</Commands>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|package|A GUID that identifies the VSPackage that provides the commands.<br /><br /> For example, package="guidVsPackage1Pkg".|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Menus Element](../extensibility/menus-element.md)|Defines all the menus that a VSPackage implements.|  
|[Groups Element](../extensibility/groups-element.md)|Contains entries that define the command groups in a VSPackage.|  
|[Buttons Element](../extensibility/buttons-element.md)|Groups Button elements.|  
|[Bitmaps Element](../extensibility/bitmaps-element.md)|Groups Bitmap elements.|  
|[Combos Element](../extensibility/combos-element.md)|Groups Combo elements.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[CommandTable Element](../extensibility/commandtable-element.md)|Defines all the elements that represent the commands that a VSPackage provides to the IDE. Possible elements are menu items, menus, toolbars, and combo boxes.|  
  
## Example  
 The following example shows how to use a [Commands Element](../extensibility/commands-element.md).  
  
```  
<Commands package="guidMyPackage">  
    <Menus>  
      <Menu Condition="'%(DEBUG)' != 'true'"   
        guid="cmdSetGuidMyProductCommands" id="menuIDMainMenu"   
        priority="0x0000" type="Menu">  
        <Annotation>  
          <Documentation>this is an annotation</Documentation>  
          <AppInfo>  
            <CustomData>  
              <CustomSubElement>Some data</CustomSubElement>  
            </CustomData>  
          </AppInfo>  
        </Annotation>  
        <CommandFlag>AlwaysCreate</CommandFlag>  
        <Strings>  
          <ButtonText>MainMenu</ButtonText>  
        </Strings>  
      </Menu>  
  </Menus>  
<Commands>  
```  
  
## See Also  
 [How VSPackages Add User Interface Elements](../extensibility/internals/how-vspackages-add-user-interface-elements.md)   
 [Commands, Menus, and Toolbars](../extensibility/internals/commands-menus-and-toolbars.md)