using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.AbstractFactory
{
    public class EmployeeSystemManager
    {
        IComputerFactory _computerFactory;

        public EmployeeSystemManager(IComputerFactory computerFactory)
        {
            _computerFactory = computerFactory;
        }

        public string GetSystemDetails()
        {
            IBrand brand = _computerFactory.Brand();
            IProcessor processor = _computerFactory.Processor();
            ISystemType systemType = _computerFactory.SystemType();

            return String.Format
                (
                    "Allocated {0} {1} {2}",
                    brand.GetBrandName().ToString(),
                    systemType.GetSytemType().ToString(),
                    processor.GetProcessor().ToString()
                );
        }
    }
}
