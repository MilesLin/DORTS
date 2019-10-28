namespace WindowsFormsApp1.Model
{
    public class SimpleObj
    {
        /// <summary>
        /// 建構式
        /// </summary>
        public SimpleObj()
        {
        }

        private int _filed1;

        public void SetProperty1(int value)
        {
            _filed1 = value;
        }

        public int GetProperty1()
        {
            return _filed1;
        }

        public int Property2 { get; set; }

        public void Method()
        {
        }

        /// <summary>
        /// 解構式
        /// </summary>
        ~SimpleObj()
        {
        }
    }
}