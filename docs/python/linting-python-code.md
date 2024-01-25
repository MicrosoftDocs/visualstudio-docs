---
title: Lint Python Code and check for issues
description: Run a linter in Visual Studio to check issues in Python code, and explore command-line options to customize the linting process.
ms.date: 08/11/2023
ms.topic: how-to
author: cwebster-99
ms.author: cowebster
manager: jmartens
ms.subservice: python
---

# Lint Python code

Linting highlights syntactical and stylistic problems in your Python source code, which often helps you identify and correct subtle programming errors or unconventional coding practices that can lead to errors. For example, linting detects use of an uninitialized or undefined variable, calls to undefined functions, missing parentheses, and even more subtle issues such as attempting to redefine built-in types or functions. Linting is distinct from Formatting because linting analyzes how the code runs and detects errors whereas formatting only restructures how code appears.

[PyLint](https://pypi.org/project/pylint/) and [mypy](https://www.mypy-lang.org/), are widely used tools that check for errors in Python code and encourages good Python coding patterns. Both are integrated into Visual Studio for Python projects.

## Run a linter

In Visual Studio, right-click a Python project in **Solution Explorer** and select **Python** and then choose **Run PyLint** or **Run Mypy**:

:::image type="content" source="media/python-linting-command.png" alt-text="Screenshot of linting command on context menu for Python projects in solution explorer.":::

This command prompts you to install the linter you choose into your active environment if it's not already present.

Linting warnings and errors appear in the **Error List** window:

:::image type="content" source="media/code-pylint-error-list.png" alt-text="Screenshot showing the PyLint error list.":::

Double-clicking an error takes you directly to the source code that generated the issue.

## Set command-line options

Both [Pylint](https://pylint.readthedocs.io/en/latest/user_guide/run.html#command-line-options) and [mypy](https://mypy.readthedocs.io/en/stable/command_line.html) offer command-line options to configure linting settings for your project.

In this example, we will work with Pylint's [command-line options](https://pylint.readthedocs.io/en/latest/user_guide/run.html#command-line-options) to control PyLint's behavior through a `.pylintrc` configuration file. Such a file can be placed in the root of a Python project in Visual Studio or elsewhere, depending on how widely you want those settings applied (see the [command-line options](https://pylint.readthedocs.io/en/latest/user_guide/run.html#command-line-options) for details).

For example, to suppress the "missing docstring" warnings shown in the previous image with a `.pylintrc` file in a project, perform the following steps:

1. On the command line, navigate to your project root (which has your `.pyproj` file) and run the following command to generate a commented configuration file:

   ```command
   pylint --generate-rcfile > .pylintrc
   ```

1. In the **Solution Explorer** window, right-click your project and select **Add** > **Existing Item**. Then go to the new `.pylintrc` file, select it, and select **Add**.

1. Open the file for editing, which has several settings you can work with. To disable a warning, locate the `[MESSAGES CONTROL]` section, then locate the `disable` setting in that section. There's a long string of specific messages to which you can append whichever warnings you want. In the example here, append `,missing-docstring` (including the outlining comma).

1. Save the `.pylintrc` file and run PyLint again to see that the warnings are now suppressed.

   > [!Tip]
   > To use a `.pylintrc` file from a network share, create an environment variable named `PYLINTRC` with the value of the filename on the network share using a Universal Naming Convention (UNC) path or a mapped drive letter. For example, `PYLINTRC=\\myshare\python\.pylintrc`.
