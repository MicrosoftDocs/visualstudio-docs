---
title: 'GitHub Copilot usage and models'
description: Learn how to manage your GitHub Copilot usage and models directly within Visual Studio.
ms.date: 04/17/2026
ms.update-cycle: 180-days
ms.topic: overview 
author: RoseHJM
ms.author: rosemalcolm
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= vs-2022'
ms.custom: awp-ai
---
# Manage Copilot usage and models

> [!NOTE]
> This article applies to Visual Studio 2022 version 17.14 and later, and Visual Studio 2026.

GitHub Copilot includes built-in tools to help you track usage, manage your plan, and understand how model selection affects [request consumption](https://docs.github.com/copilot/managing-copilot/monitoring-usage-and-entitlements/about-premium-requests).

## View Copilot usage

To track your Copilot usage:

:::moniker range="visualstudio"
1. Select the down arrow next to the Copilot button in the top-right corner of Visual Studio.
1. Select **Copilot Usage** from the menu to view the dialog.

   :::image type="content" source="media/visualstudio/copilot-consumptions-panel.png" alt-text="Screenshot that shows Copilot Consumptions panel." lightbox="media/visualstudio/copilot-consumptions-panel.png":::

   Here, you can view your usage and the number of remaining requests. You can also select **Manage plan** to manage your Copilot plan on *GitHub*.
:::moniker-end

:::moniker range="vs-2022"
1. Select the **Copilot badge** in the top-right corner of Visual Studio.
1. Select **Copilot Consumptions** from the menu to view the dialog.

   :::image type="content" source="media/vs-2022/copilot-usage-models/copilot-consumptions-panel.png" alt-text="Screenshot that shows Copilot Consumptions panel." lightbox="media/vs-2022/copilot-usage-models/copilot-consumptions-panel.png":::

   Here, you can view your usage and the number of remaining requests. You can also select **Get more requests** to manage your Copilot plan on *GitHub*.
:::moniker-end

> [!NOTE]
> GitHub manages billing and subscriptions. For details, visit your [GitHub settings](https://github.com/settings/billing/summary).



## Understand model selection

> [!NOTE]  
> Some individual plans have tighter chat and premium model limits, and high-volume users may reach caps sooner.  
> If you hit a limit, wait for reset, switch models, or use **Auto** mode. Spreading requests out over time may help avoid interruptions. See [About usage limits](https://docs.github.com/en/copilot/concepts/usage-limits).

Copilot supports multiple AI models, and each model may consume requests at different rates based on assigned [multipliers](https://docs.github.com/copilot/managing-copilot/monitoring-usage-and-entitlements/about-premium-requests#model-multipliers).

To view or change your current model:

1. Open the **Copilot Chat** window.
1. Use the **model picker** dropdown above the input field to select a model.

When your [premium request quota](https://docs.github.com/copilot/about-github-copilot/plans-for-github-copilot#comparing-copilot-plans) is exhausted, Copilot automatically falls back to a base model so you can continue working without interruption.

To manage model usage in non-chat interactions, configure the setting **Enhance non-chat requests with premium models** in **GitHub** > **Copilot** > **Editor**.

> [!TIP]
> Visit your [Copilot settings on GitHub](https://github.com/settings/copilot/features) to explore model options and subscription details.

## Related content

- [About premium requests](https://docs.github.com/copilot/managing-copilot/monitoring-usage-and-entitlements/about-premium-requests#premium-requests)
- [About Copilot billing](https://docs.github.com/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/billing-and-payments/about-billing-for-individual-copilot-plans)
- [GitHub support](https://support.github.com/)
- [Install and manage GitHub Copilot in Visual Studio](visual-studio-github-copilot-install-and-states.md)