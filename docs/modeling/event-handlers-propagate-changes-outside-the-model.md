---
title: Event Handlers Propagate Changes Outside the Model
description: Learn that in the Visualization and Modeling SDK, you can define store event handlers to propagate changes to resources outside the store.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- Domain-Specific Language, programming domain models
- Domain-Specific Language, events
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Event Handlers Propagate Changes Outside the Model

In Visualization and Modeling SDK, you can define store event handlers to propagate changes to resources outside the store, such as non-store variables, files, models in other stores, or other Visual Studio extensions. Store event handlers are executed after the end of the transaction in which the triggering event occurred. They are also executed in an Undo or Redo operation. Therefore, unlike store rules, store events are most useful for updating values that are outside the store. Unlike .NET events, store event handlers are registered to listen to a class: you do not have to register a separate handler for each instance. For more information about how to choose between different ways to handle changes, see [Responding to and Propagating Changes](../modeling/responding-to-and-propagating-changes.md).

The graphical surface and other user interface controls are examples of external resources that can be handled by store events.

### To define a store event

1. Choose the type of event that you want to monitor. For a full list, look at the properties of <xref:Microsoft.VisualStudio.Modeling.EventManagerDirectory>. Each property corresponds to a type of event. The most frequently used event types are:

    - `ElementAdded` - triggered when a model element, relationship link, shape or connector is created.

    - ElementPropertyChanged - triggered when the value of a `Normal` domain property is changed. The event is triggered only if the new and old values are not equal. The event cannot be applied to calculated and custom storage properties.

         It cannot be applied to the role properties that correspond to relationship links. Instead, use `ElementAdded` to monitor the domain relationship.

    - `ElementDeleted` - triggered after a model element, relationship, shape or connector has been deleted. You can still access the property values of the element, but it will have no relationships to other elements.

2. Add a partial class definition for _YourDsl_**DocData** in a separate code file in the **DslPackage** project.

3. Write the code of the event as a method, as in the following example. It can be `static`, unless you want to access `DocData`.

4. Override `OnDocumentLoaded()` to register the handler. If you have more than one handler, you can register them all in the same place.

The location of the registration code is not critical. `DocView.LoadView()` is an alternative location.

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.Modeling;

namespace Company.MusicLib
{
  partial class MusicLibDocData
  {
    // Register store events here or in DocView.LoadView().
    protected override void OnDocumentLoaded()
    {
      base.OnDocumentLoaded(); // Don't forget this.

      #region Store event handler registration.
      Store store = this.Store;
      EventManagerDirectory emd = store.EventManagerDirectory;
      DomainRelationshipInfo linkInfo = store.DomainDataDirectory
          .FindDomainRelationship(typeof(ArtistAppearsInAlbum));
      emd.ElementAdded.Add(linkInfo,
          new EventHandler<ElementAddedEventArgs>(AddLink));
      emd.ElementDeleted.Add(linkInfo,
          new EventHandler<ElementDeletedEventArgs>(RemoveLink));

      #endregion Store event handlers.
    }

