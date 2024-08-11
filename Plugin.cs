using Exiled.API.Features;
using Exiled.CustomItems.API.Features;
using PluginAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Some_Gun_Very_Good_
{
    public class Plugin : Plugin<AiLiShaLikeconfig_Some_Gun_Very_Good>
    {
        public override string Name { get; } = "Exiled_Some_Gun_Very_Good!";
        public override string Author { get; } = "雾云";
        public override Version Version { get; } = new Version(1, 0, 0);

        private static readonly Lazy<Plugin> LazyInstance = new Lazy<Plugin>(() => new Plugin());
        public static Plugin Instance => LazyInstance.Value;

      
        //注册
        public override void OnEnabled()
        {


            Exiled.Events.Handlers.Player.Shot += EventHandlers.OnPlayerShot;
         




        }

        //取消注册
        public override void OnDisabled()
        {

            Exiled.Events.Handlers.Player.Shot -= EventHandlers.OnPlayerShot;
       



        }






    }
}
