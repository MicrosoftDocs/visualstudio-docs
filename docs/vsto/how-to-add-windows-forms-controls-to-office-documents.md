---
title: "How to: Add Windows forms controls to Office documents"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office documents [Office development in Visual Studio, Windows Forms controls"
  - "Windows Forms controls [Office development in Visual Studio], adding"
  - "controls [Office development in Visual Studio], Windows Forms controls"
  - "documents [Office development in Visual Studio], Windows Forms controls"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Add Windows Forms controls to Office documents
  You can add Windows Forms controls to Microsoft Office Excel and Microsoft Office Word documents at design time in document-level projects. At run time, you can add controls in document-level customizations and in VSTO Add-ins. For example, you can add a <xref:Microsoft.Office.Tools.Excel.Controls.ComboBox> control to your worksheet so that users can select from a list of options.

 [!INCLUDE[appliesto_controls](../vsto/includes/appliesto-controls-md.md)]

 This topic describes the following tasks:

- [Add controls at design time](#designtime)

- [Add controls at run time in document-level projects](#runtimedoclevel)

- [Add controls at run time in VSTO Add-ins](#runtimeaddin)

## <a name="designtime"></a> Add controls at design time
 There are several ways to add Windows Forms controls to the document in a document-level project at design time.

 [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

### To drag a Windows Forms control to the document

1. Create or open an Excel Workbook project or Word Document project in Visual Studio so that the document is visible in the designer. For information on creating projects, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

2. In the **Common Controls** tab of the **Toolbox**, click the control you want to add, and drag it to the document.

    > [!NOTE]
    > When you select a control in Excel, you will see **=EMBED("WinForms.Control.Host","")** in the **Formula Bar**. This text is necessary and should not be deleted.

### To draw a Windows Forms control on the document

1. Create or open an Excel Workbook project or Word Document project in Visual Studio so that the document is visible in the designer. For information on creating projects, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

2. In the **Common Controls** tab of the **Toolbox**, click the control you want to add.

3. On the document, click where you want the upper-left corner of the control to be located, and drag to where you want the lower-right corner of the control to be located.

     The control is added to the document with the specified location and size.

    > [!NOTE]
    > When you select a control in Excel, you will see **=EMBED("WinForms.Control.Host","")**  in the **Formula Bar**. This text is necessary and should not be deleted.

### To add a Windows Forms control to the document by single-clicking the control

1. Create or open an Excel Workbook project or Word Document project in Visual Studio so that the document is visible in the designer. For information on creating projects, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

2. In the **Common Controls** tab of the **Toolbox**, click the control you want to add

3. One the document, click where you want the control to be added.

     The control is added to the document with the default size.

    > [!NOTE]
    > When you select a control in Excel, you will see **=EMBED("WinForms.Control.Host","")** in the **Formula Bar**. This text is necessary and should not be deleted.

### To add a Windows Forms control to the document by double-clicking the control

1. Create or open an Excel Workbook project or Word Document project in Visual Studio so that the document is visible in the designer. For information on creating projects, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

2. In the **Common Controls** tab of the **Toolbox**, double-click the control you want to add.

     The control is added to the document at the center of the document or active pane.

    > [!NOTE]
    > When you select a control in Excel, you will see **=EMBED("WinForms.Control.Host","")** in the **Formula Bar**. This text is necessary and should not be deleted.

### To add a Windows Forms control to the document by pressing the Enter key

1. Create or open an Excel Workbook project or Word Document project in Visual Studio so that the document is visible in the designer. For information on creating projects, see [How to: Create Office Projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

2. In the **Common Controls** tab of the **Toolbox**, click the control you want to add, and press the **Enter** key.

     The control is added to the document at the center of the document or active pane.

    > [!NOTE]
    > When you select a control in Excel, you will see **=EMBED("WinForms.Control.Host","")** in the **Formula Bar**. This text is necessary and should not be deleted.

## <a name="runtimedoclevel"></a> Add controls at run time in document-level projects
 You can programmatically add Windows Forms controls to a document at run time. In Word, use methods of the <xref:Microsoft.Office.Tools.Word.DocumentBase.Controls%2A> property of the `ThisDocument` class. In Excel, use methods of the <xref:Microsoft.Office.Tools.Excel.WorksheetBase.Controls%2A> property of a `Sheet`*n* class. Each method has several overloads that enable you to specify the location of the control in different ways.

 When you add a Windows Forms control to a document at run time, the control is not persisted in the document when the document is closed. You can recreate the control the next time the document is opened. For more information, see [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md).

### To add a Windows Forms control at run time

1. Use a method that has the name Add\<*control class*> (where *control class* is the class name of the Windows Forms control that you want to add, such as <xref:Microsoft.Office.Tools.Word.ControlExtensions.AddButton%2A>).

     The following code example demonstrates how to add a <xref:Microsoft.Office.Tools.Excel.Controls.Button> to cell **C5** of `Sheet1` in a document-level project for Excel.

     [!code-vb[Trin_VstcoreProgrammingControlsExcel#4](../vsto/codesnippet/VisualBasic/my excel chart/Sheet1.vb#4)]
     [!code-csharp[Trin_VstcoreProgrammingControlsExcel#4](../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingControlsExcelCS/Sheet1.cs#4)]

## <a name="runtimeaddin"></a> Add controls at run time in VSTO Add-ins
 You can add Windows Forms controls programmatically to any open document at run time. First, generate a host item that is based on an open document or worksheet. Then, in Word, use methods of the <xref:Microsoft.Office.Tools.Word.Document.Controls%2A> property of the new host item. In Excel, use methods of the <xref:Microsoft.Office.Tools.Excel.Worksheet.Controls%2A> property of the new host item. Each method has several overloads that enable you to specify the location of the control in different ways.

 When you add a Windows Forms control to a document at run time, the control is not persisted in the document when the document is closed. You can recreate the control the next time the document is opened. For more information, see [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md).

 For more information about generating host items in VSTO Add-in projects, see [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).

### To add a Windows Forms control at run time

1. Use a method that has the name Add\<*control class*> (where *control class* is the class name of the Windows Forms control that you want to add, such as <xref:Microsoft.Office.Tools.Word.ControlExtensions.AddButton%2A>).

    > [!NOTE]
    > In VSTO Add-in projects that target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later, you must add a reference to the *Microsoft.Office.Tools.Excel.v4.0.Utilities.dll* or *Microsoft.Office.Tools.Word.v4.0.Utilities.dll* assembly before you can access the Add\<*control class*> methods.

     The following code example demonstrates how to add a <xref:Microsoft.Office.Tools.Word.Controls.Button> to the first paragraph of the active document by using a Word VSTO Add-in.

     [!code-vb[Trin_WordAddInDynamicControls#7](../vsto/codesnippet/VisualBasic/trin_wordaddindynamiccontrols/ThisAddIn.vb#7)]
     [!code-csharp[Trin_WordAddInDynamicControls#7](../vsto/codesnippet/CSharp/Trin_WordAddInDynamicControls/ThisAddIn.cs#7)]

## See also
- [Windows Forms controls on Office documents overview](../vsto/windows-forms-controls-on-office-documents-overview.md)
- [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md)
- [How to: Resize controls within worksheet cells](../vsto/how-to-resize-controls-within-worksheet-cells.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
