---
title: "Localizing ClickOnce Applications | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "WPF, ClickOnce applications"
  - "ClickOnce deployment, globalization"
  - "deploying applications [ClickOnce], localizing ClickOnce applications"
  - "localization, ClickOnce deployment"
  - "ClickOnce deployment, download on-demand"
  - "ClickOnce deployment, localization"
  - "Windows Forms, ClickOnce applications"
  - "console applications, ClickOnce applications"
ms.assetid: c92b193b-054d-4923-834b-d4226a4c7a1a
caps.latest.revision: 18
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Localizing ClickOnce Applications
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Localization is the process of making your application appropriate for a specific culture. This process involves translating user interface (UI) text to a region-specific language, using correct date and currency formatting, adjusting the size of controls on a form, and mirroring controls from right to left if necessary.  
  
 Localizing your application results in the creation of one or more satellite assemblies. Each assembly contains UI strings, images, and other resources specific to a given culture. (Your application's main executable file contains the strings for the default culture for your application.)  
  
 This topic describes three ways to deploy a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application for other cultures:  
  
- Include all satellite assemblies in a single deployment.  
  
- Generate one deployment for each culture, with a single satellite assembly included in each.  
  
- Download satellite assemblies on demand.  
  
## Including All Satellite Assemblies in a Deployment  
 Instead of publishing multiple [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] deployments, you can publish a single [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] deployment that contains all of the satellite assemblies.  
  
 This method is the default in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. To use this method in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], you do not have to do any additional work.  
  
 To use this method with MageUI.exe, you must set the culture for your application to **neutral** in MageUI.exe. Next, you must manually include all of the satellite assemblies in your deployment. In MageUI.exe, you can add the satellite assemblies by using the **Populate** button on the **Files** tab of your application manifest.  
  
 The benefit of this approach is that it creates a single deployment and simplifies your localized deployment story. At run time, the appropriate satellite assembly will be used, depending on the default culture of the user's Windows operating system. A drawback of this approach is that it downloads all satellite assemblies whenever the application is installed or updated on a client computer. If your application has a large number of strings, or your customers have a slow network connection, this process can affect performance during application update.  
  
> [!NOTE]
> This approach assumes that your application adjusts the height, width, and position of controls automatically to accommodate different text string sizes in different cultures. Windows Forms contains a variety of controls and technologies that enable you to design your form to make it easily localizable, including the <xref:System.Windows.Forms.FlowLayoutPanel> and <xref:System.Windows.Forms.TableLayoutPanel> controls as well as the <xref:System.Windows.Forms.Control.AutoSize%2A> property.  Also see [How to: Support Localization on Windows Forms Using AutoSize and the TableLayoutPanel Control](https://msdn.microsoft.com/library/1zkt8b33\(v=vs.110\)).  
  
## Generate One Deployment for Each Culture  
 In this deployment strategy, you generate multiple deployments. In each deployment, you include only the satellite assembly needed for a specific culture, and you mark the deployment as specific to that culture.  
  
 To use this method in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], set the **Publish Language** property on the **Publish** tab to the desired region. [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] will automatically include the satellite assembly required for the region you select, and will exclude all other satellite assemblies from the deployment.  
  
 You can accomplish the same thing by using the MageUI.exe tool in the Microsoft [!INCLUDE[winsdklong](../includes/winsdklong-md.md)]. Use the **Populate** button on the **Files** tab of your application manifest to exclude all other satellite assemblies from the application directory, and then set the **Culture** field on the **Name** tab for your deployment manifest in MageUI.exe. These steps not only include the correct satellite assembly, but they also set the `language` attribute on the `assemblyIdentity` element in your deployment manifest to the corresponding culture.  
  
 After publishing the application, you must repeat this step for each additional culture your application supports. You must make sure that you publish to a different Web server directory or file share directory every time, because each application manifest will reference a different satellite assembly, and each deployment manifest will have a different value for the `language`attribute.  
  
## Downloading Satellite Assemblies on Demand  
 If you decide to include all satellite assemblies in a single deployment, you can improve performance by using on-demand downloading, which enables you to mark assemblies as optional. The marked assemblies will not be downloaded when the application is installed or updated. You can install the assemblies when you need them by calling the <xref:System.Deployment.Application.ApplicationDeployment.DownloadFileGroup%2A> method on the <xref:System.Deployment.Application.ApplicationDeployment> class.  
  
 Downloading satellite assemblies on demand differs slightly from downloading other types of assemblies on demand. For more information and code examples on how to enable this scenario using the [!INCLUDE[winsdkshort](../includes/winsdkshort-md.md)] tools for [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)], see [Walkthrough: Downloading Satellite Assemblies on Demand with the ClickOnce Deployment API](../deployment/walkthrough-downloading-satellite-assemblies-on-demand-with-the-clickonce-deployment-api.md).  
  
 You can also enable this scenario in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].  Also see [Walkthrough: Downloading Satellite Assemblies on Demand with the ClickOnce Deployment API Using the Designer](https://msdn.microsoft.com/library/ms366788\(v=vs.110\)) or [Walkthrough: Downloading Satellite Assemblies on Demand with the ClickOnce Deployment API Using the Designer](https://msdn.microsoft.com/library/ms366788\(v=vs.120\)).  
  
## Testing Localized ClickOnce Applications Before Deployment  
 A satellite assembly will be used for a Windows Forms application only if the <xref:System.Threading.Thread.CurrentUICulture%2A> property for the main thread of the application is set to the satellite assembly's culture. Customers in local markets will probably already be running a localized version of Windows with their culture set to the appropriate default.  
  
 You have three options for testing localized deployments before you make your application available to customers:  
  
- You can run your [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application on the appropriate localized versions of Windows.  
  
- You can set the <xref:System.Threading.Thread.CurrentUICulture%2A> property programmatically in your application. (This property must be set before you call the <xref:System.Windows.Forms.Application.Run%2A> method.)  
  
## See Also  
 [\<assemblyIdentity> Element](../deployment/assemblyidentity-element-clickonce-deployment.md)   
 [ClickOnce Security and Deployment](../deployment/clickonce-security-and-deployment.md)   
 [Globalizing Windows Forms](https://msdn.microsoft.com/library/72f6cd92-83be-45ec-aa37-9cb8e3ebc3c5)
