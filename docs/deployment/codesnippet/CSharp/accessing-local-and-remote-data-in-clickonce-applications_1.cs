            if (ApplicationDeployment.IsNetworkDeployed)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(ApplicationDeployment.CurrentDeployment.DataDirectory + @"\CSV.txt"))
                    {
                        MessageBox.Show(sr.ReadToEnd());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file. Error message: " + ex.Message);
                }
            }