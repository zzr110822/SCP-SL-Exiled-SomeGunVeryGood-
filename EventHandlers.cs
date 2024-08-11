using Exiled.API.Enums;
using Exiled.API.Extensions;
using Exiled.API.Features.Items;
using Exiled.Events.EventArgs.Player;
using PluginAPI.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEC;
using UnityEngine;
using Exiled.API.Features;
using PlayerStatsSystem;
using InventorySystem.Items.ThrowableProjectiles;

namespace Some_Gun_Very_Good_
{
    public class EventHandlers
    {

        public static void OnPlayerShot(ShotEventArgs e)
        {

            if (e.Item.Type == ItemType.GunFRMG0)
            {
                if (e.Firearm.Ammo <= e.Firearm.MaxAmmo)
                {

                    Vector3 position = e.Position;
                    Player player = e.Player;
                    GrenadeManager grenadeManager = new GrenadeManager();
                    ProjectileType type = ProjectileType.FragGrenade;
                    float fuseTime = 0.5f;
                    grenadeManager.GenerateAndActivateGrenade(player, type, fuseTime, position);

                }
            }

            if (e.Item.Type == ItemType.GunLogicer)
            {
                if (e.Firearm.Ammo <= e.Firearm.MaxAmmo)
                {

                    Vector3 position = e.Position;
                    Player player = e.Player;
                    GrenadeManager grenadeManager = new GrenadeManager();
                    ProjectileType type = ProjectileType.Flashbang;
                    float fuseTime = 0.5f;
                    grenadeManager.GenerateAndActivateFlashbang(player, type, fuseTime, position);

                }
            }

            

        }


        public class GrenadeManager
        {

            public void GenerateAndActivateGrenade(Player player, ProjectileType type, float fuseTime, Vector3 position)
            {
                ExplosiveGrenade grenade = (ExplosiveGrenade)Item.Create(type.GetItemType());
                grenade.FuseTime = fuseTime;
                grenade.SpawnActive(position);
            }

            public void GenerateAndActivateFlashbang(Player player, ProjectileType type, float fuseTime, Vector3 position)
            {
                FlashGrenade Flashbang = (FlashGrenade)Item.Create(type.GetItemType());
                Flashbang.FuseTime = fuseTime;
                Flashbang.SpawnActive(position);
            }

           

        }


      



    }
}
