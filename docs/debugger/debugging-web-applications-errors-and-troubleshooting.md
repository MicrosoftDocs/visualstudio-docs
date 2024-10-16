---
title: "Debugging web apps -  errors and troubleshooting"
description: Find links to reference pages to help debug web applications, such as a troubleshooting page and pages that describe each error that you may encounter.
ms.date: "07/21/2023"
ms.topic: "error-reference"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugging script, troubleshooting"
  - "errors [debugger], Web applications"
  - "debugging ASP.NET Web applications, troubleshooting"
  - "scripts, debugging"
  - "errors [Visual Studio], debugging Web applications"
  - "debugging Web services, troubleshooting"
  - "Web services, timeout error when debugging"
  - "Web applications, errors and troubleshooting"
  - "debugging [Visual Studio], errors"
  - "debugger, errors"
  - "debugging Web applications, troubleshooting"
  - "troubleshooting Web applications"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Debugging Web Applications: Errors and Troubleshooting

You may encounter the following errors when attempting to debug Web applications.

## Site Uses IP Address

This error occurs when the debugger tries to auto-attach to a Web application that is using an IP address. This issue occurs if you change Web site identification to use specific IP address in IIS.

For more information, see [Error: Site Uses IP Address](/previous-versions/visualstudio/visual-studio-2017/debugger/error-site-uses-ip-address)

## A Security Check Failed Because the IIS Admin Service Did Not Respond

This error occurs when the IIS Admin Service doesn't respond. This result usually indicates that there's a problem with the IIS installation. First, verify that the service is running using the Services tool from Administrative Tools.

For more information, see [Error: A Security Check Failed Because the IIS Admin Service Did Not Respond](/previous-versions/visualstudio/visual-studio-2017/debugger/error-a-security-check-failed-because-the-iis-admin-service-did-not-respond).

## ASP.NET Not Installed

This error occurs when ASP.NET isn't installed correctly on the computer that you are trying to debug. This result might mean that ASP.NET was never installed or that ASP.NET was installed first and IIS was installed later.

For more information, see [Error: ASP.NET Not Installed](../debugger/error-aspnet-not-installed.md).

## Debugging Failed Because Integrated Windows Authentication Is Not Enabled

Authentication of the user who requested debugging was prevented by an authentication error. This error can occur when you try to step into a Web application or an XML Web service. One cause of this error is that integrated Windows authentication isn't enabled. To enable it, follow the steps in "To enable integrated Windows authentication."

For more information, see [Error: Debugging Failed Because Integrated Windows Authentication Is Not Enabled](../debugger/error-debugging-failed-because-integrated-windows-authentication-is-not-enabled.md).

## The Web Server Has Been Locked Down and Is Blocking the DEBUG Verb

Stepping into a Web application or XML Web service failed because the IIS lockdown tool has been run and URLScan has been installed and activated. This condition blocks IIS from receiving the DEBUG verb.

For more information, see [Error: The Web Server Has Been Locked Down and Is Blocking the DEBUG Verb](/previous-versions/visualstudio/visual-studio-2017/debugger/error-the-web-server-has-been-locked-down-and-is-blocking-the-debug-verb).

## Timeout While Debugging Web Services

When you are stepping into an XML Web service from calling code, the call may sometimes time out, with the result being that you cannot continue debugging.

For more information, see [Error: Timeout While Debugging Web Services](../debugger/error-timeout-while-debugging-web-services.md).

## Unable to Start Debugging on the Web Server

When you try to debug an ASP.NET application running on a Web server, you may get this error message: Unable to start debugging on the Web server.

For more information, see [Error: Unable to Start Debugging on the Web Server](../debugger/error-unable-to-start-debugging-on-the-web-server.md).

## The Web Server Could Not Find the Requested Resource

Due to security considerations, IIS has returned a generic error.

For more information, see [Error: The Web Server Could Not Find the Requested Resource](../debugger/error-the-web-server-could-not-find-the-requested-resource.md).

## The Web Server Is Not Configured Correctly

An IIS configuration issue may result in this error.

For more information, see [Error: The web server isn't configured correctly](../debugger/error-the-web-server-is-not-configured-correctly.md).

## See also

- [Debugger Security](../debugger/debugger-security.md)
- [Debugging Web Applications and Script](how-to-enable-debugging-for-aspnet-applications.md)