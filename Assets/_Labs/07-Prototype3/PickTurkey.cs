using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PickTurkey : MonoBehaviour
{
    public List<GameObject> turkeys;
    public Text uiText;
    public Text winText;
    public float reloadDelay = 3f;

    public int turkeyLefted = 6;

    // Start is called before the first frame update
    void Start()
    {
        winText.gameObject.SetActive(false);
        UpdateGUI();
        for (int i = 1; i < 6; i++)
        {
            turkeys[i].SetActive(false);
        }
    }
    void UpdateGUI() { 

        uiText.text = "Turkey Lefted: " + turkeyLefted;

    }

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("turkey"))
        {
            other.gameObject.SetActive(false);
            turkeyLefted--;
            if (turkeyLefted == 0)
            {
                winText.gameObject.SetActive(true);
                Invoke("ReloadLevel", reloadDelay);
            }
            updateTurkey();
            UpdateGUI();
        }

    }
    private void updateTurkey()
    {
        if (turkeys[0] != null)
        {
            turkeys.RemoveAt(0);
            turkeys[0].SetActive(true);
        }
        else
        {
            return;
        }
    }
    void ReloadLevel()
    {
        SceneManager.LoadScene("07-Prototype3");
    }
}
