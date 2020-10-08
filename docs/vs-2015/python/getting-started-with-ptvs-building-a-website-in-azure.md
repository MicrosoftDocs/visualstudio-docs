---
title: "Getting Started with PTVS: Building a Website in Azure | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-python
ms.topic: conceptual
ms.assetid: 3bdbda36-14d2-4fde-ba42-d91042777ff6
caps.latest.revision: 5
author: "kraigb"
ms.author: "kraigb"
manager: jillfra
---
# Getting Started with PTVS: Building a Website in Azure
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can get started quickly building a Python web site in Azure.  
  
 You can watch these instructions in a very short [youtube video](https://www.youtube.com/watch?v=FJx5mutt1uk&list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff&index=6).  
  
 Start with the New Project … dialog and under Python projects choose the Bottle Web Project.  This [Bottle](http://bottlepy.org/docs/dev/index.html) template is a starter site based on the [Bootstrap framework](https://getbootstrap.com/).  When you create the project, Visual Studio prompts you to install dependencies (Bottle in this case) into a virtual environment.  Because you’re deploying to an Azure website, you need to add the dependencies to a virtual environment in order to deploy necessary bits for your site’s operation.  You also need to base your environment on Python 2.7 or 3.4 32-bit.  Once you create the project, press F5 to start running your site locally.  
  
 It is easy to try the site in Azure.  If you do not have an Azure subscription, you can use [try.azurewebsites.net](https://trywebsites.azurewebsites.net/).  This site offers a simple way to try out Azure Websites for an hour at a time with only a social login.  You do not need a credit card.  Choose the Empty Site template in the Change Language dropdown and choose Create.  Under “Work with your web application” choose Download Publishing Profile and save the file for use with Visual Studio.  You could also deploy using git from any operating system.  
  
 Switch back to Visual Studio and the project you created.  Select your project node in the Solution Explorer, Choose the right pointer button, and choose Publish.  If you have an Azure subscription, you can click on Microsoft Azure Websites in the dialog to manage your sites from here.  For this walkthrough, choose Import to import the publishing profile you just downloaded.  Because the publishing profile has all the necessary information, you can choose Publish.  In a few seconds a new browser window will open, and your site is live hosted on the Azure cloud.  
  
 Simple websites are easy, but for information on more significant web applications in Azure, see the [deep dive](https://www.youtube.com/watch?v=WG3pGmoo8nE&list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff&index=10) video as well as others in this channel (link in the upper right of the getting started or deep dive video page, as well as below.  
  
 You can watch these instructions in a very short [youtube video](https://www.youtube.com/watch?v=FJx5mutt1uk&list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff&index=6).  
  
## See Also  
 [Wiki documentation](https://github.com/Microsoft/PTVS/wiki/Web-Project)   
 [PTVS Getting Started and Deep Dive Videos](https://www.youtube.com/playlist?list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff)
