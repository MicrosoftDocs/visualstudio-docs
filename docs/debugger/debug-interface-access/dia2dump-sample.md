---
description: The Dia2dump sample shows how to use the Microsoft Debug Interface Access Software Development Kit (DIA SDK) to query a PDB file for information.
title: Dia2dump Sample
ms.date: "07/24/2018"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "sample applications [DIA SDK]"
  - "Dia2dump sample [DIA SDK]"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Dia2dump Sample

The Dia2dump sample shows how to use the Microsoft Debug Interface Access (DIA) SDK to query a PDB file for information.

The Dia2dump sample is installed with Visual Studio and contains the solution and source files. The compiled executable runs from the command line. It can display the contents of an entire program database (.pdb) file, or just the sections you're interested in.

## Install the sample

The sample is installed when you choose the **Desktop development with C++** workload in the Visual Studio Installer. For information on how to install Visual Studio and choose specific workloads and individual components, see [Install Visual Studio](../../install/install-visual-studio.md).

When installed, the sample is in your Visual Studio installation directory, in a subdirectory named \DIA SDK\Samples\DIA2Dump.

## Build the sample

By default, the installation directory is a protected directory. That means you must use an elevated Developer command prompt or instance of Visual Studio to build and edit the sample solution in this location. To simplify the build, we recommend you first copy the files from the sample directory to another directory, such as a folder in your Documents folder, and then build the sample.

### To build the Dia2Dump sample in Visual Studio

1. Open the DIA2Dump.sln file in Visual Studio. If you did not copy the solution to another directory, you might be prompted to restart Visual Studio with elevated permissions.

1. In **Solution Explorer**, select the Dia2Dump project (not the solution).

1. Open the project's **Property Pages** dialog box. For details, see [Working with Project Properties](/cpp/build/working-with-project-properties).

1. Open the **Configuration Properties** > **C/C++** > **General** property page.

1. In the **Additional Include Directories** property, choose the dropdown list control, then choose **Edit**.

1. In the **Additional Include Directories** dialog, in the edit field, enter the `$(VSInstallDir)DIA SDK\include` directory. Add this directory to guarantee that the compiler can find the dia2.h file. Choose **OK** to save your changes.

1. Choose **OK** to save your changes to the project properties.

1. On the **Build** menu, choose **Rebuild Solution**. By default, Visual Studio builds a Debug version of the sample, located in a Debug subdirectory of the solution directory.

1. Close Visual Studio.

### To build the Dia2Dump sample at the command line

1. In a Developer command prompt window, change to the directory where you copied the sample files. If you didn't copy the sample to another directory, you must use an elevated (run as administrator) Developer command prompt window.

1. Enter the command `nmake all` to build the default Debug configuration of dia2dump.exe.

## Run the Dia2Dump sample

Dia2Dump.exe relies on the msdia*version*.dll COM server to provide its services. Starting in Visual Studio 2015, the version is msdia140.dll. If the msdia*version*.dll COM server isn't initialized, you must register it before dia2dump.exe can work. The DIA SDK directory has a bin subdirectory that contains the x86 version of the DLL. A version for x64 architecture machines is in bin\amd64, and a version for ARM is in bin\arm. To register the dll, open an elevated Developer command prompt window, and change to the directory that contains the version for your machine architecture. Enter the command `regsvr32 msdia140.dll` to register the COM server.

### To run the sample

1. Open a command prompt and change to the directory that contains the dia2dump.exe that you built.

1. Enter the command `dia2dump filename` where *filename* is the name of a PDB file to examine. If the PDB file is in another directory, use the full path to the file as *filename*. This command lists all the data in the PDB file.

1. Dia2Dump has other options to display only selected information. Use the `dia2dump -?` command to list all of the available options.

## See also

- [Port, Migrate, and Upgrade Visual Studio Projects](/visualstudio/releases/2019/port-migrate-and-upgrade-visual-studio-projects)
