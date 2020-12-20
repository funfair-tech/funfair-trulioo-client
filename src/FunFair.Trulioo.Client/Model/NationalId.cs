namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    /// National Id.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class NationalId
    {
        /// <summary>
        /// National ID Number.
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string Number { get; set; }

        /// <summary>
        ///     Supported Types: NationalID, Health, SocialService
        ///     <b>NationalID </b><br />
        ///     <ul>
        ///         <li>China - National ID Number</li>
        ///         <li>Finland - PIC</li>
        ///         <li>France - InseeNumber</li>
        ///         <li>Hong Kong - Identity Number</li>
        ///         <li>Malaysia - National Registration ID Card (NRIC) Number</li>
        ///         <li>Mexico - CURP</li>
        ///         <li>Singapore - National Registration ID Card(NRIC) Number</li>
        ///         <li>Sweden - Personal Identification Number(PIN)</li>
        ///     </ul>
        ///     <b>Health</b><br />
        ///     <ul>
        ///         <li>Australia Medicare</li>
        ///         <li>UK - NHS Number</li>
        ///     </ul>
        ///     <b>SocialService</b><br />
        ///     <ul>
        ///         <li>Australia - Tax File Number</li>
        ///         <li>Canada - Social Insurance Number</li>
        ///         <li>Ireland - Personal Public Service Number</li>
        ///         <li>Italy - Codice Fiscale</li>
        ///         <li>Mexico - Registro Federal de Contribuyentes (Tax Number)</li>
        ///         <li>UK National Insurance Number(NI)</li>
        ///         <li>US - Social Security Number</li>
        ///     </ul>
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string Type { get; set; }

        /// <summary>
        ///     District that issued the ID
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string DistrictOfIssue { get; set; }

        /// <summary>
        ///     City that issued the ID
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string CityOfIssue { get; set; }

        /// <summary>
        ///     Province that issued the ID
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string ProvinceOfIssue { get; set; }

        /// <summary>
        ///     County that issued the ID
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string CountyOfIssue { get; set; }
    }
}