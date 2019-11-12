---
title: "How to: Manage control layout on actions panes"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "actions panes [Office development in Visual Studio], control layout"
  - "controls [Office development in Visual Studio], layout on actions panes"
  - "smart documents [Office development in Visual Studio], control layout"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Manage control layout on actions panes
  An actions pane is docked to the right of a document or worksheet by default; however, it can be docked to the left, top, or bottom. If you are using multiple user controls, you can write code to properly stack the user controls on the actions pane. For more information, see [Actions pane overview](../vsto/actions-pane-overview.md).

 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]

 The stack order of the controls depends on whether the actions pane is docked vertically or horizontally.

> [!NOTE]
> If the user resizes the actions pane at run time, you can set the controls to resize with the actions pane. You can use the <xref:System.Windows.Forms.Control.Anchor%2A> property of a Windows Forms control to anchor controls to the actions pane. For more information, see [How to: Anchor controls on Windows Forms](/dotnet/framework/winforms/controls/how-to-anchor-controls-on-windows-forms).

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## To set the stack order of the actions pane controls

1. Open a document-level project for Microsoft Office Word that includes an actions pane with multiple user controls or nested actions pane controls. For more information, see [How to: Add an actions pane to Word documents or Excel workbooks](../vsto/how-to-add-an-actions-pane-to-word-documents-or-excel-workbooks.md).

2. Right-click **ThisDocument.cs** or **ThisDocument.vb** in **Solution Explorer** and then click **View Code**.

3. In the <xref:Microsoft.Office.Tools.ActionsPane.OrientationChanged> event handler of the actions pane, check if the orientation of the actions pane is horizontal.

     [!code-csharp[Trin_VstcoreActionsPaneWord#30](../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/ThisDocument.cs#30)]
     [!code-vb[Trin_VstcoreActionsPaneWord#30](../vsto/codesnippet/VisualBasic/Trin_VstcoreActionsPaneWordVB/ThisDocument.vb#30)]

4. If the orientation is horizontal, stack the action pane controls from the left; otherwise, stack them from the top.

     [!code-csharp[Trin_VstcoreActionsPaneWord#31](../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/ThisDocument.cs#31)]
     [!code-vb[Trin_VstcoreActionsPaneWord#31](../vsto/codesnippet/VisualBasic/Trin_VstcoreActionsPaneWordVB/ThisDocument.vb#31)]

5. In C#, you must add an event handler for the `ActionsPane` to the <xref:Microsoft.Office.Tools.Word.Document.Startup> event handler. For information about creating event handlers, see [How to: Create event handlers in Office projects](../vsto/how-to-create-event-handlers-in-office-projects.md).

     [!code-csharp[Trin_VstcoreActionsPaneWord#32](../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/ThisDocument.cs#32)]

6. Run the project and verify that the actions pane controls are stacked left to right when the actions pane is docked at the top of the document, and the controls are stacked from top to bottom when the actions pane is docked at the right side of the document.

## Example
 [!code-csharp[Trin_VstcoreActionsPaneWord#29](../vsto/codesnippet/CSharp/Trin_VstcoreActionsPaneWordCS/ThisDocument.cs#29)]
 [!code-vb[Trin_VstcoreActionsPaneWord#29](../vsto/codesnippet/VisualBasic/Trin_VstcoreActionsPaneWordVB/ThisDocument.vb#29)]

## Compile the code
 This example requires:

- A Word document-level project with an actions pane that contains multiple user controls or nested actions pane controls.

## See also
- [Actions pane overview](../vsto/actions-pane-overview.md)
- [How to: Add an actions pane to Word documents or Excel workbooks](../vsto/how-to-add-an-actions-pane-to-word-documents-or-excel-workbooks.md)
- [How to: Add an actions Pane to Word Documents or Excel workbooks](../vsto/how-to-add-an-actions-pane-to-word-documents-or-excel-workbooks.md)
- [Walkthrough: Insert text into a document from an actions pane](../vsto/walkthrough-inserting-text-into-a-document-from-an-actions-pane.md)
- [Walkthrough: Insert text into a document from an actions pane](../vsto/walkthrough-inserting-text-into-a-document-from-an-actions-pane.md)
