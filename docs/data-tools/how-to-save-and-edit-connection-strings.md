---
title: Save and edit database connection strings (.NET Framework)
description: Learn how to save and edit database connection strings in a .NET Framework application development environment with Visual Studio, including directly in application settings.
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
ms.topic: how-to
ms.date: 02/25/2025

# Customer intent: As a developer, I want to learn how to save and edit database connection strings for .NET Framework applications in Visual Studio so that I can avoid security risks by not saving them in my applications.

---

# Save and edit database connection strings for .NET Framework applications

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

This article provides guidance for handling database connection strings in Windows applications. However, for cloud and web applications, more secure techniques are available. You can use [Connected Services](../azure/overview-connected-services.md) to add support for the *secrets.json* file for local development, and then migrate to Azure Key Vault for secrets storage when you deploy to Azure. For more information, see [Protect secrets during development](/aspnet/core/security/app-secrets?tabs=windows).

## Security considerations

To avoid security risks, it's important to properly handle the connection string in a Visual Studio application.
Connection strings in Visual Studio applications are often saved in the application configuration file (also referred to as application settings), or hard-coded directly in your application. Hard-coding directly into the application isn't recommended, because the sensitive information in the connection string, such as the database credentials, can be read directly from the unencrypted binaries. It's more secure to save your connection strings in the application configuration file, which also simplifies the task of maintaining your application. If the connection string needs to be changed, you can update it in the application settings file, instead of changing it in the source code and recompiling the application.

If you store sensitive information, such as a password, within the connection string it can affect the security of your application. Because connection strings saved to the application configuration file aren't encrypted, it might be possible for someone to access the file and view its contents.
If your database requires a user name and password, you can omit them from the connection string. However, your application must somehow provide this information to successfully connect to the database. For example, if you create a dialog box that prompts a user for a name and password and dynamically builds a connection string at run time, this information might be intercepted on the way to the database.

To avoid these security issues, for databases that support it, use Windows integrated security for a more secure way to control access to a database. For more information, see [Protect connection information](/dotnet/framework/data/adonet/protecting-connection-information).

## Save database connection strings

You can save a database connection string in application settings or in a dataset.

### Save a connection string in application settings

To save a connection string directly in application settings, follow these steps:

1. In **Solution Explorer**, do one of the following steps, depending on your project type:

   - For a C# project, expand the project and double-click the **Properties** node.
   - For a Visual Basic project, expand the project and double-click the **My Project** node.

   The Project Designer opens.

1. Select the **Settings** tab.

1. Enter a **Name** for the connection string. Refer to this name when accessing the connection string in code.

1. Set the **Type** to **(Connection string)**.

1. Leave the **Scope** set to **Application**.

1. Enter your connection string in the **Value** field, or select the **ellipsis** (**...**) button in the **Value** field to open the **Connection Properties** dialog box to build your connection string.

### Save a connection string in a dataset

To save a connection string in a dataset by using the Data Source Configuration Wizard, follow these steps:

1. On the **Choose Your Data Connection** page, select a data connection and choose **Next**.

1. On the **Save the Connection String to the Application Configuration File** page, select the option to save the connection to the application configuration file.

## Edit database connection strings

You can edit an existing database connection string in application settings or in a dataset.

### Edit a connection string in application settings

To edit a connection string in application settings:

1. In **Solution Explorer**, do one of the following steps, depending on your project type:

   - For a C# project, expand the project and double-click the **Properties** node.
   - For a Visual Basic project, expand the project and double-click the **My Project** node.

   The Project Designer opens.

1. Select the **Settings** tab.

1. Locate the connection you want to edit and select the text in its **Value** field.

1. Edit the connection string in the **Value** field, or select the **ellipsis** (*...*) button in the **Value** field to edit your connection with the **Connection Properties** dialog box.

## Edit a connection string in a dataset

You can modify connection information for a TableAdapter or query in a dataset.

To edit a connection string in a dataset, follow these steps:

1. In **Solution Explorer**, double-click the dataset (*.xsd* file) that has the connection you want to edit.

1. Select the **TableAdapter** or query that has the connection you want to edit.

1. In the **Properties** window, expand the **Connection** node.

1. To modify the connection string, edit the **ConnectionString** property, or select the down arrow on the **Connection** node and choose **New Connection**.

## Related content

- [Connect to a database in Visual Studio](../data-tools/add-new-connections.md)
