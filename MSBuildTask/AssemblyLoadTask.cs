using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using Common;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace MSBuildTask
{
    public class AssemblyLoadTask : Task
    {
        public override bool Execute()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "..", "Plugin", "bin", "debug", "netstandard2.0", "Plugin.dll");
            var assembly = Assembly.LoadFile(path);
            
            var customAttributes = assembly.GetCustomAttributes();
            var pluginAttribute = (PluginMarkerAttribute)customAttributes.SingleOrDefault(a => a is PluginMarkerAttribute);

            return true;
        }
    }
}
