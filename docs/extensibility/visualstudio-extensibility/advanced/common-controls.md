---
title: Common controls
description: Learn about the common controls available in Visual Studio.
ms.date: 10/15/2026
ms.topic: reference
helpviewer_keywords:
- controls
- ui
- ux
author: jasonchlus
ms.author: ansarrat
ms.subservice: extensibility-integration
monikerRange: visualstudio
---
# Common controls

Visual Studio provides a set of common controls that can be used in Visual Studio extensions. These controls are designed to provide a consistent user experience and integrate seamlessly with the Visual Studio environment. They offer built-in theme support, extended accessibility, as well as offering more types of controls than the base WPF controls.

When writing UI for Visual Studio, it is recommended to use these controls instead of the base WPF controls, and to avoid writing custom controls whenever possible. Additionally, exposed properties related to colors or corner radii are provided for edge cases but generally should not be changed from the default values.

This reference covers the common controls in Visual Studio 2026 version 18.12. The controls are provided by `Microsoft.VisualStudio.Shell.Styles`, which is included in the Visual Studio SDK meta package.

The list of available common controls is provided below, and samples can be found in the [VS Extensibility Samples ↗](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples).

## AccessText

`AccessText` is a Visual Studio-styled version of the WPF `AccessText` control that displays text with an access-key indicator and has a selectable text appearance. This control should typically be used in modal dialogs to facilitate quick navigation to interaction targets.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| Kind | `TextKind` | No | Selects the themed visual appearance of the text. Set it to a `TextKind` value to choose the corresponding appearance; its font size scales relative to the Visual Studio environment font size. |

### Commands

No additional commands are declared.

### Methods

No additional methods are declared.

### Events

No additional events are declared.

## BottomCurvedBorder

`BottomCurvedBorder` is a Visual Studio-styled border that renders the curved treatment along the bottom edge of a surface. This control is used by shell UI and generally should not be used by extender UI.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## Breadcrumb

`Breadcrumb` presents a navigable sequence of location items and can move excess items into an overflow menu. This control should typically be used when navigating through a hierarchy of locations, such as file paths or nested headers.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| HasOverflowItems | `bool` | Yes | Indicates whether items are currently shown in the overflow menu; read this to determine whether overflow is present. |
| IsInteractive | `bool` | No | Enables or disables interaction with breadcrumb items. |
| IsOverflowOpen | `bool` | No | Gets or sets whether the overflow menu is open. |
| Kind | `TextKind` | No | Sets the text appearance used by the breadcrumb; choose a `TextKind` value to match the surrounding text hierarchy, its font size scales relative to the Visual Studio environment font size. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## BreadcrumbItem

`BreadcrumbItem` represents one location in a `Breadcrumb` sequence. The control derives from `Button` and when the breadcrumb is interactive, the item can be clicked to navigate to the represented location.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| ContentWidth | `double` | Yes | Gets the calculated width of the item's content; use it when measuring or arranging breadcrumb items. |
| IsInteractive | `bool` | No | Gets or sets whether the item supports interaction. |
| IsLastItem | `bool` | No | Gets or sets whether this item represents the final location in the breadcrumb. |
| IsOverflowItem | `bool` | No | Gets or sets whether this item is presented in the breadcrumb overflow menu. |
| Kind | `TextKind` | No | Gets or sets the item's text appearance. |
| Text | `string` | No | Gets or sets the location text displayed by the item. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## Button

`Button` is a Visual Studio-styled version of the WPF `Button` control with configurable visual kind and corner shape. This control should typically be used for simple actions that can be invoked by the user.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| CornerRadius | `CornerRadius` | No | Sets the button's corner rounding to fit the surrounding UI. |
| Kind | `ButtonKind` | No | Selects the button's visual treatment; choose the kind appropriate for the action's emphasis. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## Callout

`Callout` is a popup surface for presenting contextual content near a placement target and points at the target. This control should typically be used to display additional information related to a specific UI element without taking focus from other UI elements.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| PreferredPlacement | `PlacementMode` | No | Sets the preferred position relative to the placement target. Supports only `Bottom`, `Right`, `Left`, or `Top`. |

### Commands

No commands are declared.

### Methods

| Name | Returns | Remarks |
| --- | --- | --- |
| Callout() | — | Constructs a callout that can be configured and displayed relative to a placement target. |

### Events

No events are declared.

## CalloutSurface

`CalloutSurface` provides the surface and pointer configuration used to render a callout.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| PointerAlignment | `Dock?` | No | Sets the pointer's alignment along the callout surface; use it to position the pointer relative to the surface edge. |
| PointerPlacement | `PlacementMode?` | No | Sets the pointer placement; use it to indicate which side of the callout points toward its target. Supports only `Bottom`, `Right`, `Left`, or `Top`. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## CheckableComboBox

