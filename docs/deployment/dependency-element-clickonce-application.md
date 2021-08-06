---
title: "&lt;dependency&gt; Element (ClickOnce Application) | Microsoft Docs"
description: The dependency element identifies a platform or assembly dependency that is required for the application.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
f1_keywords:
  - "urn:schemas-microsoft-com:asm.v2#osVersionInfo"
  - "urn:schemas-microsoft-com:asm.v2#os"
  - "http://www.w3.org/2000/09/xmldsig#Transform"
  - "urn:schemas-microsoft-com:asm.v2#dependency"
  - "http://www.w3.org/2000/09/xmldsig#DigestValue"
  - "urn:schemas-microsoft-com:asm.v2#assemblyIdentity"
  - "http://www.w3.org/2000/09/xmldsig#DigestMethod"
  - "http://www.w3.org/2000/09/xmldsig#Transforms"
  - "urn:schemas-microsoft-com:asm.v2#hash"
  - "urn:schemas-microsoft-com:asm.v2#dependentAssembly"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "manifests [ClickOnce], dependency element"
  - "<dependency> element [ClickOnce application manifest]"
ms.assetid: 09d6a1e0-60f8-4fbd-843b-8e49ee3115a3
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
ms.workload:
  - "multiple"
---
# &lt;dependency&gt; element (ClickOnce application)
Identifies a platform or assembly dependency that is required for the application.

## Syntax

```xml

      <dependency>
   <dependentOS
      supportURL
      description
   >
      <osVersionInfo>
         <os
            majorVersion
            minorVersion
            buildNumber
            servicePackMajor
            servicePackMinor
            productType
            suiteType
         />
      </osVersionInfo>
   </dependentOS>
   <dependentAssembly
      dependencyType
      allowDelayedBinding
      group
      codeBase
      size
   >
      <assemblyIdentity
         name
         version
         processorArchitecture
         language
      >
         <hash>
            <dsig:Transforms>
               <dsig:Transform
                  Algorithm
            />
            </dsig:Transforms>
            <dsig:DigestMethod />
            <dsig:DigestValue>
            </dsig:DigestValue>
    </hash>

      </assemblyIdentity>
   </dependentAssembly>
</dependency>
```

## Elements and attributes
 The `dependency` element is required. There may be multiple instances of `dependency` in the same application manifest.

 The `dependency` element has no attributes, and contains the following child elements.

### dependentOS
 Optional. Contains the `osVersionInfo` element. The `dependentOS` and `dependentAssembly` elements are mutually exclusive: one or the other must exist for a `dependency` element, but not both.

 `dependentOS` supports the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`supportUrl`|Optional. Specifies a support URL for the dependent platform. This URL is shown to the user if the required platform is found.|
|`description`|Optional. Describes, in human-readable form, the operating system described by the `dependentOS` element.|

### osVersionInfo
 Required. This element is a child of the `dependentOS` element and contains the `os` element. This element has no attributes.

### os
 Required. This element is a child of the `osVersionInfo` element. This element has the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`majorVersion`|Required. Specifies the major version number of the OS.|
|`minorVersion`|Required. Specifies the minor version number of the OS.|
|`buildNumber`|Required. Specifies the build number of the OS.|
|`servicePackMajor`|Required. Specifies the service pack major number of the OS.|
|`servicePackMinor`|Optional. Specifies the service pack minor number of the OS.|
|`productType`|Optional. Identifies the product type value. Valid values are `server`, `workstation`, and `domainController`. For example, for Windows 2000 Professional, this attribute value is `workstation`.|
|`suiteType`|Optional. Identifies a product suite available on the system, or the system's configuration type. Valid values are `backoffice`, `blade`, `datacenter`, `enterprise`, `home`, `professional`, `smallbusiness`, `smallbusinessRestricted`, and `terminal`. For example, for Windows 2000 Professional, this attribute value is `professional`.|

### dependentAssembly
 Optional. Contains the `assemblyIdentity` element. The `dependentOS` and `dependentAssembly` elements are mutually exclusive: one or the other must exist for a `dependency` element, but not both.

 `dependentAssembly` has the following attributes.

