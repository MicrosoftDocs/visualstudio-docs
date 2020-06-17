---
title: Microsoft Windows Virtual Desktop benefit in Visual Studio subscriptions | Microsoft Docs
author: evanwindom
ms.author: lank
manager: lank
ms.assetid: 872c5746-5357-4764-949b-aa525a0adf1a
ms.date: 04/20/2020
ms.topic: conceptual
description:  Learn how you can take advantage of Microsoft Windows Virtual Desktop via your Visual Studio subscription 
---

# Access Windows Virtual Desktop in subscriptions 
Visual Studio subscribers are now able to use their Azure dev/test individual credits for Microsoft Windows Virtual Desktop services.  
Windows Virtual Desktop is a comprehensive desktop and app virtualization service running in the cloud. It’s the only virtual desktop infrastructure (VDI) that delivers simplified management, multi-session Windows 10, optimizations for Office 365 ProPlus, and support for Remote Desktop Services (RDS) environments. Deploy and scale your Windows desktops and apps on Azure in minutes and get built-in security and compliance features.
Here's what you can do when you run Windows Virtual Desktop on Azure:
- Set up a multi-session Windows 10 deployment that delivers a full Windows 10 with scalability
- Virtualize Office 365 ProPlus and optimize it to run in multi-user virtual scenarios
- Provide Windows 7 virtual desktops with free Extended Security Updates
- Bring your existing Remote Desktop Services (RDS) and Windows Server desktops and apps to any computer
- Virtualize both desktops and apps
- Manage Windows 10, Windows Server, and Windows 7 desktops and apps with a unified management experience
For more information about what you can do with Windows Virtual Desktop, watch the [introductory video](https://docs.microsoft.com/azure/virtual-desktop/overview).

## Use Windows Virtual Desktop with Azure 
Visual Studio subscribers now have several ways to use Azure subscriptions to pay for Windows Virtual Desktop services:
- [Azure DevTest individual credits](vs-azure.md).  Subscribers who receive Azure DevTest individual credits as part of their subscriptions can use those credits to pay for Windows Virtual Desktop services.  The amount of the monthly credit depends on the subscription level.
- [Azure DevTest Pay-as-you-Go subscriptions](vs-azure-payg.md).  You can create Azure subscriptions and attach a payment instrument to have a seamless way to pay for your Windows Virtual Desktop usage. 
- [Azure Enterprise Agreement DevTest offer](azure-ea-devtest.md).  With this offer, subscribers with Enterprise Agreements can pay for Windows Virtual Desktop with Azure at discounted pricing. 

## Requirements
Windows Virtual Desktop requires an Azure Active Directory (Azure AD) to which VMs will be joined.  Users must be members of this Azure AD.  There are two options to implement the Azure AD:
- Azure AD Directory Services.  For most users, this is the easier option to implement.
- A virtual machine running a Domain Controller promo.  This option requires more work to set up but offers most users a lower operating cost.
To see a full list of prerequisites for using Windows Virtual Desktop, please visit the Windows Virtual Desktop [overview page](https://docs.microsoft.com/azure/virtual-desktop/overview#requirements). 

## Get started 
When all your prerequisites are in place, you’ll want to complete several actions to get your implementation in place.  Check out these tutorials to get started:
- [Create a Windows Virtual Desktop tenant](https://docs.microsoft.com/azure/virtual-desktop/virtual-desktop-fall-2019/tenant-setup-azure-active-directory)
- [Create a host pool](https://docs.microsoft.com/azure/virtual-desktop/create-host-pools-azure-marketplace) using the Azure portal
- [Manage app groups](https://docs.microsoft.com/azure/virtual-desktop/manage-app-groups) for Windows Virtual Desktop

## Eligibility
| Subscription Level                                                 |     Channels                                            | Benefit                                                          | Renewable?    |
|--------------------------------------------------------------------|---------------------------------------------------------|------------------------------------------------------------------|---------------|
| Visual Studio Enterprise (Standard)   | VL, Azure, Retail, | Available|  Yes          |
| Visual Studio Enterprise with GitHub Enterprise  | VL | Available|  Yes          |
| Visual Studio Professional (Standard) | VL, Azure, Retail                                       | Available                                                             |  Yes             |
| Visual Studio Professional with GitHub Enterprise | VL                                       | Available                                        |  Yes           |
| Visual Studio Test Professional (Standard)                         | VL, Retail                                              | Available|  Yes          |
| MSDN Platforms (Standard)                                          | VL, Retail                                              | Available                                         |  Yes          |
| Visual Studio Enterprise (Standard)  | NFR<sup>1</sup> |Not available  | N/A |
| Visual Studio Enterprise, Visual Studio Professional (monthly cloud) | Azure | Not available | N/A |

<sup>1</sup>  *Includes:  Not for Resale (NFR), FTE, Most Valuable Professional (MVP), Regional Director (RD), Microsoft Partner Network (MPN), Visual Studio Industry Partner (VSIP), Microsoft Certified Trainer, BizSpark, Imagine*

> [!NOTE]
> Microsoft no longer offers Visual Studio Professional Annual subscriptions and Visual Studio Enterprise Annual subscriptions in Cloud Subscriptions. There will be no change to existing customers experience and ability to renew, increase, decrease, or cancel their subscriptions. New customers are encouraged to go to [https://visualstudio.microsoft.com/vs/pricing/](https://visualstudio.microsoft.com/vs/pricing/) to explore different options to purchase Visual Studio.

Not sure which subscription you're using?  Connect to [https://my.visualstudio.com/subscriptions](https://my.visualstudio.com/subscriptions?wt.mc_id=o~msft~docs) to see all the subscriptions assigned to your email address. If you don't see all your subscriptions, you may have one or more assigned to a different email address.  You'll need to sign in with that email address to see those subscriptions.

## See also
- [Azure documentation](https://docs.microsoft.com/azure/)
- [Windows Virtual Desktop documentation](https://docs.microsoft.com/azure/virtual-desktop/)

## Next steps
-	If you need to purchase Visual Studio subscriptions, check out:
     - [Pricing for retail purchases](https://visualstudio.microsoft.com/vs/pricing/) through the Microsoft Store
     - [Volume Licensing programs](https://www.microsoft.com/licensing/default)
-	Learn about [Windows Virtual Desktop](https://docs.microsoft.com/azure/virtual-desktop/overview) 