`CheckableComboBox` is a `ComboBox`-like control that allows users to select multiple items using checkboxes. The control has built-in 'select all' support and mostly behaves like a standard `ComboBox`. This control should typically be used when multiple selections can be made from a set of options, such as a flag enumeration or font style options.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| CornerRadius | `CornerRadius` | No | Sets the corner rounding of the control. |
| HasSelectedItems | `bool` | Yes | Indicates whether the current selection contains any items. |
| IsDropDownOpen | `bool` | No | Gets or sets whether the item dropdown is open. |
| ItemContainerStyle | `Style` | No | Supplies the style applied to generated item containers. |
| ItemsSource | `IList` | No | Supplies the collection from which the selectable items are generated. |
| ItemTemplate | `DataTemplate` | No | Supplies the template used to display each item. |
| MaxDropDownHeight | `double` | No | Sets the maximum height of the open dropdown. |
| NoSelectionText | `string` | No | Sets the text displayed when no items are selected. |
| Placement | `PlacementMode` | No | Sets where the dropdown is placed relative to the control. Supports only `Bottom`, `Right`, `Left`, or `Top`. |
| SelectedItems | `IList` | No | Gets or sets the selected items; bind or assign this collection to work with the multiple selection. |
| SelectionText | `string` | No | Gets or sets the text representing the current selection. |

### Commands

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| SelectAllCommand | `ICommand` | Yes | Gets the command that selects every available item; bind or invoke it to provide a select-all action. |

### Methods

| Name | Returns | Remarks |
| --- | --- | --- |
| CheckableComboBox() | — | Constructs a checkable dropdown for selecting multiple items. |

### Events

| Name | Handler Type | Remarks |
| --- | --- | --- |
| DropDownClosed | `RoutedEventHandler` | Sent when the dropdown closes; handle it to respond after the user dismisses the list. |
| SelectionChanged | `SelectionChangedEventHandler` | Sent when the selected items change; handle it to update dependent UI or data. |

## CheckableComboBoxItem

`CheckableComboBoxItem` represents an item container in a checkable combobox.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## CheckableTreeView

`CheckableTreeView` is a tree view whose items support checkable selection. The control does not automatically propagate checked state to descendants or ancestors. This control should typically be used when a hierarchical selection is needed, such as enabling/disabling nested categories.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## CheckableTreeViewItem

`CheckableTreeViewItem` is an item container in a checkable tree view and exposes its checked state.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| IsChecked | `bool?` | No | Gets or sets whether the item is checked; `null` represents an indeterminate state, useful when descendant selections are mixed. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## CheckBox

`CheckBox` is a Visual Studio-styled version of the WPF `CheckBox` control for a user-controlled boolean or tri-state choice. This control should typically be used when a user can enable or disable a single option, or when a tri-state choice is needed.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## CodeBlock

`CodeBlock` represents a fenced or block-level code element in content rendered by `MarkdownViewer`. This control generally should not be used and exists to allow styling of code blocks in the markdown renderer.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## CodeInline

`CodeInline` represents an inline code span in content rendered by `MarkdownViewer`. This control generally should not be used and exists to allow styling of inline code blocks in the markdown renderer.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## ColorCard

`ColorCard` displays a color as a selectable or presentational card in color-selection UI. This control should typically be used when presenting a color.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| AllowsTransparency | `bool` | No | Enables or disables transparent colors for this card. |
| Color | `Color` | No | Gets or sets the color represented by the card. |
| IsSplitView | `bool` | No | Enables or disables the split-view presentation of the color. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## ColorPicker

`ColorPicker` lets users choose a color and edit its color-channel or HSL components. This control should typically be used when a user can select or edit a color.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| AllowsAlpha | `bool` | No | Enables editing of the alpha channel when transparency should be configurable. |
| ChannelAlpha | `byte` | No | Gets or sets the alpha channel value. |
| ChannelBlue | `byte` | No | Gets or sets the blue channel value. |
| ChannelGreen | `byte` | No | Gets or sets the green channel value. |
| ChannelRed | `byte` | No | Gets or sets the red channel value. |
| Color | `Color` | No | Gets or sets the selected color; use this when working with the color as a single value. |
| ColorBrush | `Brush` | Yes | Gets a brush representing the selected color for use in display or rendering. |
| Hue | `double` | No | Gets or sets the hue component of the selected color. |
| Luminosity | `double` | No | Gets or sets the luminosity component of the selected color. |
| Saturation | `double` | No | Gets or sets the saturation component of the selected color. |
| Transparency | `double` | No | Gets or sets the transparency component of the selected color. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## ComboBox

`ComboBox` is a Visual Studio-styled version of the WPF `ComboBox` control for choosing an item, with optional hint text and placement configuration. This control should typically be used when a user can select one item from a set of options.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| CornerRadius | `CornerRadius` | No | Sets the corner rounding of the control. |
| HintText | `string` | No | Sets the hint displayed when the combobox has no value. |
| Placement | `PlacementMode` | No | Sets where the dropdown is placed relative to the combobox. Supports only `Bottom`, `Right`, `Left`, or `Top`. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## ComboBoxItem

