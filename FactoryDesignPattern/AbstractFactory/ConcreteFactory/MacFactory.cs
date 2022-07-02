
namespace FactoryDesignPattern.AbstractFactory
{
    class MacDesktopFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new MAC();
        }

        public IProcessor Processor()
        {
            return new I7();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }

    class MacLaptopFactory : MacDesktopFactory
    {

        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}
