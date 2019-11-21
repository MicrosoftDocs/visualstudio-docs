---
title: "How to: Use the Expression Editor | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "System.Activities.Presentation.View.ExpressionTextBox.UI"
ms.assetid: b5f961dd-6dda-41a9-9cae-0383d479ef3d
caps.latest.revision: 13
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Use the Expression Editor
The Expression Editor is a [!INCLUDE[wfd1](../includes/wfd1-md.md)] control that is used in many workflow activities as a means of entering and evaluating these expressions. The Expression Editor provides a full-fledged IDE editing experience including IntelliSense, colorization, ParamInfo, error squiggles, among other features. The compiler validates the expression after it is entered. If the expression is invalid, an error icon is displayed. The editor can also be opened as an **Expression Editor** dialog box.

 Expressions are literal values or [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] code bound to arguments or properties. They contain value elements (e.g. variables, constants, literals, properties) that are combined with operations to yield a new value. Expressions are written using VB.NET syntax even if the application is in a program using C#. This means capitalization does not matter, comparison is performed using a single equals (“=”) sign instead of (“==”), the Boolean operators are the words "and" and "or" instead of the symbols "&&" and "&#124;&#124;", and **Nothing** is used instead of **null**. For more information on expressions and operators in [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] and for some samples, see [Operators and Expressions in Visual Basic](https://go.microsoft.com/fwlink/?LinkId=186818).

 The **Expression Editor** behaves as follows:

- If the focus is not on the Expression Editor, it looks like a regular TextBlock control.

- Once the focus is on the Expression Editor, it looks and behaves like the Expression Editor control. After it loses focus, the it looks like a regular TextBlock again.

- If you focus on the Expression Editor in a rehosted workflow designer, then it behaves like a TextBox. When focus is lost in the rehosted workflow designer, the Expression Editor looks like a regular TextBlock again.

> [!NOTE]
> IntelliSense for the Expression Editor is available only inside of [!INCLUDE[vs2010](../includes/vs2010-md.md)]. In both the [!INCLUDE[vs2010](../includes/vs2010-md.md)] and the rehosted scenarios, the compiler validates the expression after it is entered and the expression editor displays an error icon if the expression is invalid.

### Using the Expression editor

1. In [!INCLUDE[vs2010](../includes/vs2010-md.md)], open a new or existing workflow project.

2. Add, for example, the <xref:System.Activities.Statements.Assign> activity to your workflow.

    > [!NOTE]
    > Multiple workflow activities have expression editors. Expression TextBlocks also appear in the variable designer, argument designer, and the dynamic argument designer. The <xref:System.Activities.Statements.Assign> activity is used as an example.

3. Click the left expression editor in the activity designer for the <xref:System.Activities.Statements.Assign> activity.

     The grey watermark strings **\<To>** and **\<Enter a VB Expression>** are the default text strings for expression editors in the <xref:System.Activities.Statements.Assign> activity.

4. Enter your expression. If you enter a string, make sure to put quotation marks around the string. If you choose to bind the expression argument to a variable, leave the quotation marks off.

     When you are done, select a region or area outside of the Expression Editor to shift the focus to another part of the designer. This will cause the compiler to validate the expression as described previously.

     An Alternative way to enter/edit an expression is to click the ellipsis next to the property name in the property grid. This will open the **Expression Editor** as dialog box.

## See Also
 <xref:System.Activities.Presentation.View.ExpressionTextBox>