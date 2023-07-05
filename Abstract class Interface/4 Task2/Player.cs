using System;

namespace _4_Task2
{
    public class Player : IRecodable, IPlayable
    {
        void IRecodable.Pause()
        {
            Console.WriteLine("Pause Record");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Pause Music");
        }

        public void Play()
        {
            Console.WriteLine("Play Music");
        }

        public void Record()
        {
            Console.WriteLine("Record Music");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Stop Record");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stop Music");
        }
    }
}
