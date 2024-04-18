---
title: Symbols for mixed-mode Python/C++ debugging
description: Explore how you can use Visual Studio to load symbols from program database (PDB) files to support complete mixed-mode debugging for C++ and Python.
ms.date: 04/18/2024
ms.topic: how-to
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

#customer intent: As a developer, I want to use debugging symbols for Python interpreters in Visual Studio so that I can run mixed-mode Python and C++ debugging
---

# Install debugging symbols for Python interpreters in Visual Studio

This article provides steps to download and integrate debugging symbols for Python interpreters in Visual Studio.

To provide a full debugging experience, the [mixed-mode Python debugger](debugging-mixed-mode-c-cpp-python-in-visual-studio.md) in Visual Studio needs debug symbols for the Python interpreter to parse numerous internal data structures. The debugging symbols are defined in program database (*.pdb*) files. For example, the *python27.dll* library requires the *python27.pdb* symbol file, the *python36.dll* library uses the symbol file *python36.pdb*, and so on. Each version of the interpreter also supplies symbol files for various modules.

- In Visual Studio 2017 and later, the Python 3 and Anaconda 3 interpreters automatically install their respective symbols and Visual Studio finds the symbols automatically. 

- In Visual Studio 2015 and earlier, or for other interpreters, you need to download symbols separately and then point Visual Studio to the files.

When Visual Studio detects missing required symbols, a dialog prompts you to take action. You typically see the dialog when you start a mixed-mode debugging session. The dialog includes the **Open symbol settings dialog** link, which opens the **Tools** > **Options** dialog to the **Debugging** > **Symbols** tab, along with a link to this documentation article.

:::image type="content" source="media/mixed-mode-debugging-symbols-required.png" alt-text="Screenshot that shows the prompt in Visual Studio to provide the missing required debugging symbols." lightbox="media/mixed-mode-debugging-symbols-required.png" border="false":::

## Prerequisites

- Visual Studio installed with support for Python workloads. For more information, see [Install Python support in Visual Studio](installing-python-support-in-visual-studio.md).

## Check your interpreter version

Symbols differ between minor builds of Python and between 32-bit and 64-bit builds. It's important to confirm your version and build of Python to ensure you have the correct symbols for your interpreter.

To check which Python interpreter is in use:

1. In **Solution Explorer**, expand the **Python Environments** *node* under your project.

1. Locate the name of the current environment (shown in bold).

1. Right-click the environment name and select **Open Command Prompt Here**.

   A command prompt window opens to the install location of the current environment.

1. Start python by entering the following command:

   ```console
   python.exe
   ```
   
   The execution process displays your installed Python version and indicates whether it's 32-bit or 64-bit:

   :::image type="content" source="media/find-python-version.png" alt-text="Screenshot that shows how to use a command prompt opened to the install location of the current environment to detect the Python version." lightbox="media/find-python-version.png" border="false":::

## Download symbols

The following steps describe how to download the required symbols for a Python interpreter.

- For **Python 3.5 and later**, acquire the debug symbols through the Python installer.

   1. Select **Custom installation**, then select **Next**.
   
   1. On the **Advanced Options** page, select the boxes for **Download debugging symbols** and **Download debug binaries**:

      :::image type="content" source="media/mixed-mode-debugging-symbols-installer35.png" alt-text="Screenshot that shows how to select debugging symbols and binaries in the Python 3.x installer." lightbox="media/mixed-mode-debugging-symbols-installer35.png" border="false":::

   The symbol files (*.pdb*) are located in the root installation folder. Symbol files for individual modules are also placed in the *DLLs* folder.
   
   Visual Studio finds these symbols automatically. No further steps are needed.

