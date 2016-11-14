---
title: "Project Configuration for Managing Deployment | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "project configurations, managing deployment"
  - "projects [Visual Studio SDK], configuration for managing deployment"
ms.assetid: bd5940d9-d94d-4944-beda-4ec1ab2bbde5
caps.latest.revision: 8
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
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
# Project Configuration for Managing Deployment
Deployment is the act of physically moving the output items from a build process to the expected location for debugging and installation. For example, a Web application might be built on a local machine and then placed on the server.  
  
 [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] supports two ways that projects can be involved in deployment:  
  
-   As the subject of the deployment process.  
  
-   As the manager of the deployment process.  
  
 Before solutions can be deployed, you must first add a deployment project to configure deployment options. If the deploy project does not already exist, you are asked if you want to create one when you select **Deploy Solution** from the **Build** menu or right-click the solution. Clicking **Yes** opens the **Add New Project** dialog box with the **Remote Deploy Wizard** project selected.  
  
 The Remote Deploy Wizard asks you for the type of application (Windows or Web), the project output groups to include, any additional files you want to include, and the remote computer you want to deploy to. The last page of the wizard displays a summary of the selected options.  
  
 Projects that are the subject of a deployment process produce output items that must be moved to an alternate environment. These output items are described as parameters for the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectCfg2> interface, whose primary purpose if to allow projects to group outputs. For more information relating to the implementation of `IVsProjectCfg2`, see [Project Configuration for Output](../../extensibility/internals/project-configuration-for-output.md).  
  
 Deployment projects, which manage the deployment process, enable the Deploy command and respond when this command is selected. Deployment projects implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg> interface to perform the deployment and make calls to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployStatusCallback> interface to report deploy status events.  
  
 Configurations can specify dependencies that affect their build or deployment operations. Build or deploy dependencies are projects that must either be built or deployed before or after the configurations themselves are built or deployed. Build dependencies between projects are described with the <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildDependency> interface and deploy dependencies with the <xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployDependency> interface. For more information, see [Project Configuration for Building](../../extensibility/internals/project-configuration-for-building.md).  
  
## See Also  
 [Managing Configuration Options](../../extensibility/internals/managing-configuration-options.md)   
 [Project Configuration for Building](../../extensibility/internals/project-configuration-for-building.md)   
 [Project Configuration for Output](../../extensibility/internals/project-configuration-for-output.md)