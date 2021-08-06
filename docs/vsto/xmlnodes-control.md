---
title: "XMLNodes control"
description: Learn that the XMLNodes control is created only when a repeating schema element is mapped onto a Microsoft Word document.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "XMLNodes control, events"
  - "XMLNodes control"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# XMLNodes control
  **Important** The information set out in this topic regarding Microsoft Word is presented exclusively for the benefit and use of individuals and organizations who are located outside the United States and its territories or who are using, or developing programs that run on, Microsoft Word products that were licensed by Microsoft before January 2010, when Microsoft removed an implementation of particular functionality related to custom XML from Microsoft Word. This information regarding Microsoft Word may not be read or used by individuals or organizations in the United States or its territories who are using, or developing programs that run on, Microsoft Word products that were licensed by Microsoft after January 10, 2010; those products will not behave the same as products licensed before that date or purchased and licensed for use outside the United States.

 [!INCLUDE[appliesto_wdalldoc](../vsto/includes/appliesto-wdalldoc-md.md)]

 The <xref:Microsoft.Office.Tools.Word.XMLNodes> control is a collection of mapped XML node objects that exposes events. The <xref:Microsoft.Office.Tools.Word.XMLNodes> control is created only when a repeating schema element is mapped onto a Microsoft Office Word document. If the repeating element contains child elements, each of the child elements is also created as an <xref:Microsoft.Office.Tools.Word.XMLNodes> control.

 After Visual Studio creates the collection of XML nodes, you can program against the control directly without having to traverse the Word object model. The <xref:Microsoft.Office.Tools.Word.XMLNodes> control can be deleted only by removing the element mapping from the document.

> [!NOTE]
> If you access a child element of the <xref:Microsoft.Office.Tools.Word.XMLNodes> control through the <xref:Microsoft.Office.Tools.Word.XMLNodes.Item%2A> property, it returns a <xref:Microsoft.Office.Interop.Word.XMLNode> object rather than a <xref:Microsoft.Office.Tools.Word.XMLNode> control. For more information, see [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md).

## Bind data to the control
 An <xref:Microsoft.Office.Tools.Word.XMLNodes> control does not support data binding. This is because the <xref:Microsoft.Office.Tools.Word.XMLNodes> control does not have complex data binding capabilities, and simple data binding cannot represent repeating data.

## Formatting
 Any formatting that can be applied to text within the document can be applied to an <xref:Microsoft.Office.Tools.Word.XMLNodes> control.

## Events
 The events available for the <xref:Microsoft.Office.Tools.Word.XMLNodes> control are:

- <xref:Microsoft.Office.Tools.Word.XMLNodes.AfterInsert>

- <xref:Microsoft.Office.Tools.Word.XMLNodes.BeforeDelete>

- <xref:Microsoft.Office.Tools.Word.XMLNodes.ContextEnter>

- <xref:Microsoft.Office.Tools.Word.XMLNodes.ContextLeave>

- <xref:Microsoft.Office.Tools.Word.XMLNodes.Deselect>

- <xref:System.ComponentModel.IComponent.Disposed>

- <xref:Microsoft.Office.Tools.Word.XMLNodes.Select>

- <xref:Microsoft.Office.Tools.Word.XMLNodes.ValidationError>

## Compare events
 You can capture an event when the user moves his or her cursor inside the context of a particular <xref:Microsoft.Office.Tools.Word.XMLNodes> control. For example, you might have an <xref:Microsoft.Office.Tools.Word.XMLNodes> control named `Customer` that has a child <xref:Microsoft.Office.Tools.Word.XMLNodes> control named `Company`, and `Company` has two child <xref:Microsoft.Office.Tools.Word.XMLNodes> controls named `CompanyName` and `CompanyRegion` as follows:

```xml
<Customer>
    <Company>
        <CompanyName>
        <CompanyRegion>
```

 If you want to show a control on the actions pane whenever the cursor is moved into the `Company` node, it should not matter whether the cursor is placed in `CompanyName` or `CompanyRegion` because they are both within the context of `Company`. In this case, you can write your code in the <xref:Microsoft.Office.Tools.Word.XMLNodes.ContextEnter> event of `Company`.

 In most cases, when the cursor enters an <xref:Microsoft.Office.Tools.Word.XMLNodes> control, both the <xref:Microsoft.Office.Tools.Word.XMLNodes.Select> and <xref:Microsoft.Office.Tools.Word.XMLNodes.ContextEnter> events are raised. The following table shows differences between these events.

|Select event|ContextEnter event|
|------------------|------------------------|
|Occurs when the cursor is placed inside one of the nodes of the <xref:Microsoft.Office.Tools.Word.XMLNodes> collection.|Occurs when the cursor is placed inside one of the nodes or descendant nodes of the <xref:Microsoft.Office.Tools.Word.XMLNodes> collection, from an area outside of the context of the node. In other words, it is raised only when the context changes, and can be raised for multiple nested <xref:Microsoft.Office.Tools.Word.XMLNodes> controls.|

 For example, when you move the cursor from outside of `Customer` into `CompanyName`, the <xref:Microsoft.Office.Tools.Word.XMLNodes.ContextEnter> events for `Customer`, `Company`, and `CompanyName` are raised. If you then move the cursor from `CompanyName` to `CompanyRegion`, the <xref:Microsoft.Office.Tools.Word.XMLNodes.ContextEnter> event only for `CompanyRegion` is raised, because the context is the same for both `Company` and `Customer`. You can have multiple `Company` nodes in your document. If you move the cursor from the `CompanyName` node of one `Company` to the `CompanyName` node of another `Company`, the context is the same, so only the <xref:Microsoft.Office.Tools.Word.XMLNodes.Select> event is raised.

 The same differences exist between the <xref:Microsoft.Office.Tools.Word.XMLNodes.ContextLeave> event and the <xref:Microsoft.Office.Tools.Word.XMLNodes.Deselect> event.

## See also
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [Automate Word by using extended objects](../vsto/automating-word-by-using-extended-objects.md)
- [XMLNode control](../vsto/xmlnode-control.md)
- [How to: Add XMLNodes controls to Word documents](../vsto/how-to-add-xmlnodes-controls-to-word-documents.md)
- [How to: Map schemas to Word documents inside Visual Studio](../vsto/how-to-map-schemas-to-word-documents-inside-visual-studio.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
