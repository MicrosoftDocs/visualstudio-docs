---
title: "Step 2: Add a Random Object and a List of Icons | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
ms.assetid: 95faea28-eddc-4cfa-95fb-3b34b5a976d7
caps.latest.revision: 24
author: jillre
ms.author: jillfra
manager: jillfra
---
# Step 2: Add a Random Object and a List of Icons
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In this step, you create a set of matching symbols for the game. Each symbol is added to two random cells in the TableLayoutPanel on the form. To do this, you use two `new` statements to create two objects. The first is a `Random` object, like the one you used in the math quiz game. It is used in this code to randomly choose cells in the TableLayoutPanel. The second object, which may be new to you, is a `List` object which is used to store the randomly-chosen symbols.

### To add a Random object and a list of icons

1. In **Solution Explorer**, choose **Form1.cs** if you're using Visual C#, or **Form1.vb** if you're using Visual Basic, and then on the menu bar, choose **View**, **Code**. As an alternative, you can choose the **F7** key or double-click **Form1** in **Solution Explorer**.

     This displays the code module behind Form1.

2. In the existing code, add the following code.

     [!code-csharp[VbExpressTutorial4Step2_3_4#1](../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial4step2_3_4/cs/form1.cs#1)]
     [!code-vb[VbExpressTutorial4Step2_3_4#1](../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial4step2_3_4/vb/form1.vb#1)]

     If you're using Visual C#, be sure you put the code after the opening curly brace and just after the class declaration (`public partial class Form1 : Form`). If you're using Visual Basic, put the code right after the class declaration (`Public Class Form1`).

3. When adding the `List` object, notice the **IntelliSense** window that opens. The following is a Visual C# example, but similar text appears when you add a list in Visual Basic.

     ![Properties window showing Click event](../ide/media/express-listintellisense.png "Express_ListIntellisense")
IntelliSense window

    > [!NOTE]
    > The Intellisense window appears only when you enter code manually. If you copy and paste the code, it doesn't appear.

     If you look at the code (and remarks) in small sections, it's easier to understand. Your programs can use `List` objects to keep track of many different types of items. A list can hold numbers, true/false values, text, or other objects. You can even have a `List` object that holds other `List` objects. The items in a list are called *elements*, and each list only holds one type of element. So, a list of numbers can only hold numbers—you can't add text to that list. Similarly, you can't add numbers to a list of true/false values.

     When you create a `List` object using a `new` statement, you need to specify the kind of data you want to store in it. That's why the tooltip at the top of the **IntelliSense** window shows the types of elements in the list. Also, that's what `List<string>` (in Visual C#) and `List(Of String)` (in Visual Basic) means: It's a `List` object that holds elements of `string` data type. A string is what your program uses to store text, which is what the tooltip to the right of the **IntelliSense** window is telling you.

4. Consider why in Visual Basic a temporary array must be created first, but in Visual C#, the list can be created with one statement. This is because the Visual C# language has *collection initializers*, which prepare the list to accept values. In Visual Basic, you can use a collection initializer. However, for compatibility with the previous version of Visual Basic, we recommend using the preceding code.

     When you use a collection initializer with a `new` statement, after the new `List` object is created, the program fills it with the data you provided inside the curly braces. In this case, you get a list of strings named **icons**, and that list will be initialized so that it contains sixteen strings. Each of those strings is a single letter, and they all correspond to the icons that will be in the labels. So, the game will have a pair of exclamation points, a pair of uppercase N letters, a pair of commas, and so on. (When these characters are set to the Webdings font, they will appear as symbols, such as a bus, a bike, a spider, and so forth.) Your `List` object will have sixteen strings in all, one for each cell in the TableLayoutPanel panel.

    > [!NOTE]
    > In Visual Basic, you get the same result, but first the strings are put into a temporary array, which is then converted into a `List` object. An array is similar to a list, except, for example, arrays are created with a fixed size. Lists can shrink and grow as needed, which is important in this program.

### To continue or review

- To go to the next tutorial step, see [Step 3: Assign a Random Icon to Each Label](../ide/step-3-assign-a-random-icon-to-each-label.md).

- To return to the previous tutorial step, see [Step 1: Create a Project and Add a Table to Your Form](../ide/step-1-create-a-project-and-add-a-table-to-your-form.md).
