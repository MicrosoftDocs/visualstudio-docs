---
title: "Application manifests for Office solutions"
description: Learn how an application manifest is an XML file that describes the assemblies that are loaded into a Microsoft Office solution.
ms.custom: SEO-VS-2020
ms.date: 02/02/2017
ms.topic: reference
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "application manifests [Office development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# Application manifests for Office solutions
  An application manifest is an XML file that describes the assemblies that are loaded into a Microsoft Office solution. The Microsoft Office development tools in Visual Studio use the [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)] application manifest schema defined in the [ClickOnce application manifest](../deployment/clickonce-application-manifest.md) reference.

 Application manifests for Office solutions use the following [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)] elements and attributes.

|Element|Description|Attributes|
|-------------|-----------------|----------------|
|[&#60;assembly&#62; Element &#40;ClickOnce Application&#41;](../deployment/assembly-element-clickonce-deployment.md)|Required. Top-level element.|**manifestVersion**|
|[&#60;assemblyIdentity&#62; Element &#40;ClickOnce Application&#41;](../deployment/assemblyidentity-element-clickonce-deployment.md)|Required. Identifies the [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)] application's primary assembly.|**name**<br /><br /> **version**<br /><br /> **publicKeyToken**<br /><br /> **processorArchitecture**<br /><br /> **language**|
|[&#60;trustInfo&#62; Element &#40;ClickOnce Application&#41;](../deployment/trustinfo-element-clickonce-application.md)|Identifies the application security requirements.|None|
|[&#60;entryPoint&#62; Element &#40;ClickOnce Application&#41;](../deployment/entrypoint-element-clickonce-application.md)|Required. Identifies the application code entry point for execution.|**name**<br /><br /> **dependencyName**<br /><br /> **customHostSpecified**|
|[&#60;dependency&#62; Element &#40;ClickOnce Application&#41;](../deployment/dependency-element-clickonce-deployment.md)|Required. Identifies each dependency required for the application to run. Optionally identifies assemblies that need to be preinstalled.|None|
|[&#60;file&#62; Element &#40;ClickOnce Application&#41;](../deployment/file-element-clickonce-application.md)|Required. Identifies each non-assembly file that is used by the application. Can include Component Object Model (COM) isolation data associated with the file.|**name**<br /><br /> **size**|

 Application manifests for Office solutions have the following element in the `co.v1` namespace.

```xml
<entryPoint>
    <co.v1:customHostSpecified />
</entryPoint>
```

 These application manifests also have the following elements and attributes in the `vstav3` namespace.

```xml
<addIn>
  <entryPointsCollection>
    <entryPoints>
      <entryPoint>
      </entryPoint>
    </entryPoints>
  </entryPointsCollection>
  <update></update>
  <postActions>
    <postAction>
      <postActionData>
      </postActionData>
    <postAction>
  </postActions>
  <application>
    <customizations>
      <customization>
      </customization>
    </customizations>
  </application
</addIn>
```

|Element|Description|Attributes|
|-------------|-----------------|----------------|
|[&#60;customHostSpecified&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/customhostspecified-element-office-development-in-visual-studio.md)|Required. Marks the manifest specifically as an Office solution.|None|
|[&#60;addin&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/addin-element-office-development-in-visual-studio.md)|Required. Stores entry points into a single namespace.|None|
|[&#60;entryPointsCollection&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/entrypointscollection-element-office-development-in-visual-studio.md)|Required. Groups all the assemblies for one or more Office solutions.|**id**|
|[&#60;entryPoints&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/entrypoints-element-office-development-in-visual-studio.md)|Required. Groups all the assemblies to run an Office solution.|None|
|[&#60;entryPoint&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/entrypoint-element-office-development-in-visual-studio.md)|Required. Identifies the assembly to run in an Office solution.|**class**<br /><br /> **contract**|
|[&#60;update&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/update-element-office-development-in-visual-studio.md)|Required. Configures updates for the solution.|**enabled**<br /><br /> **expiration**|
|[&#60;postActions&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/postactions-element-office-development-in-visual-studio.md)|Optional. Groups all the post-deployment actions, which run after Office solutions are installed.|None|
|[&#60;postAction&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/postaction-element-office-development-in-visual-studio.md)|Optional. Identifies a post-deployment action.|None|
|[&#60;postActionData&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/postactiondata-element-office-development-in-visual-studio.md)|Optional. Configures data for a post-deployment action.|None|
|[&#60;application&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/application-element-office-development-in-visual-studio.md)|Required. Wraps the application-specific information into a single node.|None|
|[&#60;customizations&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/customizations-element-office-development-in-visual-studio.md)|Required. Stores all application host-specific information in a separate namespace.|None|
|[&#60;customization&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/customization-element-office-development-in-visual-studio.md)|Required. Stores application host-specific information in a separate namespace.|**xmlns**|
|[&#60;document&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/document-element-office-development-in-visual-studio.md)|Required only for document-level solutions. Stores customization-specific information.|**solutionId**|
|[&#60;appAddin&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/appaddin-element-office-development-in-visual-studio.md)|Required only for application-level solutions. Stores customization-specific information.|**application**<br /><br /> **loadBehavior**<br /><br /> **keyName**|
|[&#60;friendlyName&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/friendlyname-element-office-development-in-visual-studio.md)|Optional. Stores the name of the VSTO Add-in that appears in the list of installed VSTO Add-ins.|None|
|[&#60;description&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/description-element-office-development-in-visual-studio.md)|Required only for VSTO Add-ins. Stores the description that appears in the list of installed programs.|None|
|[&#60;formRegions&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/formregions-element-office-development-in-visual-studio.md)|Required only for Outlook VSTO Add-ins that include form regions.|None|
|[&#60;formRegion&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/formregion-element-office-development-in-visual-studio.md)|Required only for Outlook VSTO Add-ins that include form regions.|**Name**|
|[&#60;vstoRuntime&#62; Element &#40;Office Development in Visual Studio&#41;](../vsto/vstoruntime-element-office-development-in-visual-studio.md)|Required. Describes a specific version of the Visual Studio Tools for Office runtime that is supported by the Office solution.|**release**<br /><br /> **version**<br /><br /> **supportUrl**|

## Remarks
 You can manually edit application and deployment manifests in Office solutions. Afterwards, you must re-sign the application and deployment manifests by using the Manifest Generation and Editing Tool (*mage.exe* and *mageui.exe*). For more information, see [How to: Re-sign application and deployment manifests](../deployment/how-to-re-sign-application-and-deployment-manifests.md).

## File location
 An application manifest is specific to a single version of a solution. For this reason, application manifests should be stored separately from deployment manifests. [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] places the version-specific files in a subdirectory named after the associated version in the *Application Files* subdirectory in the publish folder.

## File name syntax
 The name of an application manifest file should be the full name and extension of the application as identified in the **assemblyIdentity** element, followed by the extension *.manifest*. For example, an application manifest that refers to the *OutlookAddIn1.dll* customization would use the following file name syntax.

 `OutlookAddIn1.dll.manifest`

## See also

- [Deployment manifests for Office solutions](../vsto/deployment-manifests-for-office-solutions.md)
- [ClickOnce application manifest](../deployment/clickonce-application-manifest.md)