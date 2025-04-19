---
title: Customize captions for data-bound controls in .NET Framework applications
description: Customize how Visual Studio creates captions for data-bound controls in .NET Framework applications. Modify the smart captioning behavior of the Data Sources window. Turn off smart captioning.
ms.date: 11/03/2017
ms.topic: how-to
helpviewer_keywords:
- Label captions, Data Sources window
- smart captions
- captions, data-bound
- Data Sources Window, label captions
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Customize how Visual Studio creates captions for data-bound controls in .NET Framework applications

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

When you drag items from the [Data Sources window](add-new-data-sources.md#work-with-data-sources-and-windows-forms) onto a designer, a special consideration comes into play: the column names in the caption labels are reformatted into a more readable string when two or more words are found to be concatenated together.

You can customize the way in which these labels are created by setting the **SmartCaptionExpression**, **SmartCaptionReplacement**, and **SmartCaptionSuffix** values in the **HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\16.0\Data Designers** registry key.

> [!NOTE]
> This registry key does not exist until you create it.

Smart captioning is controlled by the regular expression entered into the value of the **SmartCaptionExpression** value. Adding the **Data Designers** registry key overrides the default regular expression that controls caption labels. For more information about regular expressions, see [Using regular expressions in Visual Studio](../ide/using-regular-expressions-in-visual-studio.md).

The following table describes the registry values that control caption labels.

|Registry item|Description|
|-------------------|-----------------|
|**SmartCaptionExpression**|The regular expression you use to match your patterns.|
|**SmartCaptionReplacement**|The format to display any groups matched in the **SmartCaptionExpression**.|
|**SmartCaptionSuffix**|An optional string to append to the end of the caption.|

The following table lists the internal default settings for these registry values.

|Registry item|Default value|Explanation|
|-------------------|-------------------|-----------------|
|**SmartCaptionExpression**|`(\\p{Ll})(\\p{Lu})|_+`|Matches a lowercase character followed by an uppercase character or an underscore.|
|**SmartCaptionReplacement**|**$1 $2**|The **$1** represents any characters matched in the first parentheses of the expression, and the **$2** represents any characters matched in the second parentheses. The replacement is the first match, a space, and then the second match.|
|**SmartCaptionSuffix**|**:**|Represents a character appended to the returned string. For example, if the caption is `Company Name`, the suffix makes it `Company Name:`|

> [!CAUTION]
> Be very careful when doing anything in the Registry Editor. Back up the registry before editing it. If you use the Registry Editor incorrectly, you can cause serious problems that might require you to reinstall your operating system. Microsoft does not guarantee that problems that you cause by using the Registry Editor incorrectly can be resolved. Use the Registry Editor at your own risk.
>
> For information about backing up, editing, and restoring the registry, see [Windows registry information for advanced users](https://support.microsoft.com/help/256986/windows-registry-information-for-advanced-users).

## Modify the smart captioning behavior of the Data Sources window

1. Open a command window by clicking **Start** and then **Run**.

2. Type `regedit` in the **Run** dialog box, and click **OK**.

3. Expand the **HKEY_CURRENT_USER** > **Software** > **Microsoft** > **VisualStudio** node.

4. Right-click the **16.0** node, and create a new **Key** named `Data Designers`.

5. Right-click the **Data Designers** node, and create three new string values:

    - `SmartCaptionExpression`
    - `SmartCaptionReplacement`
    - `SmartCaptionSuffix`

6. Right-click the **SmartCaptionExpression** value, and select **Modify**.

7. Enter the regular expression you want the **Data Sources** window to use.

8. Right-click the **SmartCaptionReplacement** value, and select **Modify**.

9. Enter the replacement string formatted the way you want to display the patterns matched in your regular expression.

10. Right-click the **SmartCaptionSuffix** value, and select **Modify**.

11. Enter any characters you want to appear at the end of the caption.

    The next time you drag items from the **Data Sources** window, the caption labels are created using the new registry values provided.

## Turn off the smart captioning feature

1. Open a command window by clicking **Start** and then **Run**.

2. Type `regedit` in the **Run** dialog box, and click **OK**.

3. Expand the **HKEY_CURRENT_USER** > **Software** > **Microsoft** > **VisualStudio** node.

4. Right-click the **16.0** node, and create a new **Key** named `Data Designers`.

5. Right-click the **Data Designers** node, and create three new string values:

    - `SmartCaptionExpression`
    - `SmartCaptionReplacement`
    - `SmartCaptionSuffix`

6. Right-click the **SmartCaptionExpression** item, and select **Modify**.

7. Enter `(.*)` for the value. This will match the entire string.

8. Right-click the **SmartCaptionReplacement** item, and select **Modify**.

9. Enter `$1` for the value. This replaces the string with the matched value, which is the entire string so that it will remain unchanged.

    The next time you drag items from the **Data Sources** window, the caption labels are created with unmodified captions.

## Related content

- [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)
