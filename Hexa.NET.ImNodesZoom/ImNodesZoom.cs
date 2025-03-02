namespace Hexa.NET.ImNodesZoom
{
    using HexaGen.Runtime;
    using System.Diagnostics;

    public static class ImNodesZoomConfig
    {
        public static bool AotStaticLink;
    }

    public static unsafe partial class ImNodesZoom
    {
        static ImNodesZoom()
        {
            if (ImNodesZoomConfig.AotStaticLink)
            {
                InitApi(new NativeLibraryContext(Process.GetCurrentProcess().MainModule!.BaseAddress));
            }
            else
            {
                InitApi(new NativeLibraryContext(LibraryLoader.LoadLibrary(GetLibraryName, null)));
            }
        }

        public static string GetLibraryName()
        {
            return "cimnodeszoom";
        }
    }
}