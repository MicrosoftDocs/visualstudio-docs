---
title: "Manage external tools | Microsoft Docs"
ms.custom: ""
ms.date: "02/17/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.externaltools"
helpviewer_keywords: 
  - "Create GUID tool"
  - "RC (Resource Compiler)"
  - "ReBase tool"
  - "Windows NT Message Compiler"
  - "Windows NT C++ Symbol Undecorator"
  - "tstcon32.exe"
  - "Type Library Generator"
  - "Windows NT Image Binder"
  - "tools [Visual Studio], external"
  - "RowsetViewer tool"
  - "utilities, external tools"
  - "Local Test Manager"
  - "OLE DB Rowset Viewer"
  - "Midlc (IDL Compiler)"
  - "ATL Trace Tool"
  - "Odbcte32w.exe"
  - "IDL Compiler"
  - "HCW (Help Workshop)"
  - "Message Compiler [Visual Studio]"
  - "UUID Generator"
  - "MIDL, external tools"
  - "ErrLook tool"
  - "MAKEHM tool"
  - "Error lookup tool"
  - "OLEVIEW (Object Viewer)"
  - "Uuidgen.exe"
  - "WebDbg tool"
  - "OLE/COM Object Viewer"
  - "LTM (Local Test Manager)"
  - "ATLTraceTool.exe"
  - "Bind tool"
  - "Vsvars32.bat"
  - "external tools [Visual Studio]"
  - "ODBC Test"
  - "Windows NT Image Rebaser"
  - "undname.exe"
  - "Vcspawn.exe"
  - "ActiveX Control Test Container"
  - "mc (Message Compiler)"
  - "GUIDGEN tool"
  - "Odbcte32.exe"
  - "DisableMsg tool"
  - "MkTypLib tool"
  - "Help Workshop"
  - "Resource Compiler"
ms.assetid: f382fd40-a98f-4934-8c9a-5aeae881acde
caps.latest.revision: 38
author: "gewarren"
ms.author: "gewarren"
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
# Manage external tools
You can call external tools from inside Visual Studio by using the **Tools** menu. A few default tools are available from the **Tools** menu, but you can add other executables of your own.  

## Tools available on the Visual Studio Tools menu
 The **Tools** menu contains several built-in commands, such as:

*  **Extensions and Updates** for [managing Visual Studio Extensions](finding-and-using-visual-studio-extensions.md)
*  **Code Snippets Manager...** for [organizing Code Snippets](code-snippets.md#code-snippet-manager)
*  **PreEmptive Protection - Dotfuscator** for launching [Dotfuscator Community Edition (CE)](dotfuscator/index.md) if it is [installed](dotfuscator/install.md)
*  **Customize...** for [customizing menus and toolbars](how-to-customize-menus-and-toolbars-in-visual-studio.md)
*  **Options...** for [setting a variety of different options for the Visual Studio IDE and other tools](reference/options-dialog-box-visual-studio.md)

## Add new tools to the Tools menu 
 You can add an external tool to the **Tools** menu. Open the **External Tools...** dialog box and click **Add**, then fill in the information. For example, the following entry causes Windows Explorer to open at the directory of the file you currently have open in Visual Studio:  
  
1.  Title: *Open File Location*
  
2.  Command: `explorer.exe`  
  
3.  Arguments: `/root, "$(ItemDir)"`  
  
 The following is a full list of arguments that can be used when defining an external tool.
  
> [!NOTE]
>  The IDE status bar displays the Current Line and Current Column variables to indicate where the insertion point is located in the active Code Editor. The Current Text variable returns the text or code selected at that location.  
  
|Name|Argument|Description|  
|----------|--------------|-----------------|  
|Item Path|$(ItemPath)|The complete file name of the current file (drive + path + file name).|  
|Item Directory|$(ItemDir)|The directory of the current file (drive + path).|  
|Item File Name|$(ItemFilename)|The file name of the current file (file name).|  
|Item Extension|$(ItemExt)|The file name extension of the current file.|  
|Current Line|$(CurLine)|The current line position of the cursor in the code window.|  
|Current Column|$(CurCol)|The current column position of the cursor in the code window.|  
|Current Text|$(CurText)|The selected text.|  
|Target Path|$(TargetPath)|The complete file name of the item to be built (drive + path + file name).|  
|Target Directory|$(TargetDir)|The directory of the item to be built.|  
|Target Name|$(TargetName)|The file name of the item to be built.|  
|Target Extension|$(TargetExt)|The file name extension of the item to be built.|  
|Binary Directory|$(BinDir)|The final location of the binary that is being built (defined as drive + path). For example:**\\...\My Documents\Visual Studio \<Version>\\<ProjectName\>\bin\debug**|  
|Project Directory|$(ProjDir)|The directory of the current project (drive + path).|  
|Project file name|$(ProjFileName)|The file name of the current project (drive + path + file name).|  
|Solution Directory|$(SolutionDir)|The directory of the current solution (drive + path).|  
|Solution file name|$(SolutionFileName)|The file name of the current solution (drive + path + file name).|  

## See also  
 [C/C++ Build Tools](/cpp/build/reference/c-cpp-build-tools)
