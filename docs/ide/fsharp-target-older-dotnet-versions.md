---
title: Target previous .NET Framework versions for F#
description: Learn about targeting older version of the .NET Framework when using F# in Visual Studio.
ms.date: 07/11/2018
ms.topic: troubleshooting
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- dotnet
monikerRange: vs-2017
---
# Target older versions of .NET (F#)

The following error might appear if you try to target the .NET Framework 2.0, 3.0, or 3.5 in an F# project when Visual Studio is installed on Windows 8.1:

**This project requires the 2.0 F# runtime, but that runtime is not installed.**

This error is known to occur under the following combination of conditions:

- You installed Visual Studio on Windows 8.1.

- You didn’t enable the .NET Framework 3.5 before you installed Visual Studio.

- Your project targets the .NET Framework 2.0, 3.0, or 3.5.

When you install Visual Studio, it detects the installed versions of the .NET Framework. Visual Studio installs the F# 2.0 runtime only if the .NET Framework 3.5 is installed and enabled.

## Resolve the error

To resolve this error, you can either:

- Target a newer version of the .NET Framework.

- Enable the .NET Framework 3.5 on Windows 8.1 and then install the F# 2.0 runtime by repairing the Visual Studio installation. The steps to do this follow.

### To enable the .NET Framework 3.5 on Windows 8.1

1. On the **Start** screen, type **Control Panel**.

   As you type, the **Control Panel** icon appears under the **Apps** heading.

2. Choose the **Control Panel** icon, choose the **Programs** icon, and then choose the **Turn Windows features on or off** link.

3. Make sure that the **.NET Framework 3.5 (includes .NET 2.0 and 3.0)** check box is selected, and then choose the **OK** button. You don’t need to select the check boxes for any child nodes for optional components of the .NET Framework.

   The .NET Framework 3.5 is enabled if it wasn't already.

### To install the F# 2.0 runtime

Follow the [steps to repair Visual Studio](../install/repair-visual-studio.md).

## See also

- [F# guide (.NET Framework)](/dotnet/fsharp/)
- [F# in Visual Studio](fsharp-visual-studio.md)
