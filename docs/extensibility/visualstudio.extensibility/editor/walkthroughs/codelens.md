---
title: Customizing CodeLens in the editor
description: A walkthrough of how to provide your own CodeLens in the Visual Studio editor using extensions
ms.date: 1/13/2025
ms.topic: conceptual
ms.author: tinali
monikerRange: ">=vs-2022"
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
---

# Extending Visual Studio editor with a new CodeLens
There are different types of CodeLenses that could be created. Each type offers its own unique set of functionalities. The following section details how to provide each of these types of CodeLenses.

## Text view CodeLens
Text view CodeLens provide text-based information to segments of code and are the simplest forms of CodeLens. The following concepts illustrate how to create a text view CodeLens:
- [`ICodeLensProvider`](/dotnet/api/microsoft.visualstudio.extensibility.editor.icodelensprovider) interface is the main interface to implement. Your implementation of this interface defines when your CodeLens will activate, and which segments of code your CodeLens applies to, and how it will display.
- Within your implementation of [`ICodeLensProvider`](/dotnet/api/microsoft.visualstudio.extensibility.editor.icodelensprovider), you need to define when the CodeLens should be activated by implementing [`CodeLensProviderConfiguration`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelensproviderconfiguration).
- You also need to implement the [`TryCreateCodeLensAsync`](/dotnet/api/microsoft.visualstudio.extensibility.editor.icodelensprovider.trycreatecodelensasync) method. This method will execute when your CodeLens is activated. In this method, you can define how you want your CodeLens to be displayed and when it should be displayed. This method returns an instance of [`CodeLens`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelens).
- You need to create your own sub-class of [`CodeLens`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelens), where you get to define how you want your display text to appear through the [`GetLabelAsync`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelens.getlabelasync) method. This method returns an instance of [`CodeLensLabel`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelenslabel), which you can use to configure the text, tooltip, and an optional icon.

## Invokable CodeLens
Invokable CodeLens allows extensions to perform some action (for example, run a unit test) when user clicks on the CodeLens. Extensions can contribute invokable CodeLens by implementing [`InvokableCodeLens`](/dotnet/api/microsoft.visualstudio.extensibility.editor.invokablecodelens), which derives from [`CodeLens`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelens).

## Visual CodeLens
Visual CodeLens allows extensions to provide custom UI, like a list of references to a method, to be displayed in a popup above the CodeLens when user clicks on the CodeLens. Extensions can contribute visual CodeLens by implementing [`VisualCodeLens`](/dotnet/api/microsoft.visualstudio.extensibility.editor.visualcodelens), which derives from [`CodeLens`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelens). Similar to text view margins, because extensions in VisualStudio.Extensibility might be out-of-process from the Visual Studio, visual CodeLenses provide UI by creating a [`RemoteUserControl`](./../../inside-the-sdk/remote-ui.md) and the corresponding data template for that control. While there are some simple examples in the following sections, we recommend reading the [Remote UI documentation](./../../inside-the-sdk/remote-ui.md) when creating visual CodeLens' UI content.

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

In addition to configuring CodeLens provider display name, CodeLens providers can also configure priority of their CodeLens. The priority value is used to determine the relative ordering of your CodeLens respective to other CodeLenses, which can be set through the [`Priority`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelensproviderconfiguration.priority) property in the [`CodeLensProviderConfiguration`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelensproviderconfiguration) object.

CodeLenses typically visualize some data related to the text view. For example, they might want to display the number of references to a method. To do so, your CodeLens provider should also [listen to text view events](working-with-text.md) to react to opening, closing of text views and user typing.

Visual Studio only creates one instance of your CodeLens provider regardless of how many applicable text views a user opens. This means that if your CodeLens needs to maintain state, you need to ensure your CodeLens provider has a way to keep the state of currently open text views.

For more information, see [CodeLens Sample](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/CodeLensSample/).

If a Code Lens provider has to reference code elements that are not already being tagged by an existing Visual Studio feature, you can create a new [tagger](./taggers.md) implementing `ITextViewTaggerProvider<CodeLensTag>`.
