---
title: Edit XSLT Style Sheets with the XML editor
description: Explore features in the XML editor for editing XSLT style sheets, including syntax coloring, underlines, and launching the XSLT debugger from the editor.
ms.date: 11/04/2016
ms.topic: article
author: dzsquared
ms.author: drskwier
manager: mijacobs
ms.subservice: xml-tools
---
# Edit XSLT Style Sheets

The XML editor can also be used to edit XSLT style sheets. You can take advantage of the default Editor features such as IntelliSense, outlining, XML snippets, and so on. In addition, there are also new features that make it easier to develop in XSLT.

## XSLT Features

The following table describes features specific to working with XSLT style sheets.

**Syntax coloring**

XSLT keywords, such as `template` and `match`, are displayed in the XSLT keyword color specified by the **Fonts and Colors** settings.

**Wavy underlines**

The XML editor uses the installed *xslt.xsd* file to validate XSLT style sheets. Validation errors are shown as blue wavy underlines. The XML editor also compiles the style sheet in the background and reports compiler errors or warnings with appropriate wavy underlines.

**Support for script blocks**

Code in script blocks is supported by the XSLT debugger so you can set breakpoints and step through the script block code.

**View XSLT output**

You can execute an XSL transformation and view the output from the XML editor. For more information, see [How to: Execute an XSLT transformation from the XML editor](../xml-tools/how-to-execute-an-xslt-transformation-from-the-xml-editor.md).

**Debug XSLT**

You can launch the XSLT debugger from an XSLT file in the XML editor. The debugger supports setting breakpoints in the XSLT file, viewing XSLT execution state, and so on. Hovering over an XSLT variable brings up a ToolTip with the value of the variable. The debugger can be used to debug a style sheet, or to debug a compiled XSL transformation invoked from another application. For more information, see [Debugging XSLT](../xml-tools/debugging-xslt.md).

## Related content

- [XML editor](../xml-tools/xml-editor.md)
