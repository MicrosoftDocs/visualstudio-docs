---
title: "Intl.NumberFormat Object (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
f1_keywords: 
  - "NumberFormat"
dev_langs: 
  - "JavaScript"
  - "DHTML"
ms.assetid: 820bc90f-f1e7-457a-b90d-487dfc3a736d
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Intl.NumberFormat Object (JavaScript)
Provides locale-specific number formatting.  
  
## Syntax  
  
```  
numberFormatObj = new Intl.NumberFormat([locales][, options])  
```  
  
#### Parameters  
 `numberFormatObj`  
 Required. The variable name to assign the `NumberFormat` object to.  
  
 `locales`  
 Optional. An array of locale strings that contain one or more language or locale tags. If you include more than one locale string, list them in descending order of priority so that the first entry is the preferred locale. If you omit this parameter, the default locale of the JavaScript runtime is used. See the Remarks section for more information.  
  
 `options`  
 Optional. An object that contains one or more properties that specify number formatting options. See the Remarks section for details.  
  
## Remarks  
 The `locales` parameter must conform to [BCP 47](http://tools.ietf.org/html/rfc5646) language or locale tags such as "en-US" and "zh-CN". The tag may include language, region, country, and variant. For examples of language tags, see [Appendix A](http://tools.ietf.org/html/rfc5646#appendix-A) of BCP 47. For `NumberFormat`, you may add the **-u** subtag followed by -nu to specify a numbering system extension:  
  
 "*language*-*region*-u-nu-*numberingsystem*"  
  
 where *numberingsystem* may be one of the following: arab, arabext, bali, beng, deva, fullwide, gujr, guru, hanidec, khmr, knda, laoo, latn, limb, mylm, mong, mymr, orya, tamldec, telu, thai, tibt.  
  
 The `options` parameter may include the following properties:  
  
|Property|Description|Possible values|Default value|  
|--------------|-----------------|---------------------|-------------------|  
|`localeMatcher`|Specifies the locale-matching algorithm to use.|"lookup", "best fit"|"best fit"|  
|`style`|Specifies the number format style.|"decimal", "percent", "currency"|"decimal"|  
|`currency`|Specifies the ISO 4217 currency value as an alphabetic code. If the `style` is set to "currency", this value is required.|See the ISO [currency and funds code list](http://www.currency-iso.org/en/home/tables/table-a1.html).|undefined|  
|`currencyDisplay`|Specifies whether to display the currency as an ISO 4217 alphabetic currency code, a localized currency symbol, or a localized currency name. This value is used only if `style` is set to "currency".|"code", "symbol", "name"|"symbol"|  
|`useGrouping`|Specifies whether a grouping separator should be used.|true, false|`true`.|  
|`minimumIntegerDigits`|Specifies the minimum number of integral digits to use.|1 to 21.|21|  
|`minimumFractionDigits`|. Specifies the minimum number of fractional digits to be used.|0 to 20.|0|  
|`maximumFractionDigits`|Specifies the maximum number of fractional digits to be used.|This value can range from `minimumFractionDigits` to 20.|20.|  
|`minimumSignificantDigits`|Specifies the minimum number of fractional digits to be shown.|This value can range from 1 to 21.|1|  
|`maximumSignificantDigits`|Specifies the maximum number of fractional digits to be shown.|This value can range from `minimumSignificantDigits` to 21.|21|  
  
## Properties  
 The following table lists the properties of the `NumberFormat` object.  
  
|||  
|-|-|  
|Property|Description|  
|[constructor](../../javascript/reference/constructor-property-intl-numberformat.md)|Specifies the function that creates a number formatter object.|  
|[format](../../javascript/reference/format-property-intl-numberformat.md)|Returns a function that formats a number by using the number formatter settings.|  
|[prototype](../../javascript/reference/prototype-property-intl-numberformat.md)|Returns a reference to the prototype for a number formatter.|  
  
## Methods  
 The following table lists the methods of the `NumberFormat` object.  
  
|||  
|-|-|  
|Method|Description|  
|[resolvedOptions](../../javascript/reference/resolvedoptions-method-intl-numberformat.md)|Returns an object that contains the properties and values of the number formatter object.|  
  
## Example  
 The following example creates a `NumberFormat` object for the en-US locale with the specified formatting options.  
  
```javascript  
var nf = new Intl.NumberFormat(["en-US"], {  
    style: "currency",  
    currency: "CNY",  
    currencyDisplay: "symbol",  
    maximumFractionDigit: 1  
});  
  
if (console && console.log) {  
    console.log(nf.format(100)); // Returns ¥100.00  
}  
```  
  
## Example  
 The following examples show the result from using several different locales and options.  
  
```javascript  
var number = 123456789;  
var options1 = { style: "percent" };  
var options2 = { style: "currency", currency: "INR" };  
  
if (console && console.log) {  
    console.log(new Intl.NumberFormat("en-US").format(number));  
    // Returns 123,456,789  
    console.log(new Intl.NumberFormat("ja-JP").format(number));  
    // Returns 123,456,789  
    console.log(new Intl.NumberFormat("ar-SA", options1).format(number));  
    // Returns ١٢,٣٤٥,٦٧٨,٩٠٠ %  
    console.log(new Intl.NumberFormat("hi-IN", options2).format(number));  
    // Returns ₹ 12,34,56,789.00  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]  
  
## See Also  
 [toLocaleString (Number)](../../javascript/reference/tolocalestring-number.md)   
 [Intl.Collator Object](../../javascript/reference/intl-collator-object-javascript.md)   
 [Intl.DateTimeFormat Object](../../javascript/reference/intl-datetimeformat-object-javascript.md)