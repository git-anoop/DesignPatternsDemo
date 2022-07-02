using Common;

/// <summary>
/// Family of related product : Brand
/// </summary>
namespace FactoryDesignPattern.AbstractFactory
{
    public class MAC : IBrand
    {
        public string GetBrandName()
        {
            return SystemEnumeration.Brand.MAC.ToString();
        }
    }

    public class DELL : IBrand
    {
        public string GetBrandName()
        {
            return SystemEnumeration.Brand.DELL.ToString();
        }
    }
}
