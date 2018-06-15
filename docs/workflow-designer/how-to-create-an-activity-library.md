---
title: "Workflow Designer - How to: Create an Activity Library"
ms.date: 11/04/2016
ms.topic: conceptual
ms.prod: visual-studio-dev15
ms.technology: vs-workflow-designer
ms.assetid: 1eeebe74-7303-4345-8a83-fe37a26bc84b
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# How to: Create an Activity Library
Custom activities are used to model your particular business processes in a workflow. The Activity Library template in Visual Studio 2010 has been provided to enable you to create such custom activities visually using the Windows Workflow Designer.

### To create a Workflow Activity Library

1.  Start Visual Studio 2010.

2.  On the **File** menu, point to **New**, and then select **Project**.

     The **New Project** dialog box opens.

3.  In the **Project Types** pane, select **Workflow** from either the **Visual C#** projects or **Visual Basic** groupings depending on your language preference.

4.  In the **Templates** pane, select **Activity Library**.

5.  In the **Name** box, type in a descriptive name for your project to make it easy to identify.

6.  In the **Location** box, type in the directory in which you want to save your project or click **Browse** to navigate to it.

7.  In the **Solution** box, type in a descriptive name for your solution, then click **OK**.

    > [!NOTE]
    > If you want to add a workflow console application to an existing solution, open that solution in Visual Studio 2010, right click the solution in **Solution Explorer**, and select **Add**, then **New Project** to open the **New Project** dialog box. Proceed as described above in this procedure.

8.  The project template creates an activity definition in XAML. Windows Workflow Designer opens and displays the canvas for your custom activity.

9. Drag an activity from the **Toolbox** to the design surface to include it in your custom activity.

    > [!CAUTION]
    > You are allowed only one child activity in the body of your custom activity; however, that child activity could be a composite activity, such as a <xref:System.Activities.Statements.Sequence> activity or <xref:System.Activities.Statements.Flowchart> activity.

## See also

- [How to: Create an Activity](/dotnet/framework/windows-workflow-foundation/how-to-create-an-activity)
- [Creating a Workflow Project](../workflow-designer/creating-a-workflow-project.md)