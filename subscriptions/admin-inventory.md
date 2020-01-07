---
title: Inventory of pre-production environments | Visual Studio Marketplace
author: evanwindom
ms.author: lank
manager: lank
ms.date: 07/23/2019
ms.topic: conceptual
description:  Learn about administrators' responsibilty to conduct pre-production inventories
---

# Inventory of pre-production environment
Visual Studio subscriptions simplify asset management by counting users rather than devices.

Visual Studio administrators must assign Visual Studio Subscriptions to **specific, named individuals**. Naming conventions such as Dev1, Dev2, or the use of team names such as "FeatureTeam" are **not allowed**.

Here are some ways to simplify taking inventory of your pre-production environment:
- Review your user assignments. Microsoft provides a website called the [Visual Studio Administration Portal](https://manage.visualstudio.com/) to help you track Visual Studio subscription assignments.
- Use your on-premise or cloud-based Active Directory to list users. If you use Active Directory to manage user access, you may be able to identify development and test users by their directory membership.
- Use automated tools to inventory systems. You may also need to use a software inventory tool to help manage your software assets and distinguish pre-production environments from production ones. Many customers with Microsoft System Center create naming conventions to help automate this part of the inventory process.
- Get help with manual reconciliation. Enlist your staff to help reconcile your development and test users with your development and test environment.

## Resources
- [Visual Studio licensing white paper](https://aka.ms/vslicensing)
- [Visual Studio Administration and Subscriptions Support](https://visualstudio.microsoft.com/support/support-overview-vs)
- [Volume Licensing terms](https://www.microsoft.com/licensing/product-licensing/products.aspx)

## Next steps
Learn more about responsibilities for administrators:
- [Administrator responsibilities](admin-responsibilities.md)
- [Manage large teams and external contractors](manage-teams.md)
- [Track user assignments and process orders](assignments-orders.md)
- Use [Maximum Usage](maximum-usage.md) to track purchase commitments