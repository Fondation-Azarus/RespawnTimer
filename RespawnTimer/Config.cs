using Synapse.Config;
using System.ComponentModel;

namespace RespawnTimer
{
    public class PluginConfig : AbstractConfigSection
    {
        [Description("Is it on ? ")]
        public bool activated = true;
    }
}