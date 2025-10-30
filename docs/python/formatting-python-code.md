---
title: Reformat your python code in Visual Studio
description: Automatically format your Python code in Visual Studio, including the code spacing, statements, long line wrapping, and code comments.
author: cwebster-99
ms.author: cowebster
ms.subservice: python
ms.topic: article
ms.date: 04/18/2024
manager: mijacobs

# CustomerIntent: As a developer, I want to reformat Python code in Visual Studio so I can adjust settings like code spacing and line wrapping.
---

# Automatically reformat Python code in Visual Studio

Visual Studio lets you quickly reformat code to match specific formatter standards. In this article, you explore how to access and enable formatting features.

## Choose a formatter

You can set your source code formatter through **Tools** > **Options** > **Text Editor** > **Python** > **Formatting**. Python Tools in Visual Studio support source code formatting with autopep8, Black formatter, and yapf.

:::image type="content" source="media/options-editor-formatting.png" alt-text="Screenshot of the Python formatting options in Visual Studio and the Black formatter option selected." lightbox="media/options-editor-formatting.png":::

[Python support in Visual Studio](installing-python-support-in-visual-studio.md) also adds the **Fill Comment Paragraph** command to the **Edit** > **Advanced** menu as described in a later section.

## Apply format to selection or file

You can apply formatting settings to all content in a file or only to a specific selection.

To format a selection, select **Edit** > **Advanced** > **Format Selection**.

To format the whole file, select **Edit** > **Advanced** > **Format Document**.

## Word wrap

You can enable word wrapping in **Tools** > **Options** > **Text Editor** > **Python** > **General**. In the **Settings** section, select the **Word wrap** checkbox.

:::image type="content" source="media/word-wrap-setting.png" alt-text="Screenshot that shows how to enable word wrapping for Python in Visual Studio." lightbox="media/word-wrap-setting.png":::

## Format comment text

The **Edit** > **Advanced** > **Fill Comment Paragraph** option reflows and formats comment text. 

### Reformat long lines

Use the feature to break up long lines of text, as shown in this example:

```python
# This is a very long long long long long long long long long long long long long long long long long long long comment
```

The text is reformatted as multiple lines:

```python
# This is a very long long long long long long long long long long long long
# long long long long long long long comment
```

### Combine short lines

Use the feature to combine short lines of text, as shown in this example:

```python
# Short line of text
# more text
# text
```

The text is reformatted into a single line:

```python
# Short line of text more text text
```

## Related content

- [Edit Python code](editing-python-code-in-visual-studio.md)
- [Refactor Python code](refactoring-python-code.md)
- [Lint Python code](linting-python-code.md)
