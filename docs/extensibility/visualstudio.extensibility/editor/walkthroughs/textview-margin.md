---
title: Customizing the textview margin
description: A walkthrough of how to textview margin in the Visual Studio editor using extensions
ms.date: 1/13/2025
ms.topic: conceptual
ms.author: tinali
monikerRange: ">=vs-2022"
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
---

# Extending Visual Studio editor with a new margin
Text view margins are placed into a margin container (see [ContainerMarginPlacement.KnownValues](/dotnet/api/microsoft.visualstudio.extensibility.editor.containermarginplacement.knownvalues)) and ordered before or after relatively to other margins (see [MarginPlacement.KnownValues](/dotnet/api/microsoft.visualstudio.extensibility.editor.marginplacement.knownvalues)).

Text view margin providers implement [ITextViewMarginProvider](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewmarginprovider) interface, configure the margin they provide by implementing [TextViewMarginProviderConfiguration](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewmarginprovider.textviewmarginproviderconfiguration) and when activated, provide UI control to be hosted in the margin via [CreateVisualElementAsync](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewmarginprovider.createvisualelementasync).

Because extensions in VisualStudio.Extensibility might be out-of-process from the Visual Studio, we can't directly use WPF as a presentation layer for content of text view margins. Instead, providing a content to a text view margin requires creating a [RemoteUserControl](./../../inside-the-sdk/remote-ui.md#create-the-remote-user-control) and the corresponding data template for that control. While there are some simple examples below, we recommend reading the [Remote UI documentation](./../../inside-the-sdk/remote-ui.md) when creating text view margin UI content.

```csharp
/// <summary>
/// Configures the margin to be placed to the left of built-in Visual Studio line number margin.
/// </summary>
public TextViewMarginProviderConfiguration TextViewMarginProviderConfiguration => new(marginContainer: ContainerMarginPlacement.KnownValues.BottomRightCorner)
{
    Before = new[] { MarginPlacement.KnownValues.RowMargin },
};

/// <summary>
/// Creates a remotable visual element representing the content of the margin.
/// </summary>
public async Task<IRemoteUserControl> CreateVisualElementAsync(ITextViewSnapshot textView, CancellationToken cancellationToken)
{
    var documentSnapshot = await textView.GetTextDocumentAsync(cancellationToken);
    var dataModel = new WordCountData();
    dataModel.WordCount = CountWords(documentSnapshot);
    this.dataModels[textView.Uri] = dataModel;
    return new MyMarginContent(dataModel);
}
```

In addition to configuring margin placement, text view margin providers can also configure the size of the grid cell in which the margin should be placed using [GridCellLength](/dotnet/api/microsoft.visualstudio.extensibility.editor.textviewmarginproviderconfiguration.gridcelllength) and [GridUnitType](/dotnet/api/microsoft.visualstudio.extensibility.editor.textviewmarginproviderconfiguration.gridunittype) properties.

Text view margins typically visualize some data related to the text view (for example, current line number or the count of errors) so most text view margin providers would also want to [listen to text view events](working-with-text.md) to react to opening, closing of text views and user typing.

Visual Studio only creates one instance of your text view margin provider regardless of how many applicable text views a user opens, so if your margin displays some stateful data, your provider needs to keep the state of currently open text views.

For more information, see [Word Count Margin Sample](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/WordCountMargin/).

Vertical text view margins whose content needs to be aligned with text view lines are not yet supported.