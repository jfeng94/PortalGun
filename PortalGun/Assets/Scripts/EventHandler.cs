using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class EventHandler : MonoSingleton<EventHandler> {

    public delegate void ClickAction();

    public event ClickAction OnSetSector;

    public void TriggerSetSector() {
        if (OnSetSector != null) {
            OnSetSector();
        }
    }
}
