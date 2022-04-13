using System;
using System.Collections;
using System.Collections.Generic;


namespace AdapterPattern{
    /// <summary>
    /// Adapter or Translator
    /// </summary>
    public class Pam:ITarget{
     static Dictionary<string,string> EnglishFrenchDictionary = new Dictionary<string, string>();
     static Dictionary<string,string> FrenchEnglishDictioanry =new Dictionary<string, string>();
     Jhon john =new  Jhon();
     David david =new David();
     static Pam(){
 EnglishFrenchDictionary.Add ("how are you?", "comment allez-vous?");
            EnglishFrenchDictionary.Add ("I am in USA", "Je suis aux Etats-Unis");
            FrenchEnglishDictioanry.Add ("Je suis trC(s bien", "I am fine");
            FrenchEnglishDictioanry.Add ("oC9 C*tes-vous?", "where are you?");
     }
        public string TranslateAndTellToOtherPerson(string words, string convertToWhichLanguage)
        {
          if(convertToWhichLanguage.Equals("English",StringComparison.InvariantCultureIgnoreCase)){
              string EnglishWords = ConvertToEnglish(words);
              Console.WriteLine("\nPam Converted \""+words+" \" to \""+EnglishWords +" and send the question to John");
              string EnglishWordsReply  = john.AnswerFortheQuestion(EnglishWords);
              Console.WriteLine("Pam Got reply from John in English : "+"\""+EnglishWordsReply+"\"");
              string FrenchConverted =ConvertToFrench(EnglishWordsReply);
              return FrenchConverted;
          }
          else if(convertToWhichLanguage.Equals("French",StringComparison.InvariantCultureIgnoreCase)){
             string FrenchWords = ConvertToFrench (words);
             Console.WriteLine ("\nPam Converted \"" + words + " \" to \"" + FrenchWords + " and send the question to David");
             string FrenchWordsReply = david.AnswerFortheQuestion (FrenchWords);
             Console.WriteLine ("Pam Got reply from David in French : " + "\"" +FrenchWordsReply + "\"");
             string EnglishConverted = ConvertToEnglish (FrenchWordsReply);
             Console.WriteLine ("Pam Converted " + "\"" + FrenchWordsReply + "\"" + " to " + "\"" + EnglishConverted + "\"" +" and send back to John\n");
             return EnglishConverted;
          }
           else
         {
             return "Sorry Cannot Covert";
         }
        }
       public string ConvertToFrench(string Words){ 
           return EnglishFrenchDictionary[Words];
       }

       public string ConvertToEnglish(string Words){
           return FrenchEnglishDictioanry[Words];
       }
    }
}