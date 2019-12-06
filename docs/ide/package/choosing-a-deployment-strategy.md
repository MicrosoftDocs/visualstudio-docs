---
title: "Choosing a Deployment Strategy | Microsoft Docs"
ms.date: "08/29/2011"
ms.topic: "conceptual"
helpviewer_keywords:
  - "packaging"
  - "packaging, overview"
ms.workload:
  - "multiple"
---
choosing-a-deployment-strategy

# Choosing a Deployment Strategy

You can deploy Windows-based applications from Visual Studio by using either of the following technologies:

  - ClickOnce.

  - Windows Installer.

Use ClickOnce to publish the application to a centralized location. The user installs or runs the application from that location. Use Windows Installer to create an application installer file (.msi) and distribute that file. The users run the file to install the application.


> [!NOTE]
> <P>The deployment tools in Visual Studio are designed to handle typical enterprise deployment needs: they do not cover every possible deployment scenario. For more advanced deployment scenarios, you may require a third-party deployment tool or a software distribution tool such as <A href="http://go.microsoft.com/fwlink/?linkid=142133">Systems Management Server</A>.</P>


## Advantages of ClickOnce Deployment

In general, ClickOnce deployment simplifies the process of installing and updating an application. You can use the **Publish Wizard** to package your application and manifests, and to publish the application to a Web site or a network file share. Then, the users can install and start the application directly from that location in a single step.

Because ClickOnce deployed applications are self-updating, ClickOnce is the best choice for applications that require frequent updates. Users must have network connectivity to take advantage of ClickOnce update capabilities, although ClickOnce applications can be installed for the first time using a CD-ROM.

### Security in ClickOnce

ClickOnce security relies on Authenticode certificates to determine whether an application should be installed, a step known as a trust decision. Application and deployment manifests that describe an application can be signed with a certificate to prevent tampering.

Domain administrators can configure certificates to be trusted at the enterprise or machine level. If certificates are not trusted at the time of installation, ClickOnce deployment can be configured to ask users to make trust decisions. Once an application is installed, ClickOnce restricts the application permissions and actions as defined by the Internet, Local Intranet, or custom zones.

## Advantages of Windows Installer Deployment

Windows Installer deployment can advertise applications and features according to specific operating systems, install products on demand, and detect and reinstall damaged components. For more information about Windows Installer advertisement, see [Advertisement (Windows)](https://msdn.microsoft.com/en-us/library/aa367548).

To create a Windows Installer file (.msi) that is distributed to users, you can add a Visual Studio Setup project to your Visual Studio solution. In both scenarios, the user runs the installer file and steps through a wizard to install the application.

You can configure Visual Studio Setup projects by using the following designers: Customs Actions Editor, File System Editor, File Types Editor, Launch Condition Editor, Registry Editor, and User Interface Editor. Each editor enables you to specify the steps that occur on the target computer during installation.

### Security in Windows Installer

Windows Installer can use digital signatures to detect and correct corrupted resources. In Windows XP, Windows Installer is integrated with Software Restriction Policy to restrict both administrators and non-administrators from running program files based on the path, URL zone, hash, or publisher criteria. For more information, see [Windows Installer and Software Restriction Policy (Windows)](https://msdn.microsoft.com/en-us/library/aa372826). In Windows Vista, Windows Installer uses User Account Control Patching to make sure that the signature matches the certificate listed in the .msi resources. For more information, see [User Account Control (UAC) Patching](https://msdn.microsoft.com/en-us/library/aa372388).

## ClickOnce and Windows Installer Comparison Table

The following table compares the features of ClickOnce deployment and Windows Installer deployment.

<table>
<colgroup>
<col style="width: 33%" />
<col style="width: 33%" />
<col style="width: 33%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Feature</p></th>
<th><p>ClickOnce</p></th>
<th><p>Windows Installer</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Automatic update</p></td>
<td><p>Yes</p></td>
<td><p>Yes</p></td>
</tr>
<tr class="even">
<td><p>Post-installation rollback1</p></td>
<td><p>Yes</p></td>
<td><p>No</p></td>
</tr>
<tr class="odd">
<td><p>Update from Web</p></td>
<td><p>Yes</p></td>
<td><p>No</p></td>
</tr>
<tr class="even">
<td><p>Does not affect shared components or other applications</p></td>
<td><p>Yes</p></td>
<td><p>No</p></td>
</tr>
<tr class="odd">
<td><p>Security permissions granted</p></td>
<td><p>Grants only permissions necessary for the application (more safe)</p></td>
<td><p>Grants Full Trust by default (less safe)</p></td>
</tr>
<tr class="even">
<td><p>Security permissions required</p></td>
<td><p>Internet or Intranet Zone (Full Trust for CD-ROM installation)</p></td>
<td><p>Administrator</p></td>
</tr>
<tr class="odd">
<td><p>Application and deployment manifest signing</p></td>
<td><p>Yes</p></td>
<td><p>No</p></td>
</tr>
<tr class="even">
<td><p>Installation-time user interface</p></td>
<td><p>Single prompt</p></td>
<td><p>Multipart Wizard</p></td>
</tr>
<tr class="odd">
<td><p>Installation of assemblies on demand</p></td>
<td><p>Yes</p></td>
<td><p>No</p></td>
</tr>
<tr class="even">
<td><p>Installation of shared files</p></td>
<td><p>No</p></td>
<td><p>Yes</p></td>
</tr>
<tr class="odd">
<td><p>Installation of drivers</p></td>
<td><p>No</p></td>
<td><p>Yes (with custom actions)</p></td>
</tr>
<tr class="even">
<td><p>Installation to Global Assembly Cache</p></td>
<td><p>No</p></td>
<td><p>Yes</p></td>
</tr>
<tr class="odd">
<td><p>Installation for multiple users</p></td>
<td><p>No</p></td>
<td><p>Yes</p></td>
</tr>
<tr class="even">
<td><p>Add application to <strong>Start</strong> menu</p></td>
<td><p>Yes</p></td>
<td><p>Yes</p></td>
</tr>
<tr class="odd">
<td><p>Add application to Startup group</p></td>
<td><p>No</p></td>
<td><p>Yes</p></td>
</tr>
<tr class="even">
<td><p>Add application to <strong>Favorites</strong> menu</p></td>
<td><p>No</p></td>
<td><p>Yes</p></td>
</tr>
<tr class="odd">
<td><p>Register file types</p></td>
<td><p>Yes</p></td>
<td><p>Yes</p></td>
</tr>
<tr class="even">
<td><p>Install time registry access</p></td>
<td><p>Limited</p></td>
<td><p>Yes</p></td>
</tr>
<tr class="odd">
<td><p>Binary file patching</p></td>
<td><p>No</p></td>
<td><p>Yes</p></td>
</tr>
<tr class="even">
<td><p>Application installation location</p></td>
<td><p>ClickOnce application cache</p></td>
<td><p><strong>Program Files</strong> folder</p></td>
</tr>
</tbody>
</table>

**Notes**

1\. With ClickOnce, rollback is available in **Add or Remove Programs** in Windows XP and **Programs and Features** in Windows Vista.

## See Also

#### Concepts

[ClickOnce Security and Deployment](clickonce-security-and-deployment.md)

[Visual Studio Installer Deployment](visual-studio-installer-deployment.md)

#### Other Resources

[Deploying Applications and Components](choosing-a-deployment-strategy.md)

