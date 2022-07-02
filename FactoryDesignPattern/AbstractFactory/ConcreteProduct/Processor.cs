using static Common.SystemEnumeration;

/// <summary>
/// Family of related product : Processor Type
/// </summary>
namespace FactoryDesignPattern.AbstractFactory
{
    public class I7 : IProcessor
    {
        public string GetProcessor()
        {
            return ProcessorType.I7.ToString();
        }
    }

    public class I5 : IProcessor
    {
        public string GetProcessor()
        {
            return ProcessorType.I5.ToString();
        }
    }
}
