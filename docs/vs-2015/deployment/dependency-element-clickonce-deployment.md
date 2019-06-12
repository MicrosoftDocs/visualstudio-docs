---
title: "&lt;dependency&gt; Element (ClickOnce Deployment) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
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
  - "<dependency> element [ClickOnce deployment manifest]"
ms.assetid: 9b4d2082-0347-4922-ac70-85f11b913039
caps.latest.revision: 29
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# &lt;dependency&gt; Element (ClickOnce Deployment)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Identifies the version of the application to install, and the location of the application manifest.  
  
## Syntax  
  
```  
  
      <dependency>   
   <dependentAssembly  
      preRequisite  
      visible  
      dependencyType  
      codeBase  
      size  
   >   
      <assemblyIdentity   
         name   
         version   
         publicKeyToken   
         processorArchitecture   
         language  
         type  
      />   
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
  
   </dependentAssembly>   
</dependency>  
```  
  
## Elements and Attributes  
 The `dependency` element is required. It has no attributes. A deployment manifest can have multiple `dependency` elements.  
  
 The `dependency` element usually expresses dependencies for the main application on assemblies contained within a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application. If your Main.exe application consumes an assembly called DotNetAssembly.dll, then that assembly must be listed in a dependency section. Dependency, however, can also express other types of dependencies, such as dependencies on a specific version of the common language runtime, on an assembly in the global assembly cache (GAC), or on a COM object. Because it is a no-touch deployment technology, [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] cannot initiate download and installation of these types of dependencies, but it does prevent the application from running if one or more of the specified dependencies do not exist.  
  
## dependentAssembly  
 Required. This element contains the `assemblyIdentity` element. The following table shows the attributes the `dependentAssembly` supports.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`preRequisite`|Optional. Specifies that this assembly should already exist in the GAC. Valid values are `true` and `false`. If `true`, and the specified assembly does not exist in the GAC, the application fails to run.|  
|`visible`|Optional. Identifies the top-level application identity, including its dependencies. Used internally by [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] to manage application storage and activation.|  
|`dependencyType`|Required. The relationship between this dependency and the application. Valid values are:<br /><br /> -   `install`. Component represents a separate installation from the current application.<br />-   `preRequisite`. Component is required by the current application.|  
|`codebase`|Optional. The full path to the application manifest.|  
|`size`|Optional. The size of the application manifest, in bytes.|  
  
## assemblyIdentity  
 Required. This element is a child of the `dependentAssembly` element. The content of `assemblyIdentity` must be the same as described in the [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application manifest. The following table shows the attributes of the `assemblyIdentity` element.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`Name`|Required. Identifies the name of the application.|  
|`Version`|Required. Specifies the version number of the application, in the following format: `major.minor.build.revision`|  
|`publicKeyToken`|Required. Specifies a 16-character hexadecimal string that represents the last 8 bytes of the SHA-1 hash of the public key under which the application or assembly is signed. The public key used to sign must be 2048 bits or greater.|  
|`processorArchitecture`|Required. Specifies the microprocessor. The valid values are `x86` for 32-bit Windows and `IA64` for 64-bit Windows.|  
|`Language`|Optional. Identifies the two part language codes of the assembly. For example, EN-US, which stands for English (U.S.). The default is `neutral`. This element is in the `asmv2` namespace.|  
|`type`|Optional. For backwards compatibility with Windows side-by-side install technology. The only allowed value is `win32`.|  
  
## hash  
 The `hash` element is an optional child of the `file` element. The `hash` element has no attributes.  
  
 [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] uses an algorithmic hash of all the files in an application as a security check to ensure that none of the files were changed after deployment. If the `hash` element is not included, this check will not be performed. Therefore, omitting the `hash` element is not recommended.  
  
## dsig:Transforms  
 The `dsig:Transforms` element is a required child of the `hash` element. The `dsig:Transforms` element has no attributes.  
  
## dsig:Transform  
 The `dsig:Transform` element is a required child of the `dsig:Transforms` element. The following table shows the attributes of the `dsig:Transform` element.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`Algorithm`|The algorithm used to calculate the digest for this file. Currently the only value used by [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] is `urn:schemas-microsoft-com:HashTransforms.Identity`.|  
  
## dsig:DigestMethod  
 The `dsig:DigestMethod` element is a required child of the `hash` element. The following table shows the attributes of the `dsig:DigestMethod` element.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`Algorithm`|The algorithm used to calculate the digest for this file. Currently the only value used by [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] is `http://www.w3.org/2000/09/xmldsig#sha1`.|  
  
## dsig:DigestValue  
 The `dsig:DigestValue` element is a required child of the `hash` element. The `dsig:DigestValue` element has no attributes. Its text value is the computed hash for the specified file.  
  
## Remarks  
 Deployment manifests typically have a single `assemblyIdentity` element that identifies the name and version of the application manifest.  
  
## Example  
 The following code example shows a `dependency` element in a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] deployment manifest.  
  
```  
<!-- Identify the assembly dependencies -->  
<dependency>  
  <dependentAssembly dependencyType="install" allowDelayedBinding="true" codebase="MyApplication.exe" size="16384">  
    <assemblyIdentity name="MyApplication" version="0.0.0.0" cultural="neutral" processorArchitecture="msil" />  
    <hash>  
      <dsig:Transforms>  
        <dsig:Transform Algorithm="urn:schemas-microsoft-com:HashTransforms.Identity" />  
      </dsig:Transforms>  
      <dsig:DigestMethod Algorithm="http://www.w3.org/2000/09/xmldsig#sha1" />  
       <dsig:DigestValue>YzXYZJAvj9pgAG3y8jXUjC7AtHg=</dsig:DigestValue>  
    </hash>  
  </dependentAssembly>  
</dependency>  
```  
  
## Example  
 The following code example specifies a dependency on an assembly already installed in the GAC.  
  
```  
<dependency>  
  <dependentAssembly dependencyType="preRequisite" allowDelayedBinding="true">  
    <assemblyIdentity name="GACAssembly" version="1.0.0.0" language="neutral" processorArchitecture="msil" />  
  </dependentAssembly>  
</dependency>  
```  
  
## Example  
 The following code example specifies a dependency on a specific version of the common language runtime.  
  
```  
<dependency>  
  <dependentAssembly dependencyType="preRequisite" allowDelayedBinding="true">  
    <assemblyIdentity name="Microsoft.Windows.CommonLanguageRuntime" version="2.0.50215.0" />  
  </dependentAssembly>  
</dependency>  
```  
  
## Example  
 The following code example specifies an operating system dependency.  
  
```  
<dependency>  
   <dependentOS supportUrl="http://www.microsoft.com" description="Microsoft Windows Operating System">  
      <osVersionInfo>  
         <os majorVersion="4" minorVersion="10" />  
      </osVersionInfo>  
   </dependentOS>  
</dependency>  
```  
  
## See Also  
 [ClickOnce Deployment Manifest](../deployment/clickonce-deployment-manifest.md)   
 [\<dependency> Element](../deployment/dependency-element-clickonce-application.md)
