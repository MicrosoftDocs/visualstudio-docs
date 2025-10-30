---
title: XML editor Schema Cache
description: Learn about the schema cache provided by the XML Editor that includes standard XML schemas used for IntelliSense and XML document validation.
ms.date: 11/04/2016
ms.topic: article
author: dzsquared
ms.author: drskwier
manager: mijacobs
ms.subservice: xml-tools
---
# Schema cache

The XML editor provides a schema cache located in the *%VSInstallDir%\xml\Schemas* directory. The schema cache is global to all users on your computer and includes standard XML schemas that are used for IntelliSense and XML document validation.

The XML editor can also find schemas located in the solution, schemas specified in the **Schemas** field of the document **Properties** window, and schemas identified by the `xsi:schemaLocation` and `xsi:noNamespaceSchemaLocation` attributes.

The following table describes the schemas that are installed with the XML editor.

| Filename | Description |
|-| - |
| *catalog.xsd* | Schema for XML editor schema catalog files. For information about schema catalogs, see below. |
| *DotNetConfig.xsd* | Schema for Web.Config files, `http://schemas.microsoft.com/.NETConfiguration/v2.0`. |
| *msbuild.xsd* | Schema for the MSBuild make files, `http://schemas.microsoft.com/developer/msbuild/2003`. |
| *msdata.xsd* | Schema for the XSD annotations added by the <xref:System.Data.DataSet> class, "urn:schemas-microsoft-com:xml-msdata". |
| *msxsl.xsd* | Schema for Microsoft XSLT script block extensions, urn:schemas-microsoft-com:xslt. |
| *SnippetFormat.xsd* | Schema for the code snippet XML files. For examples, see *%VSInstallDir%\VC#\Expansions*. |
| *Soap1.1.xsd* | Schema for Simple Object Access Protocol (SOAP) 1.1, `http://schemas.xmlsoap.org/soap/envelope/`. |
| *Soap1.2.xsd* | Schema for Simple Object Access Protocol 1.2. |
| *SiteMapSchema.xsd* | Schema for ASP.NET sitemap XML file, `http://schemas.microsoft.com/AspNet/SiteMap-File-1.0`. |
| *wsdl.xsd* | Schema for Web Service Description Language, `http://schemas.xmlsoap.org/wsdl/`. |
| *xenc.xsd* | Schema for XML Encryption, `http://www.w3.org/2000/09/xmldsig#`. |
| *xhtml.xsd* | Schema for XHTML `http://www.w3.org/1999/xhtml`. |
| *xlink.xsd* | Schema for XLink1.0, `http://www.w3.org/1999/xlink`. |
| *xml.xsd* | Schema describing xml:space and xml:lang attributes, `http://www.w3.org/XML/1998/namespace`. |
| *xmlsig.xsd* | Schema for XML Digital Signatures, `http://www.w3.org/2000/09/xmldsig#`. |
| *xsdschema.xsd* | Schema describing XSD itself, `http://www.w3.org/2001/XMLSchema`. |
| *xslt.xsd* | Schema for XML Transforms, `http://www.w3.org/1999/XSL/Transform`. |

## Update schemas in the cache

The editor loads the schema cache directory when the XML editor package is loaded and watches for any changes while running. If a schema has been added, it is automatically loaded into an in-memory index of known schemas. If a schema has been removed, it is automatically removed from the in-memory index. If a schema has been updated, it automatically invalidates the in-memory cache of this schema.

> [!NOTE]
> Because the schema cache directory is global to your computer, you should only add schemas here that are standard and useful to all the Visual Studio projects that may be created on your computer.

The XML editor also supports any number of schema catalog files in the schema cache directory. Schema catalogs can point to other locations for schemas that you always want the editor to know about. The *catalog.xsd* file defines the format for the catalog file and is included in the schema cache directory. The *catalog.xml* file is the default catalog and it contains links to other schemas in the *%VSInstallDir%*. The following is a sampling of the *catalog.xml* file:

```xml
<SchemaCatalog xmlns="http://schemas.microsoft.com/xsd/catalog">
  <Schema href="%VSInstallDir%/help/schemas/Favorites.xsd" targetNamespace="urn:Favorites-Schema"/>
  <Schema href="%VSInstallDir%/help/schemas/Links.xsd" targetNamespace="urn:Links-Schema"/>
  <Schema href="%VSInstallDir%/help/schemas/MyHelp.xsd" targetNamespace="urn:VSHelp-Schema"/>
</SchemaCatalog>
```

The `href` attribute can be any file path or http URL pointing to the schema. The file path can be relative to the catalog document. The following variables, delimited by %%, are recognized by the editor and expanded in the path:

- VSInstallDir

- System

- ProgramFiles

- Programs

- CommonProgramFiles

- ApplicationData

- CommonApplicationData

- LCID

The catalog document can include a `Catalog` element, which points to other catalogs. You can use the `Catalog` element to point to a central catalog shared by your team or company, or an online catalog shared with your business partners. The `href` attribute is the file path or http URL for the other catalogs. The following is an example of the `Catalog` element:

```xml
<Catalog href="file://c:/xcbl/xcblCatalog.xml"/>
```

The catalog can also control how schemas are associated with XML documents using the special `Association` element. This element associates schemas that have no target namespace with a particular file extension, which can be useful because the XML editor does not do any auto-association of schemas that do not have a `targetNamespace` attribute. In the following example the `Association` element associates the dotNetConfig schema with all files that have the "config" file extension:

```xml
<Association extension="config" schema="%VSInstallDir%/xml/schemas/dotNetConfig.xsd"/>
```

## Localized schemas

In many cases the *catalog.xml* file does not contain entries for localized schemas. You can add additional entries to the *catalog.xml* file that point to the localized schema directory.

In the following example a new `Schema` element has been created that uses the %LCID% variable to point to the localized schema.

```xml
<Schema href="%InstallRoot%/Common7/IDE/Policy/Schemas/%LCID%/TDLSchema.xsd"
  targetNamespace="http://www.microsoft.com/schema/EnterpriseTemplates/TDLSchema"/>
```

## Change the location of the schema cache

You can customize the location for the schema cache using the **Miscellaneous** options page. If you have a directory of favorite schemas, the editor can be configured to use those schemas instead.

> [!NOTE]
> This change affects only the current Visual Studio user.

### To change the schema cache location

1. From the **Tools** menu, select **Options**.

2. Expand **Text Editor**, expand **XML**, and then click **Miscellaneous**.

3. Click the **Browse** button on the **Schemas** field.

4. Select the folder for the schema cache and click **OK**.

### To add another directory of common schemas

1. Edit the *catalog.xml* file in the XML editor schema cache directory.

2. Add a new `<Catalog href="..."/>` element that points to the directory of additional schemas.

3. Save your changes.

   The catalog is automatically reloaded.

## Related content

- [XML editor](../xml-tools/xml-editor.md)
