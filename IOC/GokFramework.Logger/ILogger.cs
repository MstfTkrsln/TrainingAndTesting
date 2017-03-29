using System.Reflection;

namespace GokFramework.Logger
{
    public interface ILogger
    {
        void Log(MethodBase methodBase, string message);
    }
}
