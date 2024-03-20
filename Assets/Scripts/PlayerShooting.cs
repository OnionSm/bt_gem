using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] protected GameObject player_bullet_prefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.IsShooting();
    }
    protected void IsShooting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.Shooting();
        }
    }
    protected void Shooting()
    {
        Vector3 spawn_pos = transform.parent.position;
        Quaternion rotation = transform.parent.rotation;
        GameObject new_bullet = Instantiate(player_bullet_prefab,spawn_pos, rotation);
        new_bullet.SetActive(true);
    }

}
