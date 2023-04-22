using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Screens
{
    public class GameScreen : MonoBehaviour
    {
        [SerializeField] private Button mainMenuButton;

        private void Awake()
        {
            mainMenuButton.onClick.AddListener(delegate { SceneManager.LoadScene(SceneName.MainScene.ToString()); });
        }
    }
}