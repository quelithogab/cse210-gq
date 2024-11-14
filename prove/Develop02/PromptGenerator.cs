// PromptGenerator.cs
// Generates random writing prompts from specific categories for the user.

using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private Dictionary<string, List<string>> _promptsByCategory = new Dictionary<string, List<string>>
    {
        { "1", new List<string> { "Reflect on a challenge you faced today.", "How did you feel today?" } }, // Reflection
        { "2", new List<string> { "What are you grateful for today?", "Who made a positive impact on you today?" } }, // Gratitude
        { "3", new List<string> { "What are your plans for tomorrow?", "What goal did you set today?" } } // Planning
    };

    // Returns a random prompt from the selected category
    public string GetRandomPrompt(string category)
    {
        if (_promptsByCategory.ContainsKey(category))
        {
            List<string> prompts = _promptsByCategory[category];
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
        else
        {
            return "Invalid category.";
        }
    }
}
