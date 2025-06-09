using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using System.Collections;

public class BotonInicio : MonoBehaviour
{
    public string sceneToLoad;         // Nombre de la escena a cargar
    public Button button;              // Referencia al botón de la UI (para el efecto visual)

    private bool isSelected = false;   // Si está siendo tocado por el controlador

    void Update()
    {
        // Si está seleccionado y se presiona la tecla G
        if (isSelected && Keyboard.current.gKey.wasPressedThisFrame)
        {
            StartCoroutine(FlashButton());         // Efecto visual
            SceneManager.LoadScene(sceneToLoad);   // Cambio de escena
        }
    }

    // Este método se llama desde el evento OnSelectEntered del XR Interactable
    public void ChangeScene(XRBaseInteractor interactor)
    {
        isSelected = true;
    }

    IEnumerator FlashButton()
    {
        if (button == null) yield break;

        var colors = button.colors;
        Color originalColor = colors.normalColor;

        // Simula color presionado
        button.targetGraphic.color = colors.pressedColor;

        yield return new WaitForSeconds(0.15f);

        // Vuelve al color normal
        button.targetGraphic.color = originalColor;
    }
}
