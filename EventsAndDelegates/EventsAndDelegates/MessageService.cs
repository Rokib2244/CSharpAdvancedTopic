// See https://aka.ms/new-console-template for more information
public class MessageService
{
    public void OnVideoEncoded(object sender, EventArgs args)
    {
        Console.WriteLine("MessageService: Sending a text message");
    }
}