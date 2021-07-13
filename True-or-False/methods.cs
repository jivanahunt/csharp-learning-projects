using System;
namespace TrueOrFalse
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] questions = new string[]
      {
        "Is Big Ben in London?",
        "Is Paris in France?",
        "Is the earth rectangular?"
      };
      bool[] answers = new bool[] 
      {
        true,
        true,
      };
      
      RunQuiz(questions, answers);
    }
    static void WelcomingUser()
    {
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);
      return;   
    }
    static bool[] CheckingLengthQuestionsAnswers(string[] questions, bool[] answers)
    {
      bool[] responses = new bool[questions.Length];
      if (questions.Length != answers.Length)
      {
        Console.WriteLine("Careful, the length of questions is different from the length of answers.");
      }
      return responses;
    }
    static void CheckingInput(string[] questions, bool[] responses)
    {
      int askingIndex = 0;
      foreach (string question in questions)
      {
        bool inputBool;
        bool isBool;
        do {
          Console.WriteLine(questions[askingIndex]);
          string input = Console.ReadLine();
          inputBool = Boolean.TryParse(input, out isBool);
          if (!inputBool) {Console.WriteLine("Your input is incorrect. Please reply with true or false:");}
        } while (!inputBool);
        responses[askingIndex] = isBool;
        askingIndex++;
      }
    }
    static int ScoringAnswers(bool[] answers, bool[] responses)
    {
      int scoringIndex = 0;
      int score = 0;
      foreach (bool answer in answers)
      {
        bool response = responses[scoringIndex];
        scoringIndex++;
        Console.WriteLine($"{scoringIndex}. Input: {response} | Answer: {answer}");
        if (response == answer) {score++;}
      }
      return score;
    }
    static void RunQuiz(string[] questions, bool[] answers)
    {
      WelcomingUser();
      bool[] responses = CheckingLengthQuestionsAnswers(questions, answers);
      CheckingInput(questions, responses);
      int score = ScoringAnswers(answers, responses);
      Console.WriteLine($"You got {score} out of {questions.Length} correct!");
      return;
    }  
  }
}
