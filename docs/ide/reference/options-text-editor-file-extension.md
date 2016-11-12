---
title: "Options, Text Editor, File Extension | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.toolsoptionspages.text_editor.file_extension"
helpviewer_keywords: 
  - "file extensions, associating to editor"
  - "Editing Experience"
  - "Options dialog box"
  - "Editing Experience, selecting"
ms.assetid: 05298fc5-fc4e-4bb2-b942-1f7d2dcdff0f
caps.latest.revision: 12
author: "kempb"
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
# Options, Text Editor, File Extension
This Options dialog allows you to specify how all files with certain file extensions will be handled by the Visual Studio integrated development environment (IDE). For each **Extension** that you enter, you can select an Editing Experience. This allows you to choose the IDE editor or designer in which documents of a certain type will open. To display these options, choose **Options** from the **Tools** menu, expand the **Text Editor** node, and select **File Extension**.  
  
 When you select an option "with Encoding," a dialog will be displayed whenever you open a document of that type that allows you to select an encoding scheme for that document. This can be helpful if you are preparing versions of your project documents for use on different platforms or in different target languages.  
  
> [!NOTE]
>  The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](http://msdn.microsoft.com/en-us/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
## UIElement List  
 **Extension**  
 Type the file extension whose Editing Experience in the IDE you wish to define.  
  
 **Editor**  
 Select the IDE editor or designer in which documents with this file extension will open. When you select an option "with Encoding," a dialog will be displayed whenever you open such a document that allows you to select an encoding scheme.  
  
 **Add**  
 Adds an entry that includes the specified **Extension** and **Editing Experience** to the Extension List.  
  
 **Remove**  
 Deletes the selected entry from the Extension List.  
  
 Extension List  
 Lists all extensions for which an Editing Experience has been specified.  
  
 **Map extensionless files to**  
 Select this option if you wish to specify how files without an extension will be handled by the IDE.  
  
 **Extensionless file options**  
 Provides the same list as **Editor**. Select the IDE editor or designer in which documents without file extensions will open.  
  
## See Also  
 [How to: Manage Editor Modes](../../ide/how-to-manage-editor-modes.md)