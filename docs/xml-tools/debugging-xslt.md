---
title: Ways to debug XSLT code
ms.date: 03/05/2019
ms.topic: conceptual
author: jillre
ms.author: jillfra
manager: jillfra
dev_langs:
  - "CSharp"
ms.workload:
  - "multiple"
---
# Debugging XSLT

You can debug XSLT code in Visual Studio. The XSLT debugger supports setting breakpoints, viewing XSLT execution states, and so on. The XSLT debugger can be used to debug XSLT style sheets or XSLT applications.

You can execute code one line at a time by stepping into, stepping over, or stepping out of the code. The commands for using the code-stepping functionality of the XSLT debugger are the same as those for the other Visual Studio debuggers.

Once you start debugging, the XSLT debugger opens windows to show the input document and the XSLT output.

> [!NOTE]
> The XSLT debugger is only available in the Professional and Enterprise editions of Visual Studio.

## Debug from the XML editor

You can start the debugger when you have either a style sheet or an input XML file open in the editor. This lets you debug as you're designing the style sheet.

1. Open the style sheet or XML file in Visual Studio.

1. Select **Start XSLT Debugging** from the **XML** menu or press **Alt**+**F5**.

## Debug from an app that uses XSLT

You can step into XSLT while debugging an application. When you press **F11** on an <xref:System.Xml.Xsl.XslCompiledTransform.Transform%2A?displayProperty=fullName> call, the debugger can step into the XSLT code.

> [!NOTE]
> Stepping into XSLT from the <xref:System.Xml.Xsl.XslTransform> class is not supported. The <xref:System.Xml.Xsl.XslCompiledTransform> class is the only XSLT processor that supports stepping into XSLT while debugging.

### To start debugging an XSLT application

1. When instantiating the <xref:System.Xml.Xsl.XslCompiledTransform> object, set the `enableDebug` parameter to `true` in your code. This tells the XSLT processor to create debug information when the code is compiled.

1. Press **F11** to step into the XSLT code.

   The XSLT style sheet is loaded in a new document window and the XSLT debugger starts.

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
    private const string stylesheet = @"c:\data\xsl_files\below-average.xsl";
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

## XSLT profiler

The [XSLT profiler](../xml-tools/xslt-profiler.md) is a tool that lets developers measure, evaluate, and target performance-related problems in XSLT code by creating detailed XSLT performance reports. For more information, see [XSLT profiler](../xml-tools/xslt-profiler.md).

## See also

- [Walkthrough: Debug an XSLT style sheet](../xml-tools/walkthrough-debug-an-xslt-style-sheet.md)
- [First look at the Visual Studio debugger](../debugger/debugger-feature-tour.md)
- [Debugging basics: Breakpoints](../debugger/using-breakpoints.md)
