using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletMovement : MonoBehaviour
{
    [SerializeField] protected int movespeed = 5;
    [SerializeField] protected Vector3 direction = Vector3.left;
    [SerializeField] protected Transform player_plane;
    void Start()
    {
       this.LoadComponent();
    }
    protected void LoadComponent()
    {
        if (player_plane != null) return;
        this.player_plane = transform.Find("PlayerPlane");
    }
    // Update is called once per frame
    void Update()
    {
        transform.parent.Translate(this.direction * this.movespeed * Time.deltaTime);
    }


}
