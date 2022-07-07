namespace Interfaces
{
    public interface IPlayerMoveController
    {
        public void Move();
        public void SetSpeed(float speed);
        public void AddSpeed(float speed);
        public float GetSpeed();
    }
}