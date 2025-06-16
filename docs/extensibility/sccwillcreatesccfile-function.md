---
description: "This function determines whether the source control plug-in supports the creation of the MSSCCPRJ.SCC file for each of the given files."
title: SccWillCreateSccFile Function
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccWillCreateSccFile
helpviewer_keywords:
- SccWillCreateSccFile function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccWillCreateSccFile Function

This function determines whether the source control plug-in supports the creation of the MSSCCPRJ.SCC file for each of the given files.

## Syntax

```cpp
SCCRTN SccWillCreateSccFile(
   LPVOID  pContext,
   LONG    nFiles,
   LPCSTR* lpFileNames,
   LPBOOL  pbSccFiles
);
```

#### Parameters
 pContext

[in] The source control plug-in context pointer.

 nFiles

[in] The number of file names included in the `lpFileNames` array as well as the length of the `pbSccFiles` array.

 lpFileNames

[in] An array of fully qualified file names to check (array must be allocated by caller).

 pbSccFiles

[in, out] Array in which to store the results.

## Return Value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|Success.|
|SCC_E_INVALIDFILEPATH|One of the paths in the array is invalid.|
|SCC_E_NONSPECIFICERROR|Nonspecific failure.|

## Remarks
 This function is called with a list of files to determine if the source control plug-in provides support in the MSSCCPRJ.SCC file for each of the given files (for more information on the MSSCCPRJ.SCC file, see [MSSCCPRJ.SCC File](../extensibility/mssccprj-scc-file.md)). Source control plug-ins can declare whether they have the capability of creating MSSCCPRJ.SCC files by declaring `SCC_CAP_SCCFILE` during initialization. The plug-in returns `TRUE` or `FALSE` per file in the `pbSccFiles` array to indicate which of the given files have MSSCCPRJ.SCC support. If the plug-in returns a success code from the function, the values in the return array are honored. On failure, the array is ignored.

## See also
- [Source Control Plug-in API Functions](../extensibility/source-control-plug-in-api-functions.md)
- [MSSCCPRJ.SCC File](../extensibility/mssccprj-scc-file.md)
