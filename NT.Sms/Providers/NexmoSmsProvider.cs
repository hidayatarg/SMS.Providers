using NT.Sms.Models;

namespace NT.Sms.Providers
{
    public class NexmoSmsProvider : ISmsProvider
    {
        public SmsProviderTypeEnum ProviderType => SmsProviderTypeEnum.Nexmo;

        public void SendSms(string phoneNumber, string message)
        {
            // Send SMS using Nexmo
            Console.WriteLine("SMS send using Nexmo");
        }
    }
}
