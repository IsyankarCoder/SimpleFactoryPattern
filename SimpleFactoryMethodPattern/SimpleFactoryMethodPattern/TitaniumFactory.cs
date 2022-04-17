namespace FactoryClasses{
    public class TitaniumFactory : CreditCardFactory
    {
        public TitaniumFactory()
        {
        }
        protected override ICreditCard MakeProduct()
        {
           ICreditCard product =new Titanium();
           return product;
        }
    }

}