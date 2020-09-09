using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MergingMeetingTimes
{
    public class Times
    {
        public void mergeTimes()
        {
            // check endTime i and check startTime i+1
            Hour schedule1 = new Hour { startTime = 0, endTime = 1 };
            Hour schedule2 = new Hour { startTime = 3, endTime = 5 };
            Hour schedule3 = new Hour { startTime = 4, endTime = 8 };
            Hour schedule4 = new Hour { startTime = 9, endTime = 10 };
            Hour schedule5 = new Hour { startTime = 10, endTime = 12 };

            //expected
            // start time 0 , end time 1
            // start time 3 , end time 8
            // start time 9 , end time 12

            var schedules = new List<Hour>();

            schedules.Add(schedule1);
            schedules.Add(schedule2);
            schedules.Add(schedule3);
            schedules.Add(schedule4);
            schedules.Add(schedule5);

            var mergedShedules = new List<Hour>();

            for (int i = 0; i < schedules.Count; i++)
            {
                //if(schedules[i].endTime < schedules[i+1].startTime)
                //{
                //    mergedShedules.Add(new Hour { startTime = schedules[i].startTime, endTime = schedules[i+1].endTime });
                //}

                if (schedules[i].startTime < schedules[i + 1].startTime && schedules[i].endTime < schedules[i + 1].endTime)
                {
                    mergedShedules.Add(new Hour { startTime = schedules[i].startTime, endTime = schedules[i].endTime });
                }
            }

        }

        private class Hour
        {
            public int startTime = 0;
            public int endTime = 0;
        }
    }
}
