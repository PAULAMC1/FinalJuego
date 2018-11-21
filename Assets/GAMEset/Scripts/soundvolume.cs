using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class soundvolume : MonoBehaviour
{

    public AudioMixer masterMixer;

    public void SetSFXLvl(float SFXlevel)

    {
        masterMixer.SetFloat("sfx", SFXlevel);
    }

    public void SetMusiclevel(float musiclevel)
    {
        masterMixer.SetFloat("music", musiclevel);
    }

}
