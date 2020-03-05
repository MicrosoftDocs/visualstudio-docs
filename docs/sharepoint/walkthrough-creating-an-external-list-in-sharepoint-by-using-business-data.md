---
title: "Create external list in SharePoint using business data"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Business Data Connectivity service [SharePoint development in Visual Studio], business data in a Web Part"
  - "BDC [SharePoint development in Visual Studio], external list"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], business data in a SharePoint list"
  - "BDC [SharePoint development in Visual Studio], business data in a SharePoint list"
  - "BDC [SharePoint development in Visual Studio], business data in a Web Part"
  - "BDC [SharePoint development in Visual Studio], entity backed list"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], entity backed list"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], external list"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Walkthrough: Create an external list in SharePoint by using business data

The Business Data Connectivity (BDC) service enables SharePoint to display business data from back-end server applications, Web services, and databases.

This walkthrough shows you how to create a model for the BDC service that returns information about contacts in a sample database. You will then create an external list in SharePoint by using this model.

This walkthrough illustrates the following tasks:

- Creating a project.
- Adding an entity to the model.
- Adding a finder method.
- Adding a Specific Finder method.
- Testing the project.

## Prerequisites

You need the following components to complete this walkthrough:

- Supported editions of Windows and SharePoint.

- Access to the AdventureWorks sample database. For more information about how to install the AdventureWorks database, see [SQL Server Sample Databases](https://github.com/Microsoft/sql-server-samples/releases/tag/adventureworks).

## Create a project that contains a BDC model

1. On the menu bar in Visual Studio, choose **File** > **New** > **Project**.

     The **New Project** dialog box opens.

2. Under either **Visual C#** or **Visual Basic**, expand the **SharePoint** node, and then choose the **2010** item.

3. In the **Templates** pane, choose **SharePoint 2010 Project**, name the project **AdventureWorksTest**, and then choose the **OK** button.

     The **SharePoint Customization Wizard** appears. In this wizard, you can specify the site that you'll use to debug the project and set the trust level of the solution.

4. Choose the **Deploy as a farm solution** option button to set the trust level.

5. Choose the **Finish** button to accept the default local SharePoint site.

6. In **Solution Explorer**, choose the SharePoint project node.

7. On the menu bar, choose **Project** > **Add New Item**.

     The **Add New Item** dialog box opens.

8. In the **Templates** pane, choose **Business Data Connectivity Model (Farm Solution Only)**, name the project **AdventureWorksContacts**, and then choose the **Add** button.

## Add data access classes to the project

1. On the menu bar, choose **Tools** > **Connect to Database**.

     The **Add Connection** dialog box opens.

2. Add a connection to the SQL Server AdventureWorks sample database.

     For more information, see [Add/Modify Connection (Microsoft SQL Server)](https://msdn.microsoft.com/fa400910-26c3-4df7-b9d1-115e688b4ea3).

3. In **Solution Explorer**, choose the project node.

4. On the menu bar, choose **Project** > **Add New Item**.

5. In the **Installed Templates** pane, choose the **Data** node.

6. In the **Templates** pane, choose **LINQ to SQL Classes**.

7. In the **Name** box, specify **AdventureWorks**, and then choose the **Add** button.

     A .dbml file is added to the project, and the Object Relational Designer (O/R Designer) opens.

8. On the menu bar, choose **View** > **Server Explorer**.

9. In **Server Explorer**, expand the node that represents the AdventureWorks sample database, and then expand the **Tables** node.

10. Add the **Contact (Person)** table onto the O/R Designer.

     An entity class is created and appears on the design surface. The entity class has properties that map to the columns in the Contact (Person) table.

## Remove the default entity from the BDC model

The **Business Data Connectivity Model** project adds a default entity named Entity1 to the model. Remove this entity. Later, you will add a new entity. Starting with an empty model reduces the number of steps required to complete the walkthrough.

1. In **Solution Explorer**, expand the **BdcModel1** node, and then open the *BdcModel1.bdcm* file.

2. The Business Data Connectivity model file opens in the BDC designer.

3. In the designer, open the shortcut menu for **Entity1**, and then choose **Delete**.

4. In **Solution Explorer**, open the shortcut menu for *Entity1.vb* (in Visual Basic) or *Entity1.cs* (in C#), and then choose **Delete**.

5. Open the shortcut menu for *Entity1Service.vb* (in Visual Basic) or *Entity1Service.cs* (in C#), and then choose **Delete**.

## Add an entity to the model

Add an entity to the model. You can add entities from the Visual Studio **Toolbox** onto the BDC designer.

1. On the menu bar, choose **View** > **Toolbox**.

2. On the **BusinessDataConnectivity** tab of the **Toolbox**, add an **Entity** onto the BDC designer.

     The new entity appears on the designer. Visual Studio adds a file that's named *EntityService.vb* (in Visual Basic) or *EntityService.cs* (in C#) to the project.

3. On the menu bar, choose **View** > **Properties** > **Window**.

4. In the **Properties** window, set the **Name** property value to **Contact**.

5. On the designer, open the shortcut menu for the entity, choose **Add**, and then choose **Identifier**.

     A new identifier appears on the entity.

6. In the **Properties** window, change the name of the identifier to **ContactID**.

7. In the **Type Name** list, choose **System.Int32**.

## Add a Specific Finder method

To enable the BDC service to display a specific contact, you must add a Specific Finder method. The BDC service calls the Specific Finder method when a user chooses an item in a list and then chooses the **View Item** button on the Ribbon.

Add a Specific Finder method to the Contact entity by using the **BDC Method Details** window. To return a specific entity, add code to the method.

1. On the BDC designer, choose the **Contact** entity.

2. On the menu bar, choose **View** > **Other Windows** > **BDC Method Details**.

     The BDC Method Details window opens.

3. In the **Add a Method** list, choose **Create Specific Finder Method**.

     Visual Studio adds the following elements to the model. These elements appear in the **BDC Method Details** window.

    - A method named ReadItem.

    - An input parameter for the method.

    - A return parameter for the method.

    - A type descriptor for each parameter.

    - A method instance for the method.

4. In the **BDC Method Details** window, open the list that appears for the **Contact** type descriptor, and then choose **Edit**.

     The **BDC Explorer** opens and provides a hierarchical view of the model.

5. In the **Properties** window, open the list next to the **TypeName** property, choose the **Current Project** tab, and then choose the **Contact** property.

6. In the **BDC Explorer**, open the shortcut menu of the **Contact**, and then choose **Add Type Descriptor**.

     A new type descriptor that's named **TypeDescriptor1** appears in the **BDC Explorer**.

7. In the **Properties** window, set the **Name** property value to **ContactID**.

8. Open the list next to the **TypeName** property, and then choose **Int32**.

9. Open the list next to the **Identifier** property, and then choose **ContactID**.

10. Repeat step 6 to create a type descriptor for each of the following fields.

    |Name|Type Name|
    |----------|---------------|
    |FirstName|System.String|
    |LastName|System.String|
    |Phone|System.String|
    |EmailAddress|System.String|
    |EmailPromotion|System.Int32|
    |NameStyle|System.Boolean|
    |PasswordHash|System.String|
    |PasswordSalt|System.String|

11. In the BDC designer, on the **Contact** entity, open the **ReadItem** method.

     The Contact service code file opens in Code Editor.

12. In the `ContactService` class, replace the `ReadItem` method with the following code. This code performs the following tasks:

    - Retrieves a record from Contact table of the AdventureWorks database.

    - Returns a Contact entity to the BDC service.

    > [!NOTE]
    > Replace the value of the `ServerName` field with the name of your server.

     [!code-csharp[SP_BDC#3](../sharepoint/codesnippet/CSharp/SP_BDC/bdcmodel1/contactservice.cs#3)]
     [!code-vb[SP_BDC#3](../sharepoint/codesnippet/VisualBasic/sp_bdc/bdcmodel1/contactservice.vb#3)]

## Add a finder method

To enable the BDC service to display the contacts in a list, you must add a Finder method. Add a Finder method to the Contact entity by using the **BDC Method Details** window. To return a collection of entities to the BDC service, add code to the method.

1. In the BDC designer, choose the **Contact** entity.

2. In the **BDC Method Details** window, collapse the **ReadItem** node.

3. In the **Add a Method** list under the **ReadList** method, choose **Create Finder Method**.

     Visual Studio adds a method, a return parameter, and a type descriptor.

4. In the BDC designer, on the **Contact** entity, open the **ReadList** method.

     The code file for the Contact service opens in Code Editor.

5. In the `ContactService` class, replace the `ReadList` method with the following code. This code performs the following tasks:

   - Retrieves data from the Contacts table of the AdventureWorks database.

   - Returns a list of Contact entities to the BDC service.

     > [!NOTE]
     > Replace the value of the `ServerName` field with the name of your server.

     [!code-csharp[SP_BDC#2](../sharepoint/codesnippet/CSharp/SP_BDC/bdcmodel1/contactservice.cs#2)]
     [!code-vb[SP_BDC#2](../sharepoint/codesnippet/VisualBasic/sp_bdc/bdcmodel1/contactservice.vb#2)]

## Test the project

When you run the project, the SharePoint site opens and Visual Studio adds your model to the Business Data Connectivity service. Create an external list in SharePoint that references the Contact entity. The data for contacts in the AdventureWorks database appear in the list.

> [!NOTE]
> You might have to modify your security settings in SharePoint before you can debug your solution. For more information, see [Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md).

1. Choose the **F5** key.

     The SharePoint site opens.

2. On the **Site Actions** menu, choose the **More Options** command.

3. On the **Create** page, choose the **External List** template, and then choose the **Create** button.

4. Name the custom list **Contacts**.

5. Choose the browse button next to the **External Content Type** field.

6. In the **External Content Type Picker** dialog box, choose the **AdventureWorksContacts.BdcModel1.Contact** item, and then choose the **Create** button.

     SharePoint creates an external list that contains contacts from the AdventureWorks sample database.

7. To test the Specific Finder method, choose a contact in the list.

8. On the Ribbon, choose the **Items** tab, and then choose the **View Item** command.

     The details of the contact that you chose appear on a form.

## Next steps

You can learn more about how to design models for the BDC service in SharePoint from these topics:

- [How to: Add a Creator method](../sharepoint/how-to-add-a-creator-method.md).
- [How to: Add an Updater method](../sharepoint/how-to-add-an-updater-method.md).
- [How to: Add a Deleter method](../sharepoint/how-to-add-a-deleter-method.md).

## See also

[Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md)
[Create a business data connectivity model](../sharepoint/creating-a-business-data-connectivity-model.md)
[BDC model design tools overview](../sharepoint/bdc-model-design-tools-overview.md)
[Integrate business data into SharePoint](../sharepoint/integrating-business-data-into-sharepoint.md)
