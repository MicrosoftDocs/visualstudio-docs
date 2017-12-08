---
title: "Introduction to projects and solutions in in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "12/11/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: vs-ide-general
ms.tgt_pltfrm: ""
ms.topic: "quickstart"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
---
# Quickstart: projects and solutions

In this 10-minute quickstart, we'll explore what it means to create a solution and a project in Visual Studio. We'll look at the properties of a project and some of the files it can contain. We'll also create a reference to a second project.

## Solutions

Solutions are containers used by Visual Studio to organize one or more related projects. When you open a solution in Visual Studio, it will automatically load all the projects it contains.

### Create a solution

We'll start our exploration by creating an empty solution. After you get to know Visual Studio, you probably won't find yourself creating empty solutions too often. When you create a new project in Visual Studio, it automatically creates a solution to house the project if there's not a solution already open.

1. Start Visual Studio.

   Visual Studio opens, and you'll likely see the **Start Page** taking up most of the window's real estate.

1. On the menu bar, choose **File** > **New** > **Project...**.

   The **New Project** dialog box opens.

1. In the left pane, expand **Other Project Types**, then choose **Visual Studio Solutions**. In the center pane, choose **Blank Solution**. Name your solution "QuickSolution", then choose **OK**.

   The **Start Page** closes, and a solution appears in **Solution Explorer** on the right side of the Visual Studio window. You'll probably use **Solution Explorer** often, to browse the contents of your projects.

### Add a project

