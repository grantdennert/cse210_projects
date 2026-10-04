public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was your favorite thing that happened today?",
        "What was your least favorite thing that happened today?",
        "List three things you are grateful for.",
        "Where did you see the Lord's hand in your life today?",
        "What is something you look forward to?"
    };
    public string GeneratePrompt()
    {
        string prompt;
        int maxValue = _prompts.Count() - 1;
        Random random = new Random();
        int randomNumber = random.Next(0, maxValue);
        prompt = _prompts[randomNumber];
        return prompt;
    }
}