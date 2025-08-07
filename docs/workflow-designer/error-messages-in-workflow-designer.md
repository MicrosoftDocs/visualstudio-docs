---
title: Error Messages in Workflow Designer
description: Learn about the types of error messages that you can encounter when working with Workflow Designer.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- WFDErrorMessages.UI
- System.Activities.Presentation.ErrorActivity.UI
- System.Activities.Presentation.View.ErrorView.UI
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Error Messages in Workflow Designer

This topic describes the types of error messages that can be encountered when working with Workflow Designer.

## Situations in which Errors in the Workflow Designer Occur

Errors in Workflow Designer occur in the following situations:

1. There is an error in an expression.

2. The validation constraints of an activity have not been satisfied.

3. There are errors in the XAML file that cause an activity to fail to load.

4. There are errors in the XAML file that cause the workflow to fail to load.

Invalid expressions and unsatisfied validation constraints do not cause the workflow to fail to build. Building your workflow succeeds, but an <xref:System.Activities.InvalidWorkflowException> is thrown at run time. If there are errors in the XAML file, the build fails.

Inside Visual Studio, when a workflow is loaded, its errors are displayed in the **Error List**. To navigate to the activity that is the source of the error, double-click the error in the **Error List**.

### Expression Errors
 An invalid expression is denoted by a red circle with a white exclamation point next to the expression. Hovering over this icon displays a tooltip that describes the source of the error. Inside Visual Studio, click the expression to view the line that underlines the source of the error. Hovering over lined text displays a tooltip that describes the source of the error.

### Activity Validation Errors
 When the validation constraints of an activity have not been satisfied, a red circle with a white exclamation point appears in the top right corner of the activity. Hovering over this icon displays a tooltip that describes the source of the error.

### XAML Load Errors
 When an activity fails to load, a red box with the text "Activity could not be loaded because of errors in the XAML" appears. This typically occurs when the activity's type cannot be resolved. The invalid activity can be deleted in the designer by selecting the red box and deleting it.

### Workflow Load Errors
 When a workflow fails to load, the text "Workflow Designer encountered problems with your document" appears on the designer surface, along with the exception information that caused the failure of the workflow to load. This typically occurs when the XAML file cannot be parsed.
