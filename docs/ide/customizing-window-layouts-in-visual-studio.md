---
title: Customize window layouts
description: Learn how to customize the characteristics that windows exhibit to create layouts that work best for various development workflows.
ms.custom: SEO-VS-2020
ms.date: 11/24/2021
ms.topic: conceptual
f1_keywords:
- vs.windows
- vs.environment
helpviewer_keywords:
- windows [Visual Studio], managing
- custom window configurations
- layout [Visual Studio], window management
- document windows [Visual Studio]
- interface modes
- AutoHide windows
- MDI, window interface modes
- multiple monitors
- Tabbed Document mode
- debug mode
- custom layouts
ms.assetid: 7517ff13-76de-4ecf-9c1b-eb9b7ff4d718
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Customize window layouts in Visual Studio

In Visual Studio, you can customize the position, size, and behavior of windows to create window layouts that work best for various development workflows. When you customize the layout, the IDE remembers it. For example, if you change the docking location of **Solution Explorer** and then close Visual Studio, the next time that you open Visual Studio, even if you're working on another computer, **Solution Explorer** will be docked in that same location.

You can also name and save a custom layout and then switch between layouts with a single command. For example, you could create a layout for editing and a layout for debugging, and switch between them by using the **Window** > **Apply Window Layout** menu command.

## Tool and document windows

The IDE has two basic window types, *tool windows* and *document windows*. Tool windows include **Solution Explorer**, **Server Explorer**, **Output Window**, **Error List**, the designers, the debugger windows, and so on. Document windows contain source code files, arbitrary text files, config files, and so on. Tool windows can be resized and dragged by their title bar. Document windows can be dragged by their tab. Right-click on the tab or title bar to set other options on the window.

The **Window** menu shows options for docking, floating, and hiding windows in the IDE. Right click on a window tab or title bar to see additional options for that specific window. You can display more than one instance of certain tool windows at a time. For example, you can display more than one web browser window, and you can create additional instances of some tool windows by choosing **New Window** on the **Window** menu.

### Split windows

When you have to view or edit two locations at once in a document, you can split windows. To divide your document into two independently scrolling sections, click **Split** on the **Window** menu. Click **Remove Split** on the **Window** menu to restore the single view.

### Tabs

You can use tabs to arrange your layout in several different ways. For example, you can view a preview of a file in the editor without opening the file, you can group your tabs, and more.

#### Preview tab (document windows)

In the **Preview** tab, you can view files in the editor without opening them. You can preview files by choosing them in **Solution Explorer**, during debugging when you step into files, with **Go to Definition**, and when you browse through results of a search. Preview files appear in a tab on the right side of the document tab well. The file opens for editing if you modify it or choose  **Open**.

::: moniker range=">=vs-2019"

#### Vertical document tabs

