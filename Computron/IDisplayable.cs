// Define IDisplayable in this file
using System;
namespace SavingInterface
{
  interface IDisplayable
  {
    string Header { get; }
    
    void Display();
  }
}
