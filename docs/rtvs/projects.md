---
title: "Projects in R Tools for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: 4/10/2017
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "devlang-r"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 732b73cf-2014-4f98-838e-4141ef9dedac
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
translation.priority.ht:
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---


# How to start a new project using R Tools for Visual Studio

1. Start Visual Studio 2015
2. Choose **File > New > **Project...**
3. Select the R Project from the R templates.

   ![](media/open-project-template.png)

4. Name the project in the **Name:** box.
5. Test that the R **Interactive** pane is working by typing in 3 + 4 and then Enter to see the answer displayed.

    ![](media/open-project-test.png)

# Try some of the samples

You can also try one of our sample projects.  Just download, open and run:

[Samples documentation](getting-started-samples.md)

# Use multiple project types in Visual Studio

In Visual Studio, related files are collected into a **Project**, and related Projects are collected into a **Solution**.  

Here we see a Solution that consists of 5 separate Projects made up of C++, R, Python and SQL code.  The user has built a model using R/Azure ML, Python/scikit-learn, C++ for compute intensive work, SQL for data management, and finally a Python/Bottle project to share results via Azure:

![Help window](media/projects-polyglot.png)

Solutions provide a convenient place to gather and manage relevant Projects (which maybe worked on by other team members) in one logical place.

Note that there isn't currently any explicit R to C#/C++ language integration in place yet.  However there are libraries available that provide bridges between C#/R and C++/R.
