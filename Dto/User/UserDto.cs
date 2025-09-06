using LaciSynchroni.Common.Data;
using MessagePack;

namespace LaciSynchroni.Common.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserDto(UserData User);