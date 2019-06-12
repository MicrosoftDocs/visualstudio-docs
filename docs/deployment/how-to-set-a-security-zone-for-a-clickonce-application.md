---
title: "How to: Set a Security Zone for a ClickOnce Application | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "ClickOnce deployment, security settings"
  - "code access security, ClickOnce applications"
  - "security zones, ClickOnce applications"
ms.assetid: d3dac454-518a-44d7-a76e-ccb7b9c3a150
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Set a security zone for a ClickOnce application
When setting code access security permissions for a ClickOnce application, you need to start with a base set of permissions on the **Security** page of the **Project Designer**.

 In most cases, you can also choose the **Internet** zone which contains a limited set of permissions, or the **Local Intranet** zone which contains a greater set of permissions. If your application requires custom permissions, you can do so by choosing the **Custom** security zone. For more information about setting custom permissions, see [How to: Set Custom Permissions for a ClickOnce Application](../deployment/how-to-set-custom-permissions-for-a-clickonce-application.md).

### To set a security zone

1. With a project selected in **Solution Explorer**, on the **Project** menu click **Properties**.

2. Click the **Security** tab.

3. Select the **Enable ClickOnce Security Settings** check box.

4. Select the **This is a partial trust application** option button.

     The controls in the **ClickOnce security permissions** section are enabled.

5. In the **Zone your application will be installed from** drop-down list, select a security zone.

## See also
- [How to: Set custom permissions for a ClickOnce application](../deployment/how-to-set-custom-permissions-for-a-clickonce-application.md)
- [Secure ClickOnce applications](../deployment/securing-clickonce-applications.md)
- [Code access security for ClickOnce applications](../deployment/code-access-security-for-clickonce-applications.md)
