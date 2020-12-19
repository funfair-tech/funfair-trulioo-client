namespace FunFair.Trulioo.Client.Model.Errors
{
    /// <summary>
    /// A Service error.
    /// </summary>
    public class ServiceError
    {
        /// <summary>
        /// Error code.
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string Code { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string Message { get; set; }
    }
}