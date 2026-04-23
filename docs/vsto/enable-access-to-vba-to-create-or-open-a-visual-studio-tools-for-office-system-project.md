---
title: "VBA access to create/open a VSTO system project"
titleSuffix: ""
description: Enable access to the Office VBA project system explicitly so you can create or open a Visual Studio Tools for Office system project.
ms.date: "08/14/2019"
ms.topic: how-to
f1_keywords:
  - "vst.project.vbawrongversion"
  - "VST.Project.VBASecurityGenericError"
  - "VST.Project.VBASecurityPermissions"
  - "VST.SelectDocWizard.MissingCOM"
  - "VST.Project.VBASecurityNotSet"
dev_langs:
  - "VB"
  - "CSharp"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Enable access to VBA to create or open a Visual Studio Tools for the Microsoft Office system project

You must explicitly enable access to the Visual Basic for Applications (VBA) project system in Microsoft Office before you can create or open a Visual Studio Tools for the Microsoft Office system project.

 Microsoft Office development projects require access to the Visual Basic for Applications (VBA) project system in Microsoft Office Word and Microsoft Office Excel, even though the projects do not use Visual Basic for Applications. Design-time support of controls in both Visual Basic and C# projects depends on the Visual Basic for Applications project system.

 Some Microsoft Office macro viruses attempt to automate the Visual Basic for Applications project system as a means to propagate themselves. By enabling access to the Visual Basic for Applications project system, you remove a safeguard that helps prevent the spread of macro viruses. However, normal macro security remains in place, so the macro security level and the list of trusted publishers that you maintain for your Office applications will determine whether any macro runs on your computer.

> [!NOTE]
> This applies only to the development computer. End-user computers do not need this option enabled to run Office solutions.

 It is important to note that disabling access to the Visual Basic for Applications project system on its own does not protect you from viruses, it simply helps to stop some viruses from spreading to other documents if your computer ever becomes infected with a macro virus. The option is disabled by default as an added layer of protection for your computer, but enabling it does not make your computer any more susceptible to viruses if you are following security best practices.

 The best protection against Office macro viruses is to run Office at the High or Very High security level, to only trust macros from verified, known sources, and to stay up-to-date with security patches and virus scanners.

 You can enable or disable the option **Trust Access to Visual Basic Project** manually.

 You can repair your installation of Office if you see VBA or COM errors.

[!include[Add-ins note](includes/addinsnote.md)]

## To enable or disable access to Visual Basic projects

1. Click the **File** tab.

2. Click **Options**.

3. Click **Trust Center**, and then click **Trust Center Settings**.

4. In the **Trust Center**, click **Macro Settings**.

5. Check or uncheck **Trust access to the VBA project object model** to enable or disable access to Visual Basic Projects.

6. Click **OK**.

### To enable or disable access to Visual Basic projects with the 2007 Microsoft Office system

1. On the **Tools** menu in Word or Excel, point to **Macro**, and then click **Security**.

2. In the **Security** dialog box, click the **Trusted Publishers** tab.

3. Select to enable, or clear to disable, **Trust Access to Visual Basic Project**.

4. Click **OK**.

## To set your Office macro security level

1. Click the **File** tab.

2. Click **Options**.

3. Click **Trust Center**, and then click **Trust Center Settings**.

4. In the **Trust Center**, click **Macro Settings**.

5. In the **Macro Settings** section, select the desired setting.

6. Click **OK**.

### To set your Office macro security level with the 2007 Microsoft Office system

1. On the **Tools** menu in Word or Excel, point to **Macro**, and then click **Security**.

2. On the **Security Level** tab, select the desired setting.

    The **Security Level** tab contains details about each level. For more information, see the topic "Macro Security Levels" in Office Help.

### To install VBA with the 2007 Microsoft Office system

1. In Control Panel, run **Add or Remove Programs** or **Programs and Features**.

2. Select Office in the **Currently installed programs** list.

3. Click **Change**.

4. Select **Add or Remove Features**, and then click **Continue**.

5. Select **Choose advanced customization of applications**, and then click **Next**.

6. Expand **Office Shared Features** in the **Choose update options for applications and tools** list.

7. Open the drop-down menu next to **Visual Basic for Applications**, and then click **Run from My Computer**.

8. Click **Continue**.

9. Click **Close**.

## To repair your installation of Office

1. In Control Panel, run **Add or Remove Programs** or **Programs and Features**.

2. Select your version of Office in the **Currently installed programs** list.

3. Click **Change**.

4. Select **Reinstall or Repair**, and then click **Next**.

5. Select **Detect and Repair errors in my Office installation**, and then click **Install**.

## Related content
- [Secure Office solutions](../vsto/securing-office-solutions.md)
