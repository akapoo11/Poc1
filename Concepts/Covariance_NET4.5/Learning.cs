
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
namespace Covariance_NET4._5
{
    public static class Learning
    {
        public static void Learn()
        {
            List<GroupRecord> groupRecords = new List<GroupRecord>() { new GroupRecord() { HeaderCount = 2 }, new GroupRecord() { HeaderCount = 2 } }; ;
            List<DataRecord> dataRecords = new List<DataRecord>() { new DataRecord() { ColumnCount = 2 }, new DataRecord() { ColumnCount = 2 } };
            List<IRecord> iRecords = new List<IRecord>();
            IEnumerable<IRecord> iRecordseEnumerable = new List<IRecord>();

            // Cannot implicitly convert type 'System.Collections.Generic.List<Covariance_Net3._5.GroupRecord>'
            // to 'System.Collections.Generic.List<Covariance_Net3._5.IRecord>'
            // OPTION 1- This is STILL not allowed
            //iRecords = groupRecords;

            // OPTION 2- YOU WILL NEED TO EXPLICITLY CAST
            //iRecords = dataRecords.Cast<IRecord>().ToList();
            iRecords.AddRange(groupRecords.Cast<IRecord>());
            foreach (var item in iRecords)
            {
                Debug.WriteLine(item);
            }

            // OPTION 3- This is ALLOWED, NOTE IT IS IENUMERABLE
            iRecordseEnumerable = groupRecords;

            foreach (var item in iRecordseEnumerable)
            {
                Debug.WriteLine(item);
            }

            // OPTION 4- This is ALSO ALLOWED, NOT IT IS IENUMERABLE

            PrintRecords(groupRecords);
        }

        private static void PrintRecords<T>(IEnumerable<T> records)
        {
            foreach (var item in records)
            {
                Debug.WriteLine(item);
            }
        }

        
    }
}