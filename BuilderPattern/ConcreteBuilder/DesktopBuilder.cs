using BuilderDesignPattern.IBuilder;
using BuilderDesignPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.ConcreteBuilder
{
    public class DesktopBuilder : ISystemBuilder
    {
        SystemConfiguration desktopConfiguration = new SystemConfiguration();
        public void AddDrive(string driveSize)
        {
            desktopConfiguration.HDD = driveSize;
        }

        public void AddKeyboard(string type)
        {
            desktopConfiguration.Keyboard = type; 
        }

        public void AddMemory(string memory)
        {
            desktopConfiguration.RAM = memory;
        }

        public void AddMouse(string type)
        {
            desktopConfiguration.Mouse = type;

        }

        public void AddTouchscreen(string enabled)
        {
            //// Breaks solid principle
            return;
        }

        public SystemConfiguration GetSystem()
        {
            return desktopConfiguration;
        }
    }
}
