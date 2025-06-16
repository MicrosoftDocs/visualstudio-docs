---
description: "Retrieves the text from the specified position in the document."
title: IDebugDocumentText2::GetText
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocumentText2::GetText
helpviewer_keywords:
- IDebugDocumentText2::GetText
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDocumentText2::GetText

Retrieves the text from the specified position in the document.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetText(
    eumn_TEXT_POSITION pos,
    uint               cMaxChars,
    IntPtr             pText,
    out uint           pcNumChars
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetText(
    TEXT_POSITION pos,
    ULONG         cMaxChars,
    WCHAR*        pText,
    ULONG*        pcNumChars
);
```
---

## Parameters
`pos`\
[in] A [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md) structure that indicates the location of the text to be retrieved.

`cMaxChars`\
[in] The maximum number of characters of the text to be retrieved.

`pText`\
[in, out] A pointer to a buffer that is to be filled in with the desired text. This buffer must be able to contain at least `cMaxChars` number of wide characters.

`pcNumChars`\
[out] Returns the number of characters actually retrieved.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Example
This example shows how this method can be called from C#.

```csharp
using System.Runtime.Interop.Services;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Debugger.Interop;

namespace Mynamespace
{
    class MyClass
    {
        string GetDocumentText(IDebugDocumentText2 pText, TEXT_POSITION pos)
        {
            string documentText = string.Empty;
            if (pText != null)
            {
                uint numLines = 0;
                uint numChars = 0;
                int hr;
                hr = pText.GetSize(ref numLines, ref numChars);
                if (ErrorHandler.Succeeded(hr))
                {
                    IntPtr buffer = Marshal.AllocCoTaskMem((int)numChars * sizeof(char));
                    uint actualChars = 0;
                    hr = pText.GetText(pos, numChars, buffer, out actualChars);
                    if (ErrorHandler.Succeeded(hr))
                    {
                        documentText = Marshal.PtrToStringUni(buffer, (int)actualChars);
                    }
                    Marshal.FreeCoTaskMem(buffer);
                }
            }
            return documentText;
        }
    }
}
```

## See also
- [IDebugDocumentText2](../../../extensibility/debugger/reference/idebugdocumenttext2.md)
- [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md)
