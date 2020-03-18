using System;

namespace Common
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
    public class PluginMarkerAttribute  : Attribute
    {
    }
}
