using System;
using BusinessLayer;
using DataAccessLayer;
using DataAccessLayer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;
using System.Collections.Generic;

namespace BusinessLayerTests
{
    [TestClass]
    public class BLayerTests
    {
        private  Mock<PlayerRepository> mockPlayerRepository = new Mock<PlayerRepository>();
        private BLayer bLayer;
        [TestMethod]
        public void IsInsertedNewPlayer()
        {
            //Arrange
            
            Player pl = new Player
            {
                Username = "John",
                Password = "pas123",
                InGameName = "JD",
             };
            mockPlayerRepository.Setup(x => x.InsertPlayer(pl)).Returns(1);
            this.bLayer = new BLayer();
            //Act
            var result = bLayer.InsertNewPlayer(pl);
            //Assert
            Assert.IsTrue(result);
        }

       /* public void IsListReturned()
        {
            //Arrange
            var mockPlayerRepository = new Mock<PlayerRepository>();
            List<Player> playerList = new List<Player>();
            playerList.Add(new Player
            {
                Username = "John",
                Password = "pas123",
                InGameName = "JD",
            });
            playerList.Add(new Player
            {
                Username = "Tome",
                Password = "tome123",
                InGameName = "NT",
            });
            playerList.Add(new Player
            {
                Username = "Penezo",
                Password = "pen123",
                InGameName = "NP",
            });
            mockPlayerRepository.Setup(x => x.GetAllPlayers()).Returns(playerList);
            var bLayer = new BLayer();
            //Act
            var result = bLayer.GetPlayerList();
            //Assert
            Assert.AreEqual(2);
        }*/
    }
}
