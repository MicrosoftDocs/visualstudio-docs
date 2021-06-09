---
title: Test your extension with Visual Studio 2022 Preview
description: Learn how to test your Visual Studio extension with Visual Studio 2022 Preview, the final step in updating your extension.
ms.date: 06/08/2021
ms.topic: conceptual
author: leslierichardson95
ms.author: lerich
manager: jmartens
monikerRange: "vs-2022"
ms.workload:
- vssdk
---
# Test your extension with Visual Studio 2022 Preview

[!INCLUDE(preview-note)](./includes/preview-note.md)

This document assumes you already have a building Visual Studio 2022-targeted extension.

To test an extension that targets Visual Studio 2022 you will need to have Visual Studio 2022 Preview installed.
You will not be able to run 64-bit extensions on versions of Visual Studio prior to Visual Studio 2022 Preview.

You can use Visual Studio 2022 Preview to build and test your extensions whether they target Visual Studio 2022 or an earlier version. When launching a VSIX project from Visual Studio 2022 an experimental instance of VS will be launched.

We strongly recommend you test with each version of Visual Studio that you intend the extension to support.

Now you're ready to [publish your extension](publishing.md).
