---
title: "Create WCF Data Service with WPF & Entity Framework"
ms.date: 11/04/2016
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "data services in Visual Studio"
  - "WCF Data Services, Visual Studio"
  - "ADO.NET Data Services, Visual Studio"
  - "WCF data services in Visual Studio"
ms.assetid: da66ad1b-a25d-485c-af13-2d18f0422e3d
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "data-storage"
---
# Walkthrough: Creating a WCF Data Service with WPF and Entity Framework
This walkthrough demonstrates how to create a simple [!INCLUDE[ss_data_service](../data-tools/includes/ss_data_service_md.md)] that is hosted in an [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] web application and then access it from a Windows Forms application.

In this walkthrough you:

- Create a web application to host a [!INCLUDE[ss_data_service](../data-tools/includes/ss_data_service_md.md)].

- Create an [!INCLUDE[adonet_edm](../data-tools/includes/adonet_edm_md.md)] that represents the `Customers` table in the Northwind database.

- Create a [!INCLUDE[ss_data_service](../data-tools/includes/ss_data_service_md.md)].

- Create a client application and add a reference to the [!INCLUDE[ss_data_service](../data-tools/includes/ss_data_service_md.md)].

- Enable data binding to the service and generate the user interface.

- Optionally add filtering capabilities to the application.

## Prerequisites
This walkthrough uses SQL Server Express LocalDB and the Northwind sample database.

1. If you don't have SQL Server Express LocalDB, install it either from the [SQL Server Express download page](https://www.microsoft.com/sql-server/sql-server-editions-express), or through the **Visual Studio Installer**. In the **Visual Studio Installer**, you can install SQL Server Express LocalDB as part of the **Data storage and processing** workload, or as an individual component.

