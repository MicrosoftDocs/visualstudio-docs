---
description: "Authentication of the user who requested debugging was prevented by an authentication error."
title: "Debugging Failed Because Integrated Windows Authentication Is Not Enabled"
ms.date: "11/04/2016"
ms.topic: "error-reference"
f1_keywords:
  - "vs.debug.error.webdbg_ntlm_authn_not_enabled"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "aspx"
helpviewer_keywords:
  - "debugger, Web application errors"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Error: Debugging Failed Because Integrated Windows Authentication Is Not Enabled

Authentication of the user who requested debugging was prevented by an authentication error. This can occur when you try to step into a Web application or an XML Web service. One cause of this error is that integrated Windows authentication is not enabled. To enable it, follow the steps in "To enable integrated Windows authentication."

 If you have enabled integrated Windows authentication and this error still appears, it is possible that this error is caused because **Digest Authentication for Windows Domain Servers** is enabled. In this situation you should contact with your network administrator.

### To enable integrated Windows authentication

1. Log on to the Web server by using an administrator account.

2. Click **Start** and then click **Control Panel**.

3. In **Control Panel**, double-click **Administrative Tools**.

4. Double-click **Internet Information Services**.

5. Click the Web server node.

     A **Web Sites** folder opens underneath the server name.

6. You can configure authentication for all Web sites or for individual Web sites. To configure authentication for all Web sites, right-click the **Web Sites** folder and then click **Properties**. To configure authentication for an individual Web site, open the **Web Sites** folder, right-click the individual Web site, and then click **Properties**.

     The **Properties** dialog box is displayed.

7. Click the **Directory Security** tab.

8. In the **Anonymous access and authentication control** section, click **Edit**.

     The **Authentication Methods** dialog box is displayed.

9. Under **Authenticated access**, select **Integrated Windows authentication**.

10. Click **OK** to close the **Authentication Methods** dialog box.

11. Click **OK** to close the **Properties** dialog box.

12. Close the **Internet Information Services** window.

### To enable integrated Windows authentication in older versions of Windows and IIS.

See [Running Web Applications with IIS 7.0 and Visual Studio](/previous-versions/aa964620(v=vs.140))

## See also
- [Debugging Web Applications: Errors and Troubleshooting](../debugger/debugging-web-applications-errors-and-troubleshooting.md)
- [Microsoft Digest Authentication](/windows/win32/secauthn/microsoft-digest-authentication)
