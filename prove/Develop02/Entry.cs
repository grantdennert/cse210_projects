public class Entry
{
    public string  _date = DateTime.Today.ToShortDateString();
    public string _prompt;
    public string _response;
    
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n {_response}");
    }
}