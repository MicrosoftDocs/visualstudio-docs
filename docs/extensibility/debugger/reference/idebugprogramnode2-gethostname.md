---
description: "Gets the name of the process hosting the program."
title: IDebugProgramNode2::GetHostName
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramNode2::GetHostName
helpviewer_keywords:
- IDebugProgramNode2::GetHostName
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgramNode2::GetHostName

Gets the name of the process hosting the program.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetHostName (
    enum_GETHOSTNAME_TYPE dwHostNameType,
    out string            pbstrHostName
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetHostName (
    GETHOSTNAME_TYPE dwHostNameType,
    BSTR*            pbstrHostName
);
```
---

## Parameters
`dwHostNameType`\
[in] A value from the [GETHOSTNAME_TYPE](../../../extensibility/debugger/reference/gethostname-type.md) enumeration that specifies the type of name to return.

`pbstrHostName`\
[out] Returns the name of the hosting process.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Example
The following example shows how to implement this method for a simple `CProgram` object that exposes the [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md) interface. This example ignores the `dwHostNameType` parameter and returns only the name of the program as taken from the base name of the module's file path.

```cpp
HRESULT CProgram::GetHostName(DWORD dwHostNameType, BSTR* pbstrHostName) {
    // Check for valid argument.
    if (pbstrHostName)
    {
        char szModule[_MAX_PATH];

        // Attempt to assign to szModule the path for the file used
        // to create the calling process.
        if (GetModuleFileName(NULL, szModule, sizeof (szModule)))
        {
            // If successful then declare several char arrays
            char  szDrive[_MAX_DRIVE];
            char  szDir[_MAX_DIR];
            char  szName[_MAX_FNAME];
            char  szExt[_MAX_EXT];
            char  szFilename[_MAX_FNAME + _MAX_EXT];
            WCHAR wszFilename[_MAX_FNAME + _MAX_EXT];

            // Break the szModule path name into components.
            _splitpath(szModule, szDrive, szDir, szName, szExt);

            // Copy the base file name szName into szFilename.
            lstrcpy(szFilename, szName);
            // Append the field extension szExt into szFilename.
            lstrcat(szFilename, szExt);

            // Convert the szFilename sequence of multibyte characters
            // to the wszFilename sequence of wide characters.
            mbstowcs(wszFilename, szFilename, sizeof (wszFilename) / 2);

            // Assign the wszFilename to the value at *pbstrHostName.
            *pbstrHostName = SysAllocString(wszFilename);

            return S_OK;
        }
    }

    return E_INVALIDARG;
}
```

## See also
- [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)
- [GETHOSTNAME_TYPE](../../../extensibility/debugger/reference/gethostname-type.md)
- [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)
