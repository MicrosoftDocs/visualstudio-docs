---
title: Microsoft.VisualStudio Diagnostics Explorer extension overview
description: An overview of the Microsoft.VisualStudio Diagnostics Explorer extension
ms.topic: overview
ms.date: 05/09/2024
ms.author: rytoth
monikerRange: ">=vs-2022"
author: RyanToth3
manager: tinali
ms.subservice: extensibility-integration
---

# Overview

The VisualStudio.Extensibility Diagnostics Explorer extension is a tool designed to help debug VisualStudio.Extensibility extensions while developing them. The target audience for this extension is extension authors, not extension consumers. This extension provides an interface for inspecting the extensibility points that extensions are interacting with, and what configuration objects extensions are providing to the IDE, and the metadata of those configuration objects. 

Minimum Visual Studio Version: 17.10

## Getting Started

### Installing the Extension

You can download and install the extension by locating it inside of the `Manage Extensions` window `Browse` tab, or through the [Visual Studio Marketplace](INSERT MARKETPLACE LINK HERE). Unfortunately this extension isn't hot-loadable and Visual Studio needs to be shut down in order to install it. 

### Accessing the Extension inside Visual Studio

The command for opening the tool window for this extension lives under the `Extensions` top level menu.

![Screenshot of the command that opens the extension's tool window.](./media/image-1.png)

## Diagnostics Pages

The left-hand panel of the tool window contains a list of pages that contain diagnostics for different extensible features in Visual Studio. Clicking on any of these list items changes the right-hand panel to a view containing useful diagnostics.

![Screenshot of the left hand panel of the tool window.](./media/image-2.png)

### Extensible Feature Pages

Extensible feature pages are pages where the left most top ComboBox is labeled `Extensibility Point`. These types of pages containing diagnostics that can be mapped directly to configuration objects in your extension. For example, in the `Commands` page there's an `Extensibility Point` for `Menus and Toolbars`. In the view on this page, you can see metadata related to menus and toolbars provided by installed extensions. Data in the view updates in real time as properties are updated in extensions. For example, if an extension changes the display name of one of its commands at runtime, the new display name of that command is shown in the cell in the `Display Name` column for that command immediately.

![Screenshot of the Commands page.](./media/image-3.png)

Each extensible feature page's `Extensibility Point` ComboBox has an option for a `Log`. This view contains useful diagnostics related to the selected extensible feature. The `Clear All` button beside the `Extensibility Point` ComboBox can be used to clear all lines currently being displayed in the view.

![Screenshot of the Command's Log page.](./media/image-4.png)

You can filter the items in the view by using the `Extensions` ComboBox. When `All` is selected in this ComboBox, items belonging to all installed extensions are shown. If you change this ComboBox to the ID of a specific extension, only items related to that specific extension is shown. The value of this ComboBox is persisted even when you navigate between extensible feature pages.

![Screenshot of the Command's page filtered to a specific extension.](./media/image-5.png)

Some cells in the DataGrid display `[Click to Expand]`. This message means that the metadata related to that property is too verbose to be neatly displayed in a cell of the DataGrid. Clicking on the cell opens a modal dialog displaying the actual value of that cell.

![Screenshot of the "Click to Expand" modal dialog."](./media/image-6.png)

### Events Page

The events page is used to show when "something happens" in the IDE. The fact that that event occurred appears as a new row in the DataGrid, along with any properties related to that event. For example, when a command is executed, a `Commands - Executing` event instance appears in the view showing the ID of the extension that the command belongs to and the ID of the command that was executed.

The `Event` ComboBox can be used to filter the view to only contain events with a specific name. When `All` is selected, then all events are shown. If a specific event is selected, all of the properties of the event are shown in the view. Some properties need to be expanded by clicking on `[Click to Expand]` if they're too verbose to be shown in a single cell.

The `Contract` ComboBox can be used to filter the view to only contain events related to a specific extensible feature. It also filters the `Event` ComboBox to only contain the names of events related to the specific extensible feature.

Clicking the `Clear All` button deletes all the events currently shown in the view.

![Screenshot of the Events page.](./media/image-7.png)

#### Column Descriptions

##### Extension ID

The `Extension Id` column shows the Id of the extension that the instance of the event is related to. It's possible for this cell to be empty for some events if they don't belong to a specific extension but instead apply to the IDE as a whole.

##### Item ID

The `Item Id` column shows the Id of the extension item that the instance of the event is related to. For example, the `Item Id` for the `Commands - Executing` event would be the Id of the command that was executed.

##### Properties

The `Properties` column shows the set of properties related to that instance of the event that could be displayed in a single cell in a DataGrid. More verbose properties would only be visible from the `More Info` dialog, or by changing the `Event` ComboBox to the name of the specific event that you're interested in.

##### More Info

The `More Info` column is a way to see more verbose metadata related to an event. Clicking a cell in this column opens a modal dialog containing all of the metadata related to the event represented by that row.

![Screenshot of the More Info dialog.](./media/image-8.png)

### Activation Constraints Page

The activation constraints page shows the state of various properties related to the IDE itself. The `Context` ComboBox changes the data in the view to either show all of the activation constraints related to the currently selected item in the `Acitvation Constraints` ComboBox, or a log of all the times these properties have changed since the tool window was opened. When the `Events` context is selected, the `Clear All` button can be used to delete all the events currently being displayed in the view.

![Screenshot of the Activation Constraint's Current State page.](./media/image-9.png)

![Screenshot of the Activation Constraint's Events page.](./media/image-10.png)

## Options

### Enable collection diagnostics

Disabling this option stops the extension from collection diagnostics. Restarting Visual Studio is required for changes to this setting to take effect. The default value for this setting is `on`.

![Screenshot of the "Enable collecting diagnostics" setting.](./media/image-11.png)