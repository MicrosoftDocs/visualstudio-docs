---
title: "Get a publish profile from Azure App Service"
description: Get a publish profile file from Azure App Service with information and settings for Visual Studio to deploy applications and services to Azure.
author: ghogen
manager: jmartens
ms.subservice: azure-development
ms.topic: how-to
ms.date: 10/19/2021
ms.author: ghogen
monikerRange: ">=vs-2019"
---
# Get a publish profile from Azure App Service

A publish profile is a file that contains information and settings that Visual Studio uses to deploy applications and services to Azure.

1. In the Azure portal, open the Azure App Service.
2. Go to Get publish profile and save the profile locally.

   :::image type="content" source="./media/app-service-get-publish-profile.png" alt-text="Screenshot showing how to get the publish profile from Azure App Service." lightbox="./media/app-service-get-publish-profile.png":::

A file with a .publishsettings file extension has been generated in the location where you saved it.

See also [Azure App Service](/azure/app-service).

> [!NOTE]
> When [basic authentication is disabled](/azure/app-service/configure-basic-auth-disable), you can't view or configure deployment credentials in the Deployment Center.
