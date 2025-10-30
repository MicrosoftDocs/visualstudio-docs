---
title: "Learn about the Spell Checker"
description: Learn how to use the Spell Checker in Visual Studio to correct misspelled words in multiple languages and to customize it to share with your dev team.
ms.date: 08/27/2024
ms.topic: how-to
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
monikerRange: ">=vs-2022"
---
# Learn about the Spell Checker

Many of the features in Visual Studio are designed to help you write the code you want, from making sure that your code compiles to helping you with code styling. Now, with the **Spell Checker** feature&mdash;introduced in [version 17.5](/visualstudio/releases/2022/release-notes-v17.5)&mdash;Visual Studio can even make sure your spelling is accurate.

:::image type="content" source="media/vs-2022/text-spell-checker.png" alt-text="Screenshot of an example of the Spell Checker in action.":::

The Spell Checker is available for any C#, C++, or Markdown file. When the Spell Checker is enabled, Visual Studio marks any words that it detects as misspelled words. Visual Studio also suggests alternate spellings and helps correct them. The feature even does a contextual rename when those misspellings are identifiers so that your code still compiles.

You can turn the spell checker off or on by using the **Toggle Spell Checker** button on the main toolbar, or by selecting **Edit** > **Advanced** > **Toggle Spell Checker** command from the menu bar.

## How do you use it?

When the caret is on a spelling error, the [Quick Actions](quick-actions.md) provide solutions for fixing the spelling mistakes. You can bring up the Quick Actions by using the keyboard shortcuts **Ctrl**+**.** or **Alt**+**Enter**. When the context menu comes up, Visual Studio displays three options to handle a spelling issue.

If any of the dictionaries provide spelling suggestions, Visual Studio displays them. If multiple dictionaries provide suggestions, Visual Studio groups its suggestions by dictionary. For strings and comments, choosing one of these suggestions results in a single, in-place replacement. For identifiers in a C++ or a C# document, accepting a suggestion results in a Refactor/Rename that updates all instances of the identifier to make sure the code compiles.

:::image type="content" source="media/vs-2022/text-spell-checker-multiple-dictionaries.png" alt-text="Screenshot of the Spell Checker with multiple dictionaries listed.":::

You can also choose to ignore the spelling issue. By choosing to ignore the issue, Visual Studio creates an exclusion.dic file in your AppData directory on your local machine. After you choose to ignore a word, the spelling checker ignores it across all instances of Visual Studio.

## How does it work?

Because C#, C++, and Markdown all use English as the language for their keywords, Visual Studio typically uses the "English (United States)" or "en-us" dictionary for spell checking. Visual Studio checks the instance of Windows for the display language it's using, and if it's not "en-us", it uses that dictionary as well.

> [!NOTE]
> C# and C++ also have additional dictionaries for keywords in those languages, which prevents words like ‘namespace’ or ‘alloc’ from being flagged as misspelled words.

Feedback from early users of this feature informed us that developers only want to know about errors in the document they're currently working with. In response to that feedback, the spell checker only scans the documents that are active in the editor.

The following table shows some of the heuristics that the **Spell Checker** looks at when it scans a code document:

| What's in the code | What Visual Studio checks | Why? |
|---------|---------|---------|
| Hello | Hello, hello | Always check for both proper and common nouns |
| HelloWorld | Hello, hello, World, world | Medial capitals are used to mark word boundaries |
| Hello.World| Hello, hello, World, world | Punctuation is used as a word boundary |
| _Hello123 | Hello, hello | Leading or trailing numbers or punctuation marks are stripped |
| Hello2World | Hello, hello, World, world | Medial numbers, like punctuation marks, are used as word boundary |
| btnWorld | World, world | Fragments of three characters or fewer are ignored |
| helloworld | Helloworld, helloworld | No indicator to identify word boundaries |

If Visual Studio identifies a match for the token in any of the dictionaries it's using, the token is deemed acceptable, and the scan proceeds. Otherwise, the token is considered misspelled and Visual Studio flags it as a spelling error.

:::image type="content" source="media/vs-2022/text-spell-checker-error-list-example.png" alt-text="Screenshot of an example of spelling errors in the Error List.":::

## How to customize the Spell Checker

