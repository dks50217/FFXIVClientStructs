using System.Runtime.CompilerServices;
using FFXIVClientStructs.FFXIV.Client.Game;
using FFXIVClientStructs.FFXIV.Client.Network;
using FFXIVClientStructs.FFXIV.Client.Sound;
using FFXIVClientStructs.FFXIV.Client.System.Configuration;
using FFXIVClientStructs.FFXIV.Client.System.File;
using FFXIVClientStructs.FFXIV.Client.System.Input;
using FFXIVClientStructs.FFXIV.Client.System.Timer;
using FFXIVClientStructs.FFXIV.Client.UI;
using FFXIVClientStructs.FFXIV.Common;
using FFXIVClientStructs.FFXIV.Common.Component.BGCollision;
using FFXIVClientStructs.FFXIV.Common.Lua;
using FFXIVClientStructs.FFXIV.Component.Excel;
using FFXIVClientStructs.FFXIV.Component.Exd;
using FFXIVClientStructs.FFXIV.Component.SteamApi;

namespace FFXIVClientStructs.FFXIV.Client.System.Framework;

// Client::System::Framework::Framework
[GenerateInterop]
[VirtualTable("48 8D 05 ?? ?? ?? ?? 66 C7 41 ?? ?? ?? 48 89 01 48 8B F1", 3)]
[StructLayout(LayoutKind.Explicit, Size = 0x35F0)]
public unsafe partial struct Framework {
    [StaticAddress("49 8B DC 48 89 1D ?? ?? ?? ??", 6, isPointer: true)]
    public static partial Framework* Instance();

    [FieldOffset(0x0010)] public SystemConfig SystemConfig;
    [FieldOffset(0x0460)] public DevConfig DevConfig;
    [FieldOffset(0x0570)] public CharamakeAvatarSaveDataContainer* CharamakeAvatarSaveData;
    [FieldOffset(0x0580)] public byte ClientLanguage;
    [FieldOffset(0x0581)] public byte Region;
    [FieldOffset(0x0588)] public Cursor* Cursor;
    [FieldOffset(0x0590)] public nint CallerWindow;
    [FieldOffset(0x0598)] public FileAccessPath ConfigPath;
    [FieldOffset(0x07A8)] public GameWindow* GameWindow;
    [FieldOffset(0x07B0)] public GamepadInputData GamepadInputs;
    [FieldOffset(0x09FC)] public CursorInputData CursorInputs;
    [FieldOffset(0x0A2C)] public KeyboardInputData KeyboardInputs;
    [FieldOffset(0x0EC0)] public GamepadInputData GamepadInputs2;
    [FieldOffset(0x110C)] public CursorInputData CursorInputs2;
    [FieldOffset(0x113C)] public KeyboardInputData KeyboardInputs2;

    [FieldOffset(0x1678)] public NetworkModuleProxy* NetworkModuleProxy;
    [FieldOffset(0x1680)] public bool IsNetworkModuleInitialized;
    [FieldOffset(0x1681)] public bool EnableNetworking;
    [FieldOffset(0x1688)] public TimePoint UtcTime;
    [FieldOffset(0x16A0)] public uint TimerResolutionMillis;
    [FieldOffset(0x16A8)] public long PerformanceCounterFrequency;
    [FieldOffset(0x16B0)] public long PerformanceCounterValue;
    /// <summary>
    /// Frame time (in seconds) to use for calculating animations, tasks, game logic and such. This is not necessarily the real time since the last frame.
    /// </summary>
    [FieldOffset(0x16C0)] public float FrameDeltaTime;
    /// <summary>
    /// Holds the unaltered real time since last frame in seconds.
    /// </summary>
    [FieldOffset(0x16C4)] public float RealFrameDeltaTime;
    /// <summary>
    /// If set to anything non-zero, overrides <see cref="FrameDeltaTime"/>. Has lower precedence than <see cref="NextFrameDeltaTimeOverride"/>.
    /// </summary>
    [FieldOffset(0x16C8)] public float FrameDeltaTimeOverride;
    /// <summary>
    /// If non-zero <see cref="FrameDeltaTime"/> is multiplied with this.
    /// </summary>
    [FieldOffset(0x16CC)] public float FrameDeltaFactor;
    [FieldOffset(0x16D0)] public uint FrameCounter;
    [FieldOffset(0x16D8)] public long FrameDeltaTimeMSInt; // FrameDeltaTime in milliseconds, rounded to integer
    [FieldOffset(0x16E0)] public float FrameDeltaTimeMSRem; // sub-millisecond difference between real and rounded dt, added to the next frame
    [FieldOffset(0x16E8)] public long FrameDeltaTimeUSInt; // FrameDeltaTime in microseconds, rounded to integer
    [FieldOffset(0x16F0)] public float FrameDeltaTimeUSRem; // sub-microsecond difference between real and rounded dt, added to the next frame
    [FieldOffset(0x1700)] public TaskManager TaskManager;
    [FieldOffset(0x1770)] public ClientTime ClientTime;
    [FieldOffset(0x17B8)] public float GameSpeedMultiplier; // usually 1, but during recording replay could be different
    [FieldOffset(0x17CC)] public float FrameRate;
    [FieldOffset(0x17D0)] public int PauseFrameTicksCounter; // if non-zero, FrameDeltaTime is forced to 0 during ticks; used while displaying message boxes
    /// <summary>
    /// If set to anything non-zero, overrides <see cref="FrameDeltaTime"/>. If negative <see cref="FrameDeltaTimeOverride"/> is used and 60fps as a fallback.
    /// Unlike <see cref="FrameDeltaTimeOverride"/>, this applies only to the next frame, and is reset to zero on next tick.
    /// </summary>
    [FieldOffset(0x17D4)] public float NextFrameDeltaTimeOverride;
    [FieldOffset(0x17D8)] public bool WindowInactive;

