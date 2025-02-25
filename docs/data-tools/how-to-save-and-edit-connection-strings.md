---
title: Save and edit database connection strings (.NET Framework)
description: Learn how to save and edit database connection strings in a .NET Framework application development environment with Visual Studio, including directly in application settings.
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
ms.topic: how-to
ms.date: 02/25/2025

---

# Save and edit database connection strings for .NET Framework applications

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

This article provides guidance for handling database connection strings in Windows applications. However, for cloud and web applications, more secure techniques are available. You can use [Connected Services](../azure/overview-connected-services.md) to add support for the *secrets.json* file for local development, and then migrate to Azure Key Vault for secrets storage when you deploy to Azure. For more information, see [Protect secrets during development](/aspnet/core/security/app-secrets?tabs=windows).

To avoid security risks, it important to properly handle the connection string in a Visual Studio application. Connection strings in Visual Studio applications are often saved in the application configuration file (also referred to as application settings), or hard-coded directly in your application. Hard-coding a connection string directly in your application isn't recommended, because its sensitive information, such as database credentials, can be read directly from the unencrypted binaries. It's more secure to save your connection strings in the application configuration file, which also simplifies the task of maintaining your application. If the connection string needs to be changed, you can update it in the application settings file, instead of changing it in the source code and recompiling the application.

Storing sensitive information (such as the password) within the connection string can affect the security of your application. Connection strings saved to the application configuration file aren't encrypted or obfuscated, so it might be possible for someone to access the file and view its contents.

For databases that support it, using Windows integrated security is a more secure way to control access to a database.

If you don't choose to use Windows integrated security and your database requires a user name and password, you can omit them from the connection string. However, your application must provide this information to successfully connect to the database. For example, you can create a dialog box that prompts the user for this information and dynamically builds the connection string at run time. However, security can still be an issue if the information is intercepted on the way to the database.

For more information, see [Protecting connection information](/dotnet/framework/data/adonet/protecting-connection-information).

## To save a connection string from within the Data Source Configuration Wizard

1. On the **Choose Your Data Connection** page, select a data connection and choose **Next**.
1. On the **Save the Connection String to the Application Configuration File** page, select the option to save the connection to the application configuration file.

## To save a connection string directly in application settings

1. In Solution Explorer, do one of the following steps, depending on your project type:

   - For a C# project, expand the project and double-click the **Properties** node.
   - For a Visual Basic project, expand the project and double-click the **My Project** node.

   The Project Designer opens.

1. Select the **Settings** tab.
1. Enter a **Name** for the connection string. Refer to this name when accessing the connection string in code.
1. Set the **Type** to **(Connection string)**.
1. Leave the **Scope** set to **Application**.
1. Enter your connection string in the **Value** field, or select the **ellipsis** (**...**) button in the **Value** field to open the **Connection Properties** dialog box to build your connection string.

## Edit connection strings stored in application settings

You can modify connection information that is saved in application settings by using the Project Designer.

### To edit a connection string stored in application settings

1. In Solution Explorer, do one of the following steps, depending on your project type:

   - For a C# project, expand the project and double-click the **Properties** node.
   - For a Visual Basic project, expand the project and double-click the **My Project** node.

   The Project Designer opens.

1. Select the **Settings** tab.
1. Locate the connection you want to edit and select the text in its **Value** field.
1. Edit the connection string in the **Value** field, or select the **ellipsis** (*...*) button in the **Value** field to edit your connection with the **Connection Properties** dialog box.

## Edit connection strings for datasets

You can modify connection information for each TableAdapter in a dataset.

### To edit a connection string for a TableAdapter in a dataset

1. In Solution Explorer, double-click the dataset (*.xsd* file) that has the connection you want to edit.
1. Select the **TableAdapter** or query that has the connection you want to edit.
1. In the **Properties** window, expand the **Connection** node.
1. To quickly modify the connection string, edit the **ConnectionString** property, or select the down arrow on the **Connection** node and choose **New Connection**.

## Security

Storing sensitive information (such as a password) within the connection string can affect the security of your application. Use Windows integrated security for a more secure way to control access to a database.
For more information, see [Protect connection information](/dotnet/framework/data/adonet/protecting-connection-information).

## Related content

- [Connect to a database in Visual Studio](../data-tools/add-new-connections.md)