- For **Python 3.4.x and earlier**, symbols are available as downloadable `.zip` files from the [official distributions](#access-downloads-for-official-distributions) or from [Enthought Canopy](#use-enthought-canopy-symbols).

   1. Download your required symbol file.

      > [!IMPORTANT]
      > Be sure to select the symbol file that corresponds to your installed Python version and build (32-bit or 64-bit).
   
   1. Extract the symbol files to a local folder within the Python folder, such as *Symbols*.

   1. After you extract the files, the next step is to [Point Visual Studio to the symbols](#point-visual-studio-to-the-symbols).

- For other third-party Python distributions such as ActiveState Python, contact the authors of that distribution and request them to provide you with symbols.

   WinPython incorporates the standard Python interpreter without changes. You can use symbols from the official WinPython distribution for the corresponding version number.

## Point Visual Studio to the symbols

If you downloaded symbols separately, follow these steps to make Visual Studio aware of the symbols.

> [!NOTE]
> If you installed symbols by using the Python 3.5 or later installer, Visual Studio finds the symbols automatically. You don't need to complete the steps in this section.

1. Select **Tools** > **Options**, and open the **Debugging** > **Symbols** tab.

1. Select **Add** (plus symbol) on the toolbar.

1. Enter the folder path where you extracted the downloaded symbols. This location is where the `python.pdb` file is located, such as *c:\python34\Symbols*, as shown in the following image.

   :::image type="content" source="media/mixed-mode-debugging-symbols.png" alt-text="Screenshot that shows the mixed mode debugger symbols options on the Tools Options Debugging dialog." lightbox="media/mixed-mode-debugging-symbols.png" border="false":::

1. Select **OK**.

During a debugging session, Visual Studio might also prompt you for the location of a source file for the Python interpreter. If you downloaded source files, such as from [python.org/downloads/](https://www.python.org/downloads/), you can point Visual Studio to the downloaded files.

### Symbol caching options

The **Tools** > **Options**, **Debugging** > **Symbols**  dialog also contains options to configure symbol caching. Visual Studio uses the symbol caching features to create a local cache of symbols obtained from an online source.

These features aren't needed with the Python interpreter symbols because symbols are already present locally. For more information, see [Specify symbols and source files in the Visual Studio debugger](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md).

## Access downloads for official distributions

The following table lists download information for official Python version releases.

| Python version | Downloads                                                                                                                                                 |
| --- | --- |
| 3.5 and later  | Install symbols through the Python installer.                                                                                                             |
| 3.4.4          | [32-bit](https://www.python.org/ftp/python/3.4.4/python-3.4.4-pdb.zip) - [64-bit](https://www.python.org/ftp/python/3.4.4/python-3.4.4.amd64-pdb.zip)     |
| 3.4.3          | [32-bit](https://www.python.org/ftp/python/3.4.3/python-3.4.3-pdb.zip) - [64-bit](https://www.python.org/ftp/python/3.4.3/python-3.4.3.amd64-pdb.zip)     |
| 3.4.2          | [32-bit](https://www.python.org/ftp/python/3.4.2/python-3.4.2-pdb.zip) - [64-bit](https://www.python.org/ftp/python/3.4.2/python-3.4.2.amd64-pdb.zip)     |
| 3.4.1          | [32-bit](https://www.python.org/ftp/python/3.4.1/python-3.4.1-pdb.zip) - [64-bit](https://www.python.org/ftp/python/3.4.1/python-3.4.1.amd64-pdb.zip)     |
| 3.4.0          | [32-bit](https://www.python.org/ftp/python/3.4.0/python-3.4.0-pdb.zip) - [64-bit](https://www.python.org/ftp/python/3.4.0/python-3.4.0.amd64-pdb.zip)     |
| 3.3.5          | [32-bit](https://www.python.org/ftp/python/3.3.5/python-3.3.5-pdb.zip) - [64-bit](https://www.python.org/ftp/python/3.3.5/python-3.3.5.amd64-pdb.zip)     |
| 3.3.4          | [32-bit](https://www.python.org/ftp/python/3.3.4/python-3.3.4-pdb.zip) - [64-bit](https://www.python.org/ftp/python/3.3.4/python-3.3.4.amd64-pdb.zip)     |
| 3.3.3          | [32-bit](https://www.python.org/ftp/python/3.3.3/python-3.3.3-pdb.zip) - [64-bit](https://www.python.org/ftp/python/3.3.3/python-3.3.3.amd64-pdb.zip)     |
| 3.3.2          | [32-bit](https://www.python.org/ftp/python/3.3.2/python-3.3.2-pdb.zip) - [64-bit](https://www.python.org/ftp/python/3.3.2/python-3.3.2.amd64-pdb.zip)     |
| 3.3.1          | [32-bit](https://www.python.org/ftp/python/3.3.1/python-3.3.1-pdb.zip) - [64-bit](https://www.python.org/ftp/python/3.3.1/python-3.3.1.amd64-pdb.zip)     |
| 3.3.0          | [32-bit](https://www.python.org/ftp/python/3.3.0/python-3.3.0-pdb.zip) - [64-bit](https://www.python.org/ftp/python/3.3.0/python-3.3.0.amd64-pdb.zip)     |
| 2.7.18         | [32-bit](https://www.python.org/ftp/python/2.7.18/python-2.7.18-pdb.zip) - [64-bit](https://www.python.org/ftp/python/2.7.18/python-2.7.18.amd64-pdb.zip) |
| 2.7.17         | [32-bit](https://www.python.org/ftp/python/2.7.17/python-2.7.17-pdb.zip) - [64-bit](https://www.python.org/ftp/python/2.7.17/python-2.7.17.amd64-pdb.zip) |
| 2.7.16         | [32-bit](https://www.python.org/ftp/python/2.7.16/python-2.7.16-pdb.zip) - [64-bit](https://www.python.org/ftp/python/2.7.16/python-2.7.16.amd64-pdb.zip) |
| 2.7.15         | [32-bit](https://www.python.org/ftp/python/2.7.15/python-2.7.15-pdb.zip) - [64-bit](https://www.python.org/ftp/python/2.7.15/python-2.7.15.amd64-pdb.zip) |
| 2.7.14         | [32-bit](https://www.python.org/ftp/python/2.7.14/python-2.7.14-pdb.zip) - [64-bit](https://www.python.org/ftp/python/2.7.14/python-2.7.14.amd64-pdb.zip) |
| 2.7.13         | [32-bit](https://www.python.org/ftp/python/2.7.13/python-2.7.13-pdb.zip) - [64-bit](https://www.python.org/ftp/python/2.7.13/python-2.7.13.amd64-pdb.zip) |
| 2.7.12         | [32-bit](https://www.python.org/ftp/python/2.7.12/python-2.7.12-pdb.zip) - [64-bit](https://www.python.org/ftp/python/2.7.12/python-2.7.12.amd64-pdb.zip) |
| 2.7.11         | [32-bit](https://www.python.org/ftp/python/2.7.11/python-2.7.11-pdb.zip) - [64-bit](https://www.python.org/ftp/python/2.7.11/python-2.7.11.amd64-pdb.zip) |
| 2.7.10         | [32-bit](https://www.python.org/ftp/python/2.7.10/python-2.7.10-pdb.zip) - [64-bit](https://www.python.org/ftp/python/2.7.10/python-2.7.10.amd64-pdb.zip) |
| 2.7.9          | [32-bit](https://www.python.org/ftp/python/2.7.9/python-2.7.9-pdb.zip) - [64-bit](https://www.python.org/ftp/python/2.7.9/python-2.7.9.amd64-pdb.zip)     |
| 2.7.8          | [32-bit](https://www.python.org/ftp/python/2.7.8/python-2.7.8-pdb.zip) - [64-bit](https://www.python.org/ftp/python/2.7.8/python-2.7.8.amd64-pdb.zip)     |
| 2.7.7          | [32-bit](https://www.python.org/ftp/python/2.7.7/python-2.7.7-pdb.zip) - [64-bit](https://www.python.org/ftp/python/2.7.7/python-2.7.7.amd64-pdb.zip)     |
| 2.7.6          | [32-bit](https://www.python.org/ftp/python/2.7.6/python-2.7.6-pdb.zip) - [64-bit](https://www.python.org/ftp/python/2.7.6/python-2.7.6.amd64-pdb.zip)     |
| 2.7.5          | [32-bit](https://www.python.org/ftp/python/2.7.5/python-2.7.5-pdb.zip) - [64-bit](https://www.python.org/ftp/python/2.7.5/python-2.7.5.amd64-pdb.zip)     |
| 2.7.4          | [32-bit](https://www.python.org/ftp/python/2.7.4/python-2.7.4-pdb.zip) - [64-bit](https://www.python.org/ftp/python/2.7.4/python-2.7.4.amd64-pdb.zip)     |
| 2.7.3          | [32-bit](https://www.python.org/ftp/python/2.7.3/python-2.7.3-pdb.zip) - [64-bit](https://www.python.org/ftp/python/2.7.3/python-2.7.3.amd64-pdb.zip)     |
| 2.7.2          | [32-bit](https://www.python.org/ftp/python/2.7.2/python-2.7.2-pdb.zip) - [64-bit](https://www.python.org/ftp/python/2.7.2/python-2.7.2.amd64-pdb.zip)     |
| 2.7.1          | [32-bit](https://www.python.org/ftp/python/2.7.1/python-2.7.1-pdb.zip) - [64-bit](https://www.python.org/ftp/python/2.7.1/python-2.7.1.amd64-pdb.zip)     |

## Use Enthought Canopy symbols

Enthought Canopy provides debugging symbols for its binaries starting from version 1.2. These symbols are automatically installed alongside with the distribution.

- To use the symbols, manually add the folder that contains the symbols to the symbol path, as described in [Point Visual Studio to the symbols](#point-visual-studio-to-the-symbols).

   For a typical per-user installation of Canopy, the symbols are located in the following folders:

   - 64-bit version: *%UserProfile%\AppData\Local\Enthought\Canopy\User\Scripts*
   - 32-bit version: *%UserProfile%\AppData\Local\Enthought\Canopy32\User\Scripts*

Enthought Canopy 1.1 and earlier and Enthought Python Distribution (EPD), don't provide interpreter symbols. These releases aren't compatible with mixed-mode debugging.

## Related content

- [Specify symbols and source files in the Visual Studio debugger](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md)
- [Debug Python and C++ together (mixed-mode debugging)](debugging-mixed-mode-c-cpp-python-in-visual-studio.md)
