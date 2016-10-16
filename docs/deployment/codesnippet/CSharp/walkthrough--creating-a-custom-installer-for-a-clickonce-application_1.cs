        InPlaceHostingManager iphm = null;

        public void InstallApplication(string deployManifestUriStr)
        {
            try
            {
                Uri deploymentUri = new Uri(deployManifestUriStr);
                iphm = new InPlaceHostingManager(deploymentUri, false);
            }
            catch (UriFormatException uriEx)
            {
                MessageBox.Show("Cannot install the application: " + 
                    "The deployment manifest URL supplied is not a valid URL. " +
                    "Error: " + uriEx.Message);
                return;
            }
            catch (PlatformNotSupportedException platformEx)
            {
                MessageBox.Show("Cannot install the application: " + 
                    "This program requires Windows XP or higher. " +
                    "Error: " + platformEx.Message);
                return;
            }
            catch (ArgumentException argumentEx)
            {
                MessageBox.Show("Cannot install the application: " + 
                    "The deployment manifest URL supplied is not a valid URL. " +
                    "Error: " + argumentEx.Message);
                return;
            }

            iphm.GetManifestCompleted += new EventHandler<GetManifestCompletedEventArgs>(iphm_GetManifestCompleted);
            iphm.GetManifestAsync();
        }

        void iphm_GetManifestCompleted(object sender, GetManifestCompletedEventArgs e)
        {
            // Check for an error.
            if (e.Error != null)
            {
                // Cancel download and install.
                MessageBox.Show("Could not download manifest. Error: " + e.Error.Message);
                return;
            }

            // bool isFullTrust = CheckForFullTrust(e.ApplicationManifest);

            // Verify this application can be installed.
            try
            {
                // the true parameter allows InPlaceHostingManager
                // to grant the permissions requested in the applicaiton manifest.
                iphm.AssertApplicationRequirements(true) ; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while verifying the application. " +
                    "Error: " + ex.Message);
                return;
            }

            // Use the information from GetManifestCompleted() to confirm 
            // that the user wants to proceed.
            string appInfo = "Application Name: " + e.ProductName;
            appInfo += "\nVersion: " + e.Version;
            appInfo += "\nSupport/Help Requests: " + (e.SupportUri != null ?
                e.SupportUri.ToString() : "N/A");
            appInfo += "\n\nConfirmed that this application can run with its requested permissions.";
            // if (isFullTrust)
            // appInfo += "\n\nThis application requires full trust in order to run.";
            appInfo += "\n\nProceed with installation?";

            DialogResult dr = MessageBox.Show(appInfo, "Confirm Application Install",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            // Download the deployment manifest. 
            iphm.DownloadProgressChanged += new EventHandler<DownloadProgressChangedEventArgs>(iphm_DownloadProgressChanged);
            iphm.DownloadApplicationCompleted += new EventHandler<DownloadApplicationCompletedEventArgs>(iphm_DownloadApplicationCompleted);

            try
            {
                // Usually this shouldn't throw an exception unless AssertApplicationRequirements() failed, 
                // or you did not call that method before calling this one.
                iphm.DownloadApplicationAsync();
            }
            catch (Exception downloadEx)
            {
                MessageBox.Show("Cannot initiate download of application. Error: " +
                    downloadEx.Message);
                return;
            }
        }

        /*
        private bool CheckForFullTrust(XmlReader appManifest)
        {
            if (appManifest == null)
            {
                throw (new ArgumentNullException("appManifest cannot be null."));
            }

            XAttribute xaUnrestricted =
                XDocument.Load(appManifest)
                    .Element("{urn:schemas-microsoft-com:asm.v1}assembly")
                    .Element("{urn:schemas-microsoft-com:asm.v2}trustInfo")
                    .Element("{urn:schemas-microsoft-com:asm.v2}security")
                    .Element("{urn:schemas-microsoft-com:asm.v2}applicationRequestMinimum")
                    .Element("{urn:schemas-microsoft-com:asm.v2}PermissionSet")
                    .Attribute("Unrestricted"); // Attributes never have a namespace

            if (xaUnrestricted != null)
                if (xaUnrestricted.Value == "true")
                    return true;

            return false;
        }
        */

        void iphm_DownloadApplicationCompleted(object sender, DownloadApplicationCompletedEventArgs e)
        {
            // Check for an error.
            if (e.Error != null)
            {
                // Cancel download and install.
                MessageBox.Show("Could not download and install application. Error: " + e.Error.Message);
                return;
            }

            // Inform the user that their application is ready for use. 
            MessageBox.Show("Application installed! You may now run it from the Start menu.");
        }

        void iphm_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // you can show percentage of task completed using e.ProgressPercentage
        }