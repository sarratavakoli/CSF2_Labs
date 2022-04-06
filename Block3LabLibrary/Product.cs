namespace Block3LabLibrary
{
    public class Product
    {
        //TODO: Create the data type class for Product
        //as detailed in the Lab Sets section.

        //FIELDS
        private int _id;
        private string _name;
        private int _modelNumber;
        private string _description;
        private decimal _price;

        //PROPERTIES
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int ModelNumber
        {
            get { return _modelNumber; }
            set { _modelNumber = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        //CONSTRUCTORS
        public Product(int id, string name, int modelNumber, string description, decimal price)
        {
            ID = id;
            Name = name;
            ModelNumber = modelNumber;
            Description = description;
            Price = price;
        }

        //METHODS
        public override string ToString()
        {
            return string.Format($"ID: {ID}\nName: {Name}\nModel #: {ModelNumber}\n" +
                $"Description: {Description}\nPrice: {Price:c}");
        }
    }
}