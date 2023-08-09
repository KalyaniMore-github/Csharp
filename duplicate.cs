//using system;
//using system.collections.generic;
//using system.linq;
//using system.text;
//using system.threading.tasks;

//namespace consoleapp5
//{
//    class duplicate
//    {
//        static void main(string[] args)
//        {
//            int i = 0, j = 0;
//            int[] arr1 = new int[] { 7, 7, 8, 8, 9, 1, 1, 4, 2, 2 };
//            for (i = 0; i < arr1.length; i++)
//            {
//                for (j = 0; j < arr1.length; j++)
//                {
//                    if (i == j)
//                        continue;
//                    if (arr1[j] == arr1[i])
//                        break;
//                }
//                if (arr1.length == j)
//                {
//                    console.write(arr1[i] + " ");
//                }
//            }
//        }
//    }
//}
