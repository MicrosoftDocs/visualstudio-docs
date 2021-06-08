---
title: Accommodating breaking API changes in the VS SDK API
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
# Accommodating breaking API changes

This document assumes you have already [created a VSIX project that references the Dev17 SDK](add-dev17-target.md).

If you do not have build breaks in your Dev17-targeted VSIX project,
congratulations: you're ready for [testing](testing.md)!
The remainder of this document discusses how to correct the build breaks
you might encounter while migrating your Dev16 code to Dev17.

There are [breaking API changes](breaking-api-list.md) in Dev17 that may require changes to your code
from when it ran on prior versions.
Please review that document for tips on how to update your code for each of them.

When adapting your code, we recommend you use [conditional compilation](conditional-compilation.md)
so that your code can continue to support pre-Dev17 while adding support for Dev17.

When you get your Dev17-targeted extension building, proceed to [testing](testing.md).
