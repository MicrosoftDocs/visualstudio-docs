---
title: "Managed Minimun Rules rule set for managed code | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
ms.assetid: 44a50c54-8dd3-42b2-8387-532a150e5a6c
caps.latest.revision: 4
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# Managed Minimun Rules rule set for managed code
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Managed Minimum Rules focus on the most critical problems in your code, including potential security holes, application crashes, and other important logic and design errors. You should include this rule set in any custom rule set you create for your projects.

|Rule|Description|
|----------|-----------------|
|[CA1001](../code-quality/ca1001-types-that-own-disposable-fields-should-be-disposable.md)|Types that own disposable fields should be disposable|
|[CA1821](../code-quality/ca1821-remove-empty-finalizers.md)|Remove empty finalizers|
|[CA2213](../code-quality/ca2213-disposable-fields-should-be-disposed.md)|Disposable fields should be disposed|
|[CA2231](../code-quality/ca2231-overload-operator-equals-on-overriding-valuetype-equals.md)|Overload operator equals on overriding ValueType.Equals|
