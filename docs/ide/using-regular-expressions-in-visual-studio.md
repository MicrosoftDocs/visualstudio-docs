---
title: Use regular expressions and review examples
description: Explore some regular expression characters, operators, constructs, and pattern examples that you can use in Visual Studio.
ms.date: 9/4/2025
ms.topic: article
f1_keywords:
- vsregularexpressionhelp
- vs.regularexpressionhelp
- vs.wildcardsbuilder
- vs.netregularexpressionhelp
- vs.wildcards
helpviewer_keywords:
- regular expressions [Visual Studio]
- regular expressions
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# Use regular expressions in Visual Studio

Visual Studio uses [.NET regular expressions](/dotnet/standard/base-types/regular-expressions) to find and replace text.

## Regular expression syntax

The following table contains some regular expression characters, operators, constructs, and pattern examples. For a more complete reference, see [Regular expression language](/dotnet/standard/base-types/regular-expression-language-quick-reference).

|Purpose|Expression|Example|
|-------------|----------------|-------------|
|Match any single character (except a line break). For more information, see [Any character](/dotnet/standard/base-types/character-classes-in-regular-expressions#any-character-).|.|`a.o` matches "aro" in "around" and "abo" in "about" but not "acro" in "across"|
|Match zero or more occurrences of the preceding expression (match as many characters as possible). For more information, see [Match zero or more times](/dotnet/standard/base-types/quantifiers-in-regular-expressions#match-zero-or-more-times-).|*|`a*r` matches "r" in "rack", "ar" in "ark", and "aar" in "aardvark"|
|Match any character zero or more times.|.*|`c.*e` matches "cke" in "racket", "comme" in "comment", and "code" in "code"|
|Match one or more occurrences of the preceding expression (match as many characters as possible). For more information, see [Match one or more times](/dotnet/standard/base-types/quantifiers-in-regular-expressions#match-one-or-more-times-).|+|`e+d` matches "eed" in "feeder" and "ed" in "faded"|
|Match any character one or more times.|.+|`e.+e` matches "eede" in "feeder" but finds no matches in "feed"|
|Match zero or more occurrences of the preceding expression (match as few characters as possible). For more information, see [Match zero or more times (lazy match)](/dotnet/standard/base-types/quantifiers-in-regular-expressions#match-zero-or-more-times-lazy-match-).|*?|`\w*?d` matches "fad" and "ed" in "faded" but not the entire word "faded" due to the lazy match|
|Match one or more occurrences of the preceding expression (match as few characters as possible). For more information, see [Match one or more times (lazy match)](/dotnet/standard/base-types/quantifiers-in-regular-expressions#match-one-or-more-times-lazy-match-).|+?|`e\w+?` matches "ee" in "asleep" and "ed" in "faded" but finds no matches in "fade"|
|Anchor the match string to the [beginning of a line or string](/dotnet/standard/base-types/anchors-in-regular-expressions#start-of-string-or-line-)|^|`^car` matches the word "car" only when it appears at the beginning of a line|
|Anchor the match string to the [end of a line](/dotnet/standard/base-types/anchors-in-regular-expressions#end-of-string-or-line-)|\r?$|`car\r?$` matches "car" only when it appears at the end of a line|
|Anchor the match string to the end of the file|$|`car$` matches "car" only when it appears at the end of the file|
|Match any single character in a set|[abc]|`b[abc]` matches "ba", "bb", and "bc"|
|Match any character in a range of characters|[a-f]|`be[n-t]` matches "bet" in "between", "ben" in "beneath", and "bes" in "beside", but finds no matches in "below"|
|Capture and implicitly number the expression contained within parenthesis|()|`([a-z])X\1` matches "aXa" and "bXb", but not "aXb". "\1" refers to the first expression group "[a-z]". For more information, see [Capture groups and replacement patterns](#capture-groups-and-replacement-patterns). |
|Invalidate a match|(?!abc)|`real(?!ity)` matches "real" in "realty" and "really" but not in "reality." It also finds the second "real" (but not the first "real") in "realityreal".|
|Match any character that isn't in a given set of characters. For more information, see [Negative character group](/dotnet/standard/base-types/character-classes-in-regular-expressions#negative-character-group-).|[^abc]|`be[^n-t]` matches "bef" in "before", "beh" in "behind", and "bel" in "below", but finds no matches in "beneath"|
|Match either the expression before or the one after the symbol|&#124;|`(sponge|mud) bath` matches "sponge bath" and "mud bath"|
|[Escape the character](/dotnet/standard/base-types/character-escapes-in-regular-expressions) following the backslash| \\ |`\^` matches the character ^|
|Specify the number of occurrences of the preceding character or group. For more information, see [Match exactly n times](/dotnet/standard/base-types/quantifiers-in-regular-expressions#match-exactly-n-times-n).|{n}, where 'n' is the number of occurrences|`x(ab){2}x` matches "xababx"<br/>`x(ab){2,3}x` matches "xababx" and "xabababx" but not "xababababx"|
|[Match text in a Unicode category](/dotnet/standard/base-types/character-classes-in-regular-expressions#unicode-category-or-unicode-block-p). For more information about Unicode character classes, see [Unicode Standard 15.0 Character Properties](https://www.unicode.org/versions/Unicode15.0.0/ch04.pdf#G39).|\p{X}, where "X" is the Unicode number.|`\p{Lu}` matches "T" and "D" in "Thomas Doe"|
|[Match a word boundary](/dotnet/standard/base-types/anchors-in-regular-expressions#word-boundary-b)|\b (Outside a character class `\b` specifies a word boundary, and inside a character class `\b` specifies a backspace.)|`\bin` matches "in" in "inside" but finds no matches in "pinto"|
|Match a line break (that is, a carriage return followed by a new line, or a new line only)|\r?\n|`End\r?\nBegin` matches "End" and "Begin" only when "End" is the last string in a line and "Begin" is the first string in the next line|
|Match any [word character](/dotnet/standard/base-types/character-classes-in-regular-expressions#word-character-w)|\w|`a\wd` matches "add" and "a1d" but not "a d"|
|Match any [non-word character](/dotnet/standard/base-types/character-classes-in-regular-expressions#non-word-character-w)|\W|`a\Wd` matches "a d" but not "and"|
|Match any [whitespace character](/dotnet/standard/base-types/character-classes-in-regular-expressions#whitespace-character-s)|\s|`Public\sInterface` matches the phrase "Public Interface"|
|Match any [non-whitespace character](/dotnet/standard/base-types/character-classes-in-regular-expressions#non-whitespace-character-s)|\S|`\S+` matches "end", "A11",  or  "end?". |
|Match any [decimal digit character](/dotnet/standard/base-types/character-classes-in-regular-expressions#decimal-digit-character-d)|\d|`\d` matches "4" and "0" in "wd40"|
|Match any [non-digit character](/dotnet/standard/base-types/character-classes-in-regular-expressions#non-digit-character-d)|\D|`\D` matches "w" and "d" in "wd40"|

An example regular expression that combines some of the operators and constructs to match a hexadecimal number is `\b0[xX]([0-9a-fA-F]+)\b`. This expression matches "0xc67f" but not "0xc67g".

> [!TIP]
> In Windows operating systems, most lines end in "\r\n" (a carriage return followed by a new line). These characters aren't visible but are present in the editor and passed to the .NET regular expression service. When you deal with files from the web or from a non-Windows operating system, be sure to account for the possibility that they use new line only for a line break.

## Capture groups and replacement patterns

A capture group delineates a subexpression of a regular expression and captures a substring of an input string. You can use captured groups within the regular expression itself (for example, to look for a repeated word), or in a replacement pattern. For detailed information, see [Grouping constructs in regular expressions](/dotnet/standard/base-types/grouping-constructs-in-regular-expressions).

To create a numbered capture group, surround the subexpression with parentheses in the regular expression pattern. Captures are numbered automatically from left to right based on the position of the opening parenthesis in the regular expression. To access the captured group, consider the following examples:

- **Within the regular expression**: Use `\number`. For example, `\1` in the regular expression `(\w+)\s\1` references the first capture group `(\w+)`.

- **In a replacement pattern**: Use `$number`. For example, the grouped regular expression `(\d)([a-z])` defines two groups: the first group contains a single decimal digit, and the second group contains a single character between **a** and **z**. The expression finds four matches in the following string: **1a 2b 3c 4d**. The replacement string `z$1` references the first group only (`$1`), and converts the string to **z1 z2 z3 z4**.

The following image shows a regular expression `(\w+)\s\1` and a replacement string `$1`. Both the regular expression and the replacement pattern reference the first capture group that's automatically numbered 1. When you choose **Replace all** in the **Quick Replace** dialog box in Visual Studio, repeated words are removed from the text.

:::image type="content" source="media/numbered-capture-group.png" alt-text="Screenshot of Quick Replace showing a numbered capture group in Visual Studio.":::

> [!TIP]
> In the **Quick Replace** dialog box, make sure to select the **Use Regular Expressions** button, or press **Alt**+**E**.

### Named capture groups

Instead of relying on the automatic numbering of a capture group, you can give it a name. The syntax for a named capture group is `(?<name>subexpression)`.

Named capture groups, like numbered capture groups, can be used within the regular expression itself or in a replacement pattern. To access the named capture group, consider the following examples:

- **Within the regular expression**: Use `\k<name>`. For example, `\k<repeated>` in the regular expression `(?<repeated>\w+)\s\k<repeated>` references the capture group that's named `repeated` and whose subexpression is `\w+`.

- **In a replacement pattern**: Use `${name}`. For example, `${repeated}`.

The following image shows a regular expression `(?<repeated>\w+)\s\k<repeated>` and a replacement string `${repeated}`. Both the regular expression and the replacement pattern reference the capture group named `repeated`. When you choose **Replace all** in the **Quick Replace** dialog box in Visual Studio, repeated words are removed from the text.

:::image type="content" source="media/named-capture-group.png" alt-text="Screenshot of Quick Replace showing a named capture group in Visual Studio.":::

> [!TIP]
> Make sure to select the **Use Regular Expressions** button (or press **Alt**+**E**) in the **Quick Replace** dialog box.

For more information about named capture groups, see [Named matched subexpressions](/dotnet/standard/base-types/grouping-constructs-in-regular-expressions#named-matched-subexpressions). For more information about regular expressions that are used in replacement patterns, see [Substitutions in regular expressions](/dotnet/standard/base-types/substitutions-in-regular-expressions).

## Examples

| Pattern | Description |
| - | - |
| `int ([_A-Za-z][_A-Za-z0-9]*)` | Match single integer definitions. Identifiers begin with one uppercase or lowercase letter, followed by zero or more (indicated by `*`) letters or numbers. The identifier is captured as `$1` by the outer parentheses. |
| `(private\|internal\|public)*\s*([\w]+\s+)int\s+([_A-Za-z][_A-Za-z0-9]*)\s+=\s+[+-]+(\d)+` | Match C# integer declarations that are initialized to integer literals, capturing the various parts, including the access level, modifiers like `const` or `static`, the identifier, and the defined value. Note the use of `\s+` for at least one whitespace character, or `\s*` if whitespace might or might not occur. |
| `foreach\s*\(([\w\d]*)\s+([\w\d]*)\s+in\s+(.*)\)` | Match the opening line of a `foreach` loop. The literal parentheses  are escaped with backslash (`\`). The various groups are captured as `$1`, `$2`, and `$3` by the unescaped parentheses. |
| `#define\s+([_A-Za-z][_A-Za-z0-9]*)` | Matches `#define` definitions (without the value, if any). The defined token is stored in `$1`. |
| `#include\s+["<](.*)[">]` | Match includes in a C++ source file. |

## Related content

- [Quick reference: Regular expression language](/dotnet/standard/base-types/regular-expression-language-quick-reference)
- [Find and replace text](../ide/finding-and-replacing-text.md)
