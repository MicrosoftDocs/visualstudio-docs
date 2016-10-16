---
title: "Troubleshooting the Help Viewer"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "troubleshooting [Help Viewer 2.0]"
  - "Help Viewer 2.0, troubleshooting"
ms.assetid: 461a4553-064a-4142-a2d2-058658b9ba12
caps.latest.revision: 13
ms.author: "kempb"
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
# Troubleshooting the Help Viewer
This topic discusses issues that you might encounter with the Help Viewer.  
  
## Audio doesn't work.  
 The Help Viewer doesn't include an audio player. If you download content that contains audio and nothing happens when you choose **Play**, install an audio player.  
  
## Search doesn't work in Windows Server 2008, Windows Server 2008 with SP1, or Windows Server 2008 R2.  
 The search and filter features in the Help Viewer require the Windows Search service to be installed and on. By default, this service is off in Windows Server 2008, Windows Server 2008 with Service Pack 1 (SP1), and Windows Server 2008 R2.  
  
#### To activate Windows Search service  
  
1.  Start Server Manager.  
  
2.  In the left navigation pane, choose **Roles**.  
  
3.  In the Roles Summary pane, choose **Add Role**.  
  
4.  Choose the File Services role, and then choose the **Next** button.  
  
5.  Choose the Windows Search role service.  
  
## Additional Resources  
 You can get more information and provide feedback on the Help Viewer by using the following resources:  
  
-   To provide feedback, see [Microsoft Connect](http://go.microsoft.com/fwlink/?linkid=243983) on the Microsoft website or send email to [hlpfdbk@microsoft.com](mailto:hlpfdbk@microsoft.com).  
  
-   For more information, see the [Developer Documentation and Help System](http://go.microsoft.com/fwlink/?LinkId=232741) forum and [The Help Guy](http://go.microsoft.com/fwlink/?LinkId=232743) blog.  
  
## See Also  
 [Help Viewer 2.1 Administrator Guide](http://go.microsoft.com/fwlink/?LinkId=243985)