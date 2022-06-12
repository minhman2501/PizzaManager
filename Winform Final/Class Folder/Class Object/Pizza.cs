namespace Winform_Final.Class_Folder.Class_Object
{
    public class Pizza : Product
    {
        public Pizza(string name, int price, int amount) : base(name, price, amount)
        {
            this.category = "Pizza";
        }

    }
}
