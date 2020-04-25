using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{

    public void ChangeScene(string name)
    {

            UnityEngine.SceneManagement.SceneManager.LoadScene(name);

    }

}
