using FFXIVClientStructs.FFXIV.Client.Game;
using FFXIVClientStructs.FFXIV.Component.GUI;

namespace FFXIVClientStructs.FFXIV.Client.UI.Agent;

// Client::UI::Agent::AgentInventoryContext
//   Client::UI::Agent::AgentInterface
//     Component::GUI::AtkModuleInterface::AtkEventInterface
[Agent(AgentId.InventoryContext)]
[GenerateInterop]
[Inherits<AgentInterface>]
[StructLayout(LayoutKind.Explicit, Size = 0x798)]
public unsafe partial struct AgentInventoryContext {
    [FieldOffset(0x28)] public uint BlockingAddonId;
    [FieldOffset(0x2C)] public int ContexItemStartIndex;
    [FieldOffset(0x30)] public int ContextItemCount;

    [FieldOffset(0x38), FixedSizeArray] internal FixedSizeArray98<AtkValue> _eventParams;
    [FieldOffset(0x658), FixedSizeArray] internal FixedSizeArray84<byte> _eventIds;
    [FieldOffset(0x6AC)] public uint ContextItemDisabledMask;
    [FieldOffset(0x6B0)] public uint ContextItemSubmenuMask;

    [FieldOffset(0x6B4)] public int PositionX;
    [FieldOffset(0x6B8)] public int PositionY;

    [FieldOffset(0x6C8)] public uint OwnerAddonId;
    [FieldOffset(0x6CC), CExportIgnore] public int YesNoPosition; // 2 shorts combined, gets passed as int arg, default = -1
    [FieldOffset(0x6CC)] public short YesNoX;
    [FieldOffset(0x6CE)] public short YesNoY;
    [FieldOffset(0x6D0)] public InventoryType TargetInventoryId;
    [FieldOffset(0x6D4)] public int TargetInventorySlotId;

    [FieldOffset(0x6DC)] public uint DummyInventoryId;

    [FieldOffset(0x6E8)] public InventoryItem* TargetInventorySlot;
    [FieldOffset(0x6F0)] public InventoryItem TargetDummyItem;
    [FieldOffset(0x738)] public InventoryType BlockedInventoryId;
    [FieldOffset(0x73C)] public int BlockedInventorySlotId;

    [FieldOffset(0x748)] public InventoryItem DiscardDummyItem;
    [FieldOffset(0x790)] public int DialogType; // ?? 1 = Discard, 2 = LowerQuality

    [MemberFunction("83 B9 ?? ?? ?? ?? ?? 7E ?? 39 91")]
    public partial void OpenForItemSlot(InventoryType inventoryType, int slot, int a4, uint addonId);

    [MemberFunction("E8 ?? ?? ?? ?? E9 ?? ?? ?? ?? 48 8D 0D ?? ?? ?? ?? E8 ?? ?? ?? ?? 4C 89 74 24 ??")]
    public partial long UseItem(uint itemId, InventoryType inventoryType = InventoryType.Invalid, uint itemSlot = 0, short a5 = 0);

    [MemberFunction("E8 ?? ?? ?? ?? 48 8B B4 24 ?? ?? ?? ?? 0F B6 D8")]
    public partial void DiscardItem(InventoryItem* itemSlot, InventoryType inventory, int slot, uint addonId, int position = -1); // position = YesNoPosition

    [MemberFunction("E8 ?? ?? ?? ?? 48 83 C4 ?? 5B C3 8B 83")]
    public partial void LowerItemQuality(InventoryItem* itemSlot, InventoryType inventory, int slot, uint addonId);

    public bool IsContextItemDisabled(int index)
        => index >= 0 && (ContextItemDisabledMask & (1 << index)) != 0;

    [GenerateInterop(isInherited: true)]
    [StructLayout(LayoutKind.Explicit, Size = 0x8)]
    public partial struct InventoryContextEvent; // contains 2 vfs
}
