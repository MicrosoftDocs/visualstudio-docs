---
title: Configure XML formatting in the text editor
description: Learn how to configure XML formatting and miscellaneous options in the Visual Studio text editor.
ms.date: 9/23/2025
ms.topic: how-to
#customer intent: As a Visual Studio user, I want to control how XML is formatted and completed in the editor so that my documents are readable and follow my standards.
f1_keywords:
- VS.ToolsOptionsPages.Text_Editor.XML.Formatting
- VS.ToolsOptionsPages.Text_Editor.XML.Miscellaneous
ms.custom: "ide-ref"
author: maddymontaquila
ms.author: maleger
manager: mijacobs
ms.subservice: general-ide
---
# Configure XML formatting in the Visual Studio text editor

You can control how XML elements, attributes, and other content are formatted and completed in Visual Studio. This article shows you how to configure formatting and miscellaneous options for XML editing, so your documents are readable and follow your standards.

## Prerequisites

- Visual Studio installed
- An XML file or project

## Configure XML formatting options

Use the **Formatting** options page to specify how elements and attributes are formatted in your XML documents.

1. In Visual Studio, go to **Tools** > **Options**.
2. Expand **Text Editor** > **XML**.
3. Select **Formatting**.
4. Choose your preferred formatting options:
   - **Preserve manual attribute formatting**: Do not reformat attributes. This setting is the default.
     > [!NOTE]
     > If the attributes are on multiple lines, the editor indents each line of attributes to match the indentation of the parent element.
   - **Align attributes each on a separate line**: Align the second and subsequent attributes vertically to match the indentation of the first attribute. Example:
     ```xml
     <item id = "123-A"
           name = "hammer"
           price = "9.95">
     </item>
     ```
   - **Auto Reformat**:
     - **On paste from clipboard**: Reformat XML text pasted from the clipboard.
     - **On completion of end tag**: Reformat the element when the end tag is completed.
   - **Mixed Content**:
     - **Format mixed content by default**: Attempt to reformat mixed content, except when the content is found in an `xml:space="preserve"` scope. This setting is the default.
       If an element contains a mix of text and markup, the contents are considered to be mixed content. Example:
       ```xml
       <dir>c:\data\AlphaProject\
         <file readOnly="false">test1.txt</file>
         <file readOnly="false">test2.txt</file>
       </dir>
       ```

## Configure miscellaneous XML options

Use the **Miscellaneous** options page to change the autocompletion and schema settings for the XML Editor.

1. In **Tools** > **Options**, expand **Text Editor** > **XML**.
2. Select **Miscellaneous**.
3. Adjust the following options as needed:
   - **Auto Insert**:
     - **Close tags**: The text editor adds close tags when authoring XML elements. If an element start tag is selected, the editor inserts the matching close tag, including a matching namespace prefix. This check box is selected by default.
     - **Attribute quotes**: When authoring XML attributes, the editor inserts the `="` and `"` characters and positions the caret (**^**) inside the quotation marks. This check box is selected by default.
     - **Namespace declarations**: The editor automatically inserts namespace declarations wherever they are needed. This check box is selected by default.
     - **Other markup (Comments, CDATA)**: Comments, CDATA, DOCTYPE, processing instructions, and other markup is autocompleted. This check box is selected by default.
   - **Network**:
     - **Automatically download DTDs and schemas**: Schemas and document type definitions (DTDs) are automatically downloaded from HTTP locations. This feature uses System.Net with autoproxy server detection enabled. This check box is selected by default.
   - **Outlining**:
     - **Enter outlining mode when files open**: Turns on the outlining feature when a file is opened. This check box is selected by default.
   - **Caching**:
     - **Schemas**: Specifies the location of the schema cache. The **Browse** button opens the current schema cache location in a new window. The default location is *%VsInstallDir%\xml\Schemas*.

## Next steps

- [XML options - miscellaneous](options-text-editor-xml-miscellaneous.md)
- [XML tools in Visual Studio](../../xml-tools/xml-tools-in-visual-studio.md)
