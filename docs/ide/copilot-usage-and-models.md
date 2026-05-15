  ---
title: 'GitHub Copilot usage and models'
description: Learn how to manage your GitHub Copilot usage and models directly within Visual Studio.
ms.date: 05/15/2026
ms.update-cycle: 180-days
ms.topic: overview 
author: RoseHJM
ms.author: rosemalcolm

ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= vs-2022'
ms.custom: awp-ai
---
# Manage Copilot usage and models

> [!NOTE]
> This article applies to Visual Studio 2022 version 17.14 and later, and Visual Studio 2026.

[!INCLUDE [copilot-billing-notice](../includes/copilot-billing-notice.md)]

GitHub Copilot includes built-in tools to help you track usage, manage your plan, and understand how model selection affects your monthly token quota.

## View Copilot usage

To track your Copilot usage:

:::moniker range="visualstudio"
1. Select the Copilot status indicator in the Visual Studio status bar, or select the down arrow next to the Copilot button in the top-right corner.
1. Select **Copilot Usage** from the menu to view the dialog.

   The usage window can look different depending on your plan.

   :::image type="content" source="media/visualstudio/copilot-ubb/copilot-pro-usage-configure-overages.png" alt-text="Screenshot showing Copilot Pro usage with a monthly limit bar and Configure overages button." lightbox="media/visualstudio/copilot-ubb/copilot-pro-usage-configure-overages.png":::

   :::image type="content" source="media/visualstudio/copilot-ubb/copilot-enterprise-usage-monthly-limit.png" alt-text="Screenshot showing Copilot Enterprise usage with monthly limit information and a Request usage button." lightbox="media/visualstudio/copilot-ubb/copilot-enterprise-usage-monthly-limit.png":::

   The usage window shows quota usage, remaining monthly balance, and plan details. Depending on your plan, it can also show overage indicators and links to manage billing on *GitHub*.
:::moniker-end

:::moniker range="vs-2022"
1. Select the **Copilot badge** in the top-right corner of Visual Studio.
1. Select **Copilot Usage** from the menu to view the dialog.

   :::image type="content" source="media/vs-2022/copilot-usage-models/copilot-consumptions-panel.png" alt-text="Screenshot that shows Copilot Consumptions panel." lightbox="media/vs-2022/copilot-usage-models/copilot-consumptions-panel.png":::

   Here, you can view usage details and monthly quota information for your plan.
:::moniker-end

> [!NOTE]
> Exact labels and fields in the usage window vary by plan tier (for example, Free, Pro, Business, or Enterprise) and by Visual Studio version.

> [!NOTE]
> GitHub manages billing and subscriptions. For details, visit your [GitHub settings](https://github.com/settings/billing/summary).

## Use the Copilot status indicator

:::moniker range="visualstudio"
The Copilot status indicator in the Visual Studio status bar gives you at-a-glance state and quick access to actions such as **Copilot Usage**, **Open Chat Window**, and troubleshooting links.

Use this menu to quickly check quota status before starting prompt-heavy tasks.
:::moniker-end

:::moniker range="vs-2022"
Use the Copilot badge in the top-right corner to open the same menu options.
:::moniker-end

## Understand model selection

> [!NOTE]
> With UBB, Copilot uses a token-based billing and quota model. Model multipliers are not shown in the model picker.

Copilot supports multiple AI models. In UBB-enabled experiences, the model picker no longer shows multipliers (for example, "1x").

To view or change your current model:

1. Open the **Copilot Chat** window.
1. Use the **model picker** dropdown above the input field to select a model.

In UBB-enabled experiences, the model picker can show model cost indicators, but it doesn't show multiplier labels (for example, "1x").

:::image type="content" source="media/visualstudio/copilot-ubb/model-picker-cost-scale.png" alt-text="Screenshot showing the model picker with a Cost column using dot-based cost indicators instead of multipliers." lightbox="media/visualstudio/copilot-ubb/model-picker-cost-scale.png":::

:::image type="content" source="media/visualstudio/copilot-ubb/model-picker.png" alt-text="Screenshot showing the model picker list where models are presented without multiplier labels." lightbox="media/visualstudio/copilot-ubb/model-picker.png":::

When your monthly quota is near or at limit, Copilot can show alerts and overage indicators based on your plan.

To manage model usage in non-chat interactions, configure the setting **Enhance non-chat requests with premium models** in **GitHub** > **Copilot** > **Editor**.

> [!TIP]
> Visit your [Copilot settings on GitHub](https://github.com/settings/copilot/features) to explore model options and subscription details.

## Tips to optimize usage

- Use **Auto** in the model picker for most prompts, then switch models for complex requests.
- Turn off **Enhance non-chat requests with premium models** in **GitHub** > **Copilot** > **Editor** if you want to reduce token usage for non-chat scenarios.
- If you're near your monthly quota, temporarily disable **Enable Copilot Completions** from the Copilot menu **Settings**.
- If you use multiple GitHub accounts in Visual Studio, verify the active account is the account with your expected Copilot plan.
- Use **Manage plan** from the usage window to verify your current plan tier and overage policy.

## Related content

- [About usage limits](https://docs.github.com/en/copilot/concepts/usage-limits)
- [About Copilot billing](https://docs.github.com/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/billing-and-payments/about-billing-for-individual-copilot-plans)
- [GitHub support](https://support.github.com/)
- [Install and manage GitHub Copilot in Visual Studio](visual-studio-github-copilot-install-and-states.md)