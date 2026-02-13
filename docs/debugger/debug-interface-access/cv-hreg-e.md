---
title: CV_HREG_e
description: Get reference information about the CV_HREG_e enumeration type, which specifies a target register in the debug interface access SDK.
ms.date: "02/12/2026"
ms.topic: "reference"
ms.custom: awp-ai
ai-usage: ai-assisted
dev_langs:
  - "C++"
helpviewer_keywords:
  - "CV_HREG_e enumeration"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# `CV_HREG_e`

Specifies a target register.

> [!NOTE]
> Because the `CV_HREG_e` enumeration is too large to duplicate in its entirety here, an abbreviated version is provided as a reference. Missing entries are notated in italics. The complete enumeration is available in the cvconst.h header file.

## Syntax

```c++
enum CV_HREG_e {
    // Register subset shared by all processor types
    CV_ALLREG_ERR    = 30000,
    CV_ALLREG_TEB    = 30001,
    CV_ALLREG_TIMER  = 30002,
    CV_ALLREG_EFAD1  = 30003,
    CV_ALLREG_EFAD2  = 30004,
    CV_ALLREG_EFAD3  = 30005,
    CV_ALLREG_VFRAME = 30006,
    CV_ALLREG_HANDLE = 30007,
    CV_ALLREG_PARAMS = 30008,
    CV_ALLREG_LOCALS = 30009,
    CV_ALLREG_TID    = 30010,
    CV_ALLREG_ENV    = 30011,
    CV_ALLREG_CMDLN  = 30012,

    //** Register set for Intel 80x86 and ix86 processor series **//
    CV_REG_NONE   = 0,
    CV_REG_AL     = 1,
    CV_REG_CL     = 2,
    CV_REG_DL     = 3,
    CV_REG_BL     = 4,
    CV_REG_AH     = 5,
    CV_REG_CH     = 6,
    CV_REG_DH     = 7,
    CV_REG_BH     = 8,
    CV_REG_AX     = 9,
    CV_REG_CX     = 10,
    CV_REG_DX     = 11,
    CV_REG_BX     = 12,
    CV_REG_SP     = 13,
    CV_REG_BP     = 14,
    CV_REG_SI     = 15,
    CV_REG_DI     = 16,
    CV_REG_EAX    = 17,
    CV_REG_ECX    = 18,
    CV_REG_EDX    = 19,
    CV_REG_EBX    = 20,
    CV_REG_ESP    = 21,
    CV_REG_EBP    = 22,
    CV_REG_ESI    = 23,
    CV_REG_EDI    = 24,
    CV_REG_ES     = 25,
    CV_REG_CS     = 26,
    CV_REG_SS     = 27,
    CV_REG_DS     = 28,
    CV_REG_FS     = 29,
    CV_REG_GS     = 30,
    CV_REG_IP     = 31,
    CV_REG_FLAGS  = 32,
    CV_REG_EIP    = 33,
    CV_REG_EFLAGS = 34,
    CV_REG_TEMP   = 40,     // PCODE Temp
    CV_REG_TEMPH  = 41,     // PCODE TempH
    CV_REG_QUOTE  = 42,     // PCODE Quote
    CV_REG_PCDR3  = 43,     // PCODE reserved
    // CV_REG_PCDR4 through CV_REG_PCDR7 defined
    CV_REG_CR0    = 80,     // CR0 -- control registers
    // CV_REG_CR1 through CV_REG_CR4 defined
    CV_REG_DR0    = 90,     // Debug register
    // CV_REG_DR1 through CV_REG_DR7 defined

    CV_REG_GDTR   = 110,
    CV_REG_GDTL   = 111,
    CV_REG_IDTR   = 112,
    CV_REG_IDTL   = 113,
    CV_REG_LDTR   = 114,
    CV_REG_TR     = 115,

    CV_REG_PSEUDO1 = 116,
    // CV_REG_PSEUDO2 through CV_REG_PSEUDO9 defined

    CV_REG_ST0   = 128,
    // CV_REG_ST1 through CV_REG_ST7 defined
    CV_REG_CTRL  = 136,
    CV_REG_STAT  = 137,
    CV_REG_TAG   = 138,
    CV_REG_FPIP  = 139,
    CV_REG_FPCS  = 140,
    CV_REG_FPDO  = 141,
    CV_REG_FPDS  = 142,
    CV_REG_ISEM  = 143,
    CV_REG_FPEIP = 144,
    CV_REG_FPEDO = 145,
    CV_REG_MM0   = 146,
    // CV_REG_MM1 through CV_REG_MM7 defined

    CV_REG_XMM0  = 154,  // KATMAI registers
    // CV_REG_XMM1 through CV_REG_XMM7 defined
    CV_REG_XMM00 = 162, // KATMAI sub-registers
    // CV_REG_XMM01, 02, and 03 defined
    // CV_REG_XMM10, 11, 12, and 13 defined
    // CV_REG_XMM20, 21, 22, and 23 defined
    // CV_REG_XMM30, 31, 32, and 33 defined
    // CV_REG_XMM40, 41, 42, and 43 defined
    // CV_REG_XMM50, 51, 52, and 53 defined
    // CV_REG_XMM60, 61, 62, and 63 defined
    // CV_REG_XMM70, 71, 72, and 73 defined

    CV_REG_XMM0L  = 194,
    // CV_REG_XMM1L through CV_REG_XMM7L defined
    CV_REG_XMM0H  = 202,
    // CV_REG_XMM1H through CV_REG_XMM7H defined
    CV_REG_MXCSR  = 211, // XMM status register
    CV_REG_EDXEAX = 212, // EDX:EAX pair

    CV_REG_EMM0L  = 220, // XMM sub-registers (WNI integer)
    // CV_REG_EMM1L through CV_REG_EMM7L defined
    CV_REG_EMM0H  = 228,
    // CV_REG_EMM1H through CV_REG_EMM7H defined

    CV_REG_MM00 = 236,
    CV_REG_MM01 = 237,
    CV_REG_MM10 = 238,
    CV_REG_MM11 = 239,
    CV_REG_MM20 = 240,
    CV_REG_MM21 = 241,
    CV_REG_MM30 = 242,
    CV_REG_MM31 = 243,
    CV_REG_MM40 = 244,
    CV_REG_MM41 = 245,
    CV_REG_MM50 = 246,
    CV_REG_MM51 = 247,
    CV_REG_MM60 = 248,
    CV_REG_MM61 = 249,
    CV_REG_MM70 = 250,
    CV_REG_MM71 = 251,

    //** Register set for AMD64 **//
    CV_AMD64_AL      = 1,
    CV_AMD64_CL      = 2,
    CV_AMD64_DL      = 3,
    CV_AMD64_BL      = 4,
    CV_AMD64_AH      = 5,
    CV_AMD64_CH      = 6,
    CV_AMD64_DH      = 7,
    CV_AMD64_BH      = 8,
    CV_AMD64_AX      = 9,
    CV_AMD64_CX      = 10,
    CV_AMD64_DX      = 11,
    CV_AMD64_BX      = 12,
    CV_AMD64_SP      = 13,
    CV_AMD64_BP      = 14,
    CV_AMD64_SI      = 15,
    CV_AMD64_DI      = 16,
    CV_AMD64_EAX     = 17,
    CV_AMD64_ECX     = 18,
    CV_AMD64_EDX     = 19,
    CV_AMD64_EBX     = 20,
    CV_AMD64_ESP     = 21,
    CV_AMD64_EBP     = 22,
    CV_AMD64_ESI     = 23,
    CV_AMD64_EDI     = 24,
    CV_AMD64_ES      = 25,
    CV_AMD64_CS      = 26,
    CV_AMD64_SS      = 27,
    CV_AMD64_DS      = 28,
    CV_AMD64_FS      = 29,
    CV_AMD64_GS      = 30,
    CV_AMD64_FLAGS   = 32,
    CV_AMD64_RIP     = 33,
    CV_AMD64_EFLAGS  = 34,

    // Control registers
    CV_AMD64_CR0     = 80,
    // CV_AMD64_CR1 through CV_AMD64_CR4 defined
    CV_AMD64_CR8     = 88,

    // Debug registers
    CV_AMD64_DR0     = 90,
    // CV_AMD64_DR1 through CV_AMD64_DR15 defined

    CV_AMD64_GDTR    = 110,
    CV_AMD64_GDTL    = 111,
    CV_AMD64_IDTR    = 112,
    CV_AMD64_IDTL    = 113,
    CV_AMD64_LDTR    = 114,
    CV_AMD64_TR      = 115,

    CV_AMD64_ST0     = 128,
    // CV_AMD64_ST1 through CV_AMD64_ST7 defined
    CV_AMD64_CTRL    = 136,
    CV_AMD64_STAT    = 137,
    CV_AMD64_TAG     = 138,
    CV_AMD64_FPIP    = 139,
    CV_AMD64_FPCS    = 140,
    CV_AMD64_FPDO    = 141,
    CV_AMD64_FPDS    = 142,
    CV_AMD64_ISEM    = 143,
    CV_AMD64_FPEIP   = 144,
    CV_AMD64_FPEDO   = 145,

    CV_AMD64_MM0     = 146,
    // CV_AMD64_MM1 through CV_AMD64_MM7 defined

    CV_AMD64_XMM0    = 154,  // SSE registers
    // CV_AMD64_XMM1 through CV_AMD64_XMM7 defined

    CV_AMD64_XMM0_0  = 162,  // SSE sub-registers
    // CV_AMD64_XMM0_1, 0_2, 0_3 through CV_AMD64_XMM7_0, 7_1, 7_2, 7_3 defined

    CV_AMD64_XMM0L   = 194,
    // CV_AMD64_XMM1L through CV_AMD64_XMM7L defined
    CV_AMD64_XMM0H   = 202,
    // CV_AMD64_XMM1H through CV_AMD64_XMM7H defined

    CV_AMD64_MXCSR   = 211,  // XMM status register

    CV_AMD64_EMM0L   = 220,  // XMM sub-registers (WNI integer)
    // CV_AMD64_EMM1L through CV_AMD64_EMM7L defined
    CV_AMD64_EMM0H   = 228,
    // CV_AMD64_EMM1H through CV_AMD64_EMM7H defined

    CV_AMD64_MM00    = 236,
    // CV_AMD64_MM01, MM10, MM11 through CV_AMD64_MM70, MM71 defined

    // Extended SSE registers
    CV_AMD64_XMM8    = 252,
    // CV_AMD64_XMM9 through CV_AMD64_XMM15 defined

    CV_AMD64_XMM8_0  = 260,  // Extended SSE sub-registers
    // CV_AMD64_XMM8_1, 8_2, 8_3 through CV_AMD64_XMM15_0, 15_1, 15_2, 15_3 defined

    CV_AMD64_XMM8L   = 292,
    // CV_AMD64_XMM9L through CV_AMD64_XMM15L defined
    CV_AMD64_XMM8H   = 300,
    // CV_AMD64_XMM9H through CV_AMD64_XMM15H defined

    CV_AMD64_EMM8L   = 308,  // Extended XMM sub-registers (WNI integer)
    // CV_AMD64_EMM9L through CV_AMD64_EMM15L defined
    CV_AMD64_EMM8H   = 316,
    // CV_AMD64_EMM9H through CV_AMD64_EMM15H defined

    // Low byte forms of some standard registers
    CV_AMD64_SIL     = 324,
    CV_AMD64_DIL     = 325,
    CV_AMD64_BPL     = 326,
    CV_AMD64_SPL     = 327,

    // 64-bit general purpose registers
    CV_AMD64_RAX     = 328,
    CV_AMD64_RBX     = 329,
    CV_AMD64_RCX     = 330,
    CV_AMD64_RDX     = 331,
    CV_AMD64_RSI     = 332,
    CV_AMD64_RDI     = 333,
    CV_AMD64_RBP     = 334,
    CV_AMD64_RSP     = 335,

    // Extended 64-bit integer registers
    CV_AMD64_R8      = 336,
    CV_AMD64_R9      = 337,
    CV_AMD64_R10     = 338,
    CV_AMD64_R11     = 339,
    CV_AMD64_R12     = 340,
    CV_AMD64_R13     = 341,
    CV_AMD64_R14     = 342,
    CV_AMD64_R15     = 343,

    CV_AMD64_R8B     = 344,  // 8-bit forms
    // CV_AMD64_R9B through CV_AMD64_R15B defined
    CV_AMD64_R8W     = 352,  // 16-bit forms
    // CV_AMD64_R9W through CV_AMD64_R15W defined
    CV_AMD64_R8D     = 360,  // 32-bit forms
    // CV_AMD64_R9D through CV_AMD64_R15D defined

    // AVX 256-bit registers
    CV_AMD64_YMM0    = 368,
    // CV_AMD64_YMM1 through CV_AMD64_YMM15 defined

    CV_AMD64_YMM0H   = 384,  // AVX upper 128 bits
    // CV_AMD64_YMM1H through CV_AMD64_YMM15H defined

    // AVX-512 512-bit registers
    CV_AMD64_ZMM0    = 700,
    // CV_AMD64_ZMM1 through CV_AMD64_ZMM31 defined

    CV_AMD64_K0      = 732,  // AVX-512 opmask registers
    // CV_AMD64_K1 through CV_AMD64_K7 defined

    //** ADDITIONAL AMD64 REGISTERS DEFINED IN cvconst.h **//

    //** Register set for ARM64 **//
    CV_ARM64_NOREG   = CV_REG_NONE,

    // General purpose 32-bit integer registers
    CV_ARM64_W0      = 10,
    // CV_ARM64_W1 through CV_ARM64_W28 defined
    CV_ARM64_W29     = 39,
    CV_ARM64_W30     = 40,
    CV_ARM64_WZR     = 41,

    // General purpose 64-bit integer registers
    CV_ARM64_X0      = 50,
    // CV_ARM64_X1 through CV_ARM64_X15 defined
    CV_ARM64_IP0     = 66,   // Intra-procedure-call scratch register 0 (X16)
    CV_ARM64_IP1     = 67,   // Intra-procedure-call scratch register 1 (X17)
    CV_ARM64_X18     = 68,
    // CV_ARM64_X19 through CV_ARM64_X28 defined
    CV_ARM64_FP      = 79,   // Frame pointer (X29)
    CV_ARM64_LR      = 80,   // Link register (X30)
    CV_ARM64_SP      = 81,   // Stack pointer
    CV_ARM64_ZR      = 82,   // Zero register
    CV_ARM64_PC      = 83,   // Program counter

    // Status registers
    CV_ARM64_NZCV    = 90,
    CV_ARM64_CPSR    = 91,

    // 32-bit floating point registers
    CV_ARM64_S0      = 100,
    // CV_ARM64_S1 through CV_ARM64_S31 defined

    // 64-bit floating point registers
    CV_ARM64_D0      = 140,
    // CV_ARM64_D1 through CV_ARM64_D31 defined

    // 128-bit SIMD registers
    CV_ARM64_Q0      = 180,
    // CV_ARM64_Q1 through CV_ARM64_Q31 defined

    // Floating point status registers
    CV_ARM64_FPSR    = 220,
    CV_ARM64_FPCR    = 221,

    // 8-bit floating point registers (sub-registers)
    CV_ARM64_B0      = 230,
    // CV_ARM64_B1 through CV_ARM64_B31 defined

    // 16-bit floating point registers (sub-registers)
    CV_ARM64_H0      = 270,
    // CV_ARM64_H1 through CV_ARM64_H31 defined

    // 128-bit vector registers
    CV_ARM64_V0      = 310,
    // CV_ARM64_V1 through CV_ARM64_V31 defined

    // 128-bit SIMD registers upper 64 bits
    CV_ARM64_Q0H     = 350,
    // CV_ARM64_Q1H through CV_ARM64_Q31H defined

    // Scalable Vector Extension (SVE) registers
    CV_ARM64_Z0      = 382,
    // CV_ARM64_Z1 through CV_ARM64_Z31 defined

    CV_ARM64_P0      = 414,  // SVE predicate registers
    // CV_ARM64_P1 through CV_ARM64_P15 defined

    CV_ARM64_FFR     = 430,  // SVE first-fault status register

    //** ADDITIONAL ARM64 REGISTERS DEFINED IN cvconst.h **//

} CV_HREG_e;
```

