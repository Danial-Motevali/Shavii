namespace Shavii.Interface.Repository
{
    public interface IAddressRepository
    {
        public bool Add();
        public bool Update();

        public int MyProperty { get; set; }
    }
}
