---
title: Options for Python Code and Projects (Features)
description: Explore options in Visual Studio for Python code and projects, including feature descriptions of environment preferences, debugging, diagnostics, and advanced settings.
ms.date: 01/07/2026
ms.topic: concept-article
f1_keywords:
  - "VS.ToolsOptionsPages.Python_Tools"
  - "VS.ToolsOptionsPages.Python_Tools.General"
  - "VS.ToolsOptionsPages.Python_Tools.Debugging"
  - "VS.ToolsOptionsPages.Python_Tools.Diagnostics"
  - "VS.ToolsOptionsPages.Python_Tools.Experimental"
  - "VS.ToolsOptionsPages.Python_Tools.Interactive_Windows"
  - "VS.ToolsOptionsPages.Text_Editor.Python.Advanced"
author: Devdiv-VR
ms.author: vedhar
manager: mijacobs
ms.subservice: python

# CustomerIntent: As a developer, I want to set options for Python code and projects in Visual Studio, so I can configure the development environment to meet my programming needs.
---

# Options for Python in Visual Studio

Visual Studio provides support for configuring the interactive development environment (IDE) for Python development. You can set options according to your preference and to meet specific development environment needs. This article describes options available for general layout and behavior, debugging, diagnostics, and advanced Python language features.

## Location of Python options

Python configuration settings are available from the Visual Studio toolbar under **Tools** > **Options**. The **Options** dialog lists most settings for Python on the **Python** tab:

::: moniker range=">=vs-2022"

:::image type="content" source="media/vs-2022/options-python-all-tabs-general.png" alt-text="Screenshot that shows the categories of options for Python and the specific general options in Visual Studio 2022." lightbox="media/vs-2022/options-python-all-tabs-general.png":::

You can configure preferences for debugging, Pylance language server analysis, conda environments, the general environment, and **Interactive Windows**.

::: moniker-end

::: moniker range="visualstudio"

The **Options** pane lists other Python settings under **All Settings** > **Languages** > **Python**. There are options for scroll bars, tabs, and formatting, along with general and advanced settings. Other settings are available under **Environment** > **Fonts and Colors** for the **Text Editor** settings group.

::: moniker-end
::: moniker range="vs-2022"

The **Options** dialog lists other Python settings under **Text Editor** > **Python**. There are options for scroll bars, tabs, and formatting, along with general and advanced settings. Other settings are available under **Environment** > **Fonts and Colors** for the **Text Editor** settings group.

::: moniker-end

> [!NOTE]
> The **Options** dialog might include an **Experimental** tab or group for features under development that aren't described in this article. You can find more information in posts on the [Python engineering at Microsoft blog](https://devblogs.microsoft.com/python/).

## Specific options for Python

Under **Tools** > **Options** > **Python**, you can set Python-specific options for the general environment including **Interactive Windows**, conda environments, debugging, and more.

### General Python options

The following options are available under **Tools** > **Options** > **Python**> **General**:

::: moniker range=">=vs-2022"

