---
title: "Update Excel or Word project migrated to .NET Framework 4.5"
description: You must modify your code if the target framework is changed to the .NET Framework 4 or later when you have an Excel or Word project that uses specific features.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: upgrade-and-migration-article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office projects [Office development in Visual Studio], migrating to .NET Framework 4"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Update Excel and Word projects that You migrate to the .NET Framework 4.5

  If you have an Excel or Word project that uses any of the following features, you must modify your code if the target framework is changed to the .NET Framework 4 or later:

- [GetVstoObject and HasVstoObject methods](#GetVstoObject)

- [Generated classes in document-level projects](#generatedclasses)

- [Windows Forms controls on documents](#winforms)

- [Word content control events](#ccevents)

- [OLEObject and OLEControl classes](#ole)

- [Controls.Item(Object) property](#itemproperty)

- [Collections that derive from CollectionBase](#collections)

  You must also remove the `Microsoft.Office.Tools.Excel.ExcelLocale1033Attribute` and references to the `Microsoft.Office.Tools.Excel.ExcelLocale1033Proxy` class from Excel projects that are retargeted to the .NET Framework 4 or later. Visual Studio doesn't remove this attribute or the class reference for you.

## Remove the ExcelLocale1033 attribute from Excel projects
 The `Microsoft.Office.Tools.Excel.ExcelLocale1033Attribute` has been removed from the portion of the Visual Studio 2010 Tools for Office runtime that is used for solutions that target the .NET Framework 4 or later. The common language runtime (CLR) in the .NET Framework 4 and later always passes locale ID 1033 to the Excel object model, and you can no longer use this attribute to disable this behavior. For more information, see [Globalization and localization of Excel solutions](../vsto/globalization-and-localization-of-excel-solutions.md).

### To remove the ExcelLocale1033Attribute

1. With the project open in Visual Studio, open **Solution Explorer**.

2. Under the **Properties** node (for C#) or the **My Project** node (for Visual Basic), double-click the AssemblyInfo code file to open it in the code editor.

    > [!NOTE]
    > In Visual Basic projects, you must click the **Show All Files** button in **Solution Explorer** to see the AssemblyInfo code file.

3. Locate the `Microsoft.Office.Tools.Excel.ExcelLocale1033Attribute` and either remove it from the file or comment it out.

    ### [C#](#tab/csharp)
    ```csharp
    [assembly: ExcelLocale1033Proxy(true)]
    ```

    ### [VB](#tab/vb)
    ```vb
    <Assembly: ExcelLocale1033Proxy(True)>
    ```
    ---

## Remove a reference to the ExcelLocal1033Proxy class
 Projects that were created by using Microsoft Visual Studio 2005 Tools for the Microsoft Office System instantiate the Excel <xref:Microsoft.Office.Interop.Excel.Application> object by using the `Microsoft.Office.Tools.Excel.ExcelLocale1033Proxy` class. This class has been removed from the portion of the Visual Studio 2010 Tools for Office runtime that's used for solutions that target the .NET Framework 4 or later. Therefore, you must remove or comment out the line of code that references this class.

### To remove the reference to the ExcelLocal1033Proxy class

1. Open the project in Visual Studio, and then open **Solution Explorer**.

2. In **Solution Explorer**, open the shortcut menu for *ThisAddin.cs* (for C#) or *ThisAddin.vb* (for Visual Basic), and then choose **View Code**.

3. In the Code Editor, in the `VSTO generated code` region, remove or comment out the following line of code.

    ### [C#](#tab/csharp)
    ```csharp
    this.Application = (Excel.Application)Microsoft.Office.Tools.Excel.ExcelLocale1033Proxy.Wrap(typeof(Excel.Application), this.Application);

    ```

    ### [VB](#tab/vb)
    ```vb
    Me.Application = CType(Microsoft.Office.Tools.Excel.ExcelLocale1033Proxy.Wrap(GetType(Excel.Application), Me.Application), Excel.Application)

    ```
    ---

## <a name="GetVstoObject"></a> Update code that uses the GetVstoObject and HasVstoObject methods
 In projects that target the .NET Framework 3.5, the `GetVstoObject` or `HasVstoObject` methods are available as extension methods on one of the following native objects in your project: <xref:Microsoft.Office.Interop.Word.Document>, <xref:Microsoft.Office.Interop.Excel.Workbook>, <xref:Microsoft.Office.Interop.Excel.Worksheet>, or <xref:Microsoft.Office.Interop.Excel.ListObject>. When you call these methods, you do not need to pass a parameter. The following code example demonstrates how to use the GetVstoObject method in a Word VSTO Add-in that targets the .NET Framework 3.5.

### [C#](#tab/csharp)
```csharp
Microsoft.Office.Tools.Word.Document vstoDocument =
    Globals.ThisAddIn.Application.ActiveDocument.GetVstoObject();
```

### [VB](#tab/vb)
```vb
Dim vstoDocument as Microsoft.Office.Tools.Word.Document = _
    Globals.ThisAddIn.Application.ActiveDocument.GetVstoObject()
```
---

 In projects that target the .NET Framework 4 or later, you must modify your code to access these methods in one of the following ways:

- You can still access these methods as extension methods on <xref:Microsoft.Office.Interop.Word.Document>, <xref:Microsoft.Office.Interop.Excel.Workbook>, <xref:Microsoft.Office.Interop.Excel.Worksheet>, or <xref:Microsoft.Office.Interop.Excel.ListObject> objects. However, you must now pass the object returned by the `Globals.Factory` property to these methods.

  ### [C#](#tab/csharp)
  ```csharp
  Microsoft.Office.Tools.Word.Document vstoDocument =
      Globals.ThisAddIn.Application.ActiveDocument.GetVstoObject(Globals.Factory);
  ```

  ### [VB](#tab/vb)
  ```vb
  Dim vstoDocument as Microsoft.Office.Tools.Word.Document = _
      Globals.ThisAddIn.Application.ActiveDocument.GetVstoObject(Globals.Factory)
  ```
  ---

- You can alternatively access these methods on the object that is returned by the `Globals.Factory` property. When you access these methods in this way, you must pass the native object that you want to extend to the method.

  ### [C#](#tab/csharp)
  ```csharp
  Microsoft.Office.Tools.Word.Document vstoDocument =
      Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveDocument);
  ```

  ### [VB](#tab/vb)
  ```vb
  Dim vstoDocument as Microsoft.Office.Tools.Word.Document = _
      Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveDocument)
  ```
  ---

  For more information, see [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).

## <a name="generatedclasses"></a> Update code that uses instances of the generated classes in document-level projects
 In document-level projects that target the .NET Framework 3.5, the generated classes in the projects derive from the following classes in the  Visual Studio Tools for Office runtime :

- `ThisDocument`: <xref:Microsoft.Office.Tools.Word.Document>

- `ThisWorkbook`: <xref:Microsoft.Office.Tools.Excel.Workbook>

- `Sheet` *n*: <xref:Microsoft.Office.Tools.Excel.Worksheet>

- `Chart` *n*: <xref:Microsoft.Office.Tools.Excel.ChartSheet>

  In projects that target the .NET Framework 4 or later, the types in the  Visual Studio Tools for Office runtime  listed above are interfaces, instead of classes. The generated classes in projects that target the .NET Framework 4 or later derive from the following new classes in the  Visual Studio Tools for Office runtime :

- `ThisDocument`: <xref:Microsoft.Office.Tools.Word.DocumentBase>

- `ThisWorkbook`: <xref:Microsoft.Office.Tools.Excel.WorkbookBase>

- `Sheet` *n*: <xref:Microsoft.Office.Tools.Excel.WorksheetBase>

- `Chart` *n*: <xref:Microsoft.Office.Tools.Excel.ChartSheetBase>

  If code in your project refers to an instance of one of the generated classes as the base class that it derives from, you must modify the code.

  For example, in an Excel Workbook project that targets the .NET Framework 3.5, you might have a helper method that performs some work on instances of the generated `Sheet`*n* classes in your project.

### [C#](#tab/csharp)
```csharp
private void DoSomethingToSheet(Microsoft.Office.Tools.Excel.Worksheet worksheet)
{
    // Do something to the worksheet object.
}
```

### [VB](#tab/vb)
```vb
Private Sub DoSomethingToSheet(ByVal worksheet As Microsoft.Office.Tools.Excel.Worksheet)
    ' Do something to the worksheet object.
End Sub
```
---

 If you retarget the project to the .NET Framework 4 or later, you must make one of the following changes to your code:

- Modify any code that calls the `DoSomethingToSheet` method to pass the <xref:Microsoft.Office.Tools.Excel.WorksheetBase.Base%2A> property of a <xref:Microsoft.Office.Tools.Excel.WorksheetBase> object in your project. This property returns a <xref:Microsoft.Office.Tools.Excel.Worksheet> object.

    ### [C#](#tab/csharp)
    ```csharp
    DoSomethingToSheet(Globals.Sheet1.Base);
    ```

    ### [VB](#tab/vb)
    ```vb
    DoSomethingToSheet(Globals.Sheet1.Base)
    ```
    ---

- Modify the `DoSomethingToSheet` method parameter to expect a <xref:Microsoft.Office.Tools.Excel.WorksheetBase> object instead.

    ### [C#](#tab/csharp)
    ```csharp
    private void DoSomethingToSheet (Microsoft.Office.Tools.Excel.WorksheetBase worksheet)
    {
        // Do something to the worksheet object.
    }
    ```

    ### [VB](#tab/vb)
    ```vb
    Private Sub DoSomethingToSheet(ByVal worksheet As Microsoft.Office.Tools.Excel.WorksheetBase)
        ' Do something to the worksheet object.
    End Sub
    ```
    ---

## <a name="winforms"></a> Update code that uses Windows Forms controls on documents
 You must add a **using** (C#) or **Imports** (Visual Basic) statement for the <xref:Microsoft.Office.Tools.Excel> or <xref:Microsoft.Office.Tools.Word> namespace to the top of any code file that uses the Controls property to add Windows Forms controls to the document or worksheet programmatically.

 In projects that target the .NET Framework 3.5, the methods that add Windows Forms controls (such as the `AddButton` method) are defined in the <xref:Microsoft.Office.Tools.Excel.ControlCollection> and <xref:Microsoft.Office.Tools.Word.ControlCollection> classes.

 In projects that target the .NET Framework 4 or later, these methods are extension methods that are available on the Controls property. To use these extension methods, the code file in which you use the methods must have a **using** or **Imports** statement for the <xref:Microsoft.Office.Tools.Excel> or <xref:Microsoft.Office.Tools.Word> namespace. This statement is generated automatically in new projects that target the .NET Framework 4 or later. However, this statement is not added automatically in projects that target the .NET Framework 3.5, so you must add it when you retarget the project.

 For more information, see [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md).

## <a name="ccevents"></a> Update code that handles Word content control events
 In projects that target the .NET Framework 3.5, events of Word content controls are handled by the generic <xref:System.EventHandler%601> delegate. In projects that target the .NET Framework 4 or later, these events are handled by other delegates.

 The following table lists the Word content control events and the delegates that are associated with them in projects that target the .NET Framework 4 or later.

|Event|Delegate to use in .NET Framework 4 and later projects|
|-----------| - |
|<xref:Microsoft.Office.Tools.Word.ContentControlBase.Added>|<xref:Microsoft.Office.Tools.Word.ContentControlAddedEventHandler>|
|<xref:Microsoft.Office.Tools.Word.ContentControlBase.ContentUpdating>|<xref:Microsoft.Office.Tools.Word.ContentControlContentUpdatingEventHandler>|
|<xref:Microsoft.Office.Tools.Word.ContentControlBase.Deleting>|<xref:Microsoft.Office.Tools.Word.ContentControlDeletingEventHandler>|
|<xref:Microsoft.Office.Tools.Word.ContentControlBase.Entering>|<xref:Microsoft.Office.Tools.Word.ContentControlEnteringEventHandler>|
|<xref:Microsoft.Office.Tools.Word.ContentControlBase.Exiting>|<xref:Microsoft.Office.Tools.Word.ContentControlExitingEventHandler>|
|<xref:Microsoft.Office.Tools.Word.ContentControlBase.StoreUpdating>|<xref:Microsoft.Office.Tools.Word.ContentControlStoreUpdatingEventHandler>|

## <a name="ole"></a> Update code that uses the OLEObject and OLEControl classes
 In projects that target the .NET Framework 3.5, you can add custom controls (such as Windows Forms user controls) to a document or worksheet by using the `Microsoft.Office.Tools.Excel.OLEObject` and `Microsoft.Office.Tools.Word.OLEControl` classes.

 In projects that target the .NET Framework 4 or later, these classes have been replaced by the <xref:Microsoft.Office.Tools.Excel.ControlSite> and <xref:Microsoft.Office.Tools.Word.ControlSite> interfaces. You must modify code that refers to `Microsoft.Office.Tools.Excel.OLEObject` and `Microsoft.Office.Tools.Word.OLEControl` to instead refer to <xref:Microsoft.Office.Tools.Excel.ControlSite> and <xref:Microsoft.Office.Tools.Word.ControlSite>. Other than the new names, these controls behave the same way that they do in projects that target the .NET Framework 3.5.

 For more information, see [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md).

## <a name="itemproperty"></a> Update code that uses the Controls.Item(Object) property
 In projects that target the .NET Framework 3.5, you can use the Item(Object) property of the Microsoft.Office.Tools.Word.Document.Controls or `Microsoft.Office.Tools.Excel.Worksheet.Controls` collection to determine whether a document or worksheet has a specified control.

 In projects that target the .NET Framework 4 or later, the Item(Object) property has been removed from these collections. To determine whether a document or worksheet contains a specified control, use the Contains(System.Object) method of the <xref:Microsoft.Office.Tools.Word.Document.Controls%2A> or <xref:Microsoft.Office.Tools.Excel.Worksheet.Controls%2A> collection instead.

 For more information about the Controls collection of documents and worksheets, see [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md).

## <a name="collections"></a> Update code that uses collections that derive from CollectionBase
 In projects that target the .NET Framework 3.5, several collection types in the  Visual Studio Tools for Office runtime  derive from the <xref:System.Collections.CollectionBase> class, such as `Microsoft.Office.Tools.SmartTagCollection`, `Microsoft.Office.Tools.Excel.ControlCollection`, and `Microsoft.Office.Tools.Word.ControlCollection`.

 In projects that target the .NET Framework 4 or later, these collection types are now interfaces that do not derive from <xref:System.Collections.CollectionBase>. Some members are no longer available on these collection types, such as <xref:System.Collections.CollectionBase.Capacity%2A>, <xref:System.Collections.CollectionBase.List%2A>, and <xref:System.Collections.CollectionBase.InnerList%2A>.

## Related content
- [Migrate Office solutions to the .NET Framework 4 or later](../vsto/migrating-office-solutions-to-the-dotnet-framework-4-or-later.md)
- [Content controls](../vsto/content-controls.md)
- [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)
- [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md)
- [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md)
