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



