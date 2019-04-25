---
title: "How to: Map schemas to Word documents inside Visual Studio"
titleSuffix: ""
ms.custom: "seodec18"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "XML schemas [Office development in Visual Studio], mapping"
  - "mappings [Office development in Visual Studio], XML schemas to Word documents"
  - "Word [Office development in Visual Studio], mapping XML schemas"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Map schemas to Word documents inside Visual Studio
  **Important** The information set out in this topic regarding Microsoft Word is presented exclusively for the benefit and use of individuals and organizations who are located outside the United States and its territories or who are using, or developing programs that run on, Microsoft Word products that were licensed by Microsoft before January 2010, when Microsoft removed an implementation of particular functionality related to custom XML from Microsoft Word. This information regarding Microsoft Word may not be read or used by individuals or organizations in the United States or its territories who are using, or developing programs that run on, Microsoft Word products that were licensed by Microsoft after January 10, 2010; those products will not behave the same as products licensed before that date or purchased and licensed for use outside the United States.

 [!INCLUDE[appliesto_wdalldoc](../vsto/includes/appliesto-wdalldoc-md.md)]

 You can map an XML schema to a document while the document is open in Visual Studio. You use the same Microsoft Office Word tools that you use when the document is open outside of Visual Studio. The Office project creates the same objects whether you map the schema to the document before or after you create your Word solution.

## To map an XML schema to a Word document in Visual Studio

1. Open the Word document or template project inside Visual Studio.

2. Click in the document to move the focus to the designer.

3. On the ribbon, click the **Developer** tab.

    > [!NOTE]
    > If the **Developer** tab is not visible, you must first show it. For more information, see [How to: Show the developer tab on the ribbon](../vsto/how-to-show-the-developer-tab-on-the-ribbon.md).

4. In the **XML** group, click **Schema**.

     The **Templates and Add-ins** dialog box opens.

5. Click the **XML Schema** tab.

6. Click **Add Schema**.

     The **Add Schema** dialog box opens.

7. Browse to your schema file, select it, and then click **Open**.

     The **Schema Settings** dialog box opens.

8. Assign an alias or click **OK** to add the schema without an alias.

9. Click **OK**.

     The **XML Structure** window opens.

10. Drag elements from the **XML Structure** window to the places in your document where you want the corresponding controls to be created.

## See also
- [How to: Map schemas to worksheets inside Visual Studio](../vsto/how-to-map-schemas-to-worksheets-inside-visual-studio.md)
- [XML schemas and data in document-level customizations](../vsto/xml-schemas-and-data-in-document-level-customizations.md)
