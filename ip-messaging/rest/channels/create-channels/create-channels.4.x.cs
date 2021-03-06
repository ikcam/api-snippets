// Download the twilio-csharp library from twilio.com/docs/csharp/install
using System;
using Twilio;

class Example {
    static void Main (string[] args) {
        // Find your Account Sid and Auth Token at twilio.com/user/account
        const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string authToken = "your_auth_token";
        const string serviceSid = "ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string channelType = "public";

        // Create a channel
        var client = new TwilioIpMessagingClient(accountSid, authToken);
        Channel channel = client.createChannel(serviceSid, channelType);
        Console.WriteLine(channel);
    }
}