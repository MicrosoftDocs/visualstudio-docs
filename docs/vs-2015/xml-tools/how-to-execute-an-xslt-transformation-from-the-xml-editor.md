---
title: "How to: Execute an XSLT Transformation from the XML Editor | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-xml-tools
ms.topic: conceptual
ms.assetid: 56a0fe82-5231-487d-8b6e-a08a9b04e0fc
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Execute an XSLT Transformation from the XML Editor
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The XML Editor allows you to associate an XSLT style sheet with an XML document, perform the transformation, and view the output. The resulting output from the XSLT transformation is displayed in a new document window.

 The **Output** property specifies the filename for the output. If the **Output** property is blank, a filename is generated in your temporary directory. The file extension is based on the `xsl:output` element in your style sheet and can be .xml, .txt or .htm.

 If the **Output** property specifies a filename with an .htm or .html extension, the XSLT output is previewed using [!INCLUDE[msCoName](../includes/msconame-md.md)] Internet Explorer. All other file extensions are opened using the default editor chosen by [!INCLUDE[msCoName](../includes/msconame-md.md)] Visual Studio. For example, if the file extension is .xml, Visual Studio uses the XML Editor.

### To execute an XSLT transformation from an XML document

1. Open an XML document in the XML Editor.

2. Associate an XSLT style sheet with the XML document.

    - Add an `xml-stylesheet` processing instruction to the XML document. For example, add the following line `<?xml-stylesheet type='text/xsl' href='filename.xsl'?>` to the document prolog.

         -or-

    - Add the XSLT style sheet using the **Properties** window. In the document **Properties Window**, click the **Browse** button for the **Stylesheet** field, select the XSLT style sheet, and click **Open**.

3. Click the **ShowXSL Output** button on the **XML Editor** toolbar.

    > [!NOTE]
    > If there is no style sheet associated with the XML document, a dialog box prompts you to provide the style sheet to use.
    >
    >  The resulting output from the XSLT transformation is displayed in a new document window.

### To execute an XSLT transformation from an XSLT style sheet

1. Open an XSLT style sheet in the XML Editor.

2. Specify an XML document in the **Input** field of the document **Properties** window.

    > [!NOTE]
    > The XML document is the input document used for transformation. If a document is not specified when the XSLT transformation is started, the **File Open** dialog box appears, and you can specify a document at that time.

3. Click the **ShowXSLT Output** button on the **XML Editor** toolbar.

     The resulting output from the XSLT transformation is displayed in a new document window.

### To provide a different output file name

1. Specify a file name in the **Output** field of the document **Properties** window.

2. Click the **ShowXSLT Output** button on the **XML Editor** toolbar.

     The resulting output from the XSLT transformation is displayed in a new document window and the editor used in the output window depends on the file extension of your **Output** document property.

## See Also
 [XML Editor](../xml-tools/xml-editor.md)
