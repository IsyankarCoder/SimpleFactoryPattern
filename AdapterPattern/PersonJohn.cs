using System;
namespace AdapterPattern
{
     public class Jhon : IEnglishSpeaker{

         public string AskQuestion(string Words){
             Console.WriteLine("Question Asked by Jhon [English Speaker and Can understand only English] : "+Words);
             ITarget target =new Pam();
             string returnFromDavid = target.TranslateAndTellToOtherPerson(Words,"French");
             return returnFromDavid;
         }

         public string AnswerFortheQuestion(string Words){
              string reply =null;
              if(Words.Equals("where are you ?",StringComparison.InvariantCultureIgnoreCase))
              {
                  reply= "I am in USA";
              }
              return reply;
         }
     } 
}