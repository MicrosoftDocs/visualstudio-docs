---
title: Add CodeLens indicators
description: Learn how to add custom CodeLens indicators that display inline metadata and actionable information above code elements in the Visual Studio editor.
ms.date: 09/29/2026
ms.topic: how-to
ms.author: tinali
monikerRange: ">=vs-2022"
author: tinaschrepfer

ms.subservice: extensibility-integration
ms.update-cycle: 365-days
---

# Add CodeLens indicators

CodeLens indicators display inline information above code elements (classes, methods, properties) in the editor — references, test status, change history, and more. They're one of the most visible integration points in Visual Studio, surfacing contextual metadata directly where developers work without requiring them to open a separate window.

Use CodeLens when you want to show per-code-element metadata like ownership, test results, linked issues, or change frequency. For general tooltips on arbitrary text, use Quick Info instead. For inline visual decorations, consider text adornments or taggers.

> [!NOTE]
> This guide uses the **VisualStudio.Extensibility** SDK. See [Choose the right extensibility model](../../how-it-works/models/extensibility-models.md) for model comparison.

## Full example

The complete implementation:

:::code language="csharp" source="~/../vs-extensibility-samples/New_Extensibility_Model/Samples/CodeLensSample/WordCountCodeLensProvider.cs":::

> [!TIP]
> See the full working sample: [CodeLensSample ↗](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/CodeLensSample/)

**Related concepts:** [Editor concepts](editor-concepts.md) — text view lifecycle and editor architecture

## Understand the example

**When to use CodeLens vs. alternatives:**

- Inline metadata above code elements (methods, classes) → **CodeLens** (this page)
- Hover tooltips on arbitrary text spans → Quick Info
- Persistent panels alongside the editor → [margins](margins.md)
- Visual decorations overlaid on text → text adornments (not yet supported out-of-process — use [in-process extensions](../../how-it-works/models/in-proc-extensions.md))

### Types of CodeLens

You can create various CodeLens types. Each type offers its own unique set of functionalities.

### Text view CodeLens

A text view CodeLens provides text-based information to segments of code, and it's the simplest form of CodeLens. The following concepts illustrate how to create a text view CodeLens:

- The [`ICodeLensProvider` ↗](/dotnet/api/microsoft.visualstudio.extensibility.editor.icodelensprovider) interface is the main interface to implement. Your implementation of this interface defines when your CodeLens activates, which segments of code that your CodeLens applies to, and how it displays.
- Within your implementation of [`ICodeLensProvider` ↗](/dotnet/api/microsoft.visualstudio.extensibility.editor.icodelensprovider), you need to define when the CodeLens should be activated by implementing [`CodeLensProviderConfiguration` ↗](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelensproviderconfiguration).
- You also need to implement the [`TryCreateCodeLensAsync` ↗](/dotnet/api/microsoft.visualstudio.extensibility.editor.icodelensprovider.trycreatecodelensasync) method. This method runs when your CodeLens is activated. In this method, you can define how and when you want your CodeLens to be displayed. This method returns an instance of [`CodeLens` ↗](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelens).
- You need to create your own subclass of [`CodeLens` ↗](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelens), where you get to define how you want your display text to appear through the [`GetLabelAsync` ↗](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelens.getlabelasync) method. This method returns an instance of [`CodeLensLabel` ↗](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelenslabel), which you can use to configure the text, a tooltip, and an optional icon.

### Invokable CodeLens

An invokable CodeLens allows extensions to perform some action (for example, running a unit test) when the user selects the CodeLens. Extensions can contribute an invokable CodeLens by implementing [`InvokableCodeLens` ↗](/dotnet/api/microsoft.visualstudio.extensibility.editor.invokablecodelens), which derives from [`CodeLens` ↗](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelens).

### Visual CodeLens

A visual CodeLens allows extensions to provide custom UI, like a list of references to a method, to appear in a popup above the CodeLens when the user selects the CodeLens. Extensions can contribute a visual CodeLens by implementing [`VisualCodeLens` ↗](/dotnet/api/microsoft.visualstudio.extensibility.editor.visualcodelens), which derives from [`CodeLens` ↗](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelens).

Similar to text view margins, because extensions in `VisualStudio.Extensibility` might be out of process from Visual Studio, a visual CodeLens provides a UI by creating a [`RemoteUserControl`](../../how-it-works/remote-ui.md) and the corresponding data template for that control. Some simple examples are shown in the following sections. We recommend that you read the [Remote UI documentation](../../how-it-works/remote-ui.md) when you create visual CodeLens UI content.

The sample splits the implementation across separate files. `WordCountCodeLensProvider` creates the visual CodeLens, `WordCountCodeLens` supplies its label and popup UI, and `ClickableCodeLens` shows a separate invokable CodeLens implementation:

:::code language="csharp" source="~/../vs-extensibility-samples/New_Extensibility_Model/Samples/CodeLensSample/WordCountCodeLensProvider.cs":::

:::code language="csharp" source="~/../vs-extensibility-samples/New_Extensibility_Model/Samples/CodeLensSample/WordCountCodeLens.cs":::

:::code language="csharp" source="~/../vs-extensibility-samples/New_Extensibility_Model/Samples/CodeLensSample/ClickableCodeLens.cs":::

In addition to configuring CodeLens provider display names, CodeLens providers can also configure the priority of their CodeLens. The priority value is used to determine the relative ordering of your CodeLens respective to any other CodeLens. You can set the order through the [`Priority` ↗](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelensproviderconfiguration.priority) property in the [`CodeLensProviderConfiguration` ↗](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelensproviderconfiguration) object.

If a CodeLens provider has to reference code elements that an existing Visual Studio feature hasn't already tagged, you can create a [CodeLens tagger](./taggers.md) by deriving its provider from `TextViewTaggerProvider<CodeLensTag, TTagger>`.

## Tips

### ✅ DO

- Use `CodeElementKind.KnownValues.Method` (or `.Class`, `.Property`) to filter which code elements get CodeLens
- Call `this.Invalidate()` to refresh CodeLens display when data changes
- Return `null` from `TryCreateCodeLensAsync` if CodeLens doesn't apply to a given element
- Track state per text view if your CodeLens is stateful (provider is singleton)
- Use `DocumentFilter.FromDocumentType(DocumentType.KnownValues.Code)` for broad code file coverage

### ❌ DON'T

- Don't do expensive computation in `GetLabelAsync` — it runs on every refresh
- Don't forget that VS creates only one instance of your provider (manage state carefully)
- Don't create CodeLens for non-code elements without a custom tagger

### 🔧 Troubleshooting

| Symptom | Fix |
|---------|-----|
| CodeLens not appearing | Check `AppliesTo` document filter matches the file type; verify `CodeLensProviderConfiguration` is defined |
| CodeLens shows stale data | Call `this.Invalidate()` when underlying data changes |
| CodeLens appears on wrong elements | Verify `codeElement.Kind` check in `TryCreateCodeLensAsync` |
| Visual CodeLens popup is empty | Ensure RemoteUserControl XAML is marked as EmbeddedResource |

## Next steps

- [Taggers and classification](taggers.md) — create custom code element tags for CodeLens
- [Editor margins](margins.md) — persistent UI alongside the editor
- [Remote UI](../../how-it-works/remote-ui.md) — for visual CodeLens custom UI