**[New in Visual Studio 2019 version 16.4 and later](/visualstudio/releases/2019/release-notes-v16.4/)**: We added one of the top feature requests, [vertical document tabs](https://developercommunity.visualstudio.com/idea/467369/vertical-group-tab.html). Now, you can manage your document tabs in a vertical list on either the left or right side of your editor.

You can apply vertical document tabs in the following ways:

- Choose **Tools** > **Options** > **Environment** > **Tabs and Windows** from the menu bar. Then, from the **Set tab layout** control, choose either **Top**, **Left**, or **Right** from the drop-down list.

- Right-click a tab, choose **Set Tab Layout**, and then choose either **Left** or **Right**. (To return the tabs to their default position, choose **Top**.)

    :::image type="content" source="./media/vs-2019/vertical-tabs.gif" alt-text="An animation that shows vertical document tabs in action":::

::: moniker-end

::: moniker range="vs-2022"

#### Color document tabs

**[New in Visual Studio 2022 version 17.0 and later](/visualstudio/releases/2022/release-notes)**: We added another top feature request, [color document tabs](https://devblogs.microsoft.com/visualstudio/personalize-docs/). Now, you can colorize tabs in both vertical and horizontal views in the Editor.

The following screenshot shows an example of color tabs in the vertical view:

:::image type="content" source="media/vs-2022/color-tabs-vertical.png" alt-text="Screenshot of color tabs in the vertical view.":::

The following screenshot shows an example of color tabs in the horizontal view:

:::image type="content" source="media/vs-2022/color-tabs-horizontal.png" alt-text="Screenshot of color tabs in the horizontal view.":::

To use color tabs, navigate to **Tools** > **Options** > **Environment** > **Tabs and Windows**, and then select **Colorize document tabs by project**.

::: moniker-end

#### Tab groups

Tab groups extend your ability to manage limited workspace while you're working with two or more open documents in the IDE. You can organize multiple document windows and tool windows into either vertical or horizontal tab groups and shuffle documents from one tab group to another.

### Toolbars

You can arrange toolbars by dragging them to where you want them, or by using the **Customize** dialog box. For more information about how to position and customize toolbars, see [How to: Customize menus and toolbars](../ide/how-to-customize-menus-and-toolbars-in-visual-studio.md).

## Arrange and dock windows

A document window or tool window can be *docked*, so that it has a position and size within the IDE window frame. You can also position it as a separate floating window that's outside of the IDE.

You can dock a tool window anywhere inside the IDE frame. You can also dock some tool windows as tabbed windows in the editor frame. And, you can dock document windows within the editor frame, and you can pin them to their current position in the tab order.

You can also dock multiple windows to float together in a *raft* over or outside of the IDE. Tool windows can also be hidden or minimized.

You can arrange windows in the following ways:

- Pin document windows to the left of the tab well.

- Tab-dock windows to the editing frame.

- Dock tool windows to the edge of a frame in the IDE.

- Float document or tool windows over or outside the IDE.

- Hide tool windows along the edge of the IDE.

- Display windows on different monitors.

- Reset window placement to the default layout or to a saved custom layout.

To arrange tool and document windows, you can place your cursor on the title bar of a window and then drag it to where you want it. Alternatively, you can right-click the title bar of the window to use its context menu, or you can use the commands on the **Window** menu.

### Dock windows

When you click and drag the title bar of a tool window, or the tab of document window, a guide diamond appears. During the drag operation, when the mouse cursor is over one of the arrows in the diamond, a shaded area will appear that shows you where the window will be docked if you release the mouse button now.

To move a dockable window without snapping it into place, press the **Ctrl** key while you drag the window.

To return a tool window or document window to its most recent docked location, press **Ctrl** while you double-click the title bar or tab of the window.

The following illustration shows the guide diamond for document windows, which can only be docked within the editing frame:

![Document window guide diamond](../ide/media/documentwindowguidediamonds.png)

Tool windows can be fastened to one side of a frame in the IDE or within the editing frame. A guide diamond appears when you drag a tool window to another location to help you to easily redock the window.

![Tool Window Guide Diamonds](../ide/media/vs10guidediamond.png)

The following illustration shows **Solution Explorer** being docked in a new location that's demarcated by the blue shaded area:

![Docking Solution Explorer in a new position](../ide/media/vs2015_dock_diamond.png)

### Close and auto-hide tool windows

You can close a tool window by clicking the **X** in the upper right of the title bar. To reopen the window, use its keyboard shortcut or menu command. Tool windows support a feature named *auto hide*, which causes a window to slide out of the way when you use a different window. When a window is autohidden, its name appears on a tab at the edge of the IDE. To use the window again, point to the tab so that the window slides back into view.

![Auto hide](../ide/media/vs2015_auto_hide.png)

> [!NOTE]
> To set whether auto hide operates on tool windows individually or as docked groups, select or clear **Auto Hide button affects active tool windows only** in the **Options** dialog box. For more information, see [General, Environment, Options dialog box](../ide/reference/general-environment-options-dialog-box.md).

> [!NOTE]
> Tool windows that have auto hide enabled may temporarily slide into view when the window has focus. To hide the window again, select an item outside of the current window. When the window loses focus, it slides back out of view.

### Use a second monitor

If you have a second monitor and your operating system supports it, you can choose which monitor displays a window. You can even group multiple windows together in *rafts* on other monitors.

> [!TIP]
> You can create multiple instances of **Solution Explorer** and move them to another monitor. Right-click the window and choose **New Solution Explorer View**. You can return all windows back to the original monitor by double-clicking while choosing the **Ctrl** key.

### Reset, name, and switch between window layouts

You can return the IDE to the original window layout for your settings collection by using the **Reset Window Layout** command. When you run this command, the following actions occur:

- All windows are moved to their default positions.

- Windows that are closed in the default window layout are closed.

- Windows that are open in the default window layout are opened.

### Create and save custom layouts

Visual Studio enables you to save up to 10 custom window layouts and quickly switch between them. The following steps show how to create, save, invoke, and manage custom layouts that take advantage of multiple monitors with both docked and floating tool windows.

First, create a test solution that has two projects, each with a different optimal layout.

#### Create a UI project and customize the layout

::: moniker range="vs-2017"

1. Create a new C# **WPF App** project. Imagine that in this project, you'll be developing a user interface. You want to maximize the space for the designer window and move other tool windows out of the way.

::: moniker-end

::: moniker range=">=vs-2019"

1. Create a new C# **WPF Application** project. Imagine that in this project, you'll be developing a user interface. You want to maximize the space for the designer window and move other tool windows out of the way.

::: moniker-end

2. If you have multiple monitors, pull over the **Solution Explorer** window and the **Properties** window to your second monitor. On a single monitor system, try closing all the windows except the designer.

3. Press **Ctrl**+**Alt**+**X** to display the **Toolbox** window. If the window is docked, drag it so that it floats somewhere where you'd like to position it.

4. Press **F5** to put Visual Studio into debugging mode. Adjust the position of the **Autos**, **Call Stack**, and **Output** debugging windows the way you want them. The layout you're about to create will apply to both editing mode and debugging mode.

5. When your layouts in both debugging mode and editing mode are how you want them, choose **Window** > **Save Window Layout**. Call this layout "Designer."

     Notice that your new layout is assigned the next keyboard shortcut from the reserved list of **Ctrl**+**Alt**+**1...0**.

#### Create a database project and layout

1. Add a new **SQL Server Database** project to the solution.

2. Right-click on the new project in **Solution Explorer** and choose **View in Object Explorer**. This displays the **SQL Server Object Explorer** window, which enables you to access tables, views and other objects in your database. You can either float this window or leave it docked. Adjust the other tool windows the way you want them. For added realism, you can add an actual database, but it's not necessary for this walkthrough.

3. When your layout is how you want it, from the main menu choose **Window** > **Save Window Layout**. Call this layout "DB Project." (We won't bother with a debug mode layout for this project.)

#### Switch between the layouts

To switch between layouts, use the keyboard shortcuts, or from the main menu choose **Window** > **Apply Window Layout**.

![Apply window layout menu](../ide/media/vs2015_applywindowlayout.png)

After applying the UI layout, note how the layout is preserved both in editing mode and in debug mode.

If you have a multi monitor setup at work and a single monitor laptop at home, you can create layouts that are optimized for each machine.

> [!NOTE]
> If you apply a multi-monitor layout on a single-monitor system, the floating windows that you placed on the second monitor will now be hidden behind the Visual Studio window. You can bring these windows to the front by pressing **Alt + Tab**. If you later open Visual Studio with multiple monitors, you can restore the windows to their specified positions by re-applying the layout.

#### Manage and roam your layouts

You can remove, rename, or reorder your custom layout by choosing **Window** > **Manage Window Layouts**. If you move a layout, the key binding is automatically adjusted to reflect the new position in the list. The bindings can't be otherwise modified, and so you can store a maximum of 10 layouts at a time.

![Manage window layouts](../ide/media/managewindowlayouts.png)

To remind yourself which keyboard shortcut is assigned to which layout, choose **Window** > **Apply Window Layout**.

These layouts automatically roam between Visual Studio editions, and also between Blend instances on separate machines, and from any Express edition to any other Express organization. However, layouts do not roam across Visual Studio, Blend, and Express.

## See also

- [How to: Move around in the IDE](../ide/how-to-move-around-in-the-visual-studio-ide.md)
