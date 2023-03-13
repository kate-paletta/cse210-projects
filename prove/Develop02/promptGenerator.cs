using System;

public class Entry
{
    
    //Create Write function
    public void userText(){ 
        List<string> prompts = new List<string>() 
        {
        "1. What was your favorite part of the day?",
        "2. Did you help anyone today?",
        "3. Did you learn something new?"
        };
    
        Random rndm = new Random();
        var random = new Random();
        int numprompt = random.Next(prompts.Count);

    } 

}