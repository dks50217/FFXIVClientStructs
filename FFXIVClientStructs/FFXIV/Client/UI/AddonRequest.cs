using FFXIVClientStructs.FFXIV.Component.GUI;

namespace FFXIVClientStructs.FFXIV.Client.UI;

// Client::UI::AddonRequest
//   Component::GUI::AtkUnitBase
//     Component::GUI::AtkEventListener
[GenerateInterop]
[Inherits<AtkUnitBase>]
[StructLayout(LayoutKind.Explicit, Size = 0x2F8)]
public unsafe partial struct AddonRequest {
    [FieldOffset(0x238)] public AtkCollisionNode* AtkCollisionNode220;
    [FieldOffset(0x240)] public AtkComponentIcon* AtkComponentIcon228;
    [FieldOffset(0x248)] public AtkComponentIcon* AtkComponentIcon230;
    [FieldOffset(0x250)] public AtkComponentIcon* AtkComponentIcon238;
    [FieldOffset(0x258)] public AtkComponentIcon* AtkComponentIcon240;
    [FieldOffset(0x260)] public AtkComponentIcon* AtkComponentIcon248;
    [FieldOffset(0x268)] public AtkComponentDragDrop* AtkComponentDragDrop250;
    [FieldOffset(0x270)] public AtkComponentDragDrop* AtkComponentDragDrop258;
    [FieldOffset(0x278)] public AtkComponentDragDrop* AtkComponentDragDrop260;
    [FieldOffset(0x280)] public AtkComponentDragDrop* AtkComponentDragDrop268;
    [FieldOffset(0x288)] public AtkComponentDragDrop* AtkComponentDragDrop270;
    [FieldOffset(0x290)] public AtkComponentButton* HandOverButton;

    [FieldOffset(0x298)] public AtkComponentButton* CancelButton;

    // These point to the same icon/dragdrop nodes as before
    [FieldOffset(0x2A0)] public AtkComponentIcon* AtkComponentIcon288;
    [FieldOffset(0x2A8)] public AtkComponentIcon* AtkComponentIcon290;
    [FieldOffset(0x2B0)] public AtkComponentIcon* AtkComponentIcon298;
    [FieldOffset(0x2B8)] public AtkComponentIcon* AtkComponentIcon2A0;
    [FieldOffset(0x2C0)] public AtkComponentIcon* AtkComponentIcon2A8;
    [FieldOffset(0x2C8)] public AtkComponentDragDrop* AtkComponentDragDrop2B0;
    [FieldOffset(0x2D0)] public AtkComponentDragDrop* AtkComponentDragDrop2B8;
    [FieldOffset(0x2D8)] public AtkComponentDragDrop* AtkComponentDragDrop2C0;
    [FieldOffset(0x2E0)] public AtkComponentDragDrop* AtkComponentDragDrop2C8;
    [FieldOffset(0x2E8)] public AtkComponentDragDrop* AtkComponentDragDrop2D0;

    [FieldOffset(0x2F0)] public int EntryCount;
}
