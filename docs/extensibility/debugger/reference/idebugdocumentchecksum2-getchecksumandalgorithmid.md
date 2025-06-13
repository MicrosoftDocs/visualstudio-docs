---
description: "Retrieves the document checksum and algorithm identifier given the maximum number of bytes to use."
title: IDebugDocumentChecksum2::GetChecksumAndAlgorithmId
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugDocumentChecksum2::GetChecksumAndAlgorithmI
- GetChecksumAndAlgorithmI
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDocumentChecksum2::GetChecksumAndAlgorithmId

Retrieves the document checksum and algorithm identifier given the maximum number of bytes to use.

## Syntax

### [C#](#tab/csharp)
```csharp
public int GetChecksumAndAlgorithmId(
    out Guid pRetVal,
    uint     cMaxBytes,
    out byte pChecksum,
    out uint pcNumBytes
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetChecksumAndAlgorithmId(
    GUID  *pRetVal,
    ULONG cMaxBytes,
    BYTE  *pChecksum,
    ULONG *pcNumBytes
);
```
---

## Parameters
`pRetVal`\
[out] Unique identifier for the checksum algorithm.

`cMaxBytes`\
[in] Maximum number of bytes to be used for the checksum.

`pChecksum`\
[out] Value of the checksum.

`pcNumBytes`\
[out] Actual number of bytes used for the checksum.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Example
The following example uses this method to get the checksum and algorithm for a document.

```cpp
HRESULT CDebugCodeContext::GetDocumentChecksumAndAlgorithmId(GUID *pguidAlgorithm, BYTE **ppChecksum, ULONG *pcNumBytes)
{
    HRESULT hRes = E_FAIL;

    *ppChecksum = NULL;
    *pcNumBytes = 0;

    CComPtr<IDebugDocumentContext2> pDocContext;

    hRes = this->GetDocumentContext(&pDocContext);

    if ( HREVAL(S_OK, hRes) )
    {
        CComQIPtr<IDebugDocumentChecksum2> pDocChecksum(pDocContext);

        if ( pDocChecksum != NULL )
        {
            // Figure out the size of the checksum buffer required
            ULONG cNumBytes = 0;

            hRes = pDocChecksum->GetChecksumAndAlgorithmId(pguidAlgorithm, 0, NULL, &cNumBytes);

            if ( S_OK == hRes )
            {
                // check to see if we got back valid values
                if ( cNumBytes && GUID_NULL != (*pguidAlgorithm) )
                {
                    // Alloc space for the checksum data
                    BYTE *pChecksum = (BYTE*) CoTaskMemAlloc(cNumBytes);

                    if ( pChecksum )
                    {
                        // Get the buffer containing the checksum info
                        hRes = pDocChecksum->GetChecksumAndAlgorithmId(pguidAlgorithm, cNumBytes, pChecksum, &cNumBytes);

                        if ( HREVAL(S_OK, hRes) )
                        {
                            *ppChecksum = pChecksum;
                            *pcNumBytes = cNumBytes;
                        }
                        else
                        {
                            CoTaskMemFree(pChecksum);
                        }
                    }
                    else
                        hRes = E_OUTOFMEMORY;
                }
                else
                    hRes = S_FALSE; // lang doesn't support checksums
            }
            else
                hRes = S_FALSE; // failed to work out checksum info
        }
        else
            hRes = S_FALSE; // SH doesn't support checksums
    }

    return ( hRes );
}
```

## See also
- [IDebugDocumentChecksum2](../../../extensibility/debugger/reference/idebugdocumentchecksum2.md)
