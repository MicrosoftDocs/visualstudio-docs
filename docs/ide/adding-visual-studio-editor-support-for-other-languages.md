---
title: Add editor support for other languages
description: Learn about how the Visual Studio editor supports reading and navigating through different computer languages and how you can add support for other languages.
ms.date: 5/02/2025
ms.topic: conceptual
helpviewer_keywords:
- syntax colorization
- IntelliSense
- IDE, navigation
- documents [Visual Studio], navigation
- TextMate bundle
- TextMate language grammar
- language support
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Add Visual Studio editor support for other languages

Learn about how the Visual Studio editor supports reading and navigating through different computer languages and how you can add Visual Studio editor support for other languages.

## Syntax colorization, statement completion, and Navigate To support

Features in the Visual Studio editor such as syntax colorization, statement completion (also known as IntelliSense), and *Navigate To* can help you more easily write, read, and edit your code. The following screenshot shows an example of editing a Perl script in Visual Studio. The syntax is automatically colorized. For example, remarks in the code are colored green, code is black, paths are red, and statements are blue. The Visual Studio editor automatically applies syntax colorization to any language it supports. In addition, when you begin to enter a known language keyword or object, statement completion displays a list of possible statements and objects. Statement completion can help you write code more quickly and easily.

![Syntax colorization in Perl script](../ide/media/vside_perledit.png)

Visual Studio currently provides syntax colorization and basic statement completion support for the following languages using [TextMate Grammars](https://manual.macromates.com/en/language_grammars). If your favorite language isn't in the table, though, don't worry&mdash;you can add it.

- Bat
- F#
- Java
- Markdown
- Rust
- Visual Basic
- Clojure
- Go
- JavaDoc
- Objective-C
- ShaderLab
- C#
- CMake
- Groovy
- JSON
- Perl
- ShellScript
- Visual C++
- CoffeeScript
- HTML
- LESS
- Python
- SQL
- VBNet
- CSS
- INI
- LUA
- R
- Swift
- XML
- Docker
- Jade
- Make
- Ruby
- TypeScript
- YAML

In addition to syntax colorization and basic statement completion, Visual Studio also has a feature called [Navigate To](/archive/blogs/benwilli/visual-studio-tip-3-use-navigate-to). This feature enables you to quickly search code files, file paths, and code symbols. Visual Studio provides Navigate To support for the following languages.

- C#
- C++
- TypeScript
- JavaScript
- Visual Basic
- Go
- Java
- PHP

All of these file types have the features described earlier even if support for a given language isn't yet installed. Installing specialized support for some languages may provide additional language support, such as IntelliSense or other advanced language features like light bulbs.

## Add support for nonsupported languages

Visual Studio provides language support in the editor by using [TextMate Grammars](https://manual.macromates.com/en/language_grammars). If your favorite programming language currently isn't supported in the Visual Studio editor, first, search the web&mdash;a TextMate bundle for the language may already exist. If you can't find one, though, you can add support for it yourself by creating a TextMate bundle model for language grammars and snippets.

Add any new TextMate Grammars for Visual Studio in the following folder:

*%userprofile%\\.vs\Extensions*

> In Windows, *%userprofile%* resolves to the path: *c:\Users\\\<user name>*. If the *Extensions* folder does not exist on your system, you need to create it. If the folder already exists, it is hidden.

Under this base path, add the following folders if they apply to your situation:

|Folder Name|Description|
|-----------------|-----------------|
|\\*\<language name>*|The language folder. Replace *\<language name>* with the name of the language. For example, *\Matlab*.|
|*\Syntaxes*|The grammar folder. Contains the grammar `.json` files for the language, such as *Matlab.json*.|
|*\Snippets*|The snippets folder. Contains snippets for the language.|

In Windows, *%userprofile%* resolves to the path: *c:\Users\\\<user name>*. If the *Extensions* folder does not exist on your system, you will need to create it. If the folder already exists, it will be hidden.

> [!TIP]
> If you have any files open in the editor, you'll need to close and reopen them to see syntax highlighting after you add the TextMate Grammars.

For details about how to create TextMate Grammars, see [TextMate - Introduction to Language Grammars](https://developmentality.wordpress.com/2011/02/08/textmate-introduction-to-language-grammars/) and [Notes on how to create a Language Grammar and Custom Theme for a Textmate Bundle](https://benparizek.com/notebook/notes-on-how-to-create-a-language-grammar-and-custom-theme-for-a-textmate-bundle).

## Related content

- [Add a Language Server Protocol extension](../extensibility/adding-an-lsp-extension.md)
- [Create a code snippet](../ide/walkthrough-creating-a-code-snippet.md)
- [Display statement completion](../extensibility/walkthrough-displaying-statement-completion.md)
- [Ship TextMate grammars inside Visual Studio extensions](https://github.com/microsoft/VSSDK-Extensibility-Samples/tree/master/TextmateGrammar)
- [Implement custom language support](https://github.com/microsoft/VSSDK-Extensibility-Samples/tree/master/Ook_Language_Integration)
