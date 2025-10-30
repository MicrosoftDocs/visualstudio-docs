---
title: "Specific security considerations for Office solutions"
description: Learn how the security features provided by the Microsoft .NET Framework and Microsoft Office can help to protect your Office solutions against security threats.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "troubleshooting Office development in Visual Studio, security"
  - "trusted code [Office development in Visual Studio]"
  - "blocked code [Office development in Visual Studio]"
  - "Outlook [Office development in Visual Studio], object model guard"
  - "malicious code [Office development in Visual Studio]"
  - "Outlook object model guard [Office development in Visual Studio]"
  - "security [Office development in Visual Studio], troubleshooting"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Specific security considerations for Office solutions

  The security features provided by the Microsoft .NET Framework and Microsoft Office can help to protect your Office solutions against possible security threats. This topic explains some of those threats and provides recommendations to help protect against them. It also includes information about how Microsoft Office security settings affect Office solutions.

 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]

## Trusted code is repurposed in a new, malicious document
 An attacker could take trusted code that is meant for one particular purpose, for example, downloading personal information for an employment application, and reuse it in another document, such as a worksheet. The code does not know that the original document is not running, and may open up other threats, such as revealing personal information or executing code with increased privileges, when opened by a different user. Alternatively, the attacker can modify the data in the worksheet such that, when sent to the victim, it behaves unexpectedly. By changing the values, formulas, or presentation characteristics of a worksheet linked to code, it is possible for a malicious user to attack another user by sending a modified file. It may also be possible for users to access information they are not supposed to see by modifying values in the worksheet.

 Since both the assembly location and the document location must have sufficient evidence to execute, this attack is not easy to mount. For example, documents in e-mail attachments or on untrusted intranet servers do not have enough permissions to run.

 To make this attack possible, the code itself must be written in such a way that it makes decisions based on potentially untrustworthy data. An example is creating a worksheet that has a hidden cell that contains the name of a database server. The user submits the worksheet to an ASPX page, which attempts to connect to that server using SQL authentication and a hard-coded SA password. An attacker could replace the contents of the hidden cell with a different computer name and get the SA password. To avoid this problem, never hard-code passwords, and always check server IDs against an internal list of servers that are known to be good before accessing the server.

### Recommendations

- Always validate input and data, whether it comes from the user, the document, a database, a web service, or any other source.

- Be careful about exposing particular types of functionality, such as getting privileged data on behalf of the user and putting it into an unprotected worksheet.

- Depending on the type of application, it might make sense to verify that the original document is running before executing any code. For example, verify that it is running from a document stored at a known, secure location.

- It might be a good idea to display a warning when the document opens if your application performs any privileged actions. For example, you might create a splash screen or a startup dialog box saying that the application will access personal information, and have the user choose to continue or cancel. If an end user gets such a warning from a seemingly innocent document, he or she will be able to quit the application before anything is compromised.

## Code is blocked by the Outlook object model guard
 Microsoft Office can restrict code from using certain properties, methods, and objects in the object model. By restricting access to these objects, Outlook helps to prevent email worms and viruses from using the object model for malicious purposes. This security feature is known as the Outlook object model guard. If a VSTO Add-in attempts to use a restricted property or method while the object model guard is enabled, Outlook displays a security warning that enables the user to stop the operation, or enables the user to grant access to the property or method for a limited period of time. If the user stops the operation, Outlook VSTO Add-ins created by using Office solutions in Visual Studio will throw a <xref:System.Runtime.InteropServices.COMException>.

 The object model guard can affect VSTO Add-ins in different ways, depending on whether Outlook is used with Microsoft Exchange Server:

- If Outlook is not used with Exchange, an administrator can enable or disable the object model guard for all VSTO Add-ins on the computer.

- If Outlook is used with Exchange, an administrator can enable or disable the object model guard for all VSTO Add-ins on the computer, or the administrator can specify that certain VSTO Add-ins can run without encountering the object model guard. Administrators can also modify the behavior of the object model guard for certain areas of the object model. For example, administrators can automatically allow VSTO Add-ins to send email programmatically, even if the object model guard is enabled.

  Starting in Outlook 2007, the behavior of the object model guard has been changed to improve the developer and user experience while helping to keep Outlook secure. For more information, see [Code security changes in Outlook 2007](/previous-versions/office/developer/office-2007/bb226709(v=office.12)).

