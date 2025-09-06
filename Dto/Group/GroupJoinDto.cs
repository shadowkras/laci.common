using LaciSynchroni.Common.Data;
using LaciSynchroni.Common.Data.Enum;
using MessagePack;

namespace LaciSynchroni.Common.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPasswordDto(GroupData Group, string Password) : GroupDto(Group);

[MessagePackObject(keyAsPropertyName: true)]
public record GroupJoinDto(GroupData Group, string Password, GroupUserPreferredPermissions GroupUserPreferredPermissions) : GroupPasswordDto(Group, Password);