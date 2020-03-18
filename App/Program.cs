using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Common;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "Plugin", "bin", "debug", "netstandard2.0", "Plugin.dll");
            var assembly = Assembly.LoadFile(path);

            var customAttributes = assembly.GetCustomAttributes();
            var pluginAttribute = (PluginMarkerAttribute)customAttributes.SingleOrDefault(a => a is PluginMarkerAttribute);
        }
    }
}
