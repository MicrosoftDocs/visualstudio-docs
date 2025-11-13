---
title: Extend language service to support EditorConfig
description: Learn about the changes to make to update a language service to support EditorConfig files. Replace a global language-specific option with a contextual option.
ms.date: 11/22/2017
ms.topic: concept-article
helpviewer_keywords:
- editorconfig [extensibility]
- editorconfig, supporting in a language service
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Supporting EditorConfig for your language service

[EditorConfig](https://editorconfig.org/) files enable you to describe common text editor options, such as indent size, on a per-project basis. To learn more about Visual Studio's support for EditorConfig files, see [Create portable editor settings using EditorConfig](../ide/create-portable-custom-editor-options.md).

In most cases when you implement a Visual Studio language service, no additional work is needed to support EditorConfig universal properties. The core editor automatically discovers and reads the `.editorconfig` file when users open files, and it sets the appropriate text buffer and view options. However, for edits such as tabs and spaces, some language services opt to use an appropriate contextual text view option rather than using global settings. In these cases, the language service must be updated to support EditorConfig files.

Following are the changes that are needed to update a language service to support EditorConfig files, by replacing a global *language-specific* option with a *contextual* option:

## Indent style

Language-specific options | Contextual options
-------|--------
Microsoft.VisualStudio.TextManager.Interop.LANGPREFERENCES.fInsertTabs<br/>Microsoft.VisualStudio.Package.LanguagePreferences.InsertTabs|!textBufferOptions.GetOptionValue(DefaultOptions.ConvertTabsToSpacesOptionId)<br/>!textView.Options.GetOptionValue(DefaultOptions.ConvertTabsToSpacesOptionId)

## Indent size

Language-specific options | Contextual options
-------|--------
Microsoft.VisualStudio.TextManager.Interop.LANGPREFERENCES.uIndentSize<br/>Microsoft.VisualStudio.Package.LanguagePreferences.InsertTabs.IndentSize|textBufferOptions.GetOptionValue(DefaultOptions.IndentSizeOptionId)<br/>textView.Options.GetOptionValue(DefaultOptions.IndentSizeOptionId)

## Tab size

Language-specific options | Contextual options
-------|--------
Microsoft.VisualStudio.TextManager.Interop.LANGPREFERENCES.uTabSize<br/>Microsoft.VisualStudio.Package.LanguagePreferences.InsertTabs.TabSize|textBufferOptions.GetOptionValue(DefaultOptions.TabSizeOptionId)<br/>textView.Options.GetOptionValue(DefaultOptions.TabSizeOptionId)

## Related content

- [Create portable editor settings using EditorConfig](../ide/create-portable-custom-editor-options.md)
- [Extending the editor and language services](../extensibility/extending-the-editor-and-language-services.md)
