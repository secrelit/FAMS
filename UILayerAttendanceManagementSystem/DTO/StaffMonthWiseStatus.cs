using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UILayerAttendanceManagementSystem.DTO
{
    class MonthWiseStaffStatus
    {
        String staffName = "xxx";
        String department = "ddd";
        int absent = 0;
        int ipt = 0;
        int noPunch = 0;
        int late = 0;
        double avgWorkingHrs = 0;

        public String StaffName { get { return staffName; } set { staffName = value; } }
        public String Department { get { return department; } set { department = value; } }
        public int Absent { get { return absent; } set { absent = value; } }
        public int IPT { get { return ipt; } set { ipt = value; } }
        public int NoPunch { get { return noPunch; } set { noPunch = value; } }
        public int Late { get { return late; } set { late = value; } }
        public double AvgWorkingHrs { get { return avgWorkingHrs; } set { avgWorkingHrs = value; } }

        public MonthWiseStaffStatus()
        { }

        public static List<MonthWiseStaffStatus> GetStaffList()
        {
            List<MonthWiseStaffStatus> staffList = new List<MonthWiseStaffStatus>();
            DTO.MonthWiseStaffStatus staff = new DTO.MonthWiseStaffStatus("Sandip Warate");
            staff.Absent = 0; staff.IPT = 0; staff.Late = 3; staff.NoPunch = 2; staff.Department = "MCA";

            staff = new DTO.MonthWiseStaffStatus("Nilesh Thite");
            staff.Absent = 2; staff.IPT = 1; staff.Late = 5; staff.NoPunch = 0; staff.Department = "ADMIN";
            staffList.Add(staff);

            staff = new DTO.MonthWiseStaffStatus("Swati Atre");
            staff.Absent = 1; staff.IPT = 2; staff.Late = 4; staff.NoPunch = 1; staff.Department = "MCA";
            staffList.Add(staff);

            staff = new DTO.MonthWiseStaffStatus("Rahul Sonawane");
            staff.Absent = 0; staff.IPT = 1; staff.Late = 3; staff.NoPunch = 4; staff.Department = "MCA";
            staffList.Add(staff);

            staff = new DTO.MonthWiseStaffStatus("Monali Meghal");
            staff.Absent = 2; staff.IPT = 1; staff.Late = 5; staff.NoPunch = 0; staff.Department = "MBA";
            staffList.Add(staff);

            staff = new DTO.MonthWiseStaffStatus("Chitra Deshmukh");
            staff.Absent = 1; staff.IPT = 2; staff.Late = 4; staff.NoPunch = 1; staff.Department = "MBA";
            staffList.Add(staff);

            staff = new DTO.MonthWiseStaffStatus("Mayur Pawar");
            staff.Absent = 0; staff.IPT = 1; staff.Late = 3; staff.NoPunch = 4; staff.Department = "ADMIN";
            staffList.Add(staff);

            staff = new DTO.MonthWiseStaffStatus("Achala Gautam");
            staff.Absent = 2; staff.IPT = 1; staff.Late = 5; staff.NoPunch = 0; staff.Department = "IT";
            staffList.Add(staff);

            staff = new DTO.MonthWiseStaffStatus("Nadia Rani");
            staff.Absent = 1; staff.IPT = 2; staff.Late = 4; staff.NoPunch = 1; staff.Department = "IT";
            staffList.Add(staff);

            staff = new DTO.MonthWiseStaffStatus("Manish Dhundelu");
            staff.Absent = 0; staff.IPT = 1; staff.Late = 3; staff.NoPunch = 4; staff.Department = "IT";
            staffList.Add(staff);

            staff = new DTO.MonthWiseStaffStatus("Akshay Zarekar");
            staff.Absent = 1; staff.IPT = 2; staff.Late = 4; staff.NoPunch = 1; staff.Department = "IT";
            staffList.Add(staff);

            staff = new DTO.MonthWiseStaffStatus("Vishal Shelke");
            staff.Absent = 0; staff.IPT = 1; staff.Late = 3; staff.NoPunch = 4; staff.Department = "MECH";
            staffList.Add(staff);

            staff = new DTO.MonthWiseStaffStatus("Nadia Rani");
            staff.Absent = 1; staff.IPT = 2; staff.Late = 4; staff.NoPunch = 1; staff.Department = "IT";
            staffList.Add(staff);

            staff = new DTO.MonthWiseStaffStatus("D B Yesane");
            staff.Absent = 1; staff.IPT = 4; staff.Late = 2; staff.NoPunch = 0; staff.Department = "MECH";
            staffList.Add(staff);

            staff = new DTO.MonthWiseStaffStatus("Shushant Shirole");
            staff.Absent = 2; staff.IPT = 0; staff.Late = 1; staff.NoPunch = 0; staff.Department = "MECH";
            staffList.Add(staff);

            staff = new DTO.MonthWiseStaffStatus("Yaswante Sinha");
            staff.Absent = 0; staff.IPT = 1; staff.Late = 3; staff.NoPunch = 4; staff.Department = "MECH";
            staffList.Add(staff);

            return staffList;
        }

        public MonthWiseStaffStatus(string staffName)
        {
            this.staffName = staffName;
        }
    }
}
