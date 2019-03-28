---
title: "&lt;deployment&gt; Element (ClickOnce Deployment) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
f1_keywords: 
  - "urn:schemas-microsoft-com:asm.v2#subscription"
  - "urn:schemas-microsoft-com:asm.v2#beforeApplicationStartup"
  - "urn:schemas-microsoft-com:asm.v2#deploymentProvider"
  - "urn:schemas-microsoft-com:asm.v2#update"
  - "urn:schemas-microsoft-com:asm.v2#deployment"
  - "urn:schemas-microsoft-com:asm.v2#expiration"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "<deployment> element [ClickOnce deployment manifest]"
ms.assetid: 4fafa9c2-97a0-4cea-b8fd-9746dca33af4
caps.latest.revision: 32
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# &lt;deployment&gt; Element (ClickOnce Deployment)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Identifies the attributes used for the deployment of updates and exposure to the system.  
  
## Syntax  
  
```  
  
      <deployment   
   install  
   minimumRequiredVersion  
   mapFileExtensions  
   disallowUrlActivation  
   trustUrlParameters  
>   
   <subscription>   
         <update>   
            <beforeApplicationStartup/>   
            <expiration  
               maximumAge  
               unit  
            />  
         </update>    
   </subscription>   
   <deploymentProvider   
      codebase   
   />   
</deployment>  
```  
  
## Elements and Attributes  
 The `deployment` element is required and is in the `urn:schemas-microsoft-com:asm.v1` namespace. The element has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`install`|Required. Specifies whether this application defines a presence on the Windows **Start** menu and in the Control Panel **Add or Remove Programs** application. Valid values are `true` and `false`. If `false`, [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] will always run the latest version of this application from the network, and will not recognize the `subscription` element.|  
|`minimumRequiredVersion`|Optional. Specifies the minimum version of this application that can run on the client. If the version number of the application is less than the version number supplied in the deployment manifest, the application will not run. Version numbers must be specified in the format `N.N.N.N`, where `N` is an unsigned integer. If the `install` attribute is `false`, `minimumRequiredVersion` must not be set.|  
|`mapFileExtensions`|Optional. Defaults to `false`. If `true`, all files in the deployment must have a .deploy extension. [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] will strip this extension off these files as soon as it downloads them from the Web server. If you publish your application by using [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], it automatically adds this extension to all files. This parameter allows all the files within a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] deployment to be downloaded from a Web server that blocks transmission of files ending in "unsafe" extensions such as .exe.|  
|`disallowUrlActivation`|Optional. Defaults to `false`. If `true`, prevents an installed application from being started by clicking the URL or entering the URL into Internet Explorer. If the `install` attribute is not present, this attribute is ignored.|  
|`trustURLParameters`|Optional. Defaults to `false`. If `true`, allows the URL to contain query string parameters that are passed into the application, much like command-line arguments are passed to a command-line application. For more information, see [How to: Retrieve Query String Information in an Online ClickOnce Application](../deployment/how-to-retrieve-query-string-information-in-an-online-clickonce-application.md).<br /><br /> If the `disallowUrlActivation` attribute is `true`, `trustUrlParameters` must either be excluded from the manifest, or explicitly set to `false`.|  
  
 The `deployment` element also contains the following child elements.  
  
## subscription  
 Optional. Contains the `update` element. The `subscription` element has no attributes. If the `subscription` element does not exist, the [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application will never scan for updates. If the `install` attribute of the `deployment` element is `false`, the `subscription` element is ignored, because a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application that is launched from the network always uses the latest version.  
  
## update  
 Required. This element is a child of the `subscription` element and contains either the `beforeApplicationStartup` or the `expiration` element. `beforeApplicationStartup` and `expiration` cannot both be specified in the same deployment manifest.  
  
 The `update` element has no attributes.  
  
## beforeApplicationStartup  
 Optional. This element is a child of the `update` element and has no attributes. When the `beforeApplicationStartup` element exists, the application will be blocked when [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] checks for updates, if the client is online. If this element does not exist, [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] will first scan for updates based on the values specified for the `expiration` element. `beforeApplicationStartup` and `expiration` cannot both be specified in the same deployment manifest.  
  
## expiration  
 Optional. This element is a child of the `update` element, and has no children. `beforeApplicationStartup` and `expiration` cannot both be specified in the same deployment manifest. When the update check occurs and an updated version is detected, the new version caches while the existing version runs. The new version then installs on the next launch of the [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application.  
  
 The `expiration` element supports the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`maximumAge`|Required. Identifies how old the current update should become before the application performs an update check. The unit of time is determined by the `unit` attribute.|  
|`unit`|Required. Identifies the unit of time for `maximumAge`. Valid units are `hours`, `days`, and `weeks`.|  
  
## deploymentProvider  
 For the .NET Framework 2.0, this element is required if the deployment manifest contains a `subscription` section. For the .NET Framework 3.5 and later, this element is optional, and will default to the server and file path in which the deployment manifest was discovered.  
  
 This element is a child of the `deployment` element and has the following attribute.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`codebase`|Required. Identifies the location, as a Uniform Resource Identifier (URI), of the deployment manifest that is used to update the [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application. This element also allows for forwarding update locations for CD-based installations. Must be a valid URI.|  
  
## Remarks  
 You can configure your [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application to scan for updates on startup, scan for updates after startup, or never check for updates. To scan for updates on startup, ensure that the `beforeApplicationStartup` element exists under the `update` element. To scan for updates after startup, ensure that the `expiration` element exists under the `update` element, and that update intervals are provided.  
  
 To disable checking for updates, remove the `subscription` element. When you specify in the deployment manifest to never scan for updates, you can still manually check for updates by using the <xref:System.Deployment.Application.ApplicationDeployment.CheckForUpdate%2A> method.  
  
 For more information on how deploymentProvider relates to updates, see [Choosing a ClickOnce Update Strategy](../deployment/choosing-a-clickonce-update-strategy.md).  
  
## Examples  
 The following code example illustrates a `deployment` element in a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] deployment manifest. The example uses a `deploymentProvider` element to indicate the preferred update location.  
  
```  
<deployment install="true" minimumRequiredVersion="2.0.0.0" mapFileExtension="true" trustUrlParameters="true">  
    <subscription>  
      <update>  
        <expiration maximumAge="6" unit="hours" />  
      </update>  
    </subscription>  
    <deploymentProvider codebase="http://www.adatum.com/MyApplication.application" />  
  </deployment>  
```  
  
## See Also  
 [ClickOnce Deployment Manifest](../deployment/clickonce-deployment-manifest.md)
