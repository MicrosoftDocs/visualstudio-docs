---
title: "Office Word Keyboard, Settings, Options dialog box"
description: Learn how you can make Microsoft Word receive shortcut key commands when the document has focus by selecting Dynamic keyboard scheme.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: article
f1_keywords:
  - "VS.ToolsOptionsPages.Microsoft_Office_Tools.Microsoft_Office_Word.Keyboard"
  - "VS.ToolsOptionsPages.Microsoft_Office_Keyboard_Settings.Microsoft_Office_Word_Keyboard"
  - "VST.WordOptions.KeyboardMappingScheme"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "keyboard shortcuts, Office development in Visual Studio"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Microsoft Office Word Keyboard, Settings, Options dialog box

  Microsoft Office Word and Visual Studio both handle shortcut keys. The same shortcut key combination can stand for different commands in Word and in Visual Studio. When Word is open in a document-level project in Visual Studio, only one application at a time receives the shortcut key commands. By default, Visual Studio receives all shortcut key commands, but you can make Word receive them when the document has focus by selecting **Dynamic keyboard scheme**.

 If you use a shortcut key that is not assigned to a command in the application that is currently handling the shortcut keys, the shortcut key is passed on to the other application.

 The option that you select will remain in effect for Word projects until you change it. The selection does not affect Microsoft Office Excel projects; you must make any change for Excel using the Microsoft Office Excel Keyboard options.

## UIElement list
 **Visual Studio keyboard scheme**
 Visual Studio receives all shortcut key commands, even if the Word document has focus. For example, if you press the function key **F5** while the document has focus, Visual Studio starts debugging your solution.

 **Dynamic keyboard scheme**
 Visual Studio receives shortcut key commands only when it has focus. When the Word document has focus, Word receives all shortcut key commands. For example, if you press the function key **F5** while the Word document has focus, Word opens the **Find and Replace** dialog box with the **Go To** tab selected. If you press **F5** while Visual Studio has focus, Visual Studio starts debugging your solution.

## Related content
- [Microsoft Office Excel Keyboard, Microsoft Office Keyboard Settings, Options dialog box](../vsto/microsoft-office-excel-keyboard-microsoft-office-keyboard-settings-options-dialog-box.md)
