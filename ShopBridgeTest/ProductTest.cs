using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ShopBridgeTest
{
    [TestClass]
    public class UnitTest1
    {
        ProductController _controller;

        public UnitTest1() 
        {
            _controller = new ProductController();
        }

        //returns ok result
        [Fact]
        public void GetAll_test()
        {
            // Act
            var okResult = _controller.Get();
            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        //returns right item
        [Fact]
        public void GetById_test()
        {
            // Arrange
            var testGuid = new Guid("1");
            // Act
            var okResult = _controller.Get(testGuid).Result as OkObjectResult;
            // Assert
            Assert.IsType<Product>(okResult.Value);
            Assert.Equal(testGuid, (okResult.Value as Product).Id);
        }

        //returns response created oject
        [Fact]
        public void Add_test()
        {
            // Arrange
            var testItem = new Product()
            {
                Name = "Chair",
                Description = "Useful",
                Price = 1200,
                Quantity = 10
            };
            // Act
            var createdResponse = _controller.Post(testItem) as CreatedAtActionResult;
            var item = createdResponse.Value as Product;
            // Assert
            Assert.IsType<Product>(item);
            Assert.Equal("Chair", item.Name);
        }
        
        //if exixting id passed it will return ok result
        [Fact]
        public void Delete_test()
        {
            // Arrange
            var existingGuid = new Guid(1);
            // Act
            var okResponse = _controller.Remove(existingGuid);
            // Assert
            Assert.IsType<OkResult>(okResponse);
        }



    }
}
