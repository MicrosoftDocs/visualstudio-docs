---
title: "Read XML data into a dataset | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords: 
  - "reading XML"
  - "data access [Visual Studio], XML data"
  - "reading files, XML"
  - "data [Visual Studio], reading from XML files"
  - "reading data, XML files"
  - "XML [Visual Studio], reading"
  - "XML documents, reading"
  - "datasets [Visual Basic], reading XML data"
ms.assetid: fae72958-0893-47d6-b3dd-9d42418418e4
caps.latest.revision: 18
author: "mikeblome"
ms.author: "mblome"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Read XML data into a dataset
ADO.NET provides simple methods for working with XML data. In this walkthrough, you  create a Windows application that  loads XML data into a dataset. The dataset is then displayed in a <xref:System.Windows.Forms.DataGridView> control. Finally, an XML schema based on the contents of the XML file is displayed in a text box.  
  
 This walkthrough consists of five main steps:  
  
1.  Creating a new project  
  
2.  Creating an XML file to be read into the dataset  
  
3.  Creating the user interface  
  
4.  Creating the dataset, reading the XML file, and displaying it in a <xref:System.Windows.Forms.DataGridView> control  
  
5.  Adding code to display the XML schema based on the XML file in a <xref:System.Windows.Forms.TextBox> control  
  
> [!NOTE]
>  The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or the edition you're using. To change your settings, on the  **Tools** menu, select**Import and Export Settings**. For more information, see [Customizing Development Settings in Visual Studio](http://msdn.microsoft.com/en-us/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
## Create a new project  
 In this step, you  create a Visual Basic or Visual C# project that  contains this walkthrough.  
  
#### To create the new Windows project  
  
1.  On the **File** menu, create a new project.  
  
2.  Name the project `ReadingXML`.  
  
3.  Select **Windows Application**, and then select**OK**. For more information, see [Client Applications](../Topic/Developing%20Client%20Applications%20with%20the%20.NET%20Framework.md).  
  
     The **ReadingXML** project is created and added to **Solution Explorer**.  
  
## Generate the XML file to be read into the dataset  
 Because this walkthrough focuses on reading XML data into a dataset, the contents of an XML file is provided.  
  
#### To create the XML file that will be read into the dataset  
  
1.  On the **Project** menu, select**Add New Item**.  
  
2.  Select **XML File**, name the file `authors.xml`, and then select**Add**.  
  
     The XML file loads into the designer and is ready for edit.  
  
3.  Paste the following code into the editor below the XML declaration:  
  
    ```xml  
    <Authors_Table>  
      <authors>  
        <au_id>172-32-1176</au_id>  
        <au_lname>White</au_lname>  
        <au_fname>Johnson</au_fname>  
        <phone>408 496-7223</phone>  
        <address>10932 Bigge Rd.</address>  
        <city>Menlo Park</city>  
        <state>CA</state>  
        <zip>94025</zip>  
        <contract>true</contract>  
      </authors>  
      <authors>  
        <au_id>213-46-8915</au_id>  
        <au_lname>Green</au_lname>  
        <au_fname>Margie</au_fname>  
        <phone>415 986-7020</phone>  
        <address>309 63rd St. #411</address>  
        <city>Oakland</city>  
        <state>CA</state>  
        <zip>94618</zip>  
        <contract>true</contract>  
      </authors>  
      <authors>  
        <au_id>238-95-7766</au_id>  
        <au_lname>Carson</au_lname>  
        <au_fname>Cheryl</au_fname>  
        <phone>415 548-7723</phone>  
        <address>589 Darwin Ln.</address>  
        <city>Berkeley</city>  
        <state>CA</state>  
        <zip>94705</zip>  
        <contract>true</contract>  
      </authors>  
      <authors>  
        <au_id>267-41-2394</au_id>  
        <au_lname>Hunter</au_lname>  
        <au_fname>Anne</au_fname>  
        <phone>408 286-2428</phone>  
        <address>22 Cleveland Av. #14</address>  
        <city>San Jose</city>  
        <state>CA</state>  
        <zip>95128</zip>  
        <contract>true</contract>  
      </authors>  
      <authors>  
        <au_id>274-80-9391</au_id>  
        <au_lname>Straight</au_lname>  
        <au_fname>Dean</au_fname>  
        <phone>415 834-2919</phone>  
        <address>5420 College Av.</address>  
        <city>Oakland</city>  
        <state>CA</state>  
        <zip>94609</zip>  
        <contract>true</contract>  
      </authors>  
    </Authors_Table>  
    ```  
  
4.  On the **File** menu, select**Save authors.xml**.  
  
## Create the user interface  
 The user interface for this application consists of the following:  
  
-   A <xref:System.Windows.Forms.DataGridView> control that displays the contents of the XML file as data.  
  
-   A <xref:System.Windows.Forms.TextBox> control that displays the XML schema for the XML file.  
  
