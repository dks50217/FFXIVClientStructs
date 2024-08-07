namespace FFXIVClientStructs.FFXIV.Client.Game.UI;

// Client::Game::UI::ContentsFinder
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0xB0)]
public unsafe partial struct ContentsFinder {
    [StaticAddress("0F B6 FA 48 8D 0D ?? ?? ?? ?? E8 ?? ?? ?? ?? 80 78 59 02", 6)]
    public static partial ContentsFinder* Instance();

    [FieldOffset(0x18)] public LootRule LootRules;

    [FieldOffset(0x19)] public bool IsUnrestrictedParty;
    [FieldOffset(0x1A)] public bool IsMinimalIL;
    [FieldOffset(0x1B)] public bool IsSilenceEcho;
    [FieldOffset(0x1C)] public bool IsExplorerMode;
    [FieldOffset(0x1D)] public bool IsLevelSync;
    [FieldOffset(0x1E)] public bool IsLimitedLevelingRoulette;
    [FieldOffset(0x20)] public ContentsFinderQueueInfo QueueInfo;

    public enum LootRule : byte {
        Normal = 0,
        GreedOnly = 1,
        Lootmaster = 2
    }
}

[StructLayout(LayoutKind.Explicit, Size = 0x90)]
public struct ContentsFinderQueueInfo {
    [FieldOffset(0x04)] public uint QueuedContentFinderConditionId1;
    [FieldOffset(0x0C)] public uint QueuedContentFinderConditionId2;
    [FieldOffset(0x14)] public uint QueuedContentFinderConditionId3;
    [FieldOffset(0x1C)] public uint QueuedContentFinderConditionId4;
    [FieldOffset(0x24)] public uint QueuedContentFinderConditionId5;

    [FieldOffset(0x28)] public uint QueuedClassJobId;

    [FieldOffset(0x40)] public int EnteredQueueTimestamp;
    [FieldOffset(0x44)] public int QueueReadyTimestamp;

    [FieldOffset(0x55)] public QueueStates QueueState;

    [FieldOffset(0x5A)] public byte QueuedContentRouletteId;

    [FieldOffset(0x5C)] public sbyte PositionInQueue;

    [FieldOffset(0x67)] public byte AverageWaitTime; // In minutes

    [FieldOffset(0x7C)] public PoppedContentTypes PoppedContentType;

    /// <remarks>
    /// Based on <see cref="PoppedContentType"/>, either a row id of the ContentRoulette
    /// sheet for Roulettes or a row id of the ContentFinderCondition sheet for Duties.
    /// </remarks>
    [FieldOffset(0x80)] public uint PoppedContentId;

    [FieldOffset(0x88)] public bool PoppedContentIsUnrestrictedParty;
    [FieldOffset(0x89)] public bool PoppedContentIsMinimalIL;
    [FieldOffset(0x8A)] public bool PoppedContentIsLevelSync;
    [FieldOffset(0x8B)] public bool PoppedContentIsSilenceEcho;
    [FieldOffset(0x8C)] public bool PoppedContentIsExplorerMode;

    public DateTime GetEnteredQueueDateTime() => DateTime.UnixEpoch.AddSeconds(EnteredQueueTimestamp);
    public DateTime GetQueueReadyDateTime() => DateTime.UnixEpoch.AddSeconds(QueueReadyTimestamp);

    public enum QueueStates : byte {
        None = 0,
        Pending = 1,
        Queued = 2,
        Ready = 3,
        Accepted = 4,
        InContent = 5
    }

    public enum PoppedContentTypes : byte {
        None = 0,
        Roulette = 1,
        Duty = 2
    }
}
