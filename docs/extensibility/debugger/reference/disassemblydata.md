---
description: "Describes one disassembly instruction for the integrated development environment (IDE) to display."
title: DisassemblyData
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- DisassemblyData
helpviewer_keywords:
- DisassemblyData structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
ms.custom: sfi-ropc-nochange
- CPP
- CSharp
---
# DisassemblyData

Describes one disassembly instruction for the integrated development environment (IDE) to display.

## Syntax

### [C#](#tab/csharp)
```csharp
public struct DisassemblyData { 
    public uint          dwFields;
    public string        bstrAddress;
    public string        bstrAddressOffset;
    public string        bstrCodeBytes;
    public string        bstrOpcode;
    public string        bstrOperands;
    public string        bstrSymbol;
    public ulong         uCodeLocationId;
    public TEXT_POSITION posBeg;
    public TEXT_POSITION posEnd;
    public string        bstrDocumentUrl;
    public uint          dwByteOffset;
    public uint          dwFlags;
};
```
### [C++](#tab/cpp)
```cpp
typedef struct tagDisassemblyData {
    DISASSEMBLY_STREAM_FIELDS dwFields;
    BSTR                      bstrAddress;
    BSTR                      bstrAddressOffset;
    BSTR                      bstrCodeBytes;
    BSTR                      bstrOpcode;
    BSTR                      bstrOperands;
    BSTR                      bstrSymbol;
    UINT64                    uCodeLocationId;
    TEXT_POSITION             posBeg;
    TEXT_POSITION             posEnd;
    BSTR                      bstrDocumentUrl;
    DWORD                     dwByteOffset;
    DISASSEMBLY_FLAGS         dwFlags;
} DisassemblyData;
```
---

## Members
`dwFields`\
The [DISASSEMBLY_STREAM_FIELDS](../../../extensibility/debugger/reference/disassembly-stream-fields.md) constant that specifies which fields are filled out.

`bstrAddress`\
The address as an offset from some starting point (usually the beginning of the associated function).

`bstrCodeBytes`\
The code bytes for this instruction.

`bstrOpcode`\
The opcode for this instruction.

`bstrOperands`\
The operands for this instruction.

`bstrSymbol`\
The symbol name, if any, associated with the address (public symbol, label, and so on).

`uCodeLocationId`\
The code location identifier for this disassembled line. If the code context address of one line is greater than the code context address of another, then the disassembled code location identifier of the first will also be greater than the code location identifier of the second.

`posBeg`\
The [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md) that corresponds to the position in a document where the disassembly data begins.

`posEnd`\
The [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md) that corresponds to the position in a document where the disassembly data ends.

`bstrDocumentUrl`\
For text documents that can be represented as file names, the `bstrDocumentUrl` field is filled in with the file name where the source can be found, using the format `file://file name`.

For text documents that cannot be represented as file names, `bstrDocumentUrl` is a unique identifier for the document, and the debug engine must implement the [GetDocument](../../../extensibility/debugger/reference/idebugdisassemblystream2-getdocument.md) method.

This field can also contain additional information about checksums. See Remarks for details.

`dwByteOffset`\
The number of bytes the instruction is from the beginning of the code line.

`dwFlags`\
The [DISASSEMBLY_FLAGS](../../../extensibility/debugger/reference/disassembly-flags.md) constant that specifies which flags are active.

## Remarks
Each `DisassemblyData` structure describes one instruction of disassembly. An array of these structures is returned from the [Read](../../../extensibility/debugger/reference/idebugdisassemblystream2-read.md) method.

The [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md) structure is used for text-based documents only. The source code range for this instruction is filled out only for the first instruction generated from a statement or line, for example, when `dwByteOffset == 0`.

For documents that are non-textual, a document context can be obtained from the code, and the `bstrDocumentUrl` field should be a null value. If the `bstrDocumentUrl` field is the same as the `bstrDocumentUrl` field in the previous `DisassemblyData` array element, then set the `bstrDocumentUrl` to a null value.

If the `dwFlags` field has the `DF_DOCUMENT_CHECKSUM` flag set, then additional checksum information follows the string pointed to by the `bstrDocumentUrl` field. Specifically, after the null string terminator, there follows a GUID identifying the checksum algorithm that is in turn followed by a 4 byte value indicating the number of bytes in the checksum and that in turn is followed by the checksum bytes. See the Example in this topic on how to encode and decode this field in Visual C#.

