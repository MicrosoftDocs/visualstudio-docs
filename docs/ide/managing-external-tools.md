---
title: "Manage external tools | Microsoft Docs"
ms.custom: ""
ms.date: "11/20/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.externaltools"
helpviewer_keywords: 
  - "external tools [Visual Studio]"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Manage external tools

You can call external tools from inside Visual Studio by using the **Tools** menu. A few default tools are available from the **Tools** menu, and you can customize the menu by adding other executables of your own.

## Tools available on the Visual Studio Tools menu

The **Tools** menu contains several built-in commands, such as:

* **Extensions and Updates** for [managing Visual Studio Extensions](finding-and-using-visual-studio-extensions.md)
* **Code Snippets Manager...** for [organizing Code Snippets](code-snippets.md#code-snippet-manager)
* **PreEmptive Protection - Dotfuscator** for launching [Dotfuscator Community Edition (CE)](dotfuscator/index.md) if it is [installed](dotfuscator/install.md)
* **Customize...** for [customizing menus and toolbars](how-to-customize-menus-and-toolbars-in-visual-studio.md)
* **Options...** for [setting a variety of different options for the Visual Studio IDE and other tools](reference/options-dialog-box-visual-studio.md)

## Add new tools to the Tools menu

You can add an external tool to appear on the **Tools** menu.

1. Open the **External Tools** dialog box by choosing **Tools**, **External Tools...**.

1. Click **Add**, and then fill in the information. For example, the following entry causes Windows Explorer to open at the directory of the file you currently have open in Visual Studio:

   * Title: `Open File Location`

   * Command: `explorer.exe`

   * Arguments: `/root, "$(ItemDir)"`

   ![External Tools dialog box](media/external-tools-dialog.png)

The following is a full list of arguments that can be used when defining an external tool:

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
|Binary Directory|$(BinDir)|The final location of the binary that is being built (defined as drive + path).|  
|Project Directory|$(ProjDir)|The directory of the current project (drive + path).|  
|Project File Name|$(ProjFileName)|The file name of the current project (drive + path + file name).|  
|Solution Directory|$(SolutionDir)|The directory of the current solution (drive + path).|  
|Solution File Name|$(SolutionFileName)|The file name of the current solution (drive + path + file name).|

> [!NOTE]
> The IDE status bar displays the Current Line and Current Column variables to indicate where the insertion point is located in the active Code Editor. The Current Text variable returns the text or code selected at that location.

## See also

[C/C++ Build Tools](/cpp/build/reference/c-cpp-build-tools)
