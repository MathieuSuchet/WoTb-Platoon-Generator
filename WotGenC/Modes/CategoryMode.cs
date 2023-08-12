using System.Security;

namespace WotGenC.Modes
{
    public class CategoryMode : Mode
    {
        public TankType SelectedType { get; set; }
        public Mode SubMode { get; set; }

        public CategoryMode(TankType selectedType, Mode subMode)
        {
            SubMode = subMode;
            SelectedType = selectedType;

            Name = "One tank type only | " + SubMode.Name;
            Description = SelectedType.ToString("G") + " tanks only. " + SubMode.Description;
        }
    }
}