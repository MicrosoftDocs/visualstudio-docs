---
title: "XML Schemas Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-xml-tools
ms.topic: conceptual
ms.assetid: 0271fa26-2205-49bd-96e0-ae1441571808
caps.latest.revision: 9
author: jillre
ms.author: jillfra
manager: jillfra
---
# XML Schemas Dialog Box
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The **XML Schemas** dialog box is used to select which XML schema definition language (XSD) schema(s) to associate with an XML document. You can select a schema from the schema cache, or specify a schema that is not located in the cache. Selected schema(s) are considered part of a schema set. The schema set is used for IntelliSense and also XML document validation.

 You can access the **XML Schemas** dialog box by either clicking the **Schemas** button on the document properties window, or by selecting **Schemas** from the **XML** menu.

## UIElement List
 **Use**
 Select how the XML Schema is to be used.

- **Automatic**. This schema is not in use by the current document but is available for automatic association. If the XML document declares a namespace that matches the `targetNamespace` of this schema, the schema will be automatically associated and is included in the schema set.

- **Use this schema**. This schema is being used by the current document. Either the user has explicitly requested that this schema be used by clicking on this column, or the schema was automatically associated based on a matching `targetNamespace`.

- **Do not use selected schemas**. This schema is not used by the current document, even if the schema has a matching `targetNamespace`. This setting can be useful for resolving conflicts when there is more than one version of the same schema in the schema cache or solution.

  **Target Namespace**
  Displays the target namespace associated with the XML Schema.

  **File Name**
  Displays the XML Schema file name.

  **Add**
  Opens the **Open XSD Schema** dialog, which enables you to select additional schemas to add to the schema set. When you add a schema to the schema set, the **Use** column value is set to **Use this schema**.

  **Remove**
  Removes the currently selected schema from the schema set. This removes the schema from the in-memory schema cache, but not from the file system.

## See Also
 [XML Editor Components](../xml-tools/xml-editor-components.md)
 [How to: Select the XML Schemas to Use](../xml-tools/how-to-select-the-xml-schemas-to-use.md)
 [Schema Cache](../xml-tools/schema-cache.md)
