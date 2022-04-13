using System;

namespace AdapterPattern{
    public class David : IFrenchSpeaker{
        public string AskQuestion(string Words){
             Console.WriteLine("Question Asked by David [French Speaker and Can understand only French] : "+Words);
             ITarget target = new Pam();
             string replyFromJhon = target.TranslateAndTellToOtherPerson(Words,"English");
             return replyFromJhon;
        }

        public string AnswerFortheQuestion(string Words){
            string reply = null;
              if (Words.Equals("comment allez-vous?", StringComparison.InvariantCultureIgnoreCase))
            {
                reply = "Je suis très bien";
            }
            return reply;
        }

    }
}