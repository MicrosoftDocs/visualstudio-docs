//<Snippet9>
using System;
using System.Collections.Generic;
using Microsoft.SharePoint;
using Microsoft.VisualStudio.SharePoint.Commands;

namespace Contoso.SharePoint.Commands
{
    internal class Commands
    {
        [SharePointCommand(CommandIds.ValidateSite)]
        private bool ValidateSite(ISharePointCommandContext context, Uri url)
        {
            using (SPSite site = new SPSite(url.AbsoluteUri))
            {
                string webUrl = DetermineWebUrl(url.AbsolutePath, site.ServerRelativeUrl);
                if (webUrl != null)
                {
                    using (SPWeb web = site.OpenWeb(webUrl, true))
                    {
                        return web.Exists;
                    }
                }
            }

            return false;
        }

        // For simplicity, this command does not check to make sure the provided Uri is valid. 
        // Use the ValidateSite command to verify that the Uri is valid first.
        [SharePointCommand(CommandIds.GetFieldTypes)]
        private string[] GetFieldTypes(ISharePointCommandContext context, Uri url)
        {
            List<string> columnDefinitions = new List<string>();
            using (SPSite site = new SPSite(url.AbsoluteUri))
            {
                string webUrl = DetermineWebUrl(url.AbsolutePath, site.ServerRelativeUrl);
                using (SPWeb web = site.OpenWeb(webUrl, true))
                {
                    foreach (SPFieldTypeDefinition columnDefinition in web.FieldTypeDefinitionCollection)
                    {
                        columnDefinitions.Add(columnDefinition.TypeName);
                    }

                    // SharePoint commands cannot serialize List<string>, so return an array.
                    return columnDefinitions.ToArray();
                }
            }
        }

        private string DetermineWebUrl(string serverRelativeInputUrl, string serverRelativeSiteUrl)
        {
            // Make sure both URLs have a trailing slash.
            serverRelativeInputUrl = EnsureTrailingSlash(serverRelativeInputUrl);
            serverRelativeSiteUrl = EnsureTrailingSlash(serverRelativeSiteUrl);

            string webUrl = null;
            bool isSubString = serverRelativeInputUrl.StartsWith(serverRelativeSiteUrl, StringComparison.OrdinalIgnoreCase);

            if (isSubString)
            {
                // The Web URL cannot have escaped characters.
                webUrl = Uri.UnescapeDataString(serverRelativeInputUrl.Substring(serverRelativeSiteUrl.Length));
            }

            return webUrl;
        }

        private string EnsureTrailingSlash(string url)
        {
            if (!String.IsNullOrEmpty(url)
                && url[url.Length - 1] != '/')
            {
                url += '/';
            }
            return url;
        }
    }
}
//</Snippet9>
