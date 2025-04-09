---
title: "Add a custom task pane to an application"
description: Add a custom task pane with controls to your Microsoft Office applications by using the Visual Studio Tools for Office (VSTO) Add-in.
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "task panes [Office development in Visual Studio], adding to application"
  - "custom task panes [Office development in Visual Studio], adding to application"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Add a custom task pane to an application




> [!IMPORTANT]
> The Actions feature has been retired from Microsoft Word starting in Office 2024.
> This feature is only available in Microsoft Word with the following releases of Office:
> - Microsoft 365
> - Office LTSC Professional Plus 2021
> - Office LTSC Standard 2021
> - Office Professional Plus 2016, 2019
> - Office Standard 2016, 2019

 

You can add a custom task pane to the applications listed above by using VSTO Add-in. For more information, see [Custom task panes](../vsto/custom-task-panes.md).

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## Add a custom task pane to an application

### To add a custom task pane to an application

1. Open or create a VSTO Add-in project for one of the applications listed above. For more information, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

2. On the **Project** menu, click **Add User Control**.

3. In the **Add New Item** dialog box, change the name of the new user control to **MyUserControl**, and then click **Add**.

     The user control opens in the designer.

4. Add one or more Windows Forms controls from the **Toolbox** to the user control.

5. Open the **ThisAddIn.cs** or **ThisAddIn.vb** code file.

6. Add the following code to the `ThisAddIn` class. This code declares instances of `MyUserControl` and <xref:Microsoft.Office.Tools.CustomTaskPane> as members of the `ThisAddIn` class.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_TaskPaneBasic/ThisAddIn.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_TaskPaneBasic/ThisAddIn.vb" id="Snippet1":::
     ---

7. Add the following code to the `ThisAddIn_Startup` event handler. This code creates a new <xref:Microsoft.Office.Tools.CustomTaskPane> by adding the `MyUserControl` object to the `CustomTaskPanes` collection. The code also displays the task pane.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_TaskPaneBasic/ThisAddIn.cs" id="Snippet2":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_TaskPaneBasic/ThisAddIn.vb" id="Snippet2":::
     ---

    > [!NOTE]
    > This code associates your custom task pane with the active window in the application. For some applications, you might want to modify this code to ensure that the task pane appears with other documents or items in the application. For more information, see [Custom task panes](../vsto/custom-task-panes.md).

## Related content
- [Office UI customization](../vsto/office-ui-customization.md)
- [Custom task panes](../vsto/custom-task-panes.md)
- [Walkthrough: Automate an application from a custom task pane](../vsto/walkthrough-automating-an-application-from-a-custom-task-pane.md)
