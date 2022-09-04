using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilesPlayer : Projectiles
{
    protected override float defaultSpeed { get { return 10.0f; } }
    protected override float defaultBoundary { get { return 4.5f; } }
}
