---
title: Source Editor
description: Using the source editor in Xamarin Studio
author: asb3993
ms.author: amburns
ms.date: 04/14/2017
ms.topic: article
ms.assetid: A018A314-C1C4-4F36-BCB6-2D434208FCFE
---

# Overview

A reliable source editor is essential for writing code succinctly and efficiently. Xamarin Studio provides a sophisticated source editor that is at the center of a developer’s interactions with the IDE. Xamarin Studio's source editor provides many features that developers expect and need to do their work with ease: From the basics such a syntax highlighting, code snippets, and code folding to the benefits of its Roslyn compiler integration, such as fully functional IntelliSense code completion.

The source editor in Xamarin Studio allows for a seamless experience with all of the other functionality provided by Xamarin Studio such as debugging, refactoring, and version control integration.

This guide will introduce some of the key features of the source editor, and will explore how you can use Xamarin Studio to be as productive as possible.

# The Source Editor Experience

Viewing and moving efficiently throughout your code is an integral part of the development workflow. Exactly how a developer decides to view their code is a personal decision, which varies between developers – and often between projects. 

Xamarin Studio offers many powerful features to make cross-platform development as accessible and as useful as possible. The sections below describe some of the highlights.


## Code Folding

Code folding makes it easier to manage large source code files by allowing developers to show or hide complete sections of code, such as using directives, boilerplate code and comments, and #region statements.

To turn on code folding, navigate to **Preference > Text Editor > General > Code Folding**:

![](Images/source-editor-image1a.png)

In addition to providing the option to enable code folding, this menu also includes the option to fold #regions and comments by default, displaying a named hint, in place of code.

To show or hide sections, use the disclosure widget next to the line number:

 ![](Images/source-editor-image2.png)

You can also toggle folds by using the **View > Folding** menu item:

 ![](Images/source-editor-image19.png)

This menu item can also be used to enable or disable code folding.

## White Space

It is necessary to be able to view invisible characters in source code. It's a visible way to ensure that you are adhering to coding standards and not needlessly wasting space. It's also very useful when writing F#, which depends on precisely indented lines for evaluating code.

Set options to show whitespace by navigating to **Xamarin Studio > Preferences > Text Editor > Markers and Rulers**, as illustrated below. Selecting this option allows setting _when invisible_ characters will be shown: Never, On Selection, or Always:

 ![](Images/source-editor-image3.png)

The option to show tabs, spaces, and line endings is also available:

 ![](Images/source-editor-image4.png)

## Ruler

Showing the column ruler is useful for determining line lengths, particularly when working on a team that has line length guidelines. The column ruler can be turned on or off by navigating to **Xamarin Studio > Preferences > Text Editor > Markers and Rulers** and selecting (or deselecting) **Show Column ruler**, as illustrated below:

 ![](Images/source-editor-image5.png)


## Highlight Identifier References

When this option is turned on, a developer can place the caret on any symbol in the source code and the source editor will provide a visual guide to all other references in that file. This is turned on by navigating to **Xamarin Studio > Preferences > Text Editor > Markers and Rulers** and selecting _Highlight identifier references_, as illustrated below:

![](Images/source-editor-image6.png)

The color of the highlight is also useful for denoting if something is being assigned or referenced. If something is assigned, it is highlighted in red; if it is referenced, it is highlighted in blue:

![](Images/source-editor-image7.png)

# Comments

When debugging or experimenting with code, it can be very useful to comment a block of code temporarily.

To comment out an entire block of code:

* Select the code and select **Toggle Line Comment(s)** from the context menu

OR

* Use the <code>&#8984; + /</code> keybinding on the selected code.

These methods can be used to comment and uncomment sections of code. In C# files, additional levels of line comments can be added, which allows regions of codes to be commented and uncommented, while still preserving actual comments: 

 ![](Images/source-editor-image8.png)

Comments are also useful for documenting code for future developers that may interact with it. These are usually done in the form of multi-line comments, which is added in the following way in each language:

