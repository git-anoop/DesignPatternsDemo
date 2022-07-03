using BuilderDesignPattern.IBuilder;
using BuilderDesignPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Director
{
    public class ConfigurationBuilder
    {
        public void BuildSystem
            (
                ISystemBuilder systemBuilder,
                SystemConfiguration userInputs)
        {
            systemBuilder.AddDrive(userInputs.HDD);
            systemBuilder.AddKeyboard(userInputs.Keyboard);
            systemBuilder.AddMemory(userInputs.RAM);
            systemBuilder.AddTouchscreen(userInputs.Touchscreen);
            systemBuilder.AddMouse(userInputs.Mouse);
        }
    }
}
