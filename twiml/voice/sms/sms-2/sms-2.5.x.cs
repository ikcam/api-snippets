using Twilio.TwiML;


public class Sms-2.5.x
{
    public static void Main()
    {
        var response = new VoiceResponse();
        response.Say("Our store is located at 123 Easy St.");
        response.Sms("Store Location: 123 Easy St.");

        System.Console.WriteLine(response.ToString());
    }
}
