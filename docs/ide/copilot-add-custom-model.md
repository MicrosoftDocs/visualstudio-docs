---
title: 'Using model in Copilot Chat'
description: Learn how to select, configure, and use built-in or custom AI models in GitHub Copilot Chat for Visual Studio.
ms.date: 8/19/2025
ms.update-cycle: 180-days
ms.topic: get-started
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= vs-2022'
---
# Using models in Copilot Chat

With Visual Studio 17.14, Copilot in Visual Studio uses **GPT-4.1** as the default model (previously GPT-4o). GPT-4.1 provides faster response times, higher quality suggestions, and improved efficiency for coding tasks.

You can also select from additional models or add your own, allowing you to choose the model that best fits your workflow requirements.

## Available models
 
Choose from an expanded set of models in the model picker:
 
- Claude Sonnet 4
- Claude Opus 4
- GPT-5
- Claude Sonnet 3.5
- Claude 3.7 (thinking and non-thinking)
- OpenAI o3-mini
- Gemini 2.0 Flash
- Gemini 2.5 Pro

**Model selection improvements**

- **Persistent selection**: The model you choose remains selected across chat threads.
- **Enable models directly**: If a model is available in your plan but not yet enabled, you’ll see a prompt in the model picker to activate it.

> Model availability depends on your Copilot subscription and the current status of each model. For Copilot Enterprise and Business, administrators must enable the **Preview** policy in Copilot settings before models are available in Visual Studio.

## Add and configure custom models in chat

With the latest servicing release of 17.14, Visual Studio now supports adding your own language model to the chat experience. You can now use API keys from providers like Anthropic, Google, and OpenAI to integrate a wider range of models directly into Chat. This feature enables you to select and configure models based on your workflow requirements or to test new model capabilities as they become available.

### Benefits

Using your own model provides the following capabilities:

- **Model selection**: Use a wider range of models, including new or experimental options, beyond those built into Visual Studio.
- **Configuration**: Choose models that meet your infrastructure, security, or performance requirements.
- **API management**: Monitor and control API usage, rate limits, and quotas directly with your chosen provider.
- **Switching models**: Change between built-in and custom models as needed for different tasks or workflows.

### Get started

To add an API key from OpenAI, Anthropic, or Google:

1. Open the Chat view. 
1. Select **Manage Models** from the model picker.
1. Select your provider and enter the necessary credentials (such as API key or endpoint URL). 
1. Select from preset models or add your own using provider-specific options. 
1. Once added, your custom model will appear in the model picker for chat. 

> This feature is not available for Copilot Business or Copilot Enterprise users.

### Limitations and considerations

- Custom model support is limited to the Chat experience in Visual Studio and does not affect code completions or other AI-assisted features, such as commit message generation.
- Model capabilities depend on the provider; some third-party models may not support tool use, vision inputs, or advanced features.
- Services like embeddings, intent detection, and repository indexing may continue to use the Copilot API.
- When using a custom model, output is returned directly from the provider and may bypass Copilot’s responsible AI filtering.

## Related content

- [About premium requests](https://docs.github.com/copilot/managing-copilot/monitoring-usage-and-entitlements/about-premium-requests#premium-requests)
- [About Copilot billing](https://docs.github.com/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/billing-and-payments/about-billing-for-individual-copilot-plans)
- [GitHub support](https://support.github.com/)
- [Manage Copilot usage and models](copilot-usage-and-models.md)