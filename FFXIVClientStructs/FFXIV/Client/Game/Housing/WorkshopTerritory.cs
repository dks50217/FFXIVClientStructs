using FFXIVClientStructs.FFXIV.Client.System.String;

// ReSharper disable once CheckNamespace
namespace FFXIVClientStructs.FFXIV.Client.Game;

// Client::Game::WorkshopTerritory
//   Client::Game::HousingTerritory
[GenerateInterop]
[Inherits<HousingTerritory>]
[StructLayout(LayoutKind.Explicit, Size = 0xB8D0)]
public unsafe partial struct WorkshopTerritory {
    [FieldOffset(0x68)] public HousingWorkshopAirshipData Airship;

    [FieldOffset(0x2960)] public HousingWorkshopSubmersibleData Submersible;

    [FieldOffset(0xB8B0)] public HouseId HouseId;
}

[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x28F8)]
public unsafe partial struct HousingWorkshopAirshipData {
    [FieldOffset(0x0), FixedSizeArray] internal FixedSizeArray4<HousingWorkshopAirshipSubData> _data;

    [FieldOffset(0x770)] public byte ActiveAirshipId; // 0-3, 255 if none
    [FieldOffset(0x771)] public byte AirshipCount;

    [FieldOffset(0x778), FixedSizeArray] internal FixedSizeArray82<Utf8String> _airshipLogs;
}

[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x8F40)]
public unsafe partial struct HousingWorkshopSubmersibleData {
    [FieldOffset(0x0), FixedSizeArray] internal FixedSizeArray4<HousingWorkshopSubmersibleSubData> _data;

    [FieldOffset(0x8C80), FixedSizeArray] internal FixedSizeArray5<Pointer<HousingWorkshopSubmersibleSubData>> _dataPointers;
}

[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x1C0)]
public unsafe partial struct HousingWorkshopAirshipSubData {
    [FieldOffset(0x4)] public uint RegisterTime;
    [FieldOffset(0xC)] public byte RankId;
    [FieldOffset(0x10)] public uint ReturnTime;
    [FieldOffset(0x14)] public uint CurrentExp;
    [FieldOffset(0x18)] public uint NextLevelExp;

    [FieldOffset(0x20)] public ushort HullId; // AirshipExplorationPart Key
    [FieldOffset(0x22)] public ushort SternId; // AirshipExplorationPart Key
    [FieldOffset(0x24)] public ushort BowId; // AirshipExplorationPart Key
    [FieldOffset(0x26)] public ushort BridgeId; // AirshipExplorationPart Key

    [FieldOffset(0x28)] public ushort Surveillance;
    [FieldOffset(0x2A)] public ushort Retrieval;
    [FieldOffset(0x2C)] public ushort Speed;
    [FieldOffset(0x2E)] public ushort Range;
    [FieldOffset(0x30)] public ushort Favor;

    [FieldOffset(0x37), FixedSizeArray(isString: true)] internal FixedSizeArray20<byte> _name;

    [FieldOffset(0x54), FixedSizeArray] internal FixedSizeArray5<HousingWorkshopAirshipGathered> _gatheredData;

    /// <summary>
    /// Points to <see cref="HousingWorkshopAirshipData.AirshipLogs"/>
    /// Max 82 in the array
    /// </summary>
    [FieldOffset(0x1A0)] public Utf8String* Log;

    /// <summary>Gets the registered time as a <see cref="DateTime"/> object</summary>
    public DateTime GetRegisterTime() => DateTime.UnixEpoch.AddSeconds(RegisterTime);

    /// <summary>Gets the return time as a <see cref="DateTime"/> object</summary>
    public DateTime GetReturnTime() => DateTime.UnixEpoch.AddSeconds(ReturnTime);
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)]
public unsafe partial struct HousingWorkshopAirshipGathered {
    [FieldOffset(0x0)] public uint ExpGained;

    [FieldOffset(0xC)] public uint ItemIdPrimary;
    [FieldOffset(0x10)] public uint ItemIdAdditional;
    [FieldOffset(0x14)] public ushort ItemCountPrimary;
    [FieldOffset(0x16)] public ushort ItemCountAdditional;
    [FieldOffset(0x18)] public uint Unk1Primary;
    [FieldOffset(0x1C)] public uint Unk1Additional;
    [FieldOffset(0x20)] public uint Unk2Primary;
    [FieldOffset(0x24)] public uint Unk2Additional;
    [FieldOffset(0x28)] public uint Unk3Primary;
    [FieldOffset(0x2C)] public uint Unk3Additional;

