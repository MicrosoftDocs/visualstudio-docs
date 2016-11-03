        static int Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 f = new Form1();
            Application.Run(f);
            if (!f.accepted)
                return -1;
            else
                return 0;
        }