using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMovement : MonoBehaviour
{
    [SerializeField] protected Vector3 direction;
    [SerializeField] protected Vector3 my_plane_pos;
    [SerializeField] protected float move_speed = 3f;
    void Start()
    {
        this.LoadDirection();
    }

    
    void Update()
    {
        this.BullettFLy();
    }
    protected void BullettFLy()
    {
        transform.parent.Translate(this.direction * this.move_speed * Time.deltaTime);
    }
    protected void LoadDirection()
    {
        this.my_plane_pos = EnemyPlane.Instance.my_plane_position;
        this.direction = this.my_plane_pos - transform.parent.position;
        Debug.Log("transform parent : " + transform.parent.position);
        Debug.Log("Direction : " + direction);
        
    }
}
