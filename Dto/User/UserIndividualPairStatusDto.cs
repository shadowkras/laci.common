using LaciSynchroni.Common.Data;
using LaciSynchroni.Common.Data.Enum;
using MessagePack;

namespace LaciSynchroni.Common.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserIndividualPairStatusDto(UserData User, IndividualPairStatus IndividualPairStatus) : UserDto(User);