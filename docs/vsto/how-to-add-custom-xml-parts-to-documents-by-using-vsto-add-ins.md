---
title: "How to: Add Custom XML Parts to Documents by Using VSTO Add-Ins | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "add-ins [Office development in Visual Studio], custom XML parts"
  - "Office documents [Office development in Visual Studio, custom XML parts"
  - "Word [Office development in Visual Studio], custom XML parts"
  - "PowerPoint [Office development in Visual Studio], custom XML parts"
  - "Excel [Office development in Visual Studio], custom XML parts"
  - "custom XML parts [Office development in Visual Studio], adding"
  - "documents [Office development in Visual Studio], custom XML parts"
  - "application-level add-ins [Office development in Visual Studio], custom XML parts"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Add Custom XML Parts to Documents by Using VSTO Add-Ins
  You can store XML data in the following types of documents by creating a custom XML part in a VSTO Add-in:  
  
-   A Microsoft Office Excel workbook.  
  
-   A Microsoft Office Word document.  
  
-   A Microsoft Office PowerPoint presentation.  
  
 For more information, see [Custom XML Parts Overview](../vsto/custom-xml-parts-overview.md).  
  
 **Applies to:** The information in this topic applies to application-level projects for Excel, PowerPoint, and Word. For more information, see [Features Available by Office Application and Project Type](../vsto/features-available-by-office-application-and-project-type.md).  
  
### To add a custom XML part to an Excel workbook  
  
1.  Add a new <xref:Microsoft.Office.Core.CustomXMLPart> object to the <xref:Microsoft.Office.Interop.Excel._Workbook.CustomXMLParts%2A> collection in the workbook. The <xref:Microsoft.Office.Core.CustomXMLPart> contains the XML string that you want to store in the workbook.  
  
     The following code example adds a custom XML part to a specified workbook.  
  
     [!code-vb[Trin_AddCustomXmlPartExcelAppLevel#1](../vsto/codesnippet/VisualBasic/trin_addcustomxmlpartexcelapplevel/ThisAddIn.vb#1)]
     [!code-csharp[Trin_AddCustomXmlPartExcelAppLevel#1](../vsto/codesnippet/CSharp/Trin_AddCustomXmlPartExcelAppLevel/ThisAddIn.cs#1)]  
  
2.  Add the `AddCustomXmlPartToWorkbook` method to the `ThisAddIn` class in an VSTO Add-in project for Excel.  
  
3.  Call the method from other code in your project. For example, to create the custom XML part when the user opens a workbook, call the method from an event handler for the <xref:Microsoft.Office.Interop.Excel.AppEvents_Event.WorkbookOpen> event.  
  
### To add a custom XML part to a Word document  
  
1.  Add a new <xref:Microsoft.Office.Core.CustomXMLPart> object to the <xref:Microsoft.Office.Interop.Word._Document.CustomXMLParts%2A> collection in the document. The <xref:Microsoft.Office.Core.CustomXMLPart> contains the XML string that you want to store in the document.  
  
     The following code example adds a custom XML part to a specified document.  
  
     [!code-vb[Trin_AddCustomXmlPartWordAppLevel#1](../vsto/codesnippet/VisualBasic/Trin_AddCustomXmlPartWordAppLevel/ThisAddIn.vb#1)]
     [!code-csharp[Trin_AddCustomXmlPartWordAppLevel#1](../vsto/codesnippet/CSharp/Trin_AddCustomXmlPartWordAppLevel/ThisAddIn.cs#1)]  
  
2.  Add the `AddCustomXmlPartToDocument` method to the `ThisAddIn` class in an VSTO Add-in project for Word.  
  
3.  Call the method from other code in your project. For example, to create the custom XML part when the user opens a document, call the method from an event handler for the <xref:Microsoft.Office.Interop.Word.ApplicationEvents4_Event.DocumentOpen> event.  
  
### To add a custom XML part to a PowerPoint presentation  
  
1.  Add a new <xref:Microsoft.Office.Core.CustomXMLPart> object to the <xref:Microsoft.Office.Interop.PowerPoint._Presentation.CustomXMLParts%2A> collection in the presentation. The <xref:Microsoft.Office.Core.CustomXMLPart> contains the XML string that you want to store in the presentation.  
  
     The following code example adds a custom XML part to a specified presentation.  
  
     [!code-csharp[Trin_AddCustomXmlPartPowerPointAppLevel#1](../vsto/codesnippet/CSharp/Trin_AddCustomXmlPartPowerPointAppLevel/ThisAddIn.cs#1)]
     [!code-vb[Trin_AddCustomXmlPartPowerPointAppLevel#1](../vsto/codesnippet/VisualBasic/Trin_AddCustomXmlPartPowerPointAppLevel/ThisAddIn.vb#1)]  
  
2.  Add the `AddCustomXmlPartToPresentation` method to the `ThisAddIn` class in an VSTO Add-in project for PowerPoint.  
  
3.  Call the method from other code in your project. For example, to create the custom XML part when the user opens a presentation, call the method from an event handler for the <xref:Microsoft.Office.Interop.PowerPoint.EApplication_Event.AfterPresentationOpen> event.  
  
## Robust Programming  
 For simplicity, this example uses an XML string that is defined as a local variable in the method. Typically, you should obtain the XML from an external source, such as a file or a database.  
  
## See Also  
 [Custom XML Parts Overview](../vsto/custom-xml-parts-overview.md)   
 [How to: Add Custom XML Parts to Document-Level Customizations](../vsto/how-to-add-custom-xml-parts-to-document-level-customizations.md)  
  
  