### Minimize object model guard warnings
 To help avoid security warnings when you use restricted properties and methods, make sure that your VSTO Add-in obtains Outlook objects from the `Application` field of the `ThisAddIn` class in your project. For more information about this field, see [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md).

 Only Outlook objects obtained from this object can be trusted by the object model guard. In contrast, objects that are obtained from a new `Microsoft.Office.Interop.Outlook.Application` object are not trusted, and the restricted properties and methods will raise security warnings if the object model guard is enabled.

 The following code example displays a security warning if the object model guard is enabled. The `To` property of the `Microsoft.Office.Interop.Outlook.MailItem` class is restricted by the object model guard. The `Microsoft.Office.Interop.Outlook.MailItem` object is untrusted because the code gets it from a `Microsoft.Office.Interop.Outlook.Application` that is created using the **new** operator, instead of obtaining it from the `Application` field.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreOutlookSecurity/ThisAddIn.cs" id="Snippet1":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreOutlookSecurity/ThisAddIn.vb" id="Snippet1":::
 ---

 The following code example demonstrates how to use the restricted To property of a `Microsoft.Office.Interop.Outlook.MailItem` object that is trusted by the object model guard. The code uses the trusted `Application` field to get the `Microsoft.Office.Interop.Outlook.MailItem`.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreOutlookSecurity/ThisAddIn.cs" id="Snippet2":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreOutlookSecurity/ThisAddIn.vb" id="Snippet2":::
 ---

> [!NOTE]
> If Outlook is used with Exchange, then obtaining all Outlook objects from `ThisAddIn.Application` does not guarantee that your VSTO Add-in will be able to access the entire Outlook object model. For example, if an Exchange administrator sets Outlook to automatically deny all attempts to access address information using the Outlook object model, then Outlook will not allow the previous code example to access the To property, even though the code example uses the trusted `ThisAddIn.Application` field.

### Specify which Add-ins to trust when using Exchange
 When Outlook is used with Exchange, administrators can specify that certain VSTO Add-ins can run without encountering the object model guard. Outlook VSTO Add-ins created by using Office solutions in Visual Studio cannot be trusted individually; they can only be trusted as a group.

 Outlook trusts a VSTO Add-in based on a hash code of the entry point DLL of the VSTO Add-in. All Outlook VSTO Add-ins that target the  Visual Studio Tools for Office runtime  use the same entry point DLL (*VSTOLoader.dll*). This means that if an administrator trusts any VSTO Add-in that targets the  Visual Studio Tools for Office runtime  to run without encountering the object model guard, then all other VSTO Add-ins that target the  Visual Studio Tools for Office runtime  are also trusted. For more information about trusting specific VSTO Add-ins to run without encountering the object model guard, see [Specify the method Outlook uses to manage virus prevention features](/previous-versions/office/office-2007-resource-kit/cc179194(v=office.12)).

## Permission changes do not take effect immediately
 If the administrator adjusts permissions for a document or assembly, users must quit and then restart all Office applications for those changes to be enforced.

 Other applications that host Microsoft Office applications can also prevent the new permissions from being enforced. Users should quit all applications that use Office, hosted or stand-alone, when security policies are changed.

## Trust center settings in the Microsoft Office system do not affect Add-ins or document-level customizations
 Users can prevent VSTO Add-ins from loading by setting an option in the **Trust Center**. However, VSTO Add-ins and document-level customizations created by using Office solutions in Visual Studio are not affected by these trust settings.

 If the user prevents VSTO Add-ins from loading by using the **Trust Center**, the following types of VSTO Add-ins will not load:

- Managed and unmanaged COM VSTO Add-ins.

- Managed and unmanaged smart documents.

- Managed and unmanaged Automation VSTO Add-ins.

- Managed and unmanaged real-time data components.

  The following procedures describe how users can use the **Trust Center** to restrict VSTO Add-ins from loading in Microsoft  Office 2013  and Microsoft Office 2010. These procedures do not affect VSTO Add-ins or customizations created by using Office development tools in Visual Studio.

#### To disable VSTO Add-ins in Microsoft Office 2010 and Microsoft  Office 2013  applications

1. Choose the **File** tab.

2. Choose the *ApplicationName* **Options** button.

3. In the categories pane, choose **Trust Center**.

4. In the details pane, choose **Trust Center Settings**.

5. In the categories pane, choose **Add-ins**.

6. In the details pane, select **Require Application Add-ins to be Signed by Trusted Publisher** or **Disable all Application Add-ins**.

## Related content
- [Secure Office solutions](../vsto/securing-office-solutions.md)
