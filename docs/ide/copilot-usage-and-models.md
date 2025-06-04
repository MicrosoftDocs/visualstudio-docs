---
title: 'GitHub Copilot usage and models'
description: Learn how to manage your GitHub Copilot usage and models directly within Visual Studio.
ms.date: 6/4/2025
ms.topic: overview 
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= vs-2022'
---
# Manage Copilot usage and models

GitHub Copilot includes built-in tools to help you track usage, manage your plan, and understand how model selection affects [request consumption](https://docs.github.com/copilot/managing-copilot/monitoring-usage-and-entitlements/about-premium-requests).

## View Copilot usage

To track your Copilot usage:

1. Select the **Copilot badge** in the top-right corner of Visual Studio.
2. Select **Copilot Consumptions**.

   :::image type="content" source="media/vs-2022/copilot-usage-models/copilot-consumptions-panel.png" alt-text="Screenshot that shows Copilot Consumptions panel." lightbox="media/vs-2022/copilot-usage-models/copilot-consumptions-panel.png":::

Here, you can view your usage and the number of remaining requests. You can also select **Get more requests** to manage your Copilot plan on *GitHub*.

> [!NOTE]
> GitHub manages billing and subscriptions. For details, visit your [GitHub billing settings](https://github.com/settings/billing).

## Understand model selection

Copilot supports multiple AI models, and each model may consume requests at different rates based on assigned multipliers.

To view or change your current model:
1.	Open the **Copilot Chat** window.
2.	Use the **model picker** dropdown above the input field to select a model.

When your [premium request quota](https://docs.github.com/en/copilot/about-github-copilot/plans-for-github-copilot#comparing-copilot-plans) is exhausted, Copilot automatically falls back to a base model so you can continue working without interruption.

To manage model usage in non-chat interactions, configure the setting **Enhance non-chat requests with premium models** in **GitHub** > **Copilot** > **Editor**.

> [!TIP]
> Visit your [Copilot settings on GitHub](https://github.com/settings/copilot/features) to explore model options and subscription details.

## Related content

- [About premium requests](https://docs.github.com/copilot/managing-copilot/monitoring-usage-and-entitlements/about-premium-requests#premium-requests)
- [About billing](https://docs.github.com/en/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/billing-and-payments/about-billing-for-individual-copilot-plans)
- [GitHub support](https://support.github.com/)
- [Install and manage GitHub Copilot in Visual Studio](visual-studio-github-copilot-install-and-states.md)