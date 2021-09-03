---
title: Profiling command line - Create portable data files
description: To make sharing of profiling data easier, use the VSPerfReport.exe command-line tool to embed the symbols for a profiling run into the .vsp file.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: 2ceb63a7-b835-4988-b756-2afc3fcc4808
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# Create portable profiling data files from the command line
To make sharing of profiling data easier, you can use the [VSPerfReport](../profiling/vsperfreport.md) command-line tool to embed the symbols for a profiling run into the .*vsp* file.

 You can also create a pre-analyzed profiling data (.*vsps*) file that is smaller and is quicker to load in the IDE.

> [!NOTE]
> Make sure the symbol (.*pdb*) files are available to **VSPerfReport**. For more information, see [How to: Specify symbol file locations from the command line](../profiling/how-to-specify-symbol-file-locations-from-the-command-line.md).
>
> For information about the path to **VSReport**, see [Specify the path to command-line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md).
>
> The profiling data in a .*vsps* file cannot be filtered.

### To embed the symbols for a profiling run into a profiling data (.*vsp*) file

- At a command prompt window, type the following command:

   \<Path><strong>VSPerfReport \<</strong>VSP File> **/PackSymbols**

   By default, the .*vsps* file is named with the base name of the .*vsp* file. You can specify an alternative name by using the **Output** option.

### To create a summary profiling data file

- At a command prompt window, type the following command:

   \<Path><strong>VSPerfReport \<</strong>VSP File> **/SummaryFile** [**/Output:**\<File Name>]

   By default, the .*vsps* file is named with the base name of the .*vsp* file. You can specify an alternative name by using the **Output** option.
