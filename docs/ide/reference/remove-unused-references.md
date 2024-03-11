---
title: Remove unused references
description: Learn how to clean up project references and NuGet packages that have no usage with the new Remove Unused References command.
ms.date: 3/6/2024
ms.topic: reference
author: mikadumont
ms.author: midumont
manager: mijacobs
ms.subservice: general-ide
dev_langs:
  - CSharp
  - VB
---
# Remove Unused References

This refactoring applies to:

- C#
- Visual Basic

**What:** For [SDK style projects](../../msbuild/how-to-use-project-sdk.md) only, lets you remove unused references.

**When:** You want to clean up project references and NuGet packages that have no usage.

**Why:** Removing project references that have no usage can help save space and reduce startup time of your application, because it takes time to load each module and avoids having the compiler load metadata that will never be used.

> [!NOTE]
> You can use the [.NET Upgrade Assistant](https://dotnet.microsoft.com/platform/upgrade-assistant) right from Visual Studio to upgrade your app to the latest .NET versions.

## How-to

1. Verify that the option is enabled.

   Select **Tools** > **Options** > **Text Editor** > **C#** > **Advanced**, and enable **Show "Removed Unused References" command in Solution Explorer (experimental)**.

1. Right click on a project name or dependencies node in Solution Explorer.

1. Select **Remove Unused References**.

    ![Remove Unused References command](media/remove-unused-references-command.png)

1. The **Remove Unused References** dialog will open displaying references that have no usage in source code. Unused references will be pre-selected for removal with an option to preserve references by selecting `Keep` from the Action drop down.

    ![Remove Unused References dialog](media/remove-unused-references-dialog.png)

1. Click `Apply` to remove selected references.

## See also

- [Refactoring](../refactoring-in-visual-studio.md)