---
title: "Access is denied | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT5"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 8a512060-d744-47af-a83e-4ba42ea2c5b2
author: "mikejo5000"
ms.author: "mikejo"
---
# Access is denied
A script tried to access data from a source other than the host of the current page. The Same Origin Policy followed by Internet Explorer and other browsers allows scripts to access data only from sources with the same scheme, host, and port of the URL of the current page.  
  
 For example, if the current page is `https://employees.mycompany.com`, you can't access data from the following URLs:  
  
- `http://data.contoso.com`, because it is using HTTP instead of HTTPS.  
  
- `https://somedatasource.com`, because it is a different domain.  
  
- `https://employees.mycompany.com:8888`, because it uses a different port.  
  
### To correct this error  
  
- Investigate whether the API you're trying to call supports JSONP or CORS, which are two approaches that safely allow cross-origin scripting.  
  
- If you're trying to call a REST API, refactor this call to your server-side code, then expose a new REST endpoint for your client-side scripts.  
  
     For additional information, look for online documentation related to the Same Origin Policy, JSONP, and CORS.
