---
title: "How to: Edit XML Files"
ms.date: 11/04/2016
ms.topic: conceptual
ms.assetid: 07fa3ecf-6345-4d30-9d85-d5ef5b083319
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Edit XML files

The XML editor is the new editor for XML files. It can be used on a stand-alone XML file, or on a file associated with a Visual Studio project. The XML editor is associated with the following file extensions: *.config*, *.dtd*, *.xml*, *.xsd*, *.xdr*, *.xsl*, *.xslt*, and *.vssettings*. The XML editor is also associated with any other file type that has no specific editor registered, and that contains XML or DTD content.

> [!NOTE]
> XHTML documents are handled by the HTML Editor.

## To edit an XML file

1.  Double-click the file you want to edit.

### To add a new XML file to a project

1.  From the **Project** menu, select **Add New Item**.

2.  Select **XML File** from the **Templates** pane.

3.  Enter the filename in the **Name** field and press **Add**.

     The XML file is added to the project and opened in the XML editor. The file contains the default XML declaration, `<?xml version="1.0" encoding="utf-8" ?>`.

## To add an existing XML file to a project

1.  From the **Project** menu, select **Add Existing Item**.

     The **Add Existing Item** dialog box appears.

2.  Select an XML file and press **Add**.

## To create a new XML or XSLT file

1.  From the **File** menu, select **New**.

     The **New File** dialog box appears.

2.  Select **XML File** to create a new XML file; or, select **XSLT File** to create a new XSLT style sheet.

3.  Click **Open**.

## Create an empty project for XML files

1. From the **File** menu, select **New** > **Project**.

::: moniker range="vs-2017"

   The **New Project** dialog box appears.

2. Select the code language of your choice, select **Empty Project**.

3. Click **OK**.

::: moniker-end

::: moniker range=">=vs-2019"

2. Enter **Empty Project** in the template search box, select the **Empty Project (.NET Framework)** template, and then click **Next**.

3. Click **Create**.

::: moniker-end

3. Add XML files to the project.

   The XML editor finds the schemas you add to this project and uses them for validation and IntelliSense in any XML, schema, or XSLT files that you edit while this project is open.

## See also

- [XML editor](../xml-tools/xml-editor.md)
- [XML document properties, properties window](../xml-tools/xml-document-properties-properties-window.md)
- [How to: Create an XML schema from an XML document](../xml-tools/how-to-create-an-xml-schema-from-an-xml-document.md)