---
title: Customize window layouts and personalize document tabs
description: Learn how to customize tabs and windows in Visual Studio to create layouts that work best for your development workflows.
ms.custom: SEO-VS-2020
ms.date: 08/24/2022
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
# Customize window layouts and personalize tabs

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

In Visual Studio, you can customize the position, size, and behavior of windows to create window layouts that work best for various development workflows. You can also personalize how you use tabs to interact with your code.

## Customize window layouts

When you customize a window layout, the Visual Studio [integrated development environment](../get-started/visual-studio-ide.md) (IDE) remembers it. For example, if you change the docking location of **[Solution Explorer](use-solution-explorer.md)** and then close Visual Studio, the next time that you open Visual Studio, **Solution Explorer** will be docked in that same location. The Visual Studio IDE remembers the docking location even if you're working on another computer.

You can also name and save a custom layout and then switch between layouts with a single command. For example, you could create a layout for editing and a layout for debugging, and switch between them by using the **Window** > **Apply Window Layout** menu command.

### Tool and document windows

The IDE has two basic window types, *tool windows* and *document windows*. Tool windows include **Solution Explorer**, **Server Explorer**, **Output Window**, **Error List**, the designers, the debugger windows, and so on. Document windows contain source code files, arbitrary text files, config files, and so on. Tool windows can be resized and dragged by their title bar. Document windows can be dragged by their tab. Right-click on the tab or title bar to set other options on the window.

The **Window** menu shows options for docking, floating, and hiding windows in the IDE. Right-click on a window tab or title bar to see more options for that specific window. You can display more than one instance of certain tool windows at a time. For example, you can display more than one web browser window, and you can create extra instances of some tool windows by selecting **New Window** on the **Window** menu.

#### Split windows

When you have to view or edit two locations at once in a document, you can split windows. To divide your document into two independently scrolling sections, select **Split** on the **Window** menu. Select **Remove Split** on the **Window** menu to restore the single view.

#### Toolbars

You can arrange toolbars by dragging them to where you want them, or by using the **Customize** dialog box. For more information about how to position and customize toolbars, see [How to: Customize menus and toolbars](how-to-customize-menus-and-toolbars-in-visual-studio.md).

### Arrange and dock windows

A document window or tool window can be *docked*, so that it has a position and size within the IDE window frame. You can also position it as a separate floating window that's outside of the IDE.

