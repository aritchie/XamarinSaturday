using System;


namespace MyPlugin
{
    public static class CrossEnvironment
    {
        static IEnvironment current;
        public static IEnvironment Current
        {
            get
            {
#if NETSTANDARD
                throw new ArgumentException("This is the bait library");
#else
                current = current ?? new EnvironmentImpl();
                return current;
#endif
            }
        }
    }
}
