---
title: "Requirements for Developing SharePoint Solutions | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "SharePoint development in Visual Studio, prerequisites"
  - "SharePoint development in Visual Studio, requirements"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Requirements for Developing SharePoint Solutions
  You must install the following prerequisites on the system before you can use the SharePoint solution development tools included in Visual Studio:  
  
-   [!INCLUDE[vsPro](../sharepoint/includes/vspro-md.md)] or an edition of Visual Studio Application Lifecycle Management (ALM).  
  
    -   Either the [!INCLUDE[csprcs](../sharepoint/includes/csprcs-md.md)] or [!INCLUDE[vbprvb](../sharepoint/includes/vbprvb-md.md)] feature, or both, when installing [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].  
  
-   [!INCLUDE[moss_14_long](../sharepoint/includes/moss-14-long-md.md)] installed on 64-bit [!INCLUDE[winsvr08](../sharepoint/includes/winsvr08-md.md)] or 64-bit [!INCLUDE[winsvr08](../sharepoint/includes/winsvr08-md.md)] R2.  
  
     or  
  
-   [!INCLUDE[wss_14_long](../sharepoint/includes/wss-14-long-md.md)] installed on 64-bit [!INCLUDE[winsvr08](../sharepoint/includes/winsvr08-md.md)] or 64-bit [!INCLUDE[winsvr08](../sharepoint/includes/winsvr08-md.md)] R2.  
  
> [!NOTE]  
>  While only server operating systems are officially supported by SharePoint, two client operating systems are allowed: [!INCLUDE[win7](../sharepoint/includes/win7-md.md)] and [!INCLUDE[windowsver](../sharepoint/includes/windowsver-md.md)] SP1. For more information, see [SharePoint Server 2010 Developer Workstation Installation Guide](http://go.microsoft.com/fwlink/?LinkID=164557).  
  
 Business Data Connectivity (BDC) Model project types require that [!INCLUDE[moss_14_long](../sharepoint/includes/moss-14-long-md.md)] be installed on the system.  
  
 To develop SharePoint solutions in Visual Studio, you must install SharePoint on the same machine as Visual Studio. Also, the SharePoint developer tools only support a SharePoint standalone configuration; they do not support a farm (remote) configuration.  
  
> [!NOTE]  
>  SharePoint projects in Visual Studio support only [!INCLUDE[net_v35_long](../sharepoint/includes/net-v35-long-md.md)]. If you select [!INCLUDE[net_v40_long](../sharepoint/includes/net-v40-long-md.md)] for a new SharePoint project, it will still target [!INCLUDE[net_v35_long](../sharepoint/includes/net-v35-long-md.md)].  
  
 For more information about how to install [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], see [Install Visual Studio](../install/install-visual-studio.md).  
  
## Vista and Windows 7 User Account Control (UAC)  
 [!INCLUDE[windowsver](../sharepoint/includes/windowsver-md.md)] and [!INCLUDE[win7](../sharepoint/includes/win7-md.md)] incorporate a security feature that's known as User Account Control (UAC). To develop SharePoint solutions in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] on [!INCLUDE[windowsver](../sharepoint/includes/windowsver-md.md)] and [!INCLUDE[win7](../sharepoint/includes/win7-md.md)] systems, UAC requires that you run [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] as a system administrator. On the desktop, open the shortcut menu for [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], and then choose **Run as administrator**.  
  
 To configure the desktop shortcut to always run as administrator, open its shortcut menu, choose **Properties**, choose the **Advanced** button, and then select the **Run as administrator** check box.  
  
 For more information, see [Understanding and Configuring User Account Control in Windows Vista](http://go.microsoft.com/fwlink/?LinkID=156476). and [Windows 7 User Account Control](http://go.microsoft.com/fwlink/?LinkId=177523).  
  
## SharePoint Permissions Considerations  
 To develop SharePoint solutions, you must have sufficient permissions to run and debug SharePoint solutions. Before you can test a SharePoint solution, take the following steps to ensure that you have the necessary permissions:  
  
1.  Add your user account as an Administrator on the system.  
  
2.  Add your user account as a Farm Administrator for the SharePoint server.  
  
    1.  In SharePoint Central Administration, choose the **Manage the farm administrators group** link.  
  
    2.  On the **Farm Administrators** page, choose the **New** button.  
  
3.  Add your user account to the to the WSS_ADMIN_WPG group.  
  
## See Also  
 [Getting Started &#40;SharePoint Development in Visual Studio&#41;](../sharepoint/getting-started-sharepoint-development-in-visual-studio.md)  
  
  