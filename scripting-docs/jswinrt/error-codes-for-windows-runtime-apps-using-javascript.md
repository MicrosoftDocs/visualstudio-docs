---
title: "Error codes for Windows Runtime apps using JavaScript | Microsoft Docs"
ms.custom: ""
ms.date: "05/10/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords:
  - "JavaScript, Windows Runtime error codes"
  - "VS.WebClient.Help.APPHOST9601"
  - "VS.WebClient.Help.APPHOST9602"
  - "VS.WebClient.Help.APPHOST9603"
  - "VS.WebClient.Help.APPHOST9604"
  - "VS.WebClient.Help.APPHOST9605"
  - "VS.WebClient.Help.APPHOST9606"
  - "VS.WebClient.Help.APPHOST9607"
  - "VS.WebClient.Help.APPHOST9608"
  - "VS.WebClient.Help.APPHOST9610"
  - "VS.WebClient.Help.APPHOST9611"
  - "VS.WebClient.Help.APPHOST9613"
  - "VS.WebClient.Help.APPHOST9614"
  - "VS.WebClient.Help.APPHOST9615"
  - "VS.WebClient.Help.APPHOST9616"
  - "VS.WebClient.Help.APPHOST9617"
  - "VS.WebClient.Help.APPHOST9618"
  - "VS.WebClient.Help.APPHOST9619"
  - "VS.WebClient.Help.APPHOST9620"
  - "VS.WebClient.Help.APPHOST9623"
  - "VS.WebClient.Help.APPHOST9624"
  - "VS.WebClient.Help.APPHOST9626"
ms.assetid: 4c6d4e90-602a-4b56-ae74-3458929da442
caps.latest.revision: 1
author: "erikadoyle"
ms.author: "edoyle"
manager: "jken"
---
# Error codes for Windows Runtime apps using JavaScript
Here are the error codes displayed by the Microsoft Visual Studio console when developing Windows Runtime apps using JavaScript.
  
