---
title: "How to: Customize the Code Analysis Dictionary"
ms.date: 11/04/2016
ms.topic: "conceptual"
helpviewer_keywords:
  - "code analysis dictionary"
  - "custom dictionary, code analysis"
  - "dictionary, code analysis"
ms.assetid: 667e3b4e-beff-48be-b3d1-376e1716a895
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Customize the Code Analysis Dictionary

Code Analysis uses a built-in dictionary to check identifiers in your code for errors in spelling, grammatical case, and other naming conventions of the .NET design guidelines. You can create a custom dictionary Xml file to add, remove, or modify terms, abbreviations, and acronyms to the built-in dictionary.

For example, suppose your code contained a class named **DoorKnokker**. Code Analysis would identify the name as a compound of two words: **door** and **knokker**. It would then raise a warning that **knokker** was not spelled correctly. To force code analysis to recognize the spelling, you can add the term **knokker** to the custom dictionary.

## To create a custom dictionary

Create a file that is named **CustomDictionary.xml**.

Define your custom words by using the following XML structure:

```xml
<Dictionary>
      <Words>
         <Unrecognized>
            <Word>knokker</Word>
         </Unrecognized>
         <Recognized>
            <Word></Word>
         </Recognized>
         <Deprecated>
            <Term PreferredAlternate=""></Term>
         </Deprecated>
         <Compound>
            <Term CompoundAlternate=""></Term>
         </Compound>
         <DiscreteExceptions>
            <Term></Term>
         </DiscreteExceptions>
      </Words>
      <Acronyms>
         <CasingExceptions>
            <Acronym></Acronym>
         </CasingExceptions>
      </Acronyms>
   </Dictionary>
```

## Custom Dictionary Elements

You can modify the behavior of the Code Analysis dictionary by adding terms as the inner text of the following elements in the custom dictionary:

