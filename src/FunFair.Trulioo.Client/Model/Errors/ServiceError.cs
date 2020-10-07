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
        public string Code { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        public string Message { get; set; }
    }
}