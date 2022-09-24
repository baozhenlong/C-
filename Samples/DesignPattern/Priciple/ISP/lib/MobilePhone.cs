namespace ISP
{
    public interface IBaseMobilePhone
    {
        void Call();
        void Message();
    }

    public interface IPhotographMobilePhone
    {
        void Photograph();
    }

    public interface IAudioMobilePhone
    {
        void PlayMusic();
        void PlayMovie();
    }

    public interface IGameMobilePhone
    {
        void PlayGame();
    }

    public interface ISmartMobilePhone : IBaseMobilePhone, IPhotographMobilePhone, IAudioMobilePhone, IGameMobilePhone
    {
    }

    public class OldMobilePhone : IBaseMobilePhone, IPhotographMobilePhone
    {
        public void Call() { }
        public void Message() { }
        public void Photograph() { }
    }

    public class SmartMobilePhone : ISmartMobilePhone
    {
        public void Call() { }
        public void Message() { }
        public void Photograph() { }
        public void PlayMusic() { }
        public void PlayMovie() { }
        public void PlayGame() { }
    }
}