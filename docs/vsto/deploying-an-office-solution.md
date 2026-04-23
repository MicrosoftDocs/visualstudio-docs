---
title: "Deploy an Office solution"
description: Deploy Office solutions with Windows Installer or by using with ClickOnce to reduce the number of required deployment steps for your solution.
ms.date: "08/14/2019"
ms.topic: install-set-up-deploy
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
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Deploy an Office solution

  You can deploy Office solutions by using ClickOnce or Windows Installer. By using ClickOnce, you reduce the number of steps that deploying and updating your solution requires. If you use Windows Installer, you gain control of how a solution is installed and what pages the setup program displays when users install your solution.

[!include[Add-ins note](includes/addinsnote.md)]

## Deploy a solution by using ClickOnce
 When you deploy a solution by using ClickOnce, you publish it to a central location where users can install and run it. You can update the solution without having to distribute a new setup program to users.  This deployment option is simpler, but you can't show users custom setup pages. Also, solutions must be installed multiple times on any computer that has more than one user. See [Deploy an Office solution by using ClickOnce](../vsto/deploying-an-office-solution-by-using-clickonce.md).

## Deploy a solution by using Windows Installer
 When you deploy a solution by using Windows Installer, you distribute a setup program to users, and users install the solution by using that program. The setup program can install a solution for all users of a computer at the same time, rather than the current user only. You also have a bit more control over options that appear to users when they install your solution. For example, you can show a licensing agreement or enable users to install specific components of a solution. However, if you update the solution, you must distribute a new setup program. See [Deploy an Office solution by using Windows Installer](../vsto/deploying-a-vsto-solution-by-using-windows-installer.md).

## Related content
- [Secure Office solutions](../vsto/securing-office-solutions.md)
- [Deploy an Office solution by using ClickOnce](../vsto/deploying-an-office-solution-by-using-clickonce.md)
- [Deploy an Office solution by using Windows Installer](../vsto/deploying-a-vsto-solution-by-using-windows-installer.md)
- [Troubleshoot Office solution deployment](../vsto/troubleshooting-office-solution-deployment.md)
