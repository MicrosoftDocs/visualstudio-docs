---
title: "Advanced Security Settings Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "vs.err.debug_in_zone_no_hostproc"
  - "vs.err.debug_in_zone_no_hostproc:11310"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "Advanced Security Settings dialog box"
ms.assetid: 2e7aefe9-6d20-4f3e-b257-aee1ebcc6f5d
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: jillfra
---
# Advanced Security Settings Dialog Box
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

This dialog box allows you to specify security settings related to debugging in zone.

 To access this dialog box, select a project node in **Solution Explorer**, and then, on the **Project** menu, click **Properties**. When the **Project Designer** appears, click the **Security** tab. On the **Security** page, select **Enable ClickOnce Security Settings**, click **This is a partial trust application**, and then click **Advanced**.

## UIElement List
 **Debug this application with the selected permission set**
 If you select this check box, the permission set selected on the **Security** page is used during debugging. By default, this option is selected.

 For debugging in a security zone to work, this option must be enabled; also, the **Enable the Visual Studio hosting process** option (available on the **Debug** page of the **Project Designer**) must be enabled.

 For WPF Web Browser Application projects, the **Debug this application with the selected permission set** option is checked and disabled.

 **Grant the application access to its site of origin**
 If you select this check box, the application can access the Web site or server share on which it is published. By default, this option is selected.

 **Debug this application as if it were downloaded from the following URL**
 If you have to allow the application to access the Web site or server share corresponding to the **Installation URL** you specified on the **Publish** page, type that URL here. This option is available only when **Grant the application access to its site of origin** is selected.

## See Also
 [Security Page, Project Designer](../../ide/reference/security-page-project-designer.md)
