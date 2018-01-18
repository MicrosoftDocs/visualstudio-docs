---
title: How To Define Custom Commands for Python Projects in Visual Studio | Microsoft Docs
description: Demonstrates how to edit project or targets files to add custom commands to the Python project context menu in Visual Studio.
ms.custom: ""
ms.date: 01/18/2018
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-python"
ms.devlang: python
ms.tgt_pltfrm: ""
ms.topic: "article"
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: ghogen
ms.workload: 
  - "python"
  - "data-science"
---

# Defining custom commands for Python projects

In the process of working with your Python projects, you may find it yourself switching to a command window to run specific scripts. To improve your workflow, you can add custom commands to the **Python** sub-menu in the Python project context menu. By default, that menu contains only the single **Run Pylint** command:

![Default appearance of the Python sub-menu on a project's context menu](media/custom-commands-default-menu.png)

Custom commands can be added to a project file directly, where they apply to only that individual project, or to a `.targets` file so that they appear for all projects of a particular type.

Certain Python project templates in Visual Studio already add custom commands of their own using their `.targets` file. For example, the Bottle Web Project and Flask Web Project templates both add two commands, **Start server** and **Start debug server**. The Django Web Project template add these same commands plus quite a few more:

![Appearance of the Python sub-menu on a Django project's context menu](media/custom-commands-django-menu.png)

Each custom menu command simply contains the appropriate command that Visual Studio runs as if you entered it in a command window. This means that you can run Python scripts or tools written in any other language.

This article first explains the structure of a custom command, then demonstrates adding commands to a project file and a `.targets` file.

> [!Tip]
> The typical process of editing a project file in Visual Studio means right-clicking the project file and selecting **Unload project**, then right-clicking again and selecting **Edit (project-name)**, making and saving edits, then right-clicking the project once more and selecting **Reload project**.
> Although these steps work, they become tedious when developing a custom command. A more efficient workflow is to have the project loaded in Visual Studio, then open the project file in a separate editor altogether (such as another instance of Visual Studio, Visual Studio Code, Notepad, etc.). When you save changes in the separate editor and switch to Visual Studio, Visual Studio detects the changes and asks whether to reload the project. Select **Reload** and your changes are immediately applied.

## Command target structure

A custom commands is defined with a `<Target>` element that contains a `<CreatePythonCommandItem>` element, as shown in the following general form:

```xml
<Target Name="Name1" Label="Display Name" Returns="@(Commands)">
    <CreatePythonCommandItem Target="filename, module name, or code"
        TargetType="executable/script/module/code/pip"
        Arguments="..."
        ExecuteIn="console/consolepause/output/repl[:Display name]/none"
        WorkingDirectory="..."
        ErrorRegex="..."
        WarningRegex="..."
        RequiredPackages="...;...">

      <!-- Output always appears in this form, with these exact attributes -->
      <Output TaskParameter="Command" ItemName="Commands" />
    </CreatePythonCommandItem>
  </Target>
```

Project properties can be used in attribute values, such as "$(StartupFile)".

**Target attributes:**

| Attribute | Required | Description |
| --- | --- | --- |
| Name | Yes | The identifier for the command within the Visual Studio project. |
| Label | Yes | The UI display name that appears in the Python menu. |
| Returns | Yes | Must contain `@(Commands)`. |

**CreatePythonCommandItem attributes** 
| Attribute | Required | Description |
| --- | --- | --- |
| TargetType | Yes | Specifies what Target contains, which determines how it's used. The allowable, case-insensitive values are:<ul><li>**executable**: Target contains the name of an executable program that is run as if entered directly on the command line. The value must contain only a program name with no arguments.</li><li>**script**: Target contains the name of a Python code file which is run with `python.exe`. The string in Arguments is appended to the command.</li><li>**module**: the name of a module which is run with `python.exe -m`. The string in Arguments is appended to the command.</li><li>**code**: Target contains inline Python code. The Arguments value is ignored.</li><li>**pip**: Target contains arguments to run with `pip`.</li></ul> |
| Target | Yes | The filename, module name, or code to use with the command, depending on the TargetType. The value can be the name of property defined elsewhere in the project file or a `.targets` file. See example below. |
| Arguments | Optional | Specifies a string of arguments (if any) to give to the target. Note that when TargetType is `script`, the arguments are given to the Python program, not python.exe. TBD: Examples |
| ExecuteIn | Yes | Specifies how to run Target:<ul><li>**console**: (Default) Runs Target and the arguments as if they are entered directly on the command line. A command window appears while the Target is running, then is closed automatically.</li><li>**consolepause**: Same a console, but waits for a keypress before closing the window.</li><li>**output**: Runs Target and displays its results in the Output window in Visual Studio</li><li>**repl**: Runs Target in the Interactive Window; the optional display name is used for the title of the window.</li><li>**none**: Uses whatever is the default for the command.</li></ul>|
| WorkingDirectory | Optional | The folder in which to run the Target. |
| ErrorRegex<br>WarningRegEx | Optional | Used only when ExecuteIn is `output`. Both values specify a regular expression used to parse errors and warnings from the target's output. Those errors and warnings are displayed in the Error List window in Visual Studio. If not specified, errors/warnings are not detected. |
| RequiredPackages | Optional | A list of package requirements for the command using setuptools format. Visual Studio checks that all packages in this list are installed before running the command, installing any missing packages using pip. For example, the **Run PyLint** command uses a value of `pylint>=1.0.0` for this attribute. |
| Environment | Optional | A string of environment variables to define before running the command. Each variable uses of the form NAME=VALUE with multiple variables separated by semicolons. An variable with multiple values must be contained in single or double quotes, as in 'NAME=VALUE1;VALUE2'. |

**Named capture groups for regular expressions**

The `ErrorRegex` and `WarningRegex` values should use named capture groups to extract and present information about the error or warning in question. Visual Studio recognizes the following named groups:

- `(?<message>...)`: Text of the error
- `(?<code>...)`: Error code
- `(?<filename>...)`: Name of the file for which the error is reported
- `(?<line>...)`: Line number of the location in the file for which the error reported.
- `(?<column>...)`: Column number of the location in the file for which the error reported.

For example, PyLint produces warnings of the following form:

```
************* Module hello
C:  1, 0: Missing module docstring (missing-docstring)
```

To allow Visual Studio to parse such warnings and show them in the **Error List** window, the `WarningRegex` value for the **Run PyLint** command is as follows:

```
^(?<filename>.+?)\((?<line>\d+),(?<column>\d+)\): warning (?<msg_id>.+?): (?<message>.+?)$]]
```

### Adding custom commands to a project file

  <PropertyGroup>
    <PythonCommands>$(PythonCommands);RunPythonCommand</PythonCommands>
  </PropertyGroup>


## Creating a .targets file with custom commands

  <PropertyGroup>
    <PythonCommands>$(PythonCommands);RunPythonCommand</PythonCommands>
  </PropertyGroup>

## Troubleshooting

### Message: "The project file could not be loaded"

Indicates that you have syntax errors in the project file. The message includes the specific error with a line number and character position.

### Console window closes immediately after command is run

?

### Command does not appear on the menu

Check that the command is included in the `<PythonCommands>` property group, and that the name in the command list matches the name specified in the `<Target>` element.

For example, in the following elements, the "Example" name in the property group does not match the name "ExampleCommand" in the target. Visual Studio does not find a command named "Example", so no command appears. Either use "ExampleCommand" in the command list, or change the name of the target to "Example" only.

```xml
  <PropertyGroup>
    <PythonCommands>$(PythonCommands);Example</PythonCommands>
  </PropertyGroup>
  <Target Name="ExampleCommand" Label="Example Command" Returns="@(Commands)">
    <!-- ... -->
  </Target>
```

### Message: An error occurred while running (command name). Failed to get command (target-name) from project.

Indicates that the contents of the `<Target>` or `<CreatePythonCommandItem>` elements are incorrect. Possible reasons include:

- The `TargetType` attribute contains an unrecognized value.
- The `ExecuteIn` attribute contains an unrecognized value.
- `ErrorRegex` or `WarningRegex` is specified without setting `ExecuteIn="output"`.

TBD: details logged?

### Visual Studio hangs and crashes when running the command

You're likely attempting to run a console command with `ExecuteIn="output"`, in which case Visual Studio may crash trying to parse the output. Use `ExecuteIn="console"` instead.

### Executable command "is not recognized as an internal or external command, operate program or batch file"

When using `TargetType="executable"`, the value in `Target` must be *only* the program name without any arguments, such as "python" or "python.exe" only. Move any arguments to the `Arguments` attribute.
