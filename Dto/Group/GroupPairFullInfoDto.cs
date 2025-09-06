using LaciSynchroni.Common.Data;
using LaciSynchroni.Common.Data.Enum;
using MessagePack;

namespace LaciSynchroni.Common.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairFullInfoDto(GroupData Group, UserData User, UserPermissions SelfToOtherPermissions, UserPermissions OtherToSelfPermissions) : GroupPairDto(Group, User);