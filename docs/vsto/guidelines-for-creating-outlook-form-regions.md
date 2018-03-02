---
title: "Guidelines for Creating Outlook Form Regions | Microsoft Docs"
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
  - "form regions [Office development in Visual Studio], guidelines"
  - "icons [Office development in Visual Studio]"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Guidelines for Creating Outlook Form Regions
  The following information can help you optimize your form regions and avoid potential problems:  
  
-   [Using form region names](#UsingFormRegions).  
  
-   [Disabling form region inheritance](#DisablingInheritance).  
  
-   [Understanding Types and Message Class Names](#ClassNames).  
  
-   [Designing adjoining form regions for the reading pane](#ReadingPane).  
  
-   [Using optimal icon sizes](#UsingOptimal).  
  
 For more information about form regions, see [Creating Outlook Form Regions](../vsto/creating-outlook-form-regions.md).  
  
 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]  
  
##  <a name="UsingFormRegions"></a> Using Form Region Names  
 There are several names used to describe the form region. It is important to understand the difference between these names and how they affect the form region. The following table describes each name.  
  
|Form region name|Description|  
|----------------------|-----------------|  
|Form region item name|The name that you specify for the **Outlook Form Region** item in the **Add New Item** dialog box. This is the name of the form region code file that appears in **Solution Explorer**.|  
|<xref:Microsoft.Office.Tools.Outlook.FormRegionManifest.FormRegionName%2A> property|You specify this name in the **Supply descriptive text and select your display preferences** page of the **New Outlook Form Region** wizard. This name appears as the **FormRegionName** property in the **Properties** window.<br /><br /> Use the <xref:Microsoft.Office.Tools.Outlook.FormRegionManifest.FormRegionName%2A> property to specify the label that identifies the form region in the Outlook user interface (UI). For separate form regions, this name appears as a button on the Ribbon of the Outlook item.<br /><br /> For adjoining form regions, this name appears as header text above the form region.|  
|Microsoft.Office.Tools.Outlook.FormRegionName attribute|When you add an **Outlook Form Region** item to the project, Visual Studio sets this property to the fully qualified name of the form region. The default fully qualified name is the name of the VSTO Add-in connected to the name of the form region by a dot—for example, `OutlookAddIn1.FormRegion1`.<br /><br /> This fully qualified name also appears as an attribute at the top of the form region factory class.<br /><br /> Use the Microsoft.Office.Tools.Outlook.FormRegionName attribute to uniquely identify the form region across all Outlook VSTO Add-ins. You cannot change the value of the Microsoft.Office.Tools.Outlook.FormRegionName attribute by renaming the form region item or by changing the <xref:Microsoft.Office.Tools.Outlook.FormRegionManifest.FormRegionName%2A> property. To change this name, you must modify the Microsoft.Office.Tools.Outlook.FormRegionName attribute in the form region code file.|  
  
##  <a name="DisablingInheritance"></a> Disabling Form Region Inheritance  
 By default, a custom message class inherits all the form region associations of the base message class. For example, a message class named `IPM.Task.Contoso` derives from IPM.Task. Therefore, `IPM.Task.Contoso` inherits the form region associations of IPM.Task.  
  
 If you do not want the form region to be associated with any derived message classes, set the <xref:Microsoft.Office.Tools.Outlook.FormRegionManifest.ExactMessageClass%2A> property of the form region to **true**. For example, if you associate an adjoining form region with IPM.Task and set the <xref:Microsoft.Office.Tools.Outlook.FormRegionManifest.ExactMessageClass%2A> property to **true**, the form region will only be appended to the bottom of a standard task form. The form region will not be appended to the bottom of any customized versions of a standard task form.  
  
##  <a name="ClassNames"></a> Understanding Types and Message Class Names  
 The type name of an Outlook item differs from the message class name of an Outlook item. For example, the type name of an RSS item is Microsoft.Office.Interop.Outlook.PostItem. The message class name of an RSS item is IPM.Post.RSS.  
  
 Use the type name to reference an Outlook item in code. For a list of type names, see [Associating a Form Region with an Outlook Message Class](../vsto/associating-a-form-region-with-an-outlook-message-class.md).  
  
 Use the message class name of Outlook items in the **New Outlook Form Region** wizard to associate the item with the form region. For a list of valid message class names, see [Associating a Form Region with an Outlook Message Class](../vsto/associating-a-form-region-with-an-outlook-message-class.md).  
  
##  <a name="ReadingPane"></a> Designing Adjoining Form Regions for the Reading Pane  
 You can use the Outlook Reading Pane to preview an Outlook item without opening the item. The Reading Pane is designed for reading only. Therefore, input controls that you add to an adjoining form region, such as a text box, might not behave as expected when the item and form region are open in the Reading Pane.  
  
 For example, if an item that has an adjoining form region is open in the Reading Pane, the following situation is possible:  
  
1.  Select some text in a textbox that is on the form region.  
  
2.  Press DELETE.  
  
3.  The entire mail item is deleted instead of the text in the textbox.  
  
 If you are designing an adjoining form region that contains input controls, test the controls in the Reading Pane to ensure they work properly. Consider adding custom code that disables controls that do not behave as expected.  
  
 Alternatively, you can set the <xref:Microsoft.Office.Tools.Outlook.FormRegionManifest.ShowInspectorRead%2A> property of the form region to **False**. This way the form region cannot be used in the Reading Pane.  
  
##  <a name="UsingOptimal"></a> Using Optimal Icon Sizes  
 You can specify which icons you want the form region to display by setting icon properties in the **Icons** property group of the **Properties** window. Use the following guidelines to achieve the best visual quality:  
  
-   For the **Page** icon, use a Portable Network Graphics (PNG) file.  
  
-   **Window** icons should be 32 pixels by 32 pixels.  
  
-   All other icons should be 16 pixels by 16 pixels.  
  
 The **Page** icon appears on the Ribbon of an Inspector for items that have separate, replacement, or replace-all form regions.  
  
 The **Window** icon appears in the notification area and in the ALT+TAB dialog box for open items that display replacement or replace-all form regions.  
  
## See Also  
 [Accessing a Form Region at Run Time](../vsto/accessing-a-form-region-at-run-time.md)   
 [Creating Outlook Form Regions](../vsto/creating-outlook-form-regions.md)   
 [Walkthrough: Designing an Outlook Form Region](../vsto/walkthrough-designing-an-outlook-form-region.md)   
 [How to: Add a Form Region to an Outlook Add-in Project](../vsto/how-to-add-a-form-region-to-an-outlook-add-in-project.md)   
 [Associating a Form Region with an Outlook Message Class](../vsto/associating-a-form-region-with-an-outlook-message-class.md)  
  
  