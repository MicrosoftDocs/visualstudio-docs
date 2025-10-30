---
title: IntelliCode privacy
ms.date: 09/26/2023
ms.service: visual-studio-family
ms.subservice: intellicode
ms.topic: article
description: IntelliCode privacy
author: ghogen
ms.author: ghogen
manager: mijacobs
---
# IntelliCode privacy

This article describes privacy information and settings for IntelliCode for Visual Studio.

## IntelliCode whole-line completions

IntelliCode whole line completions run entirely on the local machine and don't send any code to Microsoft in order to make predictions.

## Firewall and proxy settings

For IntelliCode to gain access to web services, network managers will need to add `*.intellicode.vsengsaas.visualstudio.com` on https/443 to an allowlist. Conversely, adding it to a blocklist will prevent IntelliCode from working in your network.

Additional information can be found at [Install and use Visual Studio and Azure Services behind a firewall or proxy server](../install/install-and-use-visual-studio-behind-a-firewall-or-proxy-server.md).

## IntelliCode API usage examples

This feature uses a web service to return real-world usage examples of functions that it has found on public GitHub repos. The feature maintains a local list of function names for which it has examples, based solely on scanning public GitHub repositories. It maintains that list on your local machine by downloading it from a web service.  When you use API Usage Examples, it will check which function calls in your code appear on the list of standard and third party library calls known by the feature. This check is performed locally so none of your code leaves the machine. Finally, we retrieve examples from the web service for only those standard and third party library calls that were found to be present. As a result this feature will never send any of your code over the internet.
