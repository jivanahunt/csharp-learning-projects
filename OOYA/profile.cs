using System;
namespace DatingProfile
{
  class Profile
  {
    // fields
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;
    // properties
    public string Name
    {
      get { return name; }
      set { name = value; }
    }
    public int Age
    {
      get { return age; }
      set {
        if (value >= 18) { age = value; }
        else { age = 1; }
      }
    }
    public string City
    {
      get { return city; }
      set { city = value; }
    }
    public string Country
    {
      get { return country; }
      set { country = value; }
    }
    public string Pronouns
    {
      get { return pronouns; }
      set { pronouns = value; }
    }
    public string[] Hobbies
    {
      get { return hobbies; }
      set { hobbies = value; }
    }
    // constructor
    public Profile(string name, int age, string city = "n/a", string country = "n/a", string pronouns = "they/them")
    {
      this.Name = name;
      this.Age = age;
      this.City = city;
      this.Country = country;
      this.Pronouns = pronouns;
      this.Hobbies = new string[0];
    }
    // methods
    public string ViewProfile()
    {
      /*string userData = this.name +
        "\n" + this.age +
        "\n" + this.city +
        "\n" + this.country +
        "\n" + this.pronouns
      ;*/
      string userData = $"Name: {this.Name}\nAge: {this.Age}\nCity: {this.City}\nCountry: {this.Country}\nPronouns: {this.Pronouns}";
      if (this.Hobbies.Length != 0) 
      {
        userData += "\nHobbies:\n";
        foreach (string hobby in this.Hobbies)
        {
          userData += $"- {hobby}\n";
        }
      }
      if (this.Age == 1)
      {
        userData = "Sorry, you're too young to use this app.";
      }
      return userData;
    }
    public void SetHobbies(string[] hobbies) 
    {
      this.Hobbies = hobbies;
    }
  }
}
