---
title: "How to: Enable and Disable Automatic Code Analysis for Managed Code | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: vs-ide-code-analysis
ms.tgt_pltfrm: ""
ms.topic: "article"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "dotnet"
---
# How to: Enable and disable automatic code analysis for managed code

You can configure code analysis to run after each build of a managed code project. You can set different code analysis properties for each build configuration.

## To enable or disable automatic code analysis

1. In **Solution Explorer**, right-click the project, and then choose **Properties**.

1. In the properties dialog box for the project, choose **Code Analysis**.

1. Specify the build type in **Configuration** and the target platform in **Platform**.

1. To enable or disable automatic code analysis, select or clear the **Enable Code Analysis on Build** check box.
