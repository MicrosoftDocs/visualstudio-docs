---
title: C++ Enumerations in Class Designer
description: Learn about how Class Designer supports C++ enum and scoped enum class types.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- Class Designer [Visual Studio], enumerations
ms.assetid: 11e90ba1-18cd-44f8-9e26-e3746a7a19d1
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- cplusplus
---
# C++ enumerations in Class Designer

**Class Designer** supports C++ `enum` and scoped `enum class` types. Following is an example:

```cpp
enum CardSuit {
   Diamonds = 1,
   Hearts = 2,
   Clubs = 3,
   Spades = 4
};

// or...
enum class CardSuit {
   Diamonds = 1,
   Hearts = 2,
   Clubs = 3,
   Spades = 4
};
```

A C++ enumeration shape in a class diagram looks and works like a structure shape, except that the label reads **Enum** or **Enum class**, it is pink instead of blue, and it has a colored border on the left and top margins. Both enumeration shapes and structure shapes have square corners.

For more information about using the `enum` type, see [Enumerations](/cpp/cpp/enumerations-cpp).

## See also

- [Working with C++ Code](working-with-visual-cpp-code.md)
- [Enumerations](/cpp/cpp/enumerations-cpp)
