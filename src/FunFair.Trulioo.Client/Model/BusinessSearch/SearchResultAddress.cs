using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Model.BusinessSearch
{
    /// <summary>
    ///     Name value pairs of address found from business search
    /// </summary>

    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
    public class SearchResultAddress
    {
        /// <summary>
        ///     Flat/Unit/Apartment number of address
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string UnitNumber { get; set; }

        /// <summary>
        ///     House / Civic / Building number of address
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string BuildingNumber { get; set; }

        /// <summary>
        ///     Name of building
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string BuildingName { get; set; }

        /// <summary>
        ///     Street name
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string StreetName { get; set; }

        /// <summary>
        ///     Street type of address (Typically St, Rd etc)
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string StreetType { get; set; }

        /// <summary>
        ///     City
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string City { get; set; }

        /// <summary>
        ///     Suburb / Subdivision / Municipality
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string Suburb { get; set; }

        /// <summary>
        ///     State or province of address. US sources expect 2 characters. Australian sources expect 2 or 3 characters.
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string StateProvinceCode { get; set; }

        /// <summary>
        ///     ZIP Code or Postal Code
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string PostalCode { get; set; }

        /// <summary>
        ///     Address Type
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string AddressType { get; set; }

        /// <summary>
        ///     Address1
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string Address1 { get; set; }

        /// <summary>
        ///     State or province of address
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string StateProvince { get; set; }
    }
}
