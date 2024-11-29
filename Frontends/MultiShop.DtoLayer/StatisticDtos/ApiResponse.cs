using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.DtoLayer.StatisticDtos
{
    public class ApiResponse
    {
        public long result { get; set; }
        public int id { get; set; }
        public string exception { get; set; }
        public int status { get; set; }
        public bool isCanceled { get; set; }
        public bool isCompleted { get; set; }
        public bool isCompletedSuccessfully { get; set; }
        public int creationOptions { get; set; }
        public object asyncState { get; set; }
        public bool isFaulted { get; set; }
    }
}
