---
title: 'Workflow Designer - Add comments to a workflow'
description: Learn how .NET Framework 4.5 allows the developer to add annotations to the certain types of items in the designer, for example, Activity, State, and Transition items.
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords:
- System.Activities.Presentation.Annotations.Annotation.UI
- Annotation
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Add comments to a workflow in the Workflow Designer

To facilitate creating larger, more complicated workflows, .NET Framework 4.5 allows the developer to add annotations to the following types of item in the designer:

- <xref:System.Activities.Activity>

- <xref:System.Activities.Statements.State>

- <xref:System.Activities.Statements.Transition>

- Classes derived from <xref:System.Activities.Statements.FlowNode>

- <xref:System.Activities.Variable>

- <xref:System.Activities.Argument>

> [!IMPORTANT]
> The contents of an annotation are saved as plain text to the XAML file associated with the workflow, and could potentially be read by others. Be cautious when entering sensitive information into an annotation.

## Adding an annotation to an activity in the designer

1. In the workflow designer, right-click on an item in the workflow designer and select **Annotations**, **Add Annotation**.

1. Add the text of the annotation in the space provided.

   The item shows an annotation icon. Hovering over the annotation icon displays the text of the annotation.

## Displaying an annotation in an activity's designer

1. With an activity designer which has an annotation displaying outside the activity, click the **Pin** icon in the annotation adorner.

   The annotation is displayed in the activity's designer. In the screenshot below, the annotation "Starting activity in the workflow" is displayed in the activity's designer.

   ![Annotation shown in the activity designer](../workflow-designer/media/annotationindesigner.png)

2. To display the annotation outside the activity's designer, hover over the annotation area in the activity's designer and click the **Unpin** icon

   ![Annotation displayed outside an activity's designer](../workflow-designer/media/annotationoutsidedesigner.png)

## Showing or hiding all annotations

1. Right-click an activity that has an annotation. Select **Annotations**, **Show All Annotations**.

   All the annotations are displayed in the activity's designers.

1. To display all annotations outside the activity's designers, right-click on the activity and select **Annotations**, **Hide All Annotations**.

## Editing or deleting an annotation for an activity

1. Right-click on an activity that has an annotation.

1. Select **Annotations**, **Edit Annotation** or **Delete Annotation**.

   The annotation is opened for editing or deleted.

1. To delete all the annotations at once, right-click the workflow designer and select **Annotation**, **Delete All Annotations**.

## Adding, editing, and deleting an annotation for a variable or argument

1. Right-click on a variable or argument and select Add Annotation.

1. Enter the text of the annotation. The variable or argument displays an annotation icon.

1. Right-click on a variable or argument that has an annotation. Select Edit Annotation.

   The annotation is opened for editing.

1. Right-click on a variable or argument that has an annotation. Select Delete Annotation.

   The annotation is deleted.
