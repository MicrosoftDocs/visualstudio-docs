---
title: "About the Text Spell Checker"
description: Learn how to use the Text Spell Checker feature in Visual Studio.
ms.date: 02/21/2023
ms.topic: conceptual
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
monikerRange: vs-2022
---
# Learn about the Text Spell Checker in Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Many of the features in Visual Studio are designed to help you write the code you want, from making sure that your code compiles to helping you with code styling. Now, with the **Text Spell Checker** feature in Visual Studio 2022 [version 17.5](/visualstudio/releases/2022/release-notes-v17.5) and later, it can even make sure your spelling is accurate.

:::image type="content" source="media/vs-2022/text-spell-checker.png" alt-text="Screenshot of an example of the Text Spell Checker in action.":::

The Text Spell Checker feature is automatically toggled on with with any C#, C++, or Markdown file. Visual Studio marks any words that detects as misspelled words. Visual Studio also suggests alternate spellings and helps correct them. The feature even does a contextual rename when those misspellings are identifiers so that your code still compiles.

> [!TIP]
> You can turn the spell checker off or on by using the **Toggle Text Spell Checker** button on the main toolbar, or by using **Edit** > **Advanced** > **Toggle Text Spell Checker** from the menu bar.

## How do you use it?

When the caret is on a spelling error, the quick actions provide solutions for fixing the spelling mistakes. You can bring up the quick actions by using the keyboard shortcuts **Ctrl**+**.** or **Alt**+**Enter**. When the context menu comes up, Visual Studio displays three options to handle a spelling issue.

If any of the dictionaries provide spelling suggestions, Visual Studio displays them. If multiple dictionaries provide suggestions, the suggestions are grouped by dictionary. For strings and comments, choosing one of these suggestions results in a single, in-place replacement. For identifiers in a C++ or a C# document, accepting a suggestion results in a Refactor/Rename that updates all instances of the identifier to make sure the code compiles.

:::image type="content" source="media/vs-2022/text-spell-checker-multiple-dictionaries.png" alt-text="Screenshot of the Text Spelling Checker with multiple dictionaries listed.":::

You can also choose to ignore the spelling issue. By choosing to ignore the issue, Visual Studio creates an exclusion.dic file in your AppData directory on your local machine. After a word has been ignored, it's ignored across all instances of Visual Studio.

## How does it work?

Because C#, C++, and Markdown all use English as the language for their keywords, Visual Studio typically uses the "English (United States)" or "en-us" dictionary for spell checking. Visual Studio checks the instance of Windows for the display language it's using, and if it's not "en-us", it uses that dictionary as well.

Feedback from early users of this feature informed us that developers wanted to know about errors in the documents they were currently working with. In direct response to this feedback, the spell checker scans documents that are open.

The following table shows some of the heuristics that the **Text Spell Checker** looks at when it scans a code document:

| What's in the code | What Visual Studio checks | Why?  |
|---------|---------|---------|
| Hello | Hello, hello | Always check for both proper and common nouns |
| HelloWorld | Hello, hello, World, world | Medial capitals common are used to mark word boundaries |
| Hello.World| Hello, hello, World, world | Punctuation is used as a word boundary |
| _Hello123 | Hello, hello | Leading or trailing numbers or punctuation is stripped |
| Hello2World | Hello, hello, World, world | Medial numbers, like punctuation, is used as word boundary |
| btnWorld | World, world | Fragments of 3 characters or less are ignored |
| helloworld | Helloworld, helloworld | No indicator to identify word boundaries |

Otherwise, Visual Studio considers the word misspelled and flags the token as a spelling error. Visual Studio displays the spelling error with a severity of "Message" in the Error List with a "SPELL" Code.

:::image type="content" source="media/vs-2022/text-spell-checker-error-list-example.png" alt-text="Screenshot of an example of spelling errors in the Error List.":::

## How to customize the Text Spell Checker

The default behavior is designed to get you started and help with the initial spelling checker experience. When you're ready to start working in a collaborative environment, you can customize the experience accordingly.

Visual Studio uses an [EditorConfig](create-portable-custom-editor-options.md) file for configuration so that you can control the spell checker behavior in a repository. By configuring an EditorConfig file, you can establish the coding standards that you expect everyone to follow, which allows you to maintain a coding consistency that might be difficult through other methods.

Here are some examples and use-case scenarios of the switches you can configure in an EditorConfig file:

- List the languages for Visual Studio to use. In this example, Visual Studio would only use the en-us and fr-fr dictionaries when checking for spelling issues. Note that the fr-fr [language pack](../install/install-visual-studio.md) must be installed on the user's machine or Visual Studio will incorrectly flag any French words as spelling errors.

    ```spelling_languages = _language_[,_language_]```<br>
    ```(Example: = en-us,fr-fr)```

- Control what Visual Studio should check. In this example, Visual Studio would check identifiers and comments for misspelled words but wouldn’t check inside strings.

    ```spelling_checkable_types = strings,identifiers,comments```<br>
    ```(Example: = identifiers,comments)```

- Control the severity Visual Studio assigns to spelling errors in the error list. In this example, spelling errors are displayed as errors.

    ```spelling_error_severity = error OR warning OR information OR hint```<br>
    ```(Example: = error)```

- Create your own exclusion dictionary to specify words you consider to be correctly spelled. In this example, the first time the Text Spell Checker is run against any file in the solution, Visual Studio checks for an exclusion.dic file in the same directory as the .sln file (for a C# project) or in the root directory (for a C++ directory). If no exclusion.dic file exists, the spell checker creates one. Then, whenever the user chooses to ignore a word, it's added to this exclusion.dic file. Visual Studio considers any word that appears in this exclusion.dic file as a correctly spelled word.

    ```spelling_exclusion_path = absolute OR relative path to exclusion dictionary```<br>
    ```(Example: = .\exclusion.dic)```

    > [!IMPORTANT]
    > The exclusion.dic file must be UTF16 with BOM encoding to work correctly.
