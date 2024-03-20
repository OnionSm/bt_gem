using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByDistance : MonoBehaviour
{
    [SerializeField] protected float distance = 0f;
    [SerializeField] protected float distanceLimit = 100f;
    [SerializeField] protected Transform main_camera;
    void Start()
    {
        distance = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.CanDespawn())
            this.DespawnBullet();
        return;
    }
    protected void LoadComponent()
    {
        if (this.main_camera != null) return;
        this.main_camera = Transform.FindObjectOfType<Camera>().transform;
    }
    protected void DespawnBullet()
    {
        Destroy(transform.parent.gameObject);
    }
    protected bool CanDespawn()
    {
        Debug.Log("Transform position : " + transform.position + "camera : " + this.main_camera.position);
        Vector3 main_camera_position = new Vector3(main_camera.position.x, main_camera.position.y, 0f);
        this.distance = Vector3.Distance(transform.position, main_camera_position);
        if (distance > distanceLimit)
            return true;
        return false;
          
    }
}
