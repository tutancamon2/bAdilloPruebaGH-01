using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class SceneChanger : MonoBehaviour
{
    public string sceneToLoad; // Nombre de la escena a cargar

    public void ChangeScene(XRBaseInteractor interactor)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}

