
using Helper;

public class Main : Singleton<Main>
{
	protected Main() { }

	[System.Serializable]
	public struct SceneData
	{
		public SceneField MainMenu;
		public SceneField Game;
	}

	public SceneData Scenes;

    public LangManager LangManager { get; internal set; }

    //public LangManager LangManager { get; internal set; }

    private void Awake()
	{
        LangManager = new LangManager();
        LangManager.Init("Language");
        DontDestroyOnLoad(gameObject);
	}
}
