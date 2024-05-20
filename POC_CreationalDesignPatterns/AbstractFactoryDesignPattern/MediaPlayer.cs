using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public interface IPlayButton
    {
        void Render();
    }

    public interface IStopButton
    {
        void Render();
    }

    public class WindowPlayButton : IPlayButton
    {
        public void Render() => Console.WriteLine("Play music in Windows ...... ");
    }

    public class WindowStopButton : IStopButton
    {
        public void Render() => Console.WriteLine("Stop music in Windows ...... ");
    }

    public class MacPlayButton : IPlayButton
    {
        public void Render() => Console.WriteLine("Play music in Mac ...... ");
    }

    public class MacStopButton : IStopButton
    {
        public void Render() => Console.WriteLine("Stop music in Mac ...... ");
    }


    /***************************************** Abstract Factory *****************/
    public interface IMediaControlFactory
    {
        IPlayButton PlayButton();
        IStopButton StopButton();
    }

    public class WindowMediaControl : IMediaControlFactory
    {
        public IPlayButton PlayButton()
        {
            return new WindowPlayButton();
        }

        public IStopButton StopButton()
        {
            return new WindowStopButton();
        }
    }

    public class MacMediaControl : IMediaControlFactory
    {
        public IPlayButton PlayButton() 
        {
            return new MacPlayButton();
        }

        public IStopButton StopButton()
        {
            return new MacStopButton();
        }
    }

    public class MediaPlayer
    {
        private readonly IPlayButton playButton;
        private readonly IStopButton stopButton;

        public MediaPlayer(IMediaControlFactory media)
        {
            playButton = media.PlayButton();
            stopButton = media.StopButton();
        }

        public void RenderControls()
        {
            playButton.Render();
            stopButton.Render();
        }
    }
}
