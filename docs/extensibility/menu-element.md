---
title: Menu Element
description: The Menu element defines one menu item. The kinds of menu are Context, Menu, MenuController, MenuControllerLatched, Toolbar, and ToolWindowToolbar.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- VSCT XML schema elements, Menus
- Menus element (VSCT XML schema)
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Menu element

Defines one menu item. These are the six kinds of menus: Context, Menu, MenuController, MenuControllerLatched, Toolbar, and ToolWindowToolbar.

## Syntax

```xml
<Menu guid="guidMyCommandSet" id="MyCommand" priority="0x100" type="button">
  <Parent>... </Parent>
  <CommandFlag>... </CommandFlag>
  <Strings>... </Strings>
</Menu>
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|guid|Required. GUID of the GUID/ID command identifier.|
|id|Required. ID of the GUID/ID command identifier.|
|priority|Optional. A numeric value that specifies the relative position of a menu in a group of menus.|
|toolbarPriorityInBand|Optional. A numeric value that specifies the relative position of a toolbar in a band when the window is docked.|
|type|Optional. An enumerated value that specifies the kind of element.<br /><br /> If not present, the default type is Menu.<br /><br /> Context<br /> A shortcut menu that is shown when a user right-clicks a window. A shortcut menu has the following characteristics:<br /><br /> -   Does not use the **Parent** and **Priority** fields when the menu is to be displayed as a shortcut menu.<br />-   Can be used as a submenu and also as a shortcut menu. In this case, both **Group ID** and **Priority** fields are respected.<br />-   Is not always available.<br /><br /> A shortcut menu is displayed only when the following conditions are true:<br /><br /> -   The window that hosts it is displayed.<br />-   A mouse handler in the VSPackage detects a right-click on the window and then calls a method that handles the command.<br />-   The shortcut menu is displayed by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IOleComponentUIManager.ShowContextMenu%2A> method (the recommended approach) or the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.ShowContextMenu%2A> method.<br /><br /> Menu<br /> Provides a drop-down menu. A drop-down menu has the following characteristics:<br /><br /> -   Respects the Parent in its definition.<br />-   Must have a Parent group, or a CommandPlacement to a group.<br />-   Can be a submenu in any other kind of menu.<br />-   Is automatically displayed whenever its parent menu is displayed.<br />-   Does not require the implementation of any VSPackage code to make it displayed.<br /><br /> MenuController<br /> Provides a split-button drop-down menu, which is typically used in toolbars. A MenuController menu has the following characteristics:<br /><br /> -   Must be contained in another menu through Parent or CommandPlacement.<br />-   Respects the Parent in its definition.<br />-   Can have any kind of menu as its parent.<br />-   Is automatically made available whenever its parent menu is displayed.<br />-   Does not require programmatic support to make the menu displayed.<br /><br /> A command from the split-button menu is displayed on the menu button. The command displayed has one of the following characteristics:<br /><br /> -   It is the last command that was used if the command is still displayed and enabled.<br />-   It is the first displayed command.<br /><br /> MenuControllerLatched<br /> Provides a split-button drop-down menu for which a command can be specified as the default selection by marking the command as latched.<br /><br /> A latched command is a command that is marked in the menu as selected, typically by displaying a check mark. A command can be marked as latched if it has the OLECMDF_LATCHED flag set on it in an implementation of the `QueryStatus` method of the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface. A MenuControllerLatched menu has the following characteristics:<br /><br /> -   Must be contained in another menu through a Parent group or CommandPlacement.<br />-   Respects the Parent in its definition.<br />-   Can have any kind of menu as its parent.<br />-   Is made available whenever its parent menu is displayed.<br />-   Does not require programmatic support to make the menu displayed.<br /><br /> A command from the split-button menu is displayed on the menu button. The command displayed has one of the following characteristics:<br /><br /> -   It is the first displayed command that is latched.<br />-   It is the first displayed command.<br /><br /> Toolbar<br /> Provides a toolbar. A toolbar has the following characteristics:<br /><br /> -   Ignores the Parent in its definition.<br />-   Cannot be made a submenu of any group, not even by using CommandPlacement.<br />-   Can always be displayed by clicking **Toolbars** on the **View** menu.<br />-   Can be displayed by using a [VisibilityItem](../extensibility/visibilityitem-element.md).<br />-   Does not require any code to create it. For an example about how to create a toolbar, see [Add a toolbar](../extensibility/adding-a-toolbar.md).<br /><br /> ToolWindowToolbar<br /> Provides a toolbar that is attached to a specific tool window, just as a toolbar is attached to the development environment.<br /><br /> -   Ignores the Parent in its definition.<br />-   Cannot be made a submenu of any group, not even by using CommandPlacement.<br />-   Is displayed only when the tool window that hosts the toolbar is displayed and the VSPackage explicitly adds the toolbar to the tool window. This is typically done when the tool window is created by obtaining the toolbar host property (as represented by the <xref:Microsoft.VisualStudio.Shell.Interop.IVsToolWindowToolbarHost> interface) from the tool window frame and then calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsToolWindowToolbarHost.AddToolbar%2A> method.|
|Condition|Optional. See [Conditional attributes](../extensibility/vsct-xml-schema-conditional-attributes.md).|

### Child elements

|Element|Description|
|-------------|-----------------|
|Parent|Optional. The parent element of the menu item.|
|CommandFlag|Required. See [Command flag element](../extensibility/command-flag-element.md). The valid CommandFlag values for a Menu are as follows:<br /><br /> -   **AlwaysCreate**<br />-   **DefaultDocked**<br />-   **DefaultInvisible** - This flag does not affect the display of toolbars.<br />-   **DontCache**<br />-   **DynamicVisibility** - This flag does not affect the display of toolbars.<br />-   **IconAndText**<br />-   **NoCustomize**<br />-   **NotInTBList**<br />-   **NoToolbarClose**<br />-   **TextChanges**<br />-   **TextIsAnchorCommand**|
|Strings|Required. See [Strings element](../extensibility/strings-element.md). The child `ButtonText` element must be defined.|
|Annotation|Optional comment.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[Menus element](../extensibility/menus-element.md)|Defines all the menus that a VSPackage implements.|

## Example

```
<Menu guid="cmdGuidWidgetCommands" id="menuIDEditWidget"
  priority="0x0002" type="Menu">
  <Parent guid="cmdSetGuidWidgetCommands" id="groupIDFileEdit"/>
  <CommandFlag>AlwaysCreate</CommandFlag>
  <Strings>
    <ButtonText>Edit Widget</ButtonText>
  </Strings>
</Menu>
```

## See also
- [Visual Studio command table (.vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
