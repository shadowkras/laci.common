using LaciSynchroni.Common.Data;
using MessagePack;

namespace LaciSynchroni.Common.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserCharaDataMessageDto(List<UserData> Recipients, CharacterData CharaData, CensusDataDto? CensusDataDto);
