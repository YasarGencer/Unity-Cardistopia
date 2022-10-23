using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatScreen : MonoBehaviour
{
    public GameObject screen;
    GameObject instantiated;
    public void Spawn()
    {
        instantiated = Instantiate(this.screen);
        GameObject close = GameObject.Find(instantiated.name + "/Close");
        close.GetComponent<Button>().onClick.AddListener(Close);
    }
    public void Close()
    {
        if (instantiated != null)
        {
            Destroy(instantiated);
            instantiated = null;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Close();
        }
    }

}
