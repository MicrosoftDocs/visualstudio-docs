---
title: Bind content controls to custom XML parts in Visual Studio
description: Bind content controls in a document-level customization for Microsoft Office Word to XML data that is stored in the document.
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "PlainTextContentControl, binding to a custom XML part"
  - "custom XML parts, binding to content controls"
  - "content controls [Office development in Visual Studio], data binding"
  - "data binding [Office development in Visual Studio], content controls"
  - "DropDownListContentControl, binding items to a custom XML part"
  - "DatePickerContentControl, binding to a custom XML part"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Walkthrough: Bind content controls to custom XML parts

  This walkthrough demonstrates how to bind content controls in a document-level customization for Word to XML data that is stored in the document.

 [!INCLUDE[appliesto_wdalldoc](../vsto/includes/appliesto-wdalldoc-md.md)]

 Word enables you to store XML data, named *custom XML parts*, in a document. You can control the display of this data by binding content controls to elements in a custom XML part. The example document in this walkthrough displays employee information that is stored in a custom XML part. When you open the document, the content controls display the values of the XML elements. Any changes that you make to the text in the content controls are saved in the custom XML part.

 This walkthrough illustrates the following tasks:

- Adding content controls to the Word document in a document-level project at design time.

- Creating an XML data file and an XML schema that defines the elements to bind to the content controls.

- Attaching the XML schema to the document at design time.

- Adding the contents of the XML file to a custom XML part in the document at run time.

- Binding the content controls to elements in the custom XML part.

- Binding a <xref:Microsoft.Office.Tools.Word.DropDownListContentControl> to a set of values that are defined in the XML schema.

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsto_vsprereq](../vsto/includes/vsto-vsprereq-md.md)]

- Microsoft Word.

## Create a new Word document project
 Create a Word document that you will use in the walkthrough.

### To create a new Word document project

1. Create a Word document project with the name **EmployeeControls**. Create a new document for the solution. For more information, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

     Visual Studio opens the new Word document in the designer and adds the **EmployeeControls** project to **Solution Explorer**.

## Add content controls to the document
 Create a table that contains three different types of content controls where the user can view or edit information about an employee.

### To add content controls to the document

1. In the Word document that is hosted in the Visual Studio designer, on the Ribbon, choose the **Insert** tab.

2. In the **Tables** group, choose **Table**, and insert a table with 2 columns and 3 rows.

3. Type text in the first column so that it resembles the following column:

   ||
   |-|
   |**Employee Name**|
   |**Hire Date**|
   |**Title**|

4. In the second column of the table, choose the first row (next to **Employee Name**).

5. On the Ribbon, choose the **Developer** tab.

   > [!NOTE]
   > If the **Developer** tab is not visible, you must first show it. For more information, see [How to: Show the developer tab on the ribbon](../vsto/how-to-show-the-developer-tab-on-the-ribbon.md).

6. In the **Controls** group, choose the **Text** button ![PlainTextContentControl](../vsto/media/plaintextcontrol.gif "PlainTextContentControl") to add a <xref:Microsoft.Office.Tools.Word.PlainTextContentControl> to the first cell.

7. In the second column of the table, choose the second row (next to **Hire Date**).

8. In the **Controls** group, choose the **Date Picker** button ![DatePickerContentControl](../vsto/media/datepicker.gif "DatePickerContentControl") to add a <xref:Microsoft.Office.Tools.Word.DatePickerContentControl> to the second cell.

9. In the second column of the table, choose the third row (next to **Title**).

10. In the **Controls** group, choose the **Drop-Down List** button ![DropDownListContentControl](../vsto/media/dropdownlist.gif "DropDownListContentControl") to add a <xref:Microsoft.Office.Tools.Word.DropDownListContentControl> to the last cell.

    That is the entire user interface for this project. If you run the project now, you can type text in the first row and select a date in the second row. The next step is to attach the data that you want to display to the document in an XML file.

## Create the XML data file
 Typically, you will obtain XML data to store in a custom XML part from an external source, such as a file or a database. In this walkthrough, you create an XML file that contains the employee data, marked by elements that you will bind to the content controls in the document. To make the data available at run time, embed the XML file as a resource in the customization assembly.

#### To create the data file

1. On the **Project** menu, choose **Add New Item**.

     The **Add New Item** dialog box appears.

2. In the **Templates** pane, select **XML File**.

3. Name the file **employees.xml**, and then choose the **Add** button.

     The **employees.xml** file opens in the Code Editor.

4. Replace the contents of the **employees.xml** file with the following text.

    ```xml
    <?xml version="1.0" encoding="utf-8" ?>
    <employees xmlns="http://schemas.microsoft.com/vsto/samples">
      <employee>
        <name>Karina Leal</name>
        <hireDate>1999-04-01</hireDate>
        <title>Manager</title>
      </employee>
    </employees>
    ```

