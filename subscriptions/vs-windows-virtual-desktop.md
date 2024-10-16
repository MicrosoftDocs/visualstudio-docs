---
title: Microsoft Windows Virtual Desktop in Visual Studio subscriptions
author: joseb-rdc
ms.author: amast
manager: shve
ms.date: 09/11/2024
ms.topic: conceptual
description:  Learn how you can take advantage of Microsoft Windows Virtual Desktop via your Visual Studio subscription 
---

# Access Windows Virtual Desktop in subscriptions

Visual Studio subscribers are now able to use their Azure dev/test individual credits for Microsoft Windows Virtual Desktop services.  

Windows Virtual Desktop is a comprehensive desktop and app virtualization service running in the cloud. It’s the only virtual desktop infrastructure (VDI) that delivers simplified management, multi-session Windows 10, optimizations for Microsoft 365 Apps for enterprise, and support for Remote Desktop Services (RDS) environments. Deploy and scale your Windows desktops and apps on Azure in minutes and get built-in security and compliance features.

Here's what you can do when you run Windows Virtual Desktop on Azure:
+ Set up a multi-session Windows 10 deployment that delivers a full Windows 10 with scalability
+ Virtualize Microsoft 365 Apps for enterprise and optimize it to run in multi-user virtual scenarios
+ Provide Windows 7 virtual desktops with free Extended Security Updates
+ Bring your existing Remote Desktop Services (RDS) and Windows Server desktops and apps to any computer
+ Virtualize both desktops and apps
+ Manage Windows 10, Windows Server, and Windows 7 desktops and apps with a unified management experience
For more information about what you can do with Windows Virtual Desktop, watch the [introductory video](/azure/virtual-desktop/overview).

## Use Windows Virtual Desktop with Azure 

Visual Studio subscribers now have several ways to use Azure subscriptions to pay for Windows Virtual Desktop services:
+ [Azure DevTest individual credits](/azure/devtest/offer/quickstart-individual-credit).  Subscribers who receive Azure DevTest individual credits as part of their subscriptions can use those credits to pay for Windows Virtual Desktop services.  The amount of the monthly credit depends on the subscription level.
+ [Azure DevTest Pay-as-you-Go subscriptions](https://azure.microsoft.com/offers/ms-azr-0023p/).  You can create Azure subscriptions and attach a payment instrument to have a seamless way to pay for your Windows Virtual Desktop usage. 
+ [Azure Enterprise Agreement DevTest offer](/azure/devtest/offer/quickstart-create-enterprise-devtest-subscriptions).  With this offer, subscribers with Enterprise Agreements can pay for Windows Virtual Desktop with Azure at discounted pricing. 

## Requirements

Windows Virtual Desktop requires a Microsoft Entra tenant to which VMs are joined.  Users must be members of this Microsoft Entra tenant.  There are two options to implement the Microsoft Entra tenant:
+ Microsoft Entra services.  For most users, this option is the easier to implement.
+ A virtual machine running a Domain Controller promo.  This option requires more work to set up but offers most users a lower operating cost.
To see a full list of prerequisites for using Windows Virtual Desktop, visit the Windows Virtual Desktop [overview page](/azure/virtual-desktop/overview#requirements). 

## Get started

When all your prerequisites are in place, you should complete several actions to get your implementation in place.  Check out these tutorials to get started:
+ [Create a Windows Virtual Desktop tenant](/azure/virtual-desktop/virtual-desktop-fall-2019/tenant-setup-azure-active-directory)
+ [Create a host pool](/azure/virtual-desktop/create-host-pools-azure-marketplace) using the Azure portal
+ [Manage app groups](/azure/virtual-desktop/manage-app-groups) for Windows Virtual Desktop

## Eligibility

| Subscription Level | Channels | Benefit  | Renewable? |
|--------------------|----------|----------|------------|
| Visual Studio Enterprise (Standard) | VL, Azure, Retail, | Available | Yes |
| Visual Studio Enterprise subscription with GitHub Enterprise  | VL | Available| Yes |
| Visual Studio Professional (Standard) | VL, Azure, Retail | Available | Yes |
| Visual Studio Professional subscription with GitHub Enterprise | VL | Available | Yes |
| Visual Studio Test Professional (Standard) | VL, Retail | Available| Yes |
| MSDN Platforms (Standard) | VL, Retail | Available | Yes |
| Visual Studio Enterprise (Standard)  | NFR* |Not available  | N/A |
| Visual Studio Enterprise, Visual Studio Professional (monthly cloud) | Azure | Not available | N/A |

\* *Includes:  Not for Resale (NFR), FTE, Most Valuable Professional (MVP), Regional Director (RD), Microsoft Cloud Partner Program, Visual Studio Industry Partner (VSIP), Microsoft Certified Trainer, BizSpark, Imagine, NFR Basic*

> [!NOTE]
> Microsoft no longer offers Visual Studio Professional Annual subscriptions and Visual Studio Enterprise Annual subscriptions in Cloud Subscriptions. There will be no change to existing customers experience and ability to renew, increase, decrease, or cancel their subscriptions. New customers are encouraged to go to [https://visualstudio.microsoft.com/vs/pricing/](https://visualstudio.microsoft.com/vs/pricing/) to explore different options to purchase Visual Studio.

Not sure which subscription you're using?  Connect to [https://my.visualstudio.com/subscriptions](https://my.visualstudio.com/subscriptions?wt.mc_id=o~msft~docs) to see all the subscriptions assigned to your email address. If you don't see all your subscriptions, you might have one or more assigned to a different email address.  You need to sign in with that email address to see those subscriptions.

## See also

+ [Azure documentation](/azure/)
+ [Windows Virtual Desktop documentation](/azure/virtual-desktop/)
+ [Visual Studio subscriptions support](https://my.visualstudio.com/gethelp)

## Next steps

+ If you need to purchase Visual Studio subscriptions, check out:
  + [Pricing for retail purchases](https://visualstudio.microsoft.com/vs/pricing/) through the Microsoft Store
  + [Volume Licensing programs](https://www.microsoft.com/licensing/default)
+ Learn about [Windows Virtual Desktop](/azure/virtual-desktop/overview)
