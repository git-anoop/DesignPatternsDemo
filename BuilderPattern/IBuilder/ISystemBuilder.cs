
using BuilderDesignPattern.Product;

namespace BuilderDesignPattern.IBuilder
{
    public interface ISystemBuilder
    {
        void AddMemory(string memory);
        void AddDrive(string driveSize);

        void AddKeyboard(string type);
        void AddMouse(string type);
        void AddTouchscreen(string enabled);
        SystemConfiguration GetSystem();
    }
}
