---
title: Pre-production inventory in Visual Studio subscription  | Visual Studio Marketplace
author: evanwindom
ms.author: amast
manager: shve
ms.assetid: 7d74e113-8fb2-490e-8502-48cce7b1327a
ms.date: 10/08/2021
ms.topic: conceptual
description:  Learn about admins' responsibility to conduct pre-production inventories
---

# Inventory of pre-production environment
Visual Studio subscriptions simplify asset management by counting users rather than devices.

Visual Studio admins must assign Visual Studio Subscriptions to **specific, named individuals**. Naming conventions such as Dev1, Dev2, or the use of team names such as "FeatureTeam" are **not allowed**.

Here are some ways to simplify taking inventory of your pre-production environment:
- Review your user assignments. Microsoft provides a website called the [Visual Studio Administration Portal](https://manage.visualstudio.com/) to help you track Visual Studio subscription assignments.
- Use your on-premise or cloud-based Active Directory to list users. If you use Active Directory to manage user access, you may be able to identify development and test users by their directory membership.
- Use automated tools to inventory systems. You may also need to use a software inventory tool to help manage your software assets and distinguish pre-production environments from production ones. Many customers with Microsoft System Center create naming conventions to help automate this part of the inventory process.
- Get help with manual reconciliation. Enlist your staff to help reconcile your development and test users with your development and test environment.

> [!NOTE]
> Visual Studio subscriptions software is not licensed for production environments, including any environment accessed by end users for more than acceptance testing or feedback, an environment connecting to a production database, supporting disaster recovery or production backup, or used for production during peak periods of activity. Exceptions to this include specific benefits for certain subscription levels, outlined in the [Visual Studio Licensing White Paper](https://aka.ms/vslicensing).  

## Resources
- [Visual Studio licensing white paper](https://visualstudio.microsoft.com/wp-content/uploads/2019/06/Visual-Studio-Licensing-Whitepaper-May-2019.pdf)
- [Visual Studio subscriptions support](https://aka.ms/vsadminhelp)
- [Volume Licensing terms](https://www.microsoft.com/licensing/product-licensing/products.aspx)

## See also
- [Visual Studio documentation](/visualstudio/)
- [Azure DevOps documentation](/azure/devops/)
- [Azure documentation](/azure/)
- [Microsoft 365 documentation](/microsoft-365/)

## Next steps
Learn more about responsibilities for admins:
- [Admin responsibilities](admin-responsibilities.md)
- [Manage large teams and external contractors](manage-teams.md)
- [Track user assignments and process orders](assignments-orders.md)
- Use [Maximum Usage](maximum-usage.md) to track purchase commitments