    private void AddLink(object sender, ElementAddedEventArgs e)
    {
      ArtistAppearsInAlbum link = e.ModelElement as ArtistAppearsInAlbum;
      if (link != null)
            ExternalDatabase.Add(link.Artist.Name, link.Album.Title);
    }
    private void RemoveLink(object sender, ElementDeletedEventArgs e)
    {
      ArtistAppearsInAlbum link = e.ModelElement as ArtistAppearsInAlbum;
      if (link != null)
            ExternalDatabase.Delete(link.Artist.Name, link.Album.Title);
    }
  }
}
```

## Use Events to Make Undoable Adjustments in the Store

Store events are not normally used for propagating changes inside the store, because the event handler executes after the transaction is committed. Instead, you would use a store rule. For more information, see [Rules Propagate Changes Within the Model](../modeling/rules-propagate-changes-within-the-model.md).

However, you could use an event handler to make additional updates to the store, if you want the user to be able to undo the additional updates separately from the original event. For example, suppose that lower case characters are the usual convention for album titles. You could write a store event handler that corrects the title to lower case after the user has typed it in upper case. But the user could use the Undo command to cancel your correction, restoring the upper case characters. A second Undo would remove the user's change.

By contrast, if you wrote a store rule to do the same thing, the user's change and your correction would be in the same transaction, so that the user could not undo the adjustment without losing the original change.

```csharp
partial class MusicLibDocView
{
    // Register store events here or in DocData.OnDocumentLoaded().
    protected override void LoadView()
    {
      /* Register store event handler for Album Title property. */
      // Get reflection data for property:
      DomainPropertyInfo propertyInfo =
        this.DocData.Store.DomainDataDirectory
        .FindDomainProperty(Album.TitleDomainPropertyId);
      // Add to property handler list:
      this.DocData.Store.EventManagerDirectory
        .ElementPropertyChanged.Add(propertyInfo,
        new EventHandler<ElementPropertyChangedEventArgs>
             (AlbumTitleAdjuster));

      /*
      // Alternatively, you can set one handler for
      // all properties of a class.
      // Your handler has to determine which property changed.
      DomainClassInfo classInfo = this.Store.DomainDataDirectory
           .FindDomainClass(typeof(Album));
      this.Store.EventManagerDirectory
          .ElementPropertyChanged.Add(classInfo,
        new EventHandler<ElementPropertyChangedEventArgs>
             (AlbumTitleAdjuster));
       */
      return base.LoadView();
    }

// Undoable adjustment after a property is changed.
// Method can be static since no local access.
private static void AlbumTitleAdjuster(object sender,
         ElementPropertyChangedEventArgs e)
{
  Album album = e.ModelElement as Album;
  Store store = album.Store;

  // We mustn't update the store in an Undo:
  if (store.InUndoRedoOrRollback
      || store.InSerializationTransaction)
      return;

  if (e.DomainProperty.Id == Album.TitleDomainPropertyId)
  {
    string newValue = (string)e.NewValue;
    string lowerCase = newValue.ToLowerInvariant();
    if (!newValue.Equals(lowerCase))
    {
      using (Transaction t = store.TransactionManager
            .BeginTransaction("adjust album title"))
      {
        album.Title = lowerCase;
        t.Commit();
      } // Beware! This could trigger the event again.
    }
  }
  // else other properties of this class.
}
```

If you write an event that updates the store:

- Use `store.InUndoRedoOrRollback` to avoid making changes to model elements in Undo. The transaction manager will set everything in the store back to its original state.

- Use `store.InSerializationTransaction` to avoid making changes while the model is being loaded from file.

- Your changes will cause further events to be triggered. Make sure that you avoid an infinite loop.

## Store Event types

Each event type corresponds to a collection in Store.EventManagerDirectory. You can add or remove event handlers at any time, but it is usual to add them when the document is loaded.

|`EventManagerDirectory` Property name|Executed when|
|-|-|
|ElementAdded|An instance of a domain class, domain relationship, shape, connector or diagram is created.|
|ElementDeleted|A model element has been removed from the store's element directory and is no longer the source or target of any relationship. The element is not actually deleted from memory, but is retained in case of a future Undo.|
|ElementEventsBegun|Invoked at the end of an outer transaction.|
|ElementEventsEnded|Invoked when all other events have been processed.|
|ElementMoved|A model element has been moved from one store partition to another.<br /><br /> This is not related to the location of a shape on the diagram.|
|ElementPropertyChanged|The value of a domain property has changed. This is executed only if the old and new values are unequal.|
|RolePlayerChanged|One of the two roles (ends) of a relationship references a new element.|
|RolePlayerOrderChanged|In a role with multiplicity greater than 1, the sequence of links has changed.|
|TransactionBeginning||
|TransactionCommitted||
|TransactionRolledBack||

## Related content

- [Responding to and Propagating Changes](../modeling/responding-to-and-propagating-changes.md)
- [Sample code: Circuit Diagrams](https://code.msdn.microsoft.com/Visualization-Modeling-SDK-763778e8)

[!INCLUDE[modeling_sdk_info](includes/modeling_sdk_info.md)]