`ComboBoxItem` is a Visual Studio-styled version of the WPF `ComboBoxItem` control for an entry in a combobox.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## CommandingContextMenuHost

`CommandingContextMenuHost` hosts a VSCT-based context menu associated with Visual Studio command routing. This control should typically be used if a VSCT context menu needs to be tied to a piece of UI.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| CommandGuid | `Guid` | No | Sets the identifier of the command set associated with the menu. |
| CommandId | `int` | No | Sets the command identifier used with the command set. |
| CommandTarget | `IOleCommandTarget` | No | Sets the command target that handles the associated command. |
| IsClosed | `bool` | Yes | Indicates whether the context menu host has closed. |
| IsOpen | `bool` | No | Gets or sets whether the context menu is open. |
| Placement | `PlacementMode` | No | Sets the menu's placement mode. Supports only `Bottom`, `Right`, `Left`, or `Top`. |
| PlacementTarget | `FrameworkElement` | No | Sets the element relative to which the menu is placed. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## ContextMenu

`ContextMenu` is a Visual Studio-styled version of the WPF `ContextMenu` control for actions associated with a region or item. This control should typically be used when a user can invoke actions related to a specific UI element, such as right-clicking on a file to see available operations.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| IsClosed | `bool` | Yes | Indicates whether the context menu has closed; read it to determine whether it remains displayed. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## CopyButton

`CopyButton` is a button that provides a copy affordance and supports configurable placement and text display. This control should typically be used when a user can copy content to the clipboard, such as copying a file path, code snippet, or message.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| Placement | `PlacementMode` | No | Sets where the copy affordance is placed relative to its target. Supports only `Bottom`, `Right`, `Left`, or `Top`. |
| ShowText | `bool` | No | Controls whether the button displays text along with its affordance. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## CurvedBorderBase

`CurvedBorderBase` is the base for curved border controls and exposes the geometries used to render their background and outline. This control is used by shell UI and generally should not be used by extender UI.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| BackgroundGeometry | `Geometry?` | Yes | Gets the geometry used to render the border background. |
| BorderGeometry | `Geometry?` | Yes | Gets the geometry used to render the border outline. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## DataGrid

`DataGrid` is a Visual Studio-styled version of the WPF `DataGrid` control for displaying and editing data in rows and columns. This control should typically be used when a user can view and manipulate tabular data, such as settings.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## DataGridCheckableComboBoxColumn

`DataGridCheckableComboBoxColumn` is a column control that presents checkable comboboxes in its cells.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| ItemContainerStyle | `Style` | No | Sets the style applied to generated combobox item containers. |
| ItemsSource | `IList` | No | Supplies the list of items shown by the comboboxes in this column. |
| NoSelectionTextBinding | `BindingBase` | No | Binds the text displayed when a cell has no selected items. |
| SelectedItemsBinding | `BindingBase` | No | Binds the selected items for each cell. |
| SelectionTextBinding | `BindingBase` | No | Binds the text displayed for the current selection in each cell. |

### Commands

No commands are declared.

### Methods

| Name | Returns | Remarks |
| --- | --- | --- |
| DataGridCheckableComboBoxColumn() | — | Constructs a datagrid column that presents checkable comboboxes. |

### Events

No events are declared.

## DataGridCheckBoxColumn

`DataGridCheckBoxColumn` is a Visual Studio-styled version of the WPF `DataGridCheckBoxColumn` control that presents a checkbox in its cells.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## DataGridComboBoxColumn

`DataGridComboBoxColumn` is a Visual Studio-styled version of the WPF `DataGridComboBoxColumn` control that presents a combobox in its cells.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| IsEditable | `bool` | No | Controls whether users can edit text in the combobox cells. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## DataGridHyperlinkColumn

`DataGridHyperlinkColumn` is a Visual Studio-styled version of the WPF `DataGridHyperlinkColumn` control that presents a hyperlink in its cells.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| CommandBinding | `BindingBase` | No | Binds the command executed by a hyperlink in the column. |
| CommandParameterBinding | `BindingBase` | No | Binds the parameter passed to the hyperlink command. |

### Commands

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| DefaultCommand | `ICommand` | Yes | Gets the default command used by hyperlinks in the column. |

### Methods

No methods are declared.

### Events

No events are declared.

## DataGridTextColumn

`DataGridTextColumn` is a Visual Studio-styled version of the WPF `DataGridTextColumn` control that presents text in its cells.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## DialogButton

`DialogButton` represents a button associated with a dialog and its result. This control should typically be used in the footer of a dialog when presenting action buttons, such as "OK" and "Cancel".

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| MessageButtons | `MessageBoxButton` | No | Gets or sets the dialog action associated with this button. |
| ResultKind | `MessageBoxResult` | No | Gets or sets the dialog result represented by this button. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## DialogWindow

