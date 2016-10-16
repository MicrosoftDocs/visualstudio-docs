---
title: "XML Schemas Dialog Box"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 0271fa26-2205-49bd-96e0-ae1441571808
caps.latest.revision: 2
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# XML Schemas Dialog Box
The **XML Schemas** dialog box is used to select which XML schema definition language (XSD) schema(s) to associate with an XML document. You can select a schema from the schema cache, or specify a schema that is not located in the cache. Selected schema(s) are considered part of a schema set. The schema set is used for IntelliSense and also XML document validation.  
  
 You can access the **XML Schemas** dialog box by either clicking the **Schemas** button on the document properties window, or by selecting **Schemas** from the **XML** menu.  
  
## UIElement List  
 **Use**  
 Select how the XML Schema is to be used.  
  
-   **Automatic**. This schema is not in use by the current document but is available for automatic association. If the XML document declares a namespace that matches the `targetNamespace` of this schema, the schema will be automatically associated and is included in the schema set.  
  
-   **Use this schema**. This schema is being used by the current document. Either the user has explicitly requested that this schema be used by clicking on this column, or the schema was automatically associated based on a matching `targetNamespace`.  
  
-   **Do not use selected schemas**. This schema is not used by the current document, even if the schema has a matching `targetNamespace`. This setting can be useful for resolving conflicts when there is more than one version of the same schema in the schema cache or solution.  
  
 **Target Namespace**  
 Displays the target namespace associated with the XML Schema.  
  
 **File Name**  
 Displays the XML Schema file name.  
  
 **Add**  
 Opens the **Open XSD Schema** dialog, which enables you to select additional schemas to add to the schema set. When you add a schema to the schema set, the **Use** column value is set to **Use this schema**.  
  
 **Remove**  
 Removes the currently selected schema from the schema set. This removes the schema from the in-memory schema cache, but not from the file system.  
  
## See Also  
 [XML Editor Components](../reference/xml-editor-components.md)   
 [How to: Select the XML Schemas to Use](../reference/how-to--select-the-xml-schemas-to-use.md)   
 [Schema Cache](../reference/schema-cache.md)