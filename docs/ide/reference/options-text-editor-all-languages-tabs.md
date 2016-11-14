---
title: "Options, Text Editor, All Languages, Tabs | Microsoft Docs"
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
  - "VS.ToolsOptionsPages.Text_Editor.ResJSON.Tabs"
  - "VS.ToolsOptionsPages.Text_Editor.JavaScript.Tabs"
  - "VS.ToolsOptionsPages.Text_Editor.All_Languages.Tabs"
helpviewer_keywords: 
  - "indents, Code Editor"
  - "Code Editor, default behavior"
  - "tabs, setting in Code Editor"
  - "All Languages Text Editor Options dialog box"
  - "editors, Code Editor"
  - "Code Editor, indenting"
  - "Code Editor, tabs"
ms.assetid: 7e208e1d-5e3a-4bf7-a27b-4417e3e049c7
caps.latest.revision: 17
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
# Options, Text Editor, All Languages, Tabs
This dialog box allows you to change the default behavior of the Code Editor. These settings also apply to other editors based upon the Code Editor, such as the HTML Designer's Source view. To display these options, select **Options** from the **Tools** menu. Within the **Text Editor** folder expand the **All Languages** subfolder, and then choose **Tabs**.  
  
> [!CAUTION]
>  This page sets default options for all development languages. Remember that resetting an option in this dialog will reset the Tabs options in all languages to whatever choices are selected here. To change Text Editor options for just one language, expand the subfolder for that language and select its option pages.  
  
 If different settings are selected on the Tabs options pages for particular programming languages, then the message "The indentation settings for individual text formats conflict with each other," is displayed for differing **Indenting** options; and the message "The tab settings for individual text formats conflict with each other," is displayed for differing **Tab** options. For example, this reminder is displayed if the **Smart indenting** option is selected for Visual Basic, but **Block indenting** is selected for Visual C++.  
  
> [!NOTE]
>  The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](http://msdn.microsoft.com/en-us/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
## Indenting  
 None  
 When selected, new lines are not indented. The insertion point is placed in the first column of a new line.  
  
 Block  
 When selected, new lines are automatically indented. The insertion point is placed at the same starting point as the preceding line.  
  
 Smart  
 When selected, new lines are positioned to fit the code context, per other code formatting settings and IntelliSense conventions for your development language. This option is not available for all development languages.  
  
 For example, lines enclosed between an opening brace ( { ) and a closing brace ( } ) might automatically be indented an extra tab stop from the position of the aligned braces.  
  
## Tabs  
 Tab size  
 Sets the distance in spaces between tab stops. The default is four spaces.  
  
 Indent size  
 Sets the size in spaces of an automatic indentation. The default is four spaces. Tab characters, space characters, or both will be inserted to fill the specified size.  
  
 Insert spaces  
 When selected, indent operations insert only space characters, not TAB characters. If the **Indent size** is set to 5, for example, then five space characters are inserted whenever you press the TAB key or the **Increase Indent** button on the **Formatting** toolbar.  
  
 Keep tabs  
 When selected, indent operations insert as many TAB characters as possible. Each TAB character fills the number of spaces specified in **Tab size**. If the **Indent size** is not an even multiple of the **Tab size**, space characters are added to fill in the difference.  
  
## See Also  
 [Options, Text Editor, All Languages](../../ide/reference/options-text-editor-all-languages.md)   
 [General, Environment, Options Dialog Box](../../ide/reference/general-environment-options-dialog-box.md)