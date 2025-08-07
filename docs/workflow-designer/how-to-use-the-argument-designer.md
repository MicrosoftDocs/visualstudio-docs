---
title: 'Workflow Designer - Use the Argument Designer'
description: Learn about the argument designer and how to use the argument designer to allow data to flow into and out of an activity.
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords:
- System.Activities.Presentation.View.ArgumentDesigner.UI
- System.Activities.Presentation.View.DesignTimeArgument.UI
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Use the Argument Designer

The argument designer makes it easy to allow data to flow into and out of an activity. Access the designer by clicking the **Arguments** button in the lower-left corner of the design canvas. The designer contains a list of arguments that appear in a tabular form and can be sorted by each of the column headers, except for the **Default value** column. Each argument contains a name, in/out/in-out/property direction, type, and default expression value (if any). The name and the default expression value are editable text fields, and the type and direction are drop-downs. For more information, see [Variables and arguments (.NET)](/dotnet/framework/windows-workflow-foundation/variables-and-arguments).

## To create a new argument

1. Open a workflow or activity solution in Visual Studio.

2. Open the arguments designer by clicking the **Arguments** button in the lower-left corner of the design canvas. The arguments designer appears.

3. Click the empty row labeled **Create Argument**. This will add a new row with a new argument using the following default values: argumentx for the **Name** where x is an integer with an initial value of 1 that is automatically incremented to create unique argument names, **In** for the **Direction**, and **String** for the **Argument type**. No value is added for **Default value**. You can change these values at any time during the workflow design process.

    > [!NOTE]
    > To delete an argument, select the argument by clicking it and then press the **Delete** key.

## Related content

- [Using the Workflow Designer](developing-applications-with-the-workflow-designer.md)
- [Variables and Arguments](/dotnet/framework/windows-workflow-foundation/variables-and-arguments)
