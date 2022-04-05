namespace StudentLib
{
    public class Vehicle
    {

        //fields
        private string _make;
        private string _model;
        private int _year;
        private float _weight;

        //properties
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        //constructors
        public Vehicle(string make, string model, int year, float weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
        }
        public Vehicle() { }

        //methods
        public override string ToString()
        {
            return string.Format(
                $"Vehicle\n" +
                $"{Year} {Make} {Model}\n" +
                $"Weight: {Weight:n2} pounds"
                );
        }
    }
}