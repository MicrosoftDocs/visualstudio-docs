---
title: "Creating Portable Profiling Data Files from the Command Line | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 2ceb63a7-b835-4988-b756-2afc3fcc4808
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Creating Portable Profiling Data Files from the Command Line
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

To make sharing of profiling data easier, you can use the [VSPerfReport](../profiling/vsperfreport.md) command-line tool to embed the symbols for a profiling run into the .vsp file.  
  
 You can also create a pre-analyzed profiling data (.vsps) file that is smaller and is quicker to load in the IDE.  
  
> [!NOTE]
> Make sure the symbol (.pdb) files are available to **VSPerfReport**. For more information, see [How to: Specify Symbol File Locations from the Command Line](../profiling/how-to-specify-symbol-file-locations-from-the-command-line.md).  
>   
> For information about the path to **VSReport**, see [Specifying the Path to Command Line Tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md).  
>   
> The profiling data in a .vsps file cannot be filtered.  
  
### To embed the symbols for a profiling run into a profiling data (.vsp) file  
  
- At a command prompt window, type the following command:  
  
   \<Path><strong>VSPerfReport \<</strong>VSP File> **/PackSymbols**  
  
   By default, the .vsps file is named with the base name of the .vsp file. You can specify an alternative name by using the **Output** option.  
  
### To create a summary profiling data file  
  
- At a command prompt window, type the following command:  
  
   \<Path><strong>VSPerfReport \<</strong>VSP File> **/SummaryFile** [**/Output:**\<File Name>]  
  
   By default, the .vsps file is named with the base name of the .vsp file. You can specify an alternative name by using the **Output** option.
