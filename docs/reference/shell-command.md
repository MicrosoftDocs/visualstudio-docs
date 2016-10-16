---
title: "Shell Command"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "tools.shell"
helpviewer_keywords: 
  - "exe files"
  - "Shell command"
  - "Tools.Shell command"
  - "executables, running from Visual Studio"
  - ".exe files"
  - "Shell, launching exe files"
  - "Visual Studio, executables from"
ms.assetid: 737fda23-b852-45c4-a9fe-41cbce6ba70f
caps.latest.revision: 13
ms.author: "kempb"
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
# Shell Command
Launches executable programs from within [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)].  
  
## Syntax  
  
```  
Tools.Shell [/command] [/output] [/dir:folder] path [args]  
```  
  
## Arguments  
 `path`  
 Required. The path and file name of the file to execute or the document to open. A full path is required if the specified file is not in one of the directories in the PATH environment variable.  
  
 `args`  
 Optional. Any arguments to pass to the invoked program.  
  
## Switches  
 /commandwindow [or] /command [or] /c [or] /cmd  
 Optional. Specifies that the output for the executable is displayed in the **Command** window.  
  
 /dir:`folder` [or] /d: `folder`  
 Optional. Specifies the working directory to be set when the program is run.  
  
 /outputwindow [or] /output [or] /out [or] /o  
 Optional. Specifies that the output for the executable is displayed in the **Output** window.  
  
## Remarks  
 The /dir /o /c switches must be specified immediately after `Tools.Shell`. Anything specified after the name of the executable is passed to it as command line arguments.  
  
 The predefined alias `Shell` can be used in place of `Tools.Shell`.  
  
> [!CAUTION]
>  If the `path` argument supplies the directory path as well as the file name, you should enclose the entire pathname in literal quotes ("""), as in the following:  
  
```  
Tools.Shell """C:\Program Files\SomeFile.exe"""  
```  
  
 Each set of three double quotes (""") is interpreted by the `Shell` processor as a single double quote character. Thus, the preceding example actually passes the following path string to the `Shell` command:  
  
```  
"C:\Program Files\SomeFile.exe"  
```  
  
> [!CAUTION]
>  If you do not enclose the path string in literal quotes ("""), Windows will use only the portion of the string up to the first space. For example, if the path string above were not quoted properly, Windows would look for a file named "Program" located in the C:\ root directory. If a C:\Program.exe executable file were actually available, even one installed by illicit tampering, Windows would attempt to execute that program in place of the desired "c:\Program Files\SomeFile.exe" program.  
  
## Example  
 The following command uses xcopy.exe to copy the file `MyText.txt` into the `Text` folder. The output from xcopy.exe is displayed in both the **Command Window** and the **Output** window.  
  
```  
>Tools.Shell /o /c xcopy.exe c:\MyText.txt c:\Text\MyText.txt  
```  
  
## See Also  
 [Visual Studio Commands](../reference/visual-studio-commands.md)   
 [Command Window](../reference/command-window.md)   
 [Output Window](../reference/output-window.md)   
 [Find/Command Box](../ide/find-command-box.md)   
 [Visual Studio Command Aliases](../reference/visual-studio-command-aliases.md)