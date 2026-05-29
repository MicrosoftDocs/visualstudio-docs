---
title: 'GitHub Copilot usage and models'
description: Learn how to manage your GitHub Copilot usage and models directly within Visual Studio.
ms.date: 05/20/2026
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

GitHub Copilot includes built-in tools to help you track usage, manage your plan, and understand how model selection affects your monthly usage.

## View Copilot usage

To view Copilot usage:

:::moniker range="visualstudio"
1. Select the down arrow next to the Copilot badge in the top-right corner.
1. Select **Copilot Usage** from the menu to view the dialog.

The usage window looks different depending on your plan category.

### Individual plans

Individual plans show personal monthly usage details and continuation options.
:::image type="content" source="media/copilot-pro-usage-monthly-limit.png" alt-text="Screenshot showing usage details for an individual Copilot plan, including monthly usage and continuation options." lightbox="media/copilot-pro-usage-monthly-limit.png":::

### Business and Enterprise plans

Business and Enterprise plans show organization-managed usage details. In some organizations, no individual monthly limit is set and usage draws from a shared pool.
:::image type="content" source="media/copilot-enterprise-usage-no-monthly-limit.png" alt-text="Screenshot showing organization-managed Copilot usage where no individual monthly limit is set." lightbox="media/copilot-enterprise-usage-no-monthly-limit.png":::