2. Install the Northwind sample database by following these steps:

    1. In Visual Studio, open the **SQL Server Object Explorer** window. (**SQL Server Object Explorer** is installed as part of the **Data storage and processing** workload in the Visual Studio Installer.) Expand the **SQL Server** node. Right-click on your LocalDB instance and select **New Query**.

       A query editor window opens.

    2. Copy the [Northwind Transact-SQL script](https://github.com/MicrosoftDocs/visualstudio-docs/blob/master/docs/data-tools/samples/northwind.sql?raw=true) to your clipboard. This T-SQL script creates the Northwind database from scratch and populates it with data.

    3. Paste the T-SQL script into the query editor, and then choose the **Execute** button.

       After a short time, the query finishes running and the Northwind database is created.

## Creating the Service
To create a [!INCLUDE[ss_data_service](../data-tools/includes/ss_data_service_md.md)], you will add a web project, create an [!INCLUDE[adonet_edm](../data-tools/includes/adonet_edm_md.md)], and then create the service from the model.

In the first step, you add a web project to host the service.

[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

### To create the web project

1. On the menu bar, choose **File** > **New** > **Project**.

2. In the **New Project** dialog box, expand the **Visual Basic** or **Visual C#** and **Web** nodes, and then choose the **ASP.NET Web Application** template.

3. In the **Name** text box, enter **NorthwindWeb**, and then choose the **OK** button.

4. In the **New ASP.NET Project** dialog box, in the **Select a template** list, choose **Empty**, and then choose the **OK** button.

In the next step, you create an [!INCLUDE[adonet_edm](../data-tools/includes/adonet_edm_md.md)] that represents the `Customers` table in the Northwind database.

### To create the Entity Data Model

1. On the menu bar, choose **Project** > **Add New Item**.

2. In the **Add New Item** dialog box, choose the **Data** node, and then choose the **ADO.NET Entity Data Model** item.

3. In the **Name** text box, enter `NorthwindModel`, and then choose the **Add** button.

     The Entity Data Model Wizard appears.

4. In the Entity Data Model Wizard, on the **Choose Model Contents** page, choose the **EF Designer from database** item, and then choose the **Next** button.

5. On the **Choose Your Data Connection** page, perform one of the following steps:

    - If a data connection to the Northwind sample database is available in the drop-down list, choose it.

         -or-

    - Choose the **New Connection** button to configure a new data connection. For more information, see [Add new connections](../data-tools/add-new-connections.md).

6. If the database requires a password, choose the **Yes, include sensitive data in the connection string** option button, and then choose the **Next** button.

    > [!NOTE]
    > If a dialog box appears, choose **Yes** to save the file to your project.

7. On the **Choose your version** page, choose the **Entity Framework 5.0** option button, and then choose the **Next** button.

    > [!NOTE]
    > In order to use the latest version of the Entity Framework 6 with WCF Services, you'll need to install the WCF Data Services Entity Framework Provider NuGet package. See [Using WCF Data Services 5.6.0 with Entity Framework 6+](https://devblogs.microsoft.com/odata/using-wcf-data-services-5-6-0-with-entity-framework-6/).

8. On the **Choose Your Database Objects** page, expand the **Tables** node, select the **Customers** check box, and then choose the **Finish** button.

     The entity model diagram displays, and a *NorthwindModel.edmx* file is added to your project.

In the next step, you create and test the data service.

### To create the data service

1. On the menu bar, choose **Project** > **Add New Item**.

2. In the **Add New Item** dialog box, choose the **Web** node, and then choose the **WCF Data Service 5.6** item.

3. In the **Name** text box, enter `NorthwindCustomers`, and then choose the **Add** button.

     The **NorthwindCustomers.svc** file appears in the **Code Editor**.

4. In the **Code Editor**, locate the first `TODO:` comment and replace the code with the following:

     [!code-vb[WCFDataServiceWalkthrough#1](../data-tools/codesnippet/VisualBasic/walkthrough-creating-a-wcf-data-service-with-wpf-and-entity-framework_1.vb)]
     [!code-csharp[WCFDataServiceWalkthrough#1](../data-tools/codesnippet/CSharp/walkthrough-creating-a-wcf-data-service-with-wpf-and-entity-framework_1.cs)]

5. Replace the comments in the `InitializeService` event handler with the following code:

     [!code-vb[WCFDataServiceWalkthrough#2](../data-tools/codesnippet/VisualBasic/walkthrough-creating-a-wcf-data-service-with-wpf-and-entity-framework_2.vb)]
     [!code-csharp[WCFDataServiceWalkthrough#2](../data-tools/codesnippet/CSharp/walkthrough-creating-a-wcf-data-service-with-wpf-and-entity-framework_2.cs)]

6. On the menu bar, choose **Debug** > **Start Without Debugging** to run the service. A browser window opens and the XML schema for the service displays.

7. In the **Address** bar, enter `Customers` at the end of the URL for **NorthwindCustomers.svc**, and then choose the **Enter** key.

     An XML representation of the data in the `Customers` table appears.

    > [!NOTE]
    > In some cases, Internet Explorer will misinterpret the data as an RSS feed. You must make sure that the option to display RSS feeds is disabled. For more information, see [Troubleshooting service references](../data-tools/troubleshooting-service-references.md).

8. Close the browser window.

In the next steps, you create a Windows Forms client application to consume the service.

## Creating the Client Application
To create the client application, you add a second project, add a service reference to the project, configure a data source, and create a user interface to display the data from the service.

In the first step, you add a Windows Forms project to the solution and set it as the startup project.

### To create the client application

1. On the menu bar, choose File, **Add** > **New Project**.

2. In the **New Project** dialog box, expand the **Visual Basic** or **Visual C#** node, choose the **Windows** node, and then choose **Windows Forms Application**.

3. In the **Name** text box, enter `NorthwindClient`, and then choose the **OK** button.

4. In **Solution Explorer**, choose the **NorthwindClient** project node.

5. On the menu bar, choose **Project**, **Set as StartUp Project**.

In the next step, you add a service reference to the [!INCLUDE[ss_data_service](../data-tools/includes/ss_data_service_md.md)] in the web project.

### To add a service reference

1. On the menu bar, choose **Project** > **Add Service Reference**.

2. In the **Add Service Reference** dialog box, choose the **Discover** button.

     The URL for the NorthwindCustomers service appears in the **Address** field.

3. Choose the **OK** button to add the service reference.

In the next step, you configure a data source to enable data binding to the service.

### To enable data binding to the service

1. On the menu bar, choose **View** > **Other Windows** > **Data Sources**.

   The **Data Sources** window opens.

2. In the **Data Sources** window, choose the **Add New Data Source** button.

3. On the **Choose a Data Source Type** page of the **Data Source Configuration Wizard**, choose **Object**, and then choose the **Next** button.

4. On the **Select the Data Objects** page, expand the **NorthwindClient** node, and then expand the **NorthwindClient.ServiceReference1** node.

5. Select **Customer** check box, and then choose the **Finish** button.

In the next step, you create the user interface that displays the data from the service.

### To create the user interface

1. In the **Data Sources** window, open the shortcut menu for the **Customers** node and choose **Copy**.

2. In the **Form1.vb** or **Form1.cs** form designer, open the shortcut menu and choose **Paste**.

    A <xref:System.Windows.Forms.DataGridView> control, a <xref:System.Windows.Forms.BindingSource> component, and a <xref:System.Windows.Forms.BindingNavigator> component are added to the form.

3. Choose the **CustomersDataGridView** control, and then in the **Properties** window set the **Dock** property to **Fill**.

4. In **Solution Explorer**, open the shortcut menu for the **Form1** node and choose **View Code** to open the Code Editor, and add the following `Imports` or `Using` statement at the top of the file:

   ```vb
   Imports NorthwindClient.ServiceReference1
   ```

   ```csharp
   using NorthwindClient.ServiceReference1;
   ```

5. Add the following code to the `Form1_Load` event handler:

   ```vb
   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
           Dim proxy As New NorthwindEntities _
   (New Uri("http://localhost:53161/NorthwindCustomers.svc/"))
           Me.CustomersBindingSource.DataSource = proxy.Customers
       End Sub
   ```

   ```csharp
   private void Form1_Load(object sender, EventArgs e)
   {
   NorthwindEntities proxy = new NorthwindEntities(new Uri("http://localhost:53161/NorthwindCustomers.svc/"));
   this.CustomersBindingSource.DataSource = proxy.Customers;
   }
   ```

6. In **Solution Explorer**, open the shortcut menu for the **NorthwindCustomers.svc** file and choose **View in Browser**. Internet Explorer opens and the XML schema for the service displays.

7. Copy the URL from the Internet Explorer address bar.

8. In the code that you added in step 4, select `http://localhost:53161/NorthwindCustomers.svc/` and replace it with the URL that you just copied.

9. On the menu bar, choose **Debug** > **Start Debugging** to run the application. The customer information is shown.

   You now have a working application that displays a list of customers from the NorthwindCustomers service. If you want to expose additional data through the service, you can modify the [!INCLUDE[adonet_edm](../data-tools/includes/adonet_edm_md.md)] to include additional tables from the Northwind database.

In the next optional step, you learn how to filter the data that is returned by the service.

## Adding Filtering Capabilities
In this step, you customize the application to filter the data by the customer's city.

### To add filtering by city

1. In **Solution Explorer**, open the shortcut menu for the **Form1.vb** or **Form1.cs** node and choose **Open**.

2. Add a <xref:System.Windows.Forms.TextBox> control and a <xref:System.Windows.Forms.Button> control from the **Toolbox** to the form.

3. Open the shortcut menu for the <xref:System.Windows.Forms.Button> control, choose **View Code**, and then add the following code in the `Button1_Click` event handler:

    ```vb
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim proxy As New northwindEntities _
    (New Uri("http://localhost:53161/NorthwindCustomers.svc"))
            Dim city As String = TextBox1.Text

            If city <> "" Then
                Me.CustomersBindingSource.DataSource = From c In _
             proxy.Customers Where c.City = city
            End If

        End Sub
    ```

    ```csharp
    private void Button1_Click(object sender, EventArgs e)
    {
    ServiceReference1.northwindModel.northwindEntities proxy = new northwindEntities(new Uri("http://localhost:53161/NorthwindCustomers.svc"));
    string city = TextBox1.Text;

    if (!string.IsNullOrEmpty(city)) {
    this.CustomersBindingSource.DataSource = from c in proxy.Customers where c.City == city;
    }

    }
    ```

4. In the previous code, replace `http://localhost:53161/NorthwindCustomers.svc` with the URL from the `Form1_Load` event handler.

5. On the menu bar, choose **Debug** > **Start Debugging** to run the application.

6. In the text box, enter **London**, and then choose the button. Only the customers from London are displayed.

## See also

- [Windows Communication Foundation Services and WCF Data Services in Visual Studio](../data-tools/windows-communication-foundation-services-and-wcf-data-services-in-visual-studio.md)
- [How to: Add, update, or remove a WCF Data Service reference](../data-tools/how-to-add-update-or-remove-a-wcf-data-service-reference.md)