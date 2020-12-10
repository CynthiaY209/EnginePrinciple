using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomInAndOut : MonoBehaviour
{
    /*private float mouseX;
    private float mouseY;*/
    private Camera cam;
    private float startingFov;

    public float minFov;
    public float maxFov;
    public float zoomRate;

    private float currentFov;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        startingFov = cam.fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (Camera.main.fieldOfView <= 100)
                this.GetComponent<Camera>().fieldOfView++;
            // 摄像机的正交投影
            if (Camera.main.orthographicSize <= 20)
                this.GetComponent<Camera>().orthographicSize += 0.5f;
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (this.GetComponent<Camera>().fieldOfView > 1)
                this.GetComponent<Camera>().fieldOfView--;
            if (this.GetComponent<Camera>().orthographicSize >= 1)
                this.GetComponent<Camera>().orthographicSize -= 0.5f;
        }*/
        currentFov = cam.fieldOfView;

        if(Input.GetKeyDown(KeyCode.P))
        {
            currentFov = startingFov;
        }

        UseWheel();

        if(Input.GetKey(KeyCode.I))
        {
            currentFov -= zoomRate;
        }

        if (Input.GetKey(KeyCode.O))
        {
            currentFov += zoomRate;
        }

        currentFov = Mathf.Clamp(currentFov, minFov, maxFov);
        cam.fieldOfView = currentFov;
    }

    public void UseWheel()
    {
        currentFov = cam.fieldOfView;
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        currentFov += scroll * zoomRate * -10;
        currentFov = Mathf.Clamp(currentFov, minFov, maxFov);
        cam.fieldOfView = currentFov;
    }
}
