using MvcProduct.Interface;

namespace MvcProduct.Classes
{
    public class TimeProvider : ITimeProvider
    {
        public DateTime Now
        {
            get { return DateTime.Now; }
        }
    }
}
