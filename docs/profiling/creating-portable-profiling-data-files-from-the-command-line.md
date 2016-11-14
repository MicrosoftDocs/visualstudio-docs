---
title: "Creating Portable Profiling Data Files from the Command Line | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 2ceb63a7-b835-4988-b756-2afc3fcc4808
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
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
# Creating Portable Profiling Data Files from the Command Line
To make sharing of profiling data easier, you can use the [VSPerfReport](../profiling/vsperfreport.md) command-line tool to embed the symbols for a profiling run into the .vsp file.  
  
 You can also create a pre-analyzed profiling data (.vsps) file that is smaller and is quicker to load in the IDE.  
  
> [!NOTE]
>  Make sure the symbol (.pdb) files are available to **VSPerfReport**. For more information, see [How to: Specify Symbol File Locations from the Command Line](../profiling/how-to-specify-symbol-file-locations-from-the-command-line.md).  
>   
>  For information about the path to **VSReport**, see [Specifying the Path to Command Line Tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md).  
>   
>  The profiling data in a .vsps file cannot be filtered.  
  
### To embed the symbols for a profiling run into a profiling data (.vsp) file  
  
-   At a command prompt window, type the following command:  
  
     \<Path>**VSPerfReport \<**VSP File> **/PackSymbols**  
  
     By default, the .vsps file is named with the base name of the .vsp file. You can specify an alternative name by using the **Output** option.  
  
### To create a summary profiling data file  
  
-   At a command prompt window, type the following command:  
  
     \<Path>**VSPerfReport \<**VSP File> **/SummaryFile** [**/Output:**\<File Name>]  
  
     By default, the .vsps file is named with the base name of the .vsp file. You can specify an alternative name by using the **Output** option.