You can customize the spell checker so that it's optimized for a collaborative environment. As such, Visual Studio uses an [EditorConfig](create-portable-custom-editor-options.md) file for configuration so that you can control the spell checker behavior in a repository.

By configuring an EditorConfig file, you can establish the coding standards that you expect everyone to follow, which allows you to maintain a coding consistency that might be difficult through other methods.

> [!IMPORTANT]
> Spelling error options are file-specific. You must specify which files spelling options are applied to. In the following example, the spelling options are applied to all C# files in the solution:
>
>```[*.cs]```

Here are some examples and use-case scenarios of the switches you can configure in an EditorConfig file:

- List the languages for Visual Studio to use. In this example, Visual Studio would only use the "en-us" and "fr-fr" dictionaries when checking for spelling issues.

    ```spelling_languages = _language_[,_language_]```<br>
    ```(Example: = en-us,fr-fr)```

    > [!NOTE]
    > Make sure to install the [language pack](../install/install-visual-studio.md) for any language you're using to prevent Visual Studio from incorrectly flagging words as spelling errors.

- Control what Visual Studio should check. In this example, Visual Studio would check identifiers and comments for misspelled words but wouldn’t check inside strings.

    ```spelling_checkable_types = strings,identifiers,comments```<br>
    ```(Example: = identifiers,comments)```

- Control the severity Visual Studio assigns to spelling errors in the error list. In this example, spelling errors are displayed as errors.

    ```spelling_error_severity = error OR warning OR information OR hint```<br>
    ```(Example: = error)```

- Create your own exclusion dictionary to specify words you consider to be correctly spelled. In this example, the first time the Spell Checker runs against any file in the solution, Visual Studio checks for an exclusion.dic file. Visual Studio checks the same directory of the .sln file for a C# project or in the root directory for a C++ directory. If no exclusion.dic file exists, the Visual Studio creates one. Then, whenever the user chooses to ignore a word, Visual Studio adds it to this exclusion.dic file. Visual Studio considers any word that appears in this exclusion.dic file as a correctly spelled word.

    ```spelling_exclusion_path = absolute OR relative path to exclusion dictionary```<br>
    ```(Example: = .\exclusion.dic)```

    > [!NOTE]
    > Visual Studio uses the exclusion dictionary specified by the `spelling_exclusion_path` switch in your .editorconfig file or an exclusion.dic file in your `%localappdata%\Microsoft\VisualStudio\<Version>` directory if a switch can’t be found.  

- Control whether the default language-specific exclusion dictionary is used. This flag is set to true by default. Any words added to the language-specific exclusion dictionary will be considered correctly spelled. Set to false to ignore the exclusion dictionaries specific to C++ or C#.

    ```spelling_use_default_exclusion_dictionary = true OR false```<br> 
    ```(Example: = spelling_use_default_exclusion_dictionary = false)```

Here's a complete example:

```
[*.{cs,vb}]                                         //specify which files the spelling options apply to
spelling_languages = en-us,fr-fr                    //specifies the en-us and fr-fr dictionaries for use in spell checking
spelling_checkable_types = identifiers,comments     //specifies that identifiers and comments are the only checked elements
spelling_error_severity = error                     //sets severity assigned to spelling errors to error in the error list
spelling_exclusion_path = exclusion.dic             //defines a custom exclusion dictionary location and file
spelling_use_default_exclusion_dictionary = false   //ignores the language-specific default exclusion dictionary
```

## Special case handling

Visual Studio has some unique behaviors when checking code for spelling errors that differ from those of a traditional spell checker designed for written text. Some of these behaviors include:

- In a string that includes punctuation, for example, 'misc.", Visual Studio won't suggest a correction because punctuation in an identifier might result in code that doesn't compile.
- Backslashes in a string will omit the subsequent character from being spell-checked and treat the backslash and subsequent character as a word delimiter. For example, in the string `hello\nworld`, Visual Studio detects the backslash first. Visual Studio treats the `\n` as a word delimiter, which leaves "hello" and "world", each of which are checked individually.
- Strings that contain URLs such as `https://...` or `mailto:..` won't be spell-checked over the entire string.

## Related content

- [Improving the Spell Checker](https://devblogs.microsoft.com/visualstudio/improving-the-spell-checker/)
