using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public Vector3 mousePosition;
    [SerializeField] protected float speed = 0.0005f;
    
    void Start()
    {
        this.LoadComponent();
    }


    void Update()
    {
        this.GetMousePositon();
        this.LookAtMouse();
        this.Move();
    }
    protected void LoadComponent()
    {
        this.LoadPlayerPlane();
    }
    protected void LoadPlayerPlane()
    {
        transform.parent.position = new Vector3(transform.parent.position.x, transform.parent.position.y, 0f);
    }
    protected void LookAtMouse()
    {

        Vector3 diff = this.mousePosition - transform.parent.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0f, 0f, rot_z -90);
    }
    protected void GetMousePositon()
    {
        this.mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.mousePosition.z = 0;
    }
    protected void Move()
    {
         transform.parent.position = Vector3.Lerp(transform.parent.position,this.mousePosition, this.speed);
    }
}