    [FieldOffset(0x17E8)] public int DataPathType;

    [FieldOffset(0x19F4), FixedSizeArray(isString: true)] internal FixedSizeArray260<char> _gamePath;
    [FieldOffset(0x1E04), FixedSizeArray(isString: true)] internal FixedSizeArray260<char> _sqPackPath;
    [FieldOffset(0x2214), FixedSizeArray(isString: true)] internal FixedSizeArray260<char> _userPath;

    [FieldOffset(0x2B38)] public ExcelModuleInterface* ExcelModuleInterface;
    [FieldOffset(0x2B40)] public ExdModule* ExdModule;
    [FieldOffset(0x2B58)] public BGCollisionModule* BGCollisionModule;
    [FieldOffset(0x2B68)] public UIModule* UIModule;
    [FieldOffset(0x2B70)] public UIClipboard* UIClipboard;
    [FieldOffset(0x2B80)] public EnvironmentManager* EnvironmentManager;
    [FieldOffset(0x2B88)] public SoundManager* SoundManager;
    [FieldOffset(0x2BD0)] public LuaState LuaState;

    [FieldOffset(0x2BF8), FixedSizeArray(isString: true)] internal FixedSizeArray256<byte> _gameVersion;
    // 0: Heavensward
    // 1: Stormblood
    // 2: Shadowbringers
    // 3: Endwalker
    // 4: Dawntrail
    [FieldOffset(0x2CF8), FixedSizeArray] internal FixedSizeArray64<ExVersionString> _exVersions;

    [FieldOffset(0x3508)] public bool UseWatchDogThread;

    [FieldOffset(0x3518)] public int FramesUntilDebugCheck;
    /// <summary>
    /// Set if <c>IsSteam</c> was set for this instance as part of <c>SetupSteamApi</c>. Set even if loading the Steam API
    /// fails for some reason.
    /// </summary>
    [FieldOffset(0x35BC)] public bool IsSteamGame;

    /// <summary>
    /// Access the Steam API wrapper/interface.
    /// </summary>
    /// <remarks>
    /// The struct backed by this API should not be considered stable. If you use this, you are signing up for API breakage.
    /// </remarks>
    [FieldOffset(0x35C0)] public SteamApi* SteamApi;

    /// <summary>
    /// Handle (type HMODULE) of steam_api64.dll
    /// </summary>
    [FieldOffset(0x35C8)] public nint SteamApiLibraryHandle;

    [VirtualFunction(1)]
    public partial bool Setup();

    [VirtualFunction(2)]
    public partial bool Destroy();

    [VirtualFunction(3)]
    public partial void Free();

    [VirtualFunction(4)]
    public partial bool Tick();

    [MemberFunction("E8 ?? ?? ?? ?? 80 7B 1D 01")]
    public partial UIModule* GetUIModule();

    [MemberFunction("E8 ?? ?? ?? ?? 4C 8B 44 24 ?? 48 8B C8 48 8B D3")]
    public partial UIClipboard* GetUIClipboard();

    [MemberFunction("80 B9 ?? ?? ?? ?? 00 74 ?? 48 8B 81 ?? ?? ?? ?? C3")]
    public partial NetworkModuleProxy* GetNetworkModuleProxy();

    [MemberFunction("E8 ?? ?? ?? ?? 03 07")]
    public static partial long GetServerTime();

    /// <summary>
    /// Checks if the Steam API has been initialized by checking whether the <see cref="SteamApi"/> pointer is valid,
    /// and whether the sub-struct reports itself as ready.
    /// </summary>
    /// <returns>Returns true if the API is ready, false otherwise.</returns>
    [MemberFunction("E8 ?? ?? ?? ?? 88 43 08 84 C0 74 16")]
    public partial bool IsSteamApiInitialized();

    /// <summary>
    /// Set up the Steam API for the current game instance. This is automatically called when `IsSteam=1` is passed to the game,
    /// but can be called manually in certain cases. Note that this function *will* re-initialize the Steam API, so ensure that
    /// the state is checked via <see cref="IsSteamApiInitialized"/> before calling it. This method will also set
    /// <see cref="IsSteamGame"/> to true, though this seemingly has no effect (??).
    /// </summary>
    /// <returns>Returns <c>true</c> if the API was initialized successfully, false otherwise.</returns>
    [MemberFunction("48 89 5C 24 ?? 57 48 81 EC 40 02 00 00 48 8B 05")]
    public partial bool SetupSteamApi();

    [GenerateInterop]
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct ExVersionString {
        [FieldOffset(0), FixedSizeArray(isString: true)] internal FixedSizeArray32<byte> _version;
    }
}
