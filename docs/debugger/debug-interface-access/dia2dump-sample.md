---
title: "Dia2dump Sample | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "sample applications [DIA SDK]"
  - "Dia2dump sample [DIA SDK]"
ms.assetid: 492c0893-7043-452f-a020-890a47230d20
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload:
  - "multiple"
---
# Dia2dump Sample

The Dia2dump sample shows how to use the Microsoft Debug Interface Access Software Development Kit (DIA SDK) to query a PDB file for information.

The Dia2dump sample is installed with Visual Studio and contains the solution and source files. The compiled executable runs from the command line and can display the contents of an entire program database (.pdb) file, or just the sections you are interested in.

## Install the sample

The sample is installed when you choose the **Desktop development with C++** workload in the Visual Studio Installer. For information on how to install Visual Studio and choose specific workloads and individual components, see [Install Visual Studio](../../install/install-visual-studio.md).

When installed, the sample is in your Visual Studio installation directory, in a subdirectory named \DIA SDK\Samples\DIA2Dump.

## Build the sample

Because the installation directory is a protected directory by default, you must use an elevated command prompt or instance of Visual Studio (run as administrator) to build and edit the solution. It may be easier to copy the files from the sample directory to another directory first, and then build the sample.

1.  Open the Dia2dump.sln file in Visual Studio. (If necessary, Visual Studio will first help you upgrade the Dia2dump project.)

2.  In the project property pages, in the **C/C++** &#124; **General** &#124; **Additional Include Directories** property, specify the `..\DIA SDK\include` directory. This guarantees that the compiler can find the dia2.h file.

3.  On the **Build** menu, click **Rebuild Solution**.

4.  Close Visual Studio.

#### To run the sample

1.  Open a command prompt and type the following:

    ```
    dia2dump filename
    ```

## See also

- [Dia2dump.cpp Source File](../../debugger/debug-interface-access/dia2dump-cpp-source-file.md)
- [Port, Migrate, and Upgrade Visual Studio Projects](../../porting/port-migrate-and-upgrade-visual-studio-projects.md)
