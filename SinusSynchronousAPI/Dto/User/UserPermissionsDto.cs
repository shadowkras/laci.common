using SinusSynchronous.API.Data;
using SinusSynchronous.API.Data.Enum;
using MessagePack;

namespace SinusSynchronous.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserPermissionsDto(UserData User, UserPermissions Permissions) : UserDto(User);
