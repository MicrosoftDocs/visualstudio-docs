---
title: "Tutorial: Flask and MongoDB on Azure | Microsoft Docs"
ms.custom: ""
ms.date: "2/22/2017"
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "devlang-python"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 3af6ff52-4b0d-43e2-bb2d-e15acd7488d9
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
translation.priority.ht:
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---

# Tutorial: Flask and MongoDB on Azure

[!INCLUDE[include](../../includes/tutorial-azure-mongodb-intro.md)]

[![Flask and MongoDB on Azure video](media/video-thumbnails/Flask-and-MongoDB-on-Azure.png)](http://www.youtube.com/watch?v=eql-crFgrAE)

[!INCLUDE[include](../../includes/tutorial-azure-mongodb-topic-toc.md)]

[!INCLUDE[include](../../includes/tutorial-prereqs.md)]

[!INCLUDE[include](../../includes/tutorial-create-intro.md)]

1. In Visual Studio, select **File > New > Project**, search for "Flask", select the **Polls Flask Web Project**, and click **OK**. If you don't see the Polls project template, you may not have installed the PTVS Sample Pack, and you may need to restart Visual Studio.
   
  ![Flask project templates](media/tutorial-flask-new-project.png)

## Create a MongoDB database

For the database, create a MongoLab hosted database on Azure as follows. (Alternately, you can [create an Azure Virtual Machine and install and administer MongoDB directly](https://docs.microsoft.com/en-us/azure/virtual-machines/virtual-machines-windows-classic-install-mongodb).)


You can create a free trial with MongoLab by following these steps.

1. Log into the [Azure Management Portal](https://manage.windowsazure.com).

1. At the bottom of the navigation pane, click **NEW**.

  ![New](media/PollsCommonAzurePlusNew.png)

1. Click **STORE**, then **MongoLab**.

  ![MongoLab Step 1](media/PollsCommonMongoLabAddon1.png)

1. In Name, type a name to use for the database service.

1. Choose a Region/Affinity Group in which to locate the database service. If 
   you will be using the database from your Azure application, select the same 
   region where you will deploy your application.

  ![MongoLab Step 2](media/PollsCommonMongoLabAddon2.png)

1. Click **PURCHASE**.