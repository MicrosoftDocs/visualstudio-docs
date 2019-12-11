---
title: "CV_CFL_LANG | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "CV_CFL_LANG enumeration"
ms.assetid: 4e8e0613-ad02-4de9-9f46-e4753c5b0251
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# CV_CFL_LANG
Specifies the source code language of the application or linked module.

## Syntax

```C++
typedef enum CV_CFL_LANG {
    CV_CFL_C       = 0x00,
    CV_CFL_CXX     = 0x01,
    CV_CFL_FORTRAN = 0x02,
    CV_CFL_MASM    = 0x03,
    CV_CFL_PASCAL  = 0x04,
    CV_CFL_BASIC   = 0x05,
    CV_CFL_COBOL   = 0x06,
    CV_CFL_LINK    = 0x07,
    CV_CFL_CVTRES  = 0x08,
    CV_CFL_CVTPGD  = 0x09,
    CV_CFL_CSHARP  = 0x0A,
    CV_CFL_VB      = 0x0B,
    CV_CFL_ILASM   = 0x0C,
    CV_CFL_JAVA    = 0x0D,
    CV_CFL_JSCRIPT = 0x0E,
    CV_CFL_MSIL    = 0x0F,
    CV_CFL_HLSL    = 0x10
} CV_CFL_LANG;
```

## Elements
CV_CFL_C
Application language is C.

CV_CFL_CXX
Application language is C++.

CV_CFL_FORTRAN
Application language is FORTRAN.

CV_CFL_MASM
Application language is Microsoft Macro Assembler.

CV_CFL_PASCAL
Application language is Pascal.

CV_CFL_BASIC
Application language is BASIC.

CV_CFL_COBOL
Application language is COBOL.

CV_CFL_LINK
Application is a linker-generated module.

CV_CFL_CVTRES
Application is a resource module converted with CVTRES tool.

CV_CFL_CVTPGD
Application is a POGO optimized module generated with CVTPGD tool.

CV_CFL_CSHARP
Application language is C#.

CV_CFL_VB
Application language is Visual Basic.

CV_CFL_ILASM
Application language is intermediate language assembly (that is, Common Language Runtime (CLR) assembly).

CV_CFL_JAVA
Application language is Java.

CV_CFL_JSCRIPT
Application language is Jscript.

CV_CFL_MSIL
Application language is an unknown Microsoft Intermediate Language (MSIL), possibly a result of using the [/LTCG (Link-time Code Generation)](/cpp/build/reference/ltcg-link-time-code-generation) switch.

CV_CFL_HLSL
Application language is High Level Shader Language.

## Remarks
The values in this enumeration are returned by a call to the [IDiaSymbol::get_language](../../debugger/debug-interface-access/idiasymbol-get-language.md) method.

## Requirements
Header: cvconst.h

## See also
- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [IDiaSymbol::get_language](../../debugger/debug-interface-access/idiasymbol-get-language.md)
