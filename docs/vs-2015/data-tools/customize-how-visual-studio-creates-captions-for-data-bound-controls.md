---
title: "Customize how Visual Studio 2015 creates captions for data-bound controls | Microsoft Docs"
titleSuffix: ""
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords:
  - "Label captions, Data Sources window"
  - "smart captions"
  - "captions, data-bound"
  - "Data Sources Window, label captions"
ms.assetid: 6d4d15f8-4d78-42fd-af64-779ae98d62c8
caps.latest.revision: 15
author: jillre
ms.author: jillfra
manager: jillfra
---
# Customize how Visual Studio creates captions for data-bound controls
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When you drag items from the [Data Sources Window](https://msdn.microsoft.com/library/0d20f699-cc95-45b3-8ecb-c7edf1f67992) onto the Windows Forms Designer, a special consideration comes into play: the column names in the caption labels are reformatted into a more readable string when two or more words are found to be concatenated together. You can customize the way in which these labels are created, by setting the **SmartCaptionExpression**, **SmartCaptionReplacement**, and **SmartCaptionSuffix** values in the **HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\10.0\Data Designers** registry key.

> [!NOTE]
> This registry key does not exist until you create it.

 Smart captioning is controlled by the regular expression entered into the value of the **SmartCaptionExpression** value. Adding the **Data Designers** registry key overrides the default regular expression that controls caption labels. For more information about regular expressions, see [Using Regular Expressions in Visual Studio](../ide/using-regular-expressions-in-visual-studio.md).

 The following table describes the registry values that control caption labels.

|Registry item|Description|
|-------------------|-----------------|
|**SmartCaptionExpression**|The regular expression used to match your patterns.|
|**SmartCaptionReplacement**|The format to display any groups matched in the **SmartCaptionExpression**.|
|**SmartCaptionSuffix**|An optional string to append to the end of the caption.|

 The following table lists the internal default settings for these registry values.

|Registry item|Default value|Explanation|
|-------------------|-------------------|-----------------|
|**SmartCaptionExpression**|(\\\p{Ll})(\\\p{Lu})&#124;_+|Matches a lowercase character followed by an uppercase character or an underscore.|
|**SmartCaptionReplacement**|$1 $2|The $1 represents any characters matched in the first parentheses of the expression, and the $2 represents any characters matched in the second parentheses. The replacement is the first match, a space, and then the second match.|
|**SmartCaptionSuffix**|:|Represents a character appended to the returned string. For example, if the caption is `Company Name`, the suffix makes it `Company Name:`|

> [!CAUTION]
> You should be very careful when doing anything in the Registry Editor. Back up the registry before editing it. If you use the Registry Editor incorrectly, you can cause serious problems that may require you to reinstall your operating system. Microsoft does not guarantee that problems that you cause by using the Registry Editor incorrectly can be resolved. Use the Registry Editor at your own risk.
>
> The following KnowledgeBase article contains instructions for backing up, editing, and restoring the registry: [Description of the Microsoft Windows registry](http://support.microsoft.com/default.aspx?scid=kb;en-us;256986) (http://support.microsoft.com/default.aspx?scid=kb;en-us;256986)

### To modify the smart captioning behavior of the Data Sources window

1. Open a command window by clicking **Start** and then **Run**.

2. Type `regedit` in the **Run** dialog box, and click **OK**.

3. Expand the **HKEY_CURRENT_USER** node.

4. Expand the **Software** node.

5. Expand the **Microsoft** node.

6. Expand the **VisualStudio** node.

7. Right-click the **10.0** node, and create a new **Key** named `Data Designers`.

8. Right-click the **Data Designers** node, and create a new **String Value** named `SmartCaptionExpression`.

9. Right-click the **Data Designers** node, and create a new **String Value** named `SmartCaptionReplacement`.

10. Right-click the **Data Designers** node, and create a new **String Value** named `SmartCaptionSuffix`.

11. Right-click the **SmartCaptionExpression** item, and select **Modify**.

12. Enter the regular expression you want the **Data Sources** window to use.

13. Right-click the **SmartCaptionReplacement** item, and select **Modify**.

14. Enter the replacement string formatted the way you want to display the patterns matched in your regular expression.

15. Right-click the **SmartCaptionSuffix** item, and select **Modify**.

16. Enter any characters you want to appear at the end of the caption.

     The next time you drag items from the **Data Sources** window, the caption labels are created using the new registry values provided.

### To turn off the smart captioning feature

1. Open a command window by clicking **Start** and then **Run**.

2. Type `regedit` in the **Run** dialog box, and click **OK**.

3. Expand the **HKEY_CURRENT_USER** node.

4. Expand the **Software** node.

5. Expand the **Microsoft** node.

6. Expand the **VisualStudio** node.

7. Right-click the **10.0** node, and create a new **Key** named `Data Designers`.

8. Right-click the **Data Designers** node, and create a new **String Value** named `SmartCaptionExpression`.

9. Right-click the **Data Designers** node, and create a new **String Value** named `SmartCaptionReplacement`.

10. Right-click the **Data Designers** node, and create a new **String Value** named `SmartCaptionSuffix`.

11. Right-click the **SmartCaptionExpression** item, and select **Modify**.

12. Enter `(.*)` for the value. This will match the entire string.

13. Right-click the **SmartCaptionReplacement** item, and select **Modify**.

14. Enter `$1` for the value. This replaces the string with the matched value, which is the entire string so that it will remain unchanged.

     The next time you drag items from the **Data Sources** window, the caption labels are created with unmodified captions.

## See Also
 [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)
