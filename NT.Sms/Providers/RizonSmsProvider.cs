using NT.Sms.Models;

namespace NT.Sms.Providers
{
    public class RizonSmsProvider : ISmsProvider
    {
        public SmsProviderTypeEnum ProviderType => SmsProviderTypeEnum.Rizon;

        public void SendSms(string phoneNumber, string message)
        {
            Console.WriteLine("SMS send using Rizon");
        }
    }
}
