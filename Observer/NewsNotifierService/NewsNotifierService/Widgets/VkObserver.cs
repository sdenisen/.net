using System;

namespace NewsNotifierService.Widgets
{
    class VkObserver : IObserver
    {
        private string _vk;

        public void Update(string twitter, string vk)
        {
            _vk = vk;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("vk info: " + _vk);
        }
    }
}