5. In **Solution Explorer**, choose the **employees.xml** file.

6. In the **Properties** window, select the **Build Action** property, and then change the value to **Embedded Resource**.

     This step embeds the XML file as a resource in the assembly when you build the project. This enables you to access the contents of the XML file at run time.

## Create an XML Schema
 If you want to bind a content control to a single element in a custom XML part, you do not have to use an XML schema. However, to bind the <xref:Microsoft.Office.Tools.Word.DropDownListContentControl> to a set of values, you must create an XML schema that validates the XML data file that you created earlier. The XML schema defines the possible values for the `title` element. You will bind the <xref:Microsoft.Office.Tools.Word.DropDownListContentControl> to this element later in this walkthrough.

#### To create an XML schema

1. On the **Project** menu, choose **Add New Item**.

     The **Add New Item** dialog box appears.

2. In the **Templates** pane, select **XML Schema**.

3. Name the schema **employees.xsd** and choose the **Add** button.

     The schema designer opens.

4. In **Solution Explorer**, open the shortcut menu for  **employees.xsd**, and then choose  **View Code**.

5. Replace the contents of the **employees.xsd** file with the following schema.

    ```xml
    <?xml version="1.0" encoding="utf-8" ?>
    <xs:schema xmlns="http://schemas.microsoft.com/vsto/samples"
        targetNamespace="http://schemas.microsoft.com/vsto/samples"
        xmlns:xs="http://www.w3.org/2001/XMLSchema"
        elementFormDefault="qualified">
      <xs:element name="employees" type="EmployeesType"></xs:element>
      <xs:complexType name="EmployeesType">
        <xs:all>
          <xs:element name="employee" type="EmployeeType"/>
        </xs:all>
      </xs:complexType>
      <xs:complexType name="EmployeeType">
        <xs:sequence>
          <xs:element name="name" type="xs:string" minOccurs="1" maxOccurs="1"/>
          <xs:element name="hireDate" type="xs:date" minOccurs="1" maxOccurs="1"/>
          <xs:element name="title" type="TitleType" minOccurs="1" maxOccurs="1"/>
        </xs:sequence>
      </xs:complexType>
      <xs:simpleType name="TitleType">
        <xs:restriction base="xs:string">
          <xs:enumeration value ="Engineer"/>
          <xs:enumeration value ="Designer"/>
          <xs:enumeration value ="Manager"/>
        </xs:restriction>
      </xs:simpleType>
    </xs:schema>
    ```

6. On the **File** menu, click **Save All** to save your changes to the **employees.xml** and the **employees.xsd** files.

## Attach the XML schema to the document
 You must attach the XML schema to the document to bind the <xref:Microsoft.Office.Tools.Word.DropDownListContentControl> to the valid values of the `title` element.

### To attach the XML schema to the document (  Word 2013 )

1. Activate **EmployeeControls.docx** in the designer.

2. On the Ribbon, choose the **Developer** tab, and then choose the **Add-Ins** button.

3. In the **Templates and Add-ins** dialog box, choose the **XML Schema** tab, and then choose the **Add Schema** button.

4. Browse to the **employees.xsd** schema you created earlier, which is located in your project directory, and then choose the **Open** button.

5. Choose the **OK** button in the **Schema Settings** dialog box.

6. Choose the **OK** button to close the **Templates and Add-ins** dialog box.

### To attach the XML schema to the document (Word 2010)

1. Activate **EmployeeControls.docx** in the designer.

2. On the Ribbon, choose the **Developer** tab.

3. In the **XML** group, choose the **Schema** button.

4. In the **Templates and Add-ins** dialog box, choose the **XML Schema** tab, and then choose the **Add Schema** button.

5. Browse to the **employees.xsd** schema that you created earlier, which is located in your project directory, and choose the **Open** button.

6. Choose the **OK** button in the **Schema Settings** dialog box.

7. Choose the **OK** button to close the **Templates and Add-ins** dialog box.

     The **XML Structure** task pane opens.

8. Close the **XML Structure** task pane.

## Add a custom XML part to the document
 Before you can bind the content controls to the elements in the XML file, you must add the contents of the XML file to a new custom XML part in the document.

### To add a custom XML part to the document

1. In **Solution Explorer**, open the shortcut menu for  **ThisDocument.cs** or **ThisDocument.vb**, and then choose **View Code**.

2. Add the following declarations to the `ThisDocument` class. This code declares several objects that you will use to add a custom XML part to the document.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/EmployeeControls/ThisDocument.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/EmployeeControls/ThisDocument.vb" id="Snippet1":::
     ---

