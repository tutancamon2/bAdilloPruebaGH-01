using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class VolverInicio : MonoBehaviour
{
    public string sceneToLoad;
    private bool isSelected = false;

    void Update()
    {
        if (isSelected && Keyboard.current.gKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    public void ChangeScene(XRBaseInteractor interactor)
    {
        isSelected = true;
    }
}
