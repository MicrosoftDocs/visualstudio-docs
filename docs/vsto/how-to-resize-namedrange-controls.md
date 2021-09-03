---
title: "How to: Resize NamedRange controls"
description: Learn how you can use Visual Studio to programmatically resize NamedRange controls in a Microsoft Excel workbook.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "controls [Office development in Visual Studio], resizing"
  - "NamedRange control, resizing"
  - "ranges, resizing in Excel"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Resize NamedRange controls
  You can set the size of a <xref:Microsoft.Office.Tools.Excel.NamedRange> control when you add it to a Microsoft Office Excel document; however, you might want to resize it at a later time.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

 You can resize a named range at design time or at run time in document-level projects. You can also resize named ranges at run time in application-level VSTO Add-ins.

 This topic describes the following tasks:

- [Resize NamedRange controls at design time](#designtime)

- [Resize NamedRange controls at run time in a document-level project](#runtimedoclevel)

- [Resize NamedRange controls at run time in a VSTO Add-in project](#runtimeaddin)

## <a name="designtime"></a> Resize NamedRange controls at design time
 You can resize a named range by redefining its size in the **Define Name** dialog box.

### To resize a named range by using the Define Name dialog box

1. Right-click a <xref:Microsoft.Office.Tools.Excel.NamedRange> control.

2. Click **Manage Named Ranges** on the shortcut menu.

     The **Define Name** dialog box appears.

3. Select the named range you want to resize.

4. Clear the **Refers to** box.

5. Select the cells you want to use to define the size of the named range.

6. Click **OK**.

## <a name="runtimedoclevel"></a> Resize NamedRange controls at run time in a document-level project
 You can resize a named range programmatically by using the <xref:Microsoft.Office.Tools.Excel.NamedRange.RefersTo%2A> property.

> [!NOTE]
> In the **Properties** window, the <xref:Microsoft.Office.Tools.Excel.NamedRange.RefersTo%2A> property is marked as read-only.

### To resize a named range programmatically

1. Create a <xref:Microsoft.Office.Tools.Excel.NamedRange> control on cell **A1** of `Sheet1`.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreHostControlsExcelCS/Sheet1.cs" id="Snippet4":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsExcelVB/Sheet1.vb" id="Snippet4":::

2. Resize the named range to include cell **B1**.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreHostControlsExcelCS/Sheet1.cs" id="Snippet5":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsExcelVB/Sheet1.vb" id="Snippet5":::

## <a name="runtimeaddin"></a> Resize NamedRange controls at run time in a VSTO Add-in project
 You can resize a <xref:Microsoft.Office.Tools.Excel.NamedRange> control on any open worksheet at run time. For more information about how to add a <xref:Microsoft.Office.Tools.Excel.NamedRange> control to a worksheet by using a VSTO Add-in, see [How to: Add NamedRange controls to worksheets](../vsto/how-to-add-namedrange-controls-to-worksheets.md).

### To resize a named range programmatically

1. Create a <xref:Microsoft.Office.Tools.Excel.NamedRange> control on cell **A1** of `Sheet1`.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_Excel_Dynamic_Controls/ThisAddIn.cs" id="Snippet10":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_Excel_Dynamic_Controls/ThisAddIn.vb" id="Snippet10":::

2. Resize the named range to include cell **B1**.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_Excel_Dynamic_Controls/ThisAddIn.cs" id="Snippet11":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_Excel_Dynamic_Controls/ThisAddIn.vb" id="Snippet11":::

## See also
- [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)
- [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md)
- [Controls on Office documents](../vsto/controls-on-office-documents.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md)
- [NamedRange control](../vsto/namedrange-control.md)
- [How to: Add NamedRange controls to worksheets](../vsto/how-to-add-namedrange-controls-to-worksheets.md)
- [How to: Resize Bookmark controls](../vsto/how-to-resize-bookmark-controls.md)
- [How to: Resize ListObject controls](../vsto/how-to-resize-listobject-controls.md)
