using Landis.Core;
using Landis.SpatialModeling;

namespace Landis.Library.Succession
{
    /// <summary>
    /// Seeding algorithm where no species can seed a neighboring site.
    /// Only the current site is checked.
    /// </summary>
    public static class NoDispersal
    {
        public static bool Algorithm(ISpecies   species,
                                     ActiveSite site)
        {
            return Reproduction.SufficientResources(species, site) &&
                   Reproduction.Establish(species, site) &&
                   Reproduction.MaturePresent(species, site);                  
        }
    }
}