`DialogWindow` represents a window for presenting content as a modal dialog. The control has support for a basic standard layout, but can be customized to present any content. Do not call `ShowDialog()` with this control; use `ShowModal()` instead. This control should typically be used for short input actions from users, displaying information the user needs to acknowledge, or information features or status.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| DialogContent | `object` | No | Gets or sets the content displayed in the dialog. |
| Moniker | `ImageMoniker` | No | Gets or sets the dialog window icon. |

### Commands

No commands are declared.

### Methods

| Name | Returns | Remarks |
| --- | --- | --- |
| DialogWindow() | — | Constructs a dialog window to configure and display. |
| ShowModal() | `bool?` | Displays the dialog modally and returns its nullable Boolean result. |

### Events

No events are declared.

## DropDownButton

`DropDownButton` is a button that displays additional content in a dropdown when clicked. This control should typically be used when a user can select from several options but none of them are a default action, such as inline settings toggles or supplemental actions.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| DropDown | `object` | No | Gets or sets the content shown in the dropdown. Supports only `Popup`, `ContextMenu`, or `CommandingContextMenuHost`. |
| Placement | `PlacementMode` | No | Sets where the dropdown is placed relative to the button. Supports only `Bottom`, `Right`, `Left`, or `Top`. |
| ShowDropDownGlyph | `bool` | No | Controls whether the dropdown glyph is displayed. |

### Commands

No commands are declared.

### Methods

| Name | Returns | Remarks |
| --- | --- | --- |
| ShowDropDown() | `void` | Opens the button's dropdown content. |

### Events

No events are declared.

## EmphasisInline

`EmphasisInline` represents an emphasized inline span in content rendered by `MarkdownViewer`. This control generally should not be used and exists to allow styling of emphasis spans in the markdown renderer.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| DelimiterCharacter | `char` | No | Gets or sets the character used to delimit the emphasis span. |
| DelimiterCount | `int` | No | Gets or sets the number of delimiter characters used for the span. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## Expander

`Expander` is a Visual Studio-styled version of the WPF `Expander` control that reveals or hides content under a header. This control should typically be used when a user can expand or collapse a section of content, such as advanced settings or additional details.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| HeaderHeight | `double` | Yes | Gets the height of the expander header for layout or measurement. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## FeedbackPanel

`FeedbackPanel` presents feedback UI and exposes feedback state and actions for submitting feedback or a vote. This control should typically be used to request user feedback on a feature, such as reporting an issue or voting on a suggestion.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| Feedback | `Feedback` | Yes | Gets the current feedback value for display or processing. |

### Commands

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| TellUsMoreCommand | `ICommand` | Yes | Gets the command used to submit additional feedback; bind it to a control that offers a follow-up feedback action. |
| VoteCommand | `ICommand` | Yes | Gets the command used to submit a vote; bind it to the voting action in the panel. |

### Methods

No methods are declared.

### Events

No events are declared.

## FilterableComboBox

`FilterableComboBox` is a `ComboBox`-derived control with a filter input in the dropdown for narrowing the available items. It will always show the selected item regardless of the filter. This control should typically be used when a user can select one item from a large set of options, and filtering is needed to quickly find the desired item.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| FilterHintText | `string` | No | Sets the hint shown in the filter input. |
| FilterText | `string` | No | Gets or sets the text used to filter the items. |
| FilterMemberPath | `string` | No | Sets the item property path used as the filtering text. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## FlyoutSurface

`FlyoutSurface` provides a "floating" surface with a drop shadow for showing flyout content. This control should typically be used to present additional content as floating above other content. Extender UI should generally use the existing popup-like controls to get this behavior, but the control exists separately to allow use in adornment layers or for other popup-like scenarios not covered by the existing common controls.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## Heading

`Heading` represents a heading element in content rendered by `MarkdownViewer`. This control generally should not be used and exists to allow styling of headings in the markdown renderer.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| Level | `int` | No | Gets or sets the heading level used to represent the heading's position in the document hierarchy. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## Hyperlink

`Hyperlink` is a Visual Studio-styled version of the WPF `Hyperlink` control with a configurable label. This control should typically be used to display a hyperlink inside text or document content.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| Text | `string` | No | Gets or sets the text displayed for the hyperlink. |

### Commands

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| DefaultCommand | `ICommand` | Yes | Gets the command invoked by the hyperlink, sends the hyperlink uri to Windows to handle. |

### Methods

No methods are declared.

### Events

No events are declared.

## HyperlinkButton

`HyperlinkButton` is a `Button`-derived control styled as a hyperlink, with optional icon and configurable accessibility type reporting. This control should typically be used when a user can invoke an action that is represented as a hyperlink, such as navigating away from the current UI.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| CornerRadius | `CornerRadius` | No | Sets the button's corner rounding. |
| Moniker | `ImageMoniker` | No | Sets the icon displayed by the button. |
| ReportAsButton | `bool` | No | Controls whether UI automation reports the control as a button. |
| Text | `string` | No | Sets the text displayed by the button. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## ImageButton

