using LaciSynchroni.Common.Data;
using LaciSynchroni.Common.Data.Enum;
using LaciSynchroni.Common.Dto;
using LaciSynchroni.Common.Dto.CharaData;
using LaciSynchroni.Common.Dto.Group;
using LaciSynchroni.Common.Dto.User;

namespace LaciSynchroni.Common.SignalR;

public interface IServerHubClient : IServerHub
{
    void OnDownloadReady(Action<Guid> act);

    void OnGroupChangePermissions(Action<GroupPermissionDto> act);

    void OnGroupDelete(Action<GroupDto> act);

    void OnGroupPairChangeUserInfo(Action<GroupPairUserInfoDto> act);

    void OnGroupPairJoined(Action<GroupPairFullInfoDto> act);

    void OnGroupPairLeft(Action<GroupPairDto> act);

    void OnGroupSendFullInfo(Action<GroupFullInfoDto> act);

    void OnGroupSendInfo(Action<GroupInfoDto> act);

    void OnReceiveServerMessage(Action<MessageSeverity, string> act);

    void OnUpdateSystemInfo(Action<SystemInfoDto> act);

    void OnUserAddClientPair(Action<UserPairDto> act);

    void OnUserReceiveCharacterData(Action<OnlineUserCharaDataDto> act);

    void OnUserReceiveUploadStatus(Action<UserDto> act);

    void OnUserRemoveClientPair(Action<UserDto> act);

    void OnUserSendOffline(Action<UserDto> act);

    void OnUserSendOnline(Action<OnlineUserIdentDto> act);

    void OnUserUpdateOtherPairPermissions(Action<UserPermissionsDto> act);

    void OnUserUpdateProfile(Action<UserDto> act);

    void OnUserUpdateSelfPairPermissions(Action<UserPermissionsDto> act);

    void OnUserDefaultPermissionUpdate(Action<DefaultPermissionsDto> act);

    void OnUpdateUserIndividualPairStatusDto(Action<UserIndividualPairStatusDto> act);

    void OnGroupChangeUserPairPermissions(Action<GroupPairUserPermissionDto> act);

    void OnGposeLobbyJoin(Action<UserData> act);
    void OnGposeLobbyLeave(Action<UserData> act);
    void OnGposeLobbyPushCharacterData(Action<CharaDataDownloadDto> act);
    void OnGposeLobbyPushPoseData(Action<UserData, PoseData> act);
    void OnGposeLobbyPushWorldData(Action<UserData, WorldData> act);
}