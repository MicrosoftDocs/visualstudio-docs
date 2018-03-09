---
title: "Walkthrough: Creating a Custom Tab by Using Ribbon XML | Microsoft Docs"
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
  - "Ribbon [Office development in Visual Studio], tabs"
  - "customizing the Ribbon, tabscustom Ribbon, tabs"
  - "Ribbon [Office development in Visual Studio], XML"
  - "XML [Office development in Visual Studio], Ribbon"
  - "Ribbon [Office development in Visual Studio], customizing"
  - "Custom tab [Office development in Visual Studio]"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Walkthrough: Creating a Custom Tab by Using Ribbon XML
  This walkthrough demonstrates how to create a custom Ribbon tab by using the **Ribbon (XML)** item.  
  
 [!INCLUDE[appliesto_ribbon](../vsto/includes/appliesto-ribbon-md.md)]  
  
 This walkthrough illustrates the following tasks:  
  
-   Adding buttons to the **Add-Ins** tab. The **Add-Ins** tab is the default tab that is defined in the Ribbon XML file.  
  
-   Automating Microsoft Office Word by using the buttons on the **Add-Ins** tab.  
  
> [!NOTE]  
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).  
  
## Prerequisites  
 You need the following components to complete this walkthrough:  
  
-   [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]  
  
-   Microsoft Word.  
  
## Creating the Project  
 The first step is to create a Word VSTO Add-in project. You will later customize the **Add-Ins** tab of this document.  
  
#### To create a new project  
  
1.  Create a **Word Add-in** project with the name **MyRibbonAddIn**.  
  
     For more information, see [How to: Create Office Projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).  
  
     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] opens the **ThisAddIn.cs** or **ThisAddIn.vb** code file and adds the **MyRibbonAddIn** project to **Solution Explorer**.  
  
## Creating the VSTO Add-ins Tab  
 To create the **Add-Ins** tab, add a **Ribbon (XML)** item to your project. Later in this walkthrough, you will add some buttons to this tab.  
  
#### To create the Add-Ins tab  
  
1.  On the **Project** menu, click **Add New Item**.  
  
2.  In the **Add New Item** dialog box, select **Ribbon (XML)**.  
  
3.  Change the name of the new Ribbon to **MyRibbon**, and click **Add**.  
  
     The **MyRibbon.cs** or **MyRibbon.vb** file opens in the designer. An XML file that is named **MyRibbon.xml** is also added to your project.  
  
4.  In **Solution Explorer**, right-click **ThisAddin.cs** or **ThisAddin.vb**, and then click **View Code**.  
  
