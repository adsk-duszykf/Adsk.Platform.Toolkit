// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Autodesk.ACC.AccountAdmin.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    /// <summary>The status of this account user.  Valid values are `active`, `not_invited`, `pending`, `disabled`, and `deleted`.</summary>
    public enum AccountUser_status
    {
        [EnumMember(Value = "active")]
        #pragma warning disable CS1591
        Active,
        #pragma warning restore CS1591
        [EnumMember(Value = "not_invited")]
        #pragma warning disable CS1591
        Not_invited,
        #pragma warning restore CS1591
        [EnumMember(Value = "pending")]
        #pragma warning disable CS1591
        Pending,
        #pragma warning restore CS1591
        [EnumMember(Value = "disabled")]
        #pragma warning disable CS1591
        Disabled,
        #pragma warning restore CS1591
        [EnumMember(Value = "deleted")]
        #pragma warning disable CS1591
        Deleted,
        #pragma warning restore CS1591
    }
}