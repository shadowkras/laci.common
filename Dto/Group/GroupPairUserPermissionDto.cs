using LaciSynchroni.Common.Data;
using LaciSynchroni.Common.Data.Enum;
using MessagePack;

namespace LaciSynchroni.Common.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairUserPermissionDto(GroupData Group, UserData User, GroupUserPreferredPermissions GroupPairPermissions) : GroupPairDto(Group, User);