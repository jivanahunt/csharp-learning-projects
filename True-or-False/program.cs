using System;
namespace TrueOrFalse
{
  class Program
  {
    static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);
      // Type your code below
      string[] questions = {"Is Big Ben in London?", "Is Paris in France?", "Is the earth rectangular?"};
      bool[] answers = {true, true, false};
      bool[] responses = new bool[questions.Length];
      if (questions.Length != answers.Length)
      {
        Console.WriteLine("Careful, the length of questions is different from the length of answers.");
      }
      int askingIndex = 0;
      foreach (string question in questions)
      {
        Console.WriteLine(questions[askingIndex]);
        string input = Console.ReadLine();
        bool isBool;
        bool inputBool = Boolean.TryParse(input, out isBool);
        while (!inputBool)
        {
          Console.WriteLine("Your input is incorrect. Please reply with true or false:");
          input = Console.ReadLine();
          inputBool = Boolean.TryParse(input, out isBool);
          Console.WriteLine($"Input can be converted to Boolean:{isBool}. Input returned boolean: {inputBool}.");
        }
        //Console.WriteLine(isBool);
        responses[askingIndex] = isBool;
        askingIndex++;
      }
      foreach (bool answer in responses)
      {
        //Console.WriteLine(answer);
      }
      int scoringIndex = 0;
      int score = 0;
      foreach (bool answer in answers)
      {
        bool response = responses[scoringIndex];
        scoringIndex++;
        Console.WriteLine($"{scoringIndex}. Input: {response} | Answer: {answer}");
        if (response == answer)
        {
          score++;
        }
      }
      Console.WriteLine($"You {score} out of {questions.Length} correct!");
    }
  }
}
