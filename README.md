
# Multiple SMS Providers with Dependency Injection using Strategy Pattern in .net-core 7.0

## SmsService

The `SmsService` is a part of the NT.Sms namespace, designed to facilitate sending SMS messages through various providers. It is implemented in C# using ASP.NET Core 7, making use of the SMS models and providers within the NT.Sms library.

## Overview

The `SmsService` class is responsible for sending SMS messages through different providers. It utilizes an IEnumerable of ISmsProvider to support multiple providers seamlessly.

## Usage

To use the `SmsService`, create an instance of it by providing an IEnumerable of ISmsProvider during initialization. This allows you to inject different SMS providers dynamically.

```csharp
var smsProviders = new List<ISmsProvider>
{
    new NexmoSmsProvider(),   // Example provider implementation
    new TwilioSmsProvider(),
    // Add more providers as needed
};

var smsService = new SmsService(smsProviders);
```

After initializing the `SmsService`, you can send an SMS by calling the `SendSms` method and providing the phone number and message.

```csharp
smsService.SendSms("+123456789", "Hello, this is a test message!");
```

The `SendSms` method internally determines the SMS provider based on a provider name retrieved from the database. The provider name is then mapped to an enum value, and the corresponding SMS provider is selected from the injected list.

### Supported Providers

- Nexmo
- Twilio
- Rizon (default if the provider is not recognized)

## Dependencies

- ASP.NET Core
- NT.Sms.Models
- NT.Sms.Providers

## License

This project is licensed under the [MIT License](LICENSE).

---

Feel free to customize this README according to your specific project needs.
