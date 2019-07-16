---
title: "How to: Specify Symbol File Locations from the Command Line | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 8aa067bb-e8bf-4081-aff0-cfbcf65934a0
caps.latest.revision: 16
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Specify Symbol File Locations from the Command Line
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

To display symbol information such as function names and line numbers, the VSPerfReport command-line tool requires access to the symbol (.pdb) files of the profiled components and the Windows system files. Symbol files are created when a component is compiled. For more information, see [VSPerfReport](../profiling/vsperfreport.md). VSPerfReport automatically searches the following locations for symbol files:  
  
- Paths specified in the **/SymbolPath** option or in the **_NT_SYMBOL_PATH** environment variable.  
  
- The exact local path where a component was compiled.  
  
- The directory that contains the profiling data (.vsp or .vsps) file.  
  
  Microsoft provides the .pdb files for many of its products online in a symbol server. If the computer that you are using for reporting is connected to the Internet, VSPerfReport connects to the online symbol server to automatically look up symbol information and save the files to a local store.  
  
  You can specify the location of symbol files and the Microsoft symbol server store in the following ways:  
  
- Set the **_NT_SYMBOL_PATH** environment variable.  
  
- Add the **/SymbolPath** option to the VSPerfReport command line.  
  
  You can also use both of these methods.  
  
> [!NOTE]
> If [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] is installed on the local computer, a location for the Windows symbol files probably has been specified already. For more information, see [How to: Reference Windows Symbol Information](../profiling/how-to-reference-windows-symbol-information.md). You still must configure VSPerfReport to use the location and server as described later in this topic.  
  
## Specifying Windows Symbol Files  
  
#### To configure the use of the Windows symbol server  
  
1. If necessary, create a directory to store the symbol files locally.  
  
2. Use the following syntax to set the **_NT_SYMBOL_PATH** environment variable or the VSPerfReport /SymbolPath option:  
  
    **srv\*** *LocalStore* **\*http://msdl.microsoft.com/downloads/symbols**  
  
    where *LocalStore* is the path of the local directory that you created.  
  
## Specifying Component Symbol Files  
 Profiling Tools searches for the.pdb files of the components that you want to profile in their original locations that are stored in the components or in the folder that contains the profiling data file. You can specify other locations to search by adding one or more paths to **_NT_SYMBOL_PATH** or to the **/SymbolPath** option. Separate paths with semi-colons.  
  
## Example  
 The following command line sets the **_NT_SYMBOL_PATH** environment variable to the Windows symbol server and the local directory to **C:\Symbols**.  
  
 **set  _NT_SYMBOL_PATH=srv\*C:\symbols\*http://msdl.microsoft.com/downloads/symbols**  
  
 The following VSPerfReport command line adds the C:\Projects\Symbols directory to the search path by using the **/SymbolPath** option.  
  
 **VSPerfReport**  *MyApp* **.exe /SymbolPath:C:\Projects\Symbols /summary:all**
