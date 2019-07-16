---
title: "XMLNode control"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "XMLNode control"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# XMLNode control
  **Important** The information set out in this topic regarding Microsoft Word is presented exclusively for the benefit and use of individuals and organizations who are located outside the United States and its territories or who are using, or developing programs that run on, Microsoft Word products that were licensed by Microsoft before January 2010, when Microsoft removed an implementation of particular functionality related to custom XML from Microsoft Word. This information regarding Microsoft Word may not be read or used by individuals or organizations in the United States or its territories who are using, or developing programs that run on, Microsoft Word products that were licensed by Microsoft after January 10, 2010; those products will not behave the same as products licensed before that date or purchased and licensed for use outside the United States.

 [!INCLUDE[appliesto_wdalldoc](../vsto/includes/appliesto-wdalldoc-md.md)]

 The <xref:Microsoft.Office.Tools.Word.XMLNode> control is a mapped XML node object that exposes events and can be bound to data. The <xref:Microsoft.Office.Tools.Word.XMLNode> control is created only when a non-repeating schema element is mapped onto a Microsoft Office Word document. After Visual Studio creates the XML node, you can program against it directly without having to traverse the Word object model.

 The <xref:Microsoft.Office.Tools.Word.XMLNode> control can be deleted only by removing the element mapping in Word.

## Bind data to the control
 An <xref:Microsoft.Office.Tools.Word.XMLNode> control supports simple data binding. The XML node should be bound to a data source by using the <xref:System.Windows.Forms.IBindableComponent.DataBindings%2A> property. If the data in the bound dataset is updated, the <xref:Microsoft.Office.Tools.Word.XMLNode> control reflects the changes.

## Formatting
 Formatting that can be applied to a <xref:Microsoft.Office.Interop.Word.XMLNode> object can be applied to a <xref:Microsoft.Office.Tools.Word.XMLNode> control. This includes fonts, underline styles, and character styles.

## Events
 The following events are available for the <xref:Microsoft.Office.Tools.Word.XMLNode> control:

- <xref:Microsoft.Office.Tools.Word.XMLNode.AfterInsert>

- <xref:Microsoft.Office.Tools.Word.XMLNode.BeforeDelete>

- <xref:Microsoft.Office.Tools.Word.XMLNode.BindingContextChanged>

- <xref:Microsoft.Office.Tools.Word.XMLNode.ContextEnter>

- <xref:Microsoft.Office.Tools.Word.XMLNode.ContextLeave>

- <xref:Microsoft.Office.Tools.Word.XMLNode.Deselect>

- <xref:System.ComponentModel.IComponent.Disposed>

- <xref:Microsoft.Office.Tools.Word.XMLNode.Select>

- <xref:Microsoft.Office.Tools.Word.XMLNode.ValidationError>

## Compare events
 You can capture an event when the user moves his or her cursor inside the context of a particular <xref:Microsoft.Office.Tools.Word.XMLNode> control. For example, you might have an <xref:Microsoft.Office.Tools.Word.XMLNode> control named `Customer` that has a child <xref:Microsoft.Office.Tools.Word.XMLNode> control named `Company`, and `Company` has two child <xref:Microsoft.Office.Tools.Word.XMLNode> controls named `CompanyName` and `CompanyRegion` as follows:

```xml
<Customer>
    <Company>
        <CompanyName>
        <CompanyRegion>
```

 If you want to show a control on the actions pane whenever the cursor is moved into the `Company` node, it should not matter whether the cursor is placed in `CompanyName` or `CompanyRegion` because they are both within the context of `Company`. In this case, you can write your code in the <xref:Microsoft.Office.Tools.Word.XMLNode.ContextEnter> event of `Company`.

 In most cases, when the cursor enters an <xref:Microsoft.Office.Tools.Word.XMLNode> control, both the <xref:Microsoft.Office.Tools.Word.XMLNode.Select> and <xref:Microsoft.Office.Tools.Word.XMLNode.ContextEnter> events are raised. The following table shows the differences between these events.

|Select Event|ContextEnter Event|
|------------------|------------------------|
|Occurs when the cursor is placed inside an <xref:Microsoft.Office.Tools.Word.XMLNode>.|Occurs when the cursor is placed inside an <xref:Microsoft.Office.Tools.Word.XMLNode> or one of its descendent nodes, from an area outside of the context of the node. In other words, it is raised only when the context changes.|

 For example, when you move the cursor from outside of `Customer` into `CompanyName`, the <xref:Microsoft.Office.Tools.Word.XMLNode.ContextEnter> event for `Customer`, `Company`, and `CompanyName` is raised. If you then move the cursor from `CompanyName` to `CompanyRegion`, only the <xref:Microsoft.Office.Tools.Word.XMLNode.ContextEnter> event for `CompanyRegion` is raised because you are still within the context of both `Company` and `Customer`.

 The same differences exist between the <xref:Microsoft.Office.Tools.Word.XMLNode.ContextLeave> event and <xref:Microsoft.Office.Tools.Word.XMLNode.Deselect> event.

## See also
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [Automate Word by using extended objects](../vsto/automating-word-by-using-extended-objects.md)
- [XMLNodes control](../vsto/xmlnodes-control.md)
- [How to: Add XMLNode controls to Word documents](../vsto/how-to-add-xmlnode-controls-to-word-documents.md)
- [How to: Map schemas to Word documents inside Visual Studio](../vsto/how-to-map-schemas-to-word-documents-inside-visual-studio.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
