using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class BotonConFeedback : MonoBehaviour
{
    public string sceneToLoad; // Nombre de la escena a cargar
    private Button button;
    private Image buttonImage;

    void Start()
    {
        button = GetComponent<Button>();
        buttonImage = button.targetGraphic as Image;
        button.onClick.AddListener(() => StartCoroutine(ParpadeoYEscena()));
    }

    IEnumerator ParpadeoYEscena()
    {
        Color originalColor = buttonImage.color;
        Color pressedColor = button.colors.pressedColor;

        buttonImage.color = pressedColor;
        yield return new WaitForSeconds(0.15f);
        buttonImage.color = originalColor;

        // Cargar la nueva escena después del parpadeo
        SceneManager.LoadScene(sceneToLoad);
    }
}
