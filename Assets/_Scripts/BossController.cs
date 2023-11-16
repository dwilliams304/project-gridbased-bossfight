using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    public delegate void OnStartBossAtack();
    public static OnStartBossAtack onStartBossAtack;

    public delegate void OnFinishedBossAttack();
    public static OnFinishedBossAttack onFinishedBossAttack;

    [SerializeField] private float _atkSpeed = 5f;


    void Start(){
        StartCoroutine(BossAttack());
    }

    IEnumerator BossAttack(){
        while(true){
            onStartBossAtack?.Invoke();
            yield return new WaitForSeconds(_atkSpeed);
            onFinishedBossAttack?.Invoke();
        }
    }
}
