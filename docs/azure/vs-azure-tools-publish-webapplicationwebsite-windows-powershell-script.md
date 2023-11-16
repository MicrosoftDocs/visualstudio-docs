---
title: Publish a web app by using a PowerShell script
description: Learn how to publish a web project to an Azure website. This script creates the required resources in your Azure subscription if they don't exist.
author: ghogen
manager: jmartens
ms.technology: vs-azure
ms.topic: conceptual
ms.date: 11/11/2016
ms.author: ghogen
---
# Publish-WebApplicationWebSite (Windows PowerShell script)

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

 [!INCLUDE [Cloud Services](./includes/cloud-services-legacy.md)]

## Syntax
Publishes a web project to an Azure website. The script creates the required resources in your Azure subscription if they don't exist.

```
Publish-WebApplicationWebSite
–Configuration <configuration>
-SubscriptionName <subscriptionName>
-WebDeployPackage <packageName>
-DatabaseServerPassword @{Name = "name"; Password = "password"}
-SendHostMessagesToOutput
-Verbose
```

## Configuration
The path to the JSON configuration file that describes the details of the deployment.

| Parameter | Default value |
| --- | --- |
| Aliases |none |
| Required? |true |
| Position |named |
| Default value |none |
| Accept pipeline input? |false |
| Accept wildcard characters? |false |

## SubscriptionName
The name of the Azure subscription that you want to create the website in.

| Parameter | Default value |
| --- | --- |
| Aliases |none |
| Required? |false |
| Position |named |
| Default value |none |
| Accept pipeline input? |false |
| Accept wildcard characters? |false |

## WebDeployPackage
The path to the web deployment package to publish to the website. You can create this package by using the Publish Web wizard in Visual Studio. For more information, see [Get started with Azure Cloud Services and ASP.NET](vs-azure-tools-publish-webapplicationwebsite-windows-powershell-script.md).

| Parameter | Default value |
| --- | --- |
| Aliases |none |
| Required? |false |
| Position |named |
| Default value |none |
| Accept pipeline input? |false |
| Accept wildcard characters? |false |

## DatabaseServerPassword
The username and password for the SQL database in Azure.

| Parameter | Default value |
| --- | --- |
| Aliases |none |
| Required? |false |
| Position |named |
| Default value |none |
| Accept pipeline input? |false |
| Accept wildcard characters? |false |

## SendHostMessagesToOutput
If true, print messages from the script to the output stream.

| Parameter | Default value |
| --- | --- |
| Aliases |none |
| Required? |false |
| Position |named |
| Default value |false |
| Accept pipeline input? |false |
| Accept wildcard characters? |false |

## Remarks
For a complete explanation of how to use the script to create Dev and Test environments, see [Using Windows PowerShell Scripts to Publish to Dev and Test Environments](vs-azure-tools-publishing-using-powershell-scripts.md).

The JSON configuration file specifies the details of what is to be deployed. It includes the information that you specified when you created the project, such as the name and username for the website. It also includes the database to provision, if any. The following code shows an example JSON configuration file:

```json
{
    "environmentSettings": {
        "webSite": {
            "name": "WebApplication10554",
            "location": "West US"
        },
        "databases": [
            {
                "connectionStringName": "DefaultConnection",
                "databaseName": "WebApplication10554_db",
                "serverName": "iss00brc88",
                "user": "sqluser2",
                "password": "",
                "edition": "",
                "size": "",
                "collation": "",
                "location": "West US"
            }
        ]
    }
}
```

You can edit the JSON configuration file to change what is deployed. A webSite section is required, but the database section is optional.

## Related content
For more information, see [Publish-WebApplicationVM (Windows PowerShell script)](vs-azure-tools-publish-webapplicationvm.md).
