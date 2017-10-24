---
title: "Generate an override - Code Generation (Visual Basic) | Microsoft Docs"
ms.custom: ""
ms.date: "11/17/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: b3c8cfc4-7c1f-4606-970e-3f7651604bab
author: "gewarren"
ms.author: "gewarren"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---

# Generate an override in Visual Basic
**What:** Lets you immediately generate the code for a any method which can be overridden from a base class. 

**When:** You want to override a base class method and generate the signature automatically.  

**Why:** You could write the method signature yourself, however this feature will generate the signature automatically. 

**How:**

1. Type the **Overrides** keyword, followed by a space, where you would like to insert an overridden method signature and an IntelliSense dropdown will appear.

   ![Override IntelliSense](media/override_intellisense.png)

1. Select the method you would like to override from the base class by clicking it with the mouse, or navigating to it with the keyboard and pressing **Enter**.

<!--
   >[!TIP]
   >* Use the Property icon ![Property icon](media/override_property.png) to show or hide  Properties in the list.
   >* Use the Method icon ![Property icon](media/override_method.png) to show or hide Methods in the list.
-->

1. The selected method or property will be added to the class as an override, ready to be implemented.

   ![Override result](media/override_result.png)

## See Also  
[Code Generation (Visual Basic)](../code-generation-vb.md) 