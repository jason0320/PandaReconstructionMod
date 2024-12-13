using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace PandaReconstructionMod
{
    [HarmonyPatch]
    internal class ReconPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(InvOwnerReconstruction), "ShouldShowGuide")]
        static void Postfix(ref bool __result)
        {
            __result = true;
        }
    }
}
