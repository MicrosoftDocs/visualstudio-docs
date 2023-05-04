---
title: "Learn about the Text Spell Checker (Preview)"
description: Learn how to use the Text Spell Checker to correct misspelled words in multiple languages and to customize it to share with your dev team.
ms.date: 05/04/2023
ms.topic: conceptual
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
monikerRange: vs-2022
---
# Learn about the Text Spell Checker (Preview)

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Many of the features in Visual Studio are designed to help you write the code you want, from making sure that your code compiles to helping you with code styling. Now, with the **Text Spell Checker** feature&mdash;introduced in [version 17.5](/visualstudio/releases/2022/release-notes-v17.5)&mdash;Visual Studio can even make sure your spelling is accurate.

:::image type="content" source="media/vs-2022/text-spell-checker.png" alt-text="Screenshot of an example of the Text Spell Checker in action.":::

> [!IMPORTANT]
> This feature is still in development. It's available now in Visual Studio 2022 version 17.5, but it'll be refined in future Preview releases. For the latest update, see the [**Improving the Spell Checker**](https://devblogs.microsoft.com/visualstudio/improving-the-spell-checker/) post on the [Visual Studio Blog](https://devblogs.microsoft.com/visualstudio/).

Visual Studio automatically toggles on the Text Spell Checker feature with any C#, C++, or Markdown file. Visual Studio marks any words that it detects as misspelled words. Visual Studio also suggests alternate spellings and helps correct them. The feature even does a contextual rename when those misspellings are identifiers so that your code still compiles.

You can turn the spell checker off or on by using the **Toggle Text Spell Checker** button on the main toolbar, or by selecting **Edit** > **Advanced** > **Toggle Text Spell Checker** command from the menu bar.

## How do you use it?

When the caret is on a spelling error, the [Quick Actions](quick-actions.md) provide solutions for fixing the spelling mistakes. You can bring up the Quick Actions by using the keyboard shortcuts **Ctrl**+**.** or **Alt**+**Enter**. When the context menu comes up, Visual Studio displays three options to handle a spelling issue.

If any of the dictionaries provide spelling suggestions, Visual Studio displays them. If multiple dictionaries provide suggestions, Visual Studio groups its suggestions by dictionary. For strings and comments, choosing one of these suggestions results in a single, in-place replacement. For identifiers in a C++ or a C# document, accepting a suggestion results in a Refactor/Rename that updates all instances of the identifier to make sure the code compiles.

:::image type="content" source="media/vs-2022/text-spell-checker-multiple-dictionaries.png" alt-text="Screenshot of the Text Spelling Checker with multiple dictionaries listed.":::

You can also choose to ignore the spelling issue. By choosing to ignore the issue, Visual Studio creates an exclusion.dic file in your AppData directory on your local machine. After you choose to ignore a word, the spelling checker ignores it across all instances of Visual Studio.

## How does it work?

Because C#, C++, and Markdown all use English as the language for their keywords, Visual Studio typically uses the "English (United States)" or "en-us" dictionary for spell checking. Visual Studio checks the instance of Windows for the display language it's using, and if it's not "en-us", it uses that dictionary as well.

Feedback from early users of this feature informed us that developers wanted to know about errors in the documents they were currently working with. In direct response to this feedback, the spell checker scans documents that are open.

The following table shows some of the heuristics that the **Text Spell Checker** looks at when it scans a code document:

| What's in the code | What Visual Studio checks | Why? |
|---------|---------|---------|
| Hello | Hello, hello | Always check for both proper and common nouns |
| HelloWorld | Hello, hello, World, world | Medial capitals are used to mark word boundaries |
| Hello.World| Hello, hello, World, world | Punctuation is used as a word boundary |
| _Hello123 | Hello, hello | Leading or trailing numbers or punctuation marks are stripped |
| Hello2World | Hello, hello, World, world | Medial numbers, like punctuation marks, are used as word boundary |
| btnWorld | World, world | Fragments of three characters or fewer are ignored |
| helloworld | Helloworld, helloworld | No indicator to identify word boundaries |

Otherwise, Visual Studio considers the word misspelled and flags the token as a spelling error. Visual Studio displays the spelling error with a severity of "Message" in the Error List with a "SPELL" Code.

:::image type="content" source="media/vs-2022/text-spell-checker-error-list-example.png" alt-text="Screenshot of an example of spelling errors in the Error List.":::

## How to customize the Text Spell Checker

You can customize the spell checker so that it's optimized for a collaborative environment. As such, Visual Studio uses an [EditorConfig](create-portable-custom-editor-options.md) file for configuration so that you can control the spell checker behavior in a repository.

By configuring an EditorConfig file, you can establish the coding standards that you expect everyone to follow, which allows you to maintain a coding consistency that might be difficult through other methods.

Here are some examples and use-case scenarios of the switches you can configure in an EditorConfig file:

- List the languages for Visual Studio to use. In this example, Visual Studio would only use the "en-us" and "fr-fr" dictionaries when checking for spelling issues.

    ```spelling_languages = _language_[,_language_]```<br>
    ```(Example: = en-us,fr-fr)```

    > [!NOTE]
    > Make sure to install the [language pack](../install/install-visual-studio.md) for any non-default language you're using to prevent Visual Studio from incorrectly flagging words as spelling errors.

- Control what Visual Studio should check. In this example, Visual Studio would check identifiers and comments for misspelled words but wouldn’t check inside strings.

    ```spelling_checkable_types = strings,identifiers,comments```<br>
    ```(Example: = identifiers,comments)```

- Control the severity Visual Studio assigns to spelling errors in the error list. In this example, spelling errors are displayed as errors.

    ```spelling_error_severity = error OR warning OR information OR hint```<br>
    ```(Example: = error)```

- Create your own exclusion dictionary to specify words you consider to be correctly spelled. In this example, the first time the Text Spell Checker is run against any file in the solution, Visual Studio checks for an exclusion.dic file in the same directory as the .sln file (for a C# project) or in the root directory (for a C++ directory). If no exclusion.dic file exists, the Visual Studio creates one. Then, whenever the user chooses to ignore a word, Visual Studio adds it to this exclusion.dic file. Visual Studio considers any word that appears in this exclusion.dic file as a correctly spelled word.

    ```spelling_exclusion_path = absolute OR relative path to exclusion dictionary```<br>
    ```(Example: = .\exclusion.dic)```

    Visual Studio uses the exclusion dictionary specified by the spelling_exclusion_path switch in your .editorconfig file or an “exclusion.dic” file in your %localappdata%\Microsoft\VisualStudio\<Version> directory if a switch can’t be found. In either case, the spell-checking APIs required the exclusion file to have “UTF-16 with BOM” encoding to work correctly. We got multiple reports of the encoding becoming corrupted, particularly when users manually modified these files to remove excluded words.

## Special case handling

In Visual Studio, some strings aren't recommended for spell-checking. Other strings aren't spell checked or aren't spell checked in their entirety.

- Strings that include punctuation aren't recommended. For example, `misc.` isn't recommended as it could result in code that won't compile.
- Backslashes in a string can omit the subsequent character from being spell-checked. For example, `\nhello` won't be flagged as a spelling error because the "n" is omitted and "hello" is a correctly spelled word. 
- Strings that contain URLs such as `https://...` or `mailto:..` won't be spell-checked over the entire string.

## See also

- [Improving the Spell Checker](https://devblogs.microsoft.com/visualstudio/improving-the-spell-checker/)