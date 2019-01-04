using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraShake : MonoBehaviour
{
    Vector3 cameraInitialPosition;
    public float shakeMagnitude = 0.05f, shakeTime = 0.5f;
    public Camera mainCamera;
    // Start is called before the first frame update
    public void ShakeIt()
    {
      int  x = 0;
        for (x = 0; x < 10; x++)
        {
            cameraInitialPosition = mainCamera.transform.position;
            InvokeRepeating("StartCameraShaking", 0f, 005f);
            Invoke("StopCameraShaking", shakeTime);
        }
        
    }
    void StartCameraShaking()
    {
        float cameraShakingOffsetX = Random.value * shakeMagnitude * 2 - shakeMagnitude;
        float cameraShakingOffsetY = Random.value * shakeMagnitude * 2 - shakeMagnitude;
        Vector3 cameraIntermediatePosition = mainCamera.transform.position;
        cameraIntermediatePosition.x += cameraShakingOffsetX;
        cameraIntermediatePosition.y += cameraShakingOffsetY;
        mainCamera.transform.position = cameraIntermediatePosition;
    }

    // Update is called once per frame
    void StopCameraShaking()
    {
        CancelInvoke("StartCameraShaking");
        mainCamera.transform.position = cameraInitialPosition;
    }
    void Update()
    {
        
    }
   

    
}
