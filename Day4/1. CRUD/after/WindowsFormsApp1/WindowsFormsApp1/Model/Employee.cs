namespace WindowsFormsApp1.Model
{
    /// <summary>
    /// 員工資料物件
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// 員工編號
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string EmpName { get; set; }

        /// <summary>
        /// 性別
        /// </summary>
        public Sex Sex { get; set; }
    }
}