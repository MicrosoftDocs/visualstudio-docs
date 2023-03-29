---
title: User Prompts reference
description: A reference for extensibility user prompts
date: 2022-07-29
---

# User prompts overview

User prompts are a simple UI mechanism for prompting the user during the execution of a [Command](../command/command.md). Prompting the user creates a dialog box with a message, one to three buttons for the choices, and a dismiss button.

**Note:** The exact UI used to prompt users may change in future versions based on user feedback or other factors.

Common examples are requesting confirmation with an OK/Cancel prompt, or asking the user to choose among a small set of options (no more than three).

The user always has the option of dismissing the prompt without making a selection.

The choices presented to the user are mapped to return values of the type defined in the `TResult` type parameter.

## Parts of a user prompt

![User Prompt Parts](user_prompt_parts.png)

1. Message
2. Choice Buttons
3. Dismiss Button

## Get started

User Prompts can only be created inside of a [Command](../command/command.md). To get started, [Create the extension project](../../getting-started/create-your-first-extension.md#create-the-extension-project) and [Add your first command](../../getting-started/create-your-first-extension.md#add-your-first-command).

## Work with user prompts

This guide covers the following scenarios for working with User Prompts:

- [Display a user prompt](#display-a-user-prompt)
- [Use built-in options](#use-built-in-options)
- [Create a prompt with custom options](#create-a-prompt-with-custom-options)

## Display a user prompt

As discussed above, User Prompts can be shown inside of Commands, where you have access to an `IClientContext` instance. To show a user prompt, call the `IClientContext.ShowPromptAsync<TResult>()` method inside the `ExecuteCommandAsync()` method for the Command. 

### `IClientContext.ShowPromptAsync<TResult>()`

The `ShowPromptAsync()` method takes three parameters:

| Parameter | Type | Required | Description |
| ----------|------|----------|-------------|
| message   | `string` | yes | The text of the message for the prompt. |
| options   | `PromptOptions<TResult>` | yes | Defines the user choices, mapping them to return values. |
| cancellationToken | [`CancellationToken`](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken) | Yes | The [`CancellationToken`](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken) for the async operation. When triggered, the prompt is force closed. |

### Example

The following code inside a Command will show a User Prompt with a simple message and an OK button.

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
    await context.ShowPromptAsync("This is a user prompt.", PromptOptions.OK, cancellationToken))
}
```

## Use built-in options

Several sets of pre-defined `PromptOptions` are available in the SDK.

### OK

| Choice | Default | Return Value |
|--------|---------|--------------|
| "OK"   | Yes | true |
| _Dismissed_ | | false |

### OKCancel

| Choice | Default | Return Value |
|--------|---------|--------------|
| "OK"   | Yes | true |
| "Cancel" | No | false |
| _Dismissed_ | | false |

### RetryCancel

| Choice | Default | Return Value |
|--------|---------|--------------|
| "Retry" | Yes | true |
| "Cancel" | No | false |
| _Dismissed_ | | false |

### Example

![User Prompt With OK](user_prompt_ok.png)

Create a prompt with a single "OK" choice.

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken ct)
{
    // Asking the user to confirm an operation.
    if (!await context.ShowPromptAsync("Continue with executing the command?", PromptOptions.OKCancel, ct))
    {
      return;
    }
    
    ...
}
```

If the user clicks "OK", `ShowPromptAsync` will return `true` when awaited. If the user clicks the dismiss button, it will return `false`.

#### Change the default choice of a built-in option to "Cancel"

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken ct)
{
  // Asking the user to confirm an operation.
  if (!await context.ShowPromptAsync("Continue with executing the command?", PromptOptions.OKCancel.WithCancelAsDefault(), ct))
  {
    return;
  }
  
  ...
}
```

## Create a prompt with custom options

![Custom User Prompt](user_prompt_custom.png)

In addition to the built-in options, you can customize the choices presented to the user and the return value mapped to each.

Instead of using the sets defined in `PromptOptions`, create a new instance of `PromptOptions<TResult>` and pass it to `ShowPromptAsync`.

### Example

Start by creating a value type to define the return values:

```csharp
public enum TokenThemeResult
{
  None,
  Solarized,
  OneDark,
  GruvBox,
}
```

Then create the `PromptOptions<TResult>` instance and pass it to `ShowPromptAsync` along with the required `message` and `cancellationToken` arguments:

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken ct)
{
  // Custom prompt
  var themeResult = await context.ShowPromptAsync(
    "Which theme should be used for the generated output?",
    new PromptOptions<TokenThemeResult>
    {
      Choices =
      {
        { "Solarized Is Awesome", TokenThemeResult.Solarized },
        { "OneDark Is The Best", TokenThemeResult.OneDark },
        { "GruvBox Is Groovy", TokenThemeResult.GruvBox },
      },
      DismissedReturns = TokenThemeResult.None,
      DefaultChoiceIndex = 2,
    },
    ct);

  Debug.WriteLine($"Selected Token Theme: {themeResult}");
}
```

The `Choices` collection maps the user choices to values in the `TokenThemeResult` enum. `DismissedReturns` sets the value that is returned if the user clicks the dismiss button. `DefaultChoiceIndex` is a zero-based index into the `Choices` collection that defines the default choice.

## Next steps

The following samples demonstrate how to work with user prompts:

- [UserPromptSample](../../../../New_Extensibility_Model/Samples/UserPromptSample/)
- [MarkdownLinter](../../../../New_Extensibility_Model/Samples/MarkdownLinter/)
