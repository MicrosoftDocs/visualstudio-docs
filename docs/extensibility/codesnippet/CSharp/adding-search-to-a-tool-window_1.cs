    public partial class MyControl : UserControl
    {
        public TextBox SearchResultsTextBox { get; set; }
        public string SearchContent { get; set; }

        public MyControl()
        {
            InitializeComponent();

            this.SearchResultsTextBox = resultsTextBox;
            this.SearchContent = BuildContent();

            this.SearchResultsTextBox.Text = this.SearchContent;
        }

        private string BuildContent()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1 go");
            sb.AppendLine("2 good");
            sb.AppendLine("3 Go");
            sb.AppendLine("4 Good");
            sb.AppendLine("5 goodbye");
            sb.AppendLine("6 Goodbye");

            return sb.ToString();
        }
    }