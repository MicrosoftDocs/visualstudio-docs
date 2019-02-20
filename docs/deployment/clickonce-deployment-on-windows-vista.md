---
title: "ClickOnce Deployment on Windows Vista | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "UAC manifest generation"
  - "ClickOnce deployment, Windows"
  - "manifest generation"
  - "Windows, ClickOnce deployment"
ms.assetid: b21a0ebc-0ff6-4f49-8993-7d1ad3f8cac2
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# ClickOnce deployment on Windows Vista

Building applications in Visual Studio for User Account Control (UAC) on Windows Vista normally generates an embedded manifest, encoded as binary XML data in the application's executable file.  ClickOnce and Registration-Free COM applications require an external manifest, so Visual Studio generates a file for these  projects containing the UAC data instead of an embedded manifest. For ClickOnce and Registration-Free COM deployments, Visual Studio uses information from a file called *app.manifest* to generate external UAC manifest information. For all other cases, Visual Studio embeds the UAC data in the application's executable file.

Visual Studio provides the following options for manifest generation:

- Use an embedded manifest. Embed UAC data in the application's executable file and run as a normal user.

   This is the default setting (unless you use ClickOnce). This setting supports the usual manner in which Visual Studio operates on Windows Vista, with the generation of both an internal and an external manifest using `AsInvoker`.

- Use an external manifest. Generate an external manifest by using *app.manifest*.

   This generates only the external manifest by using the information in *app.manifest*. When you publish an application by using ClickOnce or Registration-Free COM, Visual Studio adds *app.manifest* to the project and then adds this option.

- Use no manifest. Create the application without a manifest.

   This approach is also known as *virtualization*. Use this option for compatibility with existing applications from earlier versions of Visual Studio.

  The new properties are available on the **Application** page of the Project Designer (for Visual C# projects only) and in the MSBuild project file format.

  The method for configuring UAC manifest generation in the Visual Studio IDE differs depending on the project type (Visual C# or Visual Basic).

  * For information about configuring Visual C# projects for manifest generation, see [Application Page, Project Designer (C#)](../ide/reference/application-page-project-designer-csharp.md).

  * For information about configuring Visual Basic projects for manifest generation, see [Application Page, Project Designer (Visual Basic)](../ide/reference/application-page-project-designer-visual-basic.md).

## See also
- [ClickOnce security and deployment](../deployment/clickonce-security-and-deployment.md)
- [User permissions and Visual Studio](https://msdn.microsoft.com/library/d5c55084-1e7b-4b61-b478-137db01c0fc0)
- [Application Page, Project Designer (C#)](../ide/reference/application-page-project-designer-csharp.md)
- [Application Page, Project Designer (Visual Basic)](../ide/reference/application-page-project-designer-visual-basic.md)