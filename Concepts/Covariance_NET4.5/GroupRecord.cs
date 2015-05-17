
namespace Covariance_NET4._5
{
    public class GroupRecord : IRecord
    {
        public int HeaderCount { get; set; }
        public bool HasChildRecords { get; set; }
        public override string ToString()
        {
            return "I am GroupRecord";
        }
    }
}