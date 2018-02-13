---
title: "Deploying an Office Solution | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "ClickOnce deployment [Office development in Visual Studio], event viewer"
  - "deploying applications [Office development in Visual Studio], event viewer"
  - "Office applications [Office development in Visual Studio], deploying Office solutions"
  - "Office development in Visual Studio, deploying Office solutions"
  - "ClickOnce deployment [Office development in Visual Studio], troubleshooting"
  - "deploying applications [Office development in Visual Studio], Office solutions (2007 system)"
  - "Office development in Visual Studio, troubleshooting"
  - "Office development in Visual Studio, event viewer"
  - "ClickOnce deployment [Office development in Visual Studio], about ClickOnce solution deployments"
  - "Office solutions [Office development in Visual Studio], deploying"
  - "deploying applications [Office development in Visual Studio], troubleshooting"
  - "solutions [Office development in Visual Studio], deploying Office solutions (2007 system)"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Deploying an Office Solution
  You can deploy Office solutions by using ClickOnce or Windows Installer. By using ClickOnce, you reduce the number of steps that deploying and updating your solution requires. If you use Windows Installer, you gain control of how a solution is installed and what pages the setup program displays when users install your solution.  
  
> [!NOTE]  
>  Interested in developing solutions that extend the Office experience across [multiple platforms](https://dev.office.com/add-in-availability)? Check out the new [Office Add-ins model](https://dev.office.com/docs/add-ins/overview/office-add-ins). Office Add-ins have a small footprint compared to VSTO add-ins and solutions, and you can build them by using almost any web programming technology, such as HTML5, JavaScript, CSS3, and XML.  
  
## Deploying a Solution by Using ClickOnce  
 When you deploy a solution by using ClickOnce, you publish it to a central location where users can install and run it. You can update the solution without having to distribute a new setup program to users.  This deployment option is simpler, but you can't show users custom setup pages. Also, solutions must be installed multiple times on any computer that has more than one user. See [Deploying an Office Solution by Using ClickOnce](../vsto/deploying-an-office-solution-by-using-clickonce.md).  
  
## Deploying a Solution by Using Windows Installer  
 When you deploy a solution by using Windows Installer, you distribute a setup program to users, and users install the solution by using that program. The setup program can install a solution for all users of a computer at the same time, rather than the current user only. You also have a bit more control over options that appear to users when they install your solution. For example, you can show a licensing agreement or enable users to install specific components of a solution. However, if you update the solution, you must distribute a new setup program. See [Deploying an Office Solution by Using Windows Installer](../vsto/deploying-an-office-solution-by-using-windows-installer.md).  
  
## See Also  
 [Securing Office Solutions](../vsto/securing-office-solutions.md)   
 [Deploying an Office Solution by Using ClickOnce](../vsto/deploying-an-office-solution-by-using-clickonce.md)   
 [Deploying an Office Solution by Using Windows Installer](../vsto/deploying-an-office-solution-by-using-windows-installer.md)   
 [Troubleshooting Office Solution Deployment](../vsto/troubleshooting-office-solution-deployment.md)  
  
  