---
title: Lint Python code and check for issues
description: Run the pylint or mypy linter in Visual Studio to check for issues in your Python code, and explore command-line options to customize the linting process.
ms.date: 04/18/2024
ms.topic: how-to
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

# CustomerIntent: As a developer, I want to use linting tools in Visual Studio so that I can check for issues in my Python code.
---

# Lint Python code in Visual Studio

The linting process highlights language syntax and style problems in your Python source code. You can run a linter on your code to identify and correct subtle programming mistakes or unconventional coding practices that can lead to errors. Linting can detect the use of an uninitialized or undefined variable, calls to undefined functions, missing parentheses, and subtle issues like attempts to redefine built-in types or functions. Linting is distinct from formatting because it analyzes how your code runs and detects errors whereas formatting only restructures how your code appears.

Two common options for linting include [pylint](https://pypi.org/project/pylint/) and [mypy](https://www.mypy-lang.org/). These tools are widely used to check for errors in Python code and encourage good Python coding patterns. Both tools are integrated into Visual Studio for Python projects.

## Prerequisites 

- Visual Studio. To install the product, follow the steps in [Install Visual Studio](../install/install-visual-studio.md).
- Access to a Python project to run linting tools on existing code.

## Run a linter

The linting tools in Visual Studio are available in **Solution Explorer**.

The following steps show how to use a linter to check your code.

1. In Visual Studio, right-click a Python project in **Solution Explorer** and select **Python**, then choose **Run PyLint** or **Run Mypy**:

   :::image type="content" source="media/python-linting-command.png" alt-text="Screenshot that shows the available linting commands for Python projects in Solution Explorer." border="false" lightbox="media/python-linting-command.png":::

   The command prompts you to install the linter you choose into your active environment if it's not already present.

1. After the linter runs on your code, you can review any lint warnings and errors in the **Error List** window:

   :::image type="content" source="media/code-pylint-error-list.png" alt-text="Screenshot that shows the list of pylint errors and warnings for the code file in Visual Studio." border="false" lightbox="media/code-pylint-error-list.png" :::

1. Double-click an error or warning to go to the location in the source code where the issue is generated.

## Set command-line options

Both [pylint](https://pylint.readthedocs.io/en/latest/user_guide/run.html#command-line-options) and [mypy](https://mypy.readthedocs.io/en/stable/command_line.html) offer command-line options to configure linting settings for your project.

This section shows an example that uses the pylint [command-line options](https://pylint.readthedocs.io/en/latest/user_guide/run.html#command-line-options) to control pyLint behavior through a `.pylintrc` configuration file. This file can be placed in the root of a Python project in Visual Studio or another folder, depending on how widely you want to apply the settings.

The following steps suppress "missing docstring" warnings (as shown in the previous image) by using a `.pylintrc` file in the Python project.

1. On the command line, browse to the project root folder that has the `.pyproj` file, and run the following command to generate a commented configuration file:

   ```console
   pylint --generate-rcfile > .pylintrc
   ```

1. In **Solution Explorer**, right-click the project and select **Add** > **Existing Item**.

1. In the dialog, browse to the folder that has the new `.pylintrc` file. Select the `.pylintrc` file, and then select **Add**.

1. In **Solution Explorer**, open the `.pylintrc` file for editing.

1. There are several settings you can configure in the file. This example shows how to disable a warning.

   1. Locate the `[MESSAGES CONTROL]` section, and then locate the `disable` setting within that section.

      :::image type="content" source="media/code-pylint-messages-control.png" alt-text="Screenshot that shows the disable setting in the MESSAGES CONTROL section of the pylintrc file in Visual Studio." border="false" lightbox="media/code-pylint-messages-control.png":::
   
      The `disable` setting consists of a long string of specific messages to which you can append whichever warnings you want.
      
   1. Append the string `,missing-docstring` (including the comma prefix) to the `disable` setting value:

      :::image type="content" source="media/code-pylint-messages-control-disable.png" alt-text="Screenshot that shows how to append a specific warning message to the disable setting in the pylintrc file in Visual Studio." border="false" lightbox="media/code-pylint-messages-control-disable.png":::

1. Save the `.pylintrc` file.

1. Run pylint again. Notice that the "missing docstring" warnings are now suppressed.

## Use pylintrc file from network share

You can use a `.pylintrc` file from a network share.

1. Create an environment variable named `PYLINTRC`.

1. Assign the variable the value of the filename on the network share by using a Universal Naming Convention (UNC) path or a mapped drive letter. For example, `PYLINTRC=\\myshare\python\.pylintrc`.

## Related content

- [Edit Python code](editing-python-code-in-visual-studio.md)
- [Refactor Python code](refactoring-python-code.md)
