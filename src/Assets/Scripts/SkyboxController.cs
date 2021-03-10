using System;
using UnityEngine;
using UnityEngine.UI;

public class SkyboxController : MonoBehaviour
{
    public Material skybox;
    public Slider SunSize;
    public Slider SunSizeConvergence;
    public Slider AtmosphereThickness;
    public Slider Exposure;
    public Slider SunX;
    public Slider SunY;
    public Transform directionalLight;

    // Start is called before the first frame update
    void Start()
    {
        SunSize.value = skybox.GetFloat("_SunSize");
        SunSizeConvergence.value = skybox.GetFloat("_SunSizeConvergence");
        AtmosphereThickness.value = skybox.GetFloat("_AtmosphereThickness");
        Exposure.value = skybox.GetFloat("_Exposure");
        SunX.value = directionalLight.eulerAngles.x;
        SunY.value = directionalLight.eulerAngles.y;
    }

    void OnSetColor(Color color)
    {
        skybox.SetColor("_SkyTint", color);
    }

    void OnGetColor(ColorPicker picker)
    {
        picker.NotifyColor(skybox.GetColor("_SkyTint"));
    }

    void OnSetGround(Color color)
    {
        skybox.SetColor("_GroundColor", color);
    }

    void OnGetGround(ColorPicker picker)
    {
        picker.NotifyColor(skybox.GetColor("_GroundColor"));
    }

    public void OnUpdateSkybox(String propertyName)
    {
        Slider settingSlider;
        if (propertyName == "_SunSize")
        {
            settingSlider = SunSize;
        }
        else if (propertyName == "_SunSizeConvergence")
        {
            settingSlider = SunSizeConvergence;
        }
        else if (propertyName == "_AtmosphereThickness")
        {
            settingSlider = AtmosphereThickness;
        }
        else if (propertyName == "_Exposure")
        {
            settingSlider = Exposure;
        }
        else
        {
            return;
        }

        skybox.SetFloat(propertyName, settingSlider.value);
    }

    public void updateSunPosition(String axis)
    {
        if (axis == "x")
        {
            directionalLight.rotation = Quaternion.Euler(SunX.value, directionalLight.rotation.eulerAngles.y, 0);
        }
        else if (axis == "y")
        {
            directionalLight.rotation = Quaternion.Euler(directionalLight.rotation.eulerAngles.x, SunY.value, 0);
        }
    }
}