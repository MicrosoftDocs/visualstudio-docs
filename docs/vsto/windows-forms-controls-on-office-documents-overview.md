---
title: "Windows Forms Controls on Office Documents Overview | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "old data showing in error [Office development in Visual Studio]"
  - "Windows Forms controls [Office development in Visual Studio], Word"
  - "Windows Forms controls [Office development in Visual Studio], adding"
  - "Windows Forms controls [Office development in Visual Studio], arranging"
  - "data [Office development in Visual Studio], old data showing in error"
  - "user controls [Office development in Visual Studio], Windows Forms"
  - "Windows Forms controls [Office development in Visual Studio]"
  - "Windows Forms controls [Office development in Visual Studio], removing"
  - "application development [Office development in Visual Studio], Windows Forms controls"
  - "controls [Office development in Visual Studio], Windows Forms controls"
  - "Office [Office development in Visual Studio], Windows Forms controls"
  - "Office documents [Office development in Visual Studio, controls"
  - "documents [Office development in Visual Studio], Windows Forms controls"
  - "document-level customizations [Office development in Visual Studio], Windows Forms controls"
  - "Windows Forms controls [Office development in Visual Studio], about Windows Forms controls"
  - "Office applications [Office development in Visual Studio], Windows Forms"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Windows Forms Controls on Office Documents Overview
  Windows Forms controls are objects that users can interact with to enter or manipulate data. In document-level projects for Microsoft Office Excel and Microsoft Office Word, you can add Windows Forms controls to the document or workbook in your project at design time, or you can programmatically add these controls at run time. You can programmatically add these controls to any open document or worksheet at run time in an VSTO Add-in for Excel or Word.  
  
 For more information, see [How to: Add Windows Forms Controls to Office Documents](../vsto/how-to-add-windows-forms-controls-to-office-documents.md).  
  
 [!INCLUDE[appliesto_controls](../vsto/includes/appliesto-controls-md.md)]  
  
## Using Windows Forms Controls  
 You can add Windows Forms controls to documents and to customizable user interface (UI) elements, including actions panes, custom task panes, and Windows Forms. Windows Forms controls generally have the same behavior on documents as on these other UI elements, but some differences do exist. For information, see [Limitations of Windows Forms Controls on Office Documents](../vsto/limitations-of-windows-forms-controls-on-office-documents.md).  
  
 The decision whether to add Windows Forms controls to a document or some other UI element depends on several factors. When designing the UI of your solution, consider the uses of Windows Forms controls as described in the following table.  
  
 On a document.  
 -   When you want to display the controls 100% of the time.  
  
-   When you want users to enter data directly in the document, for example, in forms-based documents where the editing surface is locked.  
  
-   When you want the controls to display in line with the data in the document. For example, if you are adding buttons to each row of a list object, you would want them in line with each list item.  
  
 On the actions pane or a custom task pane.  
 -   When you want to provide contextual information to the user.  
  
-   When you want only the results to appear in the document, and not the query controls and data.  
  
-   When you want to ensure that the controls are not printed with the document.  
  
-   When you want to ensure that controls do not interfere with the view of the document.  
  
 On a Windows Form.  
 -   When you want to control the size of the UI.  
  
-   When you want to prevent users from hiding or deleting the controls.  
  
-   When you want to get input from the user, and prevent the user from doing anything in the document until the input is received.  
  
## Adding Windows Forms Controls Programmatically  
 You can add Windows Forms controls to Word documents and Excel worksheets at run time. The [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] provides helper methods for adding the most common Windows Forms controls. These helper methods enable you to quickly add controls to your Office document and access the combined Windows Forms control functionality and Office-related functionality of these controls.  
  
 For more information, see [Adding Controls to Office Documents at Run Time](../vsto/adding-controls-to-office-documents-at-run-time.md).  
  
## Using Windows Forms Controls in Document-Level Projects  
 Some aspects of using Windows Forms controls on documents are unique to document-level projects, which enable you to design the UI of your document by using the Visual Studio designer.  
  
### Creating Custom User Controls  
 You can add a user control to your project and then add it to the **Toolbox**. You can then drag the user control directly to your document in the same way you would add a Windows Forms control to your document. There are some things to keep in mind when you create user controls:  
  
-   Do not create a **sealed** user control. When you drag the control to your document, Visual Studio generates a wrapper class derived from the user control to extend it and support its use on the document. If the user control is **sealed**, Visual Studio cannot generate the wrapper class.  
  
-   User controls must have the <xref:System.Runtime.InteropServices.ComVisibleAttribute> attribute set to **true**. User controls created inside an Office project have this attribute set to **true** by default, but user controls that are part of outside projects might not have this attribute set to **true**.  
  
-   After you have added a user control to the document, do not rename or delete the <xref:System.Windows.Forms.UserControl> class from the project. If you need to change the name of a user control you must first delete it from the document, and then add it again after the name has been changed.  
  
### Arranging Controls at Design Time  
 If you add multiple controls to your Word and Excel documents at design time, you can quickly set the alignment of all of the selected controls by using the **Microsoft Office Word** and **Microsoft Office Excel** toolbars in Visual Studio. These toolbars are available only when a document or worksheet is open in the designer.  
  
 When you select multiple controls in the designer, you can use the following buttons on these toolbars to arrange the controls:  
  
-   **Align Lefts**  
  
-   **Align Centers**  
  
-   **Align Rights**  
  
-   **Align Tops**  
  
-   **Align Middles**  
  
-   **Align Bottoms**  
  
-   **Make Horizontal Spacing Equal**  
  
