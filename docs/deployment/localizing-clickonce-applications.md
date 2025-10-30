---
title: "Localizing ClickOnce Applications"
description: Learn about three ways to localize your ClickOnce application to a version appropriate for a specific culture.
ms.date: "11/04/2016"
ms.topic: concept-article
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
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# Localize ClickOnce applications

Localization is the process of making your application appropriate for a specific culture. This process involves translating user interface (UI) text to a region-specific language, using correct date and currency formatting, adjusting the size of controls on a form, and mirroring controls from right to left if necessary.

 Localizing your application results in the creation of one or more satellite assemblies. Each assembly contains UI strings, images, and other resources specific to a given culture. (Your application's main executable file contains the strings for the default culture for your application.)

 This topic describes three ways to deploy a ClickOnce application for other cultures:

- Include all satellite assemblies in a single deployment.

- Generate one deployment for each culture, with a single satellite assembly included in each.

- Download satellite assemblies on demand.

## Including All Satellite Assemblies in a Deployment
 Instead of publishing multiple ClickOnce deployments, you can publish a single ClickOnce deployment that contains all of the satellite assemblies.

 This method is the default in Visual Studio. To use this method in Visual Studio, you do not have to do any additional work.

 To use this method with *MageUI.exe*, you must set the culture for your application to **neutral** in *MageUI.exe*. Next, you must manually include all of the satellite assemblies in your deployment. In *MageUI.exe*, you can add the satellite assemblies by using the **Populate** button on the **Files** tab of your application manifest.

 The benefit of this approach is that it creates a single deployment and simplifies your localized deployment story. At run time, the appropriate satellite assembly will be used, depending on the default culture of the user's Windows operating system. A drawback of this approach is that it downloads all satellite assemblies whenever the application is installed or updated on a client computer. If your application has a large number of strings, or your customers have a slow network connection, this process can affect performance during application update.

> [!NOTE]
> This approach assumes that your application adjusts the height, width, and position of controls automatically to accommodate different text string sizes in different cultures. Windows Forms contains a variety of controls and technologies that enable you to design your form to make it easily localizable, including the <xref:System.Windows.Forms.FlowLayoutPanel> and <xref:System.Windows.Forms.TableLayoutPanel> controls as well as the <xref:System.Windows.Forms.Control.AutoSize%2A> property.  Also see [How to: Support localization on Windows forms using AutoSize and the TableLayoutPanel control](/previous-versions/visualstudio/visual-studio-2010/1zkt8b33(v=vs.100)).

## Generate one deployment for each culture
 In this deployment strategy, you generate multiple deployments. In each deployment, you include only the satellite assembly needed for a specific culture, and you mark the deployment as specific to that culture.

 To use this method in Visual Studio, set the **Publish Language** property on the **Publish** tab to the desired region. Visual Studio will automatically include the satellite assembly required for the region you select, and will exclude all other satellite assemblies from the deployment.

 [!INCLUDE[ndptecclick](../deployment/includes/dotnet-publish-tool.md)]

 You can accomplish the same thing by using the *MageUI.exe* tool in the Microsoft Windows Software Development Kit (SDK). Use the **Populate** button on the **Files** tab of your application manifest to exclude all other satellite assemblies from the application directory, and then set the **Culture** field on the **Name** tab for your deployment manifest in *MageUI.exe*. These steps not only include the correct satellite assembly, but they also set the `language` attribute on the `assemblyIdentity` element in your deployment manifest to the corresponding culture.

 After publishing the application, you must repeat this step for each additional culture your application supports. You must make sure that you publish to a different Web server directory or file share directory every time, because each application manifest will reference a different satellite assembly, and each deployment manifest will have a different value for the `language` attribute.

## Download satellite assemblies on demand
 If you decide to include all satellite assemblies in a single deployment, you can improve performance by using on-demand downloading, which enables you to mark assemblies as optional. The marked assemblies will not be downloaded when the application is installed or updated. You can install the assemblies when you need them by calling the <xref:System.Deployment.Application.ApplicationDeployment.DownloadFileGroup%2A> method on the <xref:System.Deployment.Application.ApplicationDeployment> class.

 [!INCLUDE[ndptecclick](../deployment/includes/dotnet-support-application-deployment-api.md)]

 Downloading satellite assemblies on demand differs slightly from downloading other types of assemblies on demand. For more information and code examples on how to enable this scenario using the Windows SDK tools for ClickOnce, see [Walkthrough: Downloading Satellite Assemblies on Demand with the ClickOnce Deployment API](../deployment/walkthrough-downloading-satellite-assemblies-on-demand-with-the-clickonce-deployment-api.md).

 You can also enable this scenario in Visual Studio.  For more information, see [Walkthrough: Downloading Satellite Assemblies on Demand with the ClickOnce Deployment API Using the Designer](../deployment/walkthrough-downloading-satellite-assemblies-on-demand-with-the-clickonce-deployment-api-using-the-designer.md).

## Testing localized ClickOnce applications before deployment
 A satellite assembly will be used for a Windows Forms application only if the <xref:System.Threading.Thread.CurrentUICulture%2A> property for the main thread of the application is set to the satellite assembly's culture. Customers in local markets will probably already be running a localized version of Windows with their culture set to the appropriate default.

 You have three options for testing localized deployments before you make your application available to customers:

- You can run your ClickOnce application on the appropriate localized versions of Windows.

- You can set the <xref:System.Threading.Thread.CurrentUICulture%2A> property programmatically in your application. (This property must be set before you call the <xref:System.Windows.Forms.Application.Run%2A> method.)

## Related content
- [\<assemblyIdentity> element](../deployment/assemblyidentity-element-clickonce-deployment.md)
- [ClickOnce security and deployment](../deployment/clickonce-security-and-deployment.md)
- [Globalize Windows forms](/dotnet/framework/winforms/advanced/globalizing-windows-forms)
