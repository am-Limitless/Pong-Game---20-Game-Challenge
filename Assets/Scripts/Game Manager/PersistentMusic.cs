using UnityEngine;
using UnityEngine.SceneManagement;

public class PersistentMusic : MonoBehaviour
{
    private static PersistentMusic instance = null;
    public string[] scenesToPersist;  // Array to hold the names of the scenes where music should persist

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;  // Subscribe to the sceneLoaded event
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Check if the current scene is not in the list of scenes to persist music
        if (System.Array.IndexOf(scenesToPersist, scene.name) == -1)
        {
            Destroy(gameObject);  // Destroy the music GameObject
        }
    }

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;  // Unsubscribe from the sceneLoaded event when this object is destroyed
    }
}
