using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

[Serializable]
public struct BulletDirection : IComponentData
{
    public float3 direction;


}
