---
title: "Error: The Web Server Has Been Locked Down and Is Blocking the DEBUG Verb | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "troubleshooting"
f1_keywords:
  - "vs.debug.error.webdbg_debug_verb_blocked"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugger, Web application errors"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Error: The Web Server Has Been Locked Down and Is Blocking the DEBUG Verb
Stepping into a Web application or XML Web service failed because the IIS lockdown tool has been run and URLScan has been installed and activated. This condition blocks IIS from receiving the DEBUG verb.

 URLScan is a security tool that works in conjunction with the IIS Lockdown Tool to give IIS Web site administrators the ability to turn off unnecessary features and restrict the type of HTTP requests that the server will process. By blocking specific HTTP requests, the URLScan security tool prevents potentially harmful requests from reaching the server and causing damage.

 If your application is running on IIS 6.0 on Windows Server 2003, you need not run the IIS Lockdown tool because IIS 6.0 provides the same functionality.

### To enable debugging on a Web server with URLScan installed

1. Locate the Urlscan.ini file. Normally, you will find it in a directory that looks something like this:

     C:\WINNT\System32\Inetsrv\urlscan

2. Create a copy of the file, and name it **Urlscan.old**.

3. Open the original copy of the Urlscan.ini file using Notepad or the text editor of your choice.

4. In Urlscan.ini, locate the [AllowVerbs] section. Add DEBUG to the [AllowVerbs] section. If you see ;DEBUG in the [AllowVerbs] section, remove the semicolon to uncomment the verb.

5. Locate the [DenyVerbs] section. If DEBUG appears in the [DenyVerbs] section, remove it.

6. Save the file.

7. Restart the server or restart IIS.

## See also
- [Debugging Web Applications: Errors and Troubleshooting](../debugger/debugging-web-applications-errors-and-troubleshooting.md)
- [Error: The Web Server Could Not Find the Requested Resource](../debugger/error-the-web-server-could-not-find-the-requested-resource.md)