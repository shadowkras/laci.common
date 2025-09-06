using LaciSynchroni.Common.Data.Enum;
using MessagePack;

namespace LaciSynchroni.Common.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record BulkPermissionsDto(Dictionary<string, UserPermissions> AffectedUsers, Dictionary<string, GroupUserPreferredPermissions> AffectedGroups);
