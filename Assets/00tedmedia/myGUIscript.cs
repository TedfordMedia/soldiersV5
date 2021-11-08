using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class myGUIscript : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Surfacecontroller ")]
    GameObject m_SurfaceController;

    [SerializeField]
    [Tooltip("Cursor to disable ")]
    GameObject m_TheCursor;

 

    [SerializeField]
    [Tooltip("Normal camera to disable ")]
    GameObject m_TheMainCamera;

    [SerializeField]
    [Tooltip("Placement script to disable ")]
    GameObject m_ThePlacementScript;

    [SerializeField]
    [Tooltip("Background to disable ")]
    GameObject m_TheBack;

    [SerializeField]
    [Tooltip("Options Panel")]
    GameObject m_TheOptionsPanel;

    [SerializeField]
    [Tooltip("AudioMixer")]
    public AudioMixer mymixer;

    [SerializeField]
    [Tooltip("Start Panel")]
    GameObject m_TheStartPanel;

    public bool myDoFireAtEnemy;

    private GameObject[] thesurfaces;

    private GameObject[] tempgameobjects;

    private GameObject thesurface;

    // Start is called before the first frame update
    void Start()
    {
        thesurfaces = GameObject.FindGameObjectsWithTag("flatsurface");
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator ExitAfterDelay(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Application.Quit();
    }

    public void StartTheScene()
    {
        Debug.Log("StartTheScene: ");
        foreach (GameObject thesurface in thesurfaces)
        {
            var meshRen = thesurface.GetComponent<MeshRenderer>();
            meshRen.enabled = false;
        }

        if (m_TheCursor)
        {
            m_TheCursor.SetActive(false);
        }

        if (m_TheStartPanel)
        {
            m_TheStartPanel.SetActive(false);
            m_TheBack.SetActive(false);
        }
        else
        {
            Debug.Log("Error: no start panel");
        }
        if (m_ThePlacementScript) m_ThePlacementScript.SetActive(true);
        myDoFireAtEnemy = true;
    }

    public void QuitGame()
    {
        Debug.Log("ButtonAcceptSettings");
        Application.Quit();
        // StartCoroutine(ExitAfterDelay(1f));
    }

    public void ButtonAcceptSettings()
    {
        Debug.Log("ButtonAcceptSettings");
    }

    public void ButtonCancelSettings()
    {
        Debug.Log("ButtonCancelSettings");
    }

    public void GoOptions()
    {
        m_TheOptionsPanel.SetActive(true);
        m_TheStartPanel.SetActive(false);
        Debug.Log("GoOptions");
    }
 

    void OnGUI()
    {
    }
}
