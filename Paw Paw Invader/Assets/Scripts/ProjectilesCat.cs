using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilesCat : Projectiles
{
    protected override float defaultSpeed { get { return -1.0f; } }
    protected override float defaultBoundary { get { return -4.5f; } }
}
