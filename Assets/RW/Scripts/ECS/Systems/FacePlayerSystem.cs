﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

public class FacePlayerSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        if (GameManager.IsGameOver())
        {
            return;
        }

        float3 playerPos = (float3)GameManager.GetPlayerPosition();
        Entities.ForEach((Entity entity, ref Translation trans, ref Rotation rot) =>
        {
            float3 direction = playerPos - trans.Value;
            direction.y = 0f;
            rot.Value = quaternion.LookRotation(direction, math.up());
        });

    }
}
