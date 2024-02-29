using UnityEngine;

// Make sure to wrap UnityEditor code with preprocessor directives
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Exit : MonoBehaviour
{
    public void QuitGame()
    {
        // Check if the game is running in the Unity Editor
        #if UNITY_EDITOR
        // Stop playing the scene in the Unity Editor
        EditorApplication.isPlaying = false;
        #else
        // Quit the application when built
        Application.Quit();
        #endif
    }
}