using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Model;

/// <summary>
///     A Data field.
/// </summary>
[SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
public class DataField
{
    /// <summary>
    ///     The field name.
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
    public string FieldName { get; set; }

    /// <summary>
    ///     The value.
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
    public string Value { get; set; }

    /// <summary>
    ///     The field group.
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
    public string FieldGroup { get; set; }
}