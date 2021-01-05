namespace FunFair.Trulioo.Client.Model.BusinessSearch
{
    /// <summary>
    ///     Name value pairs of address found from business search
    /// </summary>

    // ReSharper disable once ClassNeverInstantiated.Global
    public class SearchResultAddress
    {
        /// <summary>
        ///     Flat/Unit/Apartment number of address
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string UnitNumber { get; set; }

        /// <summary>
        ///     House / Civic / Building number of address
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string BuildingNumber { get; set; }

        /// <summary>
        ///     Name of building
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string BuildingName { get; set; }

        /// <summary>
        ///     Street name
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string StreetName { get; set; }

        /// <summary>
        ///     Street type of address (Typically St, Rd etc)
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string StreetType { get; set; }

        /// <summary>
        ///     City
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string City { get; set; }

        /// <summary>
        ///     Suburb / Subdivision / Municipality
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string Suburb { get; set; }

        /// <summary>
        ///     State or province of address. US sources expect 2 characters. Australian sources expect 2 or 3 characters.
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string StateProvinceCode { get; set; }

        /// <summary>
        ///     ZIP Code or Postal Code
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string PostalCode { get; set; }

        /// <summary>
        ///     Address Type
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string AddressType { get; set; }

        /// <summary>
        ///     Address1
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string Address1 { get; set; }

        /// <summary>
        ///     State or province of address
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string StateProvince { get; set; }
    }
}