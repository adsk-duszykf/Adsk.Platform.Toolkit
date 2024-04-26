using System.Runtime.Serialization;

namespace Autodesk.Authentication.Helpers.Models
{
    public enum AuthenticationScope
    {
        [EnumMember(Value = "user-profile:read")]
        UserProfileRead,
        [EnumMember(Value = "user:read")]
        UserRead,
        [EnumMember(Value = "user:write")]
        UserWrite,
        [EnumMember(Value = "viewables:read")]
        ViewablesRead,
        [EnumMember(Value = "data:read")]
        DataRead,
        [EnumMember(Value = "data:write")]
        DataWrite,
        [EnumMember(Value = "data:create")]
        DataCreate,
        [EnumMember(Value = "data:search")]
        DataSearch,
        [EnumMember(Value = "bucket:create")]
        BucketCreate,
        [EnumMember(Value = "bucket:read")]
        BucketRead,
        [EnumMember(Value = "bucket:update")]
        BucketUpdate,
        [EnumMember(Value = "bucket:delete")]
        BucketDelete,
        [EnumMember(Value = "code:all")]
        CodeAll,
        [EnumMember(Value = "account:read")]
        AccountRead,
        [EnumMember(Value = "account:write")]
        AccountWrite,
        [EnumMember(Value = "openid")]
        OpenId,
    }
}
