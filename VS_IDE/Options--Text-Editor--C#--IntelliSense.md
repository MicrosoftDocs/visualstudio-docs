---
title: "Options, Text Editor, C#, IntelliSense"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 3466dedb-e5f4-424c-8dd8-e4941b2f4fc2
caps.latest.revision: 25
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Options, Text Editor, C#, IntelliSense
Use the **IntelliSense** property page to modify settings that affect the behavior of IntelliSense for Visual C#. You can access the **IntelliSense** property page by clicking **Options** on the **Tools** menu, then clicking **C#** in the **Text Editor** folder, and then clicking **IntelliSense.**  
  
> [!NOTE]
>  The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
 The **IntelliSense** property page contains the following properties:  
  
## Completion Lists  
 **Show completion list after a character is typed**  
 When this option is selected, IntelliSense automatically displays the completion list when you begin typing. When this option is not selected, IntelliSense completion is still available from the **IntelliSense** menu or by pressing CTRL+SPACE.  
  
 **Place keywords in completion lists**  
 When this option is selected, IntelliSense adds C# keywords, for example, [class](../Topic/class%20\(C%23%20Reference\).md), to the completion list.  
  
 **Place code snippets in completion lists**  
 When this option is selected, IntelliSense adds aliases for C# code snippets to the completion list. In the case where the code snippet alias is the same as a keyword, for example, [class](../Topic/class%20\(C%23%20Reference\).md), the keyword is replaced by the shortcut. For more information, see [Visual C# Code Snippets](../VS_IDE/Visual-C#-Code-Snippets.md).  
  
## Selection in Completion Lists  
 **Committed by typing the following characters:**  
 Specifies all characters that execute IntelliSense automatic completion for the selected item in completion list, after they are typed.  
  
 **Committed by pressing the space bar**  
 Specifies to include the action of pressing the space bar to execute IntelliSense automatic completion for the selected item in completion list.  
  
 **Add new line on enter at end of fully typed word**  
 Specifies that if you type all the characters for an entry in the completion list and then press ENTER, a new line is created automatically and the cursor moves to the new line.  
  
 For example, if you type `else` and then press ENTER, the following appears in the editor:  
  
 `else`  
  
 `|` (cursor location)  
  
 However, if you type only `el` and then press ENTER, the following appears in the editor:  
  
 `else|` (cursor location)  
  
## IntelliSense Member Selection  
 **Pre-selects most recently used member**  
 When this option is selected, IntelliSense pre-selects the members that you have recently selected in the pop-up List Members box for automatic object name completion, during your current session in the integrated development environment (IDE). The history of most recently used members is cleared between each session in the IDE. For more information, see [IntelliSense for Most Recently Used Members](../VS_not_in_toc/IntelliSense-for-Most-Recently-Used-Members.md).  
  
## See Also  
 [General, Environment, Options Dialog Box](../VS_IDE/General--Environment--Options-Dialog-Box.md)   
 [XML Documentation Comments](../Topic/XML%20Documentation%20Comments%20\(C%23%20Programming%20Guide\).md)   
 [Using IntelliSense](../VS_IDE/Using-IntelliSense.md)