5.  Add the following code to the **ThisAddin** class. This code overrides the CreateRibbonExtensibilityObject method and returns the Ribbon XML class to the Office application.  
  
     [!code-csharp[Trin_Ribbon_Custom_Tab_XML#1](../vsto/codesnippet/CSharp/Trin_Ribbon_Custom_Tab_XML_O12/ThisAddIn.cs#1)]
     [!code-vb[Trin_Ribbon_Custom_Tab_XML#1](../vsto/codesnippet/VisualBasic/Trin_Ribbon_Custom_Tab_XML_O12/ThisAddIn.vb#1)]  
  
6.  In **Solution Explorer**, right-click the **MyRibbonAddIn** project and then click **Build**. Verify that the project builds without errors.  
  
## Adding Buttons to the Add-Ins Tab  
 The goal for this VSTO Add-in is to give users a way to add boilerplate text and a specific table to the active document. To provide the user interface, add two buttons to the **Add-Ins** tab by modifying the Ribbon XML file. Later in this walkthrough, you will define callback methods for the buttons. For more information about the Ribbon XML file, see [Ribbon XML](../vsto/ribbon-xml.md).  
  
#### To add buttons to the Add-Ins tab  
  
1.  In **Solution Explorer**, right-click **MyRibbon.xml** and then click **Open**.  
  
2.  Replace the contents of the **tab** element with the following XML. This XML changes the label of the default control group to **Content**, and it adds two new buttons with the labels **Insert Text** and **Insert Table**.  
  
    ```  
    <tab idMso="TabAddIns">  
        <group id="ContentGroup" label="Content">  
            <button id="textButton" label="Insert Text"  
                 screentip="Text" onAction="OnTextButton"  
                 supertip="Inserts text at the cursor location."/>  
            <button id="tableButton" label="Insert Table"  
                 screentip="Table" onAction="OnTableButton"  
                 supertip="Inserts a table at the cursor location."/>  
        </group>  
    </tab>  
    ```  
  
## Automating the Document by Using the Buttons  
 You must add `onAction` callback methods for the **Insert Text** and **Insert Table** buttons to perform actions when the user clicks them. For more information about callback methods for Ribbon controls, see [Ribbon XML](../vsto/ribbon-xml.md).  
  
#### To add callback methods for the buttons  
  
1.  In **Solution Explorer**, right-click **MyRibbon.cs** or **MyRibbon.vb**, and then click **Open**.  
  
2.  Add the following code to the top of the **MyRibbon.cs** or **MyRibbon.vb** file. This code creates an alias for the <xref:Microsoft.Office.Interop.Word> namespace.  
  
     [!code-csharp[Trin_RibbonButtons#1](../vsto/codesnippet/CSharp/Trin_RibbonButtons/MyRibbon.cs#1)]
     [!code-vb[Trin_RibbonButtons#1](../vsto/codesnippet/VisualBasic/Trin_RibbonButtons/MyRibbon.vb#1)]  
  
3.  Add the following method to the `MyRibbon` class. This is a callback method for the **Insert Text** button that adds a string to the active document at the current location of the cursor.  
  
     [!code-csharp[Trin_Ribbon_Custom_Tab_XML#2](../vsto/codesnippet/CSharp/Trin_Ribbon_Custom_Tab_XML_O12/MyRibbon.cs#2)]
     [!code-vb[Trin_Ribbon_Custom_Tab_XML#2](../vsto/codesnippet/VisualBasic/Trin_Ribbon_Custom_Tab_XML_O12/MyRibbon.vb#2)]  
  
4.  Add the following method to the `MyRibbon` class. This is a callback method for the **Insert Table** button that adds a table to the active document at the current location of the cursor.  
  
     [!code-csharp[Trin_Ribbon_Custom_Tab_XML#3](../vsto/codesnippet/CSharp/Trin_Ribbon_Custom_Tab_XML_O12/MyRibbon.cs#3)]
     [!code-vb[Trin_Ribbon_Custom_Tab_XML#3](../vsto/codesnippet/VisualBasic/Trin_Ribbon_Custom_Tab_XML_O12/MyRibbon.vb#3)]  
  
## Testing the VSTO Add-In  
 When you run the project, Word opens and the tab named **Add-Ins** appears on the Ribbon. Click the **Insert Text** and **Insert Table** buttons on the **Add-Ins** tab to test the code.  
  
#### To test your VSTO Add-in  
  
1.  Press F5 to run your project.  
  
2.  Confirm that the **Add-Ins** tab is visible on the Ribbon.  
  
3.  Click the **Add-Ins** tab.  
  
4.  Confirm that the **Content** group is visible on the Ribbon.  
  
5.  Click the **Insert Text** button in the **Content** group.  
  
     A string is added to the document at the current location of the cursor.  
  
6.  Click the **Insert Table** button in the **Content** group.  
  
     A table is added to the document at the current location of the cursor.  
  
## Next Steps  
 You can learn more about how to customize the Office UI from these topics:  
  
-   Customize the Ribbon of a different Office application. For more information about the applications that support customizing the Ribbon, see [Ribbon Overview](../vsto/ribbon-overview.md).  
  
-   Customize the Ribbon of an Office application by using the Ribbon Designer. For more information, see [Ribbon Designer](../vsto/ribbon-designer.md).  
  
-   Create a custom actions pane. For more information, see [Actions Pane Overview](../vsto/actions-pane-overview.md).  
  
-   Customize the UI of Microsoft Office Outlook by using Outlook Form Regions. For more information, see [Walkthrough: Designing an Outlook Form Region](../vsto/walkthrough-designing-an-outlook-form-region.md).  
  
## See Also  
 [Ribbon Overview](../vsto/ribbon-overview.md)   
 [Ribbon XML](../vsto/ribbon-xml.md)   
 [Walkthrough: Creating a Custom Tab by Using the Ribbon Designer](../vsto/walkthrough-creating-a-custom-tab-by-using-the-ribbon-designer.md)  
  
  