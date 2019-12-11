---
title: "ClickOnce Deployment Samples and Walkthroughs | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "applications [Visual Studio], walkthroughs"
  - "Visual Studio, deployment walkthroughs"
  - "Visual Studio, walkthroughs"
ms.assetid: 3973276b-7b11-4692-a0a2-32bebf0b9c2a
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# ClickOnce deployment samples and walkthroughs
This section contains sample applications, example code, and step-by-step walkthroughs that illustrate the syntax, structure, and techniques used to deploy Windows Forms, WPF, and console applications.

 The sample code is intended for instructional purposes, and should not be used in deployed solutions without modifications. In particular, security must be taken into greater consideration.

## ClickOnce deployment

|Topic|Description|
|-----------|-----------------|
|[Deploy a ClickOnce application manually](../deployment/walkthrough-manually-deploying-a-clickonce-application.md)|Explains how to use .NET Framework utilities to deploy your ClickOnce application.|
|[Download assemblies on demand with the ClickOnce deployment API](../deployment/walkthrough-downloading-assemblies-on-demand-with-the-clickonce-deployment-api.md)|Demonstrates how to mark certain assemblies in your application as "optional," and how to download them using classes in the <xref:System.Deployment.Application> namespace.|
|[Download assemblies on demand with the ClickOnce deployment API using the designer](../deployment/walkthrough-downloading-assemblies-on-demand-with-the-clickonce-deployment-api-using-the-designer.md)|Explains how to download application assemblies only when they are first used by the application.|

## See also

- [Visual Studio walkthroughs](https://msdn.microsoft.com/library/f5399a1f-2d3d-42fb-b989-134ccda2159f)