`ImageButton` is a `Button`-derived control that displays an image moniker and optional text in a configurable layout. This control should typically be used when a user can invoke an action represented by an image or image and simple text, such as a toolbar button or an action with a visual affordance.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| ImageHeight | `double` | No | Sets the displayed image height. |
| ImageWidth | `double` | No | Sets the displayed image width. |
| Moniker | `ImageMoniker` | No | Sets the image shown by the button. |
| Orientation | `Orientation` | No | Sets the relative layout direction of the image and text. |
| Text | `string` | No | Sets the text displayed with the image. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## Indicator

`Indicator` displays a visual indicator with a configurable orientation. This control should typically be used when a user needs a visual representation of selection.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| Orientation | `Orientation` | No | Sets the indicator's orientation to fit the layout in which it appears. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## Label

`Label` is a Visual Studio-styled version of the WPF `Label` control with a selectable text appearance. This control should typically be used to display text that labels or describes another UI element, such as a form field or a section of content.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| Kind | `TextKind` | No | Sets the visual text style; choose the kind that matches the text's role in the UI. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## List

`List` represents a list element in content rendered by `MarkdownViewer`. This control generally should not be used and exists to allow styling of lists in the markdown renderer.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## ListBox

`ListBox` is a Visual Studio-styled version of the WPF `ListBox` control for displaying and selecting from a list of items. This control should typically be used when a user can select one or more items from a list, such as a list of files.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## ListBoxItem

`ListBoxItem` is a Visual Studio-styled version of the WPF `ListBoxItem` control for an entry in a list box.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## ListItem

`ListItem` represents an individual item in a list rendered by `MarkdownViewer`. This control generally should not be used and exists to allow styling of list items in the markdown renderer.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## ListView

`ListView` is a Visual Studio-styled version of the WPF `ListView` control for displaying a collection of items in a configurable view. Do not use the GridView property of this control. This control should typically be used when a user can select one or more items from a list, such as a list of files.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## ListViewItem

`ListViewItem` is a Visual Studio-styled version of the WPF `ListViewItem` control for an entry in a list view.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## MarkdownViewer

`MarkdownViewer` renders Markdown source as Visual Studio-styled content and supports relative content paths and embedded media playback.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| ContentRootFolder | `string` | No | Sets the root folder used to resolve content-relative paths. |
| Markdown | `string` | No | Sets the Markdown source displayed by the control. |
| PlaybackMode | `MediaPlaybackMode` | No | Sets the playback mode for embedded media. |
| Renderer | `IMarkdownRenderer` | No | Sets the renderer used to convert Markdown into content. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## MediaHost

`MediaHost` presents embedded media and exposes playback state and actions.  This control generally should not be used and exists to allow hosting of image or video media in the markdown renderer.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| IsExpanded | `bool` | No | Gets or sets whether the media content is expanded. |
| IsPlaying | `bool` | No | Gets or sets whether media playback is active. |
| IsVideo | `bool` | No | Indicates whether the media source is treated as video. |
| PlaybackMode | `MediaPlaybackMode` | No | Sets the media playback mode. |
| ShowControls | `bool` | No | Controls whether media playback controls are displayed. |
| Source | `Uri` | No | Sets the URI of the media to display or play. |

### Commands

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| ExpandCommand | `ICommand` | Yes | Gets the command that expands the media host; bind or invoke it to expose the expanded media content. |
| PlayCommand | `ICommand` | Yes | Gets the command that starts media playback; bind it to a play action. |

### Methods

No methods are declared.

### Events

No events are declared.

## MenuItem

`MenuItem` is a Visual Studio-styled version of the WPF `MenuItem` control with optional `RadioButton`-like selection behaviors.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| GroupName | `string` | No | Sets the name of the mutually exclusive selection group. |
| IsSelectable | `bool` | No | Controls whether the menu item can be selected. |
| IsSelected | `bool` | No | Gets or sets whether the menu item is selected. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## MenuScrollViewer

`MenuScrollViewer` provides the vertical-only scrolling surface used by menus or similar flyout controls.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## MessageWindow

`MessageWindow` is a Visual Studio `Window`-derived control that displays a message in a modal window with configurable buttons, icon, and result. The control has support for a basic standard layout, but can be customized if more complex messaging is required. Do not call `Show()`, `ShowDialog()`, `ShowAt()`, or `ShowCentered()` with this control; use `ShowMessage()` instead. This control should typically be used to display short error or status information the user needs to acknowledge, or to request a simple confirmation from the user.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| MessageButtons | `MessageBoxButton` | No | Sets which buttons are displayed in the message window. |
| MessageContent | `object` | No | Sets the content of the message. |
| MessageResult | `MessageBoxResult` | Yes | Gets the result selected by the user after the message is shown. |
| Moniker | `ImageMoniker` | No | Sets the message window icon. |