Error | Remarks
----- | -------
APPHOST9601: "Can't load *remoteURI*. An app can't load remote web content in the local context." | For more info about what's allowed in the web context, see [Features and restrictions by context](https://msdn.microsoft.com/en-us/library/windows/apps/xaml/hh465373.aspx).
APPHOST9602: "'javascript:' is an invalid attribute value and will be ignored. Don't use 'javascript:' URIs in the local context." | For security reasons, you can't use 'javascript:' URIs in the local context. For more info about what's allowed in the local context, see [Features and restrictions by context](https://msdn.microsoft.com/en-us/library/windows/apps/xaml/hh465373.aspx).
APPHOST9603: "Can't load the ActiveX plug-in that has the class ID *classID*.  Apps can't load ActiveX controls." | Windows Runtime apps using JavaScript  don't support custom Microsoft ActiveXcontrols. If you need a UI control, use a standard web control, a controls library, or create your own custom control. If you need to perform custom logic, create a custom Windows Runtime object instead. For info about other HTML, CSS, and JavaScript differences, see [HTML, CSS, and JavaScript features and differences](https://msdn.microsoft.com/en-us/library/windows/apps/xaml/hh465380.aspx).
APPHOST9604: "Can't navigate to *uri* because it uses an invalid character encoding.  An app can navigate only to UTF8-encoded files." | All HTML, JavaScript, and CSS accessed by a Windows Runtime must be encoded as 8-bit Unicode Transformation Format (UTF-8). For info about other HTML, CSS, and JavaScript differences, see [HTML, CSS, and JavaScript features and differences](https://msdn.microsoft.com/en-us/library/windows/apps/xaml/hh465380.aspx).
APPHOST9605: "Can't navigate to *targetURI* from *sourceURI* because the destination URI is in a higher security zone. You can't navigate from a zone with lower security to a zone with higher security unless you're navigating to a local context URI from a web context URI and you've registered the local context URI with the MSApp.addPublicLocalApplicationUri method." | For more info, see [MSApp.addPublicLocalApplicationUri](https://msdn.microsoft.com/en-us/library/windows/apps/xaml/hh465759.aspx).
APPHOST9606: "Can't load *uri* because it uses an HTTP connection and the ms-https-connections-only meta element is present. Only HTTPS connections are allowed when you use the ms-https-connections-only meta element. Use an HTTPS connection or, if you don't need a secure connection, remove the meta element." | For more info, see [How to require an HTTPS connection](https://msdn.microsoft.com/en-us/library/windows/apps/xaml/hh452771.aspx).
APPHOST9607: "The app can't launch the URI at *uri* because of this error: *failureCode*." | A missing resource or an invalid file are common causes of this error.
APPHOST9608: "The app couldn't navigate to the about:blank page because of this error: *errorCode*." | 
APPHOST9610: "The app found an error while preparing to navigate to a custom error page: *errorCode*." |
APPHOST9611: "The app couldn't navigate to a custom error page because of this error: *errorCode*." |
APPHOST9613: "The app couldn't navigate to * uri*  because of this error: *errorCode*." | 
APPHOST9614: "A document within an iframe requested the *requestedDocMode* doc mode, but the system enforces the *currentDocMode* doc mode. The iframe will use the *currentDocMode* doc mode." | For more info about displaying remote web content, see [How to link to external web pages](https://msdn.microsoft.com/en-us/library/windows/apps/xaml/hh780594.aspx).
APPHOST9615: "The app can't download the file at *uri* because it was invoked programmatically outside of the local context." | Occurs when content in the web context tries to programmatically download a file.
APPHOST9616: "This URI can't use geolocation APIs.  Geolocation APIs can be invoked only from a URI that is part of the package or is included in the ApplicationContentUris element of the manifest." | For more info about what's allowed in the web context, see [Features and restrictions by context](https://msdn.microsoft.com/en-us/library/windows/apps/xaml/hh465373.aspx).
APPHOST9617: "This URI can't use clipboard APIs.  The clipboard APIs can be invoked only from a URI that is part of the package or is included in the ApplicationContentUris element of the manifest." | For more info about what's allowed in the web context, see [Features and restrictions by context](https://msdn.microsoft.com/en-us/library/windows/apps/xaml/hh465373.aspx).
APPHOST9618: "This URI can't use window.close.  The window.close method can be invoked only from packaged content that was loaded with an ms-appx URI scheme." | For more info about what's allowed in the web context, see [Features and restrictions by context](https://msdn.microsoft.com/en-us/library/windows/apps/xaml/hh465373.aspx).
APPHOST9619: "The app can't navigate to *uri* because a page in the web context can't be the app's top level document. Load the page in an iframe instead." | You can't navigate your top-level page to a remote web page, but your app can display a web page in an [iframe](https://msdn.microsoft.com/en-us/library/ms535258(v=vs.85).aspx). For more info about displaying remote web content, see [How to link to external web pages](https://msdn.microsoft.com/en-us/library/windows/apps/xaml/hh780594.aspx).
APPHOST9620: "This app was closed because it used an HTTP connection and the ms-https-connections-only meta element is present. Only HTTPS connections are allowed when you use the ms-https-connections-only meta element. Use an HTTPS connection or, if you don't require a secure connection, remove the meta element." | For more info, see [How to require an HTTPS connection](https://msdn.microsoft.com/en-us/library/windows/apps/xaml/hh452771.aspx).
APPHOST9623: "The app couldn't resolve *url* because of this error: *errorCode*." | A common cause of this error is a missing file.  
APPHOST9624: "The app can't use script to load the *url* url because the url launches another app. Only direct user interaction can launch another app." | Apps can't launch other apps directly. Other apps can be launched by the  user when the app implements certain contracts. For more info, see [App contracts and extensions](https://msdn.microsoft.com/en-us/library/windows/apps/xaml/hh464906.aspx).
APPHOST9626: "A direct reference to resource file `ms-appx://1d33240b-0b00-40e4-a416-a4750c48787f/ja-jp\images\logo.scale-140.png` was detected. This reference causes failures when used outside of the debugging environment." | Due to the file path of `logo.scale-140.png`, this PNG file is treated as a localized resource, causing the error in that localized resources cannot be referenced directly. See [Globalizing your app (HTML)](https://msdn.microsoft.com/en-us/library/windows/apps/xaml/hh465006.aspx) if you intend to use this file as a language resource. Otherwise, try renaming the problematic directory.
  
## See Also  
 [Using the Windows Runtime in JavaScript](../jswinrt/using-the-windows-runtime-in-javascript.md)