using System;

public class Entry
{
    List<string> prompts = new List<string>() 
    {
        "1. What was your favorite part of the day?",
        "2. Did you help anyone today?",
        "3. Did you learn something new?"
    };
    
    //Create Write function
    public void userText(){ 
        Random rndm = new Random();
        int numprompt = rndm.Next();
        Console.WriteLine(prompts[numprompt]);
    } 

}