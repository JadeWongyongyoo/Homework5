using System;

namespace Code_Array
{
    class Program
    {
        static void Main(string[] args)
        { /*รับข้อมูล*/
            string image = Console.ReadLine();
            double[,] Inputarrayimage = ReadImageDataFromFile(image);

            string convolution = Console.ReadLine();
            double[,] convolutionarray = ReadImageDataFromFile(convolution);

            string output = Console.ReadLine();

            double[,] arrayrepeated = new double[7, 7];
            for (int i = 0; i < Inputarrayimage.GetLength(0); i++)
            {
                for (int j = 0; j < Inputarrayimage.GetLength(1); j++)
                {
                    arrayrepeated[i + 1, j + 1] = Inputarrayimage[i, j];
                }
            }
            arrayrepeated[1, 6] = arrayrepeated[1, 1];
            arrayrepeated[6, 1] = arrayrepeated[1, 1];
            arrayrepeated[6, 6] = arrayrepeated[1, 1];
            arrayrepeated[6, 2] = arrayrepeated[1, 2];
            arrayrepeated[6, 3] = arrayrepeated[1, 3];
            arrayrepeated[6, 4] = arrayrepeated[1, 4];
            arrayrepeated[6, 5] = arrayrepeated[1, 5];
            arrayrepeated[2, 6] = arrayrepeated[2, 1];
            arrayrepeated[3, 6] = arrayrepeated[3, 1];
            arrayrepeated[4, 6] = arrayrepeated[4, 1];
            arrayrepeated[5, 6] = arrayrepeated[5, 1];
            arrayrepeated[6, 0] = arrayrepeated[1, 5];
            arrayrepeated[0, 6] = arrayrepeated[5, 1];
            arrayrepeated[0, 0] = arrayrepeated[5, 5];
            arrayrepeated[5, 0] = arrayrepeated[5, 5];
            arrayrepeated[0, 5] = arrayrepeated[5, 5];
            arrayrepeated[0, 1] = arrayrepeated[5, 1];
            arrayrepeated[0, 2] = arrayrepeated[5, 2];
            arrayrepeated[0, 3] = arrayrepeated[5, 3];
            arrayrepeated[0, 4] = arrayrepeated[5, 4];
            arrayrepeated[0, 5] = arrayrepeated[5, 5];
            arrayrepeated[1, 0] = arrayrepeated[1, 5];
            arrayrepeated[2, 0] = arrayrepeated[2, 5];
            arrayrepeated[3, 0] = arrayrepeated[3, 5];
            arrayrepeated[4, 0] = arrayrepeated[4, 5];
            arrayrepeated[5, 0] = arrayrepeated[5, 5];

            double[,] arrayconvolve = new double[5, 5];

            arrayconvolve[0, 0] = (convolutionarray[0, 0] * arrayrepeated[0, 0]) + (convolutionarray[0, 1] * arrayrepeated[0, 1]) + (convolutionarray[0, 2] * arrayrepeated[0, 2]) +
                                  (convolutionarray[1, 0] * arrayrepeated[1, 0]) + (convolutionarray[2, 0] * arrayrepeated[2, 0]) + (convolutionarray[1, 1] * arrayrepeated[1, 1]) +
                                  (convolutionarray[1, 2] * arrayrepeated[1, 2]) + (convolutionarray[2, 1] * arrayrepeated[2, 1]) + (convolutionarray[2, 2] * arrayrepeated[2, 2]);

            arrayconvolve[0, 1] = (convolutionarray[0, 0] * arrayrepeated[0, 1]) + (convolutionarray[0, 1] * arrayrepeated[0, 2]) + (convolutionarray[0, 2] * arrayrepeated[0, 3]) +
                                  (convolutionarray[1, 0] * arrayrepeated[1, 1]) + (convolutionarray[2, 0] * arrayrepeated[2, 1]) + (convolutionarray[1, 1] * arrayrepeated[1, 2]) +
                                  (convolutionarray[1, 2] * arrayrepeated[1, 3]) + (convolutionarray[2, 1] * arrayrepeated[2, 2]) + (convolutionarray[2, 2] * arrayrepeated[2, 3]);

            arrayconvolve[0, 2] = (convolutionarray[0, 0] * arrayrepeated[0, 2]) + (convolutionarray[0, 1] * arrayrepeated[0, 3]) + (convolutionarray[0, 2] * arrayrepeated[0, 4]) +
                                  (convolutionarray[1, 0] * arrayrepeated[1, 2]) + (convolutionarray[2, 0] * arrayrepeated[2, 2]) + (convolutionarray[1, 1] * arrayrepeated[1, 3]) +
                                  (convolutionarray[1, 2] * arrayrepeated[1, 4]) + (convolutionarray[2, 1] * arrayrepeated[2, 3]) + (convolutionarray[2, 2] * arrayrepeated[2, 4]);

            arrayconvolve[0, 3] = (convolutionarray[0, 0] * arrayrepeated[0, 3]) + (convolutionarray[0, 1] * arrayrepeated[0, 4]) + (convolutionarray[0, 2] * arrayrepeated[0, 5]) +
                                  (convolutionarray[1, 0] * arrayrepeated[1, 3]) + (convolutionarray[2, 0] * arrayrepeated[2, 3]) + (convolutionarray[1, 1] * arrayrepeated[1, 4]) +
                                  (convolutionarray[1, 2] * arrayrepeated[1, 5]) + (convolutionarray[2, 1] * arrayrepeated[2, 4]) + (convolutionarray[2, 2] * arrayrepeated[2, 5]);

            arrayconvolve[0, 4] = (convolutionarray[0, 0] * arrayrepeated[0, 4]) + (convolutionarray[0, 1] * arrayrepeated[0, 5]) + (convolutionarray[0, 2] * arrayrepeated[0, 6]) +
                                  (convolutionarray[1, 0] * arrayrepeated[1, 4]) + (convolutionarray[2, 0] * arrayrepeated[2, 4]) + (convolutionarray[1, 1] * arrayrepeated[1, 5]) +
                                  (convolutionarray[1, 2] * arrayrepeated[1, 6]) + (convolutionarray[2, 1] * arrayrepeated[2, 5]) + (convolutionarray[2, 2] * arrayrepeated[2, 6]);

            arrayconvolve[1, 0] = (convolutionarray[0, 0] * arrayrepeated[1, 0]) + (convolutionarray[0, 1] * arrayrepeated[1, 1]) + (convolutionarray[0, 2] * arrayrepeated[1, 2]) +
                                  (convolutionarray[1, 0] * arrayrepeated[2, 0]) + (convolutionarray[2, 0] * arrayrepeated[3, 0]) + (convolutionarray[1, 1] * arrayrepeated[2, 1]) +
                                  (convolutionarray[1, 2] * arrayrepeated[2, 2]) + (convolutionarray[2, 1] * arrayrepeated[3, 1]) + (convolutionarray[2, 2] * arrayrepeated[3, 2]);

            arrayconvolve[2, 0] = (convolutionarray[0, 0] * arrayrepeated[2, 0]) + (convolutionarray[0, 1] * arrayrepeated[2, 1]) + (convolutionarray[0, 2] * arrayrepeated[2, 2]) +
                                  (convolutionarray[1, 0] * arrayrepeated[3, 0]) + (convolutionarray[2, 0] * arrayrepeated[4, 0]) + (convolutionarray[1, 1] * arrayrepeated[3, 1]) +
                                  (convolutionarray[1, 2] * arrayrepeated[3, 2]) + (convolutionarray[2, 1] * arrayrepeated[4, 1]) + (convolutionarray[2, 2] * arrayrepeated[4, 2]);

            arrayconvolve[3, 0] = (convolutionarray[0, 0] * arrayrepeated[3, 0]) + (convolutionarray[0, 1] * arrayrepeated[3, 1]) + (convolutionarray[0, 2] * arrayrepeated[3, 2]) +
                                  (convolutionarray[1, 0] * arrayrepeated[4, 0]) + (convolutionarray[2, 0] * arrayrepeated[5, 0]) + (convolutionarray[1, 1] * arrayrepeated[4, 1]) +
                                  (convolutionarray[1, 2] * arrayrepeated[4, 2]) + (convolutionarray[2, 1] * arrayrepeated[5, 1]) + (convolutionarray[2, 2] * arrayrepeated[5, 2]);

            arrayconvolve[4, 0] = (convolutionarray[0, 0] * arrayrepeated[4, 0]) + (convolutionarray[0, 1] * arrayrepeated[4, 1]) + (convolutionarray[0, 2] * arrayrepeated[4, 2]) +
                                  (convolutionarray[1, 0] * arrayrepeated[5, 0]) + (convolutionarray[2, 0] * arrayrepeated[6, 0]) + (convolutionarray[1, 1] * arrayrepeated[5, 1]) +
                                  (convolutionarray[1, 2] * arrayrepeated[5, 2]) + (convolutionarray[2, 1] * arrayrepeated[6, 1]) + (convolutionarray[2, 2] * arrayrepeated[6, 2]);

            arrayconvolve[1, 1] = (convolutionarray[0, 0] * arrayrepeated[1, 1]) + (convolutionarray[0, 1] * arrayrepeated[1, 2]) + (convolutionarray[0, 2] * arrayrepeated[1, 3]) +
                                  (convolutionarray[1, 0] * arrayrepeated[2, 1]) + (convolutionarray[2, 0] * arrayrepeated[3, 1]) + (convolutionarray[1, 1] * arrayrepeated[2, 2]) +
                                  (convolutionarray[1, 2] * arrayrepeated[2, 3]) + (convolutionarray[2, 1] * arrayrepeated[3, 2]) + (convolutionarray[2, 2] * arrayrepeated[3, 3]);

            arrayconvolve[1, 2] = (convolutionarray[0, 0] * arrayrepeated[1, 2]) + (convolutionarray[0, 1] * arrayrepeated[1, 3]) + (convolutionarray[0, 2] * arrayrepeated[1, 4]) +
                                 (convolutionarray[1, 0] * arrayrepeated[2, 2]) + (convolutionarray[2, 0] * arrayrepeated[3, 2]) + (convolutionarray[1, 1] * arrayrepeated[2, 3]) +
                                 (convolutionarray[1, 2] * arrayrepeated[2, 4]) + (convolutionarray[2, 1] * arrayrepeated[3, 3]) + (convolutionarray[2, 2] * arrayrepeated[3, 4]);

            arrayconvolve[1, 3] = (convolutionarray[0, 0] * arrayrepeated[1, 3]) + (convolutionarray[0, 1] * arrayrepeated[1, 4]) + (convolutionarray[0, 2] * arrayrepeated[1, 5]) +
                                 (convolutionarray[1, 0] * arrayrepeated[2, 3]) + (convolutionarray[2, 0] * arrayrepeated[3, 3]) + (convolutionarray[1, 1] * arrayrepeated[2, 4]) +
                                 (convolutionarray[1, 2] * arrayrepeated[2, 5]) + (convolutionarray[2, 1] * arrayrepeated[3, 4]) + (convolutionarray[2, 2] * arrayrepeated[3, 5]);

            arrayconvolve[1, 4] = (convolutionarray[0, 0] * arrayrepeated[1, 4]) + (convolutionarray[0, 1] * arrayrepeated[1, 5]) + (convolutionarray[0, 2] * arrayrepeated[1, 6]) +
                                 (convolutionarray[1, 0] * arrayrepeated[2, 4]) + (convolutionarray[2, 0] * arrayrepeated[3, 4]) + (convolutionarray[1, 1] * arrayrepeated[2, 5]) +
                                 (convolutionarray[1, 2] * arrayrepeated[2, 6]) + (convolutionarray[2, 1] * arrayrepeated[3, 5]) + (convolutionarray[2, 2] * arrayrepeated[3, 6]);

            arrayconvolve[2, 1] = (convolutionarray[0, 0] * arrayrepeated[2, 1]) + (convolutionarray[0, 1] * arrayrepeated[2, 2]) + (convolutionarray[0, 2] * arrayrepeated[2, 3]) +
                                  (convolutionarray[1, 0] * arrayrepeated[3, 1]) + (convolutionarray[2, 0] * arrayrepeated[4, 1]) + (convolutionarray[1, 1] * arrayrepeated[3, 2]) +
                                  (convolutionarray[1, 2] * arrayrepeated[3, 3]) + (convolutionarray[2, 1] * arrayrepeated[4, 2]) + (convolutionarray[2, 2] * arrayrepeated[4, 3]);

            arrayconvolve[2, 2] = (convolutionarray[0, 0] * arrayrepeated[2, 2]) + (convolutionarray[0, 1] * arrayrepeated[2, 3]) + (convolutionarray[0, 2] * arrayrepeated[2, 4]) +
                                  (convolutionarray[1, 0] * arrayrepeated[3, 2]) + (convolutionarray[2, 0] * arrayrepeated[4, 2]) + (convolutionarray[1, 1] * arrayrepeated[3, 3]) +
                                  (convolutionarray[1, 2] * arrayrepeated[3, 4]) + (convolutionarray[2, 1] * arrayrepeated[4, 3]) + (convolutionarray[2, 2] * arrayrepeated[4, 4]);

            arrayconvolve[2, 3] = (convolutionarray[0, 0] * arrayrepeated[2, 3]) + (convolutionarray[0, 1] * arrayrepeated[2, 4]) + (convolutionarray[0, 2] * arrayrepeated[2, 5]) +
                                  (convolutionarray[1, 0] * arrayrepeated[3, 3]) + (convolutionarray[2, 0] * arrayrepeated[4, 3]) + (convolutionarray[1, 1] * arrayrepeated[3, 4]) +
                                  (convolutionarray[1, 2] * arrayrepeated[3, 5]) + (convolutionarray[2, 1] * arrayrepeated[4, 4]) + (convolutionarray[2, 2] * arrayrepeated[4, 5]);

            arrayconvolve[2, 4] = (convolutionarray[0, 0] * arrayrepeated[2, 4]) + (convolutionarray[0, 1] * arrayrepeated[2, 5]) + (convolutionarray[0, 2] * arrayrepeated[2, 6]) +
                                  (convolutionarray[1, 0] * arrayrepeated[3, 4]) + (convolutionarray[2, 0] * arrayrepeated[4, 4]) + (convolutionarray[1, 1] * arrayrepeated[3, 5]) +
                                  (convolutionarray[1, 2] * arrayrepeated[3, 6]) + (convolutionarray[2, 1] * arrayrepeated[4, 5]) + (convolutionarray[2, 2] * arrayrepeated[4, 6]);

            arrayconvolve[3, 1] = (convolutionarray[0, 0] * arrayrepeated[3, 1]) + (convolutionarray[0, 1] * arrayrepeated[3, 2]) + (convolutionarray[0, 2] * arrayrepeated[3, 3]) +
                                  (convolutionarray[1, 0] * arrayrepeated[4, 1]) + (convolutionarray[2, 0] * arrayrepeated[4, 2]) + (convolutionarray[1, 1] * arrayrepeated[4, 2]) +
                                  (convolutionarray[1, 2] * arrayrepeated[4, 3]) + (convolutionarray[2, 1] * arrayrepeated[5, 2]) + (convolutionarray[2, 2] * arrayrepeated[5, 3]);

            arrayconvolve[3, 2] = (convolutionarray[0, 0] * arrayrepeated[3, 2]) + (convolutionarray[0, 1] * arrayrepeated[3, 3]) + (convolutionarray[0, 2] * arrayrepeated[3, 4]) +
                                  (convolutionarray[1, 0] * arrayrepeated[4, 2]) + (convolutionarray[2, 0] * arrayrepeated[4, 3]) + (convolutionarray[1, 1] * arrayrepeated[4, 3]) +
                                  (convolutionarray[1, 2] * arrayrepeated[4, 4]) + (convolutionarray[2, 1] * arrayrepeated[5, 3]) + (convolutionarray[2, 2] * arrayrepeated[5, 4]);

            arrayconvolve[3, 3] = (convolutionarray[0, 0] * arrayrepeated[3, 3]) + (convolutionarray[0, 1] * arrayrepeated[3, 4]) + (convolutionarray[0, 2] * arrayrepeated[3, 5]) +
                                  (convolutionarray[1, 0] * arrayrepeated[4, 3]) + (convolutionarray[2, 0] * arrayrepeated[4, 4]) + (convolutionarray[1, 1] * arrayrepeated[4, 4]) +
                                  (convolutionarray[1, 2] * arrayrepeated[4, 5]) + (convolutionarray[2, 1] * arrayrepeated[5, 4]) + (convolutionarray[2, 2] * arrayrepeated[5, 5]);

            arrayconvolve[3, 4] = (convolutionarray[0, 0] * arrayrepeated[3, 4]) + (convolutionarray[0, 1] * arrayrepeated[3, 5]) + (convolutionarray[0, 2] * arrayrepeated[3, 6]) +
                                  (convolutionarray[1, 0] * arrayrepeated[4, 4]) + (convolutionarray[2, 0] * arrayrepeated[4, 5]) + (convolutionarray[1, 1] * arrayrepeated[4, 5]) +
                                  (convolutionarray[1, 2] * arrayrepeated[4, 6]) + (convolutionarray[2, 1] * arrayrepeated[5, 5]) + (convolutionarray[2, 2] * arrayrepeated[5, 6]);

            arrayconvolve[4, 1] = (convolutionarray[0, 0] * arrayrepeated[4, 1]) + (convolutionarray[0, 1] * arrayrepeated[4, 2]) + (convolutionarray[0, 2] * arrayrepeated[4, 3]) +
                                  (convolutionarray[1, 0] * arrayrepeated[5, 1]) + (convolutionarray[2, 0] * arrayrepeated[6, 1]) + (convolutionarray[1, 1] * arrayrepeated[5, 2]) +
                                  (convolutionarray[1, 2] * arrayrepeated[5, 3]) + (convolutionarray[2, 1] * arrayrepeated[6, 2]) + (convolutionarray[2, 2] * arrayrepeated[6, 3]);

            arrayconvolve[4, 2] = (convolutionarray[0, 0] * arrayrepeated[4, 2]) + (convolutionarray[0, 1] * arrayrepeated[4, 3]) + (convolutionarray[0, 2] * arrayrepeated[4, 4]) +
                                  (convolutionarray[1, 0] * arrayrepeated[5, 2]) + (convolutionarray[2, 0] * arrayrepeated[6, 2]) + (convolutionarray[1, 1] * arrayrepeated[5, 3]) +
                                  (convolutionarray[1, 2] * arrayrepeated[5, 4]) + (convolutionarray[2, 1] * arrayrepeated[6, 3]) + (convolutionarray[2, 2] * arrayrepeated[6, 4]);

            arrayconvolve[4, 3] = (convolutionarray[0, 0] * arrayrepeated[4, 3]) + (convolutionarray[0, 1] * arrayrepeated[4, 4]) + (convolutionarray[0, 2] * arrayrepeated[4, 5]) +
                                  (convolutionarray[1, 0] * arrayrepeated[5, 3]) + (convolutionarray[2, 0] * arrayrepeated[6, 2]) + (convolutionarray[1, 1] * arrayrepeated[5, 4]) +
                                  (convolutionarray[1, 2] * arrayrepeated[5, 5]) + (convolutionarray[2, 1] * arrayrepeated[6, 4]) + (convolutionarray[2, 2] * arrayrepeated[6, 5]);

            arrayconvolve[4, 4] = (convolutionarray[0, 0] * arrayrepeated[4, 1]) + (convolutionarray[0, 1] * arrayrepeated[4, 2]) + (convolutionarray[0, 2] * arrayrepeated[4, 3]) +
                                  (convolutionarray[1, 0] * arrayrepeated[5, 1]) + (convolutionarray[2, 0] * arrayrepeated[6, 1]) + (convolutionarray[1, 1] * arrayrepeated[5, 2]) +
                                  (convolutionarray[1, 2] * arrayrepeated[5, 3]) + (convolutionarray[2, 1] * arrayrepeated[6, 2]) + (convolutionarray[2, 2] * arrayrepeated[6, 3]);

            WriteImageDataToFile(output, arrayconvolve);
        }
        static double[,] ReadImageDataFromFile(string imageDataFilePath)
        {
            string[] lines = System.IO.File.ReadAllLines(imageDataFilePath);
            int imageHeight = lines.Length;
            int imageWidth = lines[0].Split(',').Length;
            double[,] imageDataArray = new double[imageHeight, imageWidth];

            for (int i = 0; i < imageHeight; i++)
            {
                string[] items = lines[i].Split(',');
                for (int j = 0; j < imageWidth; j++)
                {
                    imageDataArray[i, j] = double.Parse(items[j]);
                }
            }
            return imageDataArray;
        }
        static void WriteImageDataToFile(string imageDataFilePath,
                                 double[,] imageDataArray)
        {
            string imageDataString = "";
            for (int i = 0; i < imageDataArray.GetLength(0); i++)
            {
                for (int j = 0; j < imageDataArray.GetLength(1) - 1; j++)
                {
                    imageDataString += imageDataArray[i, j] + ", ";
                }
                imageDataString += imageDataArray[i,
                                                imageDataArray.GetLength(1) - 1];
                imageDataString += "\n";
            }

            System.IO.File.WriteAllText(imageDataFilePath, imageDataString);
        }


    }
}
