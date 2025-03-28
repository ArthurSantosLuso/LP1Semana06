using System;
using System.Net.NetworkInformation;
using Humanizer;

namespace MyRPG
{
    public class GameLevel
    {
        private Enemy[] rooms;
        private Hardness difficulty;

        public GameLevel(int numberOfRooms, Hardness difficulty)
        {
            rooms = new Enemy[numberOfRooms];
            this.difficulty = difficulty;
        }

        public void SetEnemyInRoom(int roomIndex, Enemy enemy)
        {
            if (roomIndex < 0 || roomIndex >= rooms.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(roomIndex), "Room index out of bounds");
            }
            rooms[roomIndex] = enemy;
        }
    }
}
