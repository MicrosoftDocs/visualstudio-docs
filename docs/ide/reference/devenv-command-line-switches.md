---
title: Devenv command line switches
description: Learn about devenv command-line switches and how to use them to set IDE options, and also build, debug, and deploy projects, all from the command line.
ms.date: 11/01/2023
ms.topic: reference
helpviewer_keywords:
- switches, Devenv
- command-line switches, Devenv
- command line [Visual Studio], switches
- Devenv
ms.custom: "ide-ref"
author:ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# Devenv command-line switches

Devenv lets you set various options for the IDE, build projects, debug projects, and deploy projects from the command line. Use these switches to run the IDE from a script or a .bat file (such as a nightly build script), or to start the IDE in a particular configuration.

> [!NOTE]
> For build-related tasks, it's recommended that you use MSBuild instead of devenv. For more information, see [MSBuild command-line reference](../../msbuild/msbuild-command-line-reference.md).

For information about switches that are primarily intended for Visual Studio extension development, also see [Devenv command-line switches for VSPackage development](../../extensibility/devenv-command-line-switches-for-vspackage-development.md).

## Devenv switch syntax

Commands that begin with `devenv` are handled by the `devenv.com` utility, which delivers output through standard system streams, such as `stdout` and `stderr`. The utility determines the appropriate I/O redirection when it captures output, for example to a .txt file.

Alternatively, commands that begin with `devenv.exe` can use the same switches, but the `devenv.com` utility is bypassed. Using `devenv.exe` directly prevents output from appearing on the console.

The syntax rules for `devenv` switches resemble the rules for other DOS command-line utilities. The following syntax rules apply to all `devenv` switches and their arguments:

- Commands begin with `devenv`.

- Switches aren't case-sensitive.

- You can specify a switch by using a hyphen ("-") or a forward slash ("/").

- When specifying a solution or project, the first argument is the name of the solution file or project file, including file path.

- If the first argument is a file that's not a solution or project, that file opens in the appropriate editor, in a new instance of the IDE.

- When you supply a project file name instead of a solution file name, a `devenv` command searches the parent folder of the project file for a solution file that has the same name. For example, the command `devenv myproject1.vbproj /build` searches the parent folder for a solution file that's named `myproject1.sln`.

  > [!NOTE]
  > One and only one solution file that references this project should be located in its parent folder. If the parent folder contains no solution file that references this project, or if the parent folder contains two or more solution files that reference it, then a temporary solution file is created.

- When file paths and file names include spaces, you must enclose them in quotation marks (""). For example, `"c:\project a\"`.

- Insert one space character between switches and arguments on the same line. For example, the command `devenv /log output.txt` opens the IDE and outputs all log information for that session to output.txt.

- You can't use pattern-matching syntax in `devenv` commands.

## Devenv switches

The following command-line switches display the IDE and do the described task.

