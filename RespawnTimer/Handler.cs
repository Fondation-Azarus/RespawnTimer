using Synapse;
using MEC;
using System.Collections.Generic;
using Synapse.Api;
using Synapse.Api.Events.SynapseEventArguments;
using System;

namespace RespawnTimer
{
    public class Handler
    {
        public Handler()
        {
            Server.Get.Events.Player.PlayerJoinEvent += OnJoin;
        }

        private void OnJoin(PlayerJoinEventArgs ev)
        {
            if (PluginClass.Config.activated)
                Timing.RunCoroutine(TimerShow(ev.Player));
        }

        private IEnumerator<float> TimerShow(Player p)
        {
            while (!Map.Get.Round.RoundEnded)
            {
                if (p.IsDead)
                {
                    if (Math.Round(Map.Get.Round.NextRespawn) > 1)
                    {
                        p.GiveTextHint($"Next respawn in : {Math.Round(Map.Get.Round.NextRespawn)} s.", 1);
                        yield return Timing.WaitForSeconds(1);
                    }

                    else
                    {
                        p.GiveTextHint($"Prepare yourself to respawn.", 20);
                        yield return Timing.WaitForSeconds(20);
                    }
                }
                else
                    yield return Timing.WaitForSeconds(4);
            }
        }
    }
}