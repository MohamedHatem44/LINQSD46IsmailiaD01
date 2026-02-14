namespace LINQD01
{
    // class => static
    // FN => static
    // this
    public static class ExtentionMethod
    {
        /*------------------------------------------------------------------*/
        public static int GetWordsCount(this string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                int count = str.Split(' ').Length;
                return count;
            }
            return 0;
        }
        /*------------------------------------------------------------------*/
    }
}
