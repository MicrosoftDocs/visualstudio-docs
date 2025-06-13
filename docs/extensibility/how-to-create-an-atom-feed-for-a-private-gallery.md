---
title: 'Create an Atom Feed for a Private Gallery'
description: You can create an Atom (RSS) feed to an intranet location that contains extensions and add the feed to Extensions and Updates as a private gallery.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- Atom feed, VSIX private galleries
- VSIX private galleries, Atom feed
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Create an Atom feed for a private gallery

You can create an Atom (RSS) feed to an intranet location that contains extensions and add the feed to **Extensions and Updates** as a private gallery. For more information, see [Private galleries](../extensibility/private-galleries.md).

## Create an Atom feed
 To create an Atom feed as a private gallery, you first gather your extensions (*.vsix* files) into a folder. You can organize them into subfolders if you want. You will also need the following resources:

- An *atom.xml* file that makes the extensions available as a private gallery. For information about how to connect the *atom.xml* file to **Extensions and Updates**, see [Private galleries](../extensibility/private-galleries.md).

- A folder that contains any image files that were extracted from the extensions (for example, screen shots). The *atom.xml* file contains relative links to these images so that they are available in **Extensions and Updates**.

  For example, assume that you have gathered the following two extensions into a folder:

- *Template_Wizard_239.vsix*, which is an empty VSIX project template.

- *SelectionHighlight.vsix*, which is a tool to highlight all instances of a selected word.

  The contents of the *atom.xml* file would resemble the following example:

```xml
<?xml version="1.0" encoding="UTF-8"?>
<feed xmlns="http://www.w3.org/2005/Atom">
  <title type="text" />
  <id>uuid:bcecded5-97c8-4d24-96f1-7d9e16652433;id=1</id>
  <updated>2011-04-14T21:25:48Z</updated>
  <entry>
    <id>SelectionHighlight..a14874d2-8199-4a60-af8a-11d6447813aa</id>
    <title type="text">Highlight all occurrences of selected word</title>
    <summary type="text">This extends the editor to highlight ....</summary>
    <published>2011-04-14T14:24:51-07:00</published>
    <updated>2011-04-14T14:24:22-07:00</updated>
    <author>
      <name>Microsoft</name>
    </author>
    <link rel="icon" href="VSIXImages/SelectionHighlight..a14874d2-8199-4a60-af8a-11d6447813aa_Icon_SelectionHighlightIcon.jpg" />
    <link rel="previewimage" href="VSIXImages/SelectionHighlight..a14874d2-8199-4a60-af8a-11d6447813aa_PreviewImage_SelectionHighlight.jpg" />
    <content type="application/octet-stream" src="SelectionHighlight.vsix" />
    <Vsix xmlns="http://schemas.microsoft.com/developer/vsx-syndication-schema/2010" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
      <Id>SelectionHighlight..a14874d2-8199-4a60-af8a-11d6447813aa</Id>
      <Version>1.31</Version>
      <References />
      <Rating xsi:nil="true" />
      <RatingCount xsi:nil="true" />
      <DownloadCount xsi:nil="true" />
    </Vsix>
  </entry>
  <entry>
    <id>Template_Wizard_239.Microsoft.3b38a7e3-5cbc-4389-a92a-d82tyc2ed592</id>
    ...
  </entry>
</feed>
```

 Notice that the two link tags refer to screen shots in the generated folder of images.

## Related content
- [Private galleries](../extensibility/private-galleries.md)
