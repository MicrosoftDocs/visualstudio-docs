---
title: 'Workflow Designer: Keyboard shortcuts'
description: Learn the various commands you can type on the keyboard to navigate the Workflow Designer in Visual Studio.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- WFDKeyboardShortcuts.UI
author: sayedihashimi
ms.author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Keyboard Shortcuts in the Workflow Designer

All of the core functionality of the Workflow Designer can be accessed by keyboard.

## Navigating the Workflow Designer using the keyboard

Inside Visual Studio, the global shortcuts and debugging shortcuts apply to the Workflow Designer. Also, a number of Workflow Designer specific keyboard shortcuts have been created. In Visual Studio, all of the keyboard shortcuts can be remapped. However, in a rehosted application, these keyboard shortcuts are hardcoded.

### Workflow Designer keyboard shortcuts

The following table summarizes the default keyboard shortcuts assigned to Workflow Designer commands.

|Shortcut|Purpose|
|-|-------------|
|CTRL+E, A|Shows or hides the Argument Designer.|
|CTRL+E, C|Collapses the selected activity in place.|
|CTRL+E, E|Expands the selected activity in place.|
|CTRL+E, F|Connects the selected activities in a flowchart.|
|CTRL+E, I|Shows or hides the Imports Designer.|
|CTRL+E, M|Moves the keyboard focus to the next item in the tab order.|
|CTRL+E, N|Creates a new variable in the scope of the selected activity (or the closest).|
|CTRL+E, O|Shows or hides the Overview map.|
|CTRL+E, P|Navigates to the parent of the selected activity. This goes up one level in breadcrumb navigation and changes the root activity on the designer surface.|
|CTRL+E, S|Adds the item with keyboard focus to the current selection.|
|CTRL+E, V|Shows or hides the Variable Designer.|
|CTRL+E, X|Expands all activities in the workflow.|
|CTRL+ALT+F6|Moves keyboard focus from the current UI area to the next area in the sequence. The order is as follows:<br /><br /> 1.  Breadcrumb navigation bar.<br />2.  Designer surface<br />3.  Arguments/Variables/Imports designer if open<br />4.  Shell|

### Flowchart

The following list shows the gestures used to construct a flowchart by keyboard. As in the rest of the Workflow Designer, activities are added to the designer surface using the global toolbox shortcuts provided with Visual Studio.

- To move an activity, select the activity and use the arrow keys to reposition it.

- To resize a flowchart, move an activity past the current border of the flowchart using the arrow keys. The flowchart is resized automatically.

- To set an activity as the start node, use the **Set as StartNode** command in the right-click menu.

- To connect activities:

    1. Select the source activity by tabbing to the activity.

    2. Press CTRL+E, M as many times as necessary to move keyboard focus to the destination activity.

    3. Press CTRL+E, S to add the destination activity to the selection.

    4. Press CTRL+E, F to add the connector from the source to the destination.

Notes about connecting activities by keyboard:

- You can make multiple connections at the same time by adding more activities to the selection before pressing CTRL+E, F. The connections are made in the order that the activities were added to the selection.

- If a pair of activities cannot be connected, for example if the source activity already has an outgoing connection, other connections between activities in the selection are still made whenever possible.

- When a **FlowDecision** is included in the selection and the **FlowDecision** has no outgoing connectors, the connector is placed on the **True** branch.

### Expression Editing

By default, the default keyboard shortcuts for Visual Basic text editing apply inside the expression editor in Workflow Designer, with the following limitations:

- Remapping the keyboard shortcuts for the following commands has no effect. You can only use the default keyboard shortcuts to access these commands when editing an expression.

  - Cut
  - Copy
  - Paste
  - Select All
  - Undo
  - Redo

- To remap the keyboard shortcuts for expression editing commands inside Workflow Designer in Visual Studio, edit the shortcuts in the Workflow Designer scope. Changes made in the Text Editor scope do not automatically apply to Workflow Designer. If you want to remap shortcuts in both places, you must apply the changes twice (once for each scope).
