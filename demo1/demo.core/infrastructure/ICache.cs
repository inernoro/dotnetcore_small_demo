using demo.core.Dependency;

namespace demo.core
{
    public interface ICache : ISingletonDependency
    {
        void Write(string key, string value);
    }
}