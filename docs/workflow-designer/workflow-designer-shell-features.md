---
title: "Workflow Designer Shell Features"
description: Learn how the Workflow Designer Shell features contain a number of buttons for managing the current view.
ms.date: 11/04/2016
ms.topic: article
f1_keywords:
  - "WFDShellFeatures.UI"
author: sayedihashimi
ms.author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Workflow Designer Shell Features

Workflow Designer is composed of three major UI areas: the designer surface, the breadcrumb bar above it and the shell below it. The breadcrumb bar, positioned at the top of the screen, is used to display the list of ancestors of the current root activity. For more information, see [How to: Use Breadcrumb Navigation](../workflow-designer/how-to-use-breadcrumb-navigation.md). The designer surface, positioned at the center of the screen, is used to compose workflows. The shell, positioned at the bottom of the screen, contains a number of buttons for managing the current view.

## Shell Features
 The shell has buttons on the right side of the bar that you can use to zoom in or out of your workflow, fit the contents of your workflow to the size of your screen, and show or hide the overview map. You can also zoom in or out of a workflow using the keyboard shortcuts CTRL++ and CTRL+-.

## `Overview` Map
 The overview map displays a small version of the entire activity at the current breadcrumb root, including all of its children and all of their expanded children. There is a viewport, a rectangle with an orange border, which highlights the portion of the activity currently displayed inside the editor. Dragging the rectangle around the overview map scrolls the workflow designer and changes the view of the editor.

> [!NOTE]
> The Workflow Designer user interface is virtualized. The activity designers are rendered only when required. If a portion of the workflow has never been drawn on the designer surface, that portion appears as white on the overview map. Scrolling around the overview map completely draws the workflow.

## Copying or Saving Workflows as Images
 Workflows can be copied in bitmap format or saved in bitmap or vector format. Copying or saving an image provides a way to export a view of entire activity at the current breadcrumb root, including all of its children and all of their expanded children to another program.

 To copy as image, right-click anywhere in the designer and select **Copy as Image**. To save as image, right-click anywhere in the designer and select **Save as Image**. Workflows can be saved in JPG, PNG, GIF, or XPS format. The format is selected on the **Save As** dialog box in the **Save as Type:** drop down list box at the bottom of the window.

## Fonts and Colors

The fonts used in Workflow Designer inside Visual Studio are controlled by the environment font. The colors displayed in Workflow Designer change if you are using a high contrast color scheme for your operating system theme. You must restart Visual Studio after making a change to the font or color settings before the changes take effect in Workflow Designer.
