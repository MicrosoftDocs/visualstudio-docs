---
title: "Workflow Designer - How to: Create an Activity Designer Library"
ms.date: 11/04/2016
ms.topic: conceptual
ms.prod: visual-studio-dev15
ms.technology: vs-workflow-designer
ms.assetid: 5b62e092-63b3-462d-9d77-fb112482f45d
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# How to: Create an Activity Designer Library
Custom activity designers allow you to create a user interface for a standard or a custom activity. You control the complexity of the user interface and have the ability to create more than one activity designer for an activity. This scenario allows you to create designers that are tailored for multiple audiences.

## To create an Activity Designer Library

1.  Start Visual Studio 2010.

2.  On the **File** menu, point to **New**, and then select **Project** to open the **New Project** dialog box.

3.  In the **Project Types** pane, select **Workflow** from either the **Visual C#** or **Visual Basic** groupings depending on your preferred language.

4.  In the **Templates** pane, select **Activity Designer Library**.

5.  In the **Name** box, enter a descriptive name for your project to make it easy to identify.

6.  In the **Location** box, enter the directory in which you want to save your project, or click **Browse** to navigate to it.

7.  In the **Solution** box, type in a descriptive name for your solution, then click **OK**.

    > [!NOTE]
    > If you want to add a workflow console application to an existing solution, open that solution in Visual Studio 2010, right click on the solution in **Solution Explorer**, and select **Add**, then **New Project** to open the **New Project** dialog box. Proceed as described above in this procedure.

8.  The project template creates an activity designer definition in XAML and the code-behind implementation file in source code. The Windows Workflow Designer opens and displays the canvas for your activity designer.

9. Drag Windows Presentation Foundation (WPF) controls from the **Toolbox** to the design surface to use them in your custom activity designer.  For an example of how to implement a custom activity designer, see [How to: Create a Custom Activity Designer](/dotnet/framework/windows-workflow-foundation/how-to-create-a-custom-activity-designer).

    > [!WARNING]
    > Custom activity designers can be used for custom activities as well as for default .NET Framework 4activities.

## See also

- [Creating a Workflow Project](../workflow-designer/creating-a-workflow-project.md)