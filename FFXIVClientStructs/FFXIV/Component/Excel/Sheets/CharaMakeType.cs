// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x3074)]
public unsafe partial struct CharaMakeType {
    [FieldOffset(0x00), FixedSizeArray] internal FixedSizeArray28<CharaMakeStructStruct> _charaMakeStruct;
    [FieldOffset(0x2ED0), FixedSizeArray] internal FixedSizeArray12<byte> _voiceStruct;
    [FieldOffset(0x2EDC), FixedSizeArray] internal FixedSizeArray8<FacialFeatureOptionStruct> _facialFeatureOption;
    [FieldOffset(0x2FC0), FixedSizeArray] internal FixedSizeArray3<EquipmentStruct> _equipment;
    /// <remarks>Race</remarks>
    [FieldOffset(0x3068)] public int Race;
    /// <remarks>Tribe</remarks>
    [FieldOffset(0x306C)] public int Tribe;
    [FieldOffset(0x3070)] public sbyte Gender;

    [GenerateInterop]
    [StructLayout(LayoutKind.Explicit, Size = 0x1AC)]
    public partial struct CharaMakeStructStruct {
        /// <remarks>Lobby</remarks>
        [FieldOffset(0x00)] public uint Menu;
        [FieldOffset(0x04)] public uint SubMenuMask;
        [FieldOffset(0x08)] public uint Customize;
        [FieldOffset(0x0C), FixedSizeArray] internal FixedSizeArray100<uint> _subMenuParam;
        [FieldOffset(0x19C)] public byte InitVal;
        [FieldOffset(0x19D)] public byte SubMenuType;
        [FieldOffset(0x19E)] public byte SubMenuNum;
        [FieldOffset(0x19F)] public byte LookAt;
        [FieldOffset(0x1A0), FixedSizeArray] internal FixedSizeArray10<byte> _subMenuGraphic;
    }
    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public partial struct FacialFeatureOptionStruct {
        [FieldOffset(0x00)] public int Option1;
        [FieldOffset(0x04)] public int Option2;
        [FieldOffset(0x08)] public int Option3;
        [FieldOffset(0x0C)] public int Option4;
        [FieldOffset(0x10)] public int Option5;
        [FieldOffset(0x14)] public int Option6;
        [FieldOffset(0x18)] public int Option7;
    }
    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public partial struct EquipmentStruct {
        [FieldOffset(0x00)] public ulong Helmet;
        [FieldOffset(0x08)] public ulong Top;
        [FieldOffset(0x10)] public ulong Gloves;
        [FieldOffset(0x18)] public ulong Legs;
        [FieldOffset(0x20)] public ulong Shoes;
        [FieldOffset(0x28)] public ulong Weapon;
        [FieldOffset(0x30)] public ulong SubWeapon;
    }
}