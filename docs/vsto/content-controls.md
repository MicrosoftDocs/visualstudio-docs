---
title: "Content Controls | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VST.Toolbox.DropDownListContentControl"
  - "VST.Toolbox.RichTextContentControl"
  - "VST.Toolbox.PlainTextContentControl"
  - "VST.Toolbox.ComboBoxContentControl"
  - "VST.Toolbox.CCBuildingBlockGalleryContentControl"
  - "VST.Toolbox.DatePickerContentControl"
  - "VST.Toolbox.PictureContentControl"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "document building blocks [Office development in Visual Studio]"
  - "restricted permissions [Office development in Visual Studio]"
  - "ComboBoxContentControl class"
  - "PictureContentControl class"
  - "PlainTextContentControl class"
  - "Office documents [Office development in Visual Studio], restricted permissions"
  - "RichTextContentControl class"
  - "content controls [Office development in Visual Studio]"
  - "building block gallery [Office development in Visual Studio]"
  - "controls [Office development in Visual Studio], content controls"
  - "GroupContentControl class"
  - "documents [Office development in Visual Studio], restricted permissions"
  - "DropDownListContentControl class"
  - "DatePickerContentControl class"
  - "data binding [Office development in Visual Studio], content controls"
  - "content controls [Office development in Visual Studio], about content controls"
  - "custom XML parts, content controls"
  - "templates [Office development in Visual Studio], content controls"
  - "BuildingBlockGalleryContentControl class"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Content Controls
  Content controls provide a way for you to design documents and templates that have these features:  
  
-   A user interface (UI) that has controlled input like a form.  
  
