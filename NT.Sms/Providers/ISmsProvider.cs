using NT.Sms.Models;

namespace NT.Sms.Providers
{
    public interface ISmsProvider
    {
        SmsProviderTypeEnum ProviderType { get; }

        void SendSms(string phoneNumber, string message);
    }
}