### Commands

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| CancelButtonCommand | `ICommand` | Yes | Gets the command for the Cancel button; bind it to the corresponding cancel action. |
| NoButtonCommand | `ICommand` | Yes | Gets the command for the No button; bind it to the corresponding negative action. |
| OkButtonCommand | `ICommand` | Yes | Gets the command for the OK button; bind it to the confirmation action. |
| YesButtonCommand | `ICommand` | Yes | Gets the command for the Yes button; bind it to the affirmative action. |

### Methods

| Name | Returns | Remarks |
| --- | --- | --- |
| MessageWindow() | — | Constructs a message window to configure before displaying it. |
| ShowMessage() | `MessageBoxResult` | Displays the message window and returns the result selected by the user. |

### Events

No events are declared.

## NonClientButton

`NonClientButton` is a `Button`-derived control for the non-client area of a window.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## Paragraph

`Paragraph` represents a paragraph element in content rendered by `MarkdownViewer`. This control generally should not be used and exists to allow styling of paragraphs in the markdown renderer.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## PasswordBox

`PasswordBox` is a `TextBox`-derived control that mimics the WPF `PasswordBox` and accepts password input and can expose it as a secure string or plain text. This control should typically be used when a user can enter a password or other sensitive information.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| ShowPassword | `bool` | No | Controls whether the password is displayed as plain text; enable only when revealing the entered value is intended. |
| Password | `SecureString` | No | Gets or sets the password as a `SecureString`; prefer this property when consuming the value securely. |
| PlainTextPassword | `string` | No | Gets or sets the password as plain text; use only when an API requires a string, and avoid retaining it longer than necessary. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## PathButton

`PathButton` is a `Button`-derived control that displays vector path geometry and optional text. This control should typically be used when a user can invoke an action represented by a vector path or vector path and simple text, such as a toolbar button or an action with a visual affordance.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| Data | `Geometry` | No | Sets the path geometry displayed by the button. |
| Orientation | `Orientation` | No | Sets the relative layout direction of the path and text. |
| PathHeight | `double` | No | Sets the displayed path height. |
| PathWidth | `double` | No | Sets the displayed path width. |
| Stretch | `Stretch` | No | Sets how the path geometry is scaled to fit its available space. |
| Text | `string` | No | Sets the text displayed with the path. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## Popup

`Popup` is a Visual Studio-styled version of the WPF `Popup` for displaying content with configurable focus, automation, and menu-mode behavior. This control should typically be used when a user can view additional content in a floating surface, such as a tooltip or dropdown.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| BypassAutomation | `bool` | No | Controls whether child automation peer handling is bypassed while the popup is used. |
| Content | `object` | No | Gets or sets the content displayed in the popup. |
| EnableMenuMode | `bool` | No | Controls whether menu mode is enabled while the popup is open. |
| FocusOnOpen | `bool` | No | Controls whether focus moves into the popup when it opens. |
| IsClosed | `bool` | Yes | Indicates whether the popup has closed. |

### Commands

No commands are declared.

### Methods

| Name | Returns | Remarks |
| --- | --- | --- |
| Popup() | — | Constructs a popup that can be configured and opened. |

### Events

No events are declared.

## ProgressControl

`ProgressControl` displays progress with a selected indicator style, value, and optional message. This control should typically be used when a user can view the progress of an operation or show a long-running operation is in progress, such as a file download or data processing task.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| IsRunning | `bool` | No | Indicates whether progress is active; set it to reflect whether work is in progress. |
| Kind | `ProgressKind` | No | Selects the progress indicator style. |
| Message | `string` | No | Sets the message displayed with the progress indicator. |
| Progress | `double` | No | Sets the reported progress value. |
| RingDiameter | `double` | No | Sets the diameter of the ring indicator. |

### Commands

No commands are declared.

### Methods

| Name | Returns | Remarks |
| --- | --- | --- |
| ProgressControl() | — | Constructs a progress control to configure and display. |

### Events

No events are declared.

## RadioButton

`RadioButton` is a Visual Studio-styled version of the WPF `RadioButton` for choosing one option among a related set. This control should typically be used when a user can select one option from a mutually exclusive set, such as choosing a display mode or selecting a configuration option.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| FocusOnlyOnAccessKey | `bool` | No | Controls whether the radio button receives focus only or focus and invocation through its access key. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## ScrollBar

`ScrollBar` is a Visual Studio-styled version of the WPF `ScrollBar` with an option to keep its expanded presentation visible at all times.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| AlwaysExpanded | `bool` | No | Controls whether the scroll bar remains expanded even when not mouse hovered. |

### Commands

No commands are declared.

### Methods

