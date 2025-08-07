---
title: 'Workflow Designer - Use the Expression Editor'
description: Learn how the Expression Editor is a Workflow Designer control that you can use in many workflow activities to enter and evaluate expressions.
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords:
- System.Activities.Presentation.View.ExpressionTextBox.UI
author: sayedihashimi
ms.author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Use the Expression Editor

The Expression Editor is a Workflow Designer control that is used in many workflow activities to enter and evaluate expressions. The Expression Editor provides a full-fledged IDE editing experience, including IntelliSense, colorization, ParamInfo, error squiggles, among other features. The compiler validates the expression after it's entered. If the expression is invalid, an error icon is displayed. The editor can also be opened as an **Expression Editor** dialog box.

Expressions are literal values or Visual Basic code bound to arguments or properties. They contain value elements (for example, variables, constants, literals, properties) that are combined with operations to yield a new value. Expressions are written using VB.NET syntax even if the application is in a program using C#. This means capitalization does not matter, comparison is performed using a single equal sign ("=" instead of "=="), the Boolean operators are the words "and" and "or" instead of the symbols "&&" and "||", and **Nothing** is used instead of **null**. For more information on expressions and operators in Visual Basic and for some samples, see [Operators and expressions in Visual Basic](/previous-versions/visualstudio/visual-studio-2010/a1w3te48(v=vs.100)).

The **Expression Editor** behaves as follows:

- If the focus is not on the Expression Editor, it looks like a regular TextBlock control.

- Once the focus is on the Expression Editor, it looks and behaves like the Expression Editor control. After it loses focus, the Expression Editor looks like a regular TextBlock again.

- If you focus on the Expression Editor in a rehosted workflow designer, then it behaves like a TextBox. When focus is lost in the rehosted workflow designer, the Expression Editor looks like a regular TextBlock again.

> [!NOTE]
> IntelliSense for the Expression Editor is available only inside of Visual Studio. In both the Visual Studio and the rehosted scenarios, the compiler validates the expression after it's entered and the expression editor displays an error icon if the expression is invalid.

## Use the Expression editor

1. In Visual Studio, open a new or existing workflow project.

2. Add, for example, the <xref:System.Activities.Statements.Assign> activity to your workflow.

    > [!NOTE]
    > Multiple workflow activities have expression editors. Expression TextBlocks also appear in the variable designer, argument designer, and the dynamic argument designer. The <xref:System.Activities.Statements.Assign> activity is used as an example.

3. Click the left expression editor in the activity designer for the <xref:System.Activities.Statements.Assign> activity.

     The gray watermark strings **\<To>** and **\<Enter a VB Expression>** are the default text strings for expression editors in the <xref:System.Activities.Statements.Assign> activity.

4. Enter your expression. If you enter a string, make sure to put quotation marks around the string. If you choose to bind the expression argument to a variable, leave the quotation marks off.

     When you're done, select a region or area outside of the Expression Editor to shift the focus to another part of the designer. Shifting the focus causes the compiler to validate the expression as described previously.

     An alternative way to enter or edit an expression is to click the ellipsis next to the property name in the property grid. Selecting the ellipsis opens the **Expression Editor** as a dialog box.

## Related content

- <xref:System.Activities.Presentation.View.ExpressionTextBox>
