using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace AirportCEOStaffImprovements.PersistientEmployeeTypeFilter
{
    public static class Patch_EmployeePanelUI
    {
        [HarmonyPatch(typeof(EmployeePanelUI), "LoadPanel")]
        [HarmonyPrefix]
        public static bool Prefix_LoadPanel_toInjectStoredFilter(ref int ___employeeFilterValue)
        {
            ___employeeFilterValue = PersistientEmpTypeValueHolder.filterValue;
            return true;
        }

        [HarmonyPatch(typeof(EmployeePanelUI), "FilterEmployeeByType")]
        [HarmonyPostfix]

        public static void Postfix_FilterBy_toStoreValue(int ___employeeFilterValue)
        {
            PersistientEmpTypeValueHolder.filterValue = ___employeeFilterValue;
        }
    }
}
