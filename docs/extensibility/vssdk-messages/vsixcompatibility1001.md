---
title: Visual Studio SDK analyzer error VsixCompatibility1001
description: Visual Studio SDK analyzer error VsixCompatibility1001. Learn how to recognize and address this error.
ms.date: 05/19/2022
ms.topic: error-reference
f1_keywords:
  - "VsixCompatibility1001"
helpviewer_keywords:
  - "VsixCompatibility1001"
  - VSIX error codes, compatibility analyzer
author: ankitvarmait
ms.author: anva
manager: tinali
ms.subservice: extensibility-integration
monikerRange: "vs-2022"
---

# Visual Studio SDK analyzer error VsixCompatibility1001

The extension is incompatible with the targeted version of Visual Studio because of referencing the incompatible VSSDK version.

The following conditions generate VsixCompatibility1001:

- You're updating or creating a Visual Studio extension for Visual Studio 2022.
- You're using the latest version of [Microsoft.VSSDK.BuildTools](https://www.nuget.org/packages/Microsoft.VSSDK.BuildTools/) (17.x versions) package.
- You're using the previous version of [Microsoft.VisualStudio.Sdk](https://www.nuget.org/packages/Microsoft.VisualStudio.Sdk/) (16.x versions) metapackage.

Solution:

- Update the [Microsoft.VisualStudio.Sdk](https://www.nuget.org/packages/Microsoft.VisualStudio.Sdk/) metapackage to the latest version (17.x versions).
