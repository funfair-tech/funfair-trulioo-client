using System;
using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Exceptions;

/// <inheritdoc />
public sealed class AuthenticationFailureException : RequestException
{
    /// <inheritdoc />
    internal AuthenticationFailureException(string message, int code, string reason)
        : base(message: message, code: code, reason: reason)
    {
    }

    /// <inheritdoc />
    [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
    public AuthenticationFailureException()
        : base(message: "", code: -1, reason: "")
    {
    }

    /// <inheritdoc />
    [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
    public AuthenticationFailureException(string message)
        : base(message: message, code: -1, reason: "")
    {
    }

    /// <inheritdoc />
    [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
    public AuthenticationFailureException(string message, Exception innerException)
        : base(message: message, code: -1, reason: innerException.Message)
    {
    }
}