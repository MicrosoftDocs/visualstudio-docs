---
title: "Change Method Signature | Microsoft Docs"
ms.custom: ""
ms.date: "11/16/2016"
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
    - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: b4f45f9d-9c8f-46ae-99f7-7705c6d90b6e
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

# Change Method Signature
**What:** Lets you remove or change the order of a method's parameters.

**When:** You want to move or remove a method parameter that is currently being used in a variety of locations.  

**Why:** You could manually remove and re-order the parameters, and then find all calls to that method and change them one-by-one, but that could lead to errors.  This refactoring tool will perform the task automatically.

**How:**

1. Highlight or place the text cursor inside the name of the method to modify, or one of its usages:

   ![Highlighted code](media/changesignature_highlight.png)

1. Next, do one of the following:
   * **Keyboard**
     * Press **Ctrl+R**, then **Ctrl+V**.  (Note that your keyboard shortcut may be different based on which profile you've selected.)
     * Press **Ctrl+.** to trigger the **Quick Actions and Refactorings** menu and select **Change Signature** from the Preview window popup.
   * **Mouse**
     * Select **Edit > Refactor > Remove Parameters**.
     * Select **Edit > Refactor > Reorder Parameters**.
     * Right-click the code, select the **Quick Actions and Refactorings** menu and select **Change Signature** from the Preview window popup.

1. In the **Change Signature** dialog that pops up, you can use the buttons on the right side to change the method signature:

   ![Change Signature dialog](media/changesignature_dialog.png)

   | Button | Description
   | ------ | ---
   | **Up/Down** | Move the selected parameter up and down the list
   | **Remove**  | Remove the selected parameter from the list
   | **Restore** | Restore the selected, crossed-out parameter to the list

   > [!TIP]
   > Use the **Preview reference changes** checkbox to see what the result will be before committing to it.

1. When you are finished, press the **OK** button to make the changes.

   ![Change Signature result](media/changesignature_result.png)