## Elements

| Element      | Description                                                      |
| ------------ | ---------------------------------------------------------------- |
| CV_ALLREG_*  | Registers shared by all processor types.                         |
| CV_REG_*     | Registers used by Intel 80x86 and ix86 processors (x86).         |
| CV_AMD64_*   | Registers used by AMD64/x64 processors.                          |
| CV_ARM64_*   | Registers used by ARM64 (AArch64) processors.                    |

## Remarks

Each processor type uses its own unique set of registers.

The values in this enumeration are passed to the following methods:

- [`IDiaStackWalkFrame::get_registerValue`](../../debugger/debug-interface-access/idiastackwalkframe-get-registervalue.md)

- [`IDiaStackWalkFrame::put_registerValue`](../../debugger/debug-interface-access/idiastackwalkframe-put-registervalue.md)

- [`IDiaStackWalkHelper::get_registerValue`](../../debugger/debug-interface-access/idiastackwalkhelper-get-registervalue.md)

- [`IDiaStackWalkHelper::put_registerValue`](../../debugger/debug-interface-access/idiastackwalkhelper-put-registervalue.md)

- [`IDiaStackFrame::get_registerValue`](../../debugger/debug-interface-access/idiastackframe-get-registervalue.md)

## Requirements:

Header: cvconst.h

## See also

- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [`IDiaStackWalkFrame::get_registerValue`](../../debugger/debug-interface-access/idiastackwalkframe-get-registervalue.md)
- [`IDiaStackWalkFrame::put_registerValue`](../../debugger/debug-interface-access/idiastackwalkframe-put-registervalue.md)
- [`IDiaStackWalkHelper::get_registerValue`](../../debugger/debug-interface-access/idiastackwalkhelper-get-registervalue.md)
- [`IDiaStackWalkHelper::put_registerValue`](../../debugger/debug-interface-access/idiastackwalkhelper-put-registervalue.md)
- [`IDiaStackFrame::get_registerValue`](../../debugger/debug-interface-access/idiastackframe-get-registervalue.md)
