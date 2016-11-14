---
title: "Getting Started with PTVS: Setting up Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-python"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: ec491c1d-bdb2-4c2b-a390-bd808cec635a
caps.latest.revision: 5
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
# Getting Started with PTVS: Setting up Visual Studio
Installing PTVS and related libraries is quick if you have Visual Studio.  If you do not have Visual Studio, you can get a free copy of a professional quality version.  
  
 You can watch these instructions in a very short [youtube video](https://www.youtube.com/watch?v=_okUV47eM5c&list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff&index=1).  
  
 The highlevel steps are install Visual Studio, install PTVS, install Python and data libraries (Anaconda, Canopy), and then finally to check the installation.  
  
 The first thing you'll need Visual Studio.  If you're an open-source or individual developer, you can use Visual Studio [Community Edition](https://www.visualstudio.com/products/visual-studio-community-vs)Community Edition, which is free and functional for professionals.  You can also use the Community Edition in an organization as long as it is for classroom learning, academic research, or contributing to open source projects.  Students and startups should look into DreamSpark and BizSpark programs to see if you're eligible for free access, or ask your employer whether you have an MSDN subscription.  
  
 Once you've installed Visual Studio, you'll need to [install PTVS](http://pytools.codeplex.com/wikipage?title=PTVS%20Installation).  This is a free, standalone extension that's fully supported by Microsoft and developed openly with contributions from the community.  
  
 Now you need to [install Python](http://python.org/download/).  Python is completely maintained by the community, and its home page is python.org.  Continuum Analytics produces a free bundle called Anaconda that has Python and many useful libraries (especially for science and data processing), and Enthought releases Canopy which is a similar bundle.  You only need to install one of these.  If you're not sure which one, start with [Anaconda](https://www.continuum.io/downloads), which gives you the most up-to-date Python and most of the difficult-to-install packages.  
  
 Start Visual Studio and make sure everything is working.  Under the View menu, choose Other Windows.  You see an item called Python Environments.  This window shows all of the Python installations PTVS detected and all of the packages you have installed.  The window also controls the database refresh for showing completions when you are editing code.  This refresh process takes some time and a lot of CPU and memory, but once it's done PTVS can show more helpful information about packages.  
  
 If you want to use IPython with PTVS, follow these [instructions](http://pytools.codeplex.com/wikipage?title=Using%20IPython%20with%20PTVS).  
  
 You can watch these instructions in a very short [youtube video](https://www.youtube.com/watch?v=_okUV47eM5c&list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff&index=1).  
  
## See Also  
 [PTVS Getting Started and Deep Dive Videos](https://www.youtube.com/playlist?list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff)