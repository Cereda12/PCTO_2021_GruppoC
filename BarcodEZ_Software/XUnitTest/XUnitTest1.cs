using System;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;
using AForge.Video.DirectShow;
using ZXing;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Runtime.CompilerServices;

namespace XUnitTest
{
    public class XUnitTest1
    {
        /// <summary>
        /// Prova a pingare il sito di RapidApi
        /// </summary>
        [Fact]
        public void Test1()
        {
            //Arrange
            var ping = new System.Net.NetworkInformation.Ping();

            //Act
            var result = ping.Send("www.rapidapi.com");

            //Assert
            result.Status.Should().Be(System.Net.NetworkInformation.IPStatus.Success);
        }

        public class MockAPI
        {
            static Dictionary<string, string> ele = new Dictionary<string, string>()
            {
                { "9023800451279" , "B00DBU7KCM" },
                { "4006381133627" , "B00008D8X6" },
                { "4005401170020" , "B000KJRB4O" }
            };
            public static string ReqAsin(string ean)
            {
                return ele[ean];
            }
        }
        [Theory]
        [InlineData("9023800451279", "B00DBU7KCM")] // post-it
        [InlineData("4006381133627" , "B00008D8X6")] // evidenziatore
        [InlineData("4005401170020" , "B000KJRB4O")] // matita
        public void TestMock(string ean, string asin)
        {
            var ris = MockAPI.ReqAsin(ean);

            ris.Should().Be(asin);
        }

        //[Fact]
        //public void TestGallery()
        //{
        //    //Arrange
            
        //    //Act

        //    //Assert


        //    Bitmap photo;
        //    BarcodeReader reader = new BarcodeReader();
        //    var result = reader.Decode(photo);
        //    if (result != null)
        //    {
        //        pictureGallery?.Invoke(new MethodInvoker(delegate ()
        //        {
        //            txGallery.Text = result?.ToString();
        //        }));
        //        pictureGallery.Image = photo;
        //    }
            
        //}
    }
}
