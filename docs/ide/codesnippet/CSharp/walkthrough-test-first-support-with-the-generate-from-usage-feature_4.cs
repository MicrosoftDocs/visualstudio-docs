    public class Automobile
    {
        public string Model { get; set; }
        public int TopSpeed { get; set; }

        public Automobile(string model, int topSpeed)
        {
            this.Model = model;
            this.TopSpeed = topSpeed;
        }

        public Automobile()
        {
            // TODO: Complete member initialization
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public bool IsRunning { get; set; }
    }