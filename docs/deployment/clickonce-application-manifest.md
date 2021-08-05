---
title: "ClickOnce Application Manifest | Microsoft Docs"
description: Learn about the ClickOnce application manifest, which is an XML file that describes an application that is deployed using ClickOnce.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "application manifests [ClickOnce]"
  - "ClickOnce, application manifests"
ms.assetid: 29570cec-4e53-4660-a850-abc4fa150243
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
ms.workload:
  - "multiple"
---
# ClickOnce application manifest
A [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application manifest is an XML file that describes an application that is deployed using [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)].

[!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application manifests have the following elements and attributes.

| Element | Description | Attributes |
| - | - | - |
| [\<assembly> Element](../deployment/assembly-element-clickonce-application.md) | Required. Top-level element. | `manifestVersion` |
| [\<assemblyIdentity> Element](../deployment/assemblyidentity-element-clickonce-application.md) | Required. Identifies the primary assembly of the [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application. | `name`<br /><br /> `version`<br /><br /> `publicKeyToken`<br /><br /> `processorArchitecture`<br /><br /> `language` |
| [\<trustInfo> Element](../deployment/trustinfo-element-clickonce-application.md) | Identifies the application security requirements. | None |
| [\<entryPoint> Element](../deployment/entrypoint-element-clickonce-application.md) | Required. Identifies the application code entry point. | `name` |
| [\<dependency> Element](../deployment/dependency-element-clickonce-application.md) | Required. Identifies each dependency required for the application to run. Optionally identifies assemblies that need to be preinstalled. | None |
| [\<file> Element](../deployment/file-element-clickonce-application.md) | Optional. Identifies each nonassembly file that is used by the application. Can include Component Object Model (COM) isolation data associated with the file. | `name`<br /><br /> `size`<br /><br /> `group`<br /><br /> `optional`<br /><br /> `writeableType` |
| [\<fileAssociation> Element](../deployment/fileassociation-element-clickonce-application.md) | Optional. Identifies a file extension to be associated with the application. | `extension`<br /><br /> `description`<br /><br /> `progid`<br /><br /> `defaultIcon` |

## Remarks
 The [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application manifest file identifies an application deployed using [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)]. For more information about [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)], see [ClickOnce Security and Deployment](../deployment/clickonce-security-and-deployment.md).

## File location
 A [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application manifest is specific to a single version of a deployment. For this reason, they should be stored separately from deployment manifests. The common convention is to place them in a subdirectory named after the associated version.

 The application manifest always must be signed prior to deployment. If you change an application manifest manually, you must use *mage.exe* to re-sign the application manifest, update the deployment manifest, and then re-sign the deployment manifest. For more information, see [Walkthrough: Manually deploy a ClickOnce application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md).

## File name syntax
 The name of a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application manifest file should be the full name and extension of the application as identified in the `assemblyIdentity` element, followed by the extension *.manifest*. For example, an application manifest that refers to the *Example.exe* application would use the following file name syntax.

 `example.exe.manifest`

## Example
 The following code example shows an application manifest for a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application.

```xml
<?xml version="1.0" encoding="utf-8"?>
<asmv1:assembly xsi:schemaLocation="urn:schemas-microsoft-com:asm.v1 assembly.adaptive.xsd" manifestVersion="1.0" xmlns:asmv3="urn:schemas-microsoft-com:asm.v3" xmlns:dsig="http://www.w3.org/2000/09/xmldsig#" xmlns:co.v2="urn:schemas-microsoft-com:clickonce.v2" xmlns="urn:schemas-microsoft-com:asm.v2" xmlns:asmv1="urn:schemas-microsoft-com:asm.v1" xmlns:asmv2="urn:schemas-microsoft-com:asm.v2" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:co.v1="urn:schemas-microsoft-com:clickonce.v1">
  <asmv1:assemblyIdentity name="My Application Deployment.exe" version="1.0.0.0" publicKeyToken="43cb1e8e7a352766" language="neutral" processorArchitecture="x86" type="win32" />
  <application />
  <entryPoint>
    <assemblyIdentity name="MyApplication" version="1.0.0.0" language="neutral" processorArchitecture="x86" />
    <commandLine file="MyApplication.exe" parameters="" />
  </entryPoint>
  <trustInfo>
    <security>
      <applicationRequestMinimum>
        <PermissionSet Unrestricted="true" ID="Custom" SameSite="site" />
        <defaultAssemblyRequest permissionSetReference="Custom" />
      </applicationRequestMinimum>
      <requestedPrivileges xmlns="urn:schemas-microsoft-com:asm.v3">
        <!--
          UAC Manifest Options
          If you want to change the Windows User Account Control level replace the
          requestedExecutionLevel node with one of the following.

        <requestedExecutionLevel  level="asInvoker" uiAccess="false" />
        <requestedExecutionLevel  level="requireAdministrator" uiAccess="false" />
        <requestedExecutionLevel  level="highestAvailable" uiAccess="false" />

         If you want to utilize File and Registry Virtualization for backward
         compatibility then delete the requestedExecutionLevel node.
    -->
        <requestedExecutionLevel level="asInvoker" uiAccess="false" />
      </requestedPrivileges>
    </security>
  </trustInfo>
  <dependency>
    <dependentOS>
      <osVersionInfo>
        <os majorVersion="4" minorVersion="10" buildNumber="0" servicePackMajor="0" />
      </osVersionInfo>
    </dependentOS>
  </dependency>
  <dependency>
    <dependentAssembly dependencyType="preRequisite" allowDelayedBinding="true">
      <assemblyIdentity name="Microsoft.Windows.CommonLanguageRuntime" version="4.0.20506.0" />
    </dependentAssembly>
  </dependency>
  <dependency>
    <dependentAssembly dependencyType="install" allowDelayedBinding="true" codebase="MyApplication.exe" size="4096">
      <assemblyIdentity name="MyApplication" version="1.0.0.0" language="neutral" processorArchitecture="x86" />
      <hash>
        <dsig:Transforms>
          <dsig:Transform Algorithm="urn:schemas-microsoft-com:HashTransforms.Identity" />
        </dsig:Transforms>
        <dsig:DigestMethod Algorithm="http://www.w3.org/2000/09/xmldsig#sha1" />
        <dsig:DigestValue>DpTW7RzS9IeT/RBSLj54vfTEzNg=</dsig:DigestValue>
      </hash>
    </dependentAssembly>
  </dependency>
<publisherIdentity name="CN=DOMAINCONTROLLER\UserMe" issuerKeyHash="18312a18a21b215ecf4cdb20f5a0e0b0dd263c08" /><Signature Id="StrongNameSignature" xmlns="http://www.w3.org/2000/09/xmldsig#">
...
</Signature></r:issuer></r:license></msrel:RelData></KeyInfo></Signature></asmv1:assembly>
```

## See also
- [Publish ClickOnce applications](../deployment/publishing-clickonce-applications.md)