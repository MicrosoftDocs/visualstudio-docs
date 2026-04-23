---
title: Use IntelliSense for quick information & completion
description: Explore how to work with IntelliSense features in Visual Studio, including List Members, Parameter Info, Quick Info, and Complete Word.
ms.date: 3/19/2026
ms.topic: concept-article
helpviewer_keywords:
- Quick info
- Parameter info
- Complete word
- List members
- IntelliSense [Visual Studio]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# IntelliSense in Visual Studio

IntelliSense is a code-completion aid that includes features to help you learn more about the code you're using, keep track of the parameters that you type, and add calls to properties and methods with only a few keystrokes.

These features include:
- [List Members](#list-members)
- [Parameter Info](#parameter-info)
- [Quick Info](#quick-info)
- [Complete Word](#complete-word)

Many aspects of IntelliSense are language-specific. For more information about IntelliSense for different languages, see the articles listed in the [Related content](#related-content) section.

In addition to IntelliSense, Visual Studio offers AI-powered code completions through GitHub Copilot. Copilot inline suggestions work alongside IntelliSense to provide whole-line and multi-line completions. To learn more, see [Get started with GitHub Copilot completions](visual-studio-github-copilot-extension.md).

## List Members

A list of valid members from a type or namespace appears after you type a trigger character, such as a period (`.`) in managed code or `::` in C++. If you continue typing characters, the list filters to include only the members that begin with those characters or where the beginning of *any* word within the name starts with those characters. IntelliSense also performs *camel case* matching, so you can type just the first letter of each camel-cased word in the member name to see the matches.

After you select an item, you can insert it into your code by pressing **Tab** or by typing a space. If you select an item and type a period, the item appears followed by the period, which brings up another member list. When you select an item but before you insert it, you get [Quick Info](#quick-info) for the item.

In the member list, the icon to the left represents the member type, such as namespace, class, function, or variable. The list might be long, so you can press **PgUp** and **PgDn** to move up or down in the list.

:::image type="content" source="media/visualstudio/using-intellisense/intellisense-list-members.png" alt-text="Screenshot of IntelliSense list members feature.":::

You can invoke the List Members feature manually by typing **Ctrl**+**J**, choosing **Edit** > **IntelliSense** > **List Members**, or by choosing the **List Members** button on the editor toolbar. When you invoke it on a blank line or outside a recognizable scope, the list displays symbols in the global namespace.

::: moniker range="visualstudio"

To turn List Members off by default so that it doesn't appear unless specifically invoked, go to **Tools** > **Options** > **Text Editor** > **All Languages** and deselect **Auto list members**. To turn off List Members only for a specific language, go to **General** settings for that language.

::: moniker-end

::: moniker range="vs-2022"

To turn List Members off by default so that it doesn't appear unless specifically invoked, go to **Tools** > **Options** > **Languages** > **Defaults** > **General** > **Statement Completion** and deselect **Auto list members**. To turn off List Members only for a specific language, go to **General** settings for that language.

::: moniker-end

You can also change to suggestion mode, in which only the text you type is inserted into the code. For example, if you enter an identifier that isn't in the list and press **Tab**, in completion mode the entry replaces the typed identifier. To toggle between completion mode and suggestion mode, press **Ctrl**+**Alt**+**Space**, or choose **Edit** > **IntelliSense** > **Switch between automatic and tab-only IntelliSense completion**.

## Parameter Info

*Parameter Info* shows you the number, names, and types of parameters that a method, attribute generic type parameter (in C#), or template (in C++) needs.

The parameter in bold shows the next parameter you need as you type the function. For overloaded functions, use the **Up** and **Down** arrow keys to see other parameter information for the function overloads.

:::image type="content" source="media/visualstudio/using-intellisense/intellisense-parameter-info.png" alt-text="Screenshot of the IntelliSense Parameter Info feature.":::

When you add XML Documentation comments to functions and parameters, Parameter Info shows those comments. For more information, see [Supply XML code comments](reference/generate-xml-documentation-comments.md).

You can manually open Parameter Info by choosing **Edit** > **IntelliSense** > **Parameter Info**, by pressing **Ctrl**+**Shift**+**Space**, or by choosing the **Parameter Info** button on the editor toolbar.

## Quick Info

*Quick Info* displays the complete declaration for any identifier in your code.

:::image type="content" source="media/visualstudio/using-intellisense/intellisense-quick-info.png" alt-text="Screenshot of the IntelliSense Quick Info feature.":::

When you select a member from the List Members box, Quick Info also appears.

:::image type="content" source="media/visualstudio/using-intellisense/intellisense-quick-info-parameter-info.png" alt-text="Screenshot of the IntelliSense Quick Info and Parameter Info feature.":::

You can manually invoke Quick Info by choosing **Edit** > **IntelliSense** > **Quick Info**, by pressing **Ctrl**+**K**, **Ctrl**+**I**, or by choosing the **Quick Info** button on the editor toolbar.

If a function is overloaded, IntelliSense might not display information for all forms of the overload.

::: moniker range="visualstudio"

To turn Quick Info off, go to **Tools** > **Options** > **Text Editor** > **All Languages** and deselect **Show Quick Info on hover** in the **Settings** section.

::: moniker-end

::: moniker range="vs-2022"

To turn Quick Info off, go to **Tools** > **Options** > **Languages** and deselect **Show Quick Info on hover** in the **General** section.

::: moniker-end

## Complete Word

*Complete Word* completes the rest of a variable, command, or function name after you enter enough characters to disambiguate the term. You can invoke Complete Word by choosing **Edit** > **IntelliSense** > **Complete Word**, by pressing **Ctrl**+**Space**, or by choosing the **Complete Word** button on the editor toolbar.

## IntelliSense options

IntelliSense options are on by default. 

::: moniker range="visualstudio"

To turn them off, go to **Tools** > **Options** > **Languages** > **Defaults** > **General** > **Statement Completion** and deselect **Parameter information** or **Auto list members**.

::: moniker-end

::: moniker range="vs-2022"

To turn them off, go to **Tools** > **Options** > **Text Editor** > **All Languages** and deselect **Parameter information** or **Auto list members**.

::: moniker-end

> [!TIP]
> To change the appearance of user interface elements in Visual Studio, go to **Tools** > **Options** > **Environment** > **Fonts and Colors**. For more information about these settings and how to interact with them, see [Fonts and Colors, Environment, Options dialog box](fonts-and-colors-environment-options-dialog-box.md).

## IntelliSense icons

The icons in IntelliSense convey additional meaning through icon modifiers. These icons include stars, hearts, and locks layered on top of the object's icon that convey protected, internal, or private, respectively.

:::moniker range="visualstudio"

|    Icon    |    Accessibility    |    Description    |
|------------|---------------------|-------------------|
| ![Public Icon Modifier](../ide/media/visualstudio/intellisense-public-no-modifier.png)       |    Public class    |    Access isn't restricted.   |
| ![Protected Icon Modifier](../ide/media/visualstudio/intellisense-protected-modifier.png)       |    Protected class    |    Access is limited to the containing class or types derived from the containing class.    |
| ![Protected Internal Icon Modifier](../ide/media/visualstudio/intellisense-protected-modifier.png)       |    Protected internal class    |    Access is limited to the current assembly or types derived from the containing class.    |
| ![Internal Icon Modifier](../ide/media/visualstudio/intellisense-internal-modifier.png)       |    Internal class    |    Access is limited to the current assembly.    |
|![Private Icon Modifier](../ide/media/visualstudio/intellisense-private-modifier.png)        |    Private class    |    Access is limited to the containing class or types derived from the containing class within the current assembly. (Available since C# 7.2.)    |

:::moniker-end

:::moniker range="vs-2022"

|    Icon    |    Accessibility    |    Description    |
|------------|---------------------|-------------------|
| ![Public Icon Modifier](../ide/media/intellisensePublicNoModifier.png)       |    Public class    |    Access isn't restricted.   |
| ![Protected Icon Modifier](../ide/media/intellisenseProtectedModifier.png)       |    Protected class    |    Access is limited to the containing class or types derived from the containing class.    |
| ![Protected Internal Icon Modifier](../ide/media/intellisenseProtectedInternalModifier.png)       |    Protected internal class    |    Access is limited to the current assembly or types derived from the containing class.    |
| ![Internal Icon Modifier](../ide/media/intellisenseInternalModifier.png)       |    Internal class    |    Access is limited to the current assembly.    |
|![Private Icon Modifier](../ide/media/intellisensePrivateModifier.png)        |    Private class    |    Access is limited to the containing class or types derived from the containing class within the current assembly. (Available since C# 7.2.)    |

:::moniker-end

## Troubleshoot IntelliSense

The IntelliSense options might not work as you expect in certain cases.

- **The cursor is below a code error**: You might not be able to use IntelliSense if an incomplete function or other error exists in the code above the cursor because IntelliSense might not be able to parse the code elements. You can resolve this problem by commenting out the applicable code.

- **The cursor is in a code comment**: You can't use IntelliSense if the cursor is in a comment in your source file.

- **The cursor is in a string literal**: You can't use IntelliSense if the cursor is in the quotation marks around a string literal, as in the following example:

    ```cpp
    MessageBox( hWnd, "String literal|")
    ```

- **The automatic options are turned off**: By default, IntelliSense works automatically, but you can disable it. Even if automatic statement completion is disabled, you can invoke an IntelliSense feature.

## Related content

- [Get started with GitHub Copilot](visual-studio-github-copilot-get-started.md)
- [C# IntelliSense](../ide/visual-csharp-intellisense.md)
- [Visual Basic IntelliSense](../ide/visual-basic-specific-intellisense.md)
- [JavaScript IntelliSense](../ide/javascript-intellisense.md)
- [Write and refactor C++ code](/cpp/ide/writing-and-refactoring-code-cpp)
- [Insert XML code comments](reference/generate-xml-documentation-comments.md)
