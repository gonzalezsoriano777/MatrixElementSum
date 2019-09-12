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
        public void GetAllFirstAndSecondFloorRoomsWithValesSummedUp()
        {
            int roomsSummedUp = 0;

            int expectedOutput = 9;

            int[] roomsFromSecondAndThirdFloor = new int[4];

            for(int rooms = 0; rooms < matrix.GetLength(1); rooms++)
            {
               
            }
            Assert.AreEqual(roomsSummedUp, expectedOutput);
        }

        [Test]
        public void ReturnAllRoomsFromSecondAndThirdFloor()
        {
            int sum = 0;

            int expectedOutput = 13;

            for (int floor = 0; floor < matrix.GetLength(1); floor++)
            {
                for (int rooms = 0; rooms < matrix.GetLength(1); rooms++)
                {
                    if (matrix[rooms, floor] != 0)
                    {
                        sum += matrix[rooms, floor];
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Assert.AreEqual(sum, expectedOutput);

        }

    }
}