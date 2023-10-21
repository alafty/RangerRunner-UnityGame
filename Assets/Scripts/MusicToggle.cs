using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicToggle : MonoBehaviour
{
    [SerializeField] Sprite musicOn;
    [SerializeField] Sprite musicOff;
    [SerializeField] Button button;
    public bool isToggled = false;
    [SerializeField] GameObject soundSystem;

    void Start()
    {
        button.onClick.AddListener(ToggleButton);
        soundSystem = GameObject.FindWithTag("SoundSystem");
    }

    void ToggleButton()
    {
        isToggled = !isToggled;
        soundSystem.SetActive(!isToggled);

        gameObject.GetComponent<Image>().sprite = isToggled ? musicOff : musicOn;
    }
}
