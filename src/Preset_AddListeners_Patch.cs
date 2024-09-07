using HarmonyLib;
using RST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static RST.UI.CrewPresetsPanel;

namespace LoadCrewOnly
{
    /// <summary>
    /// Adds the special click handler to the Button object since
    /// Button only supports left click.
    /// </summary>
    [HarmonyPatch(typeof(Preset), nameof(Preset.AddListeners))]
    internal static class Preset_AddListeners_Patch
    {
        public static void Postfix(Preset __instance)
        {
            //Add the click detector.  Not sure where the object is actually created on load,
            //  but this is a low call count.
            if (__instance.load.GetComponent<ClickableObject>() == null)
            {
                ClickableObject clickableObject = __instance.load.gameObject
                    .AddComponent<ClickableObject>();

                clickableObject.Data = new WeakReference<Preset>(__instance);
                clickableObject.OnRightClick += ClickableObject_OnRightClick;
            }
        }

        private static void ClickableObject_OnRightClick(object sender, PointerEventData e)
        {
            ClickableObject clickable = (ClickableObject)sender;

            WeakReference<Preset> presetRef = clickable.Data as WeakReference<Preset>;

            if (!presetRef.TryGetTarget(out Preset preset)) return;

            Button loadButton = preset.load;

            if (loadButton is null || !loadButton.isActiveAndEnabled ||
                !loadButton.IsInteractable()) return;

            LoadClicked(preset);
        }

        private static void LoadClicked(Preset preset)
        {
            preset.saveConfirm.gameObject.SetActive(value: false);
            preset.save.gameObject.SetActive(value: true);
            LoadCrew(preset);
            Preset[] presets = Instance.presets;
            for (int i = 0; i < presets.Length; i++)
            {
                presets[i].highlight.SetActive(value: false);
            }
            preset.highlight.SetActive(value: true);
        }

        /// <summary>
        /// This is the same as the game's Preset.Load function, but only includes the crew loading.
        /// </summary>
        /// <param name="instance"></param>
        private static void LoadCrew(Preset instance)
        {
            int index = instance.index;

            Ship ship = PerFrameCache.FindFlagship(Ownership.Owner.Me);
            if (ship != null && index >= 0 && index < ship.crewAndPowerPresets.Count
                && ship.crewAndPowerPresets[index] != null)
            {
                Ship.CrewAndPowerPreset crewAndPowerPreset = ship.crewAndPowerPresets[index];

                if (crewAndPowerPreset.crewPosMap != null && crewAndPowerPreset.crewRoleMap != null && crewAndPowerPreset.crewModuleMap != null)
                {
                    ship.LoadCrewPreset(crewAndPowerPreset.crewPosMap, crewAndPowerPreset.crewRoleMap, crewAndPowerPreset.crewModuleMap);
                }
            }
        }



    }
}
