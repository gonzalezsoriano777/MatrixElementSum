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

            for (int floor = 0; floor < matrix.GetLength(1); floor++)
            {
                for (int room = 0; room < matrix.Length; room++)
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


        [Test]
        public void ReturnAllRoomsFromSecondAndThirdFloor()
        {
            int[][] matrixVersionTwo = new int[3][];

            matrixVersionTwo[0] = new int[] { 0, 1, 1, 2 };
            matrixVersionTwo[1] = new int[] { 0, 5, 0, 0 };
            matrixVersionTwo[2] = new int[] { 2, 0, 3, 3 };

            int sum = 0;

            int expectedOutput = 13;

            for (int floor = 1; floor < 3; floor++)
            {
                for (int rooms = 0; rooms < matrixVersionTwo[floor].Length; rooms++)
                {
                    sum += matrixVersionTwo[floor][rooms];
                }
            }
            
            Assert.AreEqual(sum, expectedOutput);
        }
        
        [Test]
        public void ReturnTheSummedValueOfRoomsThatAreAvailableInEachFloor()
        {
            int[][] matrixVersionThree = new int[3][];

            matrixVersionThree[0] = new int[] { 0, 1, 1, 2 };
            matrixVersionThree[1] = new int[] { 0, 5, 0, 0 };
            matrixVersionThree[2] = new int[] { 2, 0, 3, 3 };

            int sumOfRooms = 0;

            int expectedResult = 17;

            for (int floor = 0; floor < 3; floor++)
            {
                for (int rooms = 0; rooms < matrixVersionThree[floor].Length; rooms++)
                {
                    sumOfRooms += matrixVersionThree[floor][rooms];
                }
            }

            Assert.AreEqual(sumOfRooms, expectedResult);
        }
    }
}