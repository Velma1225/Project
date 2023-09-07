namespace HabanMVC.Services.Job
{
    public class CommonGetServices
    {
        public string GetSalaryPayment(int SalaryPaymentId)
        {
            if (SalaryPaymentId == 1)
            {
                return "時薪";
            }
            else if (SalaryPaymentId == 2)
            {
                return "月薪";
            }
            else if (SalaryPaymentId == 3)
            {
                return "面議";
            }
            else { return "資料錯誤"; }
        }
        public string GetSalaryRange(int MinSalary, int MaxSalary)
        {
            return null;
        }
        public string GetEducation(int EducationId)
        {
            if (EducationId == 1)
            {
                return "高中";
            }
            else if (EducationId == 2)
            {
                return "專科";
            }
            else if (EducationId == 3)
            {
                return "大學";
            }
            else if (EducationId == 4)
            {
                return "研究所";
            }
            else return "資料錯誤";
        }
        public string GetJobShift(int JobShiftId)
        {
            if (JobShiftId == 1)
            {
                return "日班";
            }
            else if (JobShiftId == 2)
            {
                return "晚班";
            }
            else if (JobShiftId == 3)
            {
                return "大夜班";
            }
            else if (JobShiftId == 4)
            {
                return "假日班";
            }
            else return "資料錯誤";
        }
        public string GetEmploymentCategory(int EmploymentCategoryId)
        {
            if (EmploymentCategoryId == 1)
            {
                return "全職";
            }
            else if (EmploymentCategoryId == 2)
            {
                return "兼職";
            }
            else if (EmploymentCategoryId == 3)
            {
                return "打工";
            }
            else return "資料錯誤";
        }
        public string GetJobTenure(int JobTenureId)
        {
            if (JobTenureId == 1)
            {
                return "無經驗可";
            }
            else if (JobTenureId == 2)
            {
                return "1~3年";
            }
            else if (JobTenureId == 3)
            {
                return "3年以上";
            }
            else return "資料錯誤";
        }
    }
}
