---
title: Using AI models in Copilot Chat
description: Learn how to use built-in models or bring your own model (BYOM) in GitHub Copilot Chat for Visual Studio.
ms.date: 09/24/2026
ms.update-cycle: 180-days
ms.topic: get-started
author: RoseHJM
ms.author: rosemalcolm

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
- GPT-5 mini

Improvements to model selection include:

- **Persistent selection**: The model that you choose remains selected across chat threads.
- **Pinned models**: Pin frequently used models so they remain at the top of the **Model picker**. Expand the list to view all available models, or collapse it to show only your pinned models.

Model availability depends on your Copilot subscription and the current status of each model. For Copilot Enterprise and Business, administrators must enable the **Preview** policy in Copilot settings before models are available in Visual Studio.

:::moniker range="visualstudio"

### Manage models

Select **Manage models** in the **Model picker** to open the model management view. The view lists available Copilot and custom models. Use it to compare each model's cost, capabilities, and context-window size, and to enable or pin the models that you want to use. Custom models that you add by using your own API key also appear in this view.

### Configure thinking effort

Some supported models offer a **thinking effort** setting. Choose **Low**, **Medium**, or **High** from the model's thinking-effort control in the **Model picker** or in the model management view. Higher thinking effort can produce deeper reasoning for complex prompts, but uses more tokens and can increase AI Credit consumption. The control and available levels depend on the selected model.

:::moniker-end

## Bring your own model (BYOM)

You can add your own language model to Copilot Chat by providing API keys from providers such as Anthropic, Google, or OpenAI. This ability allows you to select and configure custom AI models to match your workflow or to evaluate new model capabilities.

### Benefits

Using your own model enables you to:

- Expand model selection beyond built-in options, including new or experimental models.
- Meet infrastructure, security, or performance requirements with models that align to your needs.
- Control and monitor API usage directly with your chosen provider.
- Switch models easily between built-in and custom options.

### Steps for adding an API key

1. In the chat view, open the **Model picker** dropdown list and select **Manage models**.

1. In the model management view, select **Add custom model**, and then select your provider. These providers are currently supported: **OpenAI**, **Anthropic**, and **Google**.

1. Enter your **API key** value.

1. Select one of these items:

    - Any standard model listed
    - Any supported model that your provider offers, even if it doesn't appear in the default list

1. Confirm that the custom model appears in the model management view, where you can review its metadata and pin it. The model then appears in the **Model picker**.

1. Start prompting in a chat. Copilot Chat uses the custom model.

### Limitations and considerations

- Support for custom models is limited to the Copilot Chat experience in Visual Studio. It doesn't affect code completions or other AI-assisted features, such as the generation of commit messages.
- Model capabilities depend on the provider. Some models might not support features such as tool use, vision inputs, or advanced reasoning.
- Services like embeddings, intent detection, and repository indexing might continue to use the Copilot API.
- When you use a custom model, output is returned directly from the provider and might bypass the filtering for responsible AI in Copilot.
- Support for custom models is *not* available for Copilot Business or Enterprise users.

## Related content

- [AI model comparison](https://docs.github.com/en/copilot/using-github-copilot/ai-models/choosing-the-right-ai-model-for-your-task)
- [Requests in GitHub Copilot](https://docs.github.com/copilot/managing-copilot/monitoring-usage-and-entitlements/about-premium-requests#premium-requests)
- [GitHub Copilot billing](https://docs.github.com/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/billing-and-payments/about-billing-for-individual-copilot-plans)
- [GitHub support](https://support.github.com/)
- [Manage Copilot usage and models](copilot-usage-and-models.md)
