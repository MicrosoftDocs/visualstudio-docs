---
title: "Customizing Deletion Behavior | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
f1_keywords:
  - "vs.dsltools.dsldesigner.deletebehavior"
helpviewer_keywords:
  - "Domain-Specific Language, deletion"
ms.assetid: c6bf088d-52c6-4817-af45-ddae745bb5a9
caps.latest.revision: 25
author: jillre
ms.author: jillfra
manager: jillfra
---
# Customizing Deletion Behavior
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Deleting an element usually causes related elements to be deleted also. All relationships connected to it, and any child elements are deleted. This behavior is named *delete propagation*. You can customize delete propagation, for example to arrange that additional related elements are deleted. By writing program code, you can make delete propagation depend on the state of the model. You can also cause other changes to occur in response to a deletion.

 This topic includes the following sections:

- [Default Deletion Behavior](#default)

- [Setting the Propagate Delete option of a role](#property)

- [Overriding the Delete Closure](#closure) – Use this technique where deletion might lead to deletion of neighboring elements.

- [Using OnDeleting and OnDeleted](#ondeleting) – Use these methods where the response could include other actions such as updating a value either inside or outside the store.

- [Deletion Rules](#rules) – Use rules to propagate updates of any kind within the store, where one change might lead to others.

- [Deletion Events](#rules) – Use store events to propagate updates outside the store, for example to other [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] documents.

- [UnMerge](#unmerge) – use the UnMerge operation to undo the merge operation that attached a child element to its parent.

## <a name="default"></a> Default Deletion Behavior
 By default, the following rules govern delete propagation:

- If an element is deleted, all embedded elements are also deleted. The embedded elements are those that are the targets of embedding relationships for which this element is the source. For example, if there is an embedding relationship from **Album** to **Song**, then when a particular Album is deleted, all its Songs will also be deleted.

     By contrast, deleting a song does not delete the album.

- By default, deletion does not propagate along reference relationships. If there is a reference relationship **ArtistPlaysOnAlbum** from **Album** to **Artist**, deleting an album does not delete any related artist, and deleting an artist does not delete any album.

     However, deletion does propagate along some built-in relationships. For example, when a model element is deleted, its shape on the diagram is also deleted. The element and shape are related by the `PresentationViewsSubject` reference relationship.

- Every relationship that is connected to the element, either at the source or target role, is deleted. The role property of the element at the opposite role no longer contains the deleted element.

## <a name="property"></a> Setting the Propagate Delete option of a role
 You can cause deletion to propagate along a reference relationship, or from an embedded child to its parent.

#### To set delete propagation

1. On the DSL Definition diagram, select the *role* to which you want propagation to delete. The role is represented by the line on the left or right of a domain relationship box.

    For example, if you want to specify that whenever an Album is deleted, the related Artists are also deleted, then select the role connected to the domain class Artist.

2. In the Properties window, set the **Propagates Delete** property.

3. Press F5 and verify that:

   - When an instance of this relationship is deleted, the element at the selected role will also be deleted.

   - When an element at the opposite role is deleted, instances of this relationship will be deleted, and the related elements at this role will be deleted.

   You can also see the **Propagates Delete** option in the **DSL Details** window. Select a domain class and, in the DSL Details window, open the **Delete Behavior** page by clicking the button at the side of the window. The **Propagate** option is shown for the opposite role of each relationship. The **Delete Style** column indicates whether the **Propagate** option is at its default setting, but it does not have any separate effect.

## Delete Propagation by using program code
 The options in the DSL Definition file only let you choose whether deletion propagates to an immediate neighbor. To implement a more complex scheme of delete propagation, you can write program code.

> [!NOTE]
> To add program code to your DSL definition, create a separate code file in the **Dsl** project and write partial definitions to augment the classes in the Generated Code folder. For more information, see [Writing Code to Customise a Domain-Specific Language](../modeling/writing-code-to-customise-a-domain-specific-language.md).

## <a name="closure"></a> Defining a Delete Closure
 The deletion operation uses the class _YourModel_**DeleteClosure** to determine which elements to delete, given an initial selection. It calls `ShouldVisitRelationship()` and `ShouldVisitRolePlayer()` repeatedly, walking the graph of relationships. You can override these methods. ShouldVisitRolePlayer is provided with the identity of a link and the element at one of the link’s roles. It should return one of the following values:

- **VisitorFilterResult.Yes**– The element should be deleted and the walker should proceed to try the element’s other links.

- **VisitorFilterResult.DoNotCare** – The element should not be deleted unless another query replies that it should be deleted.

- **VisitorFilterResult.Never** – The element must not be deleted, even if another query answers **Yes**, and the walker should not try the element’s other links.

```
// When a musician is deleted, delete their albums with a low rating.
// Override methods in <YourDsl>DeleteClosure in DomainModel.cs
partial class MusicLibDeleteClosure
{
  public override VisitorFilterResult ShouldVisitRolePlayer
    (ElementWalker walker, ModelElement sourceElement, ElementLink elementLink,
    DomainRoleInfo targetDomainRole, ModelElement targetRolePlayer)
  {
    ArtistAppearsInAlbum link = elementLink as ArtistAppearsInAlbum;
    if (link != null
       && targetDomainRole.RolePlayer.Id == Album.DomainClassId)
    {
      // Count other unvisited links to the Album of this link.
      if (ArtistAppearsInAlbum.GetLinksToArtists(link.Album)
              .Where(linkAlbumArtist =>
                     linkAlbumArtist != link &&
                     !walker.Visited(linkAlbumArtist))
              .Count() == 0)
      {
        // Should delete this role player:
        return VisitorFilterResult.Yes;
      }
      else
        // Don’t delete unless another relationship deletes it:
        return VisitorFilterResult.DoNotCare;
    }
    else
    {
      // Test for and respond to other relationships and roles here.

      // Not the relationship or role we’re interested in.
      return base.ShouldVisitRolePlayer(walker, sourceElement,
             elementLink, targetDomainRole, targetRolePlayer);
    }
  }
}

```

 The closure technique ensures that the set of elements and links to be deleted is determined before deletion begins. The walker also combines the results of your closure with those from other parts of the model.

 However, the technique assumes that deletion affects only its neighbors in the graph of relationships: you cannot use this method to delete an element in another part of the model. You cannot use it if you want to add elements or make other changes in response to a deletion.

## <a name="ondeleting"></a> Using OnDeleting and OnDeleted
 You can override `OnDeleting()` or `OnDeleted()` either in a domain class, or in a domain relationship.

1. <xref:Microsoft.VisualStudio.Modeling.ModelElement.OnDeleting%2A> is called when an element is about to be deleted, but before its relationships have been disconnected. It is still navigable to and from other elements, and is still in `store.ElementDirectory`.

    If several elements are deleted at the same time, OnDeleting is called for all of them before performing the deletions.

    `IsDeleting` is true.

2. <xref:Microsoft.VisualStudio.Modeling.ModelElement.OnDeleted%2A> is called when the element has been deleted. It remains in the CLR heap so that an Undo can be performed if required, but it is unlinked from other elements and removed from `store.ElementDirectory`. For relationships, the roles still reference the old role players.`IsDeleted` is true.

3. OnDeleting and OnDeleted are called when the user invokes Undo after a creating an element, and when an earlier deletion is repeated in Redo. Use `this.Store.InUndoRedoOrRollback` to avoid updating store elements in these cases. For more information, see [How to: Use Transactions to Update the Model](../modeling/how-to-use-transactions-to-update-the-model.md).

   For example, the following code deletes an Album when its last child Song is deleted:

```

// Delete the parent Album when the last Song is deleted.
// Override methods in the embedding relationship between Album and Song:
partial class AlbumHasSongs
{
  protected override void OnDeleted()
  {
    base.OnDeleted();
    // Don't perform in-store actions in undo:
    if (this.Store.InUndoRedoOrRollback) return;
    // Relationship source and target still work:
    // Don't bother if source is already on its way out:
    if (!this.Album.IsDeleting && !this.Album.IsDeleted)
    {
      if (this.Album.Songs.Count == 0)
      {
        this.Album.Delete();
} } } }

```

 It is often more useful to trigger from the deletion of the relationship than the role element, because this works both when the element is deleted, and when the relationship itself is deleted. However, for a reference relationship, you might want to propagate deletion when a related element is deleted, but not when the relationship itself is deleted. This example deletes an Album when its last contributing Artist is deleted, but it does not respond if the relationships are deleted:

```
using System.Linq; ...
// Assumes a many-many reference relationship
// between Artist and Album.
partial class Artist
{
  protected override void OnDeleting()
  {
    base.OnDeleting();
    if (this.Store.InUndoRedoOrRollback) return;
    List<Album> toDelete = new List<Album>();
    foreach (Album album in this.Albums)
    {
      if (album.Artists.Where(artist => !artist.IsDeleting)
                        .Count() == 0)
      {
        toDelete.Add(album);
      }
    }
    foreach (Album album in toDelete)
    {
      album.Delete();
} } }

```

 When you perform <xref:Microsoft.VisualStudio.Modeling.ModelElement.Delete%2A> on an element, OnDeleting and OnDeleted will be called. These methods are always performed inline – that is, immediately before and after the actual deletion. If your code deletes two or more elements, OnDeleting and OnDeleted will be called in alternation on all of them in turn.

## <a name="rules"></a> Deletion Rules and Events
 As an alternative  to  OnDelete handlers, you can define deletion rules and deletion events.

1. **Deleting** and **Delete** rules are triggered only in a transaction, and not in an Undo or Redo. You can set them to be queued to execute at the end of the transaction in which the deletion is performed. Deleting rules are always executed before any Deleted rules that are in the queue.

     Use rules to propagate changes that affect only elements in the store, including relationships, diagram elements and their properties. Typically, a Deleting rule is used to propagate deletion, and a Delete rule is used to create replacement elements and relationships.

     For more information, see [Rules Propagate Changes Within the Model](../modeling/rules-propagate-changes-within-the-model.md).

2. **Deleted** store event is invoked at the end of a transaction, and is called after an undo or redo. It can therefore be used to propagate deletions to objects outside the store such as files, database entries or other objects in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].

     For more information, see [Event Handlers Propagate Changes Outside the Model](../modeling/event-handlers-propagate-changes-outside-the-model.md).

    > [!WARNING]
    > When an element has been deleted, you can access its domain property values, but you cannot navigate relationship links. However, if you set a deleted event on a relationship, you can also access the two elements that were its role players. Therefore, if you want to respond to the deletion of a model element but want to access an element to which it was linked, set a delete event on the relationship instead of the model element’s domain class.

### Example Deletion Rules

```
[RuleOn(typeof(Album), FireTime = TimeToFire.TopLevelCommit)]
internal class AlbumDeletingRule : DeletingRule
{
  public override void ElementDeleting(ElementDeletingEventArgs e)
  {
    base.ElementDeleting(e);
    // ...perform tasks to propagate imminent deletion
  }
}
[RuleOn(typeof(Album), FireTime = TimeToFire.TopLevelCommit)]
internal class AlbumDeletedRule : DeleteRule
{
  public override void ElementDeleted(ElementDeletedEventArgs e)
  {
    base.ElementDeleted(e);
    // ...perform tasks such as creating new elements
  }
}

// The rule must be registered:
public partial class MusicLibDomainModel
{
  protected override Type[] GetCustomDomainModelTypes()
  {
    List<Type> types = new List<Type>(base.GetCustomDomainModelTypes());
    types.Add(typeof(AlbumDeletingRule));
    types.Add(typeof(AlbumDeletedRule));
    // If you add more rules, list them here.
    return types.ToArray();
  }
}

```

### Example Deleted Event

```
partial class NestedShapesSampleDocData
{
  protected override void OnDocumentLoaded(EventArgs e)
  {
    base.OnDocumentLoaded(e);
    DomainRelationshipInfo commentRelationship =
          this.Store.DomainDataDirectory
          .FindDomainRelationship(typeof(CommentsReferenceComponents));

    this.Store.EventManagerDirectory.ElementDeleted.Add(commentRelationship,
      new EventHandler<ElementDeletedEventArgs>(CommentLinkDeleted));
  }

  private void CommentLinkDeleted (object sender, ElementDeletedEventArgs e)
  {
    CommentsReferenceComponents link = e.ModelElement as CommentsReferenceComponents;
    Comment comment = link.Comment;
    Component component = link.Subject;
    if (comment.IsDeleted)
    {
      // The link was deleted because the comment was deleted.
      System.Windows.Forms.MessageBox.Show("Removed comment on " + component.Name);
    }
    else
    {
      // It was just the link that was deleted - the comment itself remains.
      System.Windows.Forms.MessageBox.Show("Removed comment link to "
           + component.Name);
    }
  }
}

```

## <a name="unmerge"></a> UnMerge
 The operation that attaches a child element to its parent is called *merge*. It occurs when a new element or group of elements is created from the toolbox, or moved from another part of the model, or copied from the clipboard. As well as creating an embedding relationship between the parent and its new child, the merge operation can also set up additional relationships, create auxiliary elements, and set property values in the elements. The merge operation is encapsulated in an Element Merge Directive (EMD).

 An EMD also encapsulates the complementary *unmerge* or `MergeDisconnect` operation. If you have a cluster of elements that has been constructed by using a merge, it is recommended to use the associated unmerge to remove an element from it, if you want to leave the remaining elements in a consistent state. The unmerge operation will typically use the techniques described in the previous sections.

 For more information, see [Customizing Element Creation and Movement](../modeling/customizing-element-creation-and-movement.md).

## See Also
 [Customizing Copy Behavior](../modeling/customizing-copy-behavior.md)
 [Customizing Element Creation and Movement](../modeling/customizing-element-creation-and-movement.md)
 [Writing Code to Customise a Domain-Specific Language](../modeling/writing-code-to-customise-a-domain-specific-language.md)
