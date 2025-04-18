---
title: Advanced Security Settings Dialog Box
description: Advanced Security Settings dialog box allows you to specify security settings related to debugging in zone.
ms.date: 06/27/2018
ms.subservice: deployment
ms.topic: reference
f1_keywords:
- vs.err.debug_in_zone_no_hostproc
helpviewer_keywords:
- Advanced Security Settings dialog box
ms.custom: "ide-ref"
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
monikerRange: 'vs-2019'
---
# Advanced Security Settings dialog box

This dialog box allows you to specify security settings related to debugging in zone.

![Advanced Security Settings dialog box in Visual Studio](../media/advanced-security-settings.png)

To access this dialog box, select a project node in **Solution Explorer**, and then, on the **Project** menu, click **Properties**. When the **Project Designer** appears, click the **Security** tab. On the **Security** page, select **Enable ClickOnce Security Settings**, click **This is a partial trust application**, and then click **Advanced**.

## UIElement list

**Grant the application access to its site of origin**

If you select this check box, the application can access the website or server share on which it is published. By default, this option is selected.

**Debug this application as if it were downloaded from the following URL**

If you have to allow the application to access the website or server share corresponding to the **Installation URL** you specified on the **Publish** page, enter that URL here. This option is available only when **Grant the application access to its site of origin** is selected.

## See also

- [Security Page, Project Designer](../../ide/reference/security-page-project-designer.md)
