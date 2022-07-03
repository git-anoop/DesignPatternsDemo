using BuilderDesignPattern.Director;
using BuilderDesignPattern.IBuilder;
using BuilderDesignPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.ConcreteBuilder
{
    public static class SystemBuilder
    {
        public static SystemConfiguration GetMachineConfig
            (
                int type,
                SystemConfiguration userInputs
            )
        {
            var returnValue = new SystemConfiguration();

            //// COncrete builder
            ISystemBuilder systemBuilder = null;
            switch (type)
            {
                case 1:
                    systemBuilder = new LaptopBuilder();
                    break;
                case 2:
                    systemBuilder = new DesktopBuilder();
                    break;
            }

            //// Director
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.BuildSystem(systemBuilder, userInputs);

            //// Return the system
            returnValue = systemBuilder.GetSystem();

            return returnValue;
        }
    }
}
