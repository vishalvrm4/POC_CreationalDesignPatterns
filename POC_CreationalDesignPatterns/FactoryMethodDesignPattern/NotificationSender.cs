using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    public interface INotificationCenter
    {
        void Send(string message);
    }

    public class SMSNotificationCenter : INotificationCenter
    {
        public void Send(string message) => Console.WriteLine("SMS Send : " + message);
    }

    public class EmailNotificationCenter : INotificationCenter
    {
        public void Send(string message) => Console.WriteLine("Email Send : " + message);
    }

    public enum NotificationChannel { Email, SMS }

    public static class NotificationCenterFactory
    {
        public static INotificationCenter CreateObject(NotificationChannel channel) => channel switch
        {
            NotificationChannel.Email => new EmailNotificationCenter(),
            NotificationChannel.SMS => new SMSNotificationCenter(),
            _ => throw new ArgumentException("Invalid channel"),
        };
    }
}
