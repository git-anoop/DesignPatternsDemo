
namespace FactoryDesignPattern.AbstractFactory
{
    /// <summary>
    /// Abstract Factory interface
    /// </summary>
    public interface IComputerFactory
    {
        IProcessor Processor();
        IBrand Brand();
        ISystemType SystemType();
    }
}
