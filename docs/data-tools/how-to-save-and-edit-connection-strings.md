---
title: "How to: Save and Edit Connection Strings | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: f8ef3a2c-029c-423b-9d9e-a4f1add4f640
caps.latest.revision: 14
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.technology: "vs-data-tools"
ms.workload: 
  - "data-storage"
---
# How to: Save and Edit Connection Strings
Connection strings in Visual Studio applications can be saved in the application configuration file (also referred to as application settings), or hard-coded directly in your application. Saving connection strings in the application configuration file simplifies the task of maintaining your application. If the connection string needs to be changed, then you can update it in the application settings file (as opposed to having to change it in the source code and recompile the application).

Storing sensitive information (such as the password) within the connection string can affect the security of your application. Connection strings saved to the application configuration file are not encrypted or obfuscated, so it may be possible for someone to access the file and view its contents. Using Windows Integrated Security is a more secure way to control access to a database.

If you do not choose to use Windows integrated security and your database requires a user name and password, you can omit them from the connection string, but your application will need to provide this information to successfully connect to the database. For example, you can create a dialog box that prompts the user for this information and dynamically builds the connection string at run time. Security can still be an issue if the information is intercepted on the way to the database. 
For more information, see [Protecting Connection Information](/dotnet/framework/data/adonet/protecting-connection-information).

## To save a connection string from within the Data Source Configuration Wizard
In the **Data Source Configuration Wizard**, select the option to save the connection on the Save the Connection String to the Application Configuration File page.

## To save a connection string directly into application settings
- In Solution Explorer, double-click the My Project icon (Visual Basic) or Properties icon (C#) to open the Project Designer.
- Select the Settings tab.
- Enter a Name for the connection string. Refer to this name when accessing the connection string in code.
- Set the Type to (Connection string).
- Leave the Scope set to Application.
- Type your connection string into the Value field, or click the ellipsis (...) button in the Value field to open the Connection Properties dialog box to build your connection string.  

## Editing connection strings stored in application settings
You can modify connection information that is saved in application settings by using the Project Designer.  

### To edit a connection string stored in application settings
- In Solution Explorer, double-click the My Project icon (Visual Basic) or Properties icon (C#) to open the Project Designer.
- Select the Settings tab.
- Locate the connection you want to edit and select the text in the Value field.
- Edit the connection string in the Value field, or click the ellipsis (...) button in the Value field to edit your connection with the Connection Properties dialog box.  

## Editing connection strings for datasets
You can modify connection information for each TableAdapter in a dataset.  

### To edit a connection string for a TableAdapter in a dataset
- In Solution Explorer, double-click the dataset (.xsd file) that has the connection you want to edit.
- Select the TableAdapter or query that has the connection you want to edit.
- In the Properties window, expand the Connection node.
- To quickly modify the connection string, edit the ConnectionString property, or click the down arrow on the Connection property and choose New Connection.

## Security
Storing sensitive information (such as a password) within the connection string can affect the security of your application. Using Windows integrated security is a more secure way to control access to a database.
For more information, see [Protecting Connection Information](/dotnet/framework/data/adonet/protecting-connection-information).
  
## See also
[Adding connections](../data-tools/add-new-connections.md)