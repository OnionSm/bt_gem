using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] protected float cooldown = 1f;
    [SerializeField] protected float count_cooldown;
    [SerializeField] protected GameObject enemy_bullet_prefab;
    void Start()
    {
        this.count_cooldown = this.cooldown;
    }


    void Update()
    {
        if (this.count_cooldown > 0)
        {
            this.count_cooldown -= Time.deltaTime;
            return;
        }
        this.Shooting();
    }
    protected void Shooting()
    {
        GameObject enemy_bullet = Instantiate(enemy_bullet_prefab, transform.parent.position, transform.parent.rotation);
        enemy_bullet.SetActive(true);
        this.count_cooldown = this.cooldown;
    }
}
