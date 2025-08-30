using UnityEngine;

[System.Serializable]

public class RadialShotSettings 
{
    [Header("Base Setiings")]
    public int NumberOfBullets = 5;
    public float BulletSpeed = 10f;
    public float CooldownAfterShot;
    public int Spiral = 0;

    [Header("Offsets")]
    [Range(-1f, 1f)]public float PhaseOffset = 0f;
    [Range(-180f, 180f)]public float AngleOffset = 0f;

    [Header("Custom Behavior")]
    public bool GrowOnSpawn = false;
}
