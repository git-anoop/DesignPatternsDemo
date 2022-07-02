using static Common.SystemEnumeration;

/// <summary>
/// Family of related product : System Type
/// </summary>
namespace FactoryDesignPattern.AbstractFactory
{
    class Laptop : ISystemType
    {
        public string GetSytemType()
        {
            return SystemType.Laptop.ToString();
        }
    }

    class Desktop : ISystemType
    {
        public string GetSytemType()
        {
            return SystemType.Desktop.ToString();
        }
    }
}
