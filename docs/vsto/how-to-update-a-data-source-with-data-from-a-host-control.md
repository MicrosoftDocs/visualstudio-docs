---
title: "How to: Update a data source with data from a host control"
description: Learn how you can bind a host control to a data source and update the data source with the changes that are made to the data in the control.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "documents [Office development in Visual Studio], data source updates"
  - "data [Office development in Visual Studio], updating a data source from a document"
  - "host controls [Office development in Visual Studio], data source updates"
  - "Office documents [Office development in Visual Studio, data sources"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Update a data source with data from a host control
  You can bind a host control to a data source and update the data source with the changes that are made to the data in the control. There are two main steps in this process:

1. Update the in-memory data source with the modified data in the control. Typically, the in-memory data source is a <xref:System.Data.DataSet>, a <xref:System.Data.DataTable>, or some other data object.

2. Update the database with the changed data in the in-memory data source. This is applicable only if the data source is connected to a back-end database, such as a SQL Server or Microsoft Office Access database.

   For more information about host controls and data binding, see [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md) and [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md).

   [!INCLUDE[appliesto_controls](../vsto/includes/appliesto-controls-md.md)]

## Update the in-memory data source
 By default, host controls that enable simple data binding (such as content controls on a Word document or a named range control on an Excel worksheet) do not save data changes to the in-memory data source. That is, when an end user changes a value in a host control and then navigates away from the control, the new value in the control is not automatically saved to the data source.

 To save the data to the data source, you can write code that updates the data source in response to a specific event at run time, or you can configure the control to automatically update the data source when the value in the control changes.

 You do not need to save <xref:Microsoft.Office.Tools.Excel.ListObject> changes to the in-memory data source. When you bind a <xref:Microsoft.Office.Tools.Excel.ListObject> control to data, the <xref:Microsoft.Office.Tools.Excel.ListObject> control automatically saves changes to the in-memory data source without requiring additional code.

### To update the in-memory data source at run time

- Call the <xref:System.Windows.Forms.Binding.WriteValue%2A> method of the <xref:System.Windows.Forms.Binding> object that binds the control to the data source.

     The following example saves changes made to a <xref:Microsoft.Office.Tools.Excel.NamedRange> control on an Excel worksheet to the data source. This example assumes that you have a <xref:Microsoft.Office.Tools.Excel.NamedRange> control named `namedRange1` with its <xref:Microsoft.Office.Tools.Excel.NamedRange.Value2%2A> property bound to a field in a data source.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreDataExcelCS/Sheet1.cs" id="Snippet1":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreDataExcelVB/Sheet1.vb" id="Snippet1":::

### Automatically update the in-memory data source
 You can also configure a control so that it automatically updates the in-memory data source. In a document-level project, you can do this by using code or the designer. In a VSTO Add-in project, you must use code.

#### To set a control to automatically update the in-memory data source by using code

1. Use the System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged mode of the <xref:System.Windows.Forms.Binding> object that binds the control to the data source. There are two options for updating the data source:

   - To update the data source when the control is validated, set this property to System.Windows.Forms.DataSourceUpdateMode.OnValidation.

   - To update the data source when the value of the data-bound property of the control changes, set this property to System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged.

     > [!NOTE]
     > The System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged option does not apply to Word host controls, because Word does not offer document-change or control-change notifications. However, this option can be used for Windows Forms controls on Word documents.

     The following example configures a <xref:Microsoft.Office.Tools.Excel.NamedRange> control to automatically update the data source when the value in the control changes. This example assumes that you have a <xref:Microsoft.Office.Tools.Excel.NamedRange> control named `namedRange1` with its <xref:Microsoft.Office.Tools.Excel.NamedRange.Value2%2A> property bound to a field in a data source.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreDataExcelCS/Sheet1.cs" id="Snippet19":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreDataExcelVB/Sheet1.vb" id="Snippet19":::

#### To set a control to automatically update the in-memory data source by using the designer

1. In Visual Studio, open the Word document or Excel workbook in the designer.

2. Click the control that you want to automatically update the data source.

3. In the **Properties** window, expand the **(DataBindings)** property.

4. Next to the **(Advanced)** property, click the ellipsis button (![VisualStudioEllipsesButton screenshot](../vsto/media/vbellipsesbutton.png "VisualStudioEllipsesButton screenshot")).

5. In the **Formatting and Advanced Binding** dialog box, click the **Data Source Update Mode** drop-down list and select one of the following values:

    - To update the data source when the control is validated, select **OnValidation**.

    - To update the data source when the value of the data-bound property of the control changes, select **OnPropertyChanged**.

        > [!NOTE]
        > The **OnPropertyChanged** option does not apply to Word host controls, because Word does not offer document-change or control-change notifications. However, this option can be used for Windows Forms controls on Word documents.

6. Close the **Formatting and Advanced Binding** dialog box.

## Update the database
 If the in-memory data source is associated with a database, you must update the database with the changes to the data source. For more information about updating a database, see [Save data back to the database](../data-tools/save-data-back-to-the-database.md)  and [Update data by using a TableAdapter](../data-tools/update-data-by-using-a-tableadapter.md) .

### To update the database

1. Call the <xref:System.Windows.Forms.BindingSource.EndEdit%2A> method of the <xref:System.Windows.Forms.BindingSource> for the control.

     The <xref:System.Windows.Forms.BindingSource> is automatically generated when you add a data-bound control to a document or workbook at design time. The <xref:System.Windows.Forms.BindingSource> connects the control to the typed dataset in your project. For more information, see [BindingSource component overview](/dotnet/framework/winforms/controls/bindingsource-component-overview).

     The following code example assumes that your project contains a <xref:System.Windows.Forms.BindingSource> named `customersBindingSource`.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreDataExcelCS/Sheet1.cs" id="Snippet20":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreDataExcelVB/Sheet1.vb" id="Snippet20":::

2. Call the `Update` method of the generated TableAdapter in your project.

     The TableAdapter is automatically generated when you add a data-bound control to a document or workbook at design time. The TableAdapter connects the typed dataset in your project to the database. For more information, see [TableAdapter overview](../data-tools/fill-datasets-by-using-tableadapters.md#tableadapter-overview).

     The following code example assumes that you have a connection to the Customers table in the Northwind database, and that your project contains a TableAdapter named `customersTableAdapter` and a typed dataset named `northwindDataSet`.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreDataExcelCS/Sheet1.cs" id="Snippet21":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreDataExcelVB/Sheet1.vb" id="Snippet21":::

## See also
- [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md)
- [Save data back to the database](../data-tools/save-data-back-to-the-database.md)
- [Update data by using a TableAdapter](../data-tools/update-data-by-using-a-tableadapter.md)
- [How to: Scroll through database records in a worksheet](../vsto/how-to-scroll-through-database-records-in-a-worksheet.md)
- [How to: Populate worksheets with data from a database](../vsto/how-to-populate-worksheets-with-data-from-a-database.md)
- [How to: Populate documents with data from objects](../vsto/how-to-populate-documents-with-data-from-objects.md)
- [How to: Populate documents with data from a database](../vsto/how-to-populate-documents-with-data-from-a-database.md)
- [How to: Populate documents with data from services](../vsto/how-to-populate-documents-with-data-from-services.md)