-   Two <xref:System.Windows.Forms.Button> controls.  
  
    -   One button reads the XML file into the dataset and displays it in the <xref:System.Windows.Forms.DataGridView> control.  
  
    -   A second button extracts the schema from the dataset, and through a <xref:System.IO.StringWriter%2C> displays it in the <xref:System.Windows.Forms.TextBox> control.  
  
#### To add controls to the form  
  
1.  Open `Form1` in design view.  
  
2.  From the **Toolbox**, drag the following controls onto the form:  
  
    -   One <xref:System.Windows.Forms.DataGridView> control  
  
    -   One <xref:System.Windows.Forms.TextBox> control  
  
    -   Two <xref:System.Windows.Forms.Button> controls  
  
3.  Set the following properties:  
  
    |Control|Property|Setting|  
    |-------------|--------------|-------------|  
    |`TextBox1`|**Multiline**|`true`|  
    ||**ScrollBars**|**Vertical**|  
    |`Button1`|**Name**|`ReadXmlButton`|  
    ||**Text**|`Read XML`|  
    |`Button2`|**Name**|`ShowSchemaButton`|  
    ||**Text**|`Show Schema`|  
  
## Create the dataset thatreceives the XML data  
 In this step, you create a new dataset named `authors`. For more information about datasets, see [Dataset tools in Visual Studio](../data-tools/dataset-tools-in-visual-studio.md).  
  
#### To create a new dataset that  receives the XML data  
  
1.  In **Solution Explorer**, select the source file for **Form1**, and then select the **View Designer** button on the **Solution Explorer** toolbar.  
  
2.  From the [Toolbox, Data Tab](../ide/reference/toolbox-data-tab.md), drag a **DataSet** onto **Form1**.  
  
3.  In the **Add Dataset** dialog box, select **Untyped dataset**, and then select**OK**.  
  
     **DataSet1** is added to the component tray.  
  
4.  In the **Properties** window, set the **Name** and <xref:System.Data.DataSet.DataSetName%2A> properties for`AuthorsDataSet`.  
  
## Create the event handler to read the XML file into the dataset  
 The **Read XML** button reads the XML file into the dataset. It then sets properties on the <xref:System.Windows.Forms.DataGridView> control that bind it to the dataset.  
  
#### To add code to the ReadXmlButton_Click event handler  
  
1.  In **Solution Explorer**, select **Form1**,  and then select the **View Designer** button on the **Solution Explorer** toolbar.  
  
2.  Select the **Read XML** button.  
  
     The **Code Editor** opens at the `ReadXmlButton_Click` event handler.  
  
3.  Type the following code into the `ReadXmlButton_Click` event handler:  
  
     [!code-cs[VbRaddataFillingAndExecuting#2](../data-tools/codesnippet/CSharp/read-xml-data-into-a-dataset_1.cs)]
     [!code-vb[VbRaddataFillingAndExecuting#2](../data-tools/codesnippet/VisualBasic/read-xml-data-into-a-dataset_1.vb)]  
  
4.  In the `ReadXMLButton_Click` event handler code, change the `filepath =` entry to the correct path.  
  
## Create the event handler to display the schema in the textbox  
 The **Show Schema** button creates a <xref:System.IO.StringWriter> object that's filled with the schema and is displayed in the <xref:System.Windows.Forms.TextBox>control.  
  
#### To add code to the ShowSchemaButton_Click event handler  
  
1.  In **Solution Explorer**, select **Form1**, and then select the **View Designer** button.  
  
2.  Select the **Show Schema** button.  
  
     The **Code Editor** opens at the `ShowSchemaButton_Click` event handler.  
  
3.  Type the following code into the `ShowSchemaButton_Click` event handler.  
  
     [!code-cs[VbRaddataFillingAndExecuting#3](../data-tools/codesnippet/CSharp/read-xml-data-into-a-dataset_2.cs)]
     [!code-vb[VbRaddataFillingAndExecuting#3](../data-tools/codesnippet/VisualBasic/read-xml-data-into-a-dataset_2.vb)]  
  
## Test the form  
 You can now test the form to make sure it behaves as expected.  
  
#### To test the form  
  
1.  Select**F5** to run the application.  
  
2.  Select the **Read XML** button.  
  
     The DataGridView displays the contents of the XML file.  
  
3.  Select the **Show Schema** button.  
  
     The text box displays the XML schema for the XML file.  
  
## Next Steps  
 This walkthrough teaches you the basics of reading an XML file into a dataset, as well as creating a schema based on the contents of the XML file. Here are some tasks that you might do next:  
  
-   Edit the data in the dataset and write it back out as XML. For more information, see <xref:System.Data.DataSet.WriteXml%2A>.  
  
-   Edit the data in the dataset and write it out to a database. For more information, see [Saving Data](../data-tools/saving-data.md).  
  
## See Also  
 [Data Walkthroughs](../Topic/Data%20Walkthroughs.md)   
 [Accessing data in Visual Studio](../data-tools/accessing-data-in-visual-studio.md)   
 [Preparing Your Application to Receive Data](../Topic/Preparing%20Your%20Application%20to%20Receive%20Data.md)   
 [XML Tools in Visual Studio](../xml-tools/xml-tools-in-visual-studio.md)