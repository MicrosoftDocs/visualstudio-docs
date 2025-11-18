---
title: IntelliCode Whole-line autocompletions 
ms.date: 11/17/2025
ms.service: visual-studio-family
ms.subservice: intellicode
ms.topic: article
description: IntelliCode Visual Studio Code Completions
author: ghogen
ms.author: ghogen
manager: mijacobs
---

# AI assistance when you write code

IntelliCode whole-line autocompletions predict the next chunk of your code based on your current code so far, and presents it as a gray text inline prediction. Think gray text autocompletion that you see when typing emails but for code.

This feature supports C# in Visual Studio 2022 and later.

![Screenshot of Whole Line Completion by IntelliCode in Visual Studio.](media/intellicode/intellicode-visual-studio-whole-line-completions-small.png)

To turn text predictions off, disable the IntelliCode extension. Select **Extensions** > **Manage Extensions** from the menu, find and select the IntelliCode extension, and then select **Disable**.

## How it works

IntelliCode uses a large scale transformer model, trained on around half a million public, open-source repos from GitHub. This model makes predictions on what you type next based on a rich knowledge of what you have coded so far, including:
- Variable names and positions
- Libraries you're using
- Functions in nearby code
- The IntelliSense list

The model runs on your local machine, which allows the feature to be available in offline and air-gapped environments. The feature supports C#.  

## Two modes

IntelliCode provides completions in two ways - one, when the user is typing and two, when the user has an item selected in the IntelliSense list. 

### Mode 1: Whole-line autocompletions when typing

When the user is typing, we show whole-line autocompletions, which you can accept by "Tab to accept." To dismiss the prediction, you can use the Escape (**Esc**) or Delete (**Del**) keyboard shortcuts.

![Screenshot displaying Tab to accept whole-line autocompletion.](media/intellicode/intellicode-visual-studio-whole-line-completions-small.png)

### Mode 2: Whole-line autocompletions when IntelliSense item is selected

When the user has an item from the IntelliSense list selected, IntelliCode uses what the user has typed + what the user has selected as the context for providing predictions. In this case, you see "Tab Tab to accept" prediction. The first Tab accepts the selected item from the IntelliSense list and the second Tab accepts the whole-line completion. To dismiss the prediction, you can use the Escape (**Esc**) or Delete (**Del**) keyboard shortcuts. 

![Screenshot displaying Tab Tab to accept selected completion item and whole line completion.](media/intellicode/intellicode-visual-studio-whole-line-completions-tab-tab-small.png)

### Accept or dismiss whole-line autocompletions

By default, the **Tab** key is used to accept whole-line autocompletions. You can change the default accept key to the right arrow **>** from the **Tools** > **Options** menu.

:::moniker range="visualstudio"

<a name="apply-completions-right-arrow-2026"> </a>

Open the **Tools** > **Options** pane, and expand the **All Settings** > **Text Editor** > **Code Completions** > **Preferences** section. Use the dropdown list and set the **Accept code completions using keyboard shortcuts** option to **On Right Arrow**.

:::image type="content" source="media/visualstudio/intellicode-tools-options-right-arrow.png" border="false" alt-text="Screenshot that shows how to configure the option to accept code completions by using the right arrow.":::

:::moniker-end
:::moniker range="vs-2022"

<a name="apply-completions-right-arrow-2022"> </a>

Open the **Tools** > **Options** dialog, and expand the **IntelliCode** > **Advanced** section. Select the **Apply whole line completions on right arrow** checkbox, and then select **OK**.

![Screenshot of Settings menu to change right arrow to accept whole-line autocompletion.](media/vs-2022/intellicode-tools-options-right-arrow.png)

:::moniker-end
:::moniker range="<=vs-2019"

Open the **Tools** > **Options** dialog, and expand the **IntelliCode** > **Advanced** section. Select the **Apply completions for whole lines on right arrow** checkbox, and then select **OK**.

![Screenshot of Settings menu to change right arrow to accept whole-line autocompletion.](media/intellicode/intellicode-visual-studio-whole-line-completions-right-arrow.png)

:::moniker-end

