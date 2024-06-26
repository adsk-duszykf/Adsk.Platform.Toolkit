// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Autodesk.ACC.CostManagement.Models {
    /// <summary>The object type of the payment reference is associated to. Currently support only &apos;Expense`, `Payment`, `BudgetPayment`.</summary>
    public enum PaymentReferenceCreate_associationType
    {
        [EnumMember(Value = "Payment")]
        Payment,
        [EnumMember(Value = "BudgetPayment")]
        BudgetPayment,
        [EnumMember(Value = "Expense")]
        Expense,
    }
}
