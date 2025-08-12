---
title: Define and consume activity delegates
description: In Workflow Designer, learn how .NET Framework 4.5 includes an out-of-box designer for the InvokeDelegate activity you can use to define and consume activity delegates.
ms.date: 11/04/2016
ms.topic: how-to
author: sayedihashimi
ms.author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Define and consume activity delegates in the Workflow Designer

.NET Framework 4.5 includes an out-of-box designer for the <xref:System.Activities.Statements.InvokeDelegate> activity. This designer can be used to assign delegates to the activity that derive from <xref:System.Activities.ActivityDelegate>, such as <xref:System.Activities.ActivityAction> or <xref:System.Activities.ActivityFunc%601>.

## Define an activity delegate

1. Create a new **Workflow Console Application** project.

   > [!NOTE]
   > If you don't see the **Workflow** project templates, first install the **Windows Workflow Foundation** component of Visual Studio. For detailed instructions, see [Install Windows Workflow Foundation](developing-applications-with-the-workflow-designer.md#install-windows-workflow-foundation).

3. Right-click on the project in **Solution Explorer** and select **Add** > **New Item**. Select the **Workflow** category, and then select the **Activity** item template. Name the new activity **MyForEach.xaml** and then select **OK**.

   The activity opens in the workflow designer.

4. In the Workflow Designer, click the **Arguments** tab.

5. Click **Create Argument**. Name the new argument **Items**.

6. In the **Argument type** column, select **Array of [T]**.

7. In the type browser, select **Object** and then select **OK**.

8. Click **Create Argument** again. Name the new argument **Body**. In the **Direction** column for the new argument, select **Property**.

9. In the Argument Type column, select **Browse for types**

10. In the type browser, enter **ActivityAction** in the **Type Name** field. Select **ActivityAction\<T>** in the tree view. Select **Object** in the dropdown that appears to assign the type **ActivityAction\<Object>** to the argument.

11. Drag a <xref:System.Activities.Statements.While> activity from the **Control Flow** section of the toolbox to the designer surface.

12. Select the <xref:System.Activities.Statements.While> activity, and select the **Variables** tab.

13. Select **Create Variable**. Name the new variable **Index**.

14. In the **Variable type** column, select **Int32**. Leave the **Scope** as **While**, and the **Default** column blank.

15. Set the **Condition** property of the <xref:System.Activities.Statements.While> activity to **index < Items.Length;**.

16. Drag an <xref:System.Activities.Statements.InvokeDelegate> activity from the **Primitives** section of the toolbox to the **Body** of the <xref:System.Activities.Statements.While> activity.

17. Select **Body** in the delegate drop-down.

18. In the **Properties** grid for the <xref:System.Activities.Statements.InvokeDelegate> activity, click the **...** button in the **Delegate Arguments** property.

19. In the **Value** column of the argument named **Argument**, enter **Items[Index]**. Click **Ok** to close the **DelegateArguments** dialog.

20. Drag an <xref:System.Activities.Statements.Assign> activity onto the horizontal line underneath the <xref:System.Activities.Statements.InvokeDelegate> activity. The  <xref:System.Activities.Statements.Assign> activity is created, and a <xref:System.Activities.Statements.Sequence> activity is created automatically to contain the two activities in the **Body** section of the **MyForEach** activity. The sequence is needed since the **Body** section can only contain a single activity. Automatically creating a new <xref:System.Activities.Statements.Sequence> activity is a new feature of .NET Framework 4.5.

21. Set the **To** property of the <xref:System.Activities.Statements.Assign> activity to **index**. Set the **Value** property of the **Assign** activity to **index+1**.

    The custom **MyForEach** activity invokes an arbitrary activity once for each value passed into it through the **Items** collection, with the values in the collection as inputs for the activity.

## Use the custom activity in a workflow

1. Build the project by pressing **Ctrl**+**Shift**+**B**.

2. In **Solution Explorer**, open **Workflow1.xaml** in the designer.

3. Drag a **MyForEach** activity from the toolbox to the designer surface. The activity is in a section of the toolbox with the same name as the project.

4. Set the **Items** property of the **MyForEach** activity to **new Object[] {1, "abc"}**.

5. Drag a <xref:System.Activities.Statements.WriteLine> activity from the **Primitives** section of the toolbox to the **Delegate:Body** section of the **MyForEach** activity.

6. Set the **Text** property of the <xref:System.Activities.Statements.WriteLine> activity to **Argument.ToString()**.

When the workflow is executed, the console shows the following output:

**1**
**abc**
