using SinusSynchronous.API.Data;
using SinusSynchronous.API.Data.Enum;
using MessagePack;

namespace SinusSynchronous.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairUserPermissionDto(GroupData Group, UserData User, GroupUserPreferredPermissions GroupPairPermissions) : GroupPairDto(Group, User);