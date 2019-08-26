using System;

#if __IOS__
using UIKit;
#endif
namespace MyBetterPlugin
{
    public class EnvironmentImpl : IEnvironment
    {
#if __WATCHOS__
        public string Version => "watchOS";
#else
        public string Version => UIKit.UIDevice.CurrentDevice.Model;
#endif
    }
}
