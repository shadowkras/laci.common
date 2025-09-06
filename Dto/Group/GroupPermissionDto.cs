using LaciSynchroni.Common.Data;
using LaciSynchroni.Common.Data.Enum;
using MessagePack;

namespace LaciSynchroni.Common.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPermissionDto(GroupData Group, GroupPermissions Permissions) : GroupDto(Group);