3. Add the following method to the `ThisDocument` class. This method gets the contents of the XML data file that is embedded as a resource in the assembly, and returns the contents as an XML string.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/EmployeeControls/ThisDocument.cs" id="Snippet3":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/EmployeeControls/ThisDocument.vb" id="Snippet3":::
     ---

4. Add the following method to the `ThisDocument` class. The `AddCustomXmlPart` method creates a new custom XML part that contains an XML string that is passed to the method.

     To ensure that the custom XML part is only created once, the method creates the custom XML part only if a custom XML part with a matching GUID does not already exist in the document. The first time this method is called, it saves the value of the <xref:Microsoft.Office.Core._CustomXMLPart.Id%2A> property to the `employeeXMLPartID` string. The value of the `employeeXMLPartID` string is persisted in the document because it was declared by using the <xref:Microsoft.VisualStudio.Tools.Applications.Runtime.CachedAttribute> attribute.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/EmployeeControls/ThisDocument.cs" id="Snippet4":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/EmployeeControls/ThisDocument.vb" id="Snippet4":::
     ---

## Bind the content controls to elements in the custom XML part
 Bind each content control to an element in the custom XML part by using the **XMLMapping** property of each content control.

### To bind the content controls to elements in the custom XML part

1. Add the following method to the `ThisDocument` class. This method binds each content control to an element in the custom XML part and sets the date display format of the <xref:Microsoft.Office.Tools.Word.DatePickerContentControl>.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/EmployeeControls/ThisDocument.cs" id="Snippet5":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/EmployeeControls/ThisDocument.vb" id="Snippet5":::
     ---

## Run your code when the document is opened
 Create the custom XML part and bind the custom controls to the data when the document is opened.

### To run your code when the document is opened

1. Add the following code to the `ThisDocument_Startup` method of the `ThisDocument` class. This code gets the XML string from the **employees.xml** file, adds the XML string to a new custom XML part in the document, and binds the content controls to elements in the custom XML part.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/EmployeeControls/ThisDocument.cs" id="Snippet2":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/EmployeeControls/ThisDocument.vb" id="Snippet2":::
     ---

## Test the project
 When you open the document, the content controls display data from the elements in the custom XML part. You can click the <xref:Microsoft.Office.Tools.Word.DropDownListContentControl> to select one of three valid values for the `title` element, which are defined in the **employees.xsd** file. If you edit the data in any of the content controls, the new values are saved in the custom XML part in the document.

### To test the content controls

1. Press **F5** to run the project.

2. Verify that the table in the document resembles the following table. Each of the strings in the second column is obtained from an element in the custom XML part in the document.

    |Column|Value|
    |-|-|
    |**Employee Name**|**Karina Leal**|
    |**Hire Date**|**April 1, 1999**|
    |**Title**|**Manager**|

3. Choose the cell to the right of the **Employee Name** cell and type a different name.

4. Choose the cell to the right of the **Hire Date** cell and select a different date in the date picker.

5. Choose the cell to the right of the **Title** cell and select a new item from the drop-down list.

6. Save and close the document.

7. In File Explorer, open the *\bin\Debug* folder under the location of your project.

8. Open the shortcut menu for **EmployeeControls.docx** and then choose **Rename**.

9. Name the file **EmployeeControls.docx.zip**.

     The **EmployeeControls.docx** document is saved in the Open XML Format. By renaming this document with the *.zip* file name extension, you can examine the contents of the document. For more information about Open XML, see the technical article [Introducing the Office (2007) Open XML file formats](/previous-versions/office/developer/office-2007/aa338205(v=office.12)).

10. Open the **EmployeeControls.docx.zip** file.

11. Open the **customXml** folder.

12. Open the shortcut menu for **item2.xml** and then choose **Open**.

     This file contains the custom XML part that you added to the document.

13. Verify that the `name`, `hireDate`, and `title` elements contain the new values that you entered into the content controls in the document.

14. Close the **item2.xml** file.

## Next steps
 You can learn more about how to use content controls from these topics:

- Use all the available content controls to create a template. For more information, see [Walkthrough: Create a template by using content controls](../vsto/walkthrough-creating-a-template-by-using-content-controls.md).

- Modify the data in the custom XML parts while the document is closed. The next time the user opens the document, the content controls that are bound to the XML elements will display the new data.

- Use content controls to protect parts of a document. For more information, see [How to: Protect parts of documents by using content controls](../vsto/how-to-protect-parts-of-documents-by-using-content-controls.md).

## Related content
- [Automate Word by using extended objects](../vsto/automating-word-by-using-extended-objects.md)
- [Content controls](../vsto/content-controls.md)
- [How to: Add content controls to Word documents](../vsto/how-to-add-content-controls-to-word-documents.md)
- [How to: Protect parts of documents by using content controls](../vsto/how-to-protect-parts-of-documents-by-using-content-controls.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
- [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md)
