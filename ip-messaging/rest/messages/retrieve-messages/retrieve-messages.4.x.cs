// Download the twilio-csharp library from twilio.com/docs/csharp/install
using System;
using Twilio.IpMessaging;

class Example {
    static void Main (string[] args) {
        // Find your Account Sid and Auth Token at twilio.com/user/account
        const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string authToken = "your_auth_token";
        const string serviceSid = "ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string channelSid = "CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string messageSid = "IMXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

        // Retrieve Message
        var client = new IpMessagingClient(accountSid, authToken);
        Message message = client.GetMessage(serviceSid, channelSid, messageSid);
        Console.WriteLine(message);
    }
}