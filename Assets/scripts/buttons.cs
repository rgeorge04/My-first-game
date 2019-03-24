using UnityEngine;
using UnityEngine.SceneManagement;
public class buttons : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("main");
        }

        
    }
}