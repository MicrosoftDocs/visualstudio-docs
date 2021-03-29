---
title: Restrictions on String Lengths | Microsoft Docs
description: Learn about limits on the lengths of strings used by various functions imposed by the Source Control Plug-in API.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- source control plug-ins, restrictions on string lengths
ms.assetid: 877173d2-ca27-43b3-b1f4-8379f7c5e268
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
---
# Restrictions on string lengths
The Source Control Plug-in API limits the lengths of strings used in various functions.

## String length values

|Constant|Value|
|--------------|-----------|
|`SCC_NAME_LEN`|31|
|`SCC_AUXLABEL_LEN`|31|
|`SCC_USER_LEN`|31|
|`SCC_PRJPATH_LEN`|300|

> [!NOTE]
> Length does not include the terminating `null`. Other constants with a "_SIZE" suffix instead of "_LEN" do include space for the terminating `null`.

|Constant|Value|
|--------------|-----------|
|SCC_NAME_SIZE|32|
|SCC_AUXLABEL_SIZE|32|
|SCC_USER_SIZE|32|
|SCC_PRJPATH_SIZE|301|

## See also
- [Source control plug-ins](../extensibility/source-control-plug-ins.md)