| Option | Default | Description |
| --- | --- | --- |
| **Show the Output Window when creating virtual environments**| On | Clear to prevent the **Output** window from appearing. |
| **Show the Output Window when installing or removing packages** | On | Clear to prevent the **Output** window from appearing. |
| **Show notifications bar to create environments** | On | When set and you open a project with a *requirements.txt* or *environment.yml* file, Visual Studio displays an information bar with suggestions to create a virtual environment or conda environment, respectively, instead of using the default global environment. |
| **Show notifications bar to install packages** | On | When set and you open a project with a *requirements.txt* file that doesn't use the default global environment), Visual Studio compares those requirements with packages installed in the current environment. If any packages are missing, Visual Studio displays a prompt to install those dependencies. |
| **Show notifications bar to configure test framework** | On | When set, if Visual Studio detects files in your Python project that might contain tests but no test framework is enabled, Visual Studio prompts you to enable pytest or unittest. |
| **Always run package managers as administrator** | Off | Always elevates `pip install` and similar package manager operations for all environments. When you install packages, Visual Studio prompts for administrator privileges if the environment is located in a protected area of the file system such as *c:\Program Files*. In that prompt you can choose to always elevate the install command for just that one environment. For more information, see [Packages tab](python-environments-window-tab-reference.md#packages-tab). |

::: moniker-end

### Conda environment options

The following options are available under **Tools** > **Options** > **Python**> **Conda**:

| Option | Default | Description |
| --- | --- | --- |
| **Conda executable path** | (blank) | Specifies an exact path to the *conda.exe* executable rather than relying on the default Miniconda installation included with the Python workload. If another path is given here, it takes precedence over the default installation and any other conda.exe executables specified in the registry. You might change this setting if you manually install a newer version of Anaconda or Miniconda, or want to use a 32-bit distro rather than the default 64-bit distro. |

### Debugging options

The following options are available under **Tools** > **Options** > **Python**> **Debugging**:

::: moniker range=">=vs-2022"

| Option | Default | Description |
| --- | --- | --- |
| **Prompt before running when errors are present** | On | When this option is set, Visual Studio prompts you to confirm that you want to run code that has errors. To disable the warning, clear this option. |
| **Wait for input when process exits abnormally**<br/><br/>**Wait for input when process exits normally** | On (for both) | A Python program started from Visual Studio runs in its own console window. By default, the window waits for you to press a key before closing it regardless of how the program exits. To remove that prompt and close the window automatically, clear either or both of these options. |
| **Tee program output to Debug Output window** | On | Displays program output in both a separate console window and the Visual Studio **Output** window. Clear this option to show output only in the separate console window. |
| **Break on SystemExit exception with exit code of zero** | Off | If set, stops the debugger on this exception. When clear, the debugger exits without breaking. |
| **Enable debugging of the Python standard library** | Off | Makes it possible to step into the standard library source code while debugging, but increases the time it takes for the debugger to start.|
| **Show function return value** | On | Displays function return values in the **Locals** window then stepping over a function call in the debugger (F10) |
| **Show variables** | On | Displays four groups of variables to show and how to format the display (Group, Hide, Inline). <br> - **Class**: Default is "Group" <br> - **Protected**: Default is Inline" <br> - **Function**: Default is "Group" <br> - **Special**: Default is "Group" |  

::: moniker-end

::: moniker range=">=vs-2022"

### Analysis options

The following options are available under **Tools** > **Options** > **Python**> **Analysis**:

| Option | Default | Description |
| --- | --- | --- |
| **Diagnostic mode** | Open files only | Specifies what code files the language server analyzes for problems, including **Workspace** and **Open files only**. | 
| **Log level** | Information | Specifies the level of logging to perform by the language server. The possible levels of logging, in increasing level of information provided, include **Error**, **Warning**, **Information**, and **Trace**. | 
| **Type checking** | Off | Specifies the level of type checking analysis to perform: <br> - **Off**: Produce unresolved imports/variables diagnostics but don't conduct type checking analysis <br>  - **Basic**: Use non-type (all rules on under the **Off** level) and also basic type checking-related rules <br> - **Strict**: Use all type checking rules at the highest severity of error, including all rules on under both the **Off** and **Basic** levels | 
| **Import format** | Absolute | Defines the default format when auto importing modules, including **Absolute** or **Relative**. | 
| **Stubs path** | \<Empty> |  Specifies a path to a directory that contains custom type stubs. The type stub files for each package are expected to be in their own subdirectory. | 
| **Search paths** | \<Empty> | Specifies search paths for import resolution. Accepts paths specified as strings and separated by commas if there are multiple paths, such as `["path 1","path 2"]`.  | 
| **Typeshed paths** | \<Empty> | Specifies paths for Visual Studio to use custom Typeshed files instead of its bundled version. | 
| **Automatically add common search paths like 'src'** | On | Indicates whether to automatically add search paths based on predefined names, such as `src`. | 
| **Index installed third party libraries and user files for language features such as auto-import, add import, workspace symbols and etc.** | Off | Specifies whether the language server should index user files and installed third-party libraries at startup. The index provides a more complete set of symbols in features, including auto imports, Quick Fixes, auto completions, and so on. <br> - When set, Visual Studio indexes the top-level symbols of installed packages, such as symbols in **all** under **package/\_\_init\_\_.py**, along with all symbols from up to 2,000 user files. <br> - When not set, Visual Studio displays symbols referenced or used in files previously opened in or loaded by the editor.  | 

::: moniker-end

### Interactive Windows options

The following options are available under **Tools** > **Options** > **Python**> **Interactive Windows**:

| Option | Default | Description |
| --- | --- | --- |
| **Scripts** | n/a | Specifies a general folder for startup scripts to apply to **Interactive Windows** for all environments. For more information, see [Startup scripts](python-environments-window-tab-reference.md#startup-scripts). **Note**: This feature might not work in your version of Visual Studio. |
| **Up/down arrows navigate history** | On | Uses the arrow keys to navigate through history in the **Interactive** window. Clear this setting to use the arrow keys to navigate within the **Interactive** window's output instead. |
| **Completion mode** | **Only evaluate expressions without function calls** | The process of determining the available members on an expression in the **Interactive** window might require evaluating the current unfinished expression, which can result in side-effects or functions being called multiple times. The default setting, **Only evaluate expressions without function calls** excludes expressions that appear to call a function, but evaluates other expressions. For example, it evaluates the statement `a.b` but not the `a().b` statement.  **Never evaluate expressions** prevents all side-effects, using only the normal IntelliSense engine for suggestions. **Evaluate all expressions** evaluates the complete expression to obtain suggestions, regardless of side effects. |
| **Hide static analysis suggestions** | Off | When set, displays only suggestions that are obtained by evaluating the expression. If combined with the **Completion mode** value **Never evaluate expressions**, no useful completions appear in the **Interactive** window. |

::: moniker range="visualstudio"

## Language options for Python

In the **All Settings** > **Languages** > **Python** section, there are options for scroll bars, tabs, and formatting, along with general and advanced settings:

:::image type="content" source="media/visualstudio/options-languages-python-general.png" alt-text="Screenshot that shows the categories of language options for Python and specific general options in Visual Studio 2026.":::

### General Python editor options

The following Python language options are available in the **General** section.

> [!NOTE]
> Many of the following options can be set at the global level for all languages. The global settings are in the **All Settings** > **Languages** > **Defaults** > **General** section.

| Option | Default | Description |
| --- | --- | --- |
| **Enable virtual space** | Off | When set, inserts spaces at the end of each line of code. Select this option to position comments at a consistent point next to your code. The **Virtual Space** mode is enabled in **Column Selection** mode. When **Virtual Space** mode isn't enabled, the insertion point moves from the end of one line directly to the first character of the next line. | 
| **Word wrap** | Off | Set this option to allow long lines of code to wrap based on the editors viewport width. | 
| **Show visual glyphs for word wrap** | Off | When the **Word wrap** option is enabled, set this option to show visual glyphs. | 
| **Line numbers** | On | Set this option to show line numbers in the left margin of the editor for each line of code. | 
| **Enable single-click URL navigation** | On | When set, you can single-click a URL to browse to the target location. | 
| **Show quick info on hover** | On | When set, Visual Studio displays quick information about the code keyword while the cursor is positioned over the code element. | 
| **Automatic brace completion** | On | When set, Visual Studio automatically adds the closing brace for any open brace as you enter code. | 
| **Apply Cut or Copy to blank lines when there is no selection** | On | By default, Visual Studio cuts or copies the entire line of code when there's no explicit selection. Use this option to enable or disable this Cut or Copy behavior when invoked on blank lines. | 

For more information, see [Options: Text Editor > General](../ide/reference/options-text-editor-general.md).

::: moniker-end
::: moniker range="vs-2022"

## Text editor options for Python

Under **Text Editor** > **Python**, there are options for scroll bars, tabs, and formatting, along with general and advanced settings:

:::image type="content" source="media/vs-2022/options-text-editor-python-all-tabs-general.png" alt-text="Screenshot that shows the categories of text editor options for Python and specific general options in Visual Studio 2022." lightbox="media/vs-2022/options-text-editor-python-all-tabs-general.png":::

### General Python editor options

The following options are available under **Tools** > **Options** > **Text Editor** > **Python** > **General**:

| Option | Default | Description |
| --- | --- | --- |
| **Auto list members** | On | Set this option to automatically list members for completion of code statements. | 
| **Hide advanced members** | On | When the **Auto list members** option is enabled, set this option to hide advanced members from the completion suggestions. Advanced members are members that are used less frequently than others. | 
| **Parameter information** | On | When set, hovering over parameters shows detailed information, such as the item definition and links to documentation. | 
| **Enable virtual space** | On | When set, inserts spaces at the end of each line of code. Select this option to position comments at a consistent point next to your code. The **Virtual Space** mode is enabled in **Column Selection** mode. When **Virtual Space** mode isn't enabled, the insertion point moves from the end of one line directly to the first character of the next line. <br> **Note**: This option is influenced by the **Text Editor** > **All Languages** > **General** > **Enable virtual space** global setting. If the global setting isn't enabled, this option can't be enabled at the language level. | 
| **Word wrap** | Off | Set this option to allow long lines of code to wrap based on the editors viewport width. | 
| **Show visual glyphs for word wrap** | Off | When the **Word wrap** option is enabled, set this option to show visual glyphs. | 
| **Line numbers** | Off | Set this option to show line numbers in the left margin of the editor for each line of code. | 
| **Enable single-click URL navigation** | On | When set, you can single-click a URL to browse to the target location. | 
| **Navigation bar** | Off | Set this option to enable the dropdown boxes at the top of the code window. These fields help you navigate to code in a codebase where you can choose a type or member to go directly to. <br> **Note**: This option is influenced by the **Text Editor** > **All Languages** > **General** > **Enable navigation bar** global setting. For more information, see [Navigate code> Navigation bar](../ide/navigating-code.md#navigate-code). | 
| **Automatic brace completion** | On | When set, Visual Studio automatically adds the closing brace for any open brace as you enter code. | 
| **Apply Cut or Copy to blank lines when there is no selection** | On | By default, Visual Studio cuts or copies the entire line of code when there's no explicit selection. Use this option to enable or disable this Cut or Copy behavior when invoked on blank lines. | 

For more information, see [Options dialog: Text Editor > General](../ide/reference/options-text-editor-general.md).

::: moniker-end

::: moniker range=">=vs-2022"

### Advanced Python editor options

The following options are available under **Tools** > **Options** > **Text Editor** > **Python** > **Advanced**:

| Option | Default | Description |
| --- | --- | --- |
| **Offer auto-import completions** | On | When set, Visual Studio offers auto imports in completions. | 
| **Automatically add brackets for functions** | Off | When set, Visual Studio automatically adds brackets for functions as you enter code in the editor. | 

::: moniker-end

## Fonts and Colors options

Other Python options are available under **Environment** > **Fonts and Colors** when the **Text Editor** group is set to **Python**:

::: moniker range=">=vs-2022"

:::image type="content" source="media/vs-2022/options-fonts-and-colors-2022.png" alt-text="Screenshot that shows Python font and color options under Environment in the Options dialog in Visual Studio 2022." lightbox="media/vs-2022/options-fonts-and-colors-2022.png":::

::: moniker-end

The names of the Python options are all prefixed with "Python" and are self-explanatory. The default font for all Visual Studio color themes is 10 pt Consolas regular (not bold). The default colors vary by theme. Typically, you change a font or color to make it easier to read text.
