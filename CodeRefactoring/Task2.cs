using System;

namespace CodeRefactoring
{
    /// <summary>
    /// there are three notification services: EmailService, SmsService, and PushNotificationService. 
    /// Each service has a method to send notifications to users through different channels - email, SMS, and 
    /// push notifications, respectively.
    /// This task covers:
    /// 1. Extract Interface
    /// </summary>
    public interface notification_ser
    {
        void  SendNotification(string id, string msg);
    } 
    public class EmailService: notification_ser
    {
        public void SendNotification(string userId, string message)
        {
            // Send email notification
            Console.WriteLine($"Sending email notification to user {userId}: {message}");
        }
    }

    public class SmsService: notification_ser
    {
        public void SendNotification(string userId, string message)
        {
            // Send SMS notification
            Console.WriteLine($"Sending SMS notification to user {userId}: {message}");
        }
    }
    public class PushNotificationService: notification_ser
    {
        public void SendNotification(string userId, string message)
        {
            // Send push notification
            Console.WriteLine($"Sending push notification to user {userId}: {message}");
        }
    }

    public class User
    {
        private string userId;
       // private EmailService emailService;
        //private SmsService smsService;
        //private PushNotificationService pushNotificationService;
        private notification_ser notification_ser;
        public User(string userId, notification_ser notification_ser)
        {
            this.userId = userId;
            this.notification_ser = notification_ser;
        }

        public void Notify(string message)
        {
            notification_ser.SendNotification(userId, message);
            //Console.WriteLine("No notification chanel provided");
        }
    }

}
