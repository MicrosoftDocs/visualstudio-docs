---
title: 'Bring your own model to chat'
description: Learn how to add and configure custom language models in GitHub Copilot Chat in Visual Studio, by using API keys from other providers.
ms.update-cycle: 180-days
ms.topic: get-started
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= vs-2022'
---
# Add and configure custom models in chat

With the latest servicing release of 17.14, Visual Studio now supports adding your own language model to the chat experience. You can now use API keys from providers like Anthropic, Google, and OpenAI to integrate a wider range of models directly into Chat. This feature enables you to select and configure models based on your workflow requirements or to test new model capabilities as they become available.

## Benefits

Using your own model provides the following capabilities:

- **Model selection**: Use a wider range of models, including new or experimental options, beyond those built into Visual Studio.
- **Configuration**: Choose models that meet your infrastructure, security, or performance requirements.
- **API management**: Monitor and control API usage, rate limits, and quotas directly with your chosen provider.
- **Switching models**: Change between built-in and custom models as needed for different tasks or workflows.

## Get started

To add an API key from OpenAI, Anthropic, or Google:

1. Open the Chat view. 
1. Select **Manage Models** from the model picker.
1. Select your provider and enter the necessary credentials (such as API key or endpoint URL). 
1. Select from preset models or add your own using provider-specific options. 
1. Once added, your custom model will appear in the model picker for chat. 

> [!NOTE] This feature is not available for Copilot Business or Copilot Enterprise users.

## Limitations and considerations

- Custom model support is limited to the Chat experience in Visual Studio and does not affect code completions or other AI-assisted features, such as commit message generation.
- Model capabilities depend on the provider; some third-party models may not support tool use, vision inputs, or advanced features.
- Services like embeddings, intent detection, and repository indexing may continue to use the Copilot API.
- When using a custom model, output is returned directly from the provider and may bypass Copilot’s responsible AI filtering.

## Related content

- [About premium requests](https://docs.github.com/copilot/managing-copilot/monitoring-usage-and-entitlements/about-premium-requests#premium-requests)
- [About Copilot billing](https://docs.github.com/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/billing-and-payments/about-billing-for-individual-copilot-plans)
- [GitHub support](https://support.github.com/)
- [Manage Copilot usage and models](copilot-usage-and-models.md)