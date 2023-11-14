using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    public delegate void OnStartBossAtack();
    public static OnStartBossAtack onStartBossAtack;

    public delegate void OnFinishedBossAttack();
    public static OnFinishedBossAttack onFinishedBossAttack;

    
}
