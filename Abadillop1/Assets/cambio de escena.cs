using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeToRPGScene()
    {
        SceneManager.LoadScene("rpgpp_lt_scene_1.0");
    }
}