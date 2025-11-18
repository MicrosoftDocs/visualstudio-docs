---
title: Admin responsibilities and roles in subscriptions
author: joseb-rdc
ms.author: amast
manager: shve
ms.date: 09/13/2024
ms.topic: article
description: Review task responsibilities and roles for Visual Studio subscription admins, such as ensuring subscriptions are managed in accordance with license terms.
---
# Overview of admin responsibilities

As an admin, you can manage subscriptions for your organization.  The admin role also carries responsibilities to ensure that the subscriptions are managed in accordance with the license terms. This article outlines the responsibilities, benefits, and limitations of the admin role.

## Roles & responsibilities

A Visual Studio subscriptions admin has four key responsibilities:

1. **Understand the benefits and restrictions of Visual Studio subscriptions.** Correctly understanding your benefits can enable you to reduce hardware costs by using cloud services, and reduce software costs with per-user licenses for preproduction environments. 
2. **Assign Visual Studio subscriptions to specific, named individuals and encourage usage.** Your contract requires that Visual Studio subscriptions be assigned to specific, named individuals. Follow up with your subscribers to ensure they access and take full advantage of the benefits included in their Visual Studio subscription.
3. **Accurately inventory your pre-production environment.** This inventory is essential to ensure all users who interact with Visual Studio-licensed software are appropriately licensed with their own Visual Studio subscription. 
4. **Track user assignment changes and acquire additional licenses on schedule.** Microsoft Volume Licensing (VL) Agreements and MPSA give you flexibility in how you use and assign Visual Studio subscriptions. In return, you're expected to:
+ Manage changes to software usage
+ Manage changes to user assignments
+ Process orders for more licenses on the schedule outlined in the agreement.  To help with this responsibility, there's a [Maximum Usage report](maximum-usage.md) you can run in the Visual Studio Subscription Admin Portal. 

### Inventory of preproduction environment

Visual Studio subscriptions simplify asset management by counting users rather than devices.

Visual Studio admins must assign Visual Studio Subscriptions to **specific, named individuals**. Names that don't identify individual subscribers such as Dev1, Dev2, or the use of team names such as "FeatureTeam" are **not allowed**.

Here are some ways to simplify taking inventory of your preproduction environment:
+ Review your user assignments. Microsoft provides a website called the [Visual Studio Admin Portal](https://manage.visualstudio.com/) to help you manage and track Visual Studio subscription assignments.
+ Use your on-premises or cloud-based Microsoft Entra ID to list users. If you use Microsoft Entra ID to manage user access, you might be able to identify development and test users by their directory membership.
+ Use automated tools to inventory systems. You might also need to use a software inventory tool to help manage your software assets and distinguish preproduction environments from production ones. Many customers with Microsoft System Center create naming conventions to help automate this part of the inventory process.
+ Get help with manual reconciliation. Enlist your staff to help reconcile your dev/test users with your development and test environment.

> [!NOTE]
> Visual Studio subscriptions software is not licensed for production environments, including any environment accessed by end users for more than acceptance testing or feedback, an environment connecting to a production database, supporting disaster recovery or production backup, or used for production during peak periods of activity. Exceptions to this include specific benefits for certain subscription levels, outlined in the [Visual Studio Licensing White Paper](https://aka.ms/vslicensing).  

## Benefits and limitations

Visual Studio subscriptions allow developers to install and use software to design, develop, test, evaluate, and demonstrate other software. Visual Studio Subscriptions software isn't licensed for production environments.

| Category  | Benefit or limitation |
|-----------|---------------------  |
| User-based licensing  | MSDN Platforms and all levels of Visual Studio subscriptions are licensed on a per-user basis. Each development team member that interacts (install, configure, or access) with the software included with these products and services requires their own Visual Studio subscription.  |
| Unlimited installations  | Each licensed user can install and use the software on any number of devices to design, develop, test, evaluate, and demonstrate software. The exception is Microsoft Office, which is licensed for one desktop. Visual Studio-licensed software can be used at work, home, school, and on devices at a customer’s office or on dedicated hardware hosted by a third party.  |
| Not intended for production environments | Visual Studio subscriptions software isn't licensed for production environments.  This limitation includes:  Any environment accessed by end users for more than acceptance testing or feedback, any environment connecting to a production database, supporting disaster recovery or production backup, use for production during peak periods of activity. Exceptions to this include specific benefits for certain subscription levels, outlined in the [Visual Studio Licensing White Paper](https://aka.ms/vslicensing).  |
| License reassignment  | When a user no longer requires a license, you can reassign the license to another user 90 days since it was assigned to the previous user. When you reassign a license, any product keys that were already used are available but aren't replaced. For organizations that have Enterprise Agreements (EA), any benefits that were used by the original user, such as Pluralsight training, are reset.   |
| Exception for end users | At the end of a software development project, end users typically review an application and determine whether it meets the necessary criteria for release. This process is called user acceptance testing (UAT). Team members such as a business sponsor or a product manager can act as proxies for end users. End users who don't have a Visual Studio subscription can access the software for UAT if use of the software otherwise complies with all Visual Studio licensing terms. It's rare that someone whose primary role is designing, developing, or testing the software would also qualify as an “end user." |

## Resources

[Visual Studio administration and subscriptions support](https://aka.ms/vsadminhelp)

## See also

+ [Visual Studio documentation](/visualstudio/)
+ [Azure DevOps documentation](/azure/devops/)
+ [Azure documentation](/azure/)
+ [Microsoft 365 documentation](/microsoft-365/)

## Next steps

Learn more about responsibilities for admins:
+ [Inventory of preproduction environment](admin-inventory.md)
+ [Manage large teams and external contractors](manage-teams.md)
+ [Track user assignments and process orders](assignments-orders.md)
+ Use [Maximum Usage](maximum-usage.md) to track purchase commitments
