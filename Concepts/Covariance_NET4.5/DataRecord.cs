
namespace Covariance_NET4._5
{
    public class DataRecord : IRecord
    {
        public int ColumnCount { get; set; }
        public bool HasChildRecords { get; set; }

        public override string ToString()
        {
            return "I am DataRecord";
        }

    }
}