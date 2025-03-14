using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public void GoBack2(){
        SceneManager.LoadScene("ColoredBackground");
    }

    public void GoBack(){
        SceneManager.LoadScene("ColoredBackground2");
    }
    public void GoBackOptions(){
        SceneManager.LoadScene("ColoredBackground2");
    }
    public void Options(){
        SceneManager.LoadScene("Options");
    }
}
