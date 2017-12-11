using Edu.Wisc.Forest.Flel.Util;

namespace Landis.Library.Succession
{
    /// <summary>
    /// Utility methods for the enumerated type SeedingAlgorithms.
    /// </summary>
    public static class SeedingAlgorithmsUtil
    {
        /// <summary>
        /// Parses a word into a SeedingAlgorithm.
        /// </summary>
        /// <exception cref="System.FormatException">
        /// The word doesn't match any of these: "NoDispersal",
        /// "UniversalDispersal", "WardSeedDispersal".
        /// </exception>
        public static SeedingAlgorithms Parse(string word)
        {
            switch (word)
            {
                case "NoDispersal":
                    return SeedingAlgorithms.NoDispersal;
                case "UniversalDispersal":
                    return SeedingAlgorithms.UniversalDispersal;
                case "WardSeedDispersal":
                    return SeedingAlgorithms.WardSeedDispersal;
            }

            throw new System.FormatException("Valid algorithms: NoDispersal, UniversalDispersal, WardSeedDispersal");
        }

        //---------------------------------------------------------------------

        /// <summary>
        /// Registers the appropriate method for reading input values of the
        /// type SeedingAlgorithms.
        /// </summary>
        public static void RegisterForInputValues()
        {
            Type.SetDescription<SeedingAlgorithms>("seeding algorithm");
            InputValues.Register<SeedingAlgorithms>(Parse);
        }
    }
}
