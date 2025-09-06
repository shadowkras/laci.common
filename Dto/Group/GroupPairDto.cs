using LaciSynchroni.Common.Data;
using MessagePack;

namespace LaciSynchroni.Common.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairDto(GroupData Group, UserData User) : GroupDto(Group)
{
    public string UID => User.UID;
    public string? UserAlias => User.Alias;
    public string UserAliasOrUID => User.AliasOrUID;
}