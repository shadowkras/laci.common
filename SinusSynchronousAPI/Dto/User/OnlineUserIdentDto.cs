using SinusSynchronous.API.Data;
using MessagePack;

namespace SinusSynchronous.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record OnlineUserIdentDto(UserData User, string Ident) : UserDto(User);