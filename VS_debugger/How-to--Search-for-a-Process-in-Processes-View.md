---
title: "How to: Search for a Process in Processes View"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 7cb97b37-4a95-4f1b-9eee-4910aa9c115b
caps.latest.revision: 4
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# How to: Search for a Process in Processes View
You can search for a specific process in Processes view by using its process ID or module string as search criteria. You can also specify the initial direction of the search. The fields in the dialog box will show the attributes of the selected process in the process tree.  
  
### To search for a process in Processes view  
  
1.  Arrange your windows so that Spy++ and an active [Processes View](../VS_debugger/Processes-View.md) window are visible.  
  
2.  From the **Search** menu, choose **Find Process**  
  
     The [Process Search Dialog Box](../VS_debugger/Process-Search-Dialog-Box.md) opens.  
  
3.  Type the process ID or a module string as search criteria.  
  
4.  Clear any fields for which you do not want to specify values.  
  
    > [!TIP]
    >  To find all the processes owned by a module, clear the **Process** box and type the module name in the **Module** box. Then use **Find Next** to continue searching for processes.  
  
5.  Choose **Up** or **Down** for the initial direction of the search.  
  
6.  Click **OK**.  
  
 If a matching process is found, it is highlighted in the **Process view** window.