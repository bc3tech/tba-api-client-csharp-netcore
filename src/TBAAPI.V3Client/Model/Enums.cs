namespace TBAAPI.V3Client.Model;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

/// <summary>
/// The competition level the match was played at.
/// </summary>
/// <value>The competition level the match was played at.</value>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CompLevelEnum
{
    /// <summary>
    /// Enum Qm for value: qm
    /// </summary>
    [EnumMember(Value = "qm")]
    Qm = 1,

    /// <summary>
    /// Enum Ef for value: ef
    /// </summary>
    [EnumMember(Value = "ef")]
    Ef = 2,

    /// <summary>
    /// Enum Qf for value: qf
    /// </summary>
    [EnumMember(Value = "qf")]
    Qf = 3,

    /// <summary>
    /// Enum Sf for value: sf
    /// </summary>
    [EnumMember(Value = "sf")]
    Sf = 4,

    /// <summary>
    /// Enum F for value: f
    /// </summary>
    [EnumMember(Value = "f")]
    F = 5
}

/// <summary>
/// The color (red/blue) of the winning alliance. Will contain an empty string in the event of no winner, or a tie.
/// </summary>
/// <value>The color (red/blue) of the winning alliance. Will contain an empty string in the event of no winner, or a tie.</value>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum WinningAllianceEnum
{
    /// <summary>
    /// Enum Red for value: red
    /// </summary>
    [EnumMember(Value = "red")]
    Red = 1,

    /// <summary>
    /// Enum Blue for value: blue
    /// </summary>
    [EnumMember(Value = "blue")]
    Blue = 2,

    /// <summary>
    /// Enum Empty for value: 
    /// </summary>
    [EnumMember(Value = "")]
    Empty = 3
}

/// <summary>
/// String type of the media element.
/// </summary>
/// <value>String type of the media element.</value>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TypeEnum
{
    /// <summary>
    /// Enum Youtube for value: youtube
    /// </summary>
    [EnumMember(Value = "youtube")]
    Youtube = 1,

    /// <summary>
    /// Enum Cdphotothread for value: cdphotothread
    /// </summary>
    [EnumMember(Value = "cdphotothread")]
    Cdphotothread = 2,

    /// <summary>
    /// Enum Imgur for value: imgur
    /// </summary>
    [EnumMember(Value = "imgur")]
    Imgur = 3,

    /// <summary>
    /// Enum FacebookProfile for value: facebook-profile
    /// </summary>
    [EnumMember(Value = "facebook-profile")]
    FacebookProfile = 4,

    /// <summary>
    /// Enum YoutubeChannel for value: youtube-channel
    /// </summary>
    [EnumMember(Value = "youtube-channel")]
    YoutubeChannel = 5,

    /// <summary>
    /// Enum TwitterProfile for value: twitter-profile
    /// </summary>
    [EnumMember(Value = "twitter-profile")]
    TwitterProfile = 6,

    /// <summary>
    /// Enum GithubProfile for value: github-profile
    /// </summary>
    [EnumMember(Value = "github-profile")]
    GithubProfile = 7,

    /// <summary>
    /// Enum InstagramProfile for value: instagram-profile
    /// </summary>
    [EnumMember(Value = "instagram-profile")]
    InstagramProfile = 8,

    /// <summary>
    /// Enum PeriscopeProfile for value: periscope-profile
    /// </summary>
    [EnumMember(Value = "periscope-profile")]
    PeriscopeProfile = 9,

    /// <summary>
    /// Enum Grabcad for value: grabcad
    /// </summary>
    [EnumMember(Value = "grabcad")]
    Grabcad = 10,

    /// <summary>
    /// Enum InstagramImage for value: instagram-image
    /// </summary>
    [EnumMember(Value = "instagram-image")]
    InstagramImage = 11,

    /// <summary>
    /// Enum ExternalLink for value: external-link
    /// </summary>
    [EnumMember(Value = "external-link")]
    ExternalLink = 12,

    /// <summary>
    /// Enum Avatar for value: avatar
    /// </summary>
    [EnumMember(Value = "avatar")]
    Avatar = 13
}