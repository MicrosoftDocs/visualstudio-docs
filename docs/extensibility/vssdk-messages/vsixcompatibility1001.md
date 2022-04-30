---
description: "VS SDK Analyzer Error VsixCompatibility1001"
title: "VS SDK analyzer error  VsixCompatibility1001"
ms.date: 07/20/2015
ms.topic: error-reference
f1_keywords:
  - "VsixCompatibility1001"
helpviewer_keywords:
  - "VsixCompatibility1001"
  - VSIX error codes, compatibility analyzer
author: ankitvarmait
ms.author: anva
manager: tinali
ms.technology: vs-ide-sdk
---
# VS SDK analyzer error VsixCompatibility1001

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-not-mac.md)]

The extension is incompatible with the targeted version of Visual Studio because of referencing the incompatible VS SDK version. 

The following conditions generate VsixCompatibility1001:

- You are updating or creating a Visual Studio extension for Visual Studio 2022.
- You are using the latest version of [Microsoft.VSSDK.BuildTools](https://www.nuget.org/packages/Microsoft.VSSDK.BuildTools/) (17.x versions) package.
- You are using the previous version of [Microsoft.VisualStudio.Sdk](https://www.nuget.org/packages/Microsoft.VisualStudio.Sdk/) (16.x versions) metapackage.

**Solution**
- Update the [Microsoft.VisualStudio.Sdk](https://www.nuget.org/packages/Microsoft.VisualStudio.Sdk/) metapackage to the latest version (17.x versions).