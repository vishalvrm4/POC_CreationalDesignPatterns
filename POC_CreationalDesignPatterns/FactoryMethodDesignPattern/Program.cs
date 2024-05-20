// See https://aka.ms/new-console-template for more information
using FactoryMethodDesignPattern;

Console.WriteLine("Hello, World!");

// Notification Center
INotificationCenter notificationCenter;

// assign email object
notificationCenter = NotificationCenterFactory.CreateObject(NotificationChannel.Email);
notificationCenter.Send("Message 1, 2, 3 ...");

// assign email object
notificationCenter = NotificationCenterFactory.CreateObject(NotificationChannel.SMS);
notificationCenter.Send("Message 1, 2, 3 ...");


// Logger
ILogger logger;

// assign file object
logger = LoggerFactory.CreateObject(LoggerType.File);
logger.Log("Application start at "+DateTime.Now.ToString("dd:MMM:yyyy HH:mm:ss tt"));

// assign database object
logger = LoggerFactory.CreateObject(LoggerType.Database);
logger.Log("Application start at "+DateTime.Now.ToString("dd:MMM:yyyy HH:mm:ss tt"));

// assign console object
logger = LoggerFactory.CreateObject(LoggerType.Console);
logger.Log("Application start at "+DateTime.Now.ToString("dd:MMM:yyyy HH:mm:ss tt"));