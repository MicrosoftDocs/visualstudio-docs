---
title: CommandTable Element
description: CommandTable is the root element of the .vsct file, which defines the layout and type of the commands that a VSPackage provides to the IDE.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- CommandTable
helpviewer_keywords:
- CommandTable element (VSCT XML schema)
- VSCT XML schema elements, CommandTable
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# CommandTable element

CommandTable is the root element of the *.vsct* file. This is the file that defines the actual layout and type of the commands that a VSPackage provides to the IDE. Commands may include menu items, menus, toolbars, and combo boxes. For more information, see [Visual Studio command table (.vsct) files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md).

## Syntax

```xml
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

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

| Attribute | Description |
|-----------| - |
| xmlns | Required. XML namespaces:<br /><br /> `xmlns=http://schemas.microsoft.com/VisualStudio/2005-10-18/CommandTable`<br /><br /> xmlns:xs="<http://www.w3.org/2001/XMLSchema>" |
| language | Optional. The language attribute may be used to specify the default language of all \<Strings> elements in the command table.  If the language is not specified, the language of the current process will be used:<br /><br /> language="en-us" |

### Child Elements

|Element|Description|
|-------------|-----------------|
|[Extern element](../extensibility/extern-element.md)|Optional. Contains preprocessor directives for the compiler.|
|[Include element](../extensibility/include-element.md)|Optional. Contains paths to any files to include in the compile.|
|[Define element](../extensibility/define-element.md)|Optional. Defines a symbol given its name and value.|
|[Commands element](../extensibility/commands-element.md)|Optional. The parent element defining all the commands for the VSPackage that contains all of the other elements.|
|[CommandPlacements element](../extensibility/commandplacements-element.md)|Optional. Defines where on the command bar the commands are to be placed.|
|[VisibilityConstraints element](../extensibility/visibilityconstraints-element.md)|Optional. Determines the static visibility of commands and toolbars.|
|[KeyBindings element](../extensibility/keybindings-element.md)|Optional. Specifies the shortcut key combinations, if any, for the commands.|
|[UsedCommands element](../extensibility/usedcommands-element.md)|Optional. Allows a VSPackage to optionally implement its own version of functionality originally supported by other VSPackages.|
|[Symbols element](https://www.microsoft.com/download/details.aspx?id=55984)|Optional. Contains any symbol data -- GUIDs, IDs, and so forth -- for the compiler.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|None||

## See also
- [Visual Studio command table (.vsct) files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
