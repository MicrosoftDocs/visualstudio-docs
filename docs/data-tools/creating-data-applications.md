---
title: "Creating Data Applications | Microsoft Docs"
ms.custom: ""
ms.date: "11/02/2016"
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
  - "data access [Visual Studio], creating applications"
  - "applications [Visual Studio], data"
  - "data [Visual Studio]"
  - "data [Visual Studio], creating applications"
ms.assetid: ab334d5f-4f49-4346-bce0-3325d6130b3e
caps.latest.revision: 41
author: "mikeblome"
ms.author: "mblome"
manager: "ghogen"
robots: noindex,nofollow
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
# Creating Data Applications
Visual Studio provides many design-time tools to help you create applications that access data. This introduction presents an overview of the basic processes involved in creating applications that work with data. The information here deliberately skips over many details and is designed as a source of general information and a jumping-off point to the many other Help pages associated with creating a data application.  
  
 As you develop applications that access data in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], you will have different requirements. In some cases, you might simply want to display data on a form. In other cases, you might need to devise a way to share information with other applications or processes.  
  
 No matter what you do with data, there are certain fundamental concepts that you should understand. You might never need to know some of the details of data handling — for example, you might never need to programmatically create a database — but it is very useful to understand the basic data concepts, as well as the data tools (wizards and designers) available in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].  
  
 A typical data application uses most of the processes illustrated in the following diagram:  
  
 ![Data Cycle graphic](../data-tools/media/datacyclegraphicinfo.gif "datacyclegraphicinfo")  
The Data Cycle  
  
 As you create your application, think of the task you are trying to accomplish. Use the following sections to assist in finding the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] tools and objects that are available to you.  
  
> [!NOTE]
>  [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] provides wizards to simplify several of the processes shown in the previous diagram. For example, running the **Data Source Configuration Wizard** provides your application with enough information to connect to data, create a typed dataset to receive the data, and bring the data into your application.  
  
 To quickly see how [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] helps you in developing data applications, see [Walkthrough: Creating a Simple Data Application](../Topic/Walkthrough:%20Creating%20a%20Simple%20Data%20Application.md).  
  
## Connecting to Data  
 To bring data into your application (and send changes back to the data source), some kind of two-way communication needs to be established. This two-way communication is typically handled by objects in your data model.  
  
 For example, a `TableAdapter` connects applications that use datasets to a database, and <xref:System.Data.Objects.ObjectContext> connects entities in the Entity Framework to a database. [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] provides several tools to assist in creating connections that can be used by your application. For more information on connecting your application to data, see [Connecting to Data in Visual Studio](../data-tools/connecting-to-data-in-visual-studio.md).  
  
 To learn how to use datasets to connect your application to data in a database, see [Walkthrough: Connecting to Data in a Database (Windows Forms)](../Topic/Walkthrough:%20Connecting%20to%20Data%20in%20a%20Database%20\(Windows%20Forms\).md).  
  
## Preparing Your Application to Receive Data  
 If your application uses a disconnected data model you need to temporarily store the data in your application while you work with it. Visual Studio provides tools that help you create the objects that your application uses to temporarily store data: datasets, entities, and [!INCLUDE[vbtecdlinq](../data-tools/includes/vbtecdlinq_md.md)] objects.  
  
> [!NOTE]
>  An application that uses a disconnected data model will typically connect to a database, run a query bringing data into the application, disconnect from the database, and then manipulate the data offline before reconnecting and updating the database.  
  
 For more information on creating typed datasets in your application, see [Preparing Your Application to Receive Data](../Topic/Preparing%20Your%20Application%20to%20Receive%20Data.md). For additional information about using datasets in n-tier applications, see [Separate datasets and TableAdapters into different projects](../data-tools/separate-datasets-and-tableadapters-into-different-projects.md).  
  
 To learn how to create a dataset, complete the procedures in [Walkthrough: Creating a Dataset with the Dataset Designer](../data-tools/walkthrough-creating-a-dataset-with-the-dataset-designer.md).  
  
 To learn how to create [!INCLUDE[vbtecdlinq](../data-tools/includes/vbtecdlinq_md.md)] objects, complete the procedures in [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](../Topic/Walkthrough:%20Creating%20LINQ%20to%20SQL%20Classes%20\(O-R%20Designer\).md).  
  
## Fetching Data into Your Application  
 Whether your application uses a disconnected data model or not, you need to be able to fetch data into your application. You bring data into your application by executing queries or stored procedures against a database. Applications that store data in datasets execute queries and stored procedures by using `TableAdapter`s, whereas applications that store data in entities execute queries by using [LINQ to Entities](../Topic/LINQ%20to%20Entities.md) or by connecting entities directly to stored procedures. For more information about creating and editing queries that use TableAdapters, see [How to: Create TableAdapter Queries](../data-tools/how-to-create-tableadapter-queries.md) and [How to: Edit TableAdapter Queries](../data-tools/how-to-edit-tableadapter-queries.md).  
  
 For more information about loading data into datasets, and about executing queries and stored procedures, see [Fetching Data into Your Application](../data-tools/fetching-data-into-your-application.md).  
  
 To learn how to load data into a dataset, complete the procedures in [Walkthrough: Displaying Data on a Windows Form](../data-tools/walkthrough-displaying-data-on-a-windows-form.md) and examine the code in the form-load event handler.  
  
 To learn how to load data into [!INCLUDE[vbtecdlinq](../data-tools/includes/vbtecdlinq_md.md)] objects, complete the procedures in [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](../Topic/Walkthrough:%20Creating%20LINQ%20to%20SQL%20Classes%20\(O-R%20Designer\).md).  
  
 To learn how to create and execute a SQL query, see [How to: Create and Execute an SQL Statement that Returns Rows](../Topic/How%20to:%20Create%20and%20Execute%20an%20SQL%20Statement%20that%20Returns%20Rows.md).  
  
 To learn how to execute a stored procedure, see [How to: Execute a Stored Procedure that Returns Rows](../Topic/How%20to:%20Execute%20a%20Stored%20Procedure%20that%20Returns%20Rows.md).  
  
