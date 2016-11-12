---
title: "Limitations on Script Debugging | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "ASPX breakpoint mapping, limitations"
  - "script debugging, limitations"
  - "breakpoint mapping, limitations"
ms.assetid: 280eead5-693c-47af-967f-dfe9d23f84db
caps.latest.revision: 22
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Limitations on Script Debugging
[!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] supports the debugging of client-side script, subject to the limitations in this topic.  
  
## Limitations on Breakpoint Mapping with Client-Side Script  
 [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] enables you to set a breakpoint in a server-side ASPX or HTML file that is transformed to a client-side file at run time. [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] maps the breakpoint from the server-side file to a corresponding breakpoint in the client-side file, subject to the following limitations:  
  
-   Breakpoints must be set inside `<script>` blocks. Breakpoints in inline script or `<% %>` blocks cannot be mapped.  
  
-   The browser URL for the page must contain the page name. For example, http://microsoft.com/default.apsx. Breakpoint mapping cannot recognize a redirection from an address such as http://microsoft.com to the default page.  
  
-   The breakpoint must be set in the page specified in the browser URL, not in an ASPX control (ascx) file, Master page, or other file included by that page. Breakpoints set in included pages cannot be mapped.  
  
-   Breakpoints set in `<script defer=true>` blocks cannot be mapped.  
  
-   For breakpoints set in `<script id="">` blocks, breakpoint mapping ignores the `id` attribute.  
  
## Breakpoint Mapping and Duplicate Lines  
 To find the corresponding location in server-side and client-side script, the breakpoint mapping algorithm examines the code on each line. The algorithm assumes that each line is unique. If two or more lines contain the same code, and you set a breakpoint on one of those duplicate lines, the breakpoint mapping algorithm might select the wrong duplicate in the client-side file. To prevent this, add a comment to the line where you have set the breakpoint. For example:  
  
```  
i++ ;  
i ++; // I added a comment, so this line is now unique  
i ++;  
```