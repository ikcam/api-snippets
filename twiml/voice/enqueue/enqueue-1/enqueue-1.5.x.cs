using Twilio.TwiML;


public class Enqueue1
{
    public static void Main()
    {
        var response = new VoiceResponse();
        response.Enqueue("support", waitUrl: "wait-music.xml");

        System.Console.WriteLine(response.ToString());
    }
}
