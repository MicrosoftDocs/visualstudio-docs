---
title: Finding and claiming product keys in Visual Studio subscriptions | Microsoft Docs
author: evanwindom
ms.author: amast
manager: shve
ms.assetid: da8df006-4896-4ff9-b487-698d78deabc3
ms.date: 10/13/2021
ms.topic: conceptual
description:  Learn how to find, claim and export product keys in Visual Studio subscriptions
---

# Finding and claiming product keys in Visual Studio subscriptions
This article explains how to locate, claim, and export product keys from https://my.visualstudio.com/productkeys.  For more information about activating a product with a key, retail and volume license versions of keys, and daily product key claim limits, visit the [product keys overview](product-keys.md).

## Locating and claiming product keys
You must be signed in to your Visual Studio subscription to view your product keys. Individual product keys are found by selecting the blue **Get Key** link for a particular product on the [Downloads](https://my.visualstudio.com/downloads) page as shown below.  All keys are also available in aggregate on the [Product Keys](https://my.visualstudio.com/productkeys?wt.mc_id=o~msft~docs) page. When multiple keys exist for a single product, notes will be displayed on the Notes column for the download to assist you in identifying which key should be used.
> [!div class="mx-imgBorder"]
> ![Get Key from Downloads Page](_img/product-keys/download-get-key.png "Select Get key on the information page for any download to get a key for that product.")

Some products bundle multiple editions of the product into a single download. In these cases, the product key entered determines which edition of the product is installed.
Some keys are provided automatically, such as “static” keys, which you can use as many times as needed because activation is not required. Other keys must be claimed by selecting the **Get Key** link for the product.

Various key types are available, depending on the product.

### Product key types

|    Key Type           |    Description                                                                                                                                                                                                           |
|-------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|    Not Applicable                    |    No key is needed to install this product.                                                       |
|    Retail                     |    Retail keys allow multiple   activations and are used for retail builds of the product. In many cases, 10   activations are allowed per key, though often more are allowed on the same   machine.                                                       |
|    Multiple Activation        |    A Multiple   Activation Key (MAK) enables you to activate multiple installations of a   product with the same key. MAKs are  used with Volume Licensing   versions of products. Typically, only one MAK key is provided per   subscription.    |
|    Static Activation   Key    |    Static activation   keys are provided for products that do not require activation. They can be   used for any number of installations.                                                                                                                  |
|    Custom Key                 |    Custom keys provide   special actions or information to activate or install the product.                                                                                                                                                                |
|    VA 1.0                     |    Multiple   activation keys, similar to a MAK.                                                                                                                                                                                                 |
|    OEM Key                    |    Original   Equipment Manufacturer keys that allow multiple activations.                                                                                                                                                                       |
|    DreamSpark Retail   Key    |    Retail keys for DreamSpark allow one activation. DreamSpark Retail keys are   issued in batches and are primarily intended for student consumption.                                                                                     |
|    DreamSpark Lab Key         |    Lab use keys    for DreamSpark programs that allow multiple activations. DreamSpark Lab   Keys are intended for use in university computer lab scenarios.                                                                                       |
|    DreamSpark MAK Key         |    MAK keys   for DreamSpark program customers.                                                                                                                                                                                                  |
|

You can claim a key from the download page for the product, or you can search for the key you need on the [Product Keys](https://my.visualstudio.com/productkeys) page.

### Claiming product keys
Only subscribers with active subscriptions can download products and claim product keys.  You can export your claimed keys from the [Product Keys](https://my.visualstudio.com/productkeys) page while your subscription is active.

To claim a product key:
1. Sign in to your Visual Studio subscription.  You must be signed in to download products or claim product keys.
2. Select the [Product Keys](https://my.visualstudio.com/productkeys?wt.mc_id=o~msft~docs) tab.
3. Product keys are listed alphabetically by the name of the product.  You can either scroll down to the name of the desired product, or search for it using the search bar at the top of the page.
> [!div class="mx-imgBorder"]
> ![Search for Product Key](_img/product-keys/search-keys.png "Scroll to the desired product, or use the search box to quickly locate any product.")
   
In this example, we’ve used the search bar to locate a product key for Visual Studio Enterprise 2019.
As you can see, there are several versions listed.  One key each has already been claimed for Visual Studio Enterprise 2019 versions 16.0 and 16.1.  Additional keys of different types are still available for both versions. Notice that you can record a brief note about claimed keys in the **Notes** column.  You can use this  with the date in the **Claimed** column to keep track of the keys you’ve claimed.  You might, for example, make notes when you activate an installation of the product using the key.

### Exporting your claimed keys
You can export a list of the keys you have claimed.  This includes a large selection of static and other keys that are automatically marked as “claimed” for you.

> [!IMPORTANT]
> If your subscription expires, you will no longer be able to claim new keys or export your claimed keys.

To export your keys, select the **Export all keys** link at the far right of the Product Keys page.  An .xml file entitled KeysExport.xml will be created, and you can choose to open or save the file.  You will need to open the file with an application capable of handling .xml files.  For example, you can open the file as a read-only workbook in Excel.

## Resources
- [Visual Studio subscriptions support](https://aka.ms/vssubscriberhelp)

## See also
- [Visual Studio documentation](/visualstudio/)
- [Azure DevOps documentation](/azure/devops/)
- [Azure documentation](/azure/)
- [Microsoft 365 documentation](/microsoft-365/)

## Next steps
When you're ready to download software and use keys, visit https://my.visualstudio.com/downloads.  For more information about downloading software, see the [downloading overview](download-software.md).