using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class canvasGuiControlThingTWO : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Icons Panel")]
    GameObject m_TheIconsPanel;

    private PlayMakerFSM fsm;

    // [SerializeField]
    // [Tooltip("Start Panel")]
    // GameObject m_TheStartPanel;
    // [SerializeField]
    // [Tooltip("Background to disable ")]
    // GameObject m_TheBack;
    // Start is called before the first frame update
    void Start()
    {
        fsm =
            GameObject
                .FindWithTag("mySceneMasterControllerxx")
                .GetComponent<PlayMakerFSM>();
    }

    public void StartTheScene()
    {
        Debug.Log("StartTheScene: ");

        // FsmBool myboolVariable =
        //     fsm.FsmVariables.SetFsmBool("firAtEnemy", true);

        // myboolVariable

        // SceneManager.LoadScene("Meshing");
        // if (m_TheIconsPanel)
        // {
        //     m_TheIconsPanel.SetActive(false);
        // }
    }

    // Update is called once per frame
    void Update()
    {
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
        // m_TheOptionsPanel.SetActive(true);
        // m_TheStartPanel.SetActive(false);
        Debug.Log("GoOptions");
    }
}
