---
title: Globalization Rules rule set for managed code
ms.date: 11/04/2016
description: Learn about the Globalization Rules rule set in Visual Studio, which focuses on problems related to languages, locales, and cultures. See rule descriptions.
ms.custom: SEO-VS-2020
ms.topic: reference
ms.assetid: 3c4032ee-0805-4581-8c48-b1827cd6b213
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-code-analysis
ms.workload:
- dotnet
---
# Globalization Rules rule set for managed code

Use the Microsoft Globalization Rules rule set to focus on problems that might prevent data in your application from appearing correctly in different languages, locales, and cultures. You should include this rule set if your application is localized, globalized, or both.

|Rule|Description|
|----------|-----------------|
|[CA1303](/dotnet/fundamentals/code-analysis/quality-rules/ca1303)|Do not pass literals as localized parameters|
|[CA1304](/dotnet/fundamentals/code-analysis/quality-rules/ca1304)|Specify CultureInfo|
|[CA1305](/dotnet/fundamentals/code-analysis/quality-rules/ca1305)|Specify IFormatProvider|
|[CA1307](/dotnet/fundamentals/code-analysis/quality-rules/ca1307)|Specify StringComparison for clarity|
|[CA1308](/dotnet/fundamentals/code-analysis/quality-rules/ca1308)|Normalize strings to uppercase|
|[CA1309](/dotnet/fundamentals/code-analysis/quality-rules/ca1309)|Use ordinal StringComparison|
|[CA1310](/dotnet/fundamentals/code-analysis/quality-rules/ca1310)|Specify StringComparison for correctness|
|[CA2101](/dotnet/fundamentals/code-analysis/quality-rules/ca2101)|Specify marshaling for P/Invoke string arguments|
