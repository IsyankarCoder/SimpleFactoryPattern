namespace FactoryClasses{
    public class PlatinumFactory : CreditCardFactory
    {
        public PlatinumFactory()
        {
        }
        protected override ICreditCard MakeProduct()
        {
           ICreditCard product =new Platinum();
           return product;
        }
    }

}