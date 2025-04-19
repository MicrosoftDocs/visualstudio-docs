---
title: CV_HREG_e
description: Get reference information about the CV_HREG_e enumeration type, which specifies a target register in the debug interface access SDK.
ms.date: "07/18/2024"
ms.topic: "reference"
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

    //** Register set for the 68K processors **//
    CV_R68_D0    = 0,
    // CV_R68_D1 through CV_R68_D7 defined
    CV_R68_A0    = 8,
    // CV_R68_A1 through CV_R68_A7 defined
    CV_R68_CCR   = 16,
    CV_R68_SR    = 17,
    CV_R68_USP   = 18,
    CV_R68_MSP   = 19,
    CV_R68_SFC   = 20,
    CV_R68_DFC   = 21,
    CV_R68_CACR  = 22,
    CV_R68_VBR   = 23,
    CV_R68_CAAR  = 24,
    CV_R68_ISP   = 25,
    CV_R68_PC    = 26,
    //reserved 27
    CV_R68_FPCR  = 28,
    CV_R68_FPSR  = 29,
    CV_R68_FPIAR = 30,
    //reserved 31
    CV_R68_FP0   = 32,
    // CV_R68_FP1 through CV_R68_FP7 defined
    //reserved 40
    CV_R68_MMUSR030 = 41,
    CV_R68_MMUSR    = 42,
    CV_R68_URP      = 43,
    CV_R68_DTT0     = 44,
    CV_R68_DTT1     = 45,
    CV_R68_ITT0     = 46,
    CV_R68_ITT1     = 47,
    //reserved 50
    CV_R68_PSR      = 51,
    CV_R68_PCSR     = 52,
    CV_R68_VAL      = 53,
    CV_R68_CRP      = 54,
    CV_R68_SRP      = 55,
    CV_R68_DRP      = 56,
    CV_R68_TC       = 57,
    CV_R68_AC       = 58,
    CV_R68_SCC      = 59,
    CV_R68_CAL      = 60,
    CV_R68_TT0      = 61,
    CV_R68_TT1      = 62,
    //reserved 63
    CV_R68_BAD0     = 64,
    // CV_R68_BAD1 through CV_R68_BAD7 defined
    CV_R68_BAC0     = 72,
    // CV_R68_BAC1 through CV_R68_BAC7 defined

    //** Register set for the MIPS 4000 **//
    CV_M4_NOREG   = CV_REG_NONE,
    CV_M4_IntZERO = 10, // CPU register
    CV_M4_IntAT   = 11,
    CV_M4_IntV0   = 12,
    CV_M4_IntV1   = 13,
    CV_M4_IntA0   = 14,
    // CV_M4_IntA1, A2, and A3 defined
    CV_M4_IntT0   = 18,
    // CV_M4_IntT1 through CV_M4_IntT7 defined
    CV_M4_IntS0   = 26,
    // CV_M4_IntS1 through CV_M4_IntS7 defined
    CV_M4_IntT8   = 34,
    CV_M4_IntT9   = 35,
    CV_M4_IntKT0  = 36,
    CV_M4_IntKT1  = 37,
    CV_M4_IntGP   = 38,
    CV_M4_IntSP   = 39,
    CV_M4_IntS8   = 40,
    CV_M4_IntRA   = 41,
    CV_M4_IntLO   = 42,
    CV_M4_IntHI   = 43,

    CV_M4_Fir     = 50,
    CV_M4_Psr     = 51,

    CV_M4_FltF0   = 60, // Floating point registers
    // CV_M4_FltF1 through CV_M4_FltF31 defined
    CV_M4_FltFsr  = 92,

    //** Register set for the ALPHA AXP **//
    CV_ALPHA_NOREG    = CV_REG_NONE,
    CV_ALPHA_FltF0    = 10, // Floating point registers
    // CV_ALPHA_FltF1 through CV_ALPHA_FltF31 defined

    CV_ALPHA_IntV0    = 42, // Integer registers
    CV_ALPHA_IntT0    = 43,
    // CV_ALPHA_IntT1 through CV_ALPHA_IntT7 defined
    CV_ALPHA_IntS0    = 51,
    // CV_ALPHA_IntS1 through CV_ALPHA_IntS5 defined
    CV_ALPHA_IntFP    = 57,
    CV_ALPHA_IntA0    = 58,
    // CV_ALPHA_IntA1 through CV_ALPHA_IntA5 defined
    CV_ALPHA_IntT8    = 64,
    CV_ALPHA_IntT9    = 65,
    CV_ALPHA_IntT10   = 66,
    CV_ALPHA_IntT11   = 67,
    CV_ALPHA_IntRA    = 68,
    CV_ALPHA_IntT12   = 69,
    CV_ALPHA_IntAT    = 70,
    CV_ALPHA_IntGP    = 71,
    CV_ALPHA_IntSP    = 72,
    CV_ALPHA_IntZERO  = 73,

    CV_ALPHA_Fpcr     = 74, // Control registers
    CV_ALPHA_Fir      = 75,
    CV_ALPHA_Psr      = 76,
    CV_ALPHA_FltFsr   = 77,
    CV_ALPHA_SoftFpcr = 78,

    //** Register set for Motorola/IBM PowerPC **//
    CV_PPC_GPR0  = 1, // PowerPC general registers (User Level)
    // CV_PPC_GPR1 through CV_PPC_GPR31 defined

    CV_PPC_CR    = 33, // PowerPC condition register (User Level)
    CV_PPC_CR0   = 34,
    // CV_PPC_CR1 through CV_PPC_CR7 defined

    CV_PPC_FPR0  = 42, // PowerPC floating point registers (User Level)
    // CV_PPC_FPR1 through CV_PPC_FPR31 defined

    CV_PPC_FPSCR = 74, // PowerPC floating point status and control register (User Level)
    CV_PPC_MSR   = 75, // PowerPC machine state register (Supervisor Level)
    CV_PPC_SR0   = 76, // PowerPC segment registers (Supervisor Level)
    // CV_PPC_SR1 through CV_PPC_SR15 defined

    //** ADDITIONAL PowerPC REGISTERS DEFINED IN cvconst.h **//

    //** Register set for the Hitachi SH3 **//
    CV_SH3_NOREG = CV_REG_NONE,
    CV_SH3_IntR0 = 10, // CPU register
    // CV_SH3_IntR1 through CV_SH3_IntR13 defined
    CV_SH3_IntFp = 24,
    CV_SH3_IntSp = 25,
    CV_SH3_Gbr   = 38,
    CV_SH3_Pr    = 39,
    CV_SH3_Mach  = 40,
    CV_SH3_Macl  = 41,
    CV_SH3_Pc    = 50,
    CV_SH3_Sr    = 51,
    CV_SH3_BarA  = 60,
    CV_SH3_BasrA = 61,
    CV_SH3_BamrA = 62,
    CV_SH3_BbrA  = 63,
    CV_SH3_BarB  = 64,
    CV_SH3_BasrB = 65,
    CV_SH3_BamrB = 66,
    CV_SH3_BbrB  = 67,
    CV_SH3_BdrB  = 68,
    CV_SH3_BdmrB = 69,
    CV_SH3_Brcr  = 70,

    // Additional registers for Hitachi SH processors
    CV_SH_Fpscr  = 75, // Floating point status/control register
    CV_SH_Fpul   = 76, // Floating point communication register
    CV_SH_FpR0   = 80, // Floating point registers
    // CV_SH_FpR1 through CV_SH_FpR15 defined
    CV_SH_XFpR0  = 96,
    // CV_SH_XFpR1 through CV_SH_XFpR15 defined

    //** Register set for the ARM processor **//
    CV_ARM_NOREG = CV_REG_NONE,
    CV_ARM_R0    = 10,
    // CV_ARM_R1 through CV_ARM_R12 defined
    CV_ARM_SP    = 23, // Stack pointer
    CV_ARM_LR    = 24, // Link register
    CV_ARM_PC    = 25, // Program counter
    CV_ARM_CPSR  = 26, // Current program status register

    //** Register set for Intel IA64 **//
    CV_IA64_NOREG = CV_REG_NONE,
    CV_IA64_Br0   = 512, // Branch registers
    // CV_IA64_Br1 through CV_IA64_Br7 defined
    CV_IA64_P0    = 704, // Predicate registers
    // CV_IA64_P1 through CV_IA64_P63 defined
    CV_IA64_Preds = 768,
    CV_IA64_IntH0 = 832, // Banked general registers
    // CV_IA64_IntH1 through CV_IA64_IntH15 defined
    CV_IA64_Ip    = 1016, // Special registers
    CV_IA64_Umask = 1017,
    CV_IA64_Cfm   = 1018,
    CV_IA64_Psr   = 1019,
    CV_IA64_Nats  = 1020, // Banked general registers
    CV_IA64_Nats2 = 1021,
    CV_IA64_Nats3 = 1022,
    CV_IA64_IntR0 = 1024, // Integer registers
    // CV_IA64_IntR1 through CV_IA64_IntR127 defined
    CV_IA64_FltF0 = 2048, // Low floating point registers
    // CV_IA64_FltF1 through CV_IA64_FltF127 defined

    //** ADDITIONAL Intel IA64 REGISTERS DEFINED IN cvconst.h **//

    //** Register set for the TriCore processor **//
    CV_TRI_NOREG = CV_REG_NONE,
    CV_TRI_D0    = 10, // General purpose data registers
    // CV_TRI_D1 through CV_TRI_D15 defined
    CV_TRI_A0    = 26, // General purpose address registers
    // CV_TRI_A1 through CV_TRI_A15 defined
    CV_TRI_E0    = 42, // Extended (64-bit) data registers
    CV_TRI_E2    = 43,
    CV_TRI_E4    = 44,
    CV_TRI_E6    = 45,
    CV_TRI_E8    = 46,
    CV_TRI_E10   = 47,
    CV_TRI_E12   = 48,
    CV_TRI_E14   = 49,
    CV_TRI_EA0   = 50, // Extended (64-bit) address registers
    CV_TRI_EA2   = 51,
    CV_TRI_EA4   = 52,
    CV_TRI_EA6   = 53,
    CV_TRI_EA8   = 54,
    CV_TRI_EA10  = 55,
    CV_TRI_EA12  = 56,
    CV_TRI_EA14  = 57,

    //** ADDITIONAL TriCore REGISTERS DEFINED IN cvconst.h **//

    //** Register set for the AM33 and related processors **//
    CV_AM33_NOREG = CV_REG_NONE,
    // "Extended" (general purpose integer) registers
    CV_AM33_E0    = 10,
    // CV_AM33_E1 through CV_AM33_E7 defined
    CV_AM33_A0    = 20, // Address registers
    // CV_AM33_A1 through CV_AM33_A3 defined
    CV_AM33_D0    = 30, // Integer data registers
    // CV_AM33_D1 CV_AM33_D3 defined
    CV_AM33_FS0   = 40, // (Single-precision) floating-point registers
    // CV_AM33_FS1 through CV_AM33_FS31 defined

    //** ADDITIONAL AM33 REGISTERS DEFINED IN cvconst.h **//

    //** Register set for the Mitsubishi M32R **//
    CV_M32R_NOREG = CV_REG_NONE,
    CV_M32R_R0    = 10,
    // CV_M32R_R1 through CV_M32R_R11 defined
    CV_M32R_R12   = 22, // Global pointer, if used
    CV_M32R_R13   = 23, // Frame pointer, if allocated
    CV_M32R_R14   = 24, // Link register
    CV_M32R_R15   = 25, // Stack pointer
    CV_M32R_PSW   = 26, // Preprocessor status register
    CV_M32R_CBR   = 27, // Condition bit register
    CV_M32R_SPI   = 28, // Interrupt stack pointer
    CV_M32R_SPU   = 29, // User stack pointer
    CV_M32R_SPO   = 30, // OS stack pointer
    CV_M32R_BPC   = 31, // Backup program counter
    CV_M32R_ACHI  = 32, // Accumulator high
    CV_M32R_ACLO  = 33, // Accumulator low
    CV_M32R_PC    = 34, // Program counter

} CV_HREG_e;
```

## Elements

| Element    | Description                                                                             |
| ---------------------- | --------------------------------------------------------------------------- |
| CV_REG_*               | Registers used by Intel 80x86 and ix86 processors and p-code.               |
| CV_R68_*               | Registers used by 68K processor.                                            |
| CV_M4_*                | Registers used by MIPS 4000 series processor.                               |
| CV_ALPHA_*             | Registers used by Digital Equipment Corporation Alpha AXP series processor. |
| CV_PPC_*               | Registers used by Motorola/IBM PowerPC processor.                           |
| CV_SH3_* and CV_SH_*   | Registers used by Hitachi SH3 and Hitachi SH series processor.              |
| CV_ARM_*               | Registers used by Advanced RISC Machine (ARM) processors.                   |
| CV_IA64_*              | Registers used by Intel IA64 series processors.                             |
| CV_TRI_*               | Registers used by Infineon Technologies TriCore processor.                  |
| CV_AM33_*              | Registers used by Matsushita/Panasonic AM33 and related processors.         |
| CV_M32R_*              | Registers used by Mitsubishi M32R processor.                                |
| CV_ARM64_*             | Registers used by Advanced RISC Machine (ARM) 64-bit processors.            |

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
