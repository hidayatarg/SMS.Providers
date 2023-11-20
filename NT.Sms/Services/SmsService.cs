using NT.Sms.Models;
using NT.Sms.Providers;

namespace NT.Sms.Services
{
    public class SmsService : ISmsService
    {
        //private readonly ISmsProvider _smsProvider;
        private readonly IEnumerable<ISmsProvider> _smsProvider;

        public SmsService(IEnumerable<ISmsProvider> smsProvider)
        {
            _smsProvider = smsProvider;
        }

        public void SendSms(string phoneNumber, string message)
        {
            // Provider from database
            var providerDb = "Nexmo";

            // switch based on the provider name
            var provider = providerDb switch
            {
                "Nexmo" => SmsProviderTypeEnum.Nexmo,
                "Twilo" => SmsProviderTypeEnum.Twilio,
                _ => SmsProviderTypeEnum.Rizon
            };

            // You can switch based on the provider type enum
            var smsProvider = _smsProvider.FirstOrDefault(x => x.ProviderType == provider);

            smsProvider.SendSms(phoneNumber, message);
        }
    }
}
