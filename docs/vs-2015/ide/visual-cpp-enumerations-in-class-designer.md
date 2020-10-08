---
title: "Visual C++ Enumerations in Class Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "Class Designer [Visual Studio], enumerations"
ms.assetid: 11e90ba1-18cd-44f8-9e26-e3746a7a19d1
caps.latest.revision: 14
author: jillre
ms.author: jillfra
manager: jillfra
---
# Visual C++ Enumerations in Class Designer
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Class Designer supports C++ `enum` and scoped `enum class` types. Following is an example:

```
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

 For more information about using the `enum` type, see [Enumerations](https://msdn.microsoft.com/library/081829db-5dca-411e-a53c-bffef315bcb3).

## See Also
 [Working with Visual C++ Code (Class Designer)](../ide/working-with-visual-cpp-code-class-designer.md)
 [Enumerations](https://msdn.microsoft.com/library/081829db-5dca-411e-a53c-bffef315bcb3)
