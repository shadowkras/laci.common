using LaciSynchroni.API.Data;
using LaciSynchroni.API.Data.Enum;
using MessagePack;

namespace LaciSynchroni.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserPermissionsDto(UserData User, UserPermissions Permissions) : UserDto(User);
