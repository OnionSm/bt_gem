using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlane : MonoBehaviour
{
    [SerializeField] public Vector3 my_plane_position;
    [SerializeField] protected Transform my_plane;
    [SerializeField] public static EnemyPlane Instance;
    void Start()
    {
        EnemyPlane.Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetMyPlanePosition();
        this.LookAtMyPlane();
    }
    protected void LookAtMyPlane()
    {
        Vector3 diff = this.my_plane_position - transform.parent.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
    }
    protected void GetMyPlanePosition()
    {
        this.my_plane_position = this.my_plane.position;
    }

}