## Displaying Data on Forms  
 After bringing data into your application, you will typically display it on a form for users to view or modify. [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] provides the [Data Sources Window](../Topic/Data%20Sources%20Window.md), where you can drag items onto forms to automatically create data-bound controls that display data. For more information on data binding and displaying data to users, see [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md).  
  
 To learn how to present data to users, complete the procedures in the following walkthroughs (paying particular attention to the process of dragging items from the **Data Sources** window):  
  
-   [Walkthrough: Displaying Data on a Windows Form](../data-tools/walkthrough-displaying-data-on-a-windows-form.md).  
  
-   [Bind WPF controls to a WCF data service](../data-tools/bind-wpf-controls-to-a-wcf-data-service.md)  
  
-   [Walkthrough: Binding Silverlight Controls to a WCF Data Service](../Topic/Walkthrough:%20Binding%20Silverlight%20Controls%20to%20a%20WCF%20Data%20Service.md)  
  
## Editing Data in Your Application  
 Once your users have been presented with data, they will likely modify it by adding new records and editing and deleting records prior to sending the data back to the database.  
  
 For more information on working with the data once it is loaded into your dataset, see [Editing Data in Your Application](../data-tools/editing-data-in-your-application.md).  
  
## Validating Data  
 When making changes to data, you will typically want to verify the changes before allowing the values to be accepted back into the dataset or written to the database. *Validation* is the name of the process for verifying that these new values are acceptable for the requirements of your application. You can add logic to check values in your application as they change. Visual Studio provides tools that assist in adding code that validates data during column and row changes. For more information, see [Validating Data](../Topic/Validating%20Data.md).  
  
 To learn how to add data validation to your application, see [Walkthrough: Adding Validation to a Dataset](../Topic/Walkthrough:%20Adding%20Validation%20to%20a%20Dataset.md).  
  
 To learn how to add validation to a dataset that is separated into an n-tier application, see [Add validation to an n-tier dataset](../data-tools/add-validation-to-an-n-tier-dataset.md).  
  
## Saving Data  
 After making changes in your application (and validating those changes), you typically want to send the changes back to the database. Applications that store data in datasets typically use a TableAdapterManager to save data. For more information, see [TableAdapterManager Overview](../Topic/TableAdapterManager%20Overview.md). Entity Framework applications use the <xref:System.Data.Objects.ObjectContext.SaveChanges%2A> method to save data.  
  
 For more information on sending updated data back to a database, see [Saving Data](../data-tools/saving-data.md).  
  
 To learn how to send updated data from a dataset to a database, complete the procedures in [Walkthrough: Saving Data from Related Data Tables (Hierarchical Update)](../Topic/Walkthrough:%20Saving%20Data%20from%20Related%20Data%20Tables%20\(Hierarchical%20Update\).md).  
  
## Related Topics  
 [Overview of Data Applications in Visual Studio](../data-tools/overview-of-data-applications-in-visual-studio.md)  
 Provides links to topics that discuss how to create applications that work with data.  
  
 [Connecting to Data in Visual Studio](../data-tools/connecting-to-data-in-visual-studio.md)  
 Provides links to topics about how to use [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] to connect your application to data and create data sources for your applications.  
  
 [Preparing Your Application to Receive Data](../Topic/Preparing%20Your%20Application%20to%20Receive%20Data.md)  
 Provides links to topics that explain how to work with data models in your application, including datasets and Entity Data Models.  
  
 [Fetching Data into Your Application](../data-tools/fetching-data-into-your-application.md)  
 Provides links to topics that describe how to load data into your application.  
  
 [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)  
 Provides links to topics that explain how to binding Windows Forms controls, WPF controls, and Silverlight controls to data sources.  
  
 [Editing Data in Your Application](../data-tools/editing-data-in-your-application.md)  
 Provides links to topics that describe how to change data in your application.  
  
 [Validating Data](../Topic/Validating%20Data.md)  
 Provides links to topics that describe how to add validation to data changes.  
  
 [Saving Data](../data-tools/saving-data.md)  
 Provides links to topics that explain how to send updated data from your application to a database, or how to save it to other formats such as XML.  
  
 [Tools for Working with Data Sources in Visual Studio](../Topic/Tools%20for%20Working%20with%20Data%20Sources%20in%20Visual%20Studio.md)  
 Provides links to topics about tools that you can use to work with data sources in Visual Studio, such as the **Data Sources** window and the ADO.NET Entity Data Model Designer.