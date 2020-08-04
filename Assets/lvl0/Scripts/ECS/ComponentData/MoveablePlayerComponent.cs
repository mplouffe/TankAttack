using Unity.Entities;
using Unity.NetCode;

[GenerateAuthoringComponent]
public struct MovablePlayerComponent : IComponentData
{
    [GhostDefaultField]
    public int PlayerId;
}
