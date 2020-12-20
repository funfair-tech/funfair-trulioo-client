namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     Name value pairs of document information to be passed for verification
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Document
    {
        /// <summary>
        ///     Front of the document
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public byte[] DocumentFrontImage { get; set; }

        /// <summary>
        ///     Back of the document
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public byte[] DocumentBackImage { get; set; }

        /// <summary>
        ///     Selfie image
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public byte[] LivePhoto { get; set; }

        /// <summary>
        ///     Document type
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string DocumentType { get; set; }

        /// <summary>
        ///     Accept Incomplete Document.
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public bool? AcceptIncompleteDocument { get; set; }

        /// <summary>
        ///     Validate Document Image Quality.
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public bool? ValidateDocumentImageQuality { get; set; }
    }
}