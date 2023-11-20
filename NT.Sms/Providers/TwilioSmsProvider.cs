using NT.Sms.Models;

namespace NT.Sms.Providers
{
    public class TwilioSmsProvider : ISmsProvider
    {
        public SmsProviderTypeEnum ProviderType => SmsProviderTypeEnum.Twilio;

        public void SendSms(string phoneNumber, string message)
        {
            // Send SMS using Twilio
            Console.WriteLine("SMS send using Twilio");
        }
    }
}
