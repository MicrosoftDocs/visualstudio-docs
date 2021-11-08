---
title: Common MSBuild item metadata | Microsoft Docs
description: Learn about optional item metadata that have meaning for some MSBuild SDKs or targets, but aren't set by default for every item.
ms.custom: SEO-VS-2020
ms.date: 07/13/2020
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- msbuild, common item metadata
- item metadata (MSBuild)
ms.assetid: 9857505d-ae15-42f1-936d-6cd7fb9dd276
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# Common MSBuild item metadata

The following table describes optional item metadata that have meaning for some MSBuild SDKs or targets, but that are not set by default for every item. You can set these to influence build behavior, but only if the SDK or target files you are using recognize it.

| Item metadata | SDKs | Description |
|---------------| ------- | -------------|
|%(Link)| All |The Visual Studio project system uses `Link` metadata (if present) to alter what shows up in the project tree; you can put a file in a different logical folder structure in **Solution Explorer**.<br />In addition, the `AssignTargetPath` task looks at `Link` to determine where in the output directory to copy a file to, if it’s one of the items that gets copied.|
|%(LinkBase)| .NET Core SDK | Used to set the folder to be used for `Link` metadata for groups of items. |

## See also

- [Common MSBuild project properties](../msbuild/common-msbuild-project-properties.md)
- [Common MSBuild project items](../msbuild/common-msbuild-project-items.md)
- [MSBuild well-known item metadata](msbuild-well-known-item-metadata.md)