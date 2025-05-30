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
# Copilot usage and models in Visual Studio

GitHub Copilot now follows a [new billing model](https://docs.github.com/en/copilot/managing-copilot/monitoring-usage-and-entitlements/about-premium-requests). With this update that impacts usage and billing for [premium requests](https://docs.github.com/en/copilot/managing-copilot/monitoring-usage-and-entitlements/about-premium-requests#premium-requests), Visual Studio has introduced new features to help you better manage your Copilot usage and the models you work with.

## What's changed?

If you’re a **paid Copilot user**, your plan now includes a **[monthly allowance of premium requests](https://docs.github.com/en/copilot/about-github-copilot/plans-for-github-copilot#comparing-copilot-plans)**. These requests are used whenever you interact with Copilot using premium models, like Claude Sonnet 3.7. Once you reach your quota, Copilot in Visual Studio automatically switches to a base model, ensuring uninterrupted workflow.

For users on **Copilot Free**, your account comes with up to 2,000 code completions and up to 50 chats or premium requests per month.

## What’s new in Visual Studio?

New tools and smarter defaults make it easier to track usage and get the most out of Copilot.

### Smarter default models

Visual Studio now defaults to **GPT-4.1**, a fast and balanced model. If you exhaust your premium quota, it automatically switches to the **fallback model**, ensuring uninterrupted access to powerful features at no extra cost.

> 💡 Once you select a model, it stays active for your current chat session—no need to reselect it between threads.

### Smarter usage insights

To track your Copilot usage:

1. Select the **Copilot badge** in the top-right corner of Visual Studio.
2. Select **Copilot Consumptions**.

:::image type="content" source="media/vs-2022/copilot-usage-models/copilot-consumptions-panel.png" alt-text="Screenshot that shows Copilot Consumptions panel." lightbox="media/vs-2022/copilot-usage-models/copilot-consumptions-panel.png":::

Here, you can view your usage across chat, auto (agent) mode, and other features. You can also select **Get more requests** to update your subscription or adjust Overage settings directly on *GitHub.com*.

### Smarter fallback behavior

- **Overages ON**: You can keep using premium models beyond your monthly quota, with any extra usage billed to your account.
- **Overages OFF**: Copilot automatically switches to the fallback model once you reach your quota, preventing unexpected charges.

To control model usage in non-chat interactions, configure the setting **Enhance non-chat requests with premium models** in **GitHub** > **Copilot** > **Editor**.

### Easier model management

Use the updated **model picker** experience.

> If a model is supported by your plan but not yet enabled, Visual Studio prompts you to activate it—no need to leave the IDE.

### Models available

- Gemini 2.5 Pro
- Gemini 2.0 Flash
- Claude Sonnet 3.7
- Claude Sonnet 3.5
- GPT-4.1
- GPT-4.5
- OpenAI o3 Mini
- GPT-4o

> ℹ️ Each model has a premium request multiplier, for example, GPT-4.5 counts as 50 premium requests per use. You’ll see the exact multiplier in the **model picker** before selecting.

:::image type="content" source="media/vs-2022/copilot-usage-models/model-picker.png" alt-text="Screenshot that shows Pick Model dropdown." lightbox="media/vs-2022/copilot-usage-models/model-picker.png":::

## Frequently asked questions

#### Do Completions count as premium requests?

**Code completions** do *not* count against your premium request balance for paid users.

#### What are premium requests?

Some Copilot features use more advanced processing power and count as premium requests. See [premium requests and premium features](https://docs.github.com/en/copilot/managing-copilot/monitoring-usage-and-entitlements/about-premium-requests#premium-requests) to learn more.

#### Who can purchase additional premium requests?

To learn more, see [Additional premium requests](https://docs.github.com/en/copilot/managing-copilot/monitoring-usage-and-entitlements/about-premium-requests#additional-premium-requests).

#### How is premium request usage assessed?

Premium request usage is based on the [model’s multiplier](https://docs.github.com/en/copilot/managing-copilot/monitoring-usage-and-entitlements/about-premium-requests#model-multipliers) and the feature you’re using. To learn more, see [Example of premium request usage](https://docs.github.com/en/copilot/managing-copilot/monitoring-usage-and-entitlements/about-premium-requests#example-of-premium-request-usage.)

## Related content

- [Install and manage GitHub Copilot in Visual Studio](visual-studio-github-copilot-install-and-states.md)
- [About GitHub Copilot Free](https://aka.ms/ghdocscopilotfreepage)