// See https://aka.ms/new-console-template for more information
using AbstractFactoryDesignPattern;

Console.WriteLine("Hello, World!");

IMediaControlFactory factory = null;
MediaPlayer player = null;

factory = new WindowMediaControl();
player = new MediaPlayer(factory);
player.RenderControls();

factory = new MacMediaControl();
player = new MediaPlayer(factory);
player.RenderControls();