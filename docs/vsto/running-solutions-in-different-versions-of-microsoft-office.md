---
title: "Run solutions in different versions of Microsoft Office"
ms.date: "02/02/2017"
ms.topic: "conceptual"
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
manager: jillfra
ms.workload:
  - "office"
---
# Run solutions in different versions of Microsoft Office

## Run Office solutions created by using Visual Studio 2010 and above

|Version of Office targeted by the project template|Target .NET Framework of the project<sup>1</sup>|Versions of Office that can run the solution|Required runtime on end-user computer|
|--------------------------------------------------------|------------------------------------------------------|--------------------------------------------------|-------------------------------------------|
|Office 2016 and [!INCLUDE[Office_15_short](../vsto/includes/office-15-short-md.md)]|[!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later|Office 2016<br /><br /> [!INCLUDE[Office_15_short](../vsto/includes/office-15-short-md.md)]<br /><br /> [!INCLUDE[office14_long](../vsto/includes/office14-long-md.md)]<br /><br /> 2007 Microsoft Office system<sup>2</sup>|Visual Studio 2010 Tools for Office Runtime|
|[!INCLUDE[office14_long](../vsto/includes/office14-long-md.md)]|[!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later|Office 2016<br /><br /> [!INCLUDE[Office_15_short](../vsto/includes/office-15-short-md.md)]<br /><br /> [!INCLUDE[office14_long](../vsto/includes/office14-long-md.md)]<br /><br /> 2007 Microsoft Office system<sup>2</sup>|Visual Studio 2010 Tools for Office Runtime|
|[!INCLUDE[office14_long](../vsto/includes/office14-long-md.md)]|.NET Framework 3.5|Office 2016<br /><br /> [!INCLUDE[Office_15_short](../vsto/includes/office-15-short-md.md)]<br /><br /> [!INCLUDE[office14_long](../vsto/includes/office14-long-md.md)]|Visual Studio 2010 Tools for Office Runtime|
|2007 Microsoft Office system|[!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later,<br /><br /> or<br /><br /> .NET Framework 3.5|Office 2016<br /><br /> [!INCLUDE[Office_15_short](../vsto/includes/office-15-short-md.md)]<br /><br /> [!INCLUDE[office14_long](../vsto/includes/office14-long-md.md)]<br /><br /> 2007 Microsoft Office system|Visual Studio 2010 Tools for Office Runtime|

 1. The .NET Framework version that your project targets is required on end-user computers for your solution to run. For example, if your project targets the .NET Framework 3.5, the .NET Framework 3.5 is required on end-user computers. In this example, your solution will not run if only the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] is installed on end-user computers.

 2. In this scenario, the solution will run without errors in the 2007 Microsoft Office system only if it does not use features that are new in [!INCLUDE[office14_long](../vsto/includes/office14-long-md.md)].

## Run Office solutions created by using versions of Visual Studio prior to Visual Studio 2010
 Microsoft Office applications can run solutions created by using versions of Visual Studio prior to Visual Studio 2010. In some cases, these solutions require different versions of the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)]. Different versions of the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] can be installed side by side on the same computer.

 The following table shows which versions of Microsoft Office can run solutions created by using previous versions of Visual Studio, and which versions of the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] and the .NET Framework are required for each solution.

