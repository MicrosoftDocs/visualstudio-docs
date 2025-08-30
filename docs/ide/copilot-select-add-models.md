---
title: 'Using AI models in Copilot Chat'
description: Learn how to use built-in models or bring your own model (BYOM) in GitHub Copilot Chat for Visual Studio.
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
# Using AI models in Copilot Chat

With Visual Studio 17.14, Copilot in Visual Studio uses **GPT-4.1** as the default model (previously GPT-4o). GPT-4.1 provides faster response times, higher quality suggestions, and improved efficiency for coding tasks.

However, you are not limited to using this model. You can also select from additional models or add your own, allowing you to choose the model that best fits your workflow requirements.

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
- GPT-5 mini

**Model selection improvements**

- **Persistent selection**: The model you choose remains selected across chat threads.
- **Enable models directly**: If a model is available in your plan but not yet enabled, you’ll see a prompt in the model picker to activate it.

> Model availability depends on your Copilot subscription and the current status of each model. For Copilot Enterprise and Business, administrators must enable the **Preview** policy in Copilot settings before models are available in Visual Studio.

## Bring your own model (BYOM)

You can add your own language model to Copilot Chat by providing API keys from providers such as Anthropic, Google, or OpenAI. This allows you to select and configure custom AI models to match your workflow or to evaluate new model capabilities.

### Benefits

Using your own model enables you to:

- Expand model selection beyond built-in options, including new or experimental models.
- Meet infrastructure, security, or performance requirements with models that align to your needs.
- Control and monitor API usage directly with your chosen provider.
- Switch models easily between built-in and custom options.

### Get started

To add an API key:

1. In the bottom right of the chat view, select the **model picker** dropdown.
1. Select your provider (currently supported: **OpenAI**, **Anthropic**, and **Google**; additional providers may be added in future releases).
1. Enter your **API key**. 
1. Select:
    - Any standard model listed, or
    - Any supported model offered by your provider, even if it doesn't appear in the default list.
1. Once added, the custom model appears in the model picker.
1. Start prompting in chat. Chat uses the custom model.

### Limitations and considerations

- Custom model support is limited to the Chat experience in Visual Studio and does not affect code completions or other AI-assisted features, such as commit message generation.
- Model capabilities depend on the provider; some models may not support features such as tool use, vision inputs, or advanced reasoning.
- Services like embeddings, intent detection, and repository indexing may continue to use the Copilot API.
- When using a custom model, output is returned directly from the provider and may bypass Copilot’s responsible AI filtering.
- Custom model support is **not** available for Copilot Business or Enterprise users.

## Related content

- [Choosing the right AI model for your task](https://docs.github.com/en/copilot/using-github-copilot/ai-models/choosing-the-right-ai-model-for-your-task)
- [About premium requests](https://docs.github.com/copilot/managing-copilot/monitoring-usage-and-entitlements/about-premium-requests#premium-requests)
- [About Copilot billing](https://docs.github.com/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/billing-and-payments/about-billing-for-individual-copilot-plans)
- [GitHub support](https://support.github.com/)
- [Manage Copilot usage and models](copilot-usage-and-models.md)