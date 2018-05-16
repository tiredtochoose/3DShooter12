using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateInterface : MonoBehaviour {

    #region Editor
    /// <summary>
    /// Создание главного меню
    /// </summary>
    public void CreateMainMenu()
    {
        CreateComponent();
        gameObject.AddComponent<MainMenu>();
        Clear();
    }
    
    public void CreateMenuPause()
    {
        CreateComponent();
        Clear();
    }
    private void Clear()
    {
        DestroyImmediate(this);
    }
    private void CreateComponent()
    {
        gameObject.AddComponent<Interface>();
        gameObject.AddComponent<InterfaceResources>();
    }

    #endregion

}
