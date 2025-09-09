---
title: Using AI models in Copilot Chat
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
# Get started with AI models in Copilot Chat

With Visual Studio 17.14, GitHub Copilot in Visual Studio uses GPT-4.1 as the default model (previously GPT-4o). GPT-4.1 provides faster response times, higher-quality suggestions, and improved efficiency for coding tasks.

However, you're not limited to using this model. You can also select a different model or add your own. You choose the model that best fits your workflow requirements.

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

Model selection improvements:

- **Persistent selection**: The model that you choose remains selected across chat threads.
- **Enable models directly**: If a model is available in your plan but not yet enabled, you see a prompt in the model picker to activate it.

Model availability depends on your Copilot subscription and the current status of each model. For Copilot Enterprise and Business, administrators must enable the **Preview** policy in Copilot settings before models are available in Visual Studio.

## BYOM

You can add your own language model to Copilot Chat by providing API keys from providers such as Anthropic, Google, or OpenAI. This concept is called bring your own model (BYOM). It allows you to select and configure custom AI models to match your workflow or to evaluate new model capabilities.

### Benefits

Using your own model enables you to:

- Expand model selection beyond built-in options, including new or experimental models.
- Meet infrastructure, security, or performance requirements with models that align to your needs.
- Control and monitor API usage directly with your chosen provider.
- Switch models easily between built-in and custom options.

### Steps for adding an API key

1. In the chat view, go to the **Model picker** dropdown list.
1. Select your provider. These providers are currently supported: **OpenAI**, **Anthropic**, and **Google**.
1. Enter your **API key**.
1. Select one of these items:
    - Any standard model listed
    - Any supported model offered by your provider, even if it doesn't appear in the default list
1. Confirm that the custom model appears in the model picker.
1. Start prompting in chat. Chat uses the custom model.

### Limitations and considerations

- Custom model support is limited to the Chat experience in Visual Studio and does not affect code completions or other AI-assisted features, such as commit message generation.
- Model capabilities depend on the provider. Some models might not support features such as tool use, vision inputs, or advanced reasoning.
- Services like embeddings, intent detection, and repository indexing might continue to use the Copilot API.
- When you use a custom model, output is returned directly from the provider and might bypass the filtering for responsible AI in Copilot.
- Custom model support is *not* available for Copilot Business or Enterprise users.

## Related content

- [Choosing the right AI model for your task](https://docs.github.com/en/copilot/using-github-copilot/ai-models/choosing-the-right-ai-model-for-your-task)
- [About premium requests](https://docs.github.com/copilot/managing-copilot/monitoring-usage-and-entitlements/about-premium-requests#premium-requests)
- [About Copilot billing](https://docs.github.com/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/billing-and-payments/about-billing-for-individual-copilot-plans)
- [GitHub support](https://support.github.com/)
- [Manage Copilot usage and models](copilot-usage-and-models.md)
