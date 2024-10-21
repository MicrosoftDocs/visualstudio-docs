---
title: Choose the right Visual Studio extensibility model for you
description: Learn about the different frameworks you can use extend Visual Studio, including VSSDK, the Community Toolkit, and VisualStudio.Extensibility, and learn about the pros and cons of each method.
author: TinaSchrepfer
ms.author: tinali
manager: mijacobs
ms.date: 10/16/2024
ms.topic: product-comparison
ms.subservice: extensibility-integration
---
# Choose the right Visual Studio extensibility model for you

You can extend Visual Studio using three main extensibility models, VSSDK, Community Toolkit, and VisualStudio.Extensibility. This article covers the pros and cons of each. We use a simple example to highlight the architectural and code differences between the models.

## VSSDK

[VSSDK](/visualstudio/extensibility/visual-studio-sdk) (or Visual Studio SDK) is the model that most extensions on the [Visual Studio Marketplace](https://marketplace.visualstudio.com/vs) are based on. This model is what Visual Studio itself is built on. It's the most complete and the most powerful, but also the most complex to learn and use correctly. Extensions that use VSSDK run in the same process as Visual Studio itself. Loading in the same process as Visual Studio means that an extension that has an access violation, infinite loop, or other problems can crash or hang Visual Studio and degrade the customer experience. And because extensions run in the same process as Visual Studio, they can only be built using [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework). Extenders wanting to use or incorporate libraries that use [.NET](https://dotnet.microsoft.com/download) 5 and later can't do so using VSSDK.

APIs in VSSDK have been aggregated over the years as Visual Studio itself transformed and evolved. In a single extension, you may find yourself grappling with [COM](/windows/win32/api/_com/)-based APIs from legacy imprint, breezing through the deceptive simplicity of [DTE](/dotnet/api/envdte.dte), and tinkering with [MEF](/dotnet/framework/mef/) imports and exports. Let's take an example of writing an extension which reads the text from the filesystem and inserts it to the start of the current active document within the editor. The following snippet shows the code you would write to handle when a command is invoked in a VSSDK-based extension:

``` csharp
private void Execute(object sender, EventArgs e)
{
    var textManager = package.GetService<SVsTextManager, IVsTextManager>();
    textManager.GetActiveView(1, null, out IVsTextView activeTextView);

    if (activeTextView != null && activeTextView is IVsTextViewEx nativeView)
    {
        ErrorHandler.ThrowOnFailure(nativeView.GetWindowFrame(out object frameValue));

        IComponentModel2 compService = package.GetService<SComponentModel, IComponentModel2>();
        IVsEditorAdaptersFactoryService editorAdapter = compService.GetService<IVsEditorAdaptersFactoryService>();
        var wpfTextView = editorAdapter?.GetWpfTextView(activeTextView);

        if (frameValue is IVsWindowFrame frame && wpfTextView != null)
        {
            var fileText = File.ReadAllText(Path.Combine(Path.GetTempPath(), "test.txt"));
            wpfTextView.TextBuffer?.Insert(0, fileText);
        }
    }
}
```

In addition, you would also need to provide a `.vsct` file, which defines the command configuration, like where to place it in the UI, the text associated, and so on:

``` xml
<Commands package="guidVSSDKPackage">
    <Groups>
        <Group guid="guidVSSDKPackageCmdSet" id="MyMenuGroup" priority="0x0600">
        <Parent guid="guidSHLMainMenu" id="IDM_VS_MENU_TOOLS" />
        </Group>
    </Groups>

    <Buttons>
        <Button guid="guidVSSDKPackageCmdSet" id="InsertTextCommandId" priority="0x0100" type="Button">
        <Parent guid="guidVSSDKPackageCmdSet" id="MyMenuGroup" />
        <Icon guid="guidImages" id="bmpPic1" />
        <Strings>
            <ButtonText>Invoke InsertTextCommand (Unwrapped Community Toolkit)</ButtonText>
        </Strings>
        </Button>
        <Button guid="guidVSSDKPackageCmdSet" id="cmdidVssdkInsertTextCommand" priority="0x0100" type="Button">
        <Parent guid="guidVSSDKPackageCmdSet" id="MyMenuGroup" />
        <Icon guid="guidImages1" id="bmpPic1" />
        <Strings>
            <ButtonText>Invoke InsertTextCommand (VSSDK)</ButtonText>
        </Strings>
        </Button>
    </Buttons>

    <Bitmaps>
        <Bitmap guid="guidImages" href="Resources\InsertTextCommand.png" usedList="bmpPic1, bmpPic2, bmpPicSearch, bmpPicX, bmpPicArrows, bmpPicStrikethrough" />
        <Bitmap guid="guidImages1" href="Resources\VssdkInsertTextCommand.png" usedList="bmpPic1, bmpPic2, bmpPicSearch, bmpPicX, bmpPicArrows, bmpPicStrikethrough" />
    </Bitmaps>
</Commands>
  ```

As you can see in the sample, the code may seem unintuitive and is unlikely for someone familiar with .NET to pick up easily. There are many concepts to learn and the API patterns to access the active editor text are antiquated. For most extenders, VSSDK extensions are constructed from copying and pasting from online sources, which can lead to difficult debugging sessions, trial and error, and frustration. In many cases, VSSDK extensions may not be the easiest way to achieve the extension goals (though sometimes, they're the only choice).

## Community Toolkit

[Community Toolkit](/visualstudio/extensibility/vsix/visual-studio-community-toolkit) is the open source, community-based extensibility model for Visual Studio that wraps the VSSDK for an easier development experience. Because it's based on the VSSDK, it's subject to the same limitations as VSSDK (that is, .NET Framework only, no isolation from the rest of Visual Studio, and so on). Continuing with the same example of writing an extension that inserts the text read from filesystem, using Community Toolkit, the extension would be written as follows for a command handler:

``` csharp
protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
{
    DocumentView docView = await VS.Documents.GetActiveDocumentViewAsync();
    if (docView?.TextView == null) return;
    var fileText = File.ReadAllText(Path.Combine(Path.GetTempPath(), "test.txt"));
    docView.TextBuffer?.Insert(0, fileText);
}
```

The resulting code is much improved from VSSDK in terms of simplicity and intuitiveness! Not only did we decrease the number of lines significantly, but the resulting code looks reasonable as well. There's no need to understand what the difference is between `SVsTextManager` and `IVsTextManager`. The APIs look and feel more .NET-friendly, embracing common naming and async patterns, along with prioritization of common operations. However, Community Toolkit is still built on the existing VSSDK model and so, vestiges of the underlying structure bleed through. For example, a `.vsct` file is still necessary. While Community Toolkit does a great job of simplifying the APIs, it's bound to the limitations of VSSDK and doesn't have a way to make extension configuration simpler.

## VisualStudio.Extensibility

VisualStudio.Extensibility is the new extensibility model where extensions run outside of the main Visual Studio process. Because of this fundamental architectural shift, new patterns and capabilities are now available to extensions that are not possible with VSSDK or Community Toolkit. VisualStudio.Extensibility offers a completely new set of APIs that are consistent and easy to use, allows extensions to target .NET, isolates bugs that arise from extensions from the rest of Visual Studio, and enables users to install extensions without restarting Visual Studio. However, because the new model is built on new underlying architecture, it does not yet have the breadth that VSSDK and the Community Toolkit have. To bridge that gap, you can run your VisualStudio.Extensibility extensions [in process](/visualstudio/extensibility/visualstudio.extensibility/get-started/in-proc-extensions), which allows you to continue using VSSDK APIs. However, doing so means that your extension can only target .NET Framework since it shares the same process as Visual Studio, which is based on .NET Framework.

Continuing with the same example of writing an extension that inserts the text from a file, using VisualStudio.Extensibility, the extension would be written as follows for command handling:

``` csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
    var activeTextView = await context.GetActiveTextViewAsync(cancellationToken);
    if (activeTextView is not null)
    {
        var editResult = await Extensibility.Editor().EditAsync(batch =>
        {
            var fileText = File.ReadAllText(Path.Combine(Path.GetTempPath(), "test.txt"));

            ITextDocumentEditor editor = activeTextView.Document.AsEditable(batch);
            editor.Insert(0, fileText);
        }, cancellationToken);
                
    }
}
```

To configure the command for placement, text, and so on, you no longer need to provide a `.vsct` file. Instead, it's done through code:

``` csharp
public override CommandConfiguration CommandConfiguration => new("%VisualStudio.Extensibility.Command1.DisplayName%")
{
    Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
    Placements = [CommandPlacement.KnownPlacements.ExtensionsMenu],
};
```

This code is easier to understand and follow. For the most part, you can write this extension purely through the editor with the help of IntelliSense, even for command configuration. 

## Comparing the different Visual Studio extensibility models

From the sample, you may notice that using VisualStudio.Extensibility, there are more lines of code than Community Toolkit in the command handler. Community Toolkit is an excellent ease-of-use wrapper on top of building extensions with the VSSDK; however, there are pitfalls that are not immediately obvious which is what led to the development of VisualStudio.Extensibility. To understand the transition and need, especially when it seems like the Community Toolkit also results in code that's easy to write and understand, let's review the example and compare what's happening in the deeper layers of the code.

We can quickly unwrap the code in this sample and see what's actually being called on the VSSDK side. We're going to focus solely on the command execution snippet since there's numerous details that VSSDK needs, which Community Toolkit does hide  nicely. But once we look at the underlying code, you'll understand why the simplicity here is a tradeoff. The simplicity hides some of the underlying details, which may lead to unexpected behavior, bugs, and even performance issues and crashes. The following code snippet shows the Community Toolkit code unwrapped to show the VSSDK calls:

``` csharp
private void Execute(object sender, EventArgs e)
{
    package.JoinableTaskFactory.RunAsync(async delegate
    {
        var textManager = await package.GetServiceAsync<SVsTextManager, IVsTextManager>();
        textManager.GetActiveView(1, null, out IVsTextView activeTextView);

        if (activeTextView != null && activeTextView is IVsTextViewEx nativeView)
        {
            await package.JoinableTaskFactory.SwitchToMainThreadAsync();
            ErrorHandler.ThrowOnFailure(nativeView.GetWindowFrame(out object frameValue));

            IComponentModel2 compService = package.GetService<SComponentModel, IComponentModel2>();
            IVsEditorAdaptersFactoryService editorAdapter = compService.GetService<IVsEditorAdaptersFactoryService>();
            var wpfTextView = editorAdapter?.GetWpfTextView(activeTextView);

            if (frameValue is IVsWindowFrame frame && wpfTextView != null)
            {
                var fileText = File.ReadAllText(Path.Combine(Path.GetTempPath(), "test.txt"));
                wpfTextView.TextBuffer?.Insert(0, fileText);    
            }
        }
    });
}
```

There are few issues to get into here, and they all revolve around threading and async code. We'll go through each one in detail.

### Async API versus async code execution

The first thing to note is that the `ExecuteAsync` method in Community Toolkit is a wrapped async fire-and-forget call in VSSDK:

``` csharp
package.JoinableTaskFactory.RunAsync(async delegate
{
  …
});
```

VSSDK itself doesn't support asynchronous command execution from a core API perspective. That is, when a command is executed, VSSDK doesn't have a way to execute the command handler code on a background thread, wait for it to finish, and return the user to the original calling context with execution results. So, even though the ExecuteAsync API in Community Toolkit is syntactically async, it's not true async execution. And because it's a fire and forget way of async execution, you could call ExecuteAsync over and over again without ever waiting for the previous call to complete first. While Community Toolkit provides a better experience in terms of helping extenders discover how to implement common scenarios, it ultimately can't solve the fundamental problems with VSSDK. In this case, the underlying VSSDK API is not asynchronous, and the fire-and-forget helper methods provided by Community Toolkit can't properly address async yielding and working with client state; it may hide some potential hard-to-debug issues. 

### UI thread versus background thread

The other fallout with this wrapped async call from Community Toolkit is that the code itself is still executed from the UI thread, and it's on the extension developer to figure out how to correctly switch to a background thread if you don't want to risk freezing the UI. As much as Community Toolkit can hide the noise and extra code of VSSDK, it still requires you to understand the complexities of threading in Visual Studio. And one of the first lessons you learn in VS threading is that not everything can be run from a background thread. In other words, not everything is thread safe, particularly the calls that go into COM components. So, in the above example, you see that there's a call to switch to main (UI) thread:

``` csharp
await package.JoinableTaskFactory.SwitchToMainThreadAsync();
ErrorHandler.ThrowOnFailure(nativeView.GetWindowFrame(out object frameValue));
```

You can of course switch back to a background thread after this call. However, as an extender using Community Toolkit, you'll need to pay close attention to what thread your code is on and determine if it has the risk of freezing the UI. Threading in Visual Studio is hard to get right and requires the proper use of [`JoinableTaskFactory`](/dotnet/api/microsoft.visualstudio.threading.joinabletaskfactory) to avoid deadlocks. The struggle to write code that deals with threading correctly has been a constant source of bugs, even for our internal Visual Studio engineers. VisualStudio.Extensibility, on the other hand, avoids this problem altogether by running extensions out of process and relying on async APIs end-to-end. 

### Simple API versus simple concepts

Because Community Toolkit hides away many of the intricacies of VSSDK, it could give extenders a false sense of simplicity. Let's continue with the same sample code. If an extender didn't know about the threading requirements of Visual Studio development, they might assume that their code is run from a background thread the whole time. They'll take no issue with the fact that the call to read a file from text is synchronous. If it's on a background thread, it won't freeze the UI if the file in question is large. However, when the code is unwrapped to VSSDK, they'll realize that's not the case. So, while the API from Community Toolkit certainly looks simpler to understand and more cohesive to write, because it's tied to VSSDK, it's subject to VSSDK limitations. The simplicities can gloss over important concepts that, if extenders don't understand, can cause more harm. VisualStudio.Extensibility avoids the many issues caused by main-thread dependencies by focusing on the out-of-process model and async APIs as our foundation. While running out of the process would simplify threading the most, many of these benefits carry over to extensions that are run in-process as well. For example, VisualStudio.Extensibility commands are always executed on a background thread. Interacting with VSSDK APIs still requires in-depth knowledge of how threading works, but at least you won't pay the cost of accidental hangs, as in this example.

## Comparison chart

To summarize what we covered in detail in the previous section, the following table shows a quick comparison:

| | **VSSDK** | **Community Toolkit** | **VisualStudio.Extensibility** |
|---|---|---|---|
| **Runtime Support** | .NET Framework | .NET Framework | .NET |
| **Isolation from Visual Studio** | ❌ | ❌ | ✅ |
| **Simple API** | ❌ | ✅ | ✅ |
| **Async Execution and API** | ❌ | ❌ | ✅ |
| **VS Scenario Breadth** | ✅ | ✅ | ⏳ |
| **Installable without Restart** | ❌ | ❌ | ✅ |
| **Supports** **VS 2019 and** **Below** | ✅ | ✅ | ❌ |

To help you apply the comparison to your Visual Studio extensibility needs, here are some sample scenarios and our recommendations on which model to use:

- ***I am new to Visual Studio extension development, and I want the easiest onboarding experience to create a high-quality extension, and I only*** ***need to*** ***support Visual Studio 2022 or above.***
  - In this case, we recommend that you use VisualStudio.Extensibility.
- ***I'd like to write an extension that targets Visual Studio 2022 and above. However,*** ***VisualStudio.Extensibility doesn't support all the*** ***functionality that I need.***
  - We recommend that in this case, you should adopt a hybrid method of combining VisualStudio.Extensibility and VSSDK. You can author a VisualStudio.Extensibility extension that [runs in process](/visualstudio/extensibility/visualstudio.extensibility/get-started/in-proc-extensions), which allows you to access VSSDK or Community Toolkit APIs.
- ***I have an existing extension and want to update it to support newer versions. I want my extension to support as many versions of Visual Studio as possible.***
  - Because VisualStudio.Extensibility only supports Visual Studio 2022 and above, VSSDK or Community Toolkit is the best option for this case.
- ***I have an existing extension that I'd like to migrate to*** ***VisualStudio.Extensibility to take advantage of .NET and install without restart.*** 
  - This scenario is a bit more nuanced since VisualStudio.Extensibility doesn't support down-level versions of Visual Studio. 
    - If your existing extension only supports Visual Studio 2022 and has all the APIs you need, then we recommend you rewrite your extension to use VisualStudio.Extensibility. But if your extension needs APIs that VisualStudio.Extensibility does not yet have, then go ahead and create a VisualStudio.Extensibility extension that [runs in process](/visualstudio/extensibility/visualstudio.extensibility/get-started/in-proc-extensions) so you can access VSSDK APIs. Overtime you can eliminate VSSDK API usage as VisualStudio.Extensibility adds support and move your extensions to run out of process.
    - If your extension needs to support down-level versions of Visual Studio that don't have support for VisualStudio.Extensibility, then we recommend that you do some refactoring in your codebase. Pull all the common code that can be shared across Visual Studio versions to its own library, and create separate VSIX projects that target different extensibility models. For example, if your extension needs to support Visual Studio 2019 and Visual Studio 2022, you can adopt the following project structure in your solution:
      - MyExtension-VS2019 (this is your VSSDK based VSIX container project that targets Visual Studio 2019)
      - MyExtension-VS2022 (this is your VSSDK+VisualStudio.Extensibility based VSIX container project that targets Visual Studio 2022)
      - VSSDK-CommonCode (this is the common library which is used to call Visual Studio APIs through VSSDK. Both of your VSIX projects can reference this library to share code.)
      - MyExtension-BusinessLogic (this is the common library which contains all the code that's pertinent to your extension's business logic. Both of your VSIX projects can reference this library to share code.)

## Next steps

Our recommendation is that extenders start with VisualStudio.Extensibility when creating new extensions or enhancing existing ones, and use VSSDK or the Community Toolkit if you run into unsupported scenarios. To get started, with VisualStudio.Extensibility, browse through the documentation presented in this section. You can also reference the VSExtensibility GitHub [repo](https://github.com/microsoft/VSExtensibility) for [samples](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples) or to file [issues](https://github.com/microsoft/VSExtensibility/issues).

