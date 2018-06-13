---
title: "How to: Use Breakpoints with XSLT"
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-xml-tools
ms.topic: conceptual
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# How to: Use breakpoints with XSLT

You can set breakpoints in an XSLT style sheet or in the XML source document. If you set a breakpoint on a tag, when execution starts the breakpoint will move to the next statement that has source line information.

For more information, see [Debugging basics: Breakpoints](../debugger/using-breakpoints.md).

## Set a breakpoint in a style sheet

Breakpoints can be set on start tags, end tags, and text nodes of an XSLT style sheet. Breakpoints can also be set on code in a script block.

### To set a breakpoint in a style sheet

1.  Open a style sheet in the XML Editor.

2.  Position the cursor at the breakpoint location, right-click, point to **Breakpoint**, and click **Insert Breakpoint**.

3.  Click the browse button (**...**) on the **Input** field of the document properties window.

4.  Locate the XML source document and click **Open**.

     This sets the source document file that is used for the XSLT transformation.

5.  Click the **Debug XSL** button on the XML Editor toolbar.

## Set a breakpoint in an XML source document

Breakpoints can be set on elements, attributes, namespace node, comments, processing instruction, and text nodes of an XML source document. You cannot set a breakpoint on the document node, or on a namespace node that is inherited from the parent element.

### To set a breakpoint in an XML source document

1.  Open the XML document in the XML Editor.

2.  Position the cursor at the breakpoint location, right-click, point to **Breakpoint**, and click **Insert Breakpoint**.

3.  Click the browse button (**...**) on the **Stylesheet** field of the document properties window.

4.  Locate the XML source document and click **Open**.

     This sets the source document file that is used for the XSLT transformation.

5.  Click the **Debug XSL** button on the XML Editor toolbar.

## See also

- [Walkthrough: Debug an XSLT style sheet](../xml-tools/walkthrough-debug-an-xslt-style-sheet.md)