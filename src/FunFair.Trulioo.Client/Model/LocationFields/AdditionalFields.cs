using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Model.LocationFields
{
    /// <summary>
    ///     Additional Fields for Location
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "ClassCanBeSealed.Global", Justification = "TODO: Review")]
    public class AdditionalFields
    {
        /// <summary>
        ///     Address1 is available in certain countries. It can be used to pass a compiled address field instead of sending individual address attributes (such as UnitNumber, BuidlingNumber, BuildingName,
        ///     StreetName and StreetType).
        ///     GlobalGateway will provide a passthru of Address1 directly to connected datasources for the selected country.
        ///     Please note: each datasource requires the address fields to be configured in a certain manner, implementing and sending Address1 instead of individual address fields may affect your ability to
        ///     verify this address.
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string Address1 { get; set; }
    }
}