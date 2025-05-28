---
title: Customize CodeLens in the Editor
description: This walkthrough shows you how to provide your own CodeLens in the Visual Studio editor by using extensions.
ms.date: 1/13/2025
ms.topic: conceptual
ms.author: tinali
monikerRange: ">=vs-2022"
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
---

# Extend the Visual Studio editor with a new CodeLens

You can create various CodeLens types. Each type offers its own unique set of functionalities. The following section details how to provide each of these CodeLens types.

## Text view CodeLens

A text view CodeLens provides text-based information to segments of code, and it's the simplest form of CodeLens. The following concepts illustrate how to create a text view CodeLens:

- The [`ICodeLensProvider`](/dotnet/api/microsoft.visualstudio.extensibility.editor.icodelensprovider) interface is the main interface to implement. Your implementation of this interface defines when your CodeLens activates, which segments of code that your CodeLens applies to, and how it displays.
- Within your implementation of [`ICodeLensProvider`](/dotnet/api/microsoft.visualstudio.extensibility.editor.icodelensprovider), you need to define when the CodeLens should be activated by implementing [`CodeLensProviderConfiguration`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelensproviderconfiguration).
- You also need to implement the [`TryCreateCodeLensAsync`](/dotnet/api/microsoft.visualstudio.extensibility.editor.icodelensprovider.trycreatecodelensasync) method. This method runs when your CodeLens is activated. In this method, you can define how and when you want your CodeLens to be displayed. This method returns an instance of [`CodeLens`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelens).
- You need to create your own subclass of [`CodeLens`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelens), where you get to define how you want your display text to appear through the [`GetLabelAsync`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelens.getlabelasync) method. This method returns an instance of [`CodeLensLabel`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelenslabel), which you can use to configure the text, a tooltip, and an optional icon.

## Invokable CodeLens

An invokable CodeLens allows extensions to perform some action (for example, running a unit test) when the user selects the CodeLens. Extensions can contribute an invokable CodeLens by implementing [`InvokableCodeLens`](/dotnet/api/microsoft.visualstudio.extensibility.editor.invokablecodelens), which derives from [`CodeLens`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelens).

## Visual CodeLens

A visual CodeLens allows extensions to provide custom UI, like a list of references to a method, to appear in a popup above the CodeLens when the user selects the CodeLens. Extensions can contribute a visual CodeLens by implementing [`VisualCodeLens`](/dotnet/api/microsoft.visualstudio.extensibility.editor.visualcodelens), which derives from [`CodeLens`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelens).

Similar to text view margins, because extensions in `VisualStudio.Extensibility` might be out of process from Visual Studio, a visual CodeLens provides a UI by creating a [`RemoteUserControl`](./../../inside-the-sdk/remote-ui.md) and the corresponding data template for that control. Some simple examples are shown in the following sections. We recommend that you read the [Remote UI documentation](./../../inside-the-sdk/remote-ui.md) when you create visual CodeLens UI content.

The following sample code demonstrates how to create a text view CodeLens and an invokable CodeLens:

```csharp
public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
{
    AppliesTo = new[]
    {
        DocumentFilter.FromDocumentType(DocumentType.KnownValues.Code),
    },
};

public CodeLensProviderConfiguration CodeLensProviderConfiguration =>
    new("CodeLens Sample Provider") {};

public Task<CodeLens?> TryCreateCodeLensAsync(CodeElement codeElement, CodeElementContext codeElementContext, CancellationToken token)
{
    if (codeElement.Kind == CodeElementKind.KnownValues.Method)
    {
        return Task.FromResult<CodeLens?>(new ClickableCodeLens(codeElement, this.Extensibility));
    }
    
    return Task.FromResult<CodeLens?>(new WordCountCodeLens(codeElement, codeElementContext, this.Extensibility, this));
}

...

public class ClickableCodeLens : InvokableCodeLens
{
    public override Task ExecuteAsync(CodeElementContext codeElementContext, IClientContext clientContext, CancellationToken cancelToken)
    {
        this.clickCount++;
        this.Invalidate();
        return Task.CompletedTask;
    }

    public override Task<CodeLensLabel> GetLabelAsync(CodeElementContext codeElementContext, CancellationToken token)
    {
        return Task.FromResult(new CodeLensLabel()
        {
            Text = this.clickCount == 0 ? "Click me" : $"Clicked {this.clickCount} times",
            Tooltip = "Invokable CodeLens Sample Tooltip",
        });
    }
}

public class WordCountCodeLens : VisualCodeLens
{   
    public override Task<IRemoteUserControl> GetVisualizationAsync(CodeElementContext codeElementContext, IClientContext clientContext, CancellationToken token)
    {
        return Task.FromResult<IRemoteUserControl>(new WordCountCodeLensVisual(this.wordCountData));
    }

    public override Task<CodeLensLabel> GetLabelAsync(CodeElementContext codeElementContext, CancellationToken token)
    {
        this.wordCountData.WordCount = CountWords(codeElementContext.Range);
        return Task.FromResult(new CodeLensLabel()
        {
            Text = $"Words: {this.wordCountData.WordCount}",
            Tooltip = "Number of words in this code element",
        });
    }
}
```

In addition to configuring CodeLens provider display names, CodeLens providers can also configure the priority of their CodeLens. The priority value is used to determine the relative ordering of your CodeLens respective to any other CodeLens. You can set the order through the [`Priority`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelensproviderconfiguration.priority) property in the [`CodeLensProviderConfiguration`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelensproviderconfiguration) object.

A CodeLens typically visualizes some data related to the text view. For example, it might want to display the number of references to a method. To do so, your CodeLens provider should also [listen to text view events](working-with-text.md) to react to the opening and closing of text views and user typing.

Visual Studio creates only one instance of your CodeLens provider regardless of how many applicable text views that a user opens. So, if your CodeLens needs to maintain state, you need to ensure that your CodeLens provider has a way to keep the state of currently open text views.

For more information, see [CodeLens sample](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/CodeLensSample/).

If a CodeLens provider has to reference code elements that an existing Visual Studio feature hasn't already tagged, you can create a new [tagger](./taggers.md) by implementing `ITextViewTaggerProvider<CodeLensTag>`.
