---
title: Execute an XSLT transformation
ms.date: 03/05/2019
ms.topic: conceptual
ms.assetid: 56a0fe82-5231-487d-8b6e-a08a9b04e0fc
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Execute an XSLT transformation from the XML editor

The XML editor lets you associate an XSLT style sheet with an XML document, perform the transformation, and view the output. The resulting output from the XSLT transformation is displayed in a new document window.

The **Output** property specifies the filename for the output. If the **Output** property is blank, a filename is generated in your temporary directory. The file extension is based on the `xsl:output` element in your style sheet and can be .*xml*, .*txt* or .*htm*.

If the **Output** property specifies a filename with an .*htm* or .*html* extension, the XSLT output is previewed using a web browser. All other file extensions are opened using the default editor chosen by Visual Studio. For example, if the file extension is .*xml*, Visual Studio uses the XML editor.

## Execute an XSLT transformation from an XML file

1. Open an XML document in the XML editor.

2. Associate an XSLT style sheet with the XML document.

    - Add an `xml-stylesheet` processing instruction to the XML document. For example, add the following line to the document prolog: `<?xml-stylesheet type='text/xsl' href='filename.xsl'?>`

       -or-

    - Add the XSLT style sheet using the **Properties** window. With the XML file open in the editor, right-click anywhere in the editor and choose **Properties**. In the **Properties** window, click in the **Stylesheet** field and choose the browse button (...). Select the XSLT style sheet, and then choose **Open**.

3. On the menu bar, choose **XML** > **Start XSLT Without Debugging**. Or, press **Ctrl**+**Alt**+**F5**.

   The output from the XSLT transformation is displayed in a new document window.

   > [!NOTE]
   > If there is no style sheet associated with the XML document, a dialog box prompts you to provide the style sheet to use.

## Execute an XSLT transformation from an XSLT style sheet

1. Open an XSLT style sheet in the XML editor.

2. Specify an XML document in the **Input** field of the document **Properties** window.

   > [!NOTE]
   > The XML document is the input document used for transformation. If a document is not specified when the XSLT transformation is started, the **File Open** dialog box appears and you can specify a document at that time.

3. On the menu bar, choose **XML** > **Start XSLT Without Debugging**. Or, press **Ctrl**+**Alt**+**F5**.

   The output from the XSLT transformation is displayed in a new document window.

## Specify an output file name

You can specify an output file name for both XML and XSL files. Open the **Properties** window and specify a file name in the **Output** field.

## See also

- [XML editor](../xml-tools/xml-editor.md)