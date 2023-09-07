namespace System
{
    public static class CutString
    {
        public static string StringCut(this string stringObj, int count)
        {
            if(stringObj.Length < count)
            {
                return stringObj;
            }
            else
            {
                return stringObj.Substring(0, count) + "...";
            }
        }
    }
}
