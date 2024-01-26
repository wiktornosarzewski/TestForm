namespace WindowsForms
{
    internal class Animal
    {
        public string Name { get; private set; }

        public Animal(string Name)
        {
            this.Name=Name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}