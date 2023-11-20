namespace NT.Sms.Services
{
    public interface ISmsService
    {
        void SendSms(string phoneNumber, string message);
    }
}
