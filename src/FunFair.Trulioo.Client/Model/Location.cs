using FunFair.Trulioo.Client.Model.LocationFields;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     Location/Address.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Location
    {
        /// <summary>
        ///     House / Civic / Building number of home address
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string BuildingNumber { get; set; }

        /// <summary>
        ///     Name of building of home address
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string BuildingName { get; set; }

        /// <summary>
        ///     Flat/Unit/Apartment number of home address
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string UnitNumber { get; set; }

        /// <summary>
        ///     Street name of primary residence
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string StreetName { get; set; }

        /// <summary>
        ///     Street type of primary residence (Typically St, Rd etc)
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string StreetType { get; set; }

        /// <summary>
        ///     City of home address
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string City { get; set; }

        /// <summary>
        ///     Suburb / Subdivision / Municipality of home address
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string Suburb { get; set; }

        /// <summary>
        ///     County / District of home address
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string County { get; set; }

        /// <summary>
        ///     State of primary residence. US sources expect 2 characters. Australian sources expect 2 or 3 characters.
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string StateProvinceCode { get; set; }

        /// <summary>
        ///     Country of physical address (ISO 3166-1 alpha-2 code)
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string Country { get; set; }

        /// <summary>
        ///     ZIP Code or Postal Code of home address
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string PostalCode { get; set; }

        /// <summary>
        ///     Not part of trulioo v1 API spec
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public AdditionalFields AdditionalFields { get; set; } = new();
    }
}