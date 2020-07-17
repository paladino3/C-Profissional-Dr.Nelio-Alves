namespace Ex52
{
    class Product // tipo referencia
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }



        //IMPLEMENTACAO PARA FALAR QUANDO UM PRODUTO E IGUAL A OUTRO, SEJA POR HASHCOD OU EQUALS
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Product))
            {
                return false;
            }

            Product other = obj as Product;

            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }


   
    }
}
