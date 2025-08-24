using SinusSynchronous.API.Data;
using SinusSynchronous.API.Data.Enum;
using MessagePack;

namespace SinusSynchronous.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPermissionDto(GroupData Group, GroupPermissions Permissions) : GroupDto(Group);