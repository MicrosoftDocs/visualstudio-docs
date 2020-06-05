---
title: XAML code editor
ms.date: 06/05/2020
ms.topic: conceptual
monikerRange: vs-2019
author: TerryGLee
ms.author: tglee
manager: jillfra
---
# XAML code editor

The XAML code editor in the [Visual Studio IDE](../get-started/visual-studio-ide.md) includes all the tools you need to create WPF and UWP apps for the Windows platform. This article outlines the role the code editor plays when you develop XAML-based apps, and on the features that are unique to the XAML code editor in Visual Studio 2019.

To start, let's take a look at the IDE (integrated development environment) with an open WPF project. The following image shows several of the key IDE tools you'll use along with the XAML code editor.

:::image type="content" source="media/xaml-code-editor-overview-sml.png" alt-text="The Visual Studio 2019 IDE with an open WPF project in XAML" lightbox="media/xaml-code-editor-overview-lrg.png":::

From the bottom left of the image going clockwise, the key IDE tools are as follows:

- The **[XAML code editor](#xaml-code-editor-ui)** window&mdash;the subject of this article&mdash;where you create and edit your code.
- The **[XAML Designer](creating-a-ui-by-using-xaml-designer-in-visual-studio.md)** window, where you design your UI.
- The **[Toolbox](../ide/reference/toolbox.md)** dockable window, where you add controls to your UI.
- The **[Debug](../debugger/debugger-feature-tour.md)** button, where you run your code and debug it. <br>(You can also edit your code in real-time while you're debugging with [XAML Hot Reload](xaml-hot-reload.md).)
- The **[Solution Explorer](../ide/solutions-and-projects-in-visual-studio.md)** window, where you manage your files, projects, and solutions.
- The **[Properties](../ide/reference/properties-window.md)** window, where you change the way your UI looks and how the UI controls work.

To continue, let's learn more about the XAML code editor.

## XAML code editor UI

The code editor window for XAML apps shares some UI (user interface) elements that also appear in our standard IDE, it also includes a few unique features that make developing XAML apps easier.

Here's a look at the XAML code editor window itself.

![Screenshot of the XAML code editor window in Visual Studio 2019](media/xaml-code-editor-window.png "Screenshot of the XAML code editor window in Visual Studio 2019")

Next, let's take a look at the functions of each of the UI elements in the code editor.

### Top left, first row

Starting at the top left, and from left to right, there's a **Design** tab, a **Swap Panes** button, a **XAML** tab, and a **Pop-Out XAML** button.

![Screenshot of the first of the two top rows of the XAML code editor window in Visual Studio 2019, in which UI elements on the left are highlighted](media/xaml-code-editor-top-row-left.png "Screenshot of the first of the two top rows of the XAML code editor window in Visual Studio 2019, in which UI elements on the left are highlighted")

Here's how they work:

- The **Design** tab changes the focus from the XAML code editor to the XAML Designer.
- The **Swap Panes** button reverses the location of the XAML Designer and the XAML code editor in the IDE.
- The **XAML** tab changes the focus back to the XAML code editor.
- The **Pop Out XAML** button creates a separate XAML code editor window that's outside of the IDE.

### Top right, first row

Continuing at the top right, and from left to right, there's a **Vertical Split** button, a **Horizontal Split** button, and a **Collapse Panes** button.

![Screenshot of the first of the two top rows of the XAML code editor window in Visual Studio 2019, in which UI elements on the right are highlighted](media/xaml-code-editor-top-row-right.png "Screenshot of the first of the two top rows of the XAML code editor window in Visual Studio 2019, in which UI elements on the right are highlighted")

Here's how they work:

- The **Vertical Split** button changes the location of the XAML Designer and the XAML code editor in the IDE from a horizontal alignment to a vertical alignment.
- The **Horizontal Split** button changes the location of the XAML Designer and the XAML code editor in the IDE from a vertical alignment to a horizontal alignment.
- The **Collapse Pane** button hides the XAML code editor temporarily while you focus on using the XAML Designer within the IDE. (To restore the XAML code editor, choose the same button again, which is now named the **Expand Pane** button.)

> [!TIP]
> You can run two parallel instances of the XAML code editor concurrently by using both the **Pop Out XAML** button and the **Expand Pane** button.
>
> You might find it useful to have one larger window open that reveals more of your code in context and a smaller pane open that has its focus directly on the code that you're working on.

### Top left, second row

In the second row of the top left, there are two Window dropdown lists. However, if you view the Tooltip for these UI elements, it further identifies them as the "Element: Window" and the "Member: Window".

![Screenshot of the second of the two top rows of the XAML code editor window in Visual Studio 2019, in which both Window dropdown lists are visible](media/xaml-code-editor-top-row-windows.png "Screenshot of the second of the two top rows of the XAML code editor window in Visual Studio 2019, in which both Window dropdown lists are visible")

The Window dropdown lists have different functions, as follows:

- The **Element: Window** on the left helps you view and navigate to sibling or parent elements.

  Specifically, it shows you an outline-like view that reveals the tag structure of your code. When you select from the list, your focus in the code editor will snap to the line of code that includes the element you selected.

    ![Screenshot of the Element: Window dropdown list in Visual Studio 2019](media/xaml-element-window-dropdown.png "Screenshot of the Element: Window dropdown list in Visual Studio 2019")

- The **Member: Window** on the right helps you view and navigate to attribute or child elements.

    Specifically, it shows you a list of the properties in your code. When you select from the list, your focus in the code editor will snap to the line of code that includes the property you selected.

    ![Screenshot of the Member: Window dropdown list in Visual Studio 2019](media/xaml-member-window-dropdown.png "Screenshot of the Member: Window dropdown list in Visual Studio 2019")

### Middle pane, code editor

The middle pane is the "code" part of the XAML code editor. It includes most of the features that you'll find in the [IDE code editor](../get-started/tutorial-editor.md). We'll touch on several of the universal IDE features that can help you develop your XAML code. We'll also highlight the unique-to-XAML features in the IDE, too.

![Screenshot of the XAML code editor, middle pane only, in Visual Studio 2019](media/xaml-code-editor-middle.png "Screenshot of the XAML code editor, middle pane only, in Visual Studio 2019")

#### Quick actions

You can use [Quick Actions](../ide/quick-actions.md) to refactor, generate, or otherwise modify code with a single action.

**Remove unnecessary usings**

One useful task is to remove the unnecessary usings from the code in the **MainWindow.xaml.cs** tab. Here's how:

1. Hover over a using statement, choose the lightbulb icon, and then choose **Remove Unnecessary Usings** from the drop-down list.

    ![Screenshot of the IDE editor's "Remove Unnecessary Usings" option from the Quick Actions menu](media/xaml-code-editor-remove-usings.png "Screenshot of the IDE editor's Remove Unnecessary Usings option from the Quick Actions menu")
    
1. Choose whether you want to fix all occurrences in the **Document**, the **Project**, or the **Solution**.
1. View the **Preview** dialog, and then choose **Apply**.

You can also access this feature from the menu bar. To do so, choose **Edit** > **IntelliSense** > **Remove and Sort Usings**.

For more information about usings settings, see the [Sort usings](../ide/reference/sort-usings.md) page. And, for more information about some of the typical ways that developers use Quick Actions, see the [Common Quick Actions](../ide/common-quick-actions.md) page.

#### Change tracking

The color of the left margin allows you to keep track of the changes you have made in a file. Here's how the colors relate to the actions you take:

- Changes you have made since the file was opened but not saved are denoted by a **yellow** bar on the left margin (known as the selection margin).
- After you have saved the changes (but before closing the file), the bar turns **green**.
- If you undo a change after you have saved the file, the bar turns **orange**.

To turn this feature off and on, change the **Track changes** option in the **Text Editor** settings (**Tools** > **Options** > **Text Editor**).

For more information about change tracking&mdash;to include the wavy lines (also known as "squiggles") that appear under code strings&mdash;see the **[Editor features](../ide/writing-code-in-the-code-and-text-editor.md#editor-features)** section of the [Features of the Visual Studio code editor](../ide/writing-code-in-the-code-and-text-editor.md) page.

#### Right-click context menu

When you are editing your code in the XAML code editor, there are several features that you can access by using the right-click context menu. Most of these features are available universally in the Visual Studio IDE, while some are specific to using a code editor along with a Design window. 

![Screenshot of the XAML code editor's right-click context menu in Visual Studio 2019](media/xaml-code-editor-right-click-menu.png "Screenshot of the XAML code editor's right-click context menu in Visual Studio 2019")

Here's what each feature does and how it's useful:

- **View Code** - Opens the programming language code window, which is typically tabbed next to the default view that includes the Design window and the XAML code editor. 
- **View Designer** - Opens the default view that includes the Design window and the XAML code editor. (If you are already in the default view, it does nothing.) 
- **Quick Actions and Refactorings** - Refactors, generates, or otherwise modifies code with a single action. When you hover over code, you'll see a lightbulb icon when a quick action or refactoring is available. <br>See also: [Quick Actions](../ide/quick-actions.md) and [Refactor code](../ide/refactoring-in-visual-studio.md).
- **Rename...** - Renames namespaces only. If you don't have a namespace to rename, you'll receive an error message that says "Only namespace prefixes and be renamed." 
- **Remove and Sort Namespaces** - Removes unused namespaces and then sorts those that remain. 
- **Peek Definition** - Previews the definition of a type without leaving your current location in the editor. <br>See also: [Peek Definition](../ide/go-to-and-peek-definition.md#peek-definition) and [View and edit code by using Peek Definition](../ide/how-to-view-and-edit-code-by-using-peek-definition-alt-plus-f12.md).
- **Go To Definition** - Navigates to the source of a type or member, and opens the result in a new tab. <br>See also: [Go To Definition](../ide/go-to-and-peek-definition.md#go-to-definition).
- **Surround with...** - Use surround-with code snippets, which are added around a selected block of code. <br>See also: [Expansion snippets and surround-with snippets](../ide/code-snippets.md#expansion-snippets-and-surround-with-snippets).
- **Insert Snippet** - Inserts a code snippet at the cursor location. 
- **Cut** - Self-explanatory 
- **Copy** - Self-explanatory 
- **Paste** - Self-explanatory 
- **Outlining** - Expand and collapse sections of code. <br>See also: [Outlining](../ide/outlining.md). 
- **Source Control** - View the history of code contributions to an open source repository. 

### Middle pane, scroll bar

The scroll bar can do more than scroll through your code. You can also use it to open another code editor pane. And, you can use the scroll bar to help you code more efficiently by adding annotations to it, or by using different display modes.

#### Split the code window

In the scroll bar of the code editor, there's a **Split** button at the top right. When you choose it, you can open another code editor pane. This is useful because they operate independently of each other, so you can use them to work on code in different locations.

![Screenshot of the XAML code editor, middle pane only, in Visual Studio 2019](media/code-editor-split-window-button.png "Screenshot of the XAML code editor, middle pane only, in Visual Studio 2019")

For more information about how to split an editor window, see the [Manage editor windows](../ide/how-to-manage-editor-windows.md) page.

#### Use annotations or map mode

You can also change how the scroll bar looks and what additional features it contains. For example, many people like to include *annotations* in the scroll bar, which provide visual cues such as code changes, breakpoints, bookmarks, errors, and caret position.

Others appreciate using *map mode*, which displays lines of code in miniature on the scroll bar. Developers who have a lot of code in a file might find that map mode tracks to lines of code more effectively than does the default scroll bar.

For more information about how to change the default settings of the scroll bar, see the  [Customize the scroll bar](../ide/how-to-track-your-code-by-customizing-the-scrollbar.md) page.

## XAML-specific features

Most of the following features are universally available in the Visual Studio IDE, yet there are added dimensions to some of them that make coding easier for XAML developers.

### XAML code snippets

Code snippets are small blocks of reusable code that you can insert into in a code file by using the right-click context menu command **Insert snippet** or a combination of hotkeys (**Ctrl**+**K**, **Ctrl**+**X**). We've enhanced IntelliSense so that it supports showing XAML snippets, which works for both built-in snippets and any custom snippets that you add manually. Some out-of-the-box XAML snippets include `#region`, `Column definition`, `Row definition`, `Setter`, and `Tag`.


![Screenshot of the XAML code editor with #region options showing in IntelliSense](media/xaml-code-snippets.png "Screenshot of the XAML code editor with #region options showing in IntelliSense")

For more information, see the [Code snippets](../ide/code-snippets.md) and [C# code snippets](../ide/visual-csharp-code-snippets.md) pages. 

### XAML #region support

Starting with Visual Studio 2015, we made #region support available for XAML developers in WPF and UWP, and more recently in Xamarin.Forms, too. In Visual Studio 2019, we continue to make incremental improvements to #region support. For example, in [version 16.4](/visualstudio/releases/2019/release-notes-v16.4.md) and later, #region options show as you begin to type `<!`.

![Screenshot of the XAML code editor with #region options showing in IntelliSense](media/code-editor-xaml-region.png "Screenshot of the XAML code editor with #region options showing in IntelliSense")

You can use regions when you want to group sections of your code that you also want to expand or collapse. 

```xaml
    <!--#region NameOfRegion-->
    Your code is here
    <!--#endregion-->
```

For more information about regions, see the [#region (C# Reference)](/dotnet/csharp/language-reference/preprocessor-directives/preprocessor-region.md) page. And for more information about expanding and collapsing sections of code, see the [Outlining](../ide/outlining.md) page.

### XAML Comments

We support comments; identical to C#

### XAML lightbulbs

Lightbulb icons that appear in your XAML code are part of the [Quick Actions](../ide/quick-actions.md) that you can use to refactor, generate, or otherwise modify code. 

Here are a few examples of how they can benefit your XAML coding experience:

- **Remove unnecessary namespaces**. In the XAML code editor, unnecessary namespaces appear in dimmed text. If you hover your cursor over an unnecessary using, a lightbulb will appear. When you choose the **Remove Unnecessary Namespaces** option from the drop-down list, you'll see a preview of that which you can remove.

  ![Screenshot of the XAML code editor's Remove Unnecessary Namespaces option from the Quick Actions lightbulb](media/xaml-code-editor-dimmed-namespaces-preview.png "Screenshot of the XAML code editor's Remove Unnecessary Namespaces option from the Quick Actions lightbulb")

- **Rename namespace** ***MORE TEXT HERE!*** by using F2. This feature, available both from the right-click context menu and by highlighting a value and then pressing **F12**, makes it easy to change settings on-the-fly. For example,  

  For more information, see the [Move type to namespace](../ide/reference/move-type-to-namespace.md) page.

#### UWP – Add conditional XAML

Unique feature. Say its supported. Documented to page that Dmitry linked in chat. IS THIS XAML ISLANDS?

### XAML 

### Structure Analyzers (dotted lines between the tags vertically)

ADD TEXT HERE! Basically, hierarchy view by tabs/gridlines. Especially useful in files with a lot of code in them, so that you can see where you're at in the structure of your code.

### Settings

For more information about *all* the settings in the Visual Studio IDE, see the [Features of the code editor](../ide/writing-code-in-the-code-and-text-editor.md) page.

## XAML optional settings

You can use the [Options](../ide/reference/options-dialog-box-visual-studio.md) dialog box to change the default settings for the XAML code editor. To view the settings, choose **Tools** > **Options** > **Text Editor** > **XAML**.

![Screenshot of the Options list for the XAML text editor](media/xaml-tools-options.png "Screenshot of the Options list for the XAML text editor")

> [!NOTE]
> You can also use keyboard shortcuts to access the Options dialog box. Here's how: Press **Ctrl**+**Q** to search the IDE, type **Options**, and then press **Enter**. Next, press **Ctrl**+**E** to search the Options dialog box, type **Text Editor**, press **Enter**, type **XAML**, and then press **Enter**.
>  
> For more information about keyboard shortcuts, see the [Shortcut tips for Visual Studio](../ide/productivity-shortcuts.md#code-editor) page.

### Universal text editor options

In the [Options](../ide/reference/options-text-editor-xaml-formatting.md) dialog box for XAML, the following first three items are universal to all programming languages that the Visual Studio IDE supports. Visit the linked information in the following table to find out more about these options and how to use them.

|Name  |More info  |
|---------|---------|
|General  | [Options dialog box: Text Editor > All Languages](../ide/reference/options-text-editor-all-languages.md) |
|Scroll bars | [Options, Text Editor, All Languages, Scroll Bars]() |
|Tabs  |  [Options, Text Editor, All Languages, Tabs](../ide/reference/options-text-editor-all-languages-tabs.md) |

### XAML-specific text editor options

The following table lists the settings in the [Options](../ide/reference/options-text-editor-xaml-formatting.md) dialog box that can enhance your editing experience when you develop XAML apps. Visit the linked information to find out more about these options and how to use them.

|Name  |More info  |
|---------|---------|
|Formatting | [Options, Text Editor, XAML, Formatting](../ide/reference/options-text-editor-xaml-formatting.md) |
|Miscellaneous |  [Options, Text Editor, XAML, Miscellaneous](../ide/reference/options-text-editor-xaml-miscellaneous.md) |

> [!TIP]
> The **Capitalize event handler method name** setting in the **Miscellaneous** section is especially useful to XAML developers. This setting is *off* by default because it's new, but we suggest that you set it to *on* to support proper casing in your code.

## Next steps

To learn more about how to edit your code in real-time while you're running your app in debug mode, see the [XAML Hot Reload](xaml-hot-reload.md) page.

## See also

- [Visual Studio code editor features](../ide/writing-code-in-the-code-and-text-editor.md)
- [XAML in UWP apps](/windows/uwp/xaml-platform/xaml-overview)
- [XAML in Xamarin.Forms apps](/xamarin/xamarin-forms/xaml/)
