using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace _Scripts.SceneManagement
{
    public class ScenesManager : MonoBehaviour
    {
        private static SceneReference _currentScene;
        [field: SerializeField] public SceneReference InitialScene { get; private set; }
        [field: SerializeField] public SceneReference ConnectScene { get; private set;}
        [field: SerializeField] public SceneReference LobbyScene { get; private set;}
        [field: SerializeField] public SceneReference GameScene { get; private set;}
        [field: SerializeField] public SceneReference MainMenuScene { get; private set;}
        [field: SerializeField] public SceneReference GarageScene { get; private set;}

        public enum SceneType
        {
            Initial,
            Connect,
            Lobby,
            Game,
            MainMenu,
            Garage
        }

        public void LoadScene(SceneType sceneType)
        {
            _currentScene = sceneType switch
            {
                SceneType.Initial => InitialScene,
                SceneType.Connect => ConnectScene,
                SceneType.Lobby => LobbyScene,
                SceneType.Game => GameScene,
                SceneType.MainMenu => MainMenuScene,
                SceneType.Garage => GarageScene,
                _ => _currentScene
            };
            SceneManager.LoadScene(_currentScene.ScenePath);
        }
    }
}