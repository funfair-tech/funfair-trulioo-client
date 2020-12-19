namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    /// Communication details.
    /// </summary>
    public class Communication
    {
        /// <summary>
        ///     Mobile phone number
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string MobileNumber { get; set; }

        /// <summary>
        ///     Telephone number of the individual to be verified
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string Telephone { get; set; }

        /// <summary>
        ///     Email address of the individual to be verified
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string EmailAddress { get; set; }
    }
}