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

## Use multiple project types in Visual Studio

Visual Studio Solutions provide a convenient place to gather and manage related projects in one logical place. This helps keep your code organized and facilitates collaboration within teams.

In the example shown below, the solution contains an R project with a model build using R and Azure Machine Learning, a Python/scikit-learn project, a C++ project containing modules for intensive computational work, a SQL project for data management, and a Python/Bottle project for the web site that publishes the result:

![Visual Studio Solution Explorer showing multiple related projects in a solution](media/projects-polyglot.png)

Note that there currently isn't any explicit R to C#/C++ language integration in place (as there is for Python, see [Creating a C++ extension for Python](../python/cpp-and-python.mdd)).  However there are libraries available that provide C# and C++ bridges for R.

For more details on managing projects and solutions in general, see [Solutions and Projects in Visual Studio](../ide/solutions-and-projects-in-visual-studio.md).