|Edition of Visual Studio used to create the solution|Version of Office targeted by the project template|Versions of Office that can run the solution|Required runtime on end-user computer|Required .NET Framework version on end-user computer|
|----------------------------------------------------------|--------------------------------------------------------|--------------------------------------------------|-------------------------------------------|----------------------------------------------------------|
|Visual Studio 2008 Professional<br /><br /> or<br /><br /> Visual Studio Team System 2008|2007 Microsoft Office system|[!INCLUDE[Office_15_short](../vsto/includes/office-15-short-md.md)] and [!INCLUDE[office14_long](../vsto/includes/office14-long-md.md)]<sup>1</sup><br /><br /> 2007 Microsoft Office system|Visual Studio 2010 Tools for Office Runtime<sup>1</sup><br /><br /> or<br /><br /> Visual Studio Tools for the Microsoft Office system (version 3.0 Runtime)|.NET Framework 3.5|
|One of the following editions of Visual Studio 2005 with VSTO 2005 SE<sup>2</sup> installed:<br /><br /> -   Visual Studio 2005 Tools for Office<br />-   Visual Studio Team System 2005<br />-   Visual Studio 2005 Professional|2007 Microsoft Office system|[!INCLUDE[Office_15_short](../vsto/includes/office-15-short-md.md)] and [!INCLUDE[office14_long](../vsto/includes/office14-long-md.md)] (32-bit only<sup>3</sup>)<br /><br /> 2007 Microsoft Office system|Visual Studio 2005 Tools for Office Second Edition Runtime|.NET Framework 2.0, .NET Framework 3.0, or .NET Framework 3.5|
|Any of the following editions of Visual Studio:<br /><br /> -   Visual Studio 2008 Professional<br />-   Visual Studio Team System 2008<br />-   Visual Studio 2005 Tools for Office (with or without VSTO 2005 SE<sup>2</sup> installed)<br />-   Visual Studio Team System 2005 (with or without VSTO 2005 SE<sup>2</sup> installed)<br />-   Visual Studio 2005 Professional with VSTO 2005 SE<sup>2</sup> installed|Microsoft Office 2003|[!INCLUDE[Office_15_short](../vsto/includes/office-15-short-md.md)] and [!INCLUDE[office14_long](../vsto/includes/office14-long-md.md)] (32-bit only<sup>3</sup>)<br /><br /> 2007 Microsoft Office system<br /><br /> Microsoft Office 2003|Visual Studio 2005 Tools for Office Second Edition Runtime|.NET Framework 2.0, .NET Framework 3.0, or .NET Framework 3.5|

 1. [!INCLUDE[Office_15_short](../vsto/includes/office-15-short-md.md)] and [!INCLUDE[office14_long](../vsto/includes/office14-long-md.md)] applications include the Visual Studio 2010 Tools for Office runtime. Therefore, these applications always use the Visual Studio 2010 Tools for Office runtime rather than the Visual Studio Tools for the Microsoft Office system (version 3.0 Runtime) in this scenario. Applications in the 2007 Microsoft Office system can use the Visual Studio 2010 Tools for Office Runtime or the Visual Studio Tools for the Microsoft Office system (version 3.0 Runtime).

 2. VSTO 2005 SE is a free Visual Studio add-on that provides VSTO Add-in project templates for Microsoft Office 2003 and the 2007 Microsoft Office system. It can be installed with Visual Studio 2005 Professional, Visual Studio 2005 Tools for Office, or an edition in the Visual Studio Team System 2005. For more information, see [Visual Studio 2005 Tools for Office Second Edition](https://developer.microsoft.com/office/docs).

 3. Office solutions that require the Visual Studio 2005 Tools for Office Second Edition Runtime are not compatible with 64-bit versions of [!INCLUDE[Office_15_short](../vsto/includes/office-15-short-md.md)] and [!INCLUDE[office14_long](../vsto/includes/office14-long-md.md)]. To run these solutions in the 64-bit edition of [!INCLUDE[Office_15_short](../vsto/includes/office-15-short-md.md)] or [!INCLUDE[office14_long](../vsto/includes/office14-long-md.md)], you must upgrade the project to [!INCLUDE[vs_dev10_long](../sharepoint/includes/vs-dev10-long-md.md)] or to a Visual Studio 2008 project that targets the 2007 Microsoft Office system.

## See also
- [Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md)
- [Visual Studio Tools for Office runtime overview](../vsto/visual-studio-tools-for-office-runtime-overview.md)
- [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md)
- [Visual Studio Tools for Office runtime installation scenarios](../vsto/visual-studio-tools-for-office-runtime-installation-scenarios.md)
- [Configure a computer to develop Office solutions](../vsto/running-solutions-in-different-versions-of-microsoft-office.md)
