---
title: Portability Warnings
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "vs.codeanalysis.PortabilityRules"
helpviewer_keywords:
  - "portability warnings"
  - "managed code analysis warnings, portability warnings"
  - "warnings, portability"
ms.assetid: 902e859a-2153-4970-baaa-8a5b4a11806f
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Portability Warnings
Portability warnings support portability across different operating systems.

## In This Section

|Rule|Description|
|----------|-----------------|
|[CA1900: Value type fields should be portable](../code-quality/ca1900.md)|This rule checks that structures that are declared by using an explicit layout attribute will align correctly when marshaled to unmanaged code on 64-bit operating systems.|
|[CA1901: P/Invoke declarations should be portable](../code-quality/ca1901.md)|This rule evaluates the size of each parameter and the return value of a P/Invoke, and verifies that their size is correct when marshaled to unmanaged code on 32-bit and 64-bit operating systems.|
|[CA1903: Use only API from targeted framework](../code-quality/ca1903.md)|A member or type is using a member or type that was introduced in a service pack that was not included together with the targeted framework of the project.|
