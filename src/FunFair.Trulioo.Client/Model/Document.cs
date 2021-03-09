using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     Name value pairs of document information to be passed for verification
    /// </summary>

    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
    public class Document
    {
        /// <summary>
        ///     Front of the document
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public byte[] DocumentFrontImage { get; set; }

        /// <summary>
        ///     Back of the document
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public byte[] DocumentBackImage { get; set; }

        /// <summary>
        ///     Selfie image
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public byte[] LivePhoto { get; set; }

        /// <summary>
        ///     Document type
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string DocumentType { get; set; }

        /// <summary>
        ///     Accept Incomplete Document.
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public bool? AcceptIncompleteDocument { get; set; }

        /// <summary>
        ///     Validate Document Image Quality.
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public bool? ValidateDocumentImageQuality { get; set; }
    }
}
