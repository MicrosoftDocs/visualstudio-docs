---
title: "Configure a computer to develop Office solutions"
description: Learn how to configure a development computer so that you can use the Microsoft Office developer tools in Visual Studio.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "prerequisites [Office development in Visual Studio]"
  - "Office development in Visual Studio, installing tools"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Configure a computer to develop Office solutions

To configure a development computer so that you can use the Microsoft Office developer tools in Visual Studio, follow the instructions in this topic. You must have administrative privileges on the development computer to perform these steps.

## Requirements

The following versions of Visual Studio, the .NET Framework, and Microsoft Office are supported.

|Software|Supported versions|
|--------------|------------------------|
|Visual Studio 2017| Any edition with the **Office/SharePoint development** workload.|
|.NET Framework|- The .NET Framework 4 or later.|
|Microsoft Office|<ul><li>Any suite edition of Office including Microsoft 365 apps for enterprise.</li><li>Any of the following standalone applications:<br /><br /> <ul><li>Excel</li><li>InfoPath (Office 2013 and Office 2010 only)</li><li>Outlook</li><li>PowerPoint</li><li>Project</li><li>Visio</li><li>Word</li></ul></li></ul><br /> Visual Basic for Applications (VBA) must be installed as part of Office. **Important:** Click-to-Run versions of Office 2010 applications are not supported.|

## Configure the development computer

1. Install a version of Visual Studio that includes the Office developer tools. The Office developer tools are installed by default. If you customize the Visual Studio installation by selecting which features to install, make sure that **Microsoft Office Developer Tools** is selected during setup.

2. Install a version of Office that is supported by the Office developer tools in Visual Studio.

   Make sure that you also install the PIAs for the version of Office that you install. The PIAs are installed with Office by default. If you modify Office setup, make sure that the **.NET Programmability Support** feature is selected for the applications you want to target.

3. If you have an English version of Visual Studio but use non-English settings for Windows, you can install the [Visual Studio Tools for Office runtime language pack](https://www.microsoft.com/en-us/download/details.aspx?id=105672) to see Visual Studio Tools for Office runtime messages in the same language as Windows. Non-English versions of Visual Studio automatically install the language pack. The language pack is available from the [Microsoft download center](https://www.microsoft.com/en-us/download/).

## If project templates don't appear or they don't work in Visual Studio

If you install a supported version of Visual Studio, the .NET Framework, and Microsoft Office, but Office project templates either don't appear in the Visual Studio **New Project** dialog box, or you receive an error when you try to use one, check the following:

- Ensure that you have the Microsoft Office developer tools installed on your computer.

     Office developer tools are an optional component of Visual Studio, but they are installed automatically along with Visual Studio. If you customize the Visual Studio installation by specifying which features to install, make sure that you choose **Microsoft Office Developer Tools** during setup to install the tools.

     To make sure that these tools are installed, start the Visual Studio setup program, and choose the **Modify** button. Select the **Microsoft Office Developer Tools** check box, and then choose the **Update** button.

- Make sure that you're not running a version of Office that was delivered by Click-to-Run. See [How to: Verify whether Outlook is a Click-to-Run application on a computer](/previous-versions/office/developer/office-2010/ff864733(v=office.14)).

- Ensure that you're running only one version of Microsoft Office.

If you continue to experience problems, see [Additional support for errors in Office solutions](../vsto/additional-support-for-errors-in-office-solutions.md).

## Related content

- [Get started &#40;Office development in Visual Studio&#41;](../vsto/getting-started-office-development-in-visual-studio.md)
- [How to: Install the Visual Studio Tools for Office runtime redistributable](../vsto/how-to-install-the-visual-studio-tools-for-office-runtime-redistributable.md)
- [How to: Install Office primary interop assemblies](../vsto/how-to-install-office-primary-interop-assemblies.md)
- [Features available by Office application and project type](../vsto/features-available-by-office-application-and-project-type.md)
