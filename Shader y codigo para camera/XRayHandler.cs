using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRayHandler : MonoBehaviour
{
    public Shader xRayShader;
    public Color tintColor;

    Camera _myCamera;

    private void Awake()
    {
        _myCamera = GetComponent<Camera>();
        _myCamera.enabled = false;
    }

    public void ActiveXRay()
    {
        _myCamera.enabled = true;
        _myCamera.SetReplacementShader(xRayShader, "XRAY");
    }

    public void DeactiveXRay()
    {
        _myCamera.ResetReplacementShader();
        _myCamera.enabled = false;
    }
}
