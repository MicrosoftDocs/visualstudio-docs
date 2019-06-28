---
title: Create minidumps with all callstacks
ms.date: 06/27/2019
ms.topic: conceptual
helpviewer_keywords:
  - minidumps for Visual Studio issues"
author: mikeblome
ms.author: mblome
manager: jillfra
dev_langs:
 - CSharp
 - VB
 - CPP
ms.workload:
  - "multiple"
---

# Create minidumps for a Visual Studio process with all callstacks

1. Start a new instance of Visual Studio.
1. From the main menu, choose **Debug** > **Attach To Process**.
1. Check the relevant **Managed** and **Native** checkboxes and press **Attach**.

   ![Attach to process](../ide/media/attach-to-process.png)

1. Select the other Visual Studio instance to attach to from the list of running processes.
1. From the main menu, choose **Debug** > **Break All**.
1. From the main menu, choose **Debug** > **Save Dump As**.

## Get the call stacks from a minidump

1. Open the dump file in Visual Studio.

1. Got to **Tools** > **Options** > **Debugging** > **Symbols** and make sure that **Microsoft Symbol Servers** is checked in the **Symbol file (.pdb) locations**.
1. Open the **Command** window (**View** > **Other Windows** >** Command Window**) 
1. Type ‘~*k’. The window displays all threads' call stacks.
1. Copy all text from Command Window and save to a text file.
1. Attach the txt file to the bug.
