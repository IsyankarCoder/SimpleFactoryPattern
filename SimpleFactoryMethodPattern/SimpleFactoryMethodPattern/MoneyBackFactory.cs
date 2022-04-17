namespace FactoryClasses{
     public class MoneyBackFactory
      :CreditCardFactory{
          public MoneyBackFactory(){

          }
 protected override ICreditCard MakeProduct()
        {
           ICreditCard product =new Titanium();
           return product;
        }
        
      }

}