---
title: "Error: The Web Server Could Not Find the Requested Resource | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugger, Web application errors"
ms.assetid: 1ceeaf30-918c-42bb-ace1-96944530fef3
caps.latest.revision: 12
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Error: The Web Server Could Not Find the Requested Resource
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Due to security considerations, IIS has returned a generic error.  
  
 One possible cause is the security configuration of the server. IIS 6.0 and earlier versions used an add-on program, known as URLScan, to filter out suspicious and malformed requests. IIS 7.0 has built-in Request Filtering for the same purpose. In both cases, overly restrictive request filtering can prevent Visual Studio from debugging the server.  
  
 There are numerous possible causes of this error. A few of the most common causes include a problem with the IIS installation or configuration, the web site configuration, or permissions in the file system. You can try accessing the resource with a browser. Depending on how IIS is configured you might have to use a local browser on the server or inspect the IIS error log to get a detailed error message.  
  
 For more information on troubleshooting IIS, see [IIS Management and Administration](https://go.microsoft.com/fwlink/?LinkId=255872).  
  
## See Also  
 [UrlScan Security Tool](/iis/extensions/working-with-urlscan/urlscan-3-reference)   
 [Error: The Web Server Has Been Locked Down and Is Blocking the DEBUG Verb](../debugger/error-the-web-server-has-been-locked-down-and-is-blocking-the-debug-verb.md)
