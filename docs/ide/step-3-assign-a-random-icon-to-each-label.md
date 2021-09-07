---
title: "Step 3: Assign a random icon to each label"
description: Learn how to assign a random icon to each label so the icons don't show up in the same cells every game.
ms.custom: SEO-VS-2020
ms.date: 03/21/2020
ms.topic: tutorial
dev_langs:
  - "CSharp"
  - "VB"
ms.assetid: 0ba5ed7a-9aaa-41f4-95d2-e3c2d567bc79
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
  - "multiple"
---
# Step 3: Assign a random icon to each label

If the icons show up in the same cells every game, it's not very challenging. To avoid this, assign the icons randomly to the Label controls on your form by using an `AssignIconsToSquares()` method.

## To assign a random icon to each label

1. Before adding the following code, consider how the method works. There's a new keyword: `foreach` in C# and `For Each` in Visual Basic. (One of the lines is commented out on purpose, which is explained at the end of this procedure.)

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial4step2_3_4/cs/form1.cs" id="Snippet2":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial4step2_3_4/vb/form1.vb" id="Snippet2":::

      > [!IMPORTANT]
      > Use the programming language control at the top right of this page to view either the C# code snippet or the Visual Basic code snippet.<br><br>![Programming language control for Docs.Microsoft.com](../ide/media/docs-programming-language-control.png)

2. Add the `AssignIconsToSquares()` method as shown in the previous step. You can put it just below the code you added in [Step 2: Add a Random object and a list of icons](../ide/step-2-add-a-random-object-and-a-list-of-icons.md).

     As mentioned earlier, there's something new in your `AssignIconsToSquares()` method: a `foreach` loop in C# and `For Each` in Visual Basic. You can use a `For Each` loop any time you want to do the same action multiple times. In this case, you want to execute the same statements for every label on your <xref:System.Windows.Forms.TableLayoutPanel>, as explained by the following code. The first line creates a variable named `control` that stores each control one at a time while that control has the statements in the loop executed on it.

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial4step2_3_4/cs/form1.cs" id="Snippet14":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial4step2_3_4/vb/form1.vb" id="Snippet14":::

    > [!NOTE]
    > The names "iconLabel" and "control" are used because they are descriptive. You can replace these names with any names, and the code will work exactly the same as long as you change the name in each statement inside the loop.

     The `AssignIconsToSquares()` method iterates through each label control in the TableLayoutPanel and executes the same statements for each of them. Those statements pull a random icon from the list that you added in [Step 2: Add a Random object and a list of icons](../ide/step-2-add-a-random-object-and-a-list-of-icons.md). As a reminder, each of these icons is a letter in the Webdings font, which is why they are expressed as text in this method. You included two of each icon in the list, so that there would be a pair of icons assigned to random Label controls.

     Look more closely at the code that runs inside the `foreach` or `For Each` loop. This code is reproduced here.

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial4step2_3_4/cs/form1.cs" id="Snippet16":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial4step2_3_4/vb/form1.vb" id="Snippet16":::

     The first line converts the **control** variable to a label named **iconLabel**. The line after that is an `if` statement that checks to make sure the conversion worked. If the conversion does work, the statements in the `if` statement run. (As you may recall from the previous tutorials, the `if` statement is used to evaluate whatever condition you specify.) The first line in the `if` statement creates a variable named **randomNumber** that contains a random number that corresponds to one of the items in the icons list. To do this, it uses the <xref:System.Random.Next> method of the <xref:System.Random> object that you created earlier. The `Next` method returns the random number. This line also uses the <xref:System.Collections.Generic.List%601.Count> property of the **icons** list to determine the range from which to choose the random number. The next line assigns one of the icon list items to the <xref:System.Windows.Forms.Label.Text> property of the label. The commented-out line is explained later in this topic. Finally, the last line in the `if` statement removes from the list the icon that has been added to the form.

     Remember, if you're not sure about what some part of the code does, you can position the mouse pointer over a code element and review the resulting tooltip. You can also step through each line of code while the program is running by using the Visual Studio debugger. See [How do I: Step with The debugger in Visual Studio?](https://msdn.microsoft.com/vstudio/ee672313.aspx) or [Navigate through code with the debugger](../debugger/navigating-through-code-with-the-debugger.md) for more information.

3. To fill up the game board with icons, you need to call the `AssignIconsToSquares()` method as soon as the program starts. If you're using C#, add a statement just below the call to the `InitializeComponent()` method in the **Form1** _constructor_, so your form calls your new method to set itself up before it's shown. Constructors are called when you create a new object, such as a class or struct. See [Constructors (C# programming guide)](/dotnet/csharp/programming-guide/classes-and-structs/constructors) or [Use constructors and destructors](/previous-versions/visualstudio/visual-studio-2008/2z08e49e\(v\=vs.90\)) in Visual Basic for more information.

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial4step2_3_4/cs/form1.cs" id="Snippet13":::

     For Visual Basic, add the `AssignIconsToSquares()` method call to the `Form1_Load` method so that the code looks like the following.

    ```vb
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AssignIconsToSquares()
    End Sub
    ```

4. Save your program and run it. It should show a form with random icons assigned to each label. 

5. Close your program, and then run it again. Notice that different icons are assigned to each label, as shown in the following picture. 

     ![Matching game with random icons](../ide/media/express_tut4step3.png)<br/>
*Matching game with random icons*

     The icons are visible now because you haven't hidden them. To hide them from the player, you can set each label's **ForeColor** property to the same color as its **BackColor** property.

6. To hide the icons, stop the program and remove the comment marks for the commented line of code inside the `For Each` loop.

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial4step2_3_4/cs/form1.cs" id="Snippet15":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial4step2_3_4/vb/form1.vb" id="Snippet15":::

7. On the menu bar, choose the **Save All** button to save your program, and then run it. The icons seem to have disappeared—only a blue background appears. However, the icons are randomly assigned and are still there. Because the icons are the same color as the background, it hides them from the player. After all, it wouldn't be a very challenging game if the player could see all of the icons right away!

## To continue or review

- To go to the next tutorial step, see **[Step 4: Add a click event handler to each label](../ide/step-4-add-a-click-event-handler-to-each-label.md)**.

- To return to the previous tutorial step, see [Step 2: Add a Random object and a list of icons](../ide/step-2-add-a-random-object-and-a-list-of-icons.md).
