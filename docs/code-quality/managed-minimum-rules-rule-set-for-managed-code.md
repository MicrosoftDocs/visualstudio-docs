---
title: Managed Minimum Rules rule set for managed code
ms.date: 11/04/2016
description: Learn about the Managed Minimum Rules rule set in Visual Studio, which focuses on security, robustness, and other critical issues. See rule descriptions.
ms.custom: SEO-VS-2020
ms.topic: reference
ms.assetid: 44a50c54-8dd3-42b2-8387-532a150e5a6c
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-code-analysis
ms.workload:
- dotnet
---
# Managed Minimum Rules rule set for managed code

The Managed Minimum rules focus on the most critical problems in your code, including potential security holes, application crashes, and other important logic and design errors. Include this rule set in any custom rule set you create for your projects.

|Rule|Description|
|----------|-----------------|
|[CA1001](/dotnet/fundamentals/code-analysis/quality-rules/ca1001)|Types that own disposable fields should be disposable|
|[CA1821](/dotnet/fundamentals/code-analysis/quality-rules/ca1821)|Remove empty finalizers|
|[CA2213](/dotnet/fundamentals/code-analysis/quality-rules/ca2213)|Disposable fields should be disposed|
|[CA2231](/dotnet/fundamentals/code-analysis/quality-rules/ca2231)|Overload operator equals on overriding `ValueType.Equals`|
