using LaciSynchroni.API.Data;
using LaciSynchroni.API.Data.Enum;
using MessagePack;

namespace LaciSynchroni.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPermissionDto(GroupData Group, GroupPermissions Permissions) : GroupDto(Group);