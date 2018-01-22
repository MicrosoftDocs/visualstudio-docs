---
title: Troubleshooting Azure remote debugging for Python in Visual Studio | Microsoft Docs
ms.custom: ""
ms.date: 07/12/2017
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-python"
ms.devlang: python
ms.tgt_pltfrm: ""
ms.topic: "article"
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: ghogen
ms.workload: 
  - "python"
  - "data-science"
  - "azure"
---

# Remote debugging rroubleshooter for Python and Azure

Visual Studio fails to attach to an [Azure App Service for remote debugging](debugging-azure-remote.md) for any of the following reasons:

| Reason | Resolution |
| --- | --- |
| You do not have Visual Studio 2013 Update 4 or later installed. | Install a suitable version from [visualstudio.com](https://www.visualstudio.com/downloads/). | 
| The project that's deployed to App Service doesn't match the one open in Visual Studio. | Load the correct project into Visual Studio. |
| The project wasn't deployed with the Debug configuration. | Redeploy the application by right-clicking the project in Solution Explorer and selecting **Publish**. In the **Settings** tab, make sure **Debug** is the selected configuration. |
| The App Service isn't running. | Start it from Server Explorer in Visual Studio or from the Azure portal. |
| The App Service isn't configured for web sockets. | Go to the [Azure portal](https://portal.azure.com), navigate to your App Service, open the  **Settings > Application settings** blade, turn **General settings > Web sockets** to **On**, and select **Save**. (Note that the **Debugging** options shown on this blade do *not* apply to Python debugging.) |
| `web.debug.config` was modified to disable the debug proxy. | Delete the file and republish the project to App Service, during which time Visual Studio recreates the file. |

See also:

- [Azure remote debugging for Python](debugging-azure-remote.md)
