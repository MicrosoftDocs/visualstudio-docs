---
title: Add editor margins
description: Learn how to add custom margins to the Visual Studio editor for status panels, gutter indicators, and persistent information alongside your code.
ms.date: 09/29/2026
ms.topic: how-to
ms.author: tinali
monikerRange: ">=vs-2022"
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
---

# Add editor margins

Editor margins are UI panels attached to the edges of the text editor — left (gutter), right, top, or bottom. They're the natural location for UI that tracks editor content line-by-line or provides persistent supplementary information alongside code. Common examples include word count indicators, line-level annotations, coverage markers, and custom status bars below the editor.

Unlike adornments which draw over text, margins have their own reserved space and don't interfere with text selection or scrolling. If you need to show persistent information alongside the editor rather than overlaying the code, margins are the right choice.

> [!NOTE]
> This guide uses the **VisualStudio.Extensibility** SDK. See [Choose the right extensibility model](../../how-it-works/models/extensibility-models.md) for model comparison.

## Full example

The complete implementation:

:::code language="csharp" source="~/../vs-extensibility-samples/New_Extensibility_Model/Samples/WordCountMargin/TextViewMarginProvider.cs":::

> [!TIP]
> See the full working sample: [WordCountMargin ↗](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/WordCountMargin/)

**Related concepts:** [Editor concepts](editor-concepts.md) — text view lifecycle, margins, and editor architecture

## Understand the example

**When to use margins vs. alternatives:**

- Persistent panel above, below, left, or right of the editor → **margins** (this page)
- Visual overlays on top of text (highlights, inline decorations) → text adornments (not yet supported in VisualStudio.Extensibility — use [in-process extensions](../../how-it-works/models/in-proc-extensions.md))
- Inline metadata above code elements → [CodeLens](codelens.md)
- A full dockable panel not attached to the editor → [tool windows](../tool-windows.md)

### How to create a margin

Text view margin providers implement the [ITextViewMarginProvider ↗](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewmarginprovider) interface, configuring the margin by implementing [TextViewMarginProviderConfiguration ↗](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewmarginprovider.textviewmarginproviderconfiguration). When activated, they provide a UI control to be hosted in the margin via [CreateVisualElementAsync ↗](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewmarginprovider.createvisualelementasync).

Because VisualStudio.Extensibility extensions run out of process, you can't use WPF directly for margin content. Instead, create a [RemoteUserControl](../../how-it-works/remote-ui.md#create-the-remote-user-control) and a corresponding XAML data template. See the [Remote UI documentation](../../how-it-works/remote-ui.md) for details.

#### Place the margin

Margins are placed in a container and ordered relative to other margins:

```csharp
/// <summary>
/// Places the margin in the bottom-right editor status area before the built-in row margin.
/// </summary>
public TextViewMarginProviderConfiguration TextViewMarginProviderConfiguration => new(marginContainer: ContainerMarginPlacement.KnownValues.BottomRightCorner)
{
    Before = new[] { MarginPlacement.KnownValues.RowMargin },
};

/// <summary>
/// Creates a remotable visual element representing the content of the margin.
/// </summary>
public Task<IRemoteUserControl> CreateVisualElementAsync(ITextViewSnapshot textView, CancellationToken cancellationToken)
{
    var documentSnapshot = textView.Document;
    var dataModel = new WordCountData();
    dataModel.WordCount = CountWords(documentSnapshot);
    this.dataModels[textView.Uri] = dataModel;
    return Task.FromResult<IRemoteUserControl>(new MyMarginContent(dataModel));
}
```

In addition to configuring margin placement, text view margin providers can also configure the size of the grid cell in which the margin should be placed by using [GridCellLength ↗](/dotnet/api/microsoft.visualstudio.extensibility.editor.textviewmarginproviderconfiguration.gridcelllength) and [GridUnitType ↗](/dotnet/api/microsoft.visualstudio.extensibility.editor.textviewmarginproviderconfiguration.gridunittype) properties.

Text view margins typically visualize some data related to the text view (for example, the current line number or the count of errors). Most text view margin providers also want to [listen to text view events](editor.md) to react to the opening and closing of text views and user typing.

Visual Studio creates only one instance of your text view margin provider regardless of how many applicable text views that a user opens. If your margin shows some stateful data, your provider needs to keep the state of currently open text views.

> [!NOTE]
> Vertical text view margins whose content needs to be aligned with text view lines aren't supported yet.

## Tips

### ✅ DO

- Use `ContainerMarginPlacement.KnownValues` for standard positions (BottomRightCorner, Left, Right, Top, Bottom)
- Use `Before` array to position relative to known margins like `MarginPlacement.KnownValues.RowMargin`
- Set explicit sizing in XAML or via `GridCellLength` / `GridUnitType`
- Implement `ITextViewChangedListener` to update margin content on document changes
- Track state per text view (provider is singleton, views are many)
- Pre-compute expensive data on background thread, update data model

### ❌ DON'T

- Don't do heavy computation in event handlers — slow margins cause editor lag
- Don't forget sizing on your control (renders invisible with zero size)
- Don't use WPF directly — use Remote UI with XAML as EmbeddedResource
- Don't assume only one text view exists — track state per `textView.Uri`

### 🔧 Troubleshooting

| Symptom | Fix |
|---------|-----|
| Margin doesn't appear | Verify `ContainerMarginPlacement` uses a valid placement value; check `AppliesTo` matches your document type |
| Margin has zero height/width | Set explicit sizing in XAML or via `GridCellLength` / `GridUnitType` |
| Margin causes editor lag | Avoid expensive work in event handlers; pre-compute on background thread and update data model |
| Multiple margins for same view | Provider is singleton — track state per `textView.Uri` |

## Next steps

- [CodeLens](codelens.md) — inline metadata above code elements
- [Taggers and classification](taggers.md) — mark up text with visual indicators
- [Remote UI](../../how-it-works/remote-ui.md) — how to build margin UI content
