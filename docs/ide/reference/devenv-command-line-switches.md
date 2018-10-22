---
title: Visual Studio devenv command line switches
ms.date: 02/28/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: reference
helpviewer_keywords:
  - "switches, Devenv"
  - "command-line switches, Devenv"
  - "command line [Visual Studio], switches"
  - "Devenv"
ms.assetid: e12bc6ed-74fd-4bea-8d7c-89b99c20bad8
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# Devenv command line switches

Devenv lets you set various options for the integrated development environment (IDE), as well as build, debug, and deploy projects, from the command line. Use these switches to run the IDE from a script or a .bat file, for example a nightly build script, or to start the IDE in a particular configuration.

> [!NOTE]
> For build-related tasks, it is recommended that you use MSBuild instead of devenv. For more information, see [MSBuild command-line reference](../../msbuild/msbuild-command-line-reference.md).

## Devenv switch syntax

By default, devenv commands pass switches to the devenv.com utility. The devenv.com utility delivers output through standard system streams, such as `stdout` and `stderr`. The utility determines the appropriate I/O redirection when it captures output, for example to a .txt file.

On the other hand, commands that begin with `devenv.exe` can use the same switches, but the devenv.com utility is bypassed.

The syntax rules for `devenv` switches resemble those for other DOS command-line utilities. The following syntax rules apply to all `devenv` switches and their arguments:

- Commands begin with `devenv`.

- Switches are not case-sensitive.

- When specifying a solution or project, the first argument is the name of the solution file or project file, including file path.

- If the first argument is a file that is not a solution or project, that file opens in the appropriate editor, in a new instance of the IDE.

- When you supply a project file name instead of a solution file name, a `devenv` command searches the parent folder of the project file for a solution file that has the same name. For example, the command `devenv /build myproject1.vbproj` searches the parent folder for a solution file that is named "myproject1.sln".

    > [!NOTE]
    > One and only one solution file that references this project should be located in its parent folder. If the parent folder contains no solution file that references this project, or if the parent folder contains two or more solution files that reference it, then a temporary solution file is created.

- When file paths and file names include spaces, you must enclose them in quotation marks (""). For example, "c:\project a\\".

- Insert one space character between switches and arguments on the same line. For example, the command **devenv /log output.txt** opens the IDE and outputs all log information for that session to output.txt.

- You cannot use pattern-matching syntax in `devenv` commands.

## Devenv switches

The following command-line switches display the IDE and perform the described task.

|Command line switch|Description|
|-------------------------|-----------------|
|[/Command](../../ide/reference/command-devenv-exe.md)|Starts the IDE and executes the specified command.|
|[/DebugExe](../../ide/reference/debugexe-devenv-exe.md)|Loads a C++ executable under the control of the debugger. This switch is not available for Visual Basic or C# executables. For more information, see [Automatically start a process in the debugger](../../debugger/debug-multiple-processes.md#BKMK_Automatically_start_an_process_in_the_debugger).|
|[/LCID or /l](../../ide/reference/lcid-devenv-exe.md)|Sets the default language for the IDE. If the specified language is not included in your installation of Visual Studio, this setting is ignored.|
|[/Log](../../ide/reference/log-devenv-exe.md)|Starts Visual Studio and logs all activity to the log file.|
|[/Run or /r](../../ide/reference/run-devenv-exe.md)|Compiles and runs the specified solution.|
|[/Runexit](../../ide/reference/runexit-devenv-exe.md)|Compiles and runs the specified solution, minimizes the IDE when the solution is run, and closes the IDE after the solution has finished running.|
|[/UseEnv](../../ide/reference/useenv-devenv-exe.md)|Causes the IDE to use PATH, INCLUDE, and LIB environment variables for C++ compilation, instead of the settings specified in the VC++ Directories section of **Projects** options in the **Options** dialog box. This switch is installed with the **Desktop development with C++** workload. For more information, see [Setting the Path and Environment Variables for Command-Line Builds](/cpp/build/setting-the-path-and-environment-variables-for-command-line-builds).|
|[/Edit](../../ide/reference/edit-devenv-exe.md)|Opens the specified files in a running instance of this application. If there are no running instances, it starts a new instance with a simplified window layout.|
|[/SafeMode](../../ide/reference/safemode-devenv-exe.md)|Starts Visual Studio in safe mode, and loads only the default environment and services, and shipped versions of third-party packages.|
|[/ResetSkipPkgs](../../ide/reference/resetskippkgs-devenv-exe.md)|Clears all SkipLoading tags that have been added to VSPackages by users who want to avoid loading problem VSPackages.|
|[/Setup](../../ide/reference/setup-devenv-exe.md)|Forces Visual Studio to merge resource metadata that describes menus, toolbars, and command groups, from all VSPackages available. You must run this command as an administrator.|

The following command-line switches do not display the IDE.

|Command line switch|Description|
|-------------------------|-----------------|
|[/?](../../ide/reference/q-devenv-exe.md)|Displays help for devenv switches in the **Command Prompt window**.<br /><br /> **Devenv /?**|
|[/Build](../../ide/reference/build-devenv-exe.md)|Builds the specified solution or project according to the configuration of the specified solution.<br /><br /> **Devenv myproj.csproj /build**|
|[/Clean](../../ide/reference/clean-devenv-exe.md)|Deletes any files created by the build command, without affecting source files.<br /><br /> **Devenv myproj.csproj /clean**|
|[/Deploy](../../ide/reference/deploy-devenv-exe.md)|Builds the solution, along with files necessary for deployment, according to the solutions configuration.<br /><br /> **Devenv myproj.csproj /deploy**|
|[/Diff](../../ide/reference/diff.md)|Compares two files. Takes four parameters: SourceFile, TargetFile, SourceDisplayName (optional), TargetDisplayName (optional).|
|[/Out](../../ide/reference/out-devenv-exe.md)|Lets you specify a file to receive errors when you build.<br /><br /> **Devenv myproj.csproj /build /out log.txt**|
|[/Project](../../ide/reference/project-devenv-exe.md)|The project to build, clean, or deploy. You can use this switch only if you have also supplied the /build, /rebuild, /clean, or /deploy switch.|
|[/ProjectConfig](../../ide/reference/projectconfig-devenv-exe.md)|Specifies the project configuration to build or deploy. You can use this switch only if you have also supplied the /project switch.|
|[/Rebuild](../../ide/reference/rebuild-devenv-exe.md)|Cleans and then builds the specified solution or project according to the configuration of the specified solution.|
|[/ResetSettings](../../ide/reference/resetsettings-devenv-exe.md)|Restores Visual Studio default settings. Optionally resets the settings to the specified .vssettings file.|
|[/Upgrade](../../ide/reference/upgrade-devenv-exe.md)|Upgrades the specified solution file and all its project files, or the specified project file, to the current Visual Studio formats for these files.|

## See also

* [General, Environment, Options Dialog Box](../../ide/reference/general-environment-options-dialog-box.md)