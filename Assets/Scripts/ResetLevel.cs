using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible= false;
    }
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       
    }
    public void Change(string i)
    {
        SceneManager.LoadScene(i);
    }
    public void CursorVisibile()
    {
        Cursor.visible = true;
    }
}
