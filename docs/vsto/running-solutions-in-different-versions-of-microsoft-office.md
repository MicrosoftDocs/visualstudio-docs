---
title: "Run solutions in different versions of Microsoft Office"
description: Learn how you can run versions of Microsoft Office solutions that were created by using Visual Studio 2010 and above.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "solutions [Office development in Visual Studio], multiple Office versions"
  - "Office applications [Office development in Visual Studio], multiple Office versions"
  - "Office development in Visual Studio, multiple Office versions"
  - "Office solutions [Office development in Visual Studio]"
  - "multiple Office versions"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Run solutions in different versions of Microsoft Office

## Run Office solutions created by using Visual Studio 2010 and above

|Version of Office targeted by the project template|Target .NET Framework of the project<sup>1</sup>|Versions of Office that can run the solution|Required runtime on end-user computer|
|--------------------------------------------------------|------------------------------------------------------|--------------------------------------------------|-------------------------------------------|
|Office 2016 and  Office 2013 |.NET Framework 4 or later|Office 2016<br /><br />  Office 2013 <br /><br /> Office 2010<br /><br /> 2007 Microsoft Office system<sup>2</sup>|Visual Studio 2010 Tools for Office Runtime|
|Office 2010|.NET Framework 4 or later|Office 2016<br /><br />  Office 2013 <br /><br /> Office 2010<br /><br /> 2007 Microsoft Office system<sup>2</sup>|Visual Studio 2010 Tools for Office Runtime|
|Office 2010|.NET Framework 3.5|Office 2016<br /><br />  Office 2013 <br /><br /> Office 2010|Visual Studio 2010 Tools for Office Runtime|
|2007 Microsoft Office system|.NET Framework 4 or later,<br /><br /> or<br /><br /> .NET Framework 3.5|Office 2016<br /><br />  Office 2013 <br /><br /> Office 2010<br /><br /> 2007 Microsoft Office system|Visual Studio 2010 Tools for Office Runtime|

 1. The .NET Framework version that your project targets is required on end-user computers for your solution to run. For example, if your project targets the .NET Framework 3.5, the .NET Framework 3.5 is required on end-user computers. In this example, your solution will not run if only the .NET Framework 4 is installed on end-user computers.

 2. In this scenario, the solution will run without errors in the 2007 Microsoft Office system only if it does not use features that are new in Office 2010.

## Run Office solutions created by using versions of Visual Studio prior to Visual Studio 2010
 Microsoft Office applications can run solutions created by using versions of Visual Studio prior to Visual Studio 2010. In some cases, these solutions require different versions of the  Visual Studio Tools for Office runtime . Different versions of the  Visual Studio Tools for Office runtime  can be installed side by side on the same computer.

 The following table shows which versions of Microsoft Office can run solutions created by using previous versions of Visual Studio, and which versions of the  Visual Studio Tools for Office runtime  and the .NET Framework are required for each solution.

|Edition of Visual Studio used to create the solution|Version of Office targeted by the project template|Versions of Office that can run the solution|Required runtime on end-user computer|Required .NET Framework version on end-user computer|
|----------------------------------------------------------|--------------------------------------------------------|--------------------------------------------------|-------------------------------------------|----------------------------------------------------------|
|Visual Studio 2008 Professional<br /><br /> or<br /><br /> Visual Studio Team System 2008|2007 Microsoft Office system| Office 2013  and Office 2010<sup>1</sup><br /><br /> 2007 Microsoft Office system|Visual Studio 2010 Tools for Office Runtime<sup>1</sup><br /><br /> or<br /><br /> Visual Studio Tools for the Microsoft Office system (version 3.0 Runtime)|.NET Framework 3.5|
|One of the following editions of Visual Studio 2005 with VSTO 2005 SE<sup>2</sup> installed:<br /><br /> -   Visual Studio 2005 Tools for Office<br />-   Visual Studio Team System 2005<br />-   Visual Studio 2005 Professional|2007 Microsoft Office system| Office 2013  and Office 2010 (32-bit only<sup>3</sup>)<br /><br /> 2007 Microsoft Office system|Visual Studio 2005 Tools for Office Second Edition Runtime|.NET Framework 2.0, .NET Framework 3.0, or .NET Framework 3.5|
|Any of the following editions of Visual Studio:<br /><br /> -   Visual Studio 2008 Professional<br />-   Visual Studio Team System 2008<br />-   Visual Studio 2005 Tools for Office (with or without VSTO 2005 SE<sup>2</sup> installed)<br />-   Visual Studio Team System 2005 (with or without VSTO 2005 SE<sup>2</sup> installed)<br />-   Visual Studio 2005 Professional with VSTO 2005 SE<sup>2</sup> installed|Microsoft Office 2003| Office 2013  and Office 2010 (32-bit only<sup>3</sup>)<br /><br /> 2007 Microsoft Office system<br /><br /> Microsoft Office 2003|Visual Studio 2005 Tools for Office Second Edition Runtime|.NET Framework 2.0, .NET Framework 3.0, or .NET Framework 3.5|

 1.  Office 2013  and Office 2010 applications include the Visual Studio 2010 Tools for Office runtime. Therefore, these applications always use the Visual Studio 2010 Tools for Office runtime rather than the Visual Studio Tools for the Microsoft Office system (version 3.0 Runtime) in this scenario. Applications in the 2007 Microsoft Office system can use the Visual Studio 2010 Tools for Office Runtime or the Visual Studio Tools for the Microsoft Office system (version 3.0 Runtime).

 2. VSTO 2005 SE is a free Visual Studio add-on that provides VSTO Add-in project templates for Microsoft Office 2003 and the 2007 Microsoft Office system. It can be installed with Visual Studio 2005 Professional, Visual Studio 2005 Tools for Office, or an edition in the Visual Studio Team System 2005. For more information, see [Visual Studio 2005 Tools for Office Second Edition](https://developer.microsoft.com/office/docs).

 3. Office solutions that require the Visual Studio 2005 Tools for Office Second Edition Runtime are not compatible with 64-bit versions of  Office 2013  and Office 2010. To run these solutions in the 64-bit edition of  Office 2013  or Office 2010, you must upgrade the project to Visual Studio 2010 or to a Visual Studio 2008 project that targets the 2007 Microsoft Office system.

## Related content
- [Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md)
- [Visual Studio Tools for Office runtime overview](../vsto/visual-studio-tools-for-office-runtime-overview.md)
- [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md)
- [Visual Studio Tools for Office runtime installation scenarios](../vsto/visual-studio-tools-for-office-runtime-installation-scenarios.md)
- [Configure a computer to develop Office solutions](../vsto/running-solutions-in-different-versions-of-microsoft-office.md)
