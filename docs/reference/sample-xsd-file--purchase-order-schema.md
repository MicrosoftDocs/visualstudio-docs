---
title: "Sample XSD File: Purchase Order Schema"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: f92b63b5-ec61-43b5-ae1e-63432a7a7e30
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
# Sample XSD File: Purchase Order Schema
The following XSD file is used in various examples in the XSD Schema Designer documentation. This file is a purchase order schema.  
  
```xml  
<xsd:schema xmlns:xsd="http://www.w3.org/2001/XMLSchema"   
          xmlns:tns="http://tempuri.org/PurchaseOrderSchema.xsd"   
          targetNamespace="http://tempuri.org/PurchaseOrderSchema.xsd"   
          elementFormDefault="qualified">  
  <xsd:element name='comment' type='xsd:string'/>  
  
  <xsd:element name='purchaseOrder' type='tns:PurchaseOrderType'/>  
  
  <xsd:complexType name='USAddress'>  
    <xsd:annotation>  
      <xsd:documentation>  
        Purchase order schema for Example.Microsoft.com.  
      </xsd:documentation>  
    </xsd:annotation>  
    <xsd:sequence>  
      <xsd:element name='name'   type='xsd:string'/>  
      <xsd:element name='street' type='xsd:string'/>  
      <xsd:element name='city'   type='xsd:string'/>  
      <xsd:element name='state'  type='xsd:string'/>  
      <xsd:element name='zip'    type='xsd:decimal'/>  
    </xsd:sequence>  
    <xsd:attribute name='country' type='xsd:NMTOKEN' fixed='US'/>  
  </xsd:complexType>  
  
  <xsd:simpleType name='SKU'>  
    <xsd:restriction base='xsd:string'>  
      <xsd:pattern value='\d{3}\w{3}'/>  
    </xsd:restriction>  
  </xsd:simpleType>  
  
  <xsd:complexType name='Items'>  
    <xsd:sequence>  
      <xsd:element name='item' minOccurs='0' maxOccurs='unbounded'>  
        <xsd:complexType>  
          <xsd:sequence>  
            <xsd:element name='productName' type='xsd:string'/>  
            <xsd:element name='quantity'>  
              <xsd:simpleType>  
                <xsd:restriction base='xsd:positiveInteger'>  
                  <xsd:minInclusive value='1'/>  
                  <xsd:maxExclusive value='100'/>  
                </xsd:restriction>  
              </xsd:simpleType>  
            </xsd:element>  
            <xsd:element name='USPrice'  type='xsd:decimal'/>  
            <xsd:element ref='tns:comment'/>  
            <xsd:element name='shipDate' type='xsd:date' minOccurs='0'/>  
          </xsd:sequence>  
          <xsd:attribute name='partNum' type='tns:SKU'/>  
        </xsd:complexType>  
      </xsd:element>  
    </xsd:sequence>  
  </xsd:complexType>  
  
  <xsd:complexType name='PurchaseOrderType'>  
    <xsd:sequence>  
      <xsd:element name='shipTo' type='tns:USAddress'/>  
      <xsd:element name='billTo' type='tns:USAddress'/>  
      <xsd:element ref='tns:comment' minOccurs='0'/>  
      <xsd:element name='items'  type='tns:Items'/>  
    </xsd:sequence>  
    <xsd:attribute name='orderDate' type='xsd:date'/>  
    <xsd:attribute name='confirmDate' type='xsd:date' use='required'/>  
  </xsd:complexType>  
</xsd:schema>  
```