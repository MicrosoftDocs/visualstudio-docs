---
title: Perf insights for excessive string.Format/interpolation usage
description: Learn how to improve performance for excessive use of string.Format or string interpolation.
ms.date: 09/18/2025
ms.topic: reference
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---


# Inefficient string.Format or interpolation usage

This article describes performance insights when using <xref:System.String.Format*> or string interpolation ($"...").

## Cause
Using `string.Format` or string interpolation frequently results in slow performance.

## Performance insight description

Each call to `string.Format` or string interpolation creates a new string object, resulting in excessive memory allocations and CPU usage when used repeatedly, especially in loops or performance-critical code paths.

If possible, use a <xref:System.Text.StringBuilder> for repeated string manipulations, or cache formatted strings when possible. `StringBuilder` allows for efficient string construction without creating multiple intermediate string objects.

## How to investigate a warning

In the CPU Usage tool, click **View source code** to find where `string.Format` or string interpolation is used excessively. If possible, refactor to use `StringBuilder` or minimize formatting operations in hot paths.

## See also

[StringBuilder documentation](https://learn.microsoft.com/dotnet/api/system.text.stringbuilder)