For plan behavior details, see [About usage limits](https://docs.github.com/copilot/concepts/usage-limits).

The usage window shows monthly usage, remaining monthly balance, plan details, and relevant actions you can take to manage billing. Depending on your plan, it might also show information on additional usage.
:::moniker-end

:::moniker range="vs-2022"
1. Select the Copilot badge in the top-right corner of Visual Studio, and then select **Copilot Usage**.

   In older versions, this experience might appear as **Copilot Consumptions**.

   :::image type="content" source="media/vs-2022/copilot-usage-models/copilot-consumptions-panel.png" alt-text="Screenshot that shows Copilot Consumptions panel." lightbox="media/vs-2022/copilot-usage-models/copilot-consumptions-panel.png":::

   Here, you might view usage details and monthly quota information for your plan.
:::moniker-end

> [!NOTE]
> Labels and fields in the usage window vary by GitHub Copilot plan type and Visual Studio version. GitHub manages billing and subscriptions. For details, visit your [GitHub settings](https://github.com/settings/billing/summary).

## Monitor usage and manage alerts

Check your usage and set alerts to stay within monthly limits and avoid interruptions.

### Set a personal usage warning threshold

Visual Studio warns you when usage reaches 75% of your monthly quota by default. You might change this threshold to match your usage needs.

To set a personal usage warning threshold:

1. Open **Tools** > **Options** > **GitHub** > **Copilot** > **Copilot Chat**.
1. Find the **Quota warning threshold percentage** setting.
1. Enter the percentage of your monthly quota at which you want to be warned.
1. Select **OK** to save your changes.

Once configured, Copilot Chat displays a warning banner when your usage reaches the threshold percentage you set.

This warning is a notification only. It doesn't stop usage or enforce a spending cap.

:::image type="content" source="media/copilot-quota-warning-threshold-setting.png" alt-text="Screenshot of the Visual Studio Options dialog showing the GitHub Copilot Chat settings with Quota warning threshold percentage field set to 75 percent." lightbox="media/copilot-quota-warning-threshold-setting.png":::

> [!NOTE]
> This setting applies locally to your Visual Studio installation. Your GitHub Copilot plan tier determines your actual monthly quota and any overage policies.

### Understand quota limits and alerts

When your monthly quota is near or at limit, Copilot shows alerts and overage indicators based on your plan.

Copilot credits are consumed based on token usage (input, output, and cached tokens), according to the published rates for each model. In general, larger prompts and longer responses use more credits. For details, see [Models and pricing](https://docs.github.com/copilot/reference/copilot-billing/models-and-pricing).

### Usage limit reached

When you reach the usage limits, your Copilot experience in Visual Studio might be affected as follows:

:::row::: 
    :::column span="1"::: 
       **Usage limit for Completions is reached**
    :::column-end::: 
    :::column span="2"::: 
       User receives IntelliCode suggestions instead of Copilot completions. The Copilot badge might still show an active state while completions are limited.
    :::column-end::: 
:::row-end:::
:::row::: 
    :::column span="1"::: 
       **Usage limit for Chat is reached**
    :::column-end::: 
    :::column span="2"::: 
         User no longer receives chat responses when sending prompts. A notification in chat alerts the user that they have reached their monthly limit.
    :::column-end::: 
:::row-end:::

#### Individual plans
Copilot might show warning and limit-reached banners with options to manage overages or plan continuation.
:::image type="content" source="media/copilot-monthly-limit-warning.png" alt-text="Screenshot showing a warning banner that the user has used 75 percent of the monthly limit and can upgrade the plan." lightbox="media/copilot-monthly-limit-warning.png":::

#### Business and Enterprise plans
Usage is organization-managed. In some organizations, no individual monthly limit is set and usage draws from a shared pool. If you need higher limits or policy changes, contact your organization administrator.

When monthly usage limits are configured, Copilot might display an alert banner with options to manage your usage:
:::image type="content" source="media/copilot-enterprise-monthly-limit-reached-chat.png" alt-text="Screenshot showing an alert banner in Copilot Chat that the monthly limit is reached with an Upgrade plan option." lightbox="media/copilot-enterprise-monthly-limit-reached-chat.png":::

For plan behavior details, see [About usage limits](https://docs.github.com/copilot/concepts/usage-limits).

> [!TIP]
> Visit your [Copilot settings on GitHub](https://github.com/settings/copilot/features) to explore model options and subscription details.

## Understand model selection

Copilot supports multiple AI models with different capabilities and quota consumption rates. Choose the model that matches your task.

For most prompts, use **Auto**. Auto routes you to a model based on  model reliability and availability, and is available at a discounted rate. For complex tasks, consider switching to a different model.

Your model choice affects three things:

- **Cost:** Higher-capability models usually consume more credits per request.
- **Response quality:** Higher-capability models often return more detailed and structured responses.
- **Performance:** Lower-cost models are often faster for simple tasks, while higher-capability models might take longer for complex reasoning.

To view or change your current model:

1. Open the **Copilot Chat** window.
1. Use the **Model picker** dropdown to select a model.

The model picker shows model cost indicators for each model. Available model options might vary by plan.

To manage model usage for non-chat scenarios, turn off **Enhance non-chat requests with premium models** in **GitHub** > **Copilot** > **Editor**.

For more information, see [Change the chat model](https://docs.github.com/copilot/how-tos/use-ai-models/change-the-chat-model?tool=visualstudio), [Supported AI models](https://docs.github.com/copilot/reference/ai-models/supported-models), and [Auto model selection](https://docs.github.com/copilot/concepts/auto-model-selection).

## Tips to optimize usage

- Use **Auto** in the model picker for most prompts, then switch models for complex requests.
- To reduce token usage for non-chat scenarios, turn off **Enhance non-chat requests with premium models** in **GitHub** > **Copilot** > **Editor**. For more context, see [Understand model selection](#understand-model-selection).
- If you use multiple GitHub accounts in Visual Studio, verify the active account is the account with your expected Copilot plan.
- Use **Manage plan** from the usage window to verify your current plan tier and overage policy.

## Related content

- [About usage limits](https://docs.github.com/copilot/concepts/usage-limits)
- [About Copilot billing](https://docs.github.com/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/billing-and-payments/about-billing-for-individual-copilot-plans)
- [Models and pricing](https://docs.github.com/copilot/reference/copilot-billing/models-and-pricing)
- [GitHub support](https://support.github.com/)
- [Install and manage GitHub Copilot in Visual Studio](visual-studio-github-copilot-install-and-states.md)