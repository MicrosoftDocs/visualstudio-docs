---
title: "Miscellaneous, XML, Text Editor, Options Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-xml-tools
ms.topic: conceptual
ms.assetid: fd3fff31-cddc-422d-a2f0-a5a1ef492afd
caps.latest.revision: 9
author: jillre
ms.author: jillfra
manager: jillfra
---
# Miscellaneous, XML, Text Editor, Options Dialog Box
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This dialog box allows you to change the auto-completion and schema settings for the XML Editor. You can access the **Options** dialog box from the **Tools** menu.

> [!NOTE]
> These settings are available when you select the **Text Editor** folder, the **XML** folder, and then the **Miscellaneous** option from the **Options** dialog box.

## Auto Insert
 **Close tags**
 If the autocompletion setting is checked, the editor automatically adds an end tag when you type a right angle bracket (>) to close a start tag, if the tag is not already closed. This is the default behavior.

 The completion of an empty element does not depend on the autocompletion setting. You can always autocomplete an empty element by typing a backslash (/).

 **Attribute quotes**
 When authoring XML attributes, the editor inserts the `=" "` characters and positions the caret (^) inside the double quotes.

 Selected by default.

 **Namespace declarations**
 The editor automatically inserts namespace declarations wherever they are needed.

 Selected by default.

 **Other markup (Comments, CDATA)**
 Comments, CDATA, DOCTYPE, processing instructions, and other markup are auto-completed.

 Selected by default.

## Network
 **Automatically download DTDs and schemas**
 Schemas and document type definitions (DTDs) are automatically downloaded from HTTP locations. This feature uses System.Net with auto-proxy server detection enabled.

 Selected by default.

## Outlining
 **Enter outlining mode when files open**
 Turns on the outlining feature when a file is opened.

 Selected by default.

## Caching
 **Schemas**
 Specifies the location of the schema cache. The browse button (**...**) opens the **Directory Browse** dialog box at the current schema cache location. You can select a different directory, or you can select a folder in the dialog, right-click, and choose **Open** to see what is in the directory.

## See Also
 [XML Document Properties, Properties Window](../xml-tools/xml-document-properties-properties-window.md)
 [XML Editor Components](../xml-tools/xml-editor-components.md)