- [Dictionary/Words/Recognized/Word](../code-quality/how-to-customize-the-code-analysis-dictionary.md#BKMK_DictionaryWordsRecognizedWord)

- [Dictionary/Words/Unrecognized/Word](../code-quality/how-to-customize-the-code-analysis-dictionary.md#BKMK_DictionaryWordsUnrecognizedWord)

- [Dictionary/Words/Deprecated/Term[@PreferredAlternate]](../code-quality/how-to-customize-the-code-analysis-dictionary.md#BKMK_DictionaryWordsDeprecatedTermPreferredAlternate)

- [Dictionary/Words/Compound/Term[@CompoundAlternate]](../code-quality/how-to-customize-the-code-analysis-dictionary.md#BKMK_DictionaryWordsCompoundTermCompoundAlternate)

- [Dictionary/Words/DiscreteExceptions/Term](../code-quality/how-to-customize-the-code-analysis-dictionary.md#BKMK_DictionaryWordsDiscreteExceptionsTerm)

- [Dictionary/Acronyms/CasingExceptions/Acronym](../code-quality/how-to-customize-the-code-analysis-dictionary.md#BKMK_DictionaryAcronymsCasingExceptionsAcronym)

### <a name="BKMK_DictionaryWordsRecognizedWord"></a> Dictionary/Words/Recognized/Word

To include a term in the list of terms that code analysis identifies as correctly spelled, add the term as the inner text of a Dictionary/Words/Recognized/Word element. Terms in Dictionary/Words/Recognized/Word elements are not case-sensitive.

**Example**

```xml
<Dictionary>
      <Words>
         <Recognized>
            <Word>knokker</Word>
            ...
         </Recognized>
         ...
      </Words>
      ...
</Dictionary>
```

Terms in Dictionary/Words/Recognized nodes are applied to the following code analysis rules:

- [CA1701: Resource string compound words should be cased correctly](../code-quality/ca1701.md)

- [CA1702: Compound words should be cased correctly](../code-quality/ca1702.md)

- [CA1703: Resource strings should be spelled correctly](../code-quality/ca1703.md)

- [CA1704: Identifiers should be spelled correctly](../code-quality/ca1704.md)

- [CA1709: Identifiers should be cased correctly](../code-quality/ca1709.md)

- [CA1726: Use preferred terms](../code-quality/ca1726.md)

- [CA2204: Literals should be spelled correctly](../code-quality/ca2204.md)

### <a name="BKMK_DictionaryWordsUnrecognizedWord"></a> Dictionary/Words/Unrecognized/Word

To exclude a term from the list of terms that code analysis identifies as correctly spelled, add the term to exclude as the inner text of a Dictionary/Words/Unrecognized/Word element. Terms in Dictionary/Words/Unrecognized/Word elements are not case-sensitive.

**Example**

```xml
<Dictionary>
      <Words>
         <Unrecognized>
            <Word>meth</Word>
            ...
         </Unrecognized>
         ...
      </Words>
      ...
</Dictionary>
```

Terms in the Dictionary/Words/Unrecognized node are applied to the following code analysis rules:

- [CA1701: Resource string compound words should be cased correctly](../code-quality/ca1701.md)

- [CA1702: Compound words should be cased correctly](../code-quality/ca1702.md)

- [CA1703: Resource strings should be spelled correctly](../code-quality/ca1703.md)

- [CA1704: Identifiers should be spelled correctly](../code-quality/ca1704.md)

- [CA1709: Identifiers should be cased correctly](../code-quality/ca1709.md)

- [CA1726: Use preferred terms](../code-quality/ca1726.md)

- [CA2204: Literals should be spelled correctly](../code-quality/ca2204.md)

### <a name="BKMK_DictionaryWordsDeprecatedTermPreferredAlternate"></a> Dictionary/Words/Deprecated/Term[@PreferredAlternate]

To include a term in the list of terms that code analysis identifies as deprecated, add the term as the inner text of a Dictionary/Words/Deprecated/Term element. A deprecated term is a word that is spelled correctly but should not be used.

To include a suggested alternate term in the warning, specify the alternate in the PreferredAlternate attribute of the Term element. You can leave the attribute value empty if you do not want to suggest an alternate.

- The deprecated term in Dictionary/Words/Deprecated/Term element is not case-sensitive.

- The PreferredAlternate attribute value is case-sensitive. Use Pascal case for compound alternates.

**Example**

```xml
<Dictionary>
      <Words>
         <Deprecated>
            <Term PreferredAlternate="LogOn">login</Term>
            ...
         </Deprecated>
         ...
      </Words>
      ...
</Dictionary>
```

Terms in the Dictionary/Words/Deprecated node are applied to the following code analysis rules:

- [CA1701: Resource string compound words should be cased correctly](../code-quality/ca1701.md)

- [CA1702: Compound words should be cased correctly](../code-quality/ca1702.md)

- [CA1703: Resource strings should be spelled correctly](../code-quality/ca1703.md)

- [CA1704: Identifiers should be spelled correctly](../code-quality/ca1704.md)

- [CA1726: Use preferred terms](../code-quality/ca1726.md)

### <a name="BKMK_DictionaryWordsCompoundTermCompoundAlternate"></a> Dictionary/Words/Compound/Term[@CompoundAlternate]

The built-in dictionary identifies some terms as single, discrete terms rather than a compound term. To include a term in the list of terms that code analysis identifies as a compound word and to specify the correct casing of the term, add the term as the inner text of a Dictionary/Words/Compound/Term element. In the CompoundAlternate attribute of the Term element, specify the individual words that make up the compound term by capitalizing the first letter of the individual words (Pascal case). Note that the term specified in the inner text is automatically added to the Dictionary/Words/DiscreteExceptions list.

- The compound term in Dictionary/Words/Compound/Term element is not case-sensitive.

- The CompoundAlternate attribute value is case-sensitive. Use Pascal case for compound alternates.

**Example**

```xml
<Dictionary>
      <Words>
         <Compound>
            <Term CompoundAlternate="CheckBox">checkbox</Term>
            ...
         </Compound>
         ...
      </Words>
      ...
</Dictionary>
```

Terms in the Dictionary/Words/Compound node are applied to the following code analysis rules:

- [CA1701: Resource string compound words should be cased correctly](../code-quality/ca1701.md)

- [CA1702: Compound words should be cased correctly](../code-quality/ca1702.md)

- [CA1703: Resource strings should be spelled correctly](../code-quality/ca1703.md)

- [CA1704: Identifiers should be spelled correctly](../code-quality/ca1704.md)

### <a name="BKMK_DictionaryWordsDiscreteExceptionsTerm"></a> Dictionary/Words/DiscreteExceptions/Term

To exclude a term in the list of terms that code analysis identifies as a single, discrete word when the term is checked by the casing rules for compound words, add the term as the inner text of a Dictionary/Words/DiscreteExceptions/Term element. The term in Dictionary/Words/DiscreteExceptions/Term element is not case-sensitive.

**Example**

```xml
<Dictionary>
      <Words>
         <DiscreteExceptions>
            <Term>checkbox</Term>
            ...
         </DiscreteExceptions>
         ...
      </Words>
      ...
</Dictionary>
```

Terms in the Dictionary/Words/DiscreteExceptions node are applied to the following code analysis rules:

- [CA1701: Resource string compound words should be cased correctly](../code-quality/ca1701.md)

- [CA1702: Compound words should be cased correctly](../code-quality/ca1702.md)

### <a name="BKMK_DictionaryAcronymsCasingExceptionsAcronym"></a> Dictionary/Acronyms/CasingExceptions/Acronym

To include an acronym in the list of terms that code analysis identifies as correctly spelled and to indicate how the acronym when the term is checked by the casing rules for compound words, add the term as the inner text of a Dictionary/Acronyms/CasingExceptions/Acronym element. The acronym in the Dictionary/Acronyms/CasingExceptions/Acronym element is case-sensitive.

**Example**

```xml
<Dictionary>
      <Acronyms>
         <CasingExceptions>
            <Acronym>NESW</Acronym>   <!-- North East South West -->
            ...
         </CasingExceptions>
         ...
      </Acronyms>
      ...
</Dictionary>
```

Terms in the Dictionary/Acronyms/CasingExceptions node are applied to the following code analysis rules:

- [CA1709: Identifiers should be cased correctly](../code-quality/ca1709.md)

## <a name="BKMK_ToApplyACustomDictionaryToAProject"></a> To apply a custom dictionary to a project

1. In **Solution Explorer**, use one of the following procedures:

2. To add a dictionary to a single project, right-click the project name and then click **Add Existing Item**. Specify the file in the **Add Existing Item** dialog box.

3. To add a dictionary that is shared among two or more projects, locate the file to share in the **Add Existing Item** dialog box, click the down arrow on the **Add** button and then click **Add As Link**.

4. In **Solution Explorer**, right-click the **CustomDictionary.xml** file name and click **Properties**.

5. From the **Build Action** list, select **CodeAnalysisDictionary**.

6. From the **Copy to Output Directory** list, select **Do not copy**.
