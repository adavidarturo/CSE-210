using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>(); // List to storage all _prompts
    public List<string> _usedPrompts = new List<string>(); // List to storage _usedPrompts 

    // Constructor to initialize all _prompts
    public PromptGenerator() 
    {
        // Add my custom self-assessment questions to the _prompts list
        _prompts.Add("How am I feeling, in general, this week? Were there moments of happiness, satisfaction, or stress?");
        _prompts.Add("Am I regularly devoting time to activities that nourish me spiritually?");
        _prompts.Add("Have I practiced gratitude and reflected on the positive things that happened this week?");
        _prompts.Add("What were my most important achievements during the week? In what areas do I feel I have made progress??");
        _prompts.Add("Were there times when I reacted impulsively or negatively? How could you have handled those situations more constructively?");
        _prompts.Add("Have I been aware of my thoughts and emotions? Are there negative thought patterns that I should address?");
        _prompts.Add("Have I been kind and compassionate to myself and others?");
        _prompts.Add("Am I taking care of my physical health through adequate nutrition, exercise, and rest?");
        _prompts.Add("Am I maintaining a balance between work, time for myself, and social relationships?");
        _prompts.Add("Am I making progress on my long-term goals? Do I need to adjust my approach or planning?");
        _prompts.Add("Have I learned something new this week? Have I sought opportunities for personal growth?");
        _prompts.Add("Am I practicing empathy and understanding in my relationships with others?");
    
    }

    // Method to get and remove the a chosen prompt
    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0) // If the prompt count is equal to 0
        {
            _prompts.AddRange(_usedPrompts); // Move all _prompts with the AddRange() function to the _usedPrompts list
            _usedPrompts.Clear(); // Clean the _usedPrompts list with the Clear() function
        }
        // Create a ramdom instance 
        Random random = new Random();

        // Select a random "index" with the .Next() function from the _prompts count
        int index = random.Next(_prompts.Count); 
        // Save the chosen index in "prompt" 
        string prompt = _prompts[index];
        
        _usedPrompts.Add(prompt); // Add the prompt to the _usedPrompts list
        _prompts.RemoveAt(index); // Remove that index with the RemoveAt() function from the _prompts list

        return prompt; // Save the prompt value
    }
}

