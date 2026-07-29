using System.Collections.Generic;

namespace ParcelInspector.Core.Runtime
{
    [System.Serializable]
    public class InventoryRuntimeData
    {
        public List<int> OwnedScannerSkins = new();

        public List<int> OwnedDeskThemes = new();

        public List<int> OwnedWarehouseThemes = new();
    }
}