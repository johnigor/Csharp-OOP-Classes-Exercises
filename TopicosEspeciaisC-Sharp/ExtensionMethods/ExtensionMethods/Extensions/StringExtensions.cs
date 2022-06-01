namespace System
{
    static class StringExtensions
    {
        public static string Cut(this string thisObj, int count) //recebe um numero inteiro
        {
            //logica para recortar o thisObj
            if (thisObj.Length <= count)
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, count) + "...";
            }
        }
    }
}
