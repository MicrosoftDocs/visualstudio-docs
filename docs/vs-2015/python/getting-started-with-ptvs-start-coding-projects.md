---
title: "Getting Started with PTVS: Start Coding (Projects) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-python
ms.topic: conceptual
ms.assetid: 14b85e70-b9a8-415c-a307-8c8c316a0495
caps.latest.revision: 7
author: "kraigb"
ms.author: "kraigb"
manager: jillfra
---
# Getting Started with PTVS: Start Coding (Projects)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Python Tools for Visual Studio (PTVS) helps you manage your code. 
 
 You can watch these instructions in a very short [youtube video](https://www.youtube.com/watch?v=KHPoVpL7zHg&list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff&index=2). 
 
 If you've used Python before, you know that your project is defined by how you lay out files on disk. This works great for plain Python projects, but when you have more files (web pages with JavaScript, unit tests, and build scripts), file systems can start to be a bit limiting. Visual Studio uses projects to achieve three things. 
 
- Identify critical files. Important files are those you check into a version control system (source files, resources, etc.), but not files that are generated as build output. Important files are also those that you would copy to another computer so that someone else can work on your app. 
 
- Specify how files should be used. You might have files that a tool needs to process whenever the files change. Visual Studio projects can capture this information 
 
- Define the boundaries of your components. If you have multiple components in your app, you can put each one in a separate project. These may eventually be deployed to different servers, built with different build or debug settings, or could even be written using another language supported by Visual Studio such as C++ or Node.js 
 
  There are several project templates to help get you started. If you already have Python code that you'd like to work on, the From Existing code wizard will help you create a project that includes all of your files. Multiple Web projects exist for some popular frameworks. More templates are available in the PTVS samples pack. There are options to make the provided web templates work with other frameworks. The Python Application template is a clean, empty project. There's one module to get you started. 
 
  Visual Studio shows your open projects in the Solution Explorer window, including all files, search paths, and Python environments. To add new items, select your project folder and from the context menu (press the right pointer button), choose Add and then New Item. You can select any item in the dialog, customize the item’s name, and add the item to the project. 
 
  You can drag and drop into the Solution Explorer. If you've already copied files into your project directory structure, you can choose Show All Files at the top of the Solution Explorer. Then you can select the items you want to add, and from the context menu, choose Include in Project. 
 
  You can watch these instructions in a very short [youtube video](https://www.youtube.com/watch?v=KHPoVpL7zHg&list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff&index=2). 
 
## See Also 
 [Wiki documentation](https://github.com/Microsoft/PTVS/wiki/Projects) 
 [PTVS Getting Started and Deep Dive Videos](https://www.youtube.com/playlist?list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff)
