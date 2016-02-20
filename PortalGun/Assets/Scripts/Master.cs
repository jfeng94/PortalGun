using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Master : MonoSingleton <Master> {
    public Dropdown linkedSector;
    private Dropdown storedSector;

    private int sectorValue;
    private string sectorName;
    private string streamingAssetsPath;

    void Start() {
        Debug.Log("Hello World");
        DontDestroyOnLoad(transform.gameObject);

        EventHandler.instance.OnSetSector += SetSector;
        

        if (Application.platform == RuntimePlatform.IPhonePlayer) {
            streamingAssetsPath = Application.dataPath + "/Raw";
        }
        else if (Application.platform == RuntimePlatform.WindowsPlayer) {
            streamingAssetsPath = Application.dataPath + "/streamingAssets";
        }
        else if (Application.platform == RuntimePlatform.WindowsEditor) {
            streamingAssetsPath = Application.dataPath + "/streamingAssets";
        }

    }

    public int secVal {
        get {
            return sectorValue;
        }
    }

    public string secName {
        get {
            return sectorName;
        }
    }

    public string sAssets { 
        get {
            return streamingAssetsPath;
        }
    }

    public void SetSector() {
        sectorValue = linkedSector.value;
        sectorName  = linkedSector.options[linkedSector.value].text;
        Application.LoadLevel("InfoScreen");
    }
}