| Attribute | Description |
|-----------------------| - |
| `dependencyType` | Required. Specifies the dependency type. Valid values are `preprequisite` and `install`. An `install` assembly is installed as part of the [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application. A `prerequisite` assembly must be present in the global assembly cache (GAC) before the [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application can install. |
| `allowDelayedBinding` | Required. Specifies whether the assembly can be loaded programmatically at run time. |
| `group` | Optional. If the `dependencyType` attribute is set to `install`, designates a named group of assemblies that only install on demand. For more information, see [Walkthrough: Downloading Assemblies on Demand with the ClickOnce Deployment API Using the Designer](../deployment/walkthrough-downloading-assemblies-on-demand-with-the-clickonce-deployment-api-using-the-designer.md).<br /><br /> If set to `framework` and the `dependencyType` attribute is set to `prerequisite`, designates the assembly as part of the .NET Framework. The global assemby cache (GAC) is not checked for this assembly when installing on .NET Framework 4 and later versions. |
| `codeBase` | Required when the `dependencyType` attribute is set to `install`. The path to the dependent assembly. May be either an absolute path, or a path relative to the manifest's code base. This path must be a valid URI in order for the assembly manifest to be valid. |
| `size` | Required when the `dependencyType` attribute is set to `install`. The size of the dependent assembly, in bytes. |

### assemblyIdentity
 Required. This element is a child of the `dependentAssembly` element and has the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`name`|Required. Identifies the name of the application.|
|`version`|Required. Specifies the version number of the application in the following format: `major.minor.build.revision`|
|`publicKeyToken`|Optional. Specifies a 16-character hexadecimal string that represents the last 8 bytes of the `SHA-1` hash value of the public key under which the application or assembly is signed. The public key used to sign the catalog must be 2048 bits or more.|
|`processorArchitecture`|Optional. Specifies the processor. The valid values are `x86` for 32-bit Windows and `I64` for 64-bit Windows.|
|`language`|Optional. Identifies the two part language codes, such as EN-US, of the assembly.|

### hash
 The `hash` element is an optional child of the `assemblyIdentity` element. The `hash` element has no attributes.

 [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] uses an algorithmic hash of all the files in an application as a security check, to ensure that none of the files were changed after deployment. If the `hash` element is not included, this check will not be performed. Therefore, omitting the `hash` element is not recommended.

### dsig:Transforms
 The `dsig:Transforms` element is a required child of the `hash` element. The `dsig:Transforms` element has no attributes.

### dsig:Transform
 The `dsig:Transform` element is a required child of the `dsig:Transforms` element. The `dsig:Transform` element has the following attributes.

| Attribute | Description |
|-------------| - |
| `Algorithm` | The algorithm used to calculate the digest for this file. Currently the only value used by [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] is `urn:schemas-microsoft-com:HashTransforms.Identity`. |

### dsig:DigestMethod
 The `dsig:DigestMethod` element is a required child of the `hash` element. The `dsig:DigestMethod` element has the following attributes.

| Attribute | Description |
|-------------| - |
| `Algorithm` | The algorithm used to calculate the digest for this file. Currently the only value used by [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] is `http://www.w3.org/2000/09/xmldsig#sha1`. |

### dsig:DigestValue
 The `dsig:DigestValue` element is a required child of the `hash` element. The `dsig:DigestValue` element has no attributes. Its text value is the computed hash for the specified file.

## Remarks
 All assemblies used by your application must have a corresponding `dependency` element. Dependent assemblies do not include assemblies that must be preinstalled in the global assembly cache as platform assemblies.

## Example
 The following code example illustrates `dependency` elements in a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application manifest. This code example is part of a larger example provided for the [ClickOnce Application Manifest](../deployment/clickonce-application-manifest.md) topic.

```xml
<dependency>
  <dependentOS>
    <osVersionInfo>
      <os
        majorVersion="4"
        minorVersion="10"
        buildNumber="0"
        servicePackMajor="0" />
    </osVersionInfo>
  </dependentOS>
</dependency>
<dependency>
  <dependentAssembly
    dependencyType="preRequisite"
    allowDelayedBinding="true">
    <assemblyIdentity
      name="Microsoft.Windows.CommonLanguageRuntime"
      version="4.0.20506.0" />
  </dependentAssembly>
</dependency>

<dependency>
  <dependentAssembly
    dependencyType="install"
    allowDelayedBinding="true"
    codebase="MyApplication.exe"
    size="4096">
    <assemblyIdentity
      name="MyApplication"
      version="1.0.0.0"
      language="neutral"
      processorArchitecture="x86" />
    <hash>
      <dsig:Transforms>
        <dsig:Transform Algorithm="urn:schemas-microsoft-com:HashTransforms.Identity" />
      </dsig:Transforms>
      <dsig:DigestMethod Algorithm="http://www.w3.org/2000/09/xmldsig#sha1" />
      <dsig:DigestValue>DpTW7RzS9IeT/RBSLj54vfTEzNg=</dsig:DigestValue>
    </hash>
  </dependentAssembly>
</dependency>
```

## See also
- [ClickOnce application manifest](../deployment/clickonce-application-manifest.md)
- [\<dependency> element](../deployment/dependency-element-clickonce-deployment.md)