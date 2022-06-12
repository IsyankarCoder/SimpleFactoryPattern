using System;
using ChainOfResponsibilityPatternClasses;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Atm atm =new Atm();
            Console.WriteLine("\n Requested Amount 4600");
            atm.WithDraw(4600);

            Console.WriteLine("\n Requested Amount 1900");
            atm.WithDraw(1900);

            Console.WriteLine("\n Requested Amount 600");
            atm.WithDraw(600);

              Console.WriteLine("\n Requested Amount 12680");
            atm.WithDraw(12680);
        }
    }
}

namespace ChainOfResponsibilityPatternClasses{
    public abstract class  Handler
    {
       public Handler rsHandler;   
       public void nextHandler(Handler rsHandler){
           this.rsHandler = rsHandler;
       }
       public Handler(){

       }

       public abstract void dispatchRs(long requestedAmount);
    }
    

    public  class TwoThousandHandler:Handler
    {
      public  override void dispatchRs(long requestedAmount){
             long numberofNotesToBeDispatched = requestedAmount/2000;
             if(numberofNotesToBeDispatched>0){
                if(numberofNotesToBeDispatched>1){
                   Console.WriteLine(numberofNotesToBeDispatched +"Two Thousand notes are dispacthed by TwoThousandHandler");
                }else{
                   Console.WriteLine(numberofNotesToBeDispatched +"Two Thousand note is dispacthed by TwoThousandHandler");
                }
             }

             long pendingAmountToBeProcessed = requestedAmount % 2000;
             if(pendingAmountToBeProcessed>0){
                 this.rsHandler.dispatchRs(pendingAmountToBeProcessed);
             }

        }

        public TwoThousandHandler(){

        }
         
    }

    public class FiveHundredHandler:Handler
    {
         public override void dispatchRs(long requestedAmount){
            long numberofNotesToBeDispatched = requestedAmount/500;
            if(numberofNotesToBeDispatched>0){
                if(numberofNotesToBeDispatched>1){
                   Console.WriteLine(numberofNotesToBeDispatched +"FiveHundred notes are dispacthed by FiveHundredHandler");
                }else{
                   Console.WriteLine(numberofNotesToBeDispatched +"FiveHundred notes are dispacthed by FiveHundredHandler");
                }
            }

            long pendingAmountToBeProcessed = requestedAmount%500;
            if(pendingAmountToBeProcessed>0)
            this.rsHandler.dispatchRs(pendingAmountToBeProcessed);
         }

         public FiveHundredHandler(){

         }
        
    }
    public class TwoHundredHandler:Handler
    {
         public override void dispatchRs(long requestedAmount){
            long numberofNotesToBeDispatched = requestedAmount/200;
            if(numberofNotesToBeDispatched>0){
                if(numberofNotesToBeDispatched>1){
                   Console.WriteLine(numberofNotesToBeDispatched +"TwoHundred notes are dispacthed by TwoHundredHandler");
                }else{
                   Console.WriteLine(numberofNotesToBeDispatched +"TwoHundred notes are dispacthed by TwoHundredHandler");
                }
            }

            long pendingAmountToBeProcessed = requestedAmount%200;
            if(pendingAmountToBeProcessed>0)
            this.rsHandler.dispatchRs(pendingAmountToBeProcessed);
         }

         public TwoHundredHandler(){

         }
        
    }

    public class  HundredHandler:Handler
    {
         public override void dispatchRs(long requestedAmount){
            long numberofNotesToBeDispatched = requestedAmount/100;
            if(numberofNotesToBeDispatched>0){
                if(numberofNotesToBeDispatched>1){
                   Console.WriteLine(numberofNotesToBeDispatched +"Hundred notes are dispacthed by HundredHandler");
                }else{
                   Console.WriteLine(numberofNotesToBeDispatched +"Hundred notes are dispacthed by HundredHandler");
                }
            }

            long pendingAmountToBeProcessed = requestedAmount%100;
            if(pendingAmountToBeProcessed>0)
            this.rsHandler.dispatchRs(pendingAmountToBeProcessed);
         }

         public HundredHandler(){

         }
        
    }


    public class Atm{
        private TwoThousandHandler twoThousandHandler =new TwoThousandHandler();
        private FiveHundredHandler fiveHundredHandler=new FiveHundredHandler();
        private TwoHundredHandler twoHundredHandler=new TwoHundredHandler();
        private HundredHandler  hundredHandler=new HundredHandler();
        public Atm(){

             twoThousandHandler.nextHandler(fiveHundredHandler);
             fiveHundredHandler.nextHandler(twoHundredHandler);
             twoHundredHandler.nextHandler(hundredHandler);

        }

        public void WithDraw(long requestAmount){
            twoThousandHandler.dispatchRs(requestAmount);
        }

    }

}
