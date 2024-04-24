namespace Logic
{
    public interface ILogic
    {
        void Init(double height, double width, int orbCount, int radius);

        void Enable();

        void Disable();

        List<Orb> GetOrbs();
    }
}
