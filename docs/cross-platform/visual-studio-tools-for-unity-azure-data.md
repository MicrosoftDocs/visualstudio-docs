---
title: "Visual Studio Tools for Unity Azure Walkthrough Data Model| Microsoft Docs"
ms.custom: ""
ms.date: "10/19/2017"
ms.reviewer: "crdun"
ms.suite: ""
ms.technology: 
  - "tgt-pltfrm-cross-plat"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 6FCCA8D1-0D06-4B2A-A55F-FC3D1FEA0F56
author: "dantogno"
ms.author: "v-davian"
manager: "crdun"
ms.workload: 
  - "azure"
  - "unity"
---

# Create data model classes

The Unity project must contain data model classes that correspond with the tables created in the Azure Mobile App backend.

## Create the CrashInfo class

1. In Unity, add a new folder in the root **Assets** directory named **Scripts**. Inside of the new Scripts folder, create another new folder named **Data Models**. This is for organization only.

2. Inside the new Data Models folder, create a new C# script called **CrashInfo**.

3. Open the new `CrashInfo` script, delete any template code, including the class declaration and using statements, and add the following:

  ```csharp
  public class CrashInfo
  {
      public string Id { get; set; }
      public float X { get; set; }
      public float Y { get; set; }
      public float Z { get; set; }
  }
  ```

  > [!WARNING]
  > For the walkthrough to work correctly, the name of the data model class must match the name of the Easy Table created on the Azure Mobile App backend.

## Create the HighScoreInfo class

1. Inside the Data Models folder, create a new C# script called **HighScoreInfo**.

2. Open the new `HighScoreInfo` script, delete any template code, including the class declaration and using statements, and add the following:

  ```csharp
  public class HighScoreInfo
  {
      public string Name { get; set; }
      public float Time { get; set; }
      public string Id { get; set; }
  }
  ```

  ## Next step

  * [Implement the Azure MobileServiceClient](visual-studio-tools-for-unity-azure-mobile-client.md)
