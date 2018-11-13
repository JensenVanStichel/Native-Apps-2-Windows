using System.ComponentModel.DataAnnotations;

namespace CityApp.Model
{
    public enum Provincie
    {
        Antwerpen,
        Limburg,
        [Display(Description = "Oost-Vlaanderen")]
        Oost_vlaanderen,
        [Display(Description = "Vlaams Brabant")]
        Vlaams_brabant,
        [Display(Description = "West-Vlaanderen")]
        West_vlaanderen,
        Henegouwen,
        Luik,
        Luxemburg,
        Namen,
        [Display(Description = "Waals Brabant")]
        Waals_brabant,
        [Display(Description = "Brussels Hoofstedelijk Gewest")]
        BHG
    }
}