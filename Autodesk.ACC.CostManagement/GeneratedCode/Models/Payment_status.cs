// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Autodesk.ACC.CostManagement.Models {
    /// <summary>The status of this payment.</summary>
    public enum Payment_status
    {
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "pendingInput")]
        PendingInput,
        [EnumMember(Value = "submitted")]
        Submitted,
        [EnumMember(Value = "revise")]
        Revise,
        [EnumMember(Value = "accepted")]
        Accepted,
        [EnumMember(Value = "approved")]
        Approved,
        [EnumMember(Value = "paid")]
        Paid,
    }
}
