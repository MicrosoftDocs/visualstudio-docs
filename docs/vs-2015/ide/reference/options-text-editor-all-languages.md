---
title: "Options, Text Editor, All Languages | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Text_Editor.JavaScript.General"
  - "VS.ToolsOptionsPages.Text_Editor.ResJSON.General"
  - "vs.toolsoptionspages.text_editor.all_languages.scrollbars"
helpviewer_keywords:
  - "Text Editor Options dialog box"
  - "statement completion"
  - "word wrap"
  - "General dialog box"
  - "line numbers"
  - "virtual space"
ms.assetid: 49ee7306-9d46-4170-850f-a1716171752d
caps.latest.revision: 25
author: jillre
ms.author: jillfra
manager: jillfra
---
# Options, Text Editor, All Languages
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

This dialog box allows you to change the default behavior of the Code Editor. These settings also apply to other editors based upon the Code Editor, such as the HTML Designer's Source view. To open this dialog box, select **Options** from the **Tools** menu. Within the **Text Editor** folder, expand the **All Languages** subfolder and then choose **General**.

> [!CAUTION]
> This page sets default options for all development languages. Remember that resetting an option in this dialog will reset the General options in all languages to whatever choices are selected here. To change Text Editor options for just one language, expand the subfolder for that language and select its option pages.

 A grayed checkmark is displayed when an option has been selected on the General options pages for some programming languages, but not for others.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).

## Statement Completion
 Auto list members
 When selected, pop-up lists of available members, properties, values, or methods are displayed by IntelliSense as you type in the editor. Choose any item from the pop-up list to insert the item into your code. Selecting this option enables the **Hide advanced members** option.

 Hide advanced members
 When selected, shortens pop-up statement completion lists by displaying only those items most commonly used. Other items are filtered from the list.

 Parameter information
 When selected, the complete syntax for the current declaration or procedure is displayed under the insertion point in the editor, with all of its available parameters. The next parameter you can assign is displayed in bold.

## Settings
 Enable virtual space
 When this option is selected and **Word wrap** is cleared, you can click anywhere beyond the end of a line in the Code Editor and type. This feature can be used to position comments at a consistent point next to your code.

 Word wrap
 When selected, any portion of a line that extends horizontally beyond the viewable editor area is automatically displayed on the next line. Selecting this option enables the **Show visual glyphs for word wrap** option.

> [!NOTE]
> The **Virtual Space** feature is turned off while **Word Wrap** is on.

 Show visual glyphs for word wrap
 When selected, a return-arrow indicator is displayed where a long line wraps onto a second line.

 ![LineBreakSymbol screenshot](../../ide/reference/media/linebreak.gif "linebreak")

 Clear this option if you prefer not to display these indicators.

> [!NOTE]
> These reminder arrows are not added to your code, and do not print. They are for reference only.

 Apply Cut or Copy commands to blank lines when there is no selection
 This option sets the behavior of the editor when you place the insertion point on a blank line, select nothing, and then Copy or Cut.

- When this option is selected, the blank line is copied or cut. If you then Paste, a new, blank line is inserted.

- When this option is cleared, the Cut command removes blank lines. However, the data on the Clipboard is preserved. Therefore, if you then use the Paste command, the content most recently copied onto the Clipboard is pasted. If nothing has been copied previously, nothing is pasted.

  This setting has no effect on Copy or Cut when a line is not blank. If nothing is selected, the entire line is copied or cut. If you then Paste, the text of the entire line and its endline character are pasted.

> [!TIP]
> To display indicators for spaces, tabs, and line ends, and thus distinguish indented lines from lines that are entirely blank, select **Advanced** from the **Edit** menu and choose **View White Space**.

## Display
 Line numbers
 When selected, a line number appears next to each line of code.

> [!NOTE]
> These line numbers are not added to your code, and do not print. They are for reference only.

 Enable single-click URL navigation
 When selected, the mouse cursor changes to a pointing hand as it passes over a URL in the editor. You can click the URL to display the indicated page in your Web browser.

 Navigation bar
 When selected, displays the **Navigation bar** at the top of the code editor. Its dropdown **Objects** and **Members** lists allow you to choose a particular object in your code, select from its members, and navigates to the declaration of the selected member in the Code Editor.

## See Also
 [Options, Text Editor, All Languages, Tabs](../../ide/reference/options-text-editor-all-languages-tabs.md)
 [General, Environment, Options Dialog Box](../../ide/reference/general-environment-options-dialog-box.md)
 [Using IntelliSense](../../ide/using-intellisense.md)
