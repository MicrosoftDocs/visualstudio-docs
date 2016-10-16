---
title: "How to: Select the XML Schemas to Use"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: d6fda3ef-d465-4788-8514-2f2d528d658c
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
# How to: Select the XML Schemas to Use
The XML Editor provides a schema cache located in the %InstallDir%\Xml\Schemas directory. The schema cache includes well-known XML schemas that are used for IntelliSense and XML document validation.  
  
 The **Schemas** document property is used to select one or more XML schema definition language (XSD) schema(s) to use. It allows you to select schemas from the schema cache, or to specify a schema that is not located in the cache.  
  
 The schemas you specify are saved in the hidden Solution user options file (.suo), along with all other XML document properties. As a result, you do not have to re-enter these values the next time you open the solution.  
  
> [!NOTE]
>  The editor can validate using an inline schema, or a schema referenced by the `xsd:schemaLocation` attribute. For more information, see [XML Document Validation](../reference/xml-document-validation.md).  
  
### To select an XML Schema from the schema cache  
  
1.  Open a file in the XML editor.  
  
2.  In the document properties window, click the button on the **Schemas** field.  
  
     The **XML Schemas** dialog box is displayed. The dialog box lists all schemas with an .xsd extension in the schema cache (including schemas referenced in the catalog.xml file), and also any schema that is in the current solution, open in Visual Studio, referenced in an `xsd:schemaLocation` attribute, or referenced in the **Schemas** property.  
  
3.  Select the schemas to use for validation by doing one of the following:  
  
    -   Select a schema listed in the **XML Schemas** dialog, click the **Use** column, and then select **Use this schema**.  
  
     -or-  
  
    -   Select multiple schemas listed in the **XML Schemas** dialog, right-click and select **Use this schema**.  
  
4.  Click **OK**.  
  
     The list of selected schemas is copied back to the **Schemas** document property.  
  
### To add an XML Schema to the schema cache  
  
1.  In the document properties window, click the button on the **Schemas** field.  
  
2.  Click **Add**.  
  
     This opens the **Open XSD Schema** dialog.  
  
3.  Browse and select the schema(s) to add to the schema cache.  
  
4.  Click **Open**.  
  
     The schema(s) added to the schema cache and is the **Use** column value is set to **Use this schema**.  
  
### To delete an XML Schema from the schema cache  
  
1.  In the document properties window, click the button on the **Schemas** field.  
  
2.  Select the schema to remove and then click **Remove**.  
  
     The schema is removed from the in-memory schema cache, but it is not removed from the file system.  
  
    > [!NOTE]
    >  If you still have a reference to the schema via a `schemaLocation` attribute, or a matching `targetNamespace` then **Remove** will not work in this situation due to auto-association. In this case it is recommended that you mark the schema as **Do not use selected schemas** in the **Use** column.  
  
## See Also  
 [Schema Cache](../reference/schema-cache.md)   
 [XML Schemas Dialog Box](../reference/xml-schemas-dialog-box.md)   
 [XML Editor](../reference/xml-editor.md)