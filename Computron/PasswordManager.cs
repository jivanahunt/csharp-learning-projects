using System;
namespace SavingInterface
{
  class PasswordManager : IDisplayable
  {
    string password;
    
    private string Password
    { 
      get { return password; } 
      set 
      {
        if (value.Length >= 8)
        {
          password = value;
        }
        else { password = "Error - the password length is too short. Password must be at least 8 characters or more."; }
      }
    }
    public bool Hidden
    { get; private set; }
    public string Header
    {
      get { return "Password\n--------"; }
    }
    public PasswordManager(string password, bool hidden)
    {
      Password = password;
      Hidden = hidden;
    }
    public void Display()
    {
      if (Hidden == false)
      {
        Console.WriteLine(Password);
      }
      else
      {
        Console.WriteLine("******");
      }
    }
    public void Reset()
    {
      Password = "";
      Hidden = false;
    }
    public bool ChangePassword(string password, string newPassword)
    {
      if (password == Password)
      {
        Password = newPassword;
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
