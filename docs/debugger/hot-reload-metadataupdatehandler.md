---
title: "Enhance .NET Hot Reload"
description: "Learn to use the MetadataUpdateHandler attribute to customize Hot Reload to support additional scenarios."
ms.date: 06/20/2023
ms.topic: conceptual
helpviewer_keywords:
  - "Hot reload, MetadataUpdateHandler"
  - ".NET Hot Reload, MetadataUpdateHandler"
  - "MetadataUpdateHandler for .NET Hot Reload"
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: '>= vs-2022'
ms.workload:
  - "multiple"
---
# Enhance .NET Hot Reload using MetadataUpdateHandler (C#, Visual Basic)

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

You can programmatically extend .NET Hot Reload support for additional scenarios that aren't typically supported, such as code changes that require clearing a cache or refreshing the UI. For example, to support hot reload with a JSON serializer, you need to clear its cache when a type is modified. You can use the <xref:System.Reflection.Metadata.MetadataUpdateHandlerAttribute> to refresh the application state, trigger a UI re-render, or perform similar actions.

The type specified by this attribute should implement static methods matching the signature of one or more of the following:

```csharp
static void ClearCache(Type[]? updatedTypes)
static void UpdateApplication(Type[]? updatedTypes)
```

MetadataUpdateHandler gives update handlers an opportunity to clear any caches that are inferred based on the application's metadata. After all ClearCache methods have been invoked, UpdateApplication is invoked for every handler that specifies one.

For example, in a C# MAUI app, you must do something to reload the UI after you make any code change. If your UI code is written in C#, you could use MetadataUpdateHandler to reload the UI. To set this up, add *HotReloadService.cs* to your application using the following code.

```csharp
#if DEBUG
[assembly: System.Reflection.Metadata.MetadataUpdateHandlerAttribute(typeof(YourAppNamespace.HotReloadService))]
namespace YourAppNamespace { 
    public static class HotReloadService
    {
        public static event Action<Type[]?>? UpdateApplicationEvent;

        internal static void ClearCache(Type[]? types) { }
        internal static void UpdateApplication(Type[]? types) {
            UpdateApplicationEvent?.Invoke(types);
        }
    }
}
#endif
```

Now, with the preceding code added, when you edit live code in Visual Studio, a metadata change occurs and the app dispatches the `UpdateApplicationEvent`.

> [!NOTE]
> For this scenario, XAML Hot Reload must be enabled.

In your MAUI app, implement a Build method to simplify the UI update. This method sets the `ContentPage.Content` and is called in the page's `OnNavigatedTo`. The `OnNavigatedTo` event must be hosted within Shell or a NavigationPage.

```csharp
void Build() => Content = 
        new Grid { 

        };
````

Call the Build method from the `OnNavigatedTo` event and register the `UpdateApplicationEvent` event handler.

```csharp
protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        Build();

#if DEBUG
        HotReloadService.UpdateApplicationEvent += ReloadUI;
#endif
    }
```

De-register the event handler in `OnNavigatedFrom`.

```csharp
    protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
    {
        base.OnNavigatedFrom(args);

#if DEBUG
        HotReloadService.UpdateApplicationEvent -= ReloadUI;
#endif
    }
```

In the file where you want to re-execute the build, handle the event.

```csharp
private void ReloadUI(Type[] obj)
{
    MainThread.BeginInvokeOnMainThread(() =>
    {
        Build();
    });
}
```

Now, start the app. When you make a change to your C# in this page and hit the Hot Reload button, the UI gets refreshed!

## Additional resources

- [C# UI and .NET Hot Reload](https://dev.to/davidortinau/c-ui-and-net-hot-reload-a-match-made-in-net-maui-243f)
- [Supporting Hot Reload in your .NET application](https://www.meziantou.net/supporting-hot-reload-in-your-dotnet-application.htm)