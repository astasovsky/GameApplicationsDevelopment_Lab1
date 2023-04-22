using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Screens
{
    public class MainMenuScreen : MonoBehaviour
    {
        [SerializeField] private Button startButton;
        [SerializeField] private Button settingsButton;
        [SerializeField] private Button exitButton;

        private void Awake()
        {
            startButton.onClick.AddListener(delegate { SceneManager.LoadScene(SceneName.GameScene.ToString()); });
            settingsButton.onClick.AddListener(delegate { });
            exitButton.onClick.AddListener(Application.Quit);
        }
    }
}