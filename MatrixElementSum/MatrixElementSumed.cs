using NUnit.Framework;
using System;

namespace Matrix
{
    public class MatrixElementSumed
    {
        int[,] matrix = new int[,] { { 0, 1, 1, 2 }, { 0, 5, 0, 0 }, { 2, 0, 3, 3 } };

        [Test]
        public void ReturnTheFirstRowsRoom()
        {
            int[,] output = new int[,] { { 0, 1, 1, 2 } };

            Assert.AreEqual(matrix[0, 3], output[0, 3]);
        }
        
        [Test]
        public void GetAllFloorRoomsWithValesSummedUp()
        {

            int roomsSummedUp = 0;

            int expectedOutput = 9;

            for(int floor = 0; floor < matrix.GetLength(1); floor++)
            {
                for (int room = 0; room < matrix.GetLength(1); room++)
                {
                    if (matrix[room, floor] != 0)
                    {
                        roomsSummedUp += matrix[room, floor];
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Assert.AreEqual(roomsSummedUp, expectedOutput);
        }
    }
}