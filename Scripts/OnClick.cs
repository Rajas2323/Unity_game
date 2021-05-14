using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClick : MonoBehaviour
{
    public void Restart() {
        SceneManager.LoadScene("SampleScene");
    }
}
