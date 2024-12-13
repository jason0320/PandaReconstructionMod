using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using HarmonyLib;

namespace PandaReconstructionMod
{
    [BepInPlugin("panda.recon.mod", "Panda's Reconstruction Mod", "1.0.0.0")]
    internal class Mod_PandaReconstructionMod : BaseUnityPlugin
    {
        private void Start()
        {
            var harmony = new Harmony("Panda's Reconstruction Mod");
            harmony.PatchAll();
        }
    }
}
