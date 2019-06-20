using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

[Serializable]
public struct BulletOrigin : IComponentData
{
    public float3 origin;
}