To dismiss whole-line autocompletions, use the Escape (**Esc**) or Delete (**Del**) keyboard shortcuts. 

## Privacy 

[See Privacy](intellicode-privacy.md#intellicode-whole-line-completions)

## Control whole-line autocompletions

You can control the whole-line autocompletions feature using the small purple light bulb shown at the bottom right of the editor, next to the zoom control. 

:::moniker range="visualstudio"

In the **Tools** > **Options** pane, the **All Settings** > **Text Editor** > **Code Completions** > **General** section provides the **Code Completion Invocation** option. This setting lets you set whole-line autocompletions to **Automatic on Edit and Manual** or **Manual**.

:::image type="content" source="media/visualstudio/automatic-completions-edit-manual.png" border="false" alt-text="Screenshot shows how to set the code completion invocation option for IntelliCode.":::

The **All Settings** > **Text Editor** > **Code Completions** > **Preferences** section provides more options, including:

- **Show code completions on new lines**: View whole-line autocompletions when you enter a new line by using the **Enter** (or Return) key. 

- **Show code completions while in debug mode**: View whole-line autocompletions while you're debugging your code.

- **Show code completions only after a pause in typing**: Display whole-line autocompletions only when you pause typing. You might prefer this option if you find the whole-line autocompletions distracting in the default mode.

- **Hide the hint bar that appears alongside code completions and Next Edit Suggestions**: Minimize distractions when debugging.

- **Accept code completions using keyboard shortcuts**: Set this option to the right arrow **>** key for accepting whole-line autocompletions, as described [earlier in this article](#apply-completions-right-arrow-2026).

:::moniker-end
:::moniker range="<=vs-2022"

In the **Tools** > **Options** dialog, the **IntelliCode** > **General** section provides the **Automatically generate code completions in the Editor** option. This setting lets you turn whole-line autocompletions on or off.

:::image type="content" source="media/vs-2022/generate-code-completions-editor.png" border="false" alt-text="Screenshot shows how to set the automatically generate code completions in the editor option for IntelliCode.":::

:::moniker-end
:::moniker range="vs-2022"

The **IntelliCode** > **Advanced** section provides more options in the **Whole-line Completions** group, including:

- **Apply whole line completions on right arrow**: Use the right arrow **>** key to accept whole-line autocompletions, as described [earlier in this article](#apply-completions-right-arrow-2022).

- **Disable suggestions while debugging**: Minimize distractions when debugging.

- **Show inline completions on new lines**: View whole-line autocompletions when you enter a new line by using the **Enter** (or Return) key. 

- **Wait for pauses in typing before showing whole line completions**: Display whole-line autocompletions only when you pause typing. You might prefer this option if you find the whole-line autocompletions distracting in the default mode.

:::moniker-end
:::moniker range="<=vs-2019"

![Screenshot of setting for turning IntelliCode whole-Line autocompletions on or off.](media/intellicode/intellicode-visual-studio-whole-line-completions-quiet-mode-small.png)

The first setting, **Show completions for lines of code** allows you to turn whole-line autocompletions on or off. 

The second setting, **Wait for pauses in typing before showing line completions**, when enabled, makes whole-line autocompletions only show up if the user has paused typing. You might prefer this option if you find the whole-line autocompletions distracting in the default mode.

The third setting, **Show completions on new lines** can be turned on or off depending on whether you want to see whole-line autocompletions when you enter a new line, that is, by pressing **Return** or **Enter**. 

:::moniker-end

## Provide feedback

Select the Feedback icon on the top right of Visual Studio to file a feedback ticket. Optionally, you can upload your IntelliCode log files to the feedback ticket in order to provide us with more context. Make sure you review the contents of the log files and address any privacy concerns you might have. Any data you share with Microsoft isn't used for any purpose other than providing you with support assistance. You can find the logs at _%LOCALAPPDATA%\Temp\VSFeedbackIntelliCodeLogs_.

![Screenshot of submitting feedback for IntelliCode.](media/intellicode/intellicode-visual-studio-whole-line-completions-feedback-small.png)

## Next steps

[See Privacy](intellicode-privacy.md#intellicode-whole-line-completions)
