using LaciSynchroni.API.Data;
using LaciSynchroni.API.Data.Enum;
using MessagePack;

namespace LaciSynchroni.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPasswordDto(GroupData Group, string Password) : GroupDto(Group);

[MessagePackObject(keyAsPropertyName: true)]
public record GroupJoinDto(GroupData Group, string Password, GroupUserPreferredPermissions GroupUserPreferredPermissions) : GroupPasswordDto(Group, Password);