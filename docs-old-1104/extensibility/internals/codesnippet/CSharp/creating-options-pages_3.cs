        private void ShowHelloWorld(object sender, EventArgs e)
        {
            var hw = GetDialogPage(typeof(HelloWorldOptions)) 
                as HelloWorldOptions;
            if (hw.HelloWorld == true)
            {
                MessageBox.Show("Hello World!");
            }
            else MessageBox.Show("Goodbye.");
        }