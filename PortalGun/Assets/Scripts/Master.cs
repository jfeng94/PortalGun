using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Master : MonoSingleton <Master> {
    public Dropdown linkedSector;
    private Dropdown storedSector;

    private int sectorValue;
    private string sectorName;

    void Start() {
        Debug.Log("Hello World");

        EventHandler.instance.OnSetSector += SetSector;
    }

    public void SetSector() {
        sectorValue = linkedSector.value;
        sectorName  = linkedSector.options[linkedSector.value].text;
        Debug.Log("Sector is " + sectorValue + "\t" +
                  "Sector name is " + sectorName);

    }

}
