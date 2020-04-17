---
title: XAML code editor
ms.date: 04/20/2020
ms.topic: conceptual
author: TerryGLee
ms.author: tglee
manager: jillfra
---
# XAML code editor

The XAML code editor in the [Visual Studio IDE](../../get-started/visual-studio-ide.md) includes all the tools you need to create WPF and UWP apps for the Windows platform. The XAML code editor supports modern intelligence by way of IntelliCode. It also supports the [XAML Hot Reload](xaml-tools/xaml-hot-reload.md) feature, which allows you to edit your app's code and UI on-the-fly in real-time while debugging.

Here is a screenshot of the XAML code editor experience. (We'll break this down for you further; read on.) 

![The XAML code editor in Visual Studio 2019](../media/xaml-code-editor-overview.png#lightbox)

## XAML code editor window

The code editor window for XAML apps has many of the features you find in our standard IDE, and also a few unique features that make developing XAML apps easier.

First, in the following screenshot, let's take a look at the code window itself.

![The XAML code editor window in Visual Studio 2019](../media/xaml-code-editor-window.png)


(example pop-up button, unique to XAML code editor)




| Icon | Location | Name | Function | Appears in... |
| - | - | - | - | - |
| ![XAML code editor - name of feature](../xaml-tools/media/name-of-file.png) | Code editor | Tooltip description | (Add detailed description) | Code editor |
| ![XAML code editor - name of feature](../xaml-tools/media/name-of-file.png) | Code editor | Tooltip description | (Add detailed description) | Code editor |
| ![XAML code editor - name of feature](../xaml-tools/media/name-of-file.png) | Code editor | Tooltip description | (Add detailed description) | Code editor |


### Left side icons [see if we have docs for what the colors means]

### Right side scrollbar indicators

### Various buttons on the right side such as:

- Swap designer with editor
- Expanse/Collapse
- Button to drag out two parallel code editors
- Unused Usings, lightbulb for removing

Annotated with highlights

Right-click menu

Quick Actions
Only expands a lightbulb if its available
Rename (namespaces only)
Peek Definition
Go To Definition
Snippet Features
Surround With
Insert Snippet
Outline

Dropdowns over the code editor

[left] Document outline like
[Right] Properties of selected item

Highlight unique things

XAML support for snippets
XAML #regions
XAML Comments
Lightbulbs
All Platforms - Adding missing namespace
UWP – Add conditional XAML
XAML Rename namespace using F2
Structure Analyzers (dotted lines between the tags vertically)
Only between tags and not container properties
Settings

Where to go to change code editor settings (Text Editors > XAML > General)

[Screenshot of Formatting General]

What's specific to XAML:

Formatting Options (XAML specific) described
General
Spacing
Misc.
Capitalize event handlers there to support proper casing, off by default since its new

## Next steps

To get started coding, see the []() page.

## See also

- [Visual Studio code editor features](../../ide/writing-code-in-the-code-and-text-editor.md)
- [XAML in UWP apps](/windows/uwp/xaml-platform/xaml-overview)
- [XAML in Xamarin.Forms apps](/xamarin/xamarin-forms/xaml/)
