---
title: Using Visual Studio on an Azure Virtual Machine
titleSuffix: ''
description: Use Visual Studio on an Azure virtual machine with system images for different Visual Studio configurations in the Azure Marketplace.
ms.date: 4/9/2025
ms.topic: concept-article
helpviewer_keywords:
- azure services
- virtual machine
- installation
- visual studio
author: anandmeg
ms.author: meghaanand
manager: mijacobs

ms.subservice: installation
---
# Visual Studio images on Azure

Using Visual Studio in a preconfigured Azure virtual machine (VM) is a quick, easy way to go from nothing to an up-and-running development environment. System images with different Visual Studio configurations are available in the [Azure Marketplace](https://azuremarketplace.microsoft.com/marketplace/apps/category/compute?filters=virtual-machine-images%3Bmicrosoft%3Bwindows&page=1&subcategories=application-infrastructure).

New to Azure? [Create a free Azure account](https://azure.microsoft.com/free).

## What configurations and versions are available?

Images for the latest major versions, Visual Studio 2022, Visual Studio 2019, and Visual Studio 2017 are available in the [Azure Marketplace](https://azuremarketplace.microsoft.com/marketplace/apps?exp=ubp8&search=visual%20studio&page=1&filters=microsoft%3Bwindows). These images are updated at least once a month to include the latest Visual Studio and Windows updates. Although the image names remain unchanged, each image's description includes the installed product version and the date it reflects

| Release version                                                                                                                                                | Editions              | Product version       |
|----------------------------------------------------------------------------------------------------------------------------------------------------------------|-----------------------|-----------------------|
| [Visual Studio 2022 (Microsoft Dev Box compatible)](https://azuremarketplace.microsoft.com/en-US/marketplace/apps/microsoftvisualstudio.visualstudioplustools?exp=ubp8&tab=Overview) | Enterprise, Professional, Community | Version 17.12        |
| [Visual Studio 2019 (Microsoft Dev Box compatible)](https://azuremarketplace.microsoft.com/en-US/marketplace/apps/microsoftvisualstudio.visualstudio2019plustools?exp=ubp8&tab=Overview) | Enterprise, Professional | Version 16.11        |
| [Visual Studio 2017: Latest (Version 15.9)](https://azuremarketplace.microsoft.com/marketplace/apps/microsoftvisualstudio.visualstudio?tab=Overview)           | Enterprise, Community | Version 15.9      |
| [Visual Studio on Windows Server](https://azuremarketplace.microsoft.com/en-us/marketplace/apps/microsoftvisualstudio.visualstudiowsplustools?exp=ubp8&tab=Overview) | Enterprise, Professional, Community | VS 2022 and VS 2019 on Windows Server 2025        |

The Azure VM image offers help you create and test applications more quickly and easily on both Azure VMs and the [Microsoft Dev Box](/azure/dev-box/overview-what-is-microsoft-dev-box) service. For updates on newly added or deprecated images, see the DevBlog post [Giving our Azure marketplace images a makeover](https://devblogs.microsoft.com/visualstudio/giving-our-visual-studio-azure-marketplace-images-a-makeover/). To learn more, visit the [Visual Studio Servicing Policy](/visualstudio/productinfo/vs-servicing-vs).

[Windows client for developers (Microsoft Dev Box compatible)](https://azuremarketplace.microsoft.com/en-us/marketplace/apps/microsoftvisualstudio.windowsplustools?tab=Overview), a Windows 11 Enterprise image is meant to be used as a starting point for creating custom Dev Box images, and contains additional tools and settings to optimize the developer experience. This image doesn't include Visual Studio. For Visual Studio developers, we recommend using our [Visual Studio 2022](https://azuremarketplace.microsoft.com/marketplace/apps/microsoftvisualstudio.visualstudioplustools?exp=ubp8&tab=Overview) or [Visual Studio 2019](https://azuremarketplace.microsoft.com/en-us/marketplace/apps/microsoftvisualstudio.visualstudio2019plustools?tab=Overview) Dev Box compatible images as a starting point.

## What features are installed?

Each image contains the recommended feature set for that Visual Studio edition. Generally, the installation includes:

* All available workloads, including each workload’s recommended optional components. [Learn more about workloads, components, and SDKs included Visual Studio](workload-and-component-ids.md).
* .NET 4.6.2, .NET 4.7, and .NET 4.8 SDKs, Targeting Packs, and Developer Tools
* Visual F#
* GitHub Extension for Visual Studio
* LINQ to SQL Tools

We use the following command line to install Visual Studio when building the images:

```shell
    vs_enterprise.exe --allWorkloads --includeRecommended --passive ^
       --add Microsoft.Net.Component.4.8.SDK ^
       --add Microsoft.Net.Component.4.7.2.SDK ^
       --add Microsoft.Net.Component.4.7.2.TargetingPack ^
       --add Microsoft.Net.Component.4.6.2.SDK ^
       --add Microsoft.Net.Component.4.6.2.TargetingPack ^
       --add Microsoft.Net.ComponentGroup.4.8.DeveloperTools ^
       --add Microsoft.Net.ComponentGroup.4.7.2.DeveloperTools ^
       --add Microsoft.VisualStudio.Component.FSharp ^
       --add Component.GitHub.VisualStudio ^
       --add Microsoft.VisualStudio.Component.LinqToSql
```

If the images don't include a Visual Studio feature that you require, please provide feedback through the feedback tool in the upper-right corner of the page.

## What size VM should I choose?

Azure offers a full range of virtual machine sizes. Because Visual Studio is a powerful, multi-threaded application, you want a VM size that includes at least two processors and 7 GB of memory. We recommend the following VM sizes for the Visual Studio images:

* Standard_D2_v3
* Standard_D2s_v3
* Standard_D4_v3
* Standard_D4s_v3
* Standard_D2_v2
* Standard_D2S_v2
* Standard_D3_v2

For more information on the latest machine sizes, see [Sizes for Windows virtual machines in Azure](/azure/virtual-machines/windows/sizes).

With Azure, you can rebalance your initial choice by resizing the VM. You can either provision a new VM with a more appropriate size, or resize your existing VM to different underlying hardware. For more information, see [Resize a Windows VM](/azure/virtual-machines/windows/resize-vm).

## After the VM is running, what's next?

Visual Studio follows the “bring your own license” model in Azure. As with an installation on proprietary hardware, one of the first steps is licensing your Visual Studio installation. To unlock Visual Studio, either:

* Sign in with a Microsoft account that’s associated with a Visual Studio subscription
* Unlock Visual Studio with the product key that came with your initial purchase

For more information, see [Sign in to Visual Studio](../ide/signing-in-to-visual-studio.md) and [How to unlock Visual Studio](../ide/how-to-unlock-visual-studio.md).

## How do I save the development VM for future or team use?

The spectrum of development environments is huge, and there’s real cost associated with building out the more complex environments. Regardless of your environment’s configuration, you can save, or capture, your configured VM as a "base image" for future use or for other members of your team. Then, when booting a new VM, you provision it from the base image rather than the Azure Marketplace image.

A quick summary: Use the System Preparation tool (Sysprep) and shut down the running VM, and then capture *(Figure 1)* the VM as an image through the UI in the Azure portal. Azure saves the `.vhd` file that contains the image in the storage account of your choosing. The new image then shows up as an Image resource in your subscription’s list of resources.

![Capture an image through the Azure portal’s UI](media/vs-2022/capture-vm.png)

*(Figure 1) Capture an image through the Azure portal’s UI.*

For more information, see [Create a managed image of a generalized VM in Azure](/azure/virtual-machines/windows/capture-image-resource).

> [!IMPORTANT]
> Don’t forget to use Sysprep to prepare the VM. If you miss that step, Azure can't provision a VM from the image.

> [!NOTE]
> You still incur some cost for storage of the images, but that incremental cost can be insignificant compared to the overhead costs to rebuild the VM from scratch for each team member who needs one. For instance, it costs a few dollars to create and store a 127-GB image for a month that's reusable by your entire team. However, these costs are insignificant compared to hours each employee invests to build out and validate a properly configured dev box for their individual use.

Additionally, your development tasks or technologies might need more scale, like varieties of development configurations and multiple machine configurations. You can use Azure DevTest Labs to create *recipes* that automate construction of your "golden image." You can also use DevTest Labs to manage policies for your team’s running VMs. [Using Azure DevTest Labs for developers](/azure/devtest-labs/devtest-lab-developer-lab) is the best source for more information on DevTest Labs.

## Related content

Now that you know about the preconfigured Visual Studio images, the next step is to create a new VM:

* [Create a VM through the Azure portal](/azure/virtual-machines/windows/quick-create-portal)
* [Windows Virtual Machines overview](/azure/virtual-machines/windows/overview)
