using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UILayerAttendanceManagementSystem.DTO
{
    class StaffGridRecord
    {
        String staffName;
        String department;
        int numberOfAbsentDates;
        int numberOfNoPunchDates;
        int numberOfIptDates;
        int numberOfLateDates;
        double avgWorkingHrs;

        public String StaffName { get { return staffName; } set { staffName = value; } }
        public String Department { get { return department; } set { department = value; } }
        public int NumberOfAbsentDates { get { return numberOfAbsentDates; } set { numberOfAbsentDates = value; } }
        public int NumberOfNoPunchDates { get { return numberOfNoPunchDates; } set { numberOfNoPunchDates = value; } }
        public int NumberOfIptDates { get { return numberOfIptDates; } set { numberOfIptDates = value; } }
        public int NumberOfLateDates { get { return numberOfLateDates; } set { numberOfLateDates = value; } }
        public double AvgWorkingHours { get { return avgWorkingHrs; } set { avgWorkingHrs = value; } }
    }
}
