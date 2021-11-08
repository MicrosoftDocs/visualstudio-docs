---
title: "Configure a computer to develop Office solutions"
description: Learn how you can install a supported version of Visual Studio, the .NET Framework, and Microsoft Office so you can create VSTO Add-ins and customizations for Microsoft Office.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office development in Visual Studio, installing tools"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# Configure a computer to develop Office solutions

To create VSTO Add-ins and customizations for Microsoft Office, install a supported version of Visual Studio, the .NET Framework, and Microsoft Office.

|Software|Supported versions|
|--------------|------------------------|
|Visual Studio 2017| Any edition with the **Office/SharePoint development** workload.|
|.NET Framework|- The .NET Framework 4 or later.|
|Microsoft Office|<ul><li>Any suite edition of Office including Microsoft 365 apps for enterprise.</li><li>Any of the following standalone applications:<br /><br /> <ul><li>Excel</li><li>InfoPath (Office 2013 and Office 2010 only)</li><li>Outlook</li><li>PowerPoint</li><li>Project</li><li>Visio</li><li>Word</li></ul></li></ul><br /> Visual Basic for Applications (VBA) must be installed as part of Office. **Important:** Click-to-Run versions of Office 2010 applications are not supported.|

For detailed installation steps, see [How to: Configure a computer to develop Office solutions](../vsto/how-to-configure-a-computer-to-develop-office-solutions.md).

## If project templates don't appear or they don't work in Visual Studio

If you install a supported version of Visual Studio, the .NET Framework, and Microsoft Office, but Office project templates either don't appear in the Visual Studio **New Project** dialog box, or you receive an error when you try to use one, check the following:

- Ensure that you have the Microsoft Office developer tools installed on your computer.

     Office developer tools are an optional component of Visual Studio, but they are installed automatically along with Visual Studio. If you customize the Visual Studio installation by specifying which features to install, make sure that you choose **Microsoft Office Developer Tools** during setup to install the tools.

     To make sure that these tools are installed, start the Visual Studio setup program, and choose the **Modify** button. Select the **Microsoft Office Developer Tools** check box, and then choose the **Update** button.

- Make sure that you're not running a version of Office that was delivered by Click-to-Run. See [How to: Verify whether Outlook is a Click-to-Run application on a computer](/previous-versions/office/developer/office-2010/ff864733(v=office.14)).

- Ensure that you're running only one version of Microsoft Office.

If you continue to experience problems, see [Additional support for errors in Office solutions](../vsto/additional-support-for-errors-in-office-solutions.md).

## See also
- [Get started &#40;Office development in Visual Studio&#41;](../vsto/getting-started-office-development-in-visual-studio.md)
- [How to: Configure a computer to develop Office solutions](../vsto/how-to-configure-a-computer-to-develop-office-solutions.md)
- [How to: Install the Visual Studio Tools for Office runtime redistributable](../vsto/how-to-install-the-visual-studio-tools-for-office-runtime-redistributable.md)
- [How to: Install Office primary interop assemblies](../vsto/how-to-install-office-primary-interop-assemblies.md)
- [Features available by Office application and project type](../vsto/features-available-by-office-application-and-project-type.md)