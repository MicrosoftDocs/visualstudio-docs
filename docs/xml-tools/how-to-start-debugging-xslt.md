---
title: "How to: Start Debugging XSLT"
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-xml-tools
ms.topic: conceptual
author: gewarren
ms.author: gewarren
manager: douge
dev_langs:
  - "CSharp"
ms.workload:
  - "multiple"
---
# How to: Start debugging XSLT

The XSLT debugger can be used to debug an XSLT style sheet or an XSLT application. When debugging, you can execute code one line at a time by stepping into, stepping over, or stepping out of the code. The commands to use the code-stepping functionality are the same for the XSLT debugger as for the other Visual Studio debuggers. Once you start debugging, the XSLT debugger opens windows to show the input document and the XSLT output.

## XML Editor

You can start the debugger from the XML Editor. This allows you to debug as you are designing the style sheet.

### To start debugging from a style sheet

1. Open the style sheet in the XML Editor.

1. Select **Debug XSL** from the **XML** menu.

### To start debugging from an XML input document

1. Open the XML document in the XML Editor.

1. Select **Debug XSL** from the **XML** menu.

## XSLT from other languages

You can also step into XSLT while debugging an application. When you press F11 on an <xref:System.Xml.Xsl.XslCompiledTransform.Transform%2A?displayProperty=fullName> call, the debugger can step into the XSLT code.

> [!NOTE]
> Stepping into XSLT from the <xref:System.Xml.Xsl.XslTransform> class is not supported. The <xref:System.Xml.Xsl.XslCompiledTransform> class is the only XSLT processor that supports stepping into XSLT while debugging.

### To start debugging an XSLT application

1. When instantiating the <xref:System.Xml.Xsl.XslCompiledTransform> object, set the `enableDebug` parameter to `true` in your code.

     This tells the XSLT processor to create debug information when the code is compiled.

1. Press F11 to step into the XSLT code.

     The XSLT style sheet is loaded in a new document window and the XSLT debugger is started.

     Alternatively, you can add a break point to the style sheet and run your application.

### Example

The following is an example of a C# XSLT program. It shows how to enable XSLT debugging.

```csharp
using System;
using System.IO;
using System.Xml;
using System.Xml.Xsl;

namespace ConsoleApplication
{
  class Program
  {
    private const string sourceFile = @"c:\data\xsl_files\books.xml";
    private const string stylesheet = @"c:\data\xsl_files\belowAvg.xsl";
    private const string outputFile = @"c:\data\xsl_files\output.xml";

    static void Main(string[] args)
    {
      // Enable XSLT debugging.
      XslCompiledTransform xslt = new XslCompiledTransform(true);

      // Compile the style sheet.
      xslt.Load(stylesheet)

      // Execute the XSLT transform.
      FileStream outputStream = new FileStream(outputFile, FileMode.Append);
      xslt.Transform(sourceFile, null, outputStream);
    }
  }
}
```

## See also

- [Walkthrough: Debug an XSLT style sheet](../xml-tools/walkthrough-debug-an-xslt-style-sheet.md)
- [Debugger basics](../debugger/debugger-basics.md)