You can dock a tool window anywhere inside the IDE frame. You can also dock some tool windows as tabbed windows in the editor frame. And, you can dock document windows within the editor frame, or pin them to their current position in the [tab](#personalize-tabs) order.

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

#### Dock windows

When you select and drag the title bar of a tool window or the tab of document window, a guide diamond appears. During the drag operation, when the mouse cursor is over one of the arrows in the diamond, a shaded area appears that shows you where the window will be docked if you release the mouse button.

To move a dockable window without snapping it into place, press the **Ctrl** key while you drag the window.

To return a tool window or document window to its most recent docked location, press **Ctrl** while you double-click the title bar or tab of the window.

The following illustration shows the guide diamond for document windows, which can only be docked within the editing frame:

:::image type="content" source="media/document-window-guide-diamond-sml.png" alt-text="Screenshot of the Document window guide diamond." lightbox="media/document-window-guide-diamond-lrg.png":::

Tool windows can be fastened to one side of a frame in the IDE or within the editing frame. A guide diamond appears when you drag a tool window to another location to help you to easily redock the window.

:::image type="content" source="media/tool-window-guide-diamond-sml.png" alt-text="Screenshot of the Tool window guide diamond." lightbox="media/tool-window-guide-diamond-lrg.png":::

The following illustration shows **Solution Explorer** being docked in a new location that's demarcated by a purple shaded area:

:::image type="content" source="media/docked-diamond-solution-explorer-example-sml.png" alt-text="Screenshot of what appears in the IDE when you want to dock Solution Explorer in a new position." lightbox="media/docked-diamond-solution-explorer-example-lrg.png":::

### Close and auto-hide tool windows

You can close a tool window by selecting the **X** in the upper right of the title bar. To reopen the window, select the tool windows you want by using **View** on the menu bar, or by using its associated keyboard shortcut.

Tool windows support a feature named **Auto Hide**, which causes a window to slide out of the way when you use a different window. When a window is automatically hidden, its name appears on a tab at the edge of the IDE. To use the window again, select the tab so that the window slides back into view.

:::image type="content" source="media/auto-hide-sml.png" alt-text="Set of two screenshots that show the Auto Hide menu item and an associated set of tabbed tool windows when Auto Hide is selected." lightbox="media/auto-hide-lrg.png":::

> [!TIP]
> To set whether auto hide operates on tool windows individually or as docked groups, select or clear **Auto Hide button affects active tool window only** in the **Options** dialog box. For more information, see the [Options dialog box: Environment > General](reference/general-environment-options-dialog-box.md) page.

> [!NOTE]
> Tool windows that have auto hide enabled may temporarily slide into view when the window has focus. To hide the window again, select an item outside of the current window. When the window loses focus, it slides back out of view.

#### Use a second monitor

If you have a second monitor and your operating system supports it, you can select which monitor displays a window. You can even group multiple windows together in *rafts* on other monitors.

> [!TIP]
> You can create multiple instances of **Solution Explorer** and move them to another monitor. Right-click the [**Solution** node](use-solution-explorer.md#solution-node-context-menu-options) and select **New Solution Explorer View**. To close the extra instances, double-click each one while pressing the **Ctrl** key.

#### Reset, name, and switch between window layouts

You can return the IDE to the original window layout for your settings collection by selecting **Windows** > **Reset Window Layout** from the menu bar. When you run this command, the following actions occur:

- All windows are moved to their default positions.

- Windows that are closed in the default window layout are closed.

- Windows that are open in the default window layout are opened.

#### Create and save custom layouts

Visual Studio enables you to save up to 10 custom window layouts and quickly switch between them. The following steps show how to create, save, invoke, and manage custom layouts that take advantage of multiple monitors with both docked and floating tool windows.

First, create a test solution that has two projects, each with a different optimal layout.

##### Create a project and customize the layout

First, we'll create a user interface (UI) project. The idea is to maximize the space for the designer window by moving other tool windows out of the way.

1. Create a new C# **WPF Application** project.

1. If you have multiple monitors, drag the **Solution Explorer** window and the **Properties** window over to your second monitor.

   If you're using a single monitor only, try closing all the windows except the designer.

1. Press **Ctrl**+**Alt**+**X** to display the **Toolbox** window. If the window is docked, drag it so that it floats somewhere where you'd like to position it.

1. When your layout is how you want it, select **Window** > **Save Window Layout**. Call this layout "Designer".

     Notice that your new layout is assigned the next keyboard shortcut from the reserved list of **Ctrl**+**Alt**+**1...0**.

##### Create a database project and layout

Next, we'll add a new SQL Server database project to the solution.

1. Right-click the **Solution** node in **Solution Explorer** to open its [context menu](use-solution-explorer.md#the-add-context-menu-fly-out), select **Add**, and then select **New Project**.

1. In the **Add a new project** dialog, select **SQL** from the **All project types** drop-down list, and then select **SQL Server Database Project**.

   (You can also use the Search box to find the template. To do so, enter 'SQL' as a search string in the box that includes the following text: **Search for templates (Alt+S)**.)

1. Right-click the new database project in **Solution Explorer**, and then select **View in Object Explorer**.

   When you do so, Visual Studio displays the **SQL Server Object Explorer** window, which enables you to access tables, views and other objects in your database. You can either float this window or leave it docked. Adjust the other tool windows the way you want them. For added realism, you can add an actual database, but it's not necessary for this walkthrough.

1. When your layout is how you want it, select **Window** from the menu bar, and then select **Save Window Layout**. Name this layout "DB Project". (We won't bother with a debug mode layout for this project.)

##### Switch between the layouts

To switch between layouts, use the keyboard shortcuts from the reserved list of **Ctrl**+**Alt**+**1...0**. Or, from the main menu, select **Window** > **Apply Window Layout**.

:::image type="content" source="media/apply-window-layout-sml.png" alt-text="Screenshot of the 'Apply window layout' menu." lightbox="media/apply-window-layout-lrg.png":::

If you have a multi-monitor setup at work and a single monitor laptop at home, you can create layouts that are optimized for each machine.

> [!NOTE]
> If you apply a multi-monitor layout on a single-monitor system, the floating windows that you placed on the second monitor will now be hidden behind the Visual Studio window. You can bring these windows to the front by pressing **Alt**+**Tab**. If you later open Visual Studio with multiple monitors, you can restore the windows to their specified positions by reapplying the layout.

#### Manage and roam your layouts

You can remove, rename, or reorder your custom layout by selecting **Window** > **Manage Window Layouts**. If you move a layout, the key binding is automatically adjusted to reflect the new position in the list. The key bindings themselves can't be modified, but you can store up to 10 layouts at a time.

:::image type="content" source="media/manage-window-layouts-sml.png" alt-text="Screenshot of the 'Manage Window Layouts' dialog." lightbox="media/manage-window-layouts-lrg.png":::

To remind yourself which keyboard shortcut is assigned to which layout, select **Window** > **Apply Window Layout**.

These layouts automatically roam between Visual Studio editions, and also between Blend instances on separate machines, and from any Express edition to any other Express organization. However, layouts don't roam across Visual Studio, Blend, and Express.

## Personalize tabs

You can personalize tabs to interact with document windows in several different ways. For example, you can view a preview of a file in the editor without opening the file, you can group your tabs, and more.

### Preview tab

In the **Preview** tab, you can view files in the editor without opening them. You can preview files by selecting them in **Solution Explorer**, during debugging when you step into files, with **Go to Definition**, and when you browse through results of a search. Preview files appear in a tab on the right side of the document tab well. The file opens for editing if you modify it or select  **Open**.

### Vertical document tabs

::: moniker range="vs-2022"

You can manage your document tabs in a vertical list on either the left or right side of your editor.

::: moniker-end

::: moniker range="vs-2019"

**[New in Visual Studio 2019 version 16.4 and later](/visualstudio/releases/2019/release-notes-v16.4/)**: We added one of the top feature requests, [vertical document tabs](https://developercommunity.visualstudio.com/idea/467369/vertical-group-tab.html). Now, you can manage your document tabs in a vertical list on either the left or right side of the editor.

:::image type="content" source="./media/vs-2019/vertical-tabs.gif" alt-text="An animation that shows vertical document tabs in action":::

::: moniker-end

You can apply vertical document tabs in the following ways:

- Select **Tools** > **Options** > **Environment** > **Tabs and Windows** from the menu bar. Then, from the **Set tab layout** control, select either **Top**, **Left**, or **Right** from the drop-down list.

- Right-click a tab, select **Set Tab Layout**, and then select either **Left** or **Right**. (To return the tabs to their default position, select **Top**.)

::: moniker range="vs-2022"

### Color document tabs

Visual Studio 2022 includes new personalization options you can use to help you code more efficiently. We added another top feature request, [color document tabs](https://devblogs.microsoft.com/visualstudio/personalize-docs/). Now, you can color file tabs by project so that you don't have to hunt for your open files.

> [!NOTE]
> To use color tabs, navigate to **Tools** > **Options** > **Environment** > **Tabs and Windows**, and then select **Colorize document tabs by project**.

Here are our updates, to date:

- **[New in Visual Studio 2022 version 17.0 and later](/visualstudio/releases/2022/release-notes-v17.0)**: You can now colorize tabs in both vertical and horizontal views in the Editor.

    The following screenshot shows an example of color tabs in the vertical view:

    :::image type="content" source="media/vs-2022/color-tabs-vertical.png" alt-text="Screenshot of color tabs in the vertical view.":::

    The following screenshot shows an example of color tabs in the horizontal view:

    :::image type="content" source="media/vs-2022/color-tabs-horizontal.png" alt-text="Screenshot of color tabs in the horizontal view.":::

- **[New in Visual Studio 2022 version 17.1 and later](/visualstudio/releases/2022/release-notes)**: You can also select your own tab colors. To do so, right-click on a tab and select **Set Tab Color** to pick from the palette.

    The following screenshot shows an example of how to personalize the color scheme of tabs:

    :::image type="content" source="media/vs-2022/color-tabs-personalize-schemes.png" alt-text="Screenshot of the Set Tab Option that you can use to personalize the colors of tabs.":::

> [!TIP]
> To learn more about the latest tabs updates in Visual Studio 2022, see the [**Improved doc management personalization**](https://devblogs.microsoft.com/visualstudio/doc-management-personalization/) blog post.

::: moniker-end

### Tab groups

Tab groups extend your ability to manage limited workspace while you're working with two or more open documents in the IDE. You can organize multiple document windows and tool windows into either vertical or horizontal tab groups and shuffle documents from one tab group to another.

## See also

- [How to: Move around in the IDE](../ide/how-to-move-around-in-the-visual-studio-ide.md)
