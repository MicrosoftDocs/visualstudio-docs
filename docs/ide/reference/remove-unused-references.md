---
title: Remove unused references
description: Learn how to clean up project references and NuGet packages that have no usage with the new Remove Unused References command.
ms.custom: SEO-VS-2021
ms.date: 09/14/2021
ms.topic: reference
author: mikadumont
ms.author: midumont
manager: jmartens
ms.technology: vs-ide-general
dev_langs:
  - CSharp
  - VB
ms.workload:
  - "dotnet"
---
# Remove Unused References

This refactoring applies to:

- C#
- Visual Basic

**What:** Lets you remove unused references for [SDK style projects](/dotnet/core/project-sdk/overview).

**When:** You want to clean up project references and NuGet packages that have no usage.

**Why:** Removing project references that have no usage can help save space and reduce startup time of your application, because it takes time to load each module and avoids having the compiler load metadata that will never be used.

## How-to

1. Right click on a project name or dependencies node in Solution Explorer.

2. Select **Remove Unused References**.

    ![Remove Unused References command](media/remove-unused-references-command.png)

3. The **Remove Unused References** dialog will open displaying references that have no usage in source code. Unused references will be pre-selected for removal with an option to preserve references by selecting `Keep` from the Action drop down.

    ![Remove Unused References dialog](media/remove-unused-references-dialog.png)

5. Click `Apply` to remove selected references.

## See also

- [Refactoring](../refactoring-in-visual-studio.md)