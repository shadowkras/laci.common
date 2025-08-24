using SinusSynchronous.API.Data;
using SinusSynchronous.API.Data.Enum;
using MessagePack;

namespace SinusSynchronous.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserIndividualPairStatusDto(UserData User, IndividualPairStatus IndividualPairStatus) : UserDto(User);