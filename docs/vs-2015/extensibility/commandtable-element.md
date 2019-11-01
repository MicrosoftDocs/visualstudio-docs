---
title: "CommandTable Element | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "CommandTable"
helpviewer_keywords: 
  - "CommandTable element (VSCT XML schema)"
  - "VSCT XML schema elements, CommandTable"
ms.assetid: 15c38159-660a-4ef4-9643-aa6fcfca82a9
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# CommandTable Element
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

CommandTable is the root element of the .vsct file. This is the file that defines the actual layout and type of the commands that a VSPackage provides to the IDE. Commands may include menu items, menus, toolbars, and combo boxes. For more information, see [Visual Studio Command Table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md).  
  
## Syntax  
  
```  
<CommandTable xmlns="http://schemas.microsoft.com/VisualStudio/2005-10-18/CommandTable" xmlns:xs="http://www.w3.org/2001/XMLSchema" >  
  <Extern>... </Extern>  
  <Include>... </Include>  
  <Define>... </Define>  
  <Commands>... </Commands>  
  <CommandPlacements>... </CommandPlacements>  
  <VisibilityConstraints>... </VisibilityConstraints>  
  <KeyBindings>... </KeyBindings>  
  <UsedCommands... </UsedCommands>  
  <Symbols>... </Symbols>  
</CommandTable>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
| Attribute |                                                                                                                   Description                                                                                                                   |
|-----------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|   xmlns   |                                   Required. XML namespaces:<br /><br /> xmlns="<http://schemas.microsoft.com/VisualStudio/2005-10-18/CommandTable>"<br /><br /> xmlns:xs="<http://www.w3.org/2001/XMLSchema>"                                   |
| language  | Optional. The language attribute may be used to specify the default language of all \<Strings> elements in the command table.  If the language is not specified, the language of the current process will be used:<br /><br /> language="en-us" |
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Extern Element](../extensibility/extern-element.md)|Optional. Contains preprocessor directives for the compiler.|  
|[Include Element](../extensibility/include-element.md)|Optional. Contains paths to any files to include in the compile.|  
|[Define Element](../extensibility/define-element.md)|Optional. Defines a symbol given its name and value.|  
|[Commands Element](../extensibility/commands-element.md)|Optional. The parent element defining all the commands for the VSPackage that contains all of the other elements.|  
|[CommandPlacements Element](../extensibility/commandplacements-element.md)|Optional. Defines where on the command bar the commands are to be placed.|  
|[VisibilityConstraints Element](../extensibility/visibilityconstraints-element.md)|Optional. Determines the static visibility of commands and toolbars.|  
|[KeyBindings Element](../extensibility/keybindings-element.md)|Optional. Specifies the shortcut key combinations, if any, for the commands.|  
|[UsedCommands Element](../extensibility/usedcommands-element.md)|Optional. Allows a VSPackage to optionally implement its own version of functionality originally supported by other VSPackages.|  
|[Symbols Element](https://msdn.microsoft.com/f2ddd0aa-c3dd-439e-834d-28f136a27ffa)|Optional. Contains any symbol data -- GUIDs, IDs, and so forth -- for the compiler.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|None||  
  
## See Also  
 [Visual Studio Command Table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