-   **Make Vertical Spacing Equal**  
  
> [!NOTE]  
>  In Word projects, these buttons are enabled only if the selected controls are not in line with text. By default, controls that you add to the document at design time are in line with text.  
  
### Preventing Old Data from Appearing in Excel Workbooks During Loading  
 When you add Windows Forms controls to documents or worksheets at design time, the controls remain in the document when the user closes the document. Controls added at design time are also called *static controls*.  
  
 When an Excel workbook that contains static controls is opened, the workbook displays a bitmap of the control in an ActiveX control until the customization code runs and loads the actual control. Excel creates this bitmap and stores it in the workbook whenever the workbook is saved. The bitmap shows the control as it appeared the last time the workbook was saved, including any data that the control was displaying. For more information about the ActiveX control that contains Windows Forms controls and bitmaps, see [Limitations of Windows Forms Controls on Office Documents](../vsto/limitations-of-windows-forms-controls-on-office-documents.md).  
  
 In certain conditions, the code does not load and only the bitmap is displayed, such as when the user opens the workbook in design mode. Also, if the user opens the workbook on a computer that does not have the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] installed, the customization cannot run to load the controls and therefore only the bitmap of the control is visible. You should always remove personal information from controls on workbooks before saving the workbook and sending it to another user to ensure that your personal information is not accidentally disclosed.  
  
### Matching Control Size to Cell Size on an Excel Worksheet  
 You can set the control to be resized automatically when the size of the parent cell is changed. For more information, see [How to: Resize Controls Within Worksheet Cells](../vsto/how-to-resize-controls-within-worksheet-cells.md).  
  
### Adding Components That Are Shared by All Worksheets  
 You can add components that you want to share among all worksheets, such as a <xref:System.Data.DataSet>, to the Workbook Designer instead of to the worksheets. The component will appear on the component tray.  
  
### Formula for Embedding Controls on an Excel Worksheet  
 When you select a control in Excel, you will see **=EMBED("WinForms.Control.Host","")** in the **Formula Bar**. This text is necessary and should not be deleted.  
  
### Layout Style of Controls on a Word Document  
 When you add a control to the Word document in a document-level project by using the Visual Studio designer, the control is added in line with text. To change the layout style of the control, right-click the control and then click **Format Control**. Select a wrapping style on the **Layout** page of the **Format Object** dialog box.  
  
 When you add a control to a Word document at run time, you can specify the layout style of the new control by using different `Add`\<*control class*> method overloads of the <xref:Microsoft.Office.Tools.Word.ControlCollection> class:  
  
-   To add the control in line with text, use an overload that accepts a <xref:Microsoft.Office.Interop.Word.Range> that specifies the location of the control.  
  
-   To add the control as a floating shape, use an overload that accepts the left and top coordinates of the control.  
  
 For more information, see [Adding Controls to Office Documents at Run Time](../vsto/adding-controls-to-office-documents-at-run-time.md).  
  
 If you open a Word template in the Visual Studio designer, non-inline controls on the template might not be visible because Visual Studio opens the template in **Normal** view. To view the controls, change the view to **Print Layout**.  
  
### Controls outside the Main Document Body  
 Windows Forms controls are not supported inside of a header or footer, or within a subdocument.  
  
### Adding Components at Design Time  
 Certain controls or components are not visible on the document and are instead displayed in a component tray. Visual Studio provides a component tray for each document window. The component tray appears on the screen only if components exist on the document.  
  
## See Also  
 [Controls on Office Documents](../vsto/controls-on-office-documents.md)   
 [Adding Controls to Office Documents at Run Time](../vsto/adding-controls-to-office-documents-at-run-time.md)   
 [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md)   
 [Actions Pane Overview](../vsto/actions-pane-overview.md)   
 [Windows Forms Controls](/dotnet/framework/winforms/controls/index)   
 [Limitations of Windows Forms Controls on Office Documents](../vsto/limitations-of-windows-forms-controls-on-office-documents.md)   
 [How to: Add Windows Forms Controls to Office Documents](../vsto/how-to-add-windows-forms-controls-to-office-documents.md)   
 [How to: Resize Controls Within Worksheet Cells](../vsto/how-to-resize-controls-within-worksheet-cells.md)   
 [How to: Hide Controls on Worksheets when Printing](../vsto/how-to-hide-controls-on-worksheets-when-printing.md)   
 [Walkthrough: Changing Worksheet Formatting Using CheckBox Controls](../vsto/walkthrough-changing-worksheet-formatting-using-checkbox-controls.md)   
 [Walkthrough: Changing Document Formatting Using CheckBox Controls](../vsto/walkthrough-changing-document-formatting-using-checkbox-controls.md)   
 [Walkthrough: Displaying Text in a Text Box in a Worksheet Using a Button](../vsto/walkthrough-displaying-text-in-a-text-box-in-a-worksheet-using-a-button.md)   
 [Walkthrough: Displaying Text in a Text Box in a Document Using a Button](../vsto/walkthrough-displaying-text-in-a-text-box-in-a-document-using-a-button.md)   
 [Limitations of Windows Forms Controls on Office Documents](../vsto/limitations-of-windows-forms-controls-on-office-documents.md)   
 [Walkthrough: Updating a Chart in a Document Using Radio Buttons](../vsto/walkthrough-updating-a-chart-in-a-document-using-radio-buttons.md)   
 [Walkthrough: Updating a Chart in a Worksheet Using Radio Buttons](../vsto/walkthrough-updating-a-chart-in-a-worksheet-using-radio-buttons.md)  
  
  