-   Restrictions that prevent users from editing protected sections of the document or template. For more information, see [Protecting Parts of Documents by Using Content Controls](#Protection).  
  
-   Data binding to a data source. For more information, see [Binding Data to Content Controls](#DataBinding).  
  
 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]  
  
 ![link to video](../vsto/media/playvideo.gif "link to video") For a related video demonstration, see [Binding Data to Word 2007 Content Controls Using Visual Studio Tools for the Office System (3.0)](http://go.microsoft.com/fwlink/?LinkId=136785).  
  
## Overview of Content Controls  
 Content controls provide a UI that is optimized for both user input and print. When you add a content control to a document, the control is identified by a border, a title, and temporary text that can provide instructions to the user. The border and the title of the control do not appear in printed versions of the document.  
  
 For example, if you want the user to enter a date in a section of your document, you can add a date picker content control to the document. When users click the control, the standard date picker UI appears. You can also set properties of the control to set the regional calendar that is displayed and to specify the date format. After the user chooses a date, the UI of the control is hidden, and only the date appears if the user prints the document.  
  
 Content controls also help you do the following:  
  
-   Prevent users from editing or deleting parts of a document. This is useful if you have information in a document or template that users should be able to read but not edit, or if you want users to be able to edit content controls but not delete them.  
  
-   Bind parts of a document or template to data. You can bind content controls to database fields, managed objects in the [!INCLUDE[dnprdnshort](../sharepoint/includes/dnprdnshort-md.md)], XML elements that are stored in the document, and other data sources.  
  
 In document-level projects, you can add content controls to your document at design time or at run time. In VSTO Add-in projects, you can add content controls to any open document at run time. For more information, see [How to: Add Content Controls to Word Documents](../vsto/how-to-add-content-controls-to-word-documents.md).  
  
> [!NOTE]  
>  You can use content controls only in documents that are saved in the Open XML Format. You cannot use content controls in documents that are saved in the Word 97-2003 document (.doc) format.  
  
## Types of Content Controls  
 There are nine different types of content controls that you can add to documents. Most of the content controls have a corresponding type in the <xref:Microsoft.Office.Tools.Word> namespace. You can also use a generic <xref:Microsoft.Office.Tools.Word.ContentControl>, which can represent any of the available content controls. For a walkthrough that demonstrates how to use each of the available content controls, see [Walkthrough: Creating a Template By Using Content Controls](../vsto/walkthrough-creating-a-template-by-using-content-controls.md).  
  
### Building Block Gallery  
 A building block gallery enables users to select from a list of *document building blocks* to insert into a document. A document building block is a piece of content that has been created to be used multiple times, such as a common cover page, a formatted table, or a header. For more information, see the <xref:Microsoft.Office.Tools.Word.BuildingBlockGalleryContentControl> type. For more information about building blocks, see [What's New for Developers in Word 2007](http://msdn.microsoft.com/en-us/74aa6688-65b3-4167-997d-131f26ad8f84).  
  
### Check Box  
 A check box provides a UI that represents a binary state: selected or cleared.  
  
 Unlike the other types of content controls, the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] does not provide a specific type that represents a check box content control. In other words, there is no CheckBoxContentControl type. However, you can still create a check box content control by adding a generic <xref:Microsoft.Office.Tools.Word.ContentControl> to a document programmatically. For more information, see [Check Box Content Controls in Word Projects](#checkbox).  
  
### Combo Box  
 A combo box displays a list of items that users can select. Unlike a drop-down list, the combo box enables users to add their own items. For more information, see the <xref:Microsoft.Office.Tools.Word.ComboBoxContentControl> type.  
  
### Date Picker  
 A date picker provides a calendar UI for selecting a date. The calendar appears when the end user clicks the drop-down arrow in the control. You can use regional calendars and different date formats. For more information, see the <xref:Microsoft.Office.Tools.Word.DatePickerContentControl> type.  
  
### Drop-Down List  
 A drop-down list displays a list of items that users can select. Unlike a combo box, the drop-down list does not let users add or edit items. For more information, see the <xref:Microsoft.Office.Tools.Word.DropDownListContentControl> type.  
  
### Group  
 A group control defines a protected region of a document that users cannot edit or delete. A group control can contain any document items, such as text, tables, graphics, and other content controls. For more information, see the <xref:Microsoft.Office.Tools.Word.GroupContentControl> type.  
  
### Picture  
 A picture control displays an image. You can specify the image at design time or run time, or users can click this control to select an image to insert in the document. For more information, see the <xref:Microsoft.Office.Tools.Word.PictureContentControl> type.  
  
### Rich Text  
 A rich text control contains text or other items, such as tables, pictures, or other content controls. For more information, see the <xref:Microsoft.Office.Tools.Word.RichTextContentControl> type.  
  
### Plain Text  
 A plain text control contains text. A plain text control cannot contain other items, such as tables, pictures, or other content controls. In addition, all of the text in a plain text control has the same formatting. For example, if you italicize one word of a sentence that is in a plain text control, all the text inside the control is italicized. For more information, see the <xref:Microsoft.Office.Tools.Word.PlainTextContentControl> type.  
  
### Generic Content Control  
 A generic content control is a <xref:Microsoft.Office.Tools.Word.ContentControl> object that can represent any of the available types of content controls. You can change a <xref:Microsoft.Office.Tools.Word.ContentControl> object to behave like a different type of content control by using the <xref:Microsoft.Office.Tools.Word.ContentControl.Type%2A> property. For example, if you create a <xref:Microsoft.Office.Tools.Word.ContentControl> object that represents a plain text control, you can change it at run time so that it behaves like a combo box.  
  
 You can create <xref:Microsoft.Office.Tools.Word.ContentControl> objects only at run time, not at design time. For more information, see [How to: Add Content Controls to Word Documents](../vsto/how-to-add-content-controls-to-word-documents.md).  
  
## Common Features of Content Controls  
 Most content controls share a set of members that you can use to perform common tasks. The following table describes some of the tasks that you can perform by using these members.  
  
|For this task:|Do this:|  
|--------------------|--------------|  
|Get or set the text that is displayed in the control.|Use the **Text** property. **Note:**  The <xref:Microsoft.Office.Tools.Word.PictureContentControl> and <xref:Microsoft.Office.Tools.Word.ContentControl> types do not have this property.|  
|Get or set the temporary text that is displayed in the control until a user edits the control, the control is populated with data from a data source, or the control's contents are deleted.|Use the **PlaceholderText** property. **Note:**  The <xref:Microsoft.Office.Tools.Word.PictureContentControl> type does not have this property.|  
|Get or set the title that is displayed in the border of the content control when the user clicks it.|Use the **Title** property.|  
|Remove the control from the document automatically after the user edits the control. (The text in the control remains in the document.)|Use the **Temporary** property.|  
|Run code when the user clicks in the content control, or when the cursor is moved into the content control programmatically.|Handle the <xref:Microsoft.Office.Tools.Word.ContentControlBase.Entering> event of the control.|  
|Run code when the user clicks outside the content control, or when the cursor is moved outside the content control programmatically.|Handle the <xref:Microsoft.Office.Tools.Word.ContentControlBase.Exiting> event of the control.|  
|Run code after the content control is added to the document as a result of a redo or undo operation.|Handle the <xref:Microsoft.Office.Tools.Word.ContentControlBase.Added> event of the control.|  
|Run code just before the content control is deleted from the document.|Handle the <xref:Microsoft.Office.Tools.Word.ContentControlBase.Deleting> event of the control.|  
  
##  <a name="Protection"></a> Protecting Parts of Documents By Using Content Controls  
 When you protect a part of a document, you prevent users from changing or deleting the content in that part of the document. There are several ways you can protect parts of a document by using content controls.  
  
 If the area you want to protect is inside a content control, you can use properties of the content control to prevent users from editing or deleting the control:  
  
-   The **LockContents** property prevents users from editing the contents.  
  
-   The **LockContentControl** property prevents users from deleting the control.  
  
 If the area you want to protect is not inside a content control, or if you want to protect an area that contains content controls and other types of content, you can put the whole area in a <xref:Microsoft.Office.Tools.Word.GroupContentControl>. Unlike other content controls, a <xref:Microsoft.Office.Tools.Word.GroupContentControl> provides no UI that is visible to the user. Its only purpose is to define a region that users cannot edit.  
  
> [!NOTE]  
>  If you create a <xref:Microsoft.Office.Tools.Word.GroupContentControl> that contains embedded content controls, the embedded content controls are not automatically protected. You must use the **LockContents** property of each embedded control to prevent users from editing their contents.  
  
 For more information about how to use content controls to protect parts of documents, see [How to: Protect Parts of Documents by Using Content Controls](../vsto/how-to-protect-parts-of-documents-by-using-content-controls.md).  
  
##  <a name="DataBinding"></a> Binding Data to Content Controls  
 You can display data in documents by binding a content control to a data source. When the data source is updated, the content control reflects the changes. You can also save changes back to the data source.  
  
 Content controls provide the following data binding options:  
  
-   You can bind content controls to database fields or managed objects by using the same data binding model as Windows Forms.  
  
-   You can bind content controls to elements in pieces of XML (also named *custom XML parts*) that are embedded in the document.  
  
 For an overview of binding host controls in Office solutions to data, see [Binding Data to Controls in Office Solutions](../vsto/binding-data-to-controls-in-office-solutions.md).  
  
### Using the Windows Forms Data Binding Model  
 Most content controls support the simple data binding model that Windows Forms uses. Simple data binding means that a control is bound to a single data element, such as a value in a column of a data table. For more information, see [Data Binding and Windows Forms](/dotnet/framework/winforms/data-binding-and-windows-forms).  
  
 In document-level projects, you can bind data to content controls by using the **Data Sources** window in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. For more information about how to add data-bound content controls to documents, see [How to: Populate Documents with Data from a Database](../vsto/how-to-populate-documents-with-data-from-a-database.md) and [How to: Populate Documents with Data from Objects](../vsto/how-to-populate-documents-with-data-from-objects.md).  
  
 The following table lists the content controls that you can bind to each data type in the **Data Sources** window.  
  
|Data type|Default content control|Other content controls that can be bound to this data type|  
|---------------|-----------------------------|----------------------------------------------------------------|  
|<xref:System.Boolean><br /><br /> <xref:System.Byte><br /><br /> <xref:System.Char><br /><br /> <xref:System.Double><br /><br /> <xref:System.Enum><br /><br /> <xref:System.Guid><br /><br /> <xref:System.Int16><br /><br /> <xref:System.Int32><br /><br /> <xref:System.Int64><br /><br /> <xref:System.SByte><br /><br /> <xref:System.Single><br /><br /> <xref:System.String><br /><br /> <xref:System.TimeSpan><br /><br /> <xref:System.UInt16><br /><br /> <xref:System.UInt32><br /><br /> <xref:System.UInt64>|<xref:Microsoft.Office.Tools.Word.PlainTextContentControl>|<xref:Microsoft.Office.Tools.Word.BuildingBlockGalleryContentControl><br /><br /> <xref:Microsoft.Office.Tools.Word.ComboBoxContentControl><br /><br /> <xref:Microsoft.Office.Tools.Word.DatePickerContentControl><br /><br /> <xref:Microsoft.Office.Tools.Word.RichTextContentControl>|  
|<xref:System.DateTime>|<xref:Microsoft.Office.Tools.Word.DatePickerContentControl>|<xref:Microsoft.Office.Tools.Word.BuildingBlockGalleryContentControl><br /><br /> <xref:Microsoft.Office.Tools.Word.ComboBoxContentControl><br /><br /> <xref:Microsoft.Office.Tools.Word.PlainTextContentControl><br /><br /> <xref:Microsoft.Office.Tools.Word.RichTextContentControl>|  
|<xref:System.Drawing.Image><br /><br /> <xref:System.Byte> array|<xref:Microsoft.Office.Tools.Word.PictureContentControl>|None|  
  
 In document-level and VSTO Add-in projects, you can bind a content control to a data source programmatically by using the <xref:System.Windows.Forms.ControlBindingsCollection.Add%2A> method of the <xref:System.Windows.Forms.IBindableComponent.DataBindings%2A> property of the control. If you do this, pass in the string **Text** to the *propertyName* parameter of the <xref:System.Windows.Forms.ControlBindingsCollection.Add%2A> method. The **Text** property is the default data binding property of content controls.  
  
 Content controls also support two-way data binding, in which changes in the control are updated to the data source. For more information, see [How to: Update a Data Source with Data from a Host Control](../vsto/how-to-update-a-data-source-with-data-from-a-host-control.md).  
  
> [!NOTE]  
>  Content controls do not support complex data binding. If you bind a <xref:Microsoft.Office.Tools.Word.DropDownListContentControl> or <xref:Microsoft.Office.Tools.Word.ComboBoxContentControl> to a data source by using the Windows Forms data model, users will see only a single value when they click the control. If you want to bind these controls to a set of data values that users can choose from, you can bind these controls to elements in a custom XML part.  
  
### Binding Content Controls to Custom XML Parts  
 You can bind some content controls to elements in custom XML parts that are embedded in the document. For more information about custom XML parts, see [Custom XML Parts Overview](../vsto/custom-xml-parts-overview.md).  
  
 To bind a content control to an element in a custom XML part, use the **XMLMapping** property of the control. The following code example demonstrates how to bind a <xref:Microsoft.Office.Tools.Word.PlainTextContentControl> to the `Price` element under the `Product` node in a custom XML part that has already been added to the document.  
  
```vb  
plainTextContentControl1.XMLMapping.SetMapping("/Product/Price")  
```  
  
```csharp  
plainTextContentControl1.XMLMapping.SetMapping("/Product/Price", String.Empty, null);  
```  
  
 For a walkthrough that demonstrates how to bind content controls to custom XML parts in more detail, see [Walkthrough: Binding Content Controls to Custom XML Parts](../vsto/walkthrough-binding-content-controls-to-custom-xml-parts.md).  
  
 When you bind a content control to a custom XML part, two-way data binding is automatically enabled. If a user edits text in the control, the corresponding XML elements are automatically updated. Similarly, if element values in the custom XML parts are changed, the content controls that are bound to the XML elements will display the new data.  
  
 You can bind the following types of content controls to custom XML parts:  
  
-   <xref:Microsoft.Office.Tools.Word.ComboBoxContentControl>  
  
-   <xref:Microsoft.Office.Tools.Word.DatePickerContentControl>  
  
-   <xref:Microsoft.Office.Tools.Word.DropDownListContentControl>  
  
-   <xref:Microsoft.Office.Tools.Word.PictureContentControl>  
  
-   <xref:Microsoft.Office.Tools.Word.PlainTextContentControl>  
  
### Data Binding Events for Content Controls  
 All content controls provide a set of events that you can handle to perform data-related tasks, such as validating that the text in a control meets certain criteria before the data source is updated. The following table lists the content control events that are related to data binding.  
  
|Task|Event|  
|----------|-----------|  
|Run code just before Word automatically updates the text in a content control that is bound to a custom XML part.|<xref:Microsoft.Office.Tools.Word.ContentControlBase.ContentUpdating>|  
|Run code just before Word automatically updates data in a custom XML part that is bound to a content control (that is, after the text in the content control changes).|<xref:Microsoft.Office.Tools.Word.ContentControlBase.StoreUpdating>|  
|Run your own code to validate the contents of the control according to custom criteria.|<xref:Microsoft.Office.Tools.Word.ContentControlBase.Validating>|  
|Run code after the contents of the control have been successfully validated.|<xref:Microsoft.Office.Tools.Word.ContentControlBase.Validated>|  
  
## Limitations of Content Controls  
 When you use content controls in your Office projects, be aware of the following limitations.  
  
### Behavior Differences Between Design Time and Run Time  
 Many of the limitations that Microsoft Office Word imposes on content controls at run time are not enforced at design time. When you design the UI of a document-level solution in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], be sure to modify content controls only in ways that are supported at run time.  
  
 If you modify a content control at design time in a way that the control does not support at run time, the [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] designer will not alert you of the unsupported changes. However, when you debug or run the project, or if you save and then reopen the project, Word will display an error message and request permission to repair the document. When you repair the document, Word removes all unsupported content and formatting from the control.  
  
 For example, Word does not prevent you from adding a table to a <xref:Microsoft.Office.Tools.Word.PlainTextContentControl> at design time. However, because <xref:Microsoft.Office.Tools.Word.PlainTextContentControl> objects cannot contain tables at run time, Word will display an error message when the document is opened.  
  
 Also note that many properties that define the behavior of content controls have no effect at design time. For example, if you set the **LockContents** property of a content control to **True** at design time, you can still edit text in the control in the [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] designer. This property only prevents users from editing the control at run time.  
  
### Event Limitations  
 Content controls do not provide an event that is raised when the user changes text or other items in the control. For example, there is no event that is raised when a user selects a different item in a <xref:Microsoft.Office.Tools.Word.DropDownListContentControl> or <xref:Microsoft.Office.Tools.Word.ComboBoxContentControl>.  
  
 To determine when a user edits the contents of a content control, you can bind the control to a custom XML part, and then handle the <xref:Microsoft.Office.Tools.Word.ContentControlBase.StoreUpdating> event. This event is raised when the user changes the contents of a control that is bound to a custom XML part. For a walkthrough that demonstrates how to bind a content control to a custom XML part, see [Walkthrough: Binding Content Controls to Custom XML Parts](../vsto/walkthrough-binding-content-controls-to-custom-xml-parts.md).  
  
###  <a name="checkbox"></a> Check Box Content Controls in Word Projects  
 Word 2010 introduced a new type of content control that represents a check box. However, the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] does not provide a corresponding CheckBoxContentControl type for you to use in Office projects. To create a check box content control in a [!INCLUDE[Word_15_short](../vsto/includes/word-15-short-md.md)] or Word 2010 project, use the <xref:Microsoft.Office.Tools.Word.ControlCollection.AddContentControl%2A> method to create a <xref:Microsoft.Office.Tools.Word.ContentControl> object, and pass the <xref:Microsoft.Office.Interop.Word.WdContentControlType.wdContentControlCheckBox> value to the method to specify a check box content control. The following code example demonstrates how to do this.  
  
 [!code-vb[Trin_ContentControlReference#800](../vsto/codesnippet/VisualBasic/trin_contentcontrolreference/checkbox.vb#800)]
 [!code-csharp[Trin_ContentControlReference#800](../vsto/codesnippet/CSharp/trin_wordcontentcontrolreference/checkbox.cs#800)]  
  
## See Also  
 [Automating Word by Using Extended Objects](../vsto/automating-word-by-using-extended-objects.md)   
 [How to: Add Content Controls to Word Documents](../vsto/how-to-add-content-controls-to-word-documents.md)   
 [Walkthrough: Creating a Template By Using Content Controls](../vsto/walkthrough-creating-a-template-by-using-content-controls.md)   
 [Data in Office Solutions](../vsto/data-in-office-solutions.md)   
 [Binding Data to Controls in Office Solutions](../vsto/binding-data-to-controls-in-office-solutions.md)   
 [Programmatic Limitations of Host Items and Host Controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)  
