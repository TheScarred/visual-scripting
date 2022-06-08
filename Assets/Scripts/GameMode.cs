using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class GameMode : MonoBehaviour
{
    [SerializeField]
    private InputsManager _inputsManager;

    /*private async void Start()
    {
        while(GameManager.Instance == null)
        {
            await Task.Yield();
        }
        GameManager.Instance.GameMode = this;
    }*?

    /*private IEnumerator Start()
    {
        while (true)
        {
            if(GameManager.Instance.GameMode = this)
            {
                GameManager
            }
        }
    }*/

    public InputsManager InputsManager => _inputsManager;
}
