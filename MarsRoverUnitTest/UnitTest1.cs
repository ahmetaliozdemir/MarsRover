using Mars;
using System;
using Xunit;

namespace MarsRoverUnitTest
{
    public class UnitTest1
    {
        Plato plato = new Plato(5, 5);

        [Fact]
        public void Gezici1()
        {
            plato.GeziciEkle(1, 2, 'N');

            plato.GeziciHareket(0, 'l');
            plato.GeziciHareket(0, 'm');
            plato.GeziciHareket(0, 'l');
            plato.GeziciHareket(0, 'm');
            plato.GeziciHareket(0, 'l');
            plato.GeziciHareket(0, 'm');
            plato.GeziciHareket(0, 'l');
            plato.GeziciHareket(0, 'm');
            string durum = plato.GeziciHareket(0, 'm');

            Assert.Equal("1,3,N", durum);
        }
        
        [Fact]
        public void Gezici2()
        {
            plato.GeziciEkle(3, 3, 'E');

            plato.GeziciHareket(0, 'm');
            plato.GeziciHareket(0, 'm');
            plato.GeziciHareket(0, 'r');
            plato.GeziciHareket(0, 'm');
            plato.GeziciHareket(0, 'm');
            plato.GeziciHareket(0, 'r');
            plato.GeziciHareket(0, 'm');
            plato.GeziciHareket(0, 'r');
            plato.GeziciHareket(0, 'r');

            string durum = plato.GeziciHareket(0, 'm');

            Assert.Equal("5,1,E", durum);
        }
    }
}
