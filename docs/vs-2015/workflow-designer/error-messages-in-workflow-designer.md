---
title: "Error Messages in Workflow Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "WFDErrorMessages.UI"
  - "System.Activities.Presentation.ErrorActivity.UI"
  - "System.Activities.Presentation.View.ErrorView.UI"
ms.assetid: 4d8bbc2e-34fc-477f-9140-4adfd70c34a0
caps.latest.revision: 5
author: jillre
ms.author: jillfra
manager: jillfra
---
# Error Messages in Workflow Designer
This topic describes the types of error messages that can be encountered when working with [!INCLUDE[wfd1](../includes/wfd1-md.md)].

## Situations in which Errors in the Workflow Designer Occur
 Errors in [!INCLUDE[wfd2](../includes/wfd2-md.md)] occur in the following situations:

1. There is an error in an expression.

2. The validation constraints of an activity have not been satisfied.

3. There are errors in the XAML file that cause an activity to fail to load.

4. There are errors in the XAML file that cause the workflow to fail to load.

   Invalid expressions and unsatisfied validation constraints do not cause the workflow to fail to build. Building your workflow succeeds, but an <xref:System.Activities.InvalidWorkflowException> is thrown at runtime. If there are errors in the XAML file, the build fails.

   Inside [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], when a workflow is loaded, its errors are displayed in the **Error List**. To navigate to the activity that is the source of the error, double-click the error in the **Error List**.

### Expression Errors
 An invalid expression is denoted by a red circle with a white exclamation point next to the expression. Hovering over this icon displays a tooltip that describes the source of the error. Inside [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], click the expression to view the line that underlines the source of the error. Hovering over lined text displays a tooltip that describes the source of the error.

### Activity Validation Errors
 When the validation constraints of an activity have not been satisfied, a red circle with a white exclamation point appears in the top right corner of the activity. Hovering over this icon displays a tooltip that describes the source of the error.

### XAML Load Errors
 When an activity fails to load, a red box with the text “Activity could not be loaded because of errors in the XAML” appears. This typically occurs when the activity’s type cannot be resolved. The invalid activity can be deleted in the designer by selecting the red box and deleting it.

### Workflow Load Errors
 When a workflow fails to load, the text “Workflow Designer encountered problems with your document” appears on the designer surface, along with the exception information that caused the failure of the workflow to load. This typically occurs when the XAML file cannot be parsed.