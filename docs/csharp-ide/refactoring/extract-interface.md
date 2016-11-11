---
title: "Extract Interface | Microsoft Docs"
ms.custom: ""
ms.date: "11/16/2016"
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
    - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 55e17f0a-eacb-41ec-b8ca-74f5c6bbd6de
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

# Extract Interface
**What:** Lets you create an interface using existing members from a class, struct or interface.

**When:** You have several classes, structs or interfaces with methods that could be made common and used by other classes, structs or interfaces.

**Why:** Interfaces are great constructs for object-oriented designs.  Imagine having classes for various animals (Dog, Cat, Bird) which might all have common methods, such as Eat, Drink, Sleep.  Using an interface like IAnimal would allow Dog, Cat, and Bird to have a common "signature" for these methods.  

**How:**

1. Highlight the name of the class to perform the action on, or just put the text cursor somewhere in the class name.

   ![Highlighted code](media/extractinterface_highlight.png)

1. Next, do one of the following:
   * **Keyboard**
     * Press **Ctrl+R**, then **Ctrl+I**.  (Note that your keyboard shortcut may be different based on which profile you've selected.)
     * Press **Ctrl+.** to trigger the **Quick Actions and Refactorings** menu and select **Extract Interface** from the Preview window popup.
   * **Mouse**
     * Select **Edit > Refactor > Extract Interface**.
     * Right-click the name of the class, select the **Quick Actions and Refactorings** menu and select **Extract Interface** from the Preview window popup.

1. In the **Extract Interface** dialog box that pops up, enter the information asked:
   ![Extract Interface](media/extractinterface_dialog.png)
   | Field | Description |
   | --- | --- |
   | **New interface name** | The name of the interface to be created. This will default to I*ClassName*, where *ClassName* is the name of the class you selected above. |
   | **New file name** | The name of the file which will be generated that will contain the interface. As with the interface name, this will default to I*ClassName*, where *ClassName* is the name of the class you selected above. |
   | **Select public members to form interface** | The items to extract into the interface.  You may select as many as you wish. |

1. Click **OK**.

   The interface will be immediately created in the file of the name specified.  Additionally, the class you selected will now implement that interface.

   ![Resulting Class](media/extractinterface_class.png)
   ![Resulting Interface](media/extractinterface_interface.png)
