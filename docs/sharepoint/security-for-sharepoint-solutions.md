---
title: "Security for SharePoint Solutions"
description: Discover what features Visual Studio incorporates to help enhance the security of SharePoint applications.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "security [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, security"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: sharepoint-development
---
# Security for SharePoint solutions

  Visual Studio incorporates the following features to help enhance the security of SharePoint applications.

## Safe control entries
 Every SharePoint project item created in Visual Studio has a **Safe Control Entries** property that represents a safe controls collection. Its **Safe** subproperty enables you to specify the controls that you consider secure. For more information, see [Provide package and deployment information in project items](../sharepoint/providing-packaging-and-deployment-information-in-project-items.md) and [Specifying Safe Web Parts](/previous-versions/office/developer/sharepoint2003/dd583154(v=office.11)#specifying-safe-web-parts).

## AllowPartiallyTrustedCallers attribute
 By default, only applications that are fully trusted by the runtime code access security (CAS) system can access a shared managed code assembly. Marking a fully trusted assembly with the AllowPartiallyTrustedCallers attribute allows partially trusted assemblies to access it.

 The AllowPartiallyTrustedCallers attribute is added to any SharePoint solution that is not deployed to the system global assembly cache (  GAC ). This includes sandboxed solutions or solutions deployed to the SharePoint application Bin directory. For more information, see [Version 1 Security Changes for the Microsoft .NET Framework](/previous-versions/msp-n-p/ff921345(v=pandp.10)) and [Deploying Web Parts in SharePoint Foundation](/previous-versions/office/developer/sharepoint-2010/cc768621(v=office.14)).

## Safe against script property
 *Script injection* is the insertion of potentially malicious code into controls or Web pages. To help protect SharePoint 2010 sites against script injection, contributors cannot view or edit Web parts or their properties by default. This behavior is controlled by a SafeControl attribute called SafeAgainstScript. In Visual Studio, set this attribute in a project item's **Safe Control Entries** subproperty **Safe Against Script**. For more information, see [Provide package and deployment information in project items](../sharepoint/providing-packaging-and-deployment-information-in-project-items.md) and [How to: Mark controls as safe controls](../sharepoint/how-to-mark-controls-as-safe-controls.md).

## Vista and Windows 7 User Account Control
 Windows Vista and Windows 7 incorporate a security feature known as User Account Control (UAC). To develop SharePoint solutions in Visual Studio on Windows Vista and Windows 7 systems, UAC requires that you run Visual Studio as a system administrator. From the **Start** menu, open the shortcut menu for Visual Studio, and then choose **Run as administrator**.

 To configure the Visual Studio shortcut to always run as administrator, open its shortcut menu, choose **Properties**, choose the **Advanced** button in the **Properties** dialog box, and then select the **Run as administrator** check box.

 For more information, see [Understanding and Configuring User Account Control in Windows Vista](/previous-versions/windows/it-pro/windows-vista/cc709628(v=ws.10)). and [Windows 7 User Account Control](/previous-versions/windows/it-pro/windows-server-2008-R2-and-2008/cc731416(v=ws.10)).

## SharePoint permissions considerations
 To develop SharePoint solutions, you must have sufficient permissions to run and debug SharePoint solutions. Before you can test a SharePoint solution, take the following steps to ensure that you have the necessary permissions:

1. Add your user account as an Administrator on the system.

2. Add your user account as a Farm Administrator for the SharePoint server.

    1. In SharePoint 2010 Central Administration, choose the **Manage the farm administrators group** link.

    2. On the **Farm Administrators** page, choose the **New** menu option

3. Add your user account to the to the WSS_ADMIN_WPG group.

## Additional security resources
 For more information about security issues, see the following.

### Visual Studio security

- [Security and User Permissions](/previous-versions/visualstudio/visual-studio-2010/ms165099(v=vs.100))

- [Security in Native and .NET Framework Code](/previous-versions/visualstudio/visual-studio-2010/1787tk12(v=vs.100))

- [Security in the .NET Framework](/previous-versions/dotnet/netframework-4.0/fkytk30f(v=vs.100))

### SharePoint security

- [SharePoint Foundation Administration and Security](/previous-versions/office/developer/sharepoint-2010/ee537811(v=office.14))

- [SharePoint Security Resource Center](/sharepoint/dev/)

- [Securing Web Parts in SharePoint Foundation](/previous-versions/office/developer/sharepoint-2010/cc768613(v=office.14))

- [Improving Web Application Security: Threats and Countermeasures](/previous-versions/msp-n-p/ff649874(v=pandp.10))

### General security

- [MSDN Security Development Lifecycle](https://www.microsoft.com/msrc?rtc=1)

- [Building Secure ASP.NET Applications: Authentication, Authorization, and Secure Communication](/previous-versions/msp-n-p/ff649100(v=pandp.10))

## Related content

- [Develop SharePoint solutions](../sharepoint/developing-sharepoint-solutions.md)
