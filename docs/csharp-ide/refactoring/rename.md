---
title: "Rename | Microsoft Docs"
ms.custom: ""
ms.date: "11/16/2016"
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
    - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 60e2a623-b56d-4591-93dc-e51429e4e1ba
author: "BrianPeek"
ms.author: "brpeek"
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

# Rename
**What:** Lets you rename identifiers for code symbols, such as fields, local variables, methods, namespaces, properties and types.

**When:** You want to safely rename something without having to find all instances, and copy/paste the new name.  

**Why:** Copy and pasting the new name across an entire project would likely result in errors.  This refactoring tool will accurately perform the renaming action.

**How:**

1. Highlight or place the text cursor inside the item to be renamed:

   ![Highlighted code](media/rename_highlight.png)

1. Next, do one of the following:
   * **Keyboard**
     * Press **Ctrl+R**, then **Ctrl+R**.  (Note that your keyboard shortcut may be different based on which profile you've selected.)
   * **Mouse**
     * Select **Edit > Refactor > Rename**.
     * Right-click the code and select **Rename**.

1. Rename the item simply by typing the new name.

   ![Rename animation](media/rename_animated.gif)

   > [!TIP]
   > You can also update comments and other strings to use this new name, as well as preview changes before saving, using the checkboxes in the **Rename** box which appears at the top right of your IDE.

1. When you're happy with the change, click the **Apply** button or press **Enter** and the changes will be committed.

> [!NOTE]
> If you use a name that already exists which would cause a conflict, the **Rename** box in your IDE will warn you.
>
> ![Rename Conflict](media/rename_conflict.png)


<!--   ![Rename item](media/rename_rename.png)-->