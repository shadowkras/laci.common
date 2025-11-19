using MessagePack;

namespace LaciSynchroni.Common.Dto.User
{
    [MessagePackObject(keyAsPropertyName: true)]
    public sealed class UserPairNotificationDto
    {
        public required string MyHashedCid { get; init; }
        public required string Message { get; init; }
    }
}
