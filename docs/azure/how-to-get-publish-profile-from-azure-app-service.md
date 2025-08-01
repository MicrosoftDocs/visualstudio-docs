---
title: Get a publish profile from Azure App Service
description: Get a publish profile file from Azure App Service with information and settings for Visual Studio to deploy applications and services to Azure.
author: ghogen
manager: mijacobs
ms.subservice: azure-development
ms.topic: how-to
ms.date: 08/01/2025
ms.author: ghogen
monikerRange: ">=vs-2019"
---

# Get a publish profile from Azure App Service

A publish profile is a file that contains information and settings that Visual Studio uses to deploy applications and services to Azure.

1. In the Azure portal, open the Azure App Service.
1. Make sure that **Basic authentication** is enabled. Go to **Settings**, **Configuration**, **General settings**, **SCM Basic Auth Publishing Credentials**, and choose **On**.
1. Go to **Download publish profile** and save the profile locally.

   :::image type="content" source="./media/app-service-get-publish-profile.png" alt-text="Screenshot showing how to get the publish profile from Azure App Service." lightbox="./media/app-service-get-publish-profile.png":::

A file with a `.publishsettings` extension is generated in the location you specified.

See also [Azure App Service](/azure/app-service).

> [!NOTE]
> When [basic authentication is disabled](/azure/app-service/configure-basic-auth-disable), **Download publish profile** and **Reset publish profile** are disabled.

