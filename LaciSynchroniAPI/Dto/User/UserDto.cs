using LaciSynchroni.API.Data;
using MessagePack;

namespace LaciSynchroni.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserDto(UserData User);