| Name | Returns | Remarks |
| --- | --- | --- |
| ScrollBar() | — | Constructs a scroll bar. |

### Events

No events are declared.

## ScrollViewer

`ScrollViewer` is a Visual Studio-styled version of the WPF `ScrollViewer` control for scrolling content that exceeds its available viewport. This control should typically be used when a user can view content that may exceed the available space, such as a long list or document.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## SeamlessBorder

`SeamlessBorder` is a border for creating a seamless transition between the border and background colors with rounded corners. This control should only be used for solid colors or with the same color but different alpha values between the border and background.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## SearchBox

`SearchBox` is a `TextBox`-derived control that provides search input, recent-item support, search actions, and notifications when search state changes. This control should typically be used when a user can enter search text and perform a search or filter action, such as searching for files or settings.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| AllowRecentItems | `bool` | No | Controls whether recent search items are available. |
| HasNoResults | `bool` | No | Gets or sets whether the current search has no results. |
| IsDropDownOpen | `bool` | No | Gets or sets whether the search dropdown is open. |
| RecentItems | `IList<string>` | Yes | Gets the recent search items; read this collection to present or inspect search history. |
| ShowSearchButton | `bool` | No | Controls whether the search button is shown. |

### Commands

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| ClearCommand | `ICommand` | Yes | Gets the command that clears the search; bind it to a clear action. |
| SearchCommand | `ICommand` | Yes | Gets the command that performs a search; bind it to the search action. |

### Methods

| Name | Returns | Remarks |
| --- | --- | --- |
| SearchBox() | — | Constructs a search box. |

### Events

| Name | Handler Type | Remarks |
| --- | --- | --- |
| Cleared | `RoutedEventHandler` | Sent when the search is cleared; handle it to reset results or related UI. |
| RecentItemsChanged | `RoutedEventHandler` | Sent when the recent search items change; handle it to refresh any UI based on search history. |
| Searching | `RoutedEventHandler` | Sent when a search is initiated; handle it to process the search request. |

## SearchBoxItem

`SearchBoxItem` represents an item displayed in the recent items search dropdown.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## Section

`Section` represents a section element in content rendered by `MarkdownViewer`. This control generally should not be used and exists to allow styling of sections in the markdown renderer.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## Separator

`Separator` is a Visual Studio-styled version of the WPF `Separator` control that provides a visual divider between items or regions. This control should typically be used when a user can view a visual separation between related content, such as menu items or toolbar buttons.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## SimpleCurvedBorder

`SimpleCurvedBorder` renders a simple curved border around a surface. This control is used by shell UI and generally should not be used by extender UI.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## SplitButton

`SplitButton` is a `Button`-derived control that combines a primary action with a separate dropdown action. The primary action is tied to the standard Click event. This control should typically be used when a user can invoke a primary action but also has additional supplemental actions available, such as a "Save" button with a dropdown for "Save As" or "Save All".

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| DropDownToolTip | `object` | No | Sets the tooltip for the dropdown portion of the button. |

### Commands

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| ActionCommand | `ICommand` | Yes | Gets the command that performs the primary button action. |
| DropDownCommand | `ICommand` | Yes | Gets the command that opens the dropdown. |

### Methods

| Name | Returns | Remarks |
| --- | --- | --- |
| SplitButton() | — | Constructs a split button with a primary action and a dropdown action. |

### Events

No events are declared.

## TabControl

`TabControl` is a Visual Studio-styled version of the WPF `TabControl` control for presenting selectable tabs and their content. This control should typically be used when a user can select one of several related content areas, such as different views or settings categories.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| ShowSelectedContent | `bool` | No | Controls whether the content of the selected tab is displayed. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## TabItem

`TabItem` is a Visual Studio-styled version of the WPF `TabItem` control representing one tab in a tab control.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## TextBlock

`TextBlock` is a Visual Studio-styled version of the WPF `TextBlock` control for text display with configurable text appearance and formatting mode.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| Kind | `TextKind` | No | Sets the visual text style; select a kind that matches the text's role in the UI. |
| PreferredTextFormattingMode | `TextFormattingMode?` | Yes | Gets the preferred text formatting mode attached to the element. |

### Commands

No commands are declared.

### Methods

| Name | Returns | Remarks |
| --- | --- | --- |
| GetPreferredTextFormattingMode(DependencyObject) | `TextFormattingMode?` | Gets the preferred text formatting mode attached to the specified object. |
| SetPreferredTextFormattingMode(DependencyObject, TextFormattingMode?) | `void` | Sets the preferred text formatting mode on the specified object. |

### Events

No events are declared.

## TextBox

`TextBox` is a Visual Studio-styled version of the WPF `TextBox` control for text input with configurable corner shape and hint text. This control should typically be used when a user can enter text, such as a name or message.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| CornerRadius | `CornerRadius` | No | Sets the text box's corner rounding. |
| HintText | `string` | No | Sets the hint displayed while the text box is empty. |

