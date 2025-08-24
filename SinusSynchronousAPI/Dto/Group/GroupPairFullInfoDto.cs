using SinusSynchronous.API.Data;
using SinusSynchronous.API.Data.Enum;
using MessagePack;

namespace SinusSynchronous.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairFullInfoDto(GroupData Group, UserData User, UserPermissions SelfToOtherPermissions, UserPermissions OtherToSelfPermissions) : GroupPairDto(Group, User);