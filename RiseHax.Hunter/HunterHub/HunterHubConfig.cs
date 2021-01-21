using System.ComponentModel;

// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global

namespace RiseHax.Hunter
{
    public sealed class HunterHubConfig
    {
        private const string FeatureToggle = nameof(FeatureToggle);
        private const string Operation = nameof(Operation);
        private const string Bots = nameof(Bots);
        private const string Integration = nameof(Integration);
        private const string Debug = nameof(Debug);

        [Category(Operation)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public FolderSettings Folder { get; set; } = new();
    }
}