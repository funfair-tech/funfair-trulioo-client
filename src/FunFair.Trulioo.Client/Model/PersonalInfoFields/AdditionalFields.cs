using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Model.PersonalInfoFields
{
    /// <summary>
    ///     Additional Fields for person info
    /// </summary>

    [SuppressMessage(category: "ReSharper", checkId: "ClassCanBeSealed.Global", Justification = "TODO: Review")]
    public class AdditionalFields
    {
        /// <summary>
        ///     Full name of the individual to be verified.
        ///     Available only for countries where a person's name can not be resolved into FirstGivenName, MiddleName and FirstSurname.
        ///     Use the GET configuration/v1/fields/{configurationname}/{countrycode} to determine if this field is available for the country in question.
        ///     Data in this field will supersede information provided in FirstGivenName, MiddleName and FirstSurname
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string FullName { get; set; }
    }
}
