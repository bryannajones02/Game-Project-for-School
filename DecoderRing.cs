using System;
namespace secondproject
{
    public static class DecoderRing
    {

        private static int num2 = 0;
        private static char value =' ';
        private static string newsentence;


        public static string Encode(string aString)
        {
            char[] charArray = aString.ToCharArray();
            int num;
            for (num = 0; num < charArray.Length; num++) //iterate through whole array
            {
                num2 = charArray[num] - 1; //if encoded subtract the int value of that char by one
                value = (char)num2;
                charArray[num] = value;
                newsentence = new string(charArray);
            }
            return newsentence;
        }


        
        public static string Decode(string aString)
        {
            char[] charArray = aString.ToCharArray();
            char value;
            for (int num = 0; num < charArray.Length; num++) //iterate through whole array
            {
                int num2 = charArray[num] + 1; //if encoded add the int value of that char by one
                value = (char)num2;
                charArray[num] = value;
                newsentence = new string(charArray);
            }
            return newsentence;
           
        }
        
        public static string Secret(string aString)
        {
            char[] charArray = aString.ToCharArray();
            if (charArray[0] != 'x') //decode
            {
                return DecoderRing.Decode(aString);
            }
            else //encode
            {
                return DecoderRing.Encode(aString);
            }
          
        }
        
    }
}
