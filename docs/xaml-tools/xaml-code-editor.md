---
title: XAML code editor
ms.date: 04/22/2020
ms.topic: conceptual
author: TerryGLee
ms.author: tglee
manager: jillfra
---
# XAML code editor

The XAML code editor in the [Visual Studio IDE](../../get-started/visual-studio-ide.md) includes all the tools you need to create WPF and UWP apps for the Windows platform. This article outlines the role the code editor plays when you develop XAML-based apps, and on the features that are unique to the XAML code editor in Visual Studio 2019. 

To start, let's take a look at the IDE (integrated development environment) with an open WPF project. The following image shows several of the key IDE tools you'll use along with the XAML code editor. From the bottom left of the image going clockwise, they are: 

[![The Visual Studio 2019 IDE](media/xaml-code-editor-overview.png "An annotated screenshot of the Visual Studio IDE with a WPF project open, which includes the XAML code editor window") ](media/xaml-code-editor-overview.png#lightbox)

- The **[XAML code editor](#xaml-code-editor-window)** window&mdash;the subject of this article&mdash;where you create and edit your code. 
- The **[XAML Designer](creating-a-ui-by-using-xaml-designer-in-visual-studio.md)** window, where you design your UI.
- The **[Toolbox](../../ide/reference/toolbox.md)** dockable window, where you add controls to your UI.
- The **[Debug](../../debugger/debugger-feature-tour.md)** button, where you run your code and debug it. <br>(You can also edit your code in real-time while you're debugging with [XAML Hot Reload](xaml-tools/xaml-hot-reload.md).)
- The **[Solution Explorer](../../ide/solutions-and-projects-in-visual-studio.md)** window, where you manage your files, projects, and solutions. 
- The **[Properties](../../ide/reference/properties-window.md)** window, where you change the way your UI looks.

To continue, let's learn more about the XAML code editor. 

## XAML code editor window

The code editor window for XAML apps has many of the features you find in our standard IDE, and also a few unique features that make developing XAML apps easier.

Here's a look at the code window itself.

![Screenshot of the XAML code editor window in Visual Studio 2019](media/xaml-code-editor-window.png)

Next, let's take a look at the functions of each of the UI elements in the code editor.

### Top left, first row

Starting at the top left, and from left to right, there's a Design tab, a Swap Panes button, a XAML tab, and a Pop-Out XAML button.

![Screenshot of the first of the two top rows of the XAML code editor window in Visual Studio 2019, in which UI elements on the left are highlighted](media/xaml-code-editor-top-row-left.png)

Here's how to use each of these tabs and buttons: 

- To change the focus from the XAML code editor to the XAML Designer, choose the **Design** tab.
- To reverse the location of the XAML Designer and the XAML code editor in the IDE, choose the **Swap Panes** button.
- To change the focus back to the XAML code editor, choose the **XAML** tab.
- To create a separate XAML code editor window that is outside of the IDE, choose the **Pop Out XAML** button.

### Top right, first row

Continuing at the top right, and from left to right, there's a Vertical Split button, a Horizontal Split button, and a Collapse Panes button.

![Screenshot of the first of the two top rows of the XAML code editor window in Visual Studio 2019, in which UI elements on the left are highlighted](media/xaml-code-editor-top-row-right.png)

Here's how to use each of these buttons:

- To change the location of the XAML Designer and the XAML code editor in the IDE from a horizontal alignment to a vertical alignment, choose the **Vertical Split** button.
- To change the location of the XAML Designer and the XAML code editor in the IDE from a vertical alignment to a horizontal alignment, choose the **Horizontal Split** button.
- To hide the XAML code editor temporarily while you focus on using the XAML Designer within the IDE, choose the **Collapse Pane** button. (To restore the XAML code editor, choose the same button again, now named the **Expand Pane** button.)

(example pop-up button, unique to XAML code editor)

| Icon | Location | Name | Function | Appears in... |
| - | - | - | - | - |
| ![XAML code editor - name of feature](media/name-of-file.png) | Code editor | Tooltip description | (Add detailed description) | Code editor |
| ![XAML code editor - name of feature](media/name-of-file.png) | Code editor | Tooltip description | (Add detailed description) | Code editor |
| ![XAML code editor - name of feature](media/name-of-file.png) | Code editor | Tooltip description | (Add detailed description) | Code editor |

### Left side icons 

[see if we have docs for what the colors means]

### Right side scrollbar indicators

#### Various buttons on the right side such as:

- Swap designer with editor
- Expanse/Collapse
- Button to drag out two parallel code editors
- Unused Usings, lightbulb for removing

Annotated with highlights

Right-click menu

- Quick Actions
- Only expands a lightbulb if its available
- Rename (namespaces only)
- Peek Definition
- Go To Definition
- Snippet Features
- Surround With
- Insert Snippet
- Outline

Dropdowns over the code editor

- left: Document outline like
- right: Properties of selected item

Highlight unique things

- XAML support for snippets
- XAML #regions
- XAML Comments
- Lightbulbs
- All Platforms - Adding missing namespace
- UWP – Add conditional XAML
- XAML Rename namespace using F2
- Structure Analyzers (dotted lines between the tags vertically)
- Only between tags and not container properties
- Settings

## XAML code editor settings

Where to go to change code editor settings (Text Editors > XAML > General)

![Screenshot of the Options menu for the XAML text editor](media/xaml-tools-options.png)

![Screenshot of the Options menu for the XAML text editor](media/xaml-tools-options-test.png)

## XAML-specific tools

What's specific to XAML:

- Formatting Options (XAML specific) described
- General
- Spacing
- Misc.
- Capitalize event handlers there to support proper casing, off by default since its new

## Next steps

To get started coding, see the [Title Name](pagename.md) page.

## See also

- [Visual Studio code editor features](../../ide/writing-code-in-the-code-and-text-editor.md)
- [XAML in UWP apps](/windows/uwp/xaml-platform/xaml-overview)
- [XAML in Xamarin.Forms apps](/xamarin/xamarin-forms/xaml/)
