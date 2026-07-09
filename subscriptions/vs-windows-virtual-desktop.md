---
title: Use Azure Virtual Desktop with Visual Studio Subscriptions
author: joseb-rdc
ms.author: amast
ms.manager:  shve
ms.date: 07/09/2026
ms.topic: concept-article
description:  Learn how to use Azure Virtual Desktop via your Visual Studio Subscriptions using Azure Dev/Test credits and pricing for developer and testing workloads. 
---

# Use Azure Virtual Desktop with your Visual Studio Subscriptions

Visual Studio subscribers can use their Azure Dev/Test credits to run Azure Virtual Desktop workloads.

Azure Virtual Desktop is a desktop and app virtualization service that runs on Azure. It lets you deliver secure remote desktops and applications to users on any device.

You can use Azure Virtual Desktop with Visual Studio Subscriptions to build and test environments using Azure Dev/Test credits and pricing, helping reduce costs for nonproduction scenarios.

What you can do with Azure Virtual Desktop:
+ Deploy multi-session Windows 11 or Windows 10 desktops to optimize cost and scale 
+ Deliver Microsoft 365 Apps for enterprise in multi-user virtual environments 
+ Provide virtual desktops for legacy scenarios, such as Windows 7 with Extended Security Updates (where applicable) 
+ Publish full desktops or individual applications using RemoteApp 
+ Bring existing Remote Desktop Services (RDS) environments to Azure 
+ Manage desktops and applications using a unified Azure-based management experience 
+ Secure access to desktops and apps with built-in Azure security and compliance features

To learn more about Azure Virtual Desktop, watch the [introductory video](/azure/virtual-desktop/overview).

## Use Azure Virtual Desktop with Azure 

Visual Studio subscribers have several ways to use Azure subscriptions to pay for Azure Virtual Desktop:
+ [Azure Dev/Test individual credits](/azure/devtest/offer/quickstart-individual-credit). Subscribers who receive Azure DevTest individual credits as part of their subscriptions can use those credits to pay for Azure Virtual Desktop services. The amount of the monthly credit depends on the subscription level.
+ [Azure Dev/Test pay-as-you-go subscriptions](https://azure.microsoft.com/offers/ms-azr-0023p/). You can create Azure subscriptions and attach a payment instrument to have a seamless way to pay for Azure Virtual Desktop beyond your included credits. 
+ [Azure Enterprise Agreement Dev/Test offer](/azure/devtest/offer/quickstart-create-enterprise-devtest-subscriptions). With this offer, subscribers with Enterprise Agreements can use Azure at a discounted Dev/Test rates, including Azure Virtual Desktop workloads.

> [!IMPORTANT]
> Azure Dev/Test credits can be used to pay for Azure Virtual Desktop usage. Azure Virtual Desktop access still requires eligible user licenses. For details, see [Licensing Azure Virtual Desktop](https://learn.microsoft.com/azure/virtual-desktop/licensing).

## Requirements

Azure Virtual Desktop requires a Microsoft Entra tenant that your virtual machines (VMs) are joined to. Users must be members of this Microsoft Entra tenant.  

There are several ways to configure identity for Azure Virtual Desktop:
+ Microsoft Entra ID-based deployment. For most users, this option is the easiest to implement and provide a streamlined deployment experience.
+ Hybrid identity with Active Directory Domain Services. This option requires extra configuration, such as domain controller, but might be used for scenarios that rely on existing on-premises environment.

To see a full list of prerequisites for using Azure Virtual Desktop, visit the Azure Virtual Desktop [overview page](/azure/virtual-desktop/overview#requirements). 

## Get started

When you complete the prerequisites, complete the following steps to set up Azure Virtual Desktop:
+ [Create an Azure Virtual Desktop tenant](/azure/virtual-desktop/deploy-azure-virtual-desktop)
+ [Create a host pool](/azure/virtual-desktop/create-host-pools-azure-marketplace) using the Azure portal
+ [Manage app groups](/azure/virtual-desktop/manage-app-groups) for Azure Virtual Desktop

## Eligibility

The availability shown in this table indicates which Visual Studio Subscription levels can use Azure Virtual Desktop with Azure Dev/Test benefits.

Azure Virtual Desktop isn't activated as a separate benefit in the Visual Studio Subscription portal. Instead, eligible subscribers can run Azure Virtual Desktop workloads using their Azure Dev /Test credits and Dev/Test pricing.

| Subscription Level | Channels | Benefit | Renewable? |
| ------------------ | -------- | ------- | ---------- |
| Visual Studio Enterprise (Standard) | VL, Azure, Retail, | Available | Yes |
| Visual Studio Enterprise subscription with GitHub Enterprise | VL | Available | Yes |
| Visual Studio Professional (Standard) | VL, Azure, Retail | Available | Yes |
| Visual Studio Professional subscription with GitHub Enterprise | VL | Available | Yes |
| Visual Studio Test Professional (Standard) | VL, Retail | Available | Yes |
| MSDN Platforms (Standard) | VL, Retail | Available | Yes |
| Visual Studio Enterprise (Standard) | NFR* | Not available | N/A |
| Visual Studio Enterprise, Visual Studio Professional (monthly cloud) | Azure | Not available | N/A |

\* *Not for Resale (NFR), FTE, Most Valuable Professional (MVP), Regional Director (RD), Microsoft AI Cloud Partner Program, Visual Studio Industry Partner (VSIP), Microsoft Certified Trainer, BizSpark, Imagine, NFR Basic, Open Source Heroes, Student Ambassadors, Microsoft Bug Bounty, We. Comms, ISV*

> [!NOTE]
> Microsoft no longer offers Visual Studio Enterprise Annual subscriptions and Visual Studio Professional Annual subscriptions in Cloud Subscriptions. There are no change to existing customers experience and ability to renew, increase, decrease, or cancel their subscriptions. New customers are encouraged to go to [https://visualstudio.microsoft.com/vs/pricing/](https://visualstudio.microsoft.com/vs/pricing/) to explore different options to purchase Visual Studio.

Not sure which subscription you're using? Connect to [https://my.visualstudio.com/subscriptions](https://my.visualstudio.com/subscriptions?wt.mc_id=o~msft~docs) to see all the subscriptions assigned to your email address. If you don't see all your subscriptions, you might have one or more assigned to a different email address. You need to sign in with that email address to see those subscriptions.

## See also

+ [Azure documentation](/azure/)
+ [Azure Virtual Desktop documentation](/azure/virtual-desktop/)
+ [Visual Studio Subscriptions support](https://my.visualstudio.com/gethelp)

## Next steps

+ If you need to purchase Visual Studio subscriptions, check out:
  + [Pricing for retail purchases](https://visualstudio.microsoft.com/vs/pricing/) through the Microsoft Store
  + [Volume Licensing programs](https://www.microsoft.com/licensing/default)
