---
title: "Getting Started with PTVS: Setting up Visual Studio 2015 | Microsoft Docs"
titleSuffix: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-python
ms.topic: conceptual
ms.assetid: ec491c1d-bdb2-4c2b-a390-bd808cec635a
caps.latest.revision: 6
author: "kraigb"
ms.author: "kraigb"
manager: jillfra
---
# Getting Started with PTVS: Setting up Visual Studio

[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Installing PTVS and related libraries is quick if you have Visual Studio. If you do not have Visual Studio, you can get a free copy of a professional quality version.

You can watch these instructions in a very short [youtube video](https://www.youtube.com/watch?v=_okUV47eM5c&list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff&index=1).

The high level steps are as follows: install Visual Studio, install PTVS, install Python and data libraries (Anaconda, Canopy), and then finally to check the installation.

The first thing you'll need is Visual Studio. If you're an open-source or individual developer, you can use Visual Studio [Community Edition](https://www.visualstudio.com/products/visual-studio-community-vs), which is free and functional for professionals. You can also use the Community Edition in an organization as long as it is for classroom learning, academic research, or contributing to open-source projects. Students and startups should look into DreamSpark and BizSpark programs to see if you're eligible for free access, or ask your employer whether you have an MSDN subscription.

Once you've installed Visual Studio, you'll need to [install PTVS](https://archive.codeplex.com/?p=pytools). This is a free, standalone extension that's fully supported by Microsoft and developed openly with contributions from the community.

Now you need to [install Python](https://www.python.org/download/). Python is maintained by the community, and its home page is python.org. Continuum Analytics produces a free bundle called Anaconda that has Python and many useful libraries (especially for science and data processing), and Enthought produces a similar bundle named Canopy. You only need to install one of these products. If you're not sure which one, start with [Anaconda](https://www.continuum.io/downloads), which gives you the most up-to-date Python and most of the difficult-to-install packages.

Start Visual Studio and make sure everything is working. Under the View menu, choose Other Windows. You see an item called Python Environments. This window shows all of the Python installations PTVS detected and all of the packages you have installed. The window also controls the database refresh for showing completions when you are editing code. This refresh process takes some time, but once it's done PTVS can show more helpful information about packages.

If you want to use IPython with PTVS, follow these [instructions](https://archive.codeplex.com/?p=pytools).

You can watch these instructions in a short [youtube video](https://www.youtube.com/watch?v=_okUV47eM5c&list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff&index=1).

## See Also

[PTVS Getting Started and Deep Dive Videos](https://www.youtube.com/playlist?list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff)
