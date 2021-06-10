namespace Section.DesignPatterns.Singleton.Mono
{
    public class LevelManager : MonoSingleton<LevelManager>
    {
        public override void Init()
        {
            base.Init();
        }

        public void LoadLevel()
        {

        }
    }
}