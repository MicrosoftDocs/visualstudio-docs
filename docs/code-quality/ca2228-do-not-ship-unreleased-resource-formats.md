---
title: "CA2228: Do not ship unreleased resource formats"
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "DoNotShipUnreleasedResourceFormats"
  - "CA2228"
helpviewer_keywords:
  - "CA2228"
  - "DoNotShipUnreleasedResourceFormats"
ms.assetid: 2c614edc-4e94-4b4f-8067-eea677a75cd9
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# CA2228: Do not ship unreleased resource formats

|||
|-|-|
|TypeName|DoNotShipUnreleasedResourceFormats|
|CheckId|CA2228|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause

A resource file was built using a version of .NET that is not currently supported.

## Rule description

Resource files that were built by using pre-release versions of .NET might not be usable by supported versions of .NET.

## How to fix violations

To fix a violation of this rule, build the resource using a supported version of .NET.

## When to suppress warnings

Do not suppress a warning from this rule.