|Command line switch|Description|
| - |-----------------|
|[/Command](command-devenv-exe.md)|Starts the IDE and executes the specified command.<br /><br /> `devenv /command "nav https://learn.microsoft.com/"`|
|[/DebugExe](debugexe-devenv-exe.md)|Loads a C++ executable under the control of the debugger. This switch isn't available for Visual Basic or C# executables. For more information, see [Automatically start a process in the debugger](../../debugger/debug-multiple-processes.md#BKMK_Automatically_start_an_process_in_the_debugger).<br /><br /> `devenv /debugexe mysln.exe`|
|[/Diff](diff.md)|Compares two files. Takes four parameters: *SourceFile*, *TargetFile*, *SourceDisplayName* (optional), and *TargetDisplayName* (optional).<br /><br /> `devenv /diff File1 File2 Alias1 Alias2`|
|[/DoNotLoadProjects](donotloadprojects-devenv-exe.md)|Opens the specified solution without loading any projects.<br /><br /> `devenv /donotloadprojects mysln.sln`|
|[/Edit](edit-devenv-exe.md)|Opens the specified files in a running instance of this application. If there are no running instances, it starts a new instance with a simplified window layout.<br /><br /> `devenv /edit File1 File2`|
|[/LCID or /L](lcid-devenv-exe.md)|Sets the default language for the IDE. If the specified language isn't included in your installation of Visual Studio, this setting is ignored.<br /><br /> `devenv /l 1033`|
|[/Log](log-devenv-exe.md)|Starts Visual Studio and logs all activity to the log file.<br /><br /> `devenv /log mylogfile.xml`|
|/NoScale| Opens the IDE in a [DPI-disabled mode](../../designers/disable-dpi-awareness.md) that allows for a more accurate layout in the Windows Forms Designer. |
|[/NoSplash](nosplash-devenv-exe.md)|Opens the IDE without showing the splash screen.<br /><br /> `devenv /nosplash File1 File2`|
|[/ResetSettings](resetsettings-devenv-exe.md)|Restores Visual Studio default settings. Optionally resets the settings to the specified `.vssettings` file.<br /><br /> `devenv /resetsettings mysettings.vssettings`|
|[/Run or /R](run-devenv-exe.md)|Compiles and runs the specified solution.<br /><br /> `devenv /run mysln.sln`|
|[/RunExit](runexit-devenv-exe.md)|Compiles and runs the specified solution, minimizes the IDE when the solution is run, and closes the IDE after the solution has finished running.<br /><br /> `devenv /runexit mysln.sln`|
|[/SafeMode](safemode-devenv-exe.md)|Starts Visual Studio in safe mode. This switch loads only the default environment, the default services, and the shipped versions of third-party packages.<br /><br /> This switch takes no arguments.|
|/TfsLink|Opens Team Explorer and launches a viewer for the provided artifact URI if one is registered.|
|[/UseEnv](useenv-devenv-exe.md)|Causes the IDE to use PATH, INCLUDE, LIBPATH, and LIB environment variables for C++ compilation. This switch is installed with the **Desktop development with C++** workload. For more information, see [Setting the Path and Environment Variables for Command-Line Builds](/cpp/build/setting-the-path-and-environment-variables-for-command-line-builds).|

The following command-line switches don't display the IDE.

|Command line switch|Description|
| - |-----------------|
|[/?](q-devenv-exe.md)|Displays help for `devenv` switches in the **Command Prompt window**.<br /><br /> This switch takes no arguments.|
|[/Build](build-devenv-exe.md)|Builds the specified solution or project according to the configuration of the specified solution.<br /><br /> `devenv mysln.sln /build`|
|[/Clean](clean-devenv-exe.md)|Deletes any files created by the build command, without affecting source files.<br /><br /> `devenv mysln.sln /clean`|
|[/Deploy](deploy-devenv-exe.md)|Builds the solution, along with files necessary for deployment, according to the solution's configuration.<br /><br /> `devenv mysln.sln /deploy`|
|[/Out](out-devenv-exe.md)|Lets you specify a file to receive errors when you build.<br /><br /> `devenv mysln.sln /build Debug /out log.txt`|
|[/Project](project-devenv-exe.md)|The project to build, clean, or deploy. You can use this switch only if you've also supplied the `/Build`, `/Rebuild`, `/Clean`, or `/Deploy` switch.<br /><br /> `devenv mysln.sln /build Debug /project proj1`|
|[/ProjectConfig](projectconfig-devenv-exe.md)|Specifies the project configuration to build or deploy. You can use this switch only if you've also supplied the `/Project` switch.<br /><br /> `devenv mysln.sln /build Release /project proj1 /projectconfig Release`|
|[/Rebuild](rebuild-devenv-exe.md)|Cleans and then builds the specified solution or project according to the configuration of the specified solution.<br /><br /> `devenv mysln.sln /rebuild`|
|[/Setup](../../extensibility/devenv-command-line-switches-for-vspackage-development.md#guidelines-for-switches)|Forces Visual Studio to merge resource metadata that describes menus, toolbars, and command groups from all available VSPackages. You can only run this command as an administrator.|
|[/Upgrade](upgrade-devenv-exe.md)|Upgrades the specified solution file and all its project files, or the specified project file, to the current Visual Studio formats for these files.<br /><br /> `devenv mysln.sln /upgrade`|

## See also

- [General, Environment, Options Dialog Box](general-environment-options-dialog-box.md)
- [Devenv command-line switches for VSPackage development](../../extensibility/devenv-command-line-switches-for-vspackage-development.md)
