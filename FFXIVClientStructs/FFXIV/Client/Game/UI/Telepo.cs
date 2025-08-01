namespace FFXIVClientStructs.FFXIV.Client.Game.UI;

// Client::Game::UI::Telepo
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x58)]
public unsafe partial struct Telepo {
    [StaticAddress("48 8D 0D ?? ?? ?? ?? 48 8B 12", 3)]
    public static partial Telepo* Instance();

    [FieldOffset(0x10)] public StdVector<TeleportInfo> TeleportList;
    [FieldOffset(0x28)] public SelectUseTicketInvoker UseTicketInvoker;

    [MemberFunction("E8 ?? ?? ?? ?? 48 8B 4B 10 84 C0 48 8B 01 74 2C")]
    public partial bool Teleport(uint aetheryteId, byte subIndex);

    [MemberFunction("E8 ?? ?? ?? ?? 48 89 46 68 4C 8B E0")]
    public partial StdVector<TeleportInfo>* UpdateAetheryteList();

    /// Territories have aetherstream coordinates X and Y, an associated ExpansionValue and an associated Plane in TerritoryTypeTelepo.
    /// Planes have relays described in the TelepoRelay sheet, every pair of planes has an associated entry territory, exit territory and cost organized in a 6x6 matrix.
    /// If planes are the same, the cost function is
    ///     f(Entry, Exit) := `100 + AetherStreamDistance * Max(1000, EntryExpansionValue + ExitExpansionValue + 600) / 5000`.
    /// If planes differ, the cost computes as
    ///     f(Entry, Exit) := f(Entry, EntryRelay(EntryPlane, ExitPlane)) + Cost(EntryPlane, ExitPlane) + f(ExitRelay(EntryPlane, ExitPlane), Exit).
    /// Then, the growth is halved after 1000, i.e. if f(Entry, Exit) > 1000, then return (f(Entry, Exit) - 1000) / 2 + 1000 instead.
    /// Additionally, if <paramref name="residentArea"/> is true, the cost is quartered, and if <paramref name="favored"/> is true, the cost is halved.
    [MemberFunction("E8 ?? ?? ?? ?? 89 84 9D")]
    public partial uint GetTeleportCost([CExporterExcel("Aetheryte")] void* aetheryteRow, short multiplier, bool favored, bool residentArea);

    [GenerateInterop]
    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public unsafe partial struct SelectUseTicketInvoker {
        [FieldOffset(0x10)] public Telepo* Telepo;

        [FieldOffset(0x1C)] public uint AddonId;

        [MemberFunction("48 89 5C 24 ?? 48 89 74 24 ?? 57 48 83 EC ?? 80 79 ?? 00 41 0F B6 F8 8B F2")]
        public partial bool TeleportWithTickets(uint aetheryteId, byte subIndex);
    }
}

[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public struct TeleportInfo {
    [FieldOffset(0x00)] public uint AetheryteId;
    [FieldOffset(0x04)] public uint GilCost;
    [FieldOffset(0x08)] public ushort TerritoryId;

    [FieldOffset(0x0C)] public EstateType EstateType;
    [FieldOffset(0x10)] public HouseId HouseId;
    [FieldOffset(0x18)] public byte Ward;
    [FieldOffset(0x19)] public byte Plot;
    [FieldOffset(0x1A)] public byte SubIndex;
    [FieldOffset(0x1B)] public bool IsFavourite;
    [FieldOffset(0x1C)] public bool IsFreeAetheryte;

    public bool IsSharedHouse => Ward > 0 && Plot > 0;
    public bool IsApartment => SubIndex == 128 && !IsSharedHouse;
}
