using System.Threading;

public static class StringLiteral
{
    #region SCENE NAME
    public const string LOBBY = "Lobby";
    public const string INGAME = "InGame";
    public const string RESULT = "GameResult";
    #endregion

    #region CONNECTION INFO TEXT
    public const string CONNECT_SERVER = "서버에 접속 중입니다.";
    public const string CONNECTION_SUCCESS = "서버 연결에 성공하였습니다.";
    public const string CONNECTION_FAILURE = "서버 연결에 실패하였습니다.";
    public const string ENTER_ROOM = "룸에 접속 중입니다.";
    public const string CREATE_ROOM = "게임이 없습니다. 새로 생성합니다.";
    public const string WAIT_PLAYER = "아레나가 열리고 있습니다. 상대를 기다리고 있습니다.";
    #endregion

    #region DATA PATH
    public const string LEGEND_STAT_DATA_PATH = "Assets/Resources/Data/LegendStatData.csv";
    #endregion

    #region FOLDER PATH
    public const string PREFAB_FOLDER = "Prefab";
    public const string SUFFIX_INGAME = "_Ingame";
    public const string MAP_PREFAB_PATH = "Map/SingleLogBridge";
    public const string UI_FOLDER = "UI";
    public const string UI_SPRITE_FOLDER = "UI/Sprite";
    public const string UI_GAME_RESULT_POPUP = "UI_GameResultPopup";
    public const string TOP_DECO_SPRITE = "_TopDeco_";
    public const string SOUND = "Sound";
    public const string VOICE = "Voice";
    public const string SFX = "SFX";
    public const string BGM = "BGM";
    #endregion

    #region LegendController 
    public static readonly string[] ACTIONS = new[] { "Move", "Jump", "DefaultAttack", "SmashAttack", "SkillAttack" };
    public static readonly string[] ANIMATION_CLIP = new[] { "Peter_FirstAttack", "Peter_SecondAttack" };
    public const string JUMP_ANIMATION_CLIP = "Peter_JumpAttack";
    public const string ALICE_BOMB = "AliceBomb";
    #endregion

    #region Tag
    public const string HANGZONE = "HangZone";
    public const string GROUND = "Ground";
    public const string PLAYER = "Player";
    public const string DEFAULT_HIT = "DefaultHit";
    public const string HEAVY_HIT = "HeavyHit";
    #endregion

    #region INPUT ACTION MAP
    public const string PLAYER_INPUT = "PlayerInput";
    public const string FIRST_PLAYER_ACTIONS = "FirstPlayerActions";
    public const string SECOND_PLAYER_ACTIONS = "SecondPlayerActions";
    #endregion

    #region LAYER NAME
    public const string TEAM_BLUE = "TeamBlue";
    public const string TEAM_RED = "TeamRed";
    public const string HANG_ZONE = "HangZone";
    public const string HIT_ZONE = "HitZone";
    #endregion

    #region MAP
    public const string SPAWN_POINTS = "SpawnPoints";
    #endregion

    #region BGM
    public const string BGM_TITLE = "Title";
    public const string BGM_LOBBY = "Lobby";
    public const string BGM_MATCH = "Match";
    public const string BGM_STAGE = "Stage";
    public const string BGM_GAMERESULT = "GameResult";
    #endregion

    #region UI SFX
    public const string SFX_BUTTON = "Button";
    public const string SFX_GAMEMODESTART = "GameModeStart";
    public const string SFX_MATCH_START = "Match_Start";
    public const string SFX_MATCH_OVER = "Match_Over";
    public const string SFX_REMOVEPANEL = "RemovePanel";
    #endregion

    #region Legend SFX
    // Legend Common SFX
    public const string SFX_DEFAULTATTACK_ZERO = "DefaultAttack00";
    public const string SFX_DEFAULTATTACK_ONE = "DefaultAttack01";
    public const string SFX_DEFAULTATTACK_TWO = "DefaultAttack02";
    public const string SFX_DEFAULTATTACK_THREE = "DefaultAttack03";
    public const string SFX_DEFAULTATTACK_HIT = "DefaultAttack_Hit";
    public const string SFX_DOWN = "Down";
    public const string SFX_HANG = "Hang";
    public const string SFX_HEAVYATTACK = "HeavyAttack";
    public const string SFX_HEAVYATTACK_HIT = "HeavyAttack_Hit";
    public const string SFX_JUMP = "Jump";
    public const string SFX_JUMPATTACK = "JumpAttack";
    public const string SFX_JUMPLANDING = "JumpLanding";
    public const string SFX_ROLLBACK = "RollBack";
    public const string SFX_ROLLFRONT = "RollFront";
    public const string SFX_SKILLATTACK = "SkillAttack";
    public const string SFX_SKILLATTACK_HIT = "SkillAttack_Hit";
    public const string SFX_STEP = "Step0";
    public const string SFX_LEGEND_DEAD = "Legend_Dead";
    public const string SFX_LEGEND_SMASH = "Legend_Smash";
    public const string SFX_LEGEND_REVIVE = "Legend_Revive"; // TODO : 부활작업 완료시 재생
    // Legend Individual SFX
    public const string SFX_SKILLATTACK_SHOT = "SkillAttack_Shot";
    public const string SFX_SKILLATTACK_END = "SkillAttack_End";

    public const string SFX_MINE_ACTIVATE = "MineActivate";
    public const string SFX_MINE_EXPLODE = "MineExplode";
    public const string SFX_MINE_SET = "MineSet";
    #endregion

    #region Legend Voice
    public const string VOICE_WIN = "Win";
    #endregion
}