    //these might actually be HQ indicators
    [FieldOffset(0x32)] public bool AirshipItemValidPrimary;
    [FieldOffset(0x33)] public bool AirshipItemValidAdditional;
}

[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x2320)]
public unsafe partial struct HousingWorkshopSubmersibleSubData {
    [FieldOffset(0x0)] public HousingWorkshopSubmersibleData* Parent;
    [FieldOffset(0xE)] public byte RankId;
    [FieldOffset(0x10)] public uint RegisterTime;
    [FieldOffset(0x14)] public uint ReturnTime;
    [FieldOffset(0x18)] public uint CurrentExp;
    [FieldOffset(0x1C)] public uint NextLevelExp;

    [FieldOffset(0x22), FixedSizeArray] internal FixedSizeArray20<byte> _name;

    [FieldOffset(0x3A)] public ushort HullId; // SubmarinePart Key
    [FieldOffset(0x3C)] public ushort SternId; // SubmarinePart Key
    [FieldOffset(0x3E)] public ushort BowId; // SubmarinePart Key
    [FieldOffset(0x40)] public ushort BridgeId; // SubmarinePart Key

    [FieldOffset(0x42), FixedSizeArray] internal FixedSizeArray5<byte> _currentExplorationPoints;

    [FieldOffset(0x4A)] public ushort SurveillanceBase;
    [FieldOffset(0x4C)] public ushort RetrievalBase;
    [FieldOffset(0x4E)] public ushort SpeedBase;
    [FieldOffset(0x50)] public ushort RangeBase;
    [FieldOffset(0x52)] public ushort FavorBase;

    [FieldOffset(0x54)] public ushort SurveillanceBonus;
    [FieldOffset(0x56)] public ushort RetrievalBonus;
    [FieldOffset(0x58)] public ushort SpeedBonus;
    [FieldOffset(0x5A)] public ushort RangeBonus;
    [FieldOffset(0x5C)] public ushort FavorBonus;
    [FieldOffset(0x60)] public SubmarineRating SubmarineRating;
    [FieldOffset(0x62)] public ushort LogSpeed;

    [FieldOffset(0x64), FixedSizeArray] internal FixedSizeArray5<HousingWorkshopSubmarineGathered> _gatheredData;

    [FieldOffset(0x1B0), FixedSizeArray] internal FixedSizeArray82<Utf8String> _logs;

    /// <summary>Gets the registered time as a <see cref="DateTime"/> object</summary>
    public DateTime GetRegisterTime() => DateTime.UnixEpoch.AddSeconds(RegisterTime);

    /// <summary>Gets the return time as a <see cref="DateTime"/> object</summary>
    public DateTime GetReturnTime() => DateTime.UnixEpoch.AddSeconds(ReturnTime);
}

public enum SubmarineRating : byte {
    SS = 0,
    S = 1,
    A = 2,
    B = 3,
    C = 4
}

[StructLayout(LayoutKind.Explicit, Size = 0x38)]
public struct HousingWorkshopSubmarineGathered {
    [FieldOffset(0x0)] public byte Point;
    [FieldOffset(0x1)] public SubmarineRating PointRating;
    [FieldOffset(0x2)] public byte UnlockedPoint;
    [FieldOffset(0x3)] public bool FirstExploration;
    [FieldOffset(0x4)] public bool AdditionalSubmarineUnlocked;
    [FieldOffset(0x5)] public bool DoubleDip;
    [FieldOffset(0x6)] public ushort UnknownUshort;
    [FieldOffset(0x8)] public uint FavorLine;
    [FieldOffset(0xC)] public uint ExpGained;
    [FieldOffset(0x10)] public uint ItemIdPrimary;
    [FieldOffset(0x14)] public uint ItemIdAdditional;
    [FieldOffset(0x18)] public ushort ItemCountPrimary;
    [FieldOffset(0x1A)] public ushort ItemCountAdditional;
    [FieldOffset(0x1C)] public bool ItemHQPrimary;
    [FieldOffset(0x1D)] public bool ItemHQAdditional;
    [FieldOffset(0x1E)] public byte UnknownPrimary;
    [FieldOffset(0x1F)] public byte UnknownAdditional;
    [FieldOffset(0x20)] public uint SurveyLinePrimary;
    [FieldOffset(0x24)] public uint SurveyLineAdditional;
    [FieldOffset(0x28)] public uint YieldLinePrimary;
    [FieldOffset(0x2C)] public uint YieldLineAdditional;
    [FieldOffset(0x30)] public uint DiscoveredLinePrimary;
    [FieldOffset(0x34)] public uint DiscoveredLineAdditional;
}
