using Synapse.Api.Plugin;

namespace RespawnTimer
{
    [PluginInformation(
        Name = "Respawn Timer",
        Author = "Bonjemus",
        Description = "Plugin which allows spectators to see how much time they have to wait until the next respawn.",
        LoadPriority = 1,
        SynapseMajor = SynapseController.SynapseMajor,
        SynapseMinor = SynapseController.SynapseMinor,
        SynapsePatch = SynapseController.SynapsePatch,
        Version = "1.0.0"
        )]
    public class PluginClass : AbstractPlugin
    {
        [Config(section = "Respawn Timer")]
        public static PluginConfig Config;

        public override void Load()
        {
            new Handler();
        }
    }
}