**C#**

```
/*
 This is a multiline
 comment in C#
*/
```
**F#**

```
(*
 This is a multiline
  comment in F#
*)
```

# Editor Behavior 

Many editor behaviors can be set that allow code to be formatted as it is written. These actions are set under **Preferences > Text Editor > Behavior**, and some of the more commonly used functions are described below:

![](Images/source-editor-image9.png)


*  Matching closing braces can be added automatically to code when creating new classes, methods, or properties. When this option is selected, typing `{` will automatically add `}`.
* On the fly code formatting is triggered by particular character presses such as semi-colon or braces, which will emulate the formatting preferences that are set.
* You can also choose to format the file when saving it, which allows the writing of code as desired and leaves the IDE responsible for formatting code as set by existing preferences.
* Indentation can be set to None, Auto, or Smart. These do the following:
 * None – sets the caret to the start of the next line
 * Auto – sets the caret to the same column on the next line
 * Smart – indents on the following line based on the code
* Word breaking behavior differs between OSes, and for navigation purposes, the text editor needs to know where words begin or end. The formatting can be set to Unix or Windows.


# Task Comments

When writing code, it is standard practice to explicitly comment unfinished or questionable code or quick workarounds with warnings. The default signal tokens provided by Xamarin Studio are TODO, HACK, FIXME, UNDONE, although personalized tokens can be defined under **Preferences > Environment > Task List**, which is illustrated below:

 ![](Images/source-editor-image10.png)

Xamarin Studio draws attention to these markers by highlighting them in the Task List pad, which can be displayed by navigating to **View > Pads > Task**:

![](Images/source-editor-image11.png)

# Snippets 

Code snippets, often referred to as _code templates_, are useful for efficient programming because they allow the insertion and editing of pre-written blocks of code. Using code snippets can be particularly convenient for quickly adding common patterns, or even for learning new patterns when you the developer is unsure of syntax. There are templates provided for C#, F#, HTML XML, Python, and Razor.

This section will explain how to create, insert, and use snippets in code.



## Inserting a Snippet

There are some different ways to add code snippets, which are described below:
 
* **Tab Expansion** – Start typing the template name, select it from the list and press **TAB TAB** to add it:
 
  ![](Images/source-editor-image13.png)

* **Toolbox** – Use the toolbox pad to display a list of all code snippets. Drag any template desiired from the toolbox into the correct position in the source code:

 ![](Images/source-editor-image14.png)

* **Insert Templates command** – There is currently no default keybinding set for inserting a template. To create one, browse to **Preferences > Key Bindings** and search for `template`. This allows adding the desired key binding into the Edit Binding field, then click **Apply**:

 ![](Images/source-editor-image15.png)

## Creating a new template

While there are many existing templates in a variety of languages that you can use and edit, new templates can also be added by navigating to **Xamarin Studio > Preferences > Text Editor > Code Templates**:

![](Images/source-editor-image12.png)


# Block Selection 

Xamarin Studio makes it straighforward to select, cut, copy, and paste sections of your code. Rectangular blocks of code can be highlighted and selected by using the   **Option + Drag** command on the code block. The formatting within this block selection is retained when pasting the block.

Block selections can also be edited, to modify text on multiple lines at once. A zero-width block selection can be used to place the caret in front of many lines at once, and allows typing identical text on multiple lines.

 ![](Images/source-editor-image16.png)

# Editor Themes

Editor themes can be changed to any of the ten color schemes provided by default in Xamarin Studio via the **Preferences > Text Editor > Syntax Highlighting** menu options:

 ![](Images/source-editor-image17.png)

The developer also has fine grain control over syntax highlighting, allowing the creation of custom color schemes. This is done via the **Syntax Highlighting** menu, which is displayed in the image above. Select the **New** button, choose the color scheme desired for the new color scheme to be based on, and click **OK**. This will allow changing the foreground and background colors for many different objects, as illustrated below:

 ![](Images/source-editor-image18.png)