## Example
The `bstrDocumentUrl` field can contain additional information other than a string if the `DF_DOCUMENT_CHECKSUM` flag is set. The process of creating and reading this encoded string is straightforward in Visual C++. However, in Visual C#, it is another matter. For those who are curious, the following example shows one way to create the encoded string from Visual C# and one way to decode the encoded string in Visual C#.

```csharp
using System;
using System.Runtime.InteropServices;

namespace MyNamespace
{
    class MyClass
    {
        string EncodeData(string documentString,
                          Guid checksumGuid,
                          byte[] checksumData)
        {
            string returnString = documentString;

            if (checksumGuid == null || checksumData == null)
            {
                // Nothing more to do. Just return the string.
                return returnString;
            }

            returnString += '\0'; // separating null value

            // Add checksum GUID to string.
            byte[] guidDataArray  = checksumGuid.ToByteArray();
            int    guidDataLength = guidDataArray.Length;
            IntPtr pBuffer        = Marshal.AllocCoTaskMem(guidDataLength);
            for (int i = 0; i < guidDataLength; i++)
            {
                Marshal.WriteByte(pBuffer, i, guidDataArray[i]);
            }
            // Copy guid data bytes to string as wide characters.
            // Assumption: sizeof(char) == 2.
            for (int i = 0; i < guidDataLength / sizeof(char); i++)
            {
                returnString += (char)Marshal.ReadInt16(pBuffer, i * sizeof(char));
            }

            // Add checksum count (a 32-bit value).
            Int32 checksumCount = checksumData.Length;
            Marshal.StructureToPtr(checksumCount, pBuffer, true);
            for (int i = 0; i < sizeof(Int32) / sizeof(char); i++)
            {
                returnString += (char)Marshal.ReadInt16(pBuffer, i * sizeof(char));
            }

            // Add checksum data.
            pBuffer = Marshal.AllocCoTaskMem(checksumCount);
            for (int i = 0; i < checksumCount; i++)
            {
                Marshal.WriteByte(pBuffer, i, checksumData[i]);
            }
            for (int i = 0; i < checksumCount / sizeof(char); i++)
            {
                returnString += (char)Marshal.ReadInt16(pBuffer, i * sizeof(char));
            }
            Marshal.FreeCoTaskMem(pBuffer);

            return returnString;
        }

        void DecodeData(    string encodedString,
                        out string documentString,
                        out Guid   checksumGuid,
                        out byte[] checksumData)
        {
            documentString = String.Empty;
            checksumGuid = Guid.Empty;
            checksumData = null;

            IntPtr pBuffer = Marshal.StringToBSTR(encodedString);
            if (null != pBuffer)
            {
                int bufferOffset = 0;

                // Parse string out. String is assumed to be Unicode.
                documentString = Marshal.PtrToStringUni(pBuffer);
                bufferOffset += (documentString.Length + 1) * sizeof(char);

                // Parse Guid out.
                // Read guid bytes from buffer and store in temporary
                // buffer that contains only the guid bytes. Then the
                // Marshal.PtrToStructure() can work properly.
                byte[] guidDataArray  = checksumGuid.ToByteArray();
                int    guidDataLength = guidDataArray.Length;
                IntPtr pGuidBuffer    = Marshal.AllocCoTaskMem(guidDataLength);
                for (int i = 0; i < guidDataLength; i++)
                {
                    Marshal.WriteByte(pGuidBuffer, i,
                                      Marshal.ReadByte(pBuffer, bufferOffset + i));
                }
                bufferOffset += guidDataLength;
                checksumGuid = (Guid)Marshal.PtrToStructure(pGuidBuffer, typeof(Guid));
                Marshal.FreeCoTaskMem(pGuidBuffer);

                // Parse out the number of checksum data bytes (always 32-bit value).
                int dataCount = Marshal.ReadInt32(pBuffer, bufferOffset);
                bufferOffset += sizeof(Int32);

                // Parse out the checksum data.
                checksumData = new byte[dataCount];
                for (int i = 0; i < dataCount; i++)
                {
                    checksumData[i] = Marshal.ReadByte(pBuffer, bufferOffset + i);
                }
            }
        }
    }
}
```

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [Read](../../../extensibility/debugger/reference/idebugdisassemblystream2-read.md)
- [DISASSEMBLY_STREAM_FIELDS](../../../extensibility/debugger/reference/disassembly-stream-fields.md)
- [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md)
- [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md)
- [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md)
- [DISASSEMBLY_FLAGS](../../../extensibility/debugger/reference/disassembly-flags.md)
