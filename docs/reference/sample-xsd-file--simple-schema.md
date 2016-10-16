---
title: "Sample XSD File: Simple Schema"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: f7e1dde1-b4f6-4371-add4-935b68ec77d7
caps.latest.revision: 4
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Sample XSD File: Simple Schema
The following XSD file is used in various examples in the XSD Schema Designer documentation. This file is a simple purchase order schema.  
  
```xml  
<xsd:schema xmlns:xsd="http://www.w3.org/2001/XMLSchema"   
           xmlns:tns="http://tempuri.org/PurchaseOrderSchema.xsd"   
           targetNamespace="http://tempuri.org/PurchaseOrderSchema.xsd"   
           elementFormDefault="qualified">  
 <xsd:element name="PurchaseOrder" type="tns:PurchaseOrderType"/>  
 <xsd:complexType name="PurchaseOrderType">  
  <xsd:sequence>  
   <xsd:element name="ShipTo" type="tns:USAddress" maxOccurs="2"/>  
   <xsd:element name="BillTo" type="tns:USAddress"/>  
  </xsd:sequence>  
  <xsd:attribute name="OrderDate" type="xsd:date"/>  
 </xsd:complexType>  
  
 <xsd:complexType name="USAddress">  
  <xsd:sequence>  
   <xsd:element name="name"   type="xsd:string"/>  
   <xsd:element name="street" type="xsd:string"/>  
   <xsd:element name="city"   type="xsd:string"/>  
   <xsd:element name="state"  type="xsd:string"/>  
   <xsd:element name="zip"    type="xsd:integer"/>  
  </xsd:sequence>  
  <xsd:attribute name="country" type="xsd:NMTOKEN" fixed="US"/>  
 </xsd:complexType>  
</xsd:schema>  
```