---
title: "Generate a constructor - Code Generation (C#) | Microsoft Docs"
ms.custom: ""
ms.date: "11/27/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: f2280cfa-a9ec-4b56-9d94-c8fd384db980
author: "kuhlenh"
ms.author: "kaseyu"
manager: ghogen
ms.workload: 
  - "dotnet"
---

# Generate a constructor in C# #
**What:** Lets you immediately generate the code for a new constructor on a class. 

**When:** You introduce a new constructor and want to properly declare it automatically, or you modify an existing constructor. 

**Why:** You could declare the constructor before using it, however this feature will generate it, with the proper parameters, automatically. Furthermore, modifying an existing constructor requires updating all the callsites unless you use this feature to update them automatically.

**How:**
There are several ways to generate a constructor:
- [Generate constructor and pick members](#pick)
- [Generate constructor from selected fields](#selection)
- [Generate constructor from new usage](#usage)
- [Add parameter to existing constructor](#addparameter)
- [Create and initialize field/property from a constructor parameter](#create)

## <a id = "pick"></a> Generate constructor and pick members
1. Place your cursor in any empty line in a class:

   ![Cursor in empty line](media/constructor1-highlight-cs.png)

1. Next, do one of the following:
   * **Keyboard**
     * Press **Ctrl+.** to trigger the **Quick Actions and Refactorings** menu and select **Generate constructor...** from the Preview window popup.
   * **Mouse**
     * Right-click and select the **Quick Actions and Refactorings** menu and select **Generate constructor...** from the Preview window popup.
     * Click the ![Lightbulb](media/bulb-cs.png) icon which appears in the left margin if the text cursor is already on the empty line in the class.

   ![Generate constructor preview](media/constructor1-preview-cs.png)

1. A dialog will appear allowing you to pick and choose which members you want to be used as constructor parameters as well as order them (with the up and down arrows). Press **Ok** to commit your changes.
  
   ![Pick members dialog](media/constructor1-dialog-cs.png)

   >[!TIP] 
   >You can check the **Add null checks** checkbox to automatically generate null checks for your constructor parameters.

1. The constructor will be created with the selected parameters in the specified order.
   ![Generate constructor result](media/constructor1-result-cs.png)

## <a id="selection"></a> Generate constructor from selected fields
1. Highlight the members you wish to have in your generated constructor:
   ![Highlight members](media/constructor2-highlight-cs.png)

1. Next, do one of the following:
   * **Keyboard**
     * Press **Ctrl+.** to trigger the **Quick Actions and Refactorings** menu and select **Generate constructor 'TypeName(...)'** from the Preview window popup.
   * **Mouse**
     * Right-click and select the **Quick Actions and Refactorings** menu and select **Generate constructor 'TypeName(...)'** from the Preview window popup.
     * Click the ![Lightbulb](media/bulb-cs.png) icon which appears in the left margin if the text cursor is already on the line with the selection.

     ![Generate Constructor preview](media/constructor2-preview-cs.png)

1. The constructor will be created with the selected parameters.
     ![Generate Constructor result](media/constructor2-result-cs.png)

## <a id="usage"></a> Generate constructor from new usage
1. Place your cursor on the line where there is a red squiggle indicating you've used a constructor that doesn't yet exist.

   ![Highlighted code](media/constructor-highlight-cs.png)

1. Next, do one of the following:
   * **Keyboard**
     * Press **Ctrl+.** to trigger the **Quick Actions and Refactorings** menu and select **Generate constructor in '*TypeName*'** from the Preview window popup.
   * **Mouse**
     * Right-click and select the **Quick Actions and Refactorings** menu and select **Generate constructor in '*TypeName*'** from the Preview window popup.
     * Hover over the red squiggle and click the ![Lightbulb](media/bulb-cs.png) icon which appears.
     * Click the ![Lightbulb](media/bulb-cs.png) icon which appears in the left margin if the text cursor is already on the line with the red squiggle.

   ![Generate constructor preview](media/constructor-preview-cs.png)

   >[!TIP]
   >Use the [**Preview changes**](../../ide/preview-changes.md) link at the bottom of the preview window to see all of the changes that will be made before making your selection.

1. The constructor will be created automatically with any parameters inferred from its usage.

   ![Generate constructor result](media/constructor-result-cs.png)

## <a id="addparameter"></a> Add parameter to existing constructor
1. Add a parameter to an existing object instantiation.

1. Place your cursor on the line where there is a red squiggle indicating you've used a constructor that doesn't yet exist.
    
    ![Generate constructor highlight](media/constructor4-highlight-cs.png)

1. Next, do one of the following:
   * **Keyboard**
     * Press **Ctrl+.** to trigger the **Quick Actions and Refactorings** menu and select **Add parameter to 'TypeName(...)'** from the Preview window popup.
   * **Mouse**
     * Right-click and select the **Quick Actions and Refactorings** menu and select **Add parameter to 'TypeName(...)'** from the Preview window popup.
     * Hover over the red squiggle and click the ![Lightbulb](media/bulb-cs.png) icon which appears.
     * Click the ![Lightbulb](media/bulb-cs.png) icon which appears in the left margin if the text cursor is already on the line with the red squiggle.

    ![Generate constructor preview](media/constructor4-preview-cs.png)

1. The parameter will be added automatically with its type inferred from its usage.
   
   ![Generate constructor result](media/constructor4-result-cs.png)

## <a id="create"></a> Create and initialize field/property from a constructor parameter
1. From an existing constructor, add a parameter:

   ![Generate constructor highlight](media/constructor5-highlight-cs.png)

1. Place your cursor inside the newly added parameter.

1. Next, do one of the following:
   * **Keyboard**
     * Press **Ctrl+.** to trigger the **Quick Actions and Refactorings** menu and select **Create and initialize property 'YourProperty'** or **Create and initialize field 'YourField'** from the Preview window popup.
   * **Mouse**
     * Right-click and select the **Quick Actions and Refactorings** menu and select **Create and initialize property 'YourProperty'** or **Create and initialize field 'YourField'** from the Preview window popup.
     * Click the ![Lightbulb](media/bulb-cs.png) icon which appears in the left margin if the text cursor is already on the line with the added parameter.

   ![Generate constructor preview](media/constructor5-preview-cs.png)

1. The field/property will be created and automatically named to match your types.

   ![Generate constructor result](media/constructor5-result-cs.png)

## See also

[Code Generation](../code-generation-in-visual-studio.md)  
[Preview Changes](../../ide/preview-changes.md)