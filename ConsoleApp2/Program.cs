using ConsoleApp2;

NotificationCreator creator;

creator = new EmailNotificationCreator();
creator.Send("Welcome!");

creator = new SmsNotificationCreator();
creator.Send("OTP: 12345");