---
title: Handle breaking API changes in the VS SDK API
description: Learn how to deal with changes that break your build when migrating your Visual Studio extension to work with Visual Studio 2022 Preview.
ms.date: 06/08/2021
ms.topic: conceptual
author: leslierichardson95
ms.author: lerich
manager: jmartens
monikerRange: "vs-2022"
ms.workload:
- vssdk
---
# Handle breaking API changes

[!INCLUDE(preview-note)](./includes/preview-note.md)

This document assumes you have already [created a VSIX project that references the Visual Studio 2022 SDK](add-dev17-target.md).

If you do not have build breaks in your Visual Studio 2022-targeted VSIX project, congratulations: you're ready for [testing](testing.md)!
The remainder of this document discusses how to correct the build breaks you might encounter while migrating your Visual Studio 2019 code to Visual Studio 2022.

There are [breaking API changes](breaking-api-list.md) in Visual Studio 2022 that may require changes to your code from when it ran on prior versions. Please review that document for tips on how to update your code for each of them.

When adapting your code, we recommend you use [conditional compilation](conditional-compilation.md) so that your code can continue to support pre-Visual Studio 2022 while adding support for Visual Studio 2022.

When you get your Visual Studio 2022-targeted extension building, proceed to [testing](testing.md).
