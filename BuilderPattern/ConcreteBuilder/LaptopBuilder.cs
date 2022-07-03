using BuilderDesignPattern.IBuilder;
using BuilderDesignPattern.Product;

namespace BuilderDesignPattern.ConcreteBuilder
{
    class LaptopBuilder : ISystemBuilder
    {
        SystemConfiguration laptopConfiguration = new SystemConfiguration();
        public void AddDrive(string driveSize)
        {
            laptopConfiguration.HDD = driveSize;
        }

        public void AddKeyboard(string type)
        {
            return;
        }

        public void AddMemory(string memory)
        {
            laptopConfiguration.RAM = memory;
        }

        public void AddMouse(string type)
        {
            return;
        }

        public void AddTouchscreen(string enabled)
        {
            laptopConfiguration.Touchscreen = enabled;
        }

        public SystemConfiguration GetSystem()
        {
            return laptopConfiguration;
        }
    }
}