### Commands

No commands are declared.

### Methods

| Name | Returns | Remarks |
| --- | --- | --- |
| TextBox() | — | Constructs a text box. |

### Events

No events are declared.

## ToggleButton

`ToggleButton` is a Visual Studio-styled version of the WPF `ToggleButton` control that represents a boolean or tri-state. This control should typically be used when a user can toggle something on or off, such as enabling or disabling a feature.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| CornerRadius | `CornerRadius` | No | Sets the button's corner rounding. |
| Kind | `ButtonKind` | No | Selects the button's visual treatment. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## ToggleSwitch

`ToggleSwitch` is an alternate style of a `ToggleButton` for a two-state-only choice that looks like a switch instead of a normal button, with configurable labels and content layout. This control should typically be used when a user can toggle something on or off, such as enabling or disabling a feature.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| IsContentSwapped | `bool` | No | Controls whether the on/off content positions are swapped. |
| OffText | `string` | No | Sets the text displayed in the off state. |
| OnText | `string` | No | Sets the text displayed in the on state. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## ToolTip

`ToolTip` is a Visual Studio-styled version of the WPF `ToolTip` control for presenting brief contextual information. This control should typically be used when a user can view additional information about a UI element, such as a description of a button or field.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## TopCurvedBorder

`TopCurvedBorder` is a Visual Studio-styled border that renders the curved treatment along the top edge of a surface. This control is used by shell UI and generally should not be used by extender UI.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## TreeView

`TreeView` is a Visual Studio-styled version of the WPF `TreeView` control for displaying items with parent-child relationships. This control should typically be used when a user can view and select items in a hierarchical structure, such as a file system or organizational chart.

### Properties

No properties are declared.

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## TreeViewItem

`TreeViewItem` is a Visual Studio-styled version of the WPF `TreeViewItem` control for an entry in a tree view.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| BringHeaderIntoViewOnSelection | `bool` | No | Controls whether selecting the item brings its header into view. |
| HeaderHeight | `double` | Yes | Gets the height of the item header for layout or measurement. |
| Level | `int` | Yes | Gets the item's depth in the tree. |

### Commands

No commands are declared.

### Methods

| Name | Returns | Remarks |
| --- | --- | --- |
| TreeViewItem() | — | Constructs a tree view item. |

### Events

No events are declared.

## TypedItemsControl

`TypedItemsControl` is an items control that creates child items of a specified type. This control should typically be used when a user can view and interact with a collection of items of a specific type without selection.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| ItemType | `Type` | No | Sets the type for child items added to the control. This type must have a parameterless constructor. |

### Commands

No commands are declared.

### Methods

No methods are declared.

### Events

No events are declared.

## Window

`Window` is a non-modal, Visual Studio styled version of the WPF `Window` with configurable chrome, content regions, and window actions. The control has support for a basic layout but is the most flexible of the window controls for custom layout. Do not use `ShowDialog()` with this control; use one of the modal window variants instead. This control should typically be used when a user can view content in a separate window, such as a tool window or floating panel while retaining the ability to interact with the rest of the product at the same time.

### Properties

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| BorderColor | `Color` | No | Sets the window border color. |
| CanCopy | `bool` | No | Controls whether the window content can be copied. |
| CanDragMove | `bool` | No | Controls whether the window can be moved by dragging. |
| CloseEndsProcess | `bool` | No | Controls whether closing the window ends the process. |
| CloseOnEsc | `bool` | No | Controls whether pressing Escape closes the window. |
| Dpi | `double` | Yes | Gets the window's DPI scale. |
| FooterContent | `object` | No | Gets or sets the content displayed in the footer. |
| Handle | `IntPtr` | Yes | Gets the native window handle. |
| NonClientContent | `object` | No | Gets or sets content displayed in the non-client area. |
| UseDwmBorder | `bool` | Yes | Indicates whether the window uses a DWM border. |
| ShowFooter | `bool` | No | Controls whether the footer is shown. |
| ShowTitle | `bool` | No | Controls whether the title is shown. |

### Commands

| Name | Type | Is Read-Only | Remarks |
| --- | --- | --- | --- |
| CloseCommand | `ICommand` | Yes | Gets the command that closes the window; bind or invoke it to provide a close action. |
| MaximizeCommand | `ICommand` | Yes | Gets the command that maximizes the window; bind it to a maximize action. |
| MinimizeCommand | `ICommand` | Yes | Gets the command that minimizes the window; bind it to a minimize action. |

### Methods

| Name | Returns | Remarks |
| --- | --- | --- |
| ShowAt(int, int, double, double) | `void` | Displays the window at the specified screen coordinates and optional logical size. |
| ShowCentered() | `void` | Displays the window centered on the screen. |
| ShowDialog() | `bool?` | Displays the window as a modal dialog and returns its nullable Boolean result. |

### Events

No events are declared.
