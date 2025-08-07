---
title: 'Workflow Designer - Use the Variable Designer'
description: Learn how you can use the variable designer to create variables for use in data-binding scenarios and conditional statements.
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords:
- System.Activities.Presentation.View.DesignTimeVariable.UI
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Use the Variable Designer

The variable designer is used to create variables for use in data-binding scenarios and conditional statements. The designer is accessed by clicking the **Variables** button in the lower-left corner of the design canvas. The designer contains a list of variables that appear in a tabular form and can be sorted by each of the column headers, except for the **Default** column. Each variable contains a name, variable type, scope, and default value (if any). The name and default value are editable text fields, and the type and scope are drop-downs. The scope is the activity that was selected when the variable designer was invoked. If a variable cannot be created within the scope of the selection, then the scope will default to the nearest ancestor activity of the selection that allows for variables to be created in its scope. For more information, see [Variables and arguments (.NET)](/dotnet/framework/windows-workflow-foundation/variables-and-arguments).

 The sort order is not applied until the user explicitly uses one of the sorting controls, closes and reopens the variable designer, or creates another variable.

## To create a new variable

1. Open a workflow or activity solution in Visual Studio.

2. On the design canvas, select an activity in your workflow.

3. Open the variable designer by clicking the **Variables** button in the lower-left corner of the design canvas. The variable designer appears.

4. Click the empty row labeled **Create Variable**. This will add a new row with a new variable using the following default values: variablex for the **Name** where x is an integer with an initial value of 1 that is automatically incremented to create unique variable names, **String** for the **Variable type**, and **Sequence** for the **Scope**. No value is added for **Default**. You can change these values at any time during the workflow design process.

    > [!NOTE]
    > To delete a variable, select the variable by clicking it and then press the **Delete** key.

## Related content

- [Using the Workflow Designer](developing-applications-with-the-workflow-designer.md)
- [Variables and Arguments](/dotnet/framework/windows-workflow-foundation/variables-and-arguments)
- [How to: Use the Argument Designer](../workflow-designer/how-to-use-